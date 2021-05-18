using CinemaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Repo
{
    public class UserRepo
    {
        public List<User> GetUsers()
        {
            return new List<User>
            {
                new User
                {
                    Name="Zaur",
                    Surname="Jafarov",
                    Age=19,
                    Username="zaurcfr",
                    Email="zaurcfr13@gmail.com",
                    Password="zaur123"
                },
                new User
                {
                    Name="Ayxan",
                    Surname="Axundov",
                    Age=19,
                    Username="ayxanaxn",
                    Email="ayxanaxn@gmail.com",
                    Password="ayxan123"
                },
                new User
                {
                    Name="Sanan",
                    Surname="Mammadov",
                    Age=19,
                    Username="senanmem",
                    Email="senanmem@gmail.com",
                    Password="senan123"
                },
                new User
                {
                    Name="User",
                    Surname="User",
                    Age=19,
                    Username="user",
                    Email="user@gmail.com",
                    Password="user"
                }
            };
        }
    }
}
