using System.Diagnostics;
using System.Threading;

namespace MorphicLiteAutomation.Objects
{
    class Uninstall
    {
        public void UninstallMorphic()
        {

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = @"powershell.exe",
                Arguments = @"Uninstall-Package -Name 'Morphic' -Confirm:$false",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process process = new Process
            {
                StartInfo = startInfo
            };
            process.Start();
            Thread.Sleep(1000);
            System.Console.WriteLine("Uninstall has been successfully executed");
        }
    }
}
