using mvvm.Models;
using mvvm.Utils;
using mvvm.ViewModels.Tree;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.Data
{
    public class TreeData
    {
        public static ObservableCollection<TreeViewBase> Get()
        {
            return new ObservableCollection<TreeViewBase>()
            {
                new FacultyViewModel(
                    new Faculty()
                    {
                        Code = "3.0985", Name = "Computer Science", Groups = new List<Group>()
                        {
                            new Group()
                            {
                                Course = "5", GroupName = "SP-01b", Students = new List<Student>()
                                {
                                    new Student() { LastName = "Shepard", FirstName = "John" },
                                    new Student() { LastName = "Anderson", FirstName = "Peter" },
                                    new Student() { LastName = "Udina", FirstName = "Rick" }
                                }
                            },
                            new Group()
                            {
                                Course = "3", GroupName = "SP-01n", Students = new List<Student>()
                                {
                                    new Student() { LastName = "ONeal", FirstName = "Jack" }
                                }
                            }
                        }
                    }
                ),
                new FacultyViewModel(
                    new Faculty()
                    {
                        Code = "5.0899", Name = "Legal Medicine", Groups = new List<Group>()
                        {
                            new Group()
                            {
                                Course = "2", GroupName = "LM-05c", Students = new List<Student>()
                                {
                                    new Student() { LastName = "Morgan", FirstName = "Dexter" }
                                }
                            }
                        }
                    }
                )
            };
        }
    }
}