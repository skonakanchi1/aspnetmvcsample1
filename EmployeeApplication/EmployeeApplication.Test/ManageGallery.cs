using EmployeeApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Test
{
    public class ManageGallery
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public void Login()
        {
            BFGLoginViewModel vModel = new BFGLoginViewModel();
            vModel.Model = new Models.BFGLogin();
            vModel.Model.UserName = Username;
            vModel.Model.PassWord = Password;
            vModel.LogIn();

        }
    }
}
