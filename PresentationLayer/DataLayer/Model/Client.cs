using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Model
{
    public class Client
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string surname { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public double locLat { get; set; }
        public double locLon { get; set; }
    }
}
