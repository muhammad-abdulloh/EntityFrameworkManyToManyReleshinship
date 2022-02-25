using EntityFrameworkProject.Data;
using EntityFrameworkProject.Models;
using System;

namespace EntityFrameworkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbContexts _dbContexts = new DbContexts();

            Teacher teacher = new Teacher()
            {
                FullName = "Muhammad Abdulloh"
            };

            Group group = new Group()
            {
                Name = ".Net"
            };
            group.Teachers.Add(teacher);

            _dbContexts.Groups.Add(group);

            _dbContexts.SaveChanges();
        }
    }
}
