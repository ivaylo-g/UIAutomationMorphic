using System.Diagnostics;
using System.Net;
using System.Threading;

namespace MorphicLiteAutomation.Objects
{
    class Install
    {

        public void InstallMorphic()
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://dw2oujmdhok1n.cloudfront.net/win/x64/stable/MorphicSetup.msi", @"C:\Users\vagrant\Documents\Morphic.msi");
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("cd C:\\Users\\vagrant\\Documents\\");
            process.StandardInput.WriteLine("Morphic.msi");
            bool found = false;
            while (!found)
            {
                foreach (Process clsProcess in Process.GetProcesses())
                    if (clsProcess.ProcessName == "Morphic")
                        found = true;
                Thread.Sleep(1000);
            }

        }
    }
}
