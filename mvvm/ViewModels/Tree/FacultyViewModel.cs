using mvvm.Models;
using mvvm.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.ViewModels.Tree
{
    public class FacultyViewModel : TreeViewBase
    {
        public FacultyViewModel(Faculty faculty)
        {
            this.faculty = faculty;

            Name = faculty.Code + " - " + faculty.Name;

            children = new ObservableCollection<TreeViewBase>();
            foreach (Group group in faculty.Groups)
                children.Add(new GroupViewModel(group));
        }

        private Faculty faculty;
        public Faculty Faculty { get; set; }
    }
}