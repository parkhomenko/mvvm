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
    public class GroupViewModel : TreeViewBase
    {
        private Group group;

        public GroupViewModel(Group group)
        {
            this.group = group;

            DefineName();

            children = new ObservableCollection<TreeViewBase>();
            foreach (Student student in group.Students)
                children.Add(new StudentViewModel(student));
        }

        public override void DefineName()
        {
            Name = group.GroupName;
        }

        public override string[] GetInfo()
        {
            return new string[] { group.Course, group.GroupName };
        }

        public override void EditInfo(string[] info)
        {
            group.Course = info[0];
            group.GroupName = info[1];

            DefineName();
        }

        public override void AddInfo(string[] info)
        {
            Student student = new Student();
            student.LastName = info[0];
            student.FirstName = info[1];

            children.Add(new StudentViewModel(student));
        }
    }
}