using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.Tree
{
    class ContentItem : IItem
    {
        List<IItem> items = new List<IItem>();

        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            items.Remove(item);
        }
    }
}