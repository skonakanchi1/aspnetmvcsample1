using EmployeeApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeApplication.ViewModel
{
    public class BFGLoginViewModel
    {
        public BFGLogin Model { get; set; }

       

        public string LogIn()
        {
            if (Model.UserName == "Srini" && Model.PassWord == "asdf")
                Model.Message = "Success";
            else
                Model.Message = "Failed";
            return Model.Message;
        
        }
        
    }
}