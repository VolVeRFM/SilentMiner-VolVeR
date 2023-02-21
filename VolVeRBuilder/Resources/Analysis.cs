using System.Management;
using System;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace MinerAns
{
   


    public class Analysis
    {
        public static bool isVirtualMachine()
        {
            const string MICROSOFTCORPORATION = "microsoft corporation";
            const string VMWARE = "vmware";

            foreach (var item in new ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get())
            {
                string manufacturer = item["Manufacturer"].ToString().ToLower();

                if (manufacturer.Contains(MICROSOFTCORPORATION) || manufacturer.Contains(VMWARE))
                {
                    return true;
                }
                if (item["Model"] != null)
                {
                    string model = item["Model"].ToString().ToLower();
                    if (model.Contains(MICROSOFTCORPORATION) || model.Contains(VMWARE))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

 

        public static bool DetectSandboxie()
        {
            try
            {
                if (Analysis.GetModuleHandle("SbieDll.dll").ToInt32() != 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CheckRemoteDebuggerPresent(
          IntPtr hProcess,
          ref bool isDebuggerPresent);
    }
}

 
