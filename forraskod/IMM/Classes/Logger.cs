using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;

namespace IMM.Classes
{
    class Logger
    {
        private static string logpath = @"Logger\"+DateTime.Today.ToShortDateString()+"txt";
        public static void Log(string page, string logEvent) {
            if (Directory.Exists(@"Logger\")){
                File.AppendAllText(logpath, page + " | " + logEvent + " | " + DateTime.Now + " | " + "\n");
            } else {
                Directory.CreateDirectory(@"Logger\");
                Log(page,logEvent);
            }
        }
        public static void mappaMegnyit() {
            Process.Start(@"Logger\");
        }
    }
}
