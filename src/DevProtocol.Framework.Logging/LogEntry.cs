using System;

namespace DevProtocol.Framework.Logging
{
    public class LogEntry
    {
        public readonly LoggingEventType Severity;
        public readonly string Message;
        public readonly Exception Exception;

        public LogEntry(LoggingEventType severity, string message, Exception exception = null)
        {
            this.Severity = severity;
            this.Message = message;
            this.Exception = exception;
        }
    }
}