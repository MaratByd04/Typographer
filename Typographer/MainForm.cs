using System.Text.RegularExpressions;

namespace Typographer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string processedText = ProcessText(TextBox.Text);
            TextBox.Text = processedText;
        }

        public string ProcessText(string inputText)
        {
            inputText = FixPunctuation(inputText);
            inputText = RemoveExtraSpaces(inputText);
            inputText = FixHyphens(inputText);
            inputText = FixDashUsage(inputText);
            inputText = ReplaceTemperatures(inputText);
            inputText = ReplaceAWithAtSymbol(inputText);
            inputText = CapitalizeSentences(inputText);
            
            return inputText;
        }

        public string FixPunctuation(string inputText)
        {
            // Правило 1. Замена знаков препинания
            inputText = Regex.Replace(inputText, @"(\w)([.,!?])", "$1 $2");
            inputText = Regex.Replace(inputText, @"([.,!?])(\w)", "$1 $2");
            return inputText;
        }

        public string RemoveExtraSpaces(string inputText)
        {
            // Правило 2. Удаление лишних пробелов
            inputText = Regex.Replace(inputText, @"\s+", " ");
            return inputText;
        }

        public string FixHyphens(string inputText)
        {
            // Правило 5. Удаление пробелов перед и после дефиса
            inputText = Regex.Replace(inputText, @"(\S) - (\S)", "$1-$2");
            return inputText;
        }

        public string FixDashUsage(string inputText)
        {
            // Правило 7. Замена дефиса на тире
            inputText = Regex.Replace(inputText, @"(\d+)-(\d+)", "$1—$2");
            inputText = Regex.Replace(inputText, @"(\d+)-(\d+)", "$1—$2");
            return inputText;
        }

        public string ReplaceTemperatures(string inputText)
        {
            // Правило 18. Замена диапазонов температур
            inputText = Regex.Replace(inputText, @"(−?\d+)\.\.\.(−?\d+)\s?°C", "$1...$2 °C");
            inputText = Regex.Replace(inputText, @"(−?\d+)\s?—\s?(−?\d+)\s?°C", "$1—$2 °C");
            return inputText;
        }

        public string CapitalizeSentences(string inputText)
        {
            // Свое правило, разделяет текст на предложения. 
            string[] sentences = inputText.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < sentences.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(sentences[i]))
                {
                    sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1);
                }
            }
            string processedText = string.Join(". ", sentences) + ".";
            return processedText;
        }

        public string ReplaceAWithAtSymbol(string inputText) // абсурдное правило 
        {
            // замена всех букв "е" на символ "*"
            inputText = inputText.Replace("е", "*").Replace("Е", "*");
            return inputText;
        }
    }
}

