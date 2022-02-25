using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public virtual ICollection<Group> Groups { get; set; }

        public Teacher()
        {
            Groups = new List<Group>();
        }
    }
}
