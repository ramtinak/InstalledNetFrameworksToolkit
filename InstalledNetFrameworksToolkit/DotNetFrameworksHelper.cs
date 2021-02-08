/*
 * Copyright (c) 2021 - Ramtin Jokar [ Ramtinak@live.com ]
 * 
 * 
 * License: MIT
 * 
 */

using System;

namespace InstalledNetFrameworksToolkit
{
    public static class DotNetFrameworksHelper
    {
        /// <summary>
        ///      Checks whether .NET Framework v4.6 is installed or not.
        /// </summary>
        public static bool IsNET46Installed() => 
            Type.GetType("System.AppContext, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", false) != null;

        /// <summary>
        ///     Checks whether .NET Framework v4.6.1 is installed or not.
        /// </summary>
        public static bool IsNET461Installed() => 
            Type.GetType("System.Data.SqlClient.SqlColumnEncryptionCngProvider, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", false) != null;

        /// <summary>
        ///     Checks whether .NET Framework v4.6.2 is installed or not.
        /// </summary>
        public static bool IsNET462Installed() => 
            Type.GetType("System.Security.Cryptography.AesCng, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", false) != null;

        /// <summary>
        ///     Checks whether .NET Framework v4.7 is installed or not.
        /// </summary>
        public static bool IsNET47Installed() =>
            Type.GetType("System.Web.Caching.CacheInsertOptions, System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", false) != null;

        /// <summary>
        ///     Checks whether .NET Framework v4.7.1 is installed or not.
        /// </summary>
        public static bool IsNET471Installed() => 
            Type.GetType("System.StringNormalizationExtensions, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", false) != null;

        /// <summary>
        ///     Checks whether .NET Framework v4.7.2 is installed or not.
        /// </summary>
        public static bool IsNET472Installed() => 
            Type.GetType("System.Data.SqlClient.SqlAuthenticationParameters, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", false) != null;

        /// <summary>
        ///     Checks whether .NET Framework v4.8 is installed or not.
        /// </summary>
        public static bool IsNET48Installed() => 
            Type.GetType("System.Net.Configuration.SettingsSection, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", false) != null;
    }

}
