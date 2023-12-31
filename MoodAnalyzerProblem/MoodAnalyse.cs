﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyzerProblem.MoodAnalyseCustom_Exception;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyse
    {
        string message;
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                //My name is Sad
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                // return "Happy";
                throw new MoodAnalyseCustom_Exception("Message should not be null", MoodAnalyser_ExceptionType.NULL_MOOD);
            }
        }
    }
}