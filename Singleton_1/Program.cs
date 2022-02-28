using System;
using System.IO;

namespace Singleton.Structural

{
    /// <summary>
    /// Singleton Design Pattern
    /// </summary>
    public class Program
    {
        static LoggingServiceSingleton log;
        public Program()
        {
            log = LoggingServiceSingleton.Instance;
        }
        public static void Main(string[] args)
        {
            log.WriteToLog("Hector enters");
            Tuple<int, int> obj = GetTwoNumbers();
            double result = GetAverage(obj.Item1, obj.Item2);
            PrintResults(result);

            log.ReadLog();
        }

        public static Tuple<int, int> GetTwoNumbers()
        {
            Console.WriteLine("Give 1st Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give 2nd Number");
            int b = Convert.ToInt32(Console.ReadLine());

            log.WriteToLog($"User inserts numbers: {a} , {b}");
            return Tuple.Create(a, b);
        }

        public static double GetAverage(int a, int b)
        {
            log.WriteToLog("Average Calculation");
            return (a + (double)b) / 2;
        }

        public static void PrintResults(double average)
        {
            log.WriteToLog($"Average =: {average}");
            Console.WriteLine("Average is: " + average);
        }

    }
    public sealed class LoggingServiceSingleton
    {
        public static LoggingServiceSingleton Instance { get; } = new LoggingServiceSingleton();
        private LoggingServiceSingleton() { }

        public void WriteToLog(string message)
        {
            string path = @"log.txt";
            string str = message = message + "---" + DateTime.Now.ToString();

            if (!File.Exists(path))
            {
                File.Create(path);

                File.AppendAllLines(path, new string[] { str });
            }
            else
            {
                File.AppendAllLines(path, new string[] { str });
            }
        }
        public void ReadLog()
        {
            string path = @"log.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("No Data Exist");
            }
            else
            {
                string result = File.ReadAllText(path);
                Console.WriteLine(result);
            }
        }

    }
}