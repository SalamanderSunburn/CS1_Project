﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.UserForm
{
    interface IUserView
    {
        string Login { get; set; }
        string Password { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string Role { get; set; }
        bool Active { get; set; } // CheckBox.CheckState
        ICollection<Domain.Entities.Comments.Comment> Comments { get; set; } // get: return comments.User.Login + comments.Date + comments.Text according to EntutyType.User
    }
}
