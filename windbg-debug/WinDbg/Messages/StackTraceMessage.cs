﻿namespace windbg_debug.WinDbg.Messages
{
    public class StackTraceMessage : Message
    {
        public StackTraceMessage(int threadId)
        {
            ThreadId = threadId;
        }

        public int ThreadId { get; private set; }
    }
}
