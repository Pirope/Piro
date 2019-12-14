using DataLayer.Model;
using System.Collections.Generic;

namespace DataLayer
{
    public class allData
    {
        public List<NewStaff> Staff { get; set; }
        public allData()
        {
            Staff = new List<NewStaff>();
        }
        public bool addStaff(NewStaff ns)
        {
            try
            {
                Staff.Add(ns);
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }
    }
}
