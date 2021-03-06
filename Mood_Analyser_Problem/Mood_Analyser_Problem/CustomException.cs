﻿using System;
using System.Collections.Generic;
using System.Text;
namespace Mood_Analyser_Problem
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
        }
        private readonly ExceptionType type;
        public CustomException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
