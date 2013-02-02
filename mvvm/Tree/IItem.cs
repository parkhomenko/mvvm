using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.Tree
{
    interface IItem
    {
        void AddItem(IItem item) { throw new Exception("Not supported"); }
        void RemoveItem(IItem item) { throw new Exception("Not supported"); }

        string SomeName { get; set; }
        string SomeDescription { get; set; }
    }
}