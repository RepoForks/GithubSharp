using System;

namespace GithubSharp.Plugins.LogProviders.NullOrCustomLogProvider
{
    public class NullOrCustomLogProvider : GithubSharp.Core.Services.ILogProvider
    {
        public NullOrCustomLogProvider()
        {
        }

        public NullOrCustomLogProvider(Action<string,object[]> logHandler, Func<Exception,bool> handleAndReturnIfToThrowErrorHandler)
        {
            this.HandleHandleAndReturnIfToThrowError += new HandleAndReturnIfToThrowErrorEvent(handleAndReturnIfToThrowErrorHandler);
            this.HandleLogMessage += new LogMessageEvent(logHandler);
        }

        public delegate bool HandleAndReturnIfToThrowErrorEvent(Exception error);
        public event HandleAndReturnIfToThrowErrorEvent HandleHandleAndReturnIfToThrowError;

        public delegate void LogMessageEvent(string Message, params object[] Arguments);
        public event LogMessageEvent HandleLogMessage;

        #region ILogProvider Members

        public bool DebugMode { get; set; }

        public void LogMessage(string Message, params object[] Arguments)
        {
            if (HandleLogMessage != null)
                HandleLogMessage(Message, Arguments);
        }

        public bool HandleAndReturnIfToThrowError(Exception error)
        {
            if (HandleHandleAndReturnIfToThrowError != null)
                return HandleHandleAndReturnIfToThrowError(error);
            return DebugMode;
        }

        #endregion
    }
}
