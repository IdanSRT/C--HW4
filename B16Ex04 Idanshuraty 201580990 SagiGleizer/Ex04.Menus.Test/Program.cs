﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Test;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            InterfaceTester.BuildInterfaceMenu().Show();
            DelegateTester.BuildDelegateMenu().Show();
        }
    }
}
