using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{

    public static class visitTypes
    {
        public const int assessment = 0;
        public const int medication = 1;
        public const int bath = 2;
        public const int meal = 3;

    }
    public class HealthFacade
    {

        private allData allData = new allData();

        public Boolean addStaff(int id, string firstName, string surname, string address1, string address2, string category, double baseLocLat, double baseLocLon)
        {
            NewStaff newStaff = new NewStaff{
                id = id,
                firstName = firstName,
                surname = surname,
                address1 = address1,
                address2 = address2,
                category = category,
                baseLocLat = baseLocLat,
                baseLocLon = baseLocLon
            };
            return allData.addStaff(newStaff);
        }

        public List<NewStaff> getStaffList()
        {
            return allData.Staff;
        }


        //public Boolean addClient(int id, string firstName, string surname, string address1, string address2, double locLat, double locLon)
        //{
        //    NewClient newClient = new NewClient( id, firstName, surname, address1, address2, locLat, locLon);


        //    return allData.newClientPerson(newClient);
        //}

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
