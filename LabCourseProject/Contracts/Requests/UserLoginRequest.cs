﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabCourseProject.Contracts.Requests
{
    public class UserLoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; } 
    }
}
