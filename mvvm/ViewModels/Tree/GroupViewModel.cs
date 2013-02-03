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
        public GroupViewModel(Group group)
        {
            this.group = group;

            Name = group.Id;
            Text = group.GroupName;

            children = new ObservableCollection<TreeViewBase>();
            foreach (Student student in group.Students)
                children.Add(new StudentViewModel(student));
        }

        private Group group;
        public Group Group { get; set; }
    }
}