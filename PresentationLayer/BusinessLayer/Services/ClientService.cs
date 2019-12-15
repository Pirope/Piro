using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class ClientService
    {
        public List<Client> ClientList { get; set; }
        public ClientService()
        {
            ClientList = new List<Client>();
        }

        public bool AddClient(Client newClient)
        {
            try
            {
                ClientList.Add(newClient);
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }
    }
}
