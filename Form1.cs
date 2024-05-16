namespace Ccs_Lab2_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputSumBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputWord2Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputResultButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Буквы слова - " + this.InputWord1Box.Text +
                    ", входящие в слово - " + this.InputWord2Box.Text + ": \n" +
                    Logic.Lab1_02(this.InputWord1Box.Text, this.InputWord2Box.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода.", "Ошибка"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OutputSumButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Logic.Lab1_01(int.Parse(this.InputSumBox.Text)));
            } 
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода. Введите корректное число."
                    , "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class Logic
    {
        public static string Lab1_01(int sum)
        {
            string outMessage = "";

            int rubles = sum / 100;
            int kopecks = sum % 100;

            string rublesStr = "";
            if (rubles != 0)
            {
                if (rubles == 1)
                    rublesStr = $"{rubles} рубль ";
                else if (rubles <= 4)
                    rublesStr = $"{rubles} рубля ";
                else
                    rublesStr = $"{rubles} рублей ";
            }

            string kopecksStr = "";
            if (kopecks != 0)
            {
                if (kopecks == 1)
                    kopecksStr = $"{kopecks} копейка ";
                else if (kopecks <= 4)
                    kopecksStr = $"{kopecks} копейки ";
                else
                    kopecksStr = $"{kopecks} копеек ";
            }

            outMessage = $"Стоимость товара: {rublesStr}{kopecksStr}";

            return outMessage.Trim();
        }

        public static string Lab1_02(string word1, string word2)
        {
            string result = "";
            bool[] checkedLetters = new bool[26];

            word1 = word1.ToLower();
            word2 = word2.ToLower();

            foreach (char letter in word1)
            {
                if (!checkedLetters[letter - 'а'])
                {
                    if (word2.Contains(letter))
                    {
                        result += letter + " - да ";
                    }
                    else
                    {
                        result += letter + " - нет ";
                    }
                    checkedLetters[letter - 'а'] = true;
                }
            }
            return result.Trim();
        }
    }
}
