using BusinessLayer.Interfaces;
using DataLayer.Model;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class StaffService : IStaffService
    {
        public List<Staff> StaffList { get; set; }
        public StaffService()
        {
            StaffList = new List<Staff>();
        }
        public bool AddStaff(Staff newStaff)
        {
            
            try
            {
                StaffList.Add(newStaff);
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }
    }
}
