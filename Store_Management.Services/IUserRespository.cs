﻿using System;
using System.Collections.Generic;
using Store_Management_Models;

namespace Store_Management.Services
{
    public interface IUserResposity
    {
        IEnumerable<User> GetAllUsers();
    }
}
