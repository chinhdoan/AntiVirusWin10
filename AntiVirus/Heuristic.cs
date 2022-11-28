using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
namespace AntiVirus
{
    class Heuristic
    {
        public string myResultPath;
        public void getResults() {
            myResultPath = Directory.GetParent(Application.ExecutablePath).FullName + "\\result.txt";
            string getParentPath = Directory.GetParent(Application.ExecutablePath).FullName;
            var psi = new ProcessStartInfo();
            psi.FileName = getParentPath + "\\python38\\python.exe";

            var script = getParentPath + "\\heuristic\\check.py";

            psi.Arguments = $"\"{script}\"";

            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;


            var result = "";
            var error = "";
            var process = Process.Start(psi);
            result = process.StandardOutput.ReadToEnd();
            error = process.StandardError.ReadToEnd();

            File.WriteAllText(myResultPath,result);
            Console.WriteLine(result);
            Console.WriteLine(error);
        }
       
    }
}
