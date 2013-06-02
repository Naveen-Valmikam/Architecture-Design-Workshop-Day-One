using DancingSentenceExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace DancingSentenceEampleTests
{
    [TestClass]
    public class ExampleTests
    {
        private DancingSentence SUT;
        
        [TestInitialize]
        public void Init()
        {
            SUT = new DancingSentence();
        }

        [TestMethod]
        public void ShouldIgnoreSpaces()
        {
            var result = SUT.MakeDancing("This is a dancing sentence");
            result.ShouldEqual("ThIs Is A dAnCiNg SeNtEnCe");
        }

        [TestMethod]
        public void ShouldHandleBasics()
        {
            var result = SUT.MakeDancing("aaaaaaaaaaaaa");
            result.ShouldEqual("AaAaAaAaAaAaA");
        }

        [TestMethod]
        public void ShouldHandleSingleLetter()
        {
            var result = SUT.MakeDancing("z");
            result.ShouldEqual("Z");
        }
    }
}