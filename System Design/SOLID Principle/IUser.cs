﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle
{
    internal interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);

    }
    // Single Responsiblities with multiple interfaces
    // We can perform this by object creational macaniciasm
    interface ILogger
    {
        void LogError(string error);
    }
    interface IEmail
    {
        bool SendEmail(string emailContent);
    }
}
