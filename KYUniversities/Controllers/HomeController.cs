﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KYUniversities.Models;

namespace KYUniversities.Controllers
{
    public class HomeController : Controller
    {
        public List<University> GetCSVData()
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
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormModel vm)
        {
            var newItems = new List<string>();
            var path = Server.MapPath("~/Content/Univ.csv");
            var states = GetAllStates();
            var States = GetSelectListItems(states);
            this.ViewData["universities"] = GetCSVData();

            newItems.Add($" ,{vm.Institution},,,{vm.State},,,,{vm.Headname}, {vm.Headtitle}, {vm.Phone},,,,, {vm.Website}");

            System.IO.File.AppendAllLines(path, newItems);
            //System.Threading.Thread.Sleep(1000);

            return View();
        }

        private IEnumerable<string> GetAllStates()
        {
            return new List<string>
            {
                "KY",
            };
        }

        private IEnumerable<SelectListItem> GetSelectListItems(IEnumerable<string> elements)
        {
            // Create an empty list to hold result of the operation
            var selectList = new List<SelectListItem>();

            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element,
                    Text = element
                });
            }

            return selectList;
        }
    }
}