namespace l11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = CalculateAge(1990, 2024);
            label1.Text = "Возраст: " + age + " лет";

            age = CalculateAge(2005, 2024);
            label2.Text = "Возраст: " + age + " лет";
        }

        private int CalculateAge(int birthYear, int currentYear)
        {
            return currentYear - birthYear;
        }
    }
}
