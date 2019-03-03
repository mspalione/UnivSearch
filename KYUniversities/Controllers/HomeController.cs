using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KYUniversities.Models;

namespace KYUniversities.Controllers
{
    public class HomeController : Controller
    {

        public string path => Server.MapPath("~/Content/Univ.csv");

        public List<University> GetCSVData()
        {
            string csvData = System.IO.File.ReadAllText(path);
            string state;
            List<University> lstUniversity = new List<University>();
            //Execute a loop over the rows.
            string[] sCSVData = csvData.Split('\n');
            for (int iCount = 1; iCount < sCSVData.Length - 1; iCount++)
            {
                state = sCSVData[iCount].Split(',')[4];
                //Only get results for KY schools
                if ((state == "\"KY\"") || (state == "KY"))
                {
                    var data = sCSVData[iCount].Split(',');
                    lstUniversity.Add(new University
                    {
                        //Get relevant data from csv file
                        InstName = data[1],
                        ChfName = data[8],
                        ChfTitle = data[9],
                        PhNum = data[10],
                        WebAdd = data[15]
                    });
                }
            }
            //return Json(lstUniversity, JsonRequestBehavior.AllowGet);
            return lstUniversity;
        }

        [HttpGet]
        public ActionResult Index()
        {
            this.ViewData["universities"] = GetCSVData();

            var form = new FormModel
            {
                State = "KY"
            };

            return View(form);
        }

        [HttpPost]
        public ActionResult Index(FormModel vm)
        {
            var newItems = new List<string>();
            //var path = Server.MapPath("~/Content/Univ.csv");            

            newItems.Add($" ,{vm.Institution},,,{vm.State},,,,{vm.Headname},{vm.Headtitle},{vm.Phone},,,,,{vm.Website}");

            System.IO.File.AppendAllLines(path, newItems);
            this.ViewData["universities"] = GetCSVData();

            ModelState.Clear();

            var form = new FormModel
            {
                State = "KY"
            };

            return View(form);
        }     
    }
}