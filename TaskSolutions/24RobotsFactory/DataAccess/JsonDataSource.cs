using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace _24RobotsFactory.DataSource
{
    class JsonDataSource : IDataSource
    {
        private string fileName = "Ids.json";

        public void AddId(string id)
        {
            AddIds(new List<string>() { id });
        }

        public void AddIds(List<string> id)
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
        }
    }
}
