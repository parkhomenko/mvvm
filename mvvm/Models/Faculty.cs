using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.Models
{
    public class Faculty
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public List<Group> Groups { get; set; }
    }
}