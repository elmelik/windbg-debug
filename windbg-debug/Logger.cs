﻿using System;
using System.IO;

namespace windbg_debug
{
    public class Logger
    {
        private readonly bool _verbose;

        public Logger(bool verbose)
        {
            _verbose = verbose;
        }

        public void Log(string text)
        {
            if (_verbose)
                Console.Error.WriteLine(text);

            File.AppendAllText("G:\\temp.txt", text + Environment.NewLine);
        }
    }
}
