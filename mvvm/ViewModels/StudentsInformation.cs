using mvvm.Models;
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
        public ObservableCollection<Group> Groups { get; set; }
        public ObservableCollection<Student> Students { get; set; }

        public StudentsInformation()
        {
            Groups = new ObservableCollection<Group>();
            Students = new ObservableCollection<Student>();

            fillGroups();
            fillStudents();
        }

        public void fillGroups()
        {
            Group group = new Group();
            group.GroupName = "SP-01n";
            group.Course = "3";

            Groups.Add(group);

            group = new Group();
            group.GroupName = "SP-01b";
            group.Course = "4";
            
            Groups.Add(group);
        }

        public void fillStudents()
        {
            Student student = new Student();
            student.LastName = "Petrov";
            student.FirstName = "Edvard";
            student.MiddleName = "Ivanovich";
            student.StudentGroup = Groups[0];

            Students.Add(student);

            student = new Student();
            student.LastName = "Shepard";
            student.FirstName = "John";
            student.MiddleName = "Johnson";
            student.StudentGroup = Groups[1];

            Students.Add(student);
        }
    }
}