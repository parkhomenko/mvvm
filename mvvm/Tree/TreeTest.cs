using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.Tree
{
    class TreeTest
    {
        public TreeTest()
        {
            IItem itemTree = new TreeViewItem();
            IItem itemTree2 = new TreeViewItem();
            
            IItem itemDescription = new DescriptionItem();
            IItem itemDescription2 = new DescriptionItem();
            IItem itemAppendix = new AppendixItem();

            IItem itemText = new TextItem();
            IItem itemText2 = new TextItem();
            IItem itemQuestion = new QuestionItem();

            itemDescription.AddItem(itemText);
            itemDescription.AddItem(itemText2);
            itemDescription2.AddItem(itemText);
            itemAppendix.AddItem(itemText);

            itemTree.AddItem(itemDescription);
            itemTree.AddItem(itemDescription2);
            itemTree.AddItem(itemAppendix);

            itemTree2.AddItem(itemTree);
        }
    }
}