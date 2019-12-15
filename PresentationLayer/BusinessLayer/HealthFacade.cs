using BusinessLayer.Services;
using DataLayer.Model;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{

    //TODO remove it to data layer
    public static class visitTypes
    {
        public const int assessment = 0;
        public const int medication = 1;
        public const int bath = 2;
        public const int meal = 3;
    }
    public class HealthFacade
    {
        StaffService Service = new StaffService();

        public Boolean addStaff(int id, string firstName, string surname, string address1, string address2, string category, double baseLocLat, double baseLocLon)
        {
            Staff Staff = new Staff
            {
                id = id,
                firstName = firstName,
                surname = surname,
                address1 = address1,
                address2 = address2,
                category = category,
                baseLocLat = baseLocLat,
                baseLocLon = baseLocLon
            };
            return Service.AddStaff(Staff);
        }

        public List<Staff> getStaffList()
        {
            return Service.StaffList;
        }

       

        public Boolean addClient(int id, string firstName, string surname, string address1, string address2, double locLat, double locLon)
        {
            Client Client = new Client
            {
                id = id,
                firstName = firstName,
                surname = surname,
                address1 = address1,
                address2 = address2,
                locLat = locLat,
                locLon = locLon
            };
              
            return Client(Client);
        }
        public List<Client> getClientList()
        {
            return ClientList;
        }

        //public Boolean addVisit(int[] staff, int patient, int type, string dateTime)
        //{
        //    NewVisit newVisit = new NewVisit(staff, patient, type, dateTime);
        //    if (!allData.StaffValid(newStaff))
        //    { 
        //    throw new Exception("Error - This person doesn't exist as part of Staff\n");
        //    }
        //    if (!allData.ClienValid(newClient))
        //    {
        //        throw new Exception("Error - This person doesn't exist as part of Client\n");
        //    }
        //    if (!allData.addVisit(newVisit))
        //    {
        //        throw new Exception("Error - This data doesn't exist");
        //    }
        //    //If no errors thrown, assum OK
        //    return true;
        //}



        //public String getClientList()
        //{
        //    return allData.printClientMembers();
        //}

        //public String getVisitList()
        //{
        //    return allData.printVisits;
        //}


        //public void clear()
        //{

        //}


        //public Boolean load()
        //{
        //    allData.Load();
        //    return false;
        //}

        //public bool save()
        //{
        //    allData.Save();
        //    return false;
        //}

    }
}
