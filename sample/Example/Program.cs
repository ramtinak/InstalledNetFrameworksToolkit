/*
 * Developer: Ramtin Jokar [ Ramtinak@live.com ] [ My Telegram Account: https://t.me/ramtinak ]
 * 
 * 
 * License: MIT
 * 
 */

using InstalledNetFrameworksToolkit;
using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is .NET Framework v4.6\t\tInstalled:\t\t" + DotNetFrameworksHelper.IsNET46Installed());
            Console.WriteLine("Is .NET Framework v4.6.1\tInstalled:\t\t" + DotNetFrameworksHelper.IsNET461Installed());
            Console.WriteLine("Is .NET Framework v4.6.2\tInstalled:\t\t" + DotNetFrameworksHelper.IsNET462Installed());
            Console.WriteLine("Is .NET Framework v4.7\t\tInstalled:\t\t" + DotNetFrameworksHelper.IsNET47Installed());
            Console.WriteLine("Is .NET Framework v4.7.1\tInstalled:\t\t" + DotNetFrameworksHelper.IsNET471Installed());
            Console.WriteLine("Is .NET Framework v4.7.2\tInstalled:\t\t" + DotNetFrameworksHelper.IsNET472Installed());
            Console.WriteLine("Is .NET Framework v4.8\t\tInstalled:\t\t" + DotNetFrameworksHelper.IsNET48Installed());

            Console.ReadLine();
        }
    }
}
