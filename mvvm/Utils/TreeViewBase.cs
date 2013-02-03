using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace mvvm.Utils
{
    public abstract class TreeViewBase : PropertyNotifier
    {
        protected ObservableCollection<TreeViewBase> children;

        public ObservableCollection<TreeViewBase> Children
        {
            get { return children; }
            set
            {
                children = value;
                RaisePropertyChanged("Children");
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged("Name");
            }
        }
    }
}