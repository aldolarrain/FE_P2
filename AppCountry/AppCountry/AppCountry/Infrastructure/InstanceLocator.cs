﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppCountry.Infrastructure
{
    using AppCountry.ViewModels;
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
