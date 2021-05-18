using CinemaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Repo
{
    public class AdminRepo
    {
        public List<Admin> GetAdmins()
        {
            return new List<Admin>
            {
                new Admin
                {
                    Name="Admin",
                    Surname="Admin",
                    Age=19,
                    Username="admin",
                    Email="admin@gmail.com",
                    Password="admin"
                }
            };
        }
    }
}
