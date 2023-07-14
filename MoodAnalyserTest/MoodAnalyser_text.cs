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
        MoodAnalyse moodAnalyse= new MoodAnalyse();
        [Test]
        public void GivenSadMood_ShouldReturnSad()
        {
            string Result = moodAnalyse.AnalyseMood("I am in Sad Mood");
            Assert.AreEqual(Result, "Sad");
        }
    }

}
