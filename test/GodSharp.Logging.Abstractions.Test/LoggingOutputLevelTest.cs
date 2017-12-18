using Xunit;

namespace GodSharp.Logging.Abstractions.Test
{
    public class LoggingOutputLevelTest
    {
        [Fact]
        public void TestMethod()
        {
            System.Console.WriteLine((int)LoggingLevel.Debug);
            System.Console.WriteLine((int)LoggingLevel.Info);
            System.Console.WriteLine((int)LoggingLevel.Warn);
            System.Console.WriteLine((int)LoggingLevel.Error);
            System.Console.WriteLine((int)LoggingLevel.Fatal);
            System.Console.WriteLine();
            System.Console.WriteLine((int)LoggingOutputLevel.None);
            System.Console.WriteLine((int)LoggingOutputLevel.DebugOnly);
            System.Console.WriteLine((int)LoggingOutputLevel.InfoOnly);
            System.Console.WriteLine((int)LoggingOutputLevel.WarnOnly);
            System.Console.WriteLine((int)LoggingOutputLevel.ErrorOnly);
            System.Console.WriteLine((int)LoggingOutputLevel.FatalOnly);
            System.Console.WriteLine();
            System.Console.WriteLine((int)LoggingOutputLevel.Debug);
            System.Console.WriteLine((int)LoggingOutputLevel.Info);
            System.Console.WriteLine((int)LoggingOutputLevel.Warn);
            System.Console.WriteLine((int)LoggingOutputLevel.Error);
            System.Console.WriteLine((int)LoggingOutputLevel.Fatal);

            Assert.True(((int)LoggingOutputLevel.None & (int)LoggingLevel.Debug) == 0);
            Assert.True(((int)LoggingOutputLevel.None & (int)LoggingLevel.Info) == 0);
            Assert.True(((int)LoggingOutputLevel.None & (int)LoggingLevel.Warn) == 0);
            Assert.True(((int)LoggingOutputLevel.None & (int)LoggingLevel.Error) == 0);
            Assert.True(((int)LoggingOutputLevel.None & (int)LoggingLevel.Fatal) == 0);
            

            Assert.True(((int)LoggingOutputLevel.DebugOnly & (int)LoggingLevel.Debug) > 0);
            Assert.True(((int)LoggingOutputLevel.DebugOnly & (int)LoggingLevel.Info) == 0);
            Assert.True(((int)LoggingOutputLevel.DebugOnly & (int)LoggingLevel.Warn) == 0);
            Assert.True(((int)LoggingOutputLevel.DebugOnly & (int)LoggingLevel.Error) == 0);
            Assert.True(((int)LoggingOutputLevel.DebugOnly & (int)LoggingLevel.Fatal) == 0);

            Assert.True(((int)LoggingOutputLevel.InfoOnly & (int)LoggingLevel.Debug) == 0);
            Assert.True(((int)LoggingOutputLevel.InfoOnly & (int)LoggingLevel.Info) > 0);
            Assert.True(((int)LoggingOutputLevel.InfoOnly & (int)LoggingLevel.Warn) == 0);
            Assert.True(((int)LoggingOutputLevel.InfoOnly & (int)LoggingLevel.Error) == 0);
            Assert.True(((int)LoggingOutputLevel.InfoOnly & (int)LoggingLevel.Fatal) == 0);

            Assert.True(((int)LoggingOutputLevel.WarnOnly & (int)LoggingLevel.Debug) == 0);
            Assert.True(((int)LoggingOutputLevel.WarnOnly & (int)LoggingLevel.Info) == 0);
            Assert.True(((int)LoggingOutputLevel.WarnOnly & (int)LoggingLevel.Warn) > 0);
            Assert.True(((int)LoggingOutputLevel.WarnOnly & (int)LoggingLevel.Error) == 0);
            Assert.True(((int)LoggingOutputLevel.WarnOnly & (int)LoggingLevel.Fatal) == 0);

            Assert.True(((int)LoggingOutputLevel.ErrorOnly & (int)LoggingLevel.Debug) == 0);
            Assert.True(((int)LoggingOutputLevel.ErrorOnly & (int)LoggingLevel.Info) == 0);
            Assert.True(((int)LoggingOutputLevel.ErrorOnly & (int)LoggingLevel.Warn) == 0);
            Assert.True(((int)LoggingOutputLevel.ErrorOnly & (int)LoggingLevel.Error) > 0);
            Assert.True(((int)LoggingOutputLevel.ErrorOnly & (int)LoggingLevel.Fatal) == 0);

            Assert.True(((int)LoggingOutputLevel.FatalOnly & (int)LoggingLevel.Debug) == 0);
            Assert.True(((int)LoggingOutputLevel.FatalOnly & (int)LoggingLevel.Info) == 0);
            Assert.True(((int)LoggingOutputLevel.FatalOnly & (int)LoggingLevel.Warn) == 0);
            Assert.True(((int)LoggingOutputLevel.FatalOnly & (int)LoggingLevel.Error) == 0);
            Assert.True(((int)LoggingOutputLevel.FatalOnly & (int)LoggingLevel.Fatal) > 0);


            Assert.True(((int)LoggingOutputLevel.Debug & (int)LoggingLevel.Debug) > 0);
            Assert.True(((int)LoggingOutputLevel.Debug & (int)LoggingLevel.Info) == 0);
            Assert.True(((int)LoggingOutputLevel.Debug & (int)LoggingLevel.Warn) == 0);
            Assert.True(((int)LoggingOutputLevel.Debug & (int)LoggingLevel.Error) == 0);
            Assert.True(((int)LoggingOutputLevel.Debug & (int)LoggingLevel.Fatal) == 0);

            Assert.True(((int)LoggingOutputLevel.Info & (int)LoggingLevel.Debug) > 0);
            Assert.True(((int)LoggingOutputLevel.Info & (int)LoggingLevel.Info) > 0);
            Assert.True(((int)LoggingOutputLevel.Info & (int)LoggingLevel.Warn) == 0);
            Assert.True(((int)LoggingOutputLevel.Info & (int)LoggingLevel.Error) == 0);
            Assert.True(((int)LoggingOutputLevel.Info & (int)LoggingLevel.Fatal) == 0);

            Assert.True(((int)LoggingOutputLevel.Warn & (int)LoggingLevel.Debug) > 0);
            Assert.True(((int)LoggingOutputLevel.Warn & (int)LoggingLevel.Info) > 0);
            Assert.True(((int)LoggingOutputLevel.Warn & (int)LoggingLevel.Warn) > 0);
            Assert.True(((int)LoggingOutputLevel.Warn & (int)LoggingLevel.Error) == 0);
            Assert.True(((int)LoggingOutputLevel.Warn & (int)LoggingLevel.Fatal) == 0);

            Assert.True(((int)LoggingOutputLevel.Error & (int)LoggingLevel.Debug) > 0);
            Assert.True(((int)LoggingOutputLevel.Error & (int)LoggingLevel.Info) > 0);
            Assert.True(((int)LoggingOutputLevel.Error & (int)LoggingLevel.Warn) > 0);
            Assert.True(((int)LoggingOutputLevel.Error & (int)LoggingLevel.Error) > 0);
            Assert.True(((int)LoggingOutputLevel.Error & (int)LoggingLevel.Fatal) == 0);

            Assert.True(((int)LoggingOutputLevel.Fatal & (int)LoggingLevel.Debug) > 0);
            Assert.True(((int)LoggingOutputLevel.Fatal & (int)LoggingLevel.Info) > 0);
            Assert.True(((int)LoggingOutputLevel.Fatal & (int)LoggingLevel.Warn) > 0);
            Assert.True(((int)LoggingOutputLevel.Fatal & (int)LoggingLevel.Error) > 0);
            Assert.True(((int)LoggingOutputLevel.Fatal & (int)LoggingLevel.Fatal) > 0);

        }
    }
}
