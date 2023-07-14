﻿using MoodAnalyzerProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserTest
{
    public class MoodAnalyser_text
    {
        [Test]
        public void GivenSadMood_ShouldReturnSad()
        {

            MoodAnalyse moodAnalyse = new MoodAnalyse("I am in Sad Mood");
            string Result = moodAnalyse.AnalyseMood();
            Assert.AreEqual(Result, "Sad");
        }
    }

}
