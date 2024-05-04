using Typographer;

namespace TypographerTests
{
    [TestClass]
    public class Form1Tests
    {
        private MainForm form;

        [TestInitialize]
        public void Initialize()
        {
            form = new MainForm(); 
        }
        [TestMethod]
        public void TestFixPunctuation()
        {
            var inputText = "Привет, мир Как дела?";
            var expectedOutput = "Привет, мир Как дела? ";
            var result = form.FixPunctuation(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestRemoveExtraSpaces()
        {
            var inputText = "Привет, мир Как дела?   ";
            var expectedOutput = "Привет, мир Как дела? ";
            var result = form.RemoveExtraSpaces(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestFixHyphens()
        {
            var inputText = "Привет-мир Как-дела? ";
            var expectedOutput = "Привет-мир Как-дела? ";
            var result = form.FixHyphens(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestFixDashUsage()
        {
            var inputText = "10-20";
            var expectedOutput = "10—20";
            var result = form.FixDashUsage(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestReplaceTemperatures()
        {
            var inputText = "20...30 °C";
            var expectedOutput = "20...30 °C";
            var result = form.ReplaceTemperatures(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestCapitalizeSentences()
        {
            var inputText = "Привет, мир Как дела? ";
            var expectedOutput = "Привет, мир Как дела? ";
            var result = form.CapitalizeSentences(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestReplaceAWithAtSymbol()
        {
            var inputText = "Привет, мир!";
            var expectedOutput = "Прив*т, мир!";
            var result = form.ReplaceAWithAtSymbol(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestFixPunctuationWithSpecialChars()
        {
            var inputText = "Привет, мир Как дела? (с восклицательным знаком)";
            var expectedOutput = "Привет, мир Как дела? (с восклицательным знаком) ";
            var result = form.FixPunctuation(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestRemoveExtraSpacesWithMultipleLines()
        {
            var inputText = "Привет,\nмир\nКак\nдела?   \n";
            var expectedOutput = "Привет, мир\nКак дела? ";
            var result = form.RemoveExtraSpaces(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestFixHyphensWithMixedCase()
        {
            var inputText = "Привет-Мир Как-Дела? ";
            var expectedOutput = "Привет-Мир Как-Дела? ";
            var result = form.FixHyphens(inputText);
            Assert.AreEqual(expectedOutput, result);
        }
    }
}