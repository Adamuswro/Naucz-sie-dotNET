using System.Collections.Generic;
using System.IO;
using _20Full.Models;
using Newtonsoft.Json;

namespace _20Full.DataAccess
{
    class JsonDataSource : IDataSource
    {
        private string fileName = "Hands.json";

        public List<Hand> LoadHands()
        {
            var result = new List<Hand>();
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                result = JsonConvert.DeserializeObject<List<Hand>>(json);
            }
            return result;
        }

        public void SaveHands(List<Hand> hands)
        {
            using (StreamWriter file = File.CreateText(fileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, hands);
            }
        }
    }
}
