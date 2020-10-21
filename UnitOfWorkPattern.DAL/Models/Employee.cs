using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWorkPattern.DAL.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime HireDate { get; set; }        
    }
}
