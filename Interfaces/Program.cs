using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            SmsLogger smsLogger = new SmsLogger();
            smsLogger.WriteLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();
        }
    }
    public interface ILogger
    {
        //sadece imzası
        void WriteLog();
    }
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Dosyaya yazıldı.");
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database'e yazıldı.");
        }
    }

    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Sms gönderildi.");
        }
    }

    public class LogManager
    {
        public ILogger _logger;

        public LogManager(ILogger logger)
        {
            _logger = logger;
        }
        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}
