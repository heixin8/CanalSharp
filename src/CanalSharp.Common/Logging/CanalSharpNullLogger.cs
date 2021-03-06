﻿using System;

namespace CanalSharp.Common.Logging
{
    internal class CanalSharpNullLogger : ICanalSharpLogger
    {
        public void Debug(string message)
        {
        }

        public void Info(string message)
        {
        }

        public void Warning(string message)
        {
        }

        public void Error(string message, System.Exception exception)
        {
        }

        public void Trace(string message)
        {
        }
    }
}