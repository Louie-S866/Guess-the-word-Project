namespace Guess_the_Word___Y13_Programming_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "Word_File";
            string filePath = Path.Combine(exeDirectory, fileName);
            string content = File.ReadAllText(filePath);
            Console.WriteLine($"File path: {filePath}");

            // string filePath = "C:/School/Programming Project/Application - Guess the word/Guess the Word - Y13 Programming Project/Text files";
            // string content = File.ReadAllText("C:/School/Programming Project/Application - Guess the word/Guess the Word - Y13 Programming Project/Text files");

            for (int i = 0; i < content.Length; i++)
            {
                label1.Text = Convert.ToString(content[i]);
                Console.WriteLine(content[i]);
                Console.ReadLine();
            }
        }
    }
}