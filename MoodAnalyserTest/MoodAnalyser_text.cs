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
        [Test]
        public void GivenNullMessage_ShouldThrowCustomException()
        {
            try
            {
                //Arrange - it will set up the testing object
                MoodAnalyse moodAnalyse = new MoodAnalyse(null);
                //Act - it will perform the actual work what we want test
                string result = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalyseCustom_Exception ex)
            {
                //Assert - which verify the result  by equal actual and expected output
                Assert.AreEqual(ex.Message, "Message should not be null");
            }
        }
    }
}
