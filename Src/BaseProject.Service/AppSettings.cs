﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseProject.Service.Interfaces;

namespace BaseProject.Service
{
    public class AppSettings : IAppSettings
    {
        public string UserAdmin
        {
            get { return ConfigurationManager.AppSettings["UserAdmin"]; }
        }

    }
}