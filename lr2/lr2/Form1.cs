namespace lr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Calculate_Click(object sender, EventArgs e)
        {
            string text = TextBox_Input.Text;
            string[] fractionsAsText = text.Split(' ');
            List<Fraction> fractions = new List<Fraction>();

            foreach (string fracton in fractionsAsText)
            {
                string[] splitted = fracton.Split('/');
                int numerator = int.Parse(splitted[0]);
                int denumerator = int.Parse(splitted[1]);
                fractions.Add(new Fraction(numerator, denumerator));
            }

            Fraction sum = fractions[0];

            for(int i =  1; i < fractions.Count; i++) 
            {
                sum = sum + fractions[i];
            }

            Fraction average = sum / new Fraction(fractions.Count, 1);
          
            Label_Average.Text = average.ToString();

            Label_Sum.Text = sum.ToString();

        }
    }
}
