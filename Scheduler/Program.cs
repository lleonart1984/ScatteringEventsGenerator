using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = 0;
            bool training = false;
            while (true)
            {
                try
                {
                    if (File.Exists("locker.txt"))
                    {
                        Thread.Sleep(5000); // wait 5 seconds to check if process finished
                        continue;
                    }
                }
                catch
                {
                    Thread.Sleep(5000); // wait 5 seconds to check if process finished
                    continue;
                }

                Console.Write("Loop: " + (loop++) + "\t");

                if (training) // something new was generated
                {
                    Console.WriteLine("Starting trainer...");

                    // Start training process
                    Process.Start("python.exe", "vae4Scattering.py");
                }
                else
                {
                    Console.WriteLine("Starting generator...");
                    // Start generating process
                    Process.Start("Generator.exe");
                }
                training = !training;
                Thread.Sleep(10000); // wait for process to place the locker
            }
        }
    }
}
