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
        

        public JsonResult GetCSVData()
        {
            string path = Server.MapPath("~/Content/Univ.csv");
            string csvData = System.IO.File.ReadAllText(path);
            string state;
            List<University> lstUniversity = new List<University>();
            //Execute a loop over the rows.
            string[] sCSVData = csvData.Split('\n');
            for (int iCount = 1; iCount < sCSVData.Length - 1; iCount++)
            {
                state = sCSVData[iCount].Split(',')[4];
                //Only get results for KY schools
                if (state == "\"KY\"")
                {
                    lstUniversity.Add(new University
                    {
                //Get relevant data from csv file
                        InstName = sCSVData[iCount].Split(',')[1],
                        ChfName = sCSVData[iCount].Split(',')[8],
                        ChfTitle = sCSVData[iCount].Split(',')[9],
                        PhNum = sCSVData[iCount].Split(',')[10],
                        WebAdd = sCSVData[iCount].Split(',')[15]
                    });
                }
            }

            return Json(lstUniversity, JsonRequestBehavior.AllowGet);

        }

        public ActionResult Index()
        { 
            return View();
        }

        
    }


}