using System.Diagnostics;

namespace Flax.Logger
{
    public static class Logger
    {
        private static object locker = new();
        private static string filePath = Path.Combine(Path.GetTempPath(), "Flax", "flax.log");

        public static void Log(string message, LogType logType = LogType.Info)
        {
            string text = $"[{DateTime.Now}] {logType}::{message}\n";

            lock (locker)
            {
                Debug.WriteLine(text);
                File.AppendAllText(filePath, text);
            }
        }
    }
}