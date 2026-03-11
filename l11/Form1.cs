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
            int birthYear = (int)numericUpDown1.Value;
            int currentYear = (int)numericUpDown2.Value;

            int age = CalculateAge(birthYear, currentYear);

            label3.Text = "Возраст: " + age + " лет";
        }

        private int CalculateAge(int birthYear, int currentYear)
        {
            return currentYear - birthYear;
        }
    }
}
