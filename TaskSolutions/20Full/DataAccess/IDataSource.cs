using _20Full.Models;
using System.Collections.Generic;

namespace _20Full.DataAccess
{
    internal interface IDataSource
    {
        List<Hand> LoadHands();
        void SaveHands(List<Hand> hands);
    }
}