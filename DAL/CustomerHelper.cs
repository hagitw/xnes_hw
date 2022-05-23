using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using xnes_hw.Models;

namespace xnes_hw.DAL
{
    public static class CustomerHelper
    {
        private static XnesDbContext XnesDb = new XnesDbContext();
        public static List<Customer> GetCustomers()
        {
            try
            {//TODO:
                //return XnesDb.Customers.ToList();
                var Customers = XnesDb.Database.ExecuteSqlCommand("EXEC GetCustomers");
                return null; // Customers.    
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public static bool AddCustomers(Customer newCustomer)
        {
            try
            {
                XnesDb.Customers.Add(newCustomer);
                XnesDb.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                // return null;
            }

        }
        public static List<City> GetCities()
        {
            return XnesDb.Cities.ToList();

        }
    }
}