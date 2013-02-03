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
                        Id = "5", Code = "3.0985", Name = "Computer Science", Groups = new List<Group>()
                        {
                            new Group()
                            {
                                Id = "3", Course = "5", GroupName = "SP-01b", Students = new List<Student>()
                                {
                                    new Student() { Id = "1", LastName = "Shepard", FirstName = "John" },
                                    new Student() { Id = "2", LastName = "Anderson", FirstName = "Peter" },
                                    new Student() { Id = "3", LastName = "Udina", FirstName = "Rick" }
                                }
                            },
                            new Group()
                            {
                                Id = "4", Course = "3", GroupName = "SP-01n", Students = new List<Student>()
                                {
                                    new Student() { Id = "4", LastName = "ONeal", FirstName = "Jack" }
                                }
                            }
                        }
                    }
                ),
                new FacultyViewModel(
                    new Faculty()
                    {
                        Id = "6", Code = "5.0899", Name = "Legal Medicine", Groups = new List<Group>()
                        {
                            new Group()
                            {
                                Id = "5", Course = "2", GroupName = "LM-05c", Students = new List<Student>()
                                {
                                    new Student() { Id = "5", LastName = "Morgan", FirstName = "Dexter" }
                                }
                            }
                        }
                    }
                )
            };
        }
    }
}