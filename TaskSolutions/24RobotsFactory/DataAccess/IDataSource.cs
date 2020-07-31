using _24RobotsFactory;
using System.Collections.Generic;

namespace _24RobotsFactory.DataSource
{
    public interface IDataSource
    {
        List<string> GetAllIds();
        void AddIds(List<string> id);
        void AddId(string id);
        void RemoveId(string id);
    }
}