using mvvm.Data;
using mvvm.Models;
using mvvm.Utils;
using mvvm.ViewModels.Tree;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.ViewModels
{
    public class StudentsInformation
    {
        public ObservableCollection<TreeViewBase> Parent { get; set; }

        public StudentsInformation()
        {
            Parent = TreeData.Get();
        }
    }
}