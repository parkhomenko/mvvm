using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;

namespace mvvm.Utils
{
    public abstract class TreeViewBase : PropertyNotifier
    {
        protected ObservableCollection<TreeViewBase> children;
        private string name;

        public ObservableCollection<TreeViewBase> Children
        {
            get { return children; }
            set
            {
                children = value;
                RaisePropertyChanged("Children");
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged("Name");
            }
        }

        public abstract void DefineName();
        public abstract string[] GetInfo();
        public abstract void EditInfo(string[] info);
        public abstract void AddInfo(string[] info);
    }
}