using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace InventoryManagement
{
    /// <summary>
    /// It attempts to write to HKEY_LOCAL_MACHINE first, which will run on startup on all user accounts.
    /// If it fails (due to lack of privileges), it attempts HKEY_CURRENT_USER, which will only run the program
    /// on the current Windows account the user is logged into.
    /// Written by HelBorn and taken from https://gist.github.com/HelBorn/2266242
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Adds this executable to the startup list.
        /// </summary>
        public static bool RunOnStartup()
        {
            return RunOnStartup(Application.ProductName, Application.ExecutablePath);
        }

        /// <summary>
        /// Adds the specified executable to the startup list.
        /// </summary>
        /// <param name="appTitle">Registry key title.</param>
        /// <param name="appPath">Path of executable to run on startup.</param>
        public static bool RunOnStartup(string appTitle, string appPath)
        {
            RegistryKey rk;
            try
            {
                rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                rk.SetValue(appTitle, appPath);
                return true;
            }
            catch (Exception)
            {
            }

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                rk.SetValue(appTitle, appPath);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Removes this executable from the startup list.
        /// </summary>
        public static bool RemoveFromStartup()
        {
            return RemoveFromStartup(Application.ProductName, Application.ExecutablePath);
        }

        /// <summary>
        /// Removes the specified executable from the startup list.
        /// </summary>
        /// <param name="appTitle">Registry key title.</param>
        public static bool RemoveFromStartup(string appTitle)
        {
            return RemoveFromStartup(appTitle, null);
        }

        /// <summary>
        /// Removes the specified executable from the startup list.
        /// </summary>
        /// <param name="appTitle">Registry key title.</param>
        /// <param name="appPath">Path of executable in the registry that's being run on startup.</param>
        public static bool RemoveFromStartup(string appTitle, string appPath)
        {
            RegistryKey rk;
            try
            {
                rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (appPath == null)
                {
                    rk.DeleteValue(appTitle);
                }
                else
                {
                    if (rk.GetValue(appTitle).ToString().ToLower() == appPath.ToLower())
                    {
                        rk.DeleteValue(appTitle);
                    }
                }
                return true;
            }
            catch (Exception)
            {
            }

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (appPath == null)
                {
                    rk.DeleteValue(appTitle);
                }
                else
                {
                    if (rk.GetValue(appTitle).ToString().ToLower() == appPath.ToLower())
                    {
                        rk.DeleteValue(appTitle);
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if this executable is in the startup list.
        /// </summary>
        /// <returns></returns>
        public static bool IsInStartup()
        {
            return IsInStartup(Application.ProductName, Application.ExecutablePath);
        }

        /// <summary>
        /// Checks if specified executable is in the startup list.
        /// </summary>
        /// <param name="appTitle">Registry key title.</param>
        /// <param name="appPath">Path of the executable.</param>
        /// <returns></returns>
        public static bool IsInStartup(string appTitle, string appPath)
        {
            RegistryKey rk;
            string value;

            try
            {
                rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                value = rk.GetValue(appTitle).ToString();
                if (value == null)
                {
                    return false;
                }
                else if (!value.ToLower().Equals(appPath.ToLower()))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                value = rk.GetValue(appTitle).ToString();
                if (value == null)
                {
                    return false;
                }
                else if (!value.ToLower().Equals(appPath.ToLower()))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }

            return false;
        }
    }
}
