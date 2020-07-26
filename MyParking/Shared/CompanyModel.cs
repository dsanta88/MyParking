using System;
using System.Collections.Generic;
using System.Text;

namespace MyParking.Shared
{
   public class CompanyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Logo { get; set; }
        public int CityId { get; set; }
    }
}
