using log4net;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.IO;

namespace Logging
{
    
  
    public class Program
    {
       

        static void Main(string[] args)
        {
            string strLogText = "Some details you want to log.";

          
            StreamWriter log;

            if (!File.Exists("logfile.txt"))
            {
                log = new StreamWriter("logfile.txt");
            }
            else
            {
                log = File.AppendText("logfile.txt");

                log.WriteLine(DateTime.Now);
                log.WriteLine(strLogText);
                Console.WriteLine(strLogText);
                log.WriteLine();
            }
            log.Close();
        }
    }
}
