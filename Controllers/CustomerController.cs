using NLog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using xnes_hw.DAL;
using xnes_hw.Models;

namespace xnes_hw.Controllers
{
   

    public class CustomerController : Controller
    {
        Logger log = LogManager.GetCurrentClassLogger();

        XnesDbContext XnesDb = new XnesDbContext();
        BankService BankService = new BankService();
        public ActionResult Index()
        {
            if (!ReadConfiguration()) 
            {
                return View("Error");
            } 
            List<City> cities = CustomerHelper.GetCities();
            List<Bank> banks = BankService.GetBanks();
            List<BankBranch> bankBranches = BankService.GetBankBranchs();

            var li = new SelectList(cities, "Code", "Description");
            var libanks = new SelectList(banks, "Code", "Description");
            
            FormModel formModel =new FormModel();
            formModel.Cities = new SelectList(cities, "Id", "Name");
            formModel.Banks = new SelectList(banks, "Code", "Description");
            formModel.BankBranches = new SelectList(bankBranches, "BranchNumber", "BranchName");

            return View(formModel);
        }
       

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Index(FormModel formModel)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

     
        //for test
        public ActionResult New()
        {
            XnesDb.Cities.Add(new Models.City { Name = "חיפה" });
            return View();
        }

        public ActionResult CustomersList()
        {
         
            return View(XnesDb.Customers);
        }

        private bool ReadConfiguration() 
        {

            try
            {
                log.Info("vc");
                Common.BankApi = ConfigurationManager.AppSettings["BankApi"];

            }
            catch (Exception e)
            {

                return false;
            }
            return true;
        }
        public bool CheckValues(string val)
        {
            return !string.IsNullOrEmpty(val);
        }
      
    }
}
