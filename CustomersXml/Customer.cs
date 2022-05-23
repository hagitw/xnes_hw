using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersXml
{
    public class Customer
    {
        public int Id { get; set; }    
        public string HebrewName { get; set; }
        public string EnglishName { get; set; }
        public DateTime BirthDate { get; set; }
        public int CustomerId { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public string Bank { get; set; }
        public string BankBranch { get; set; }
        public int BankAccount { get; set; }

    }
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
