﻿using System;
using System.Collections.Generic;
using System.Text;
namespace Mood_Analyser_Problem
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood(string mesaage)
        {
            if (this.message.Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
