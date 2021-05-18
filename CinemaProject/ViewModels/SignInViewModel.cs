using CinemaProject.Command;
using CinemaProject.Models;
using CinemaProject.Repo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.ViewModels
{
    public class SignInViewModel
    {
        public RelayCommand SignInCommand { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<Admin> Admins { get; set; }
        public UserRepo UserRepository { get; set; }
        public AdminRepo AdminRepository { get; set; }

        public SignInViewModel()
        {

        }
    }
}
