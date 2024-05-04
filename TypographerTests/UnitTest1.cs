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
            var inputText = "������, ��� ��� ����?";
            var expectedOutput = "������, ��� ��� ����? ";
            var result = form.FixPunctuation(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestRemoveExtraSpaces()
        {
            var inputText = "������, ��� ��� ����?   ";
            var expectedOutput = "������, ��� ��� ����? ";
            var result = form.RemoveExtraSpaces(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestFixHyphens()
        {
            var inputText = "������-��� ���-����? ";
            var expectedOutput = "������-��� ���-����? ";
            var result = form.FixHyphens(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestFixDashUsage()
        {
            var inputText = "10-20";
            var expectedOutput = "10�20";
            var result = form.FixDashUsage(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestReplaceTemperatures()
        {
            var inputText = "20...30 �C";
            var expectedOutput = "20...30 �C";
            var result = form.ReplaceTemperatures(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestCapitalizeSentences()
        {
            var inputText = "������, ��� ��� ����? ";
            var expectedOutput = "������, ��� ��� ����? ";
            var result = form.CapitalizeSentences(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestReplaceAWithAtSymbol()
        {
            var inputText = "������, ���!";
            var expectedOutput = "����*�, ���!";
            var result = form.ReplaceAWithAtSymbol(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestFixPunctuationWithSpecialChars()
        {
            var inputText = "������, ��� ��� ����? (� ��������������� ������)";
            var expectedOutput = "������, ��� ��� ����? (� ��������������� ������) ";
            var result = form.FixPunctuation(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestRemoveExtraSpacesWithMultipleLines()
        {
            var inputText = "������,\n���\n���\n����?   \n";
            var expectedOutput = "������, ���\n��� ����? ";
            var result = form.RemoveExtraSpaces(inputText);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestFixHyphensWithMixedCase()
        {
            var inputText = "������-��� ���-����? ";
            var expectedOutput = "������-��� ���-����? ";
            var result = form.FixHyphens(inputText);
            Assert.AreEqual(expectedOutput, result);
        }
    }
}