using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25FactoryMethod
{
    public interface IDocument
    {
        void Print();
        List<Page> Pages { get; set; }
    }
}
