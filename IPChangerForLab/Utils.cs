using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace IPChangerForLab
{
    class Utils
    {
        /// <summary>
		/// Returns the list of Network Interfaces installed
		/// </summary>
		/// <returns>Array list of string</returns>
		public static ArrayList GetNICNames()
        {
            ArrayList nicNames = new ArrayList();

            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["ipEnabled"])
                {
                    nicNames.Add(mo["Caption"]);
                }
            }

            return nicNames;
        }
        private bool IsValidIP(string IP)
        {
            string[] segments = IP.Split('.');

            if (segments.Length != 4)
                throw new Exception("Invalid IP format. Valid format is XXX.XXX.XXX.XXX");

            foreach (string segment in segments)
            {
                try
                {
                    byte value = byte.Parse(segment);
                    return true;
                }
                catch
                {
                    throw new Exception("Only values from 0 to 255 allowed");
                }
            }

            return false;
        }
    }
}
