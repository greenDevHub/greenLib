﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Verwaltung
{
    static class AuthInfo
    {
        public static User CurrentUser { get; set; } = new User();

        public static string FormInfo() {
            return " - Angemeldet als: " + CurrentUser.UserName + " (" + CurrentUser.PermissionName + ")";
        }
    }
}