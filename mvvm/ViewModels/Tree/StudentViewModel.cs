using mvvm.Models;
using mvvm.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace mvvm.ViewModels.Tree
{
    public class StudentViewModel : TreeViewBase
    {
        private Student student;

        public StudentViewModel(Student student)
        {
            this.student = student;

            DefineName();
        }

        public override void DefineName()
        {
            Name = student.LastName + " " + student.FirstName;
        }

        public override string[] GetInfo()
        {
            return new string[] { student.LastName, student.FirstName };
        }

        public override void EditInfo(string[] info)
        {
            student.LastName = info[0];
            student.FirstName = info[1];

            DefineName();
        }

        public override void AddInfo(string[] info)
        {
            MessageBox.Show("You can't add new items to a student");
        }
    }
}