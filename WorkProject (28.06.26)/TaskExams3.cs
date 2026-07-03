//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.IO;

//namespace WorkProject__02._07._26_
//{
//    internal class TaskExams3
//    {
//        static void Main(string[] args)
//        {
//            ConsoleLogger consoleLogger = new ConsoleLogger();
//            FileLogger fileLogger = new FileLogger();
//            consoleLogger.LogInfo("Я работаю и вывожу сообщение!"); fileLogger.LogInfo("Я работаю и записываю сообщение!");
//        }

//    }
//    public interface ILogger
//    {
//        void LogInfo(string message);
//    }
//    public class ConsoleLogger : ILogger
//    {
//        public string Message { get; private set; }
//        public void LogInfo(string message)
//        {
//            Message = message;
//            Console.WriteLine(Message);
//        }
//    }
//    public class FileLogger : ILogger
//    {
//        public string Message { get; private set; }
//        public void LogInfo(string message)
//        {
//            Message = message;
//            File.AppendAllText("C:\\Users\\Bombastic\\source\\repos\\WorkProject (28.06.26)\\WorkProject (28.06.26)\\log.txt", Message);
//        }
//    }
//}
