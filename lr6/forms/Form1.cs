namespace forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Cheak_Click(object sender, EventArgs e)
        {
            string text = TextBox_Input.Text;

            int start = 0;
            int end = text.Length - 1;

            text = text.ToLower();
            bool result = false;

            while (true)
            {
                if (start >= end)
                {
                    result = true;
                    break;
                }

                char left = text[start];
                char right = text[end];

                if (char.IsLetter(left) is false)
                {
                    start++;
                    continue;
                }

                if (char.IsLetter(right) is false)
                {
                    end--;
                    continue;
                }

                if (left == right)
                {
                    start++;
                    end--;
                    continue;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            Label_Result.Text = result.ToString();

        }
    }
}
