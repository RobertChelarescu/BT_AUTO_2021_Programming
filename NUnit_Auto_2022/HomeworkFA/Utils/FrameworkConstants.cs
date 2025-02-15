﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.HomeworkFA.Utils
{
    class FrameworkConstants
    {
        const string extensionPath = "Other\\ExtensionFile";

        static Dictionary<string, string> configData = Utils.ReadConfig("config.properties");
        static string hostname = configData["hostname"];
        static string protocol = configData["protocol"];        
        static string port = configData["port"];
        static string apppath = configData["apppath"];
        public static string browserProxy = configData["proxyserver"];
        public static bool startHeadless = GetHeadlessConfig();
        public static bool useProxy = Boolean.Parse(configData["useproxy"]);
        public static bool startMaximized = Boolean.Parse(configData["startmaximized"]);
        public static bool ignoreCertErr = Boolean.Parse(configData["ignorecerterr"]);
        public static bool startWithExtension = Boolean.Parse(configData["extension"]);
        public static string configBrowser = configData["browser"];

        public static string GetUrl()
        {
            return String.Format("{0}://{1}:{2}{3}", protocol, hostname, port, apppath);
        }

        public static string GetExtensionName(WebBrowsers browserType)
        {
            switch (browserType)
            {
                case WebBrowsers.Firefox:
                    {
                        return String.Format("{0}\\metamask-10.8.1-an+fx.xpi", extensionPath);
                    }
                default:
                    {
                        return String.Format("{0}\\extension_4_42_0_0.crx", extensionPath);
                    }
            }
        }

           private static bool GetHeadlessConfig()
        {
            foreach (string key in Environment.GetEnvironmentVariables().Keys)
            {
                if (key.Equals("env"))
                {
                    if (!Environment.GetEnvironmentVariables()[key].Equals("local"))
                    {
                        Console.WriteLine("Found env variable other for local");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Found env variable for local");
                        return false;
                    }
                }
               
            }
            Console.WriteLine("No env variable, reading from file");
            return Boolean.Parse(configData["headless"]);
        }
    }
}
