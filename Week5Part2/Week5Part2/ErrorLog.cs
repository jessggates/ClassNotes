using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2
{
    internal static class ErrorLog
    {
        static void Log(string message)
        {
            static void Log(string message, Exception exception) { }
        }

        static void Log(Exception exception) { }

        static void Log(Exception exception, string userID)
        {

        }

        static void Log(FileInfo logFile, string message)
        {

        }
    }
}
