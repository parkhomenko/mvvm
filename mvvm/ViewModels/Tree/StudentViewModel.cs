using mvvm.Models;
using mvvm.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.ViewModels.Tree
{
    public class StudentViewModel : TreeViewBase
    {
        public StudentViewModel(Student student)
        {
            this.student = student;

            Name = student.Id;
            Text = student.LastName + " " + student.FirstName;
        }

        private Student student;
        public Student Student { get; set; }
    }
}