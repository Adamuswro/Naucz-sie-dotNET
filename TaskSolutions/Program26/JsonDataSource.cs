using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace _26BeautySalon
{
    class JsonDataSource : IDataSource
    {
        private string fileName = "Customers.json";

        public List<Customer> GetAllCustomers()
        {
            System.Console.WriteLine("ALL CUSTOMERS");
            throw new System.NotImplementedException();
        }

        public void SaveCustomer(Customer newCustomer)
        {
            System.Console.WriteLine("SAVE CUSTOMER");
            throw new System.NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            System.Console.WriteLine("UPDATE CUSTOMER");
            throw new System.NotImplementedException();
        }



        /*public void AddIds(List<string> id)
        {
            var Ids = GetAllIds();

            if (Ids == null)
            {
                Ids = new List<string>();
            }

            Ids.AddRange(id);

            using (StreamWriter file = File.CreateText(fileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, Ids);
            }
        }

        public List<string> GetAllIds()
        {
            var result = new List<string>();
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                result = JsonConvert.DeserializeObject<List<string>>(json);

                result = JsonConvert.DeserializeObject<List<string>>(json);
            }
            return result;
        }

        public void RemoveId(string id)
        {
            var allIds = GetAllIds();
            if (allIds.Remove(id) == false)
            {
                return;
            }

            AddIds(allIds);
        }*/
    }
}
