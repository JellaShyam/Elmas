using System;
using System.Globalization;
using System.IO;

namespace Elmas.Logger
{
    public sealed class Log : ILog
    {
        private static readonly Lazy<Log> Instance = new Lazy<Log>();
        public static Log GetInstanceLogger
        {
            get { return Instance.Value; }
        }
        public void WriteErrorLog(string message)
        {
            const string fileName = "Elmas_ErrorLog.txt";
            var destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"\", fileName);
            using (var writer = new StreamWriter(destPath, true))
            {
                writer.WriteLine("Message :" + message + "<br/>" +
                                 "" + Environment.NewLine + "Date :" + DateTime.Now.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);
            }
        }
    }
}
