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
        private Faculty faculty;

        public FacultyViewModel(Faculty faculty)
        {
            this.faculty = faculty;

            DefineName();

            children = new ObservableCollection<TreeViewBase>();
            foreach (Group group in faculty.Groups)
                children.Add(new GroupViewModel(group));
        }

        public override void DefineName()
        {
            Name = faculty.Code + " - " + faculty.Name;
        }

        public override string[] GetInfo()
        {
            return new string[] { faculty.Code, faculty.Name };
        }

        public override void EditInfo(string[] info)
        {
            faculty.Code = info[0];
            faculty.Name = info[1];

            DefineName();
        }

        public override void AddInfo(string[] info)
        {
            Group group = new Group();
            group.Course = info[0];
            group.GroupName = info[1];
            group.Students = new List<Student>();

            children.Add(new GroupViewModel(group));
        }
    }
}