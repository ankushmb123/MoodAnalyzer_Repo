using MoodAnalyzerProblem;
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
        [Test]
        public void GivenSadMood_ShouldReturnHappy()
        {

            MoodAnalyse moodAnalyse = new MoodAnalyse("I am in Any Mood");
            string Result = moodAnalyse.AnalyseMood();
            Assert.AreEqual(Result, "Happy");

        }
        [Test]
        public void GivenNullMood_ShouldReturnHappy()
        {

            MoodAnalyse moodAnalyse = new MoodAnalyse(null);
            string result = moodAnalyse.AnalyseMood();
            Assert.AreEqual(result, "Happy");
        }
    }

}
