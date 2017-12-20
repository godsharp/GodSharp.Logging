using GodSharp.Logging.Abstractions;
using Xunit;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace GodSharp.Logging.NLog.Test
{
    public class NLoggingTest
    {
        Abstractions.Logging logging = new NLogging();

        [Fact]
        public void WithinQueueTestMethod()
        {
            LoggingConfiguration.QueueEnable = true;

            logging.Error("WithinQueueTestMethod start");
            LogTestMethod();
            logging.Error("WithinQueueTestMethod end");
        }

        [Fact]
        public void WithoutQueueTestMethod()
        {
            logging.Error("WithoutQueueTestMethod start");
            LoggingConfiguration.QueueEnable = false;

            LogTestMethod();
            logging.Error("WithoutQueueTestMethod end");
        }

        private void LogTestMethod()
        {
            List<double> list = new List<double>();
            Stopwatch stopwatch = new Stopwatch();
            for (int i = 0; i < 3; i++)
            {
                stopwatch.Start();
                LogRunTestMethod();
                stopwatch.Stop();

                System.Console.WriteLine($"{i} : {stopwatch.Elapsed.TotalMilliseconds}ms");
                list.Add(stopwatch.Elapsed.TotalMilliseconds);

                stopwatch.Reset();
            }

            System.Console.WriteLine($"Total time:{list.Sum()}ms,Average time:{list.Average()}ms");
        }

        private void LogRunTestMethod()
        {
            int count = 0;
            while (count< 10000)
            {
                logging.Error("Hello GodSharp : " + count);
                count++;
            }
        }
    }
}
