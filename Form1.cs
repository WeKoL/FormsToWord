namespace wordInter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                var helper = new WordInter("obrazec-zayavlenie-na-otpusk-bez-soderjaniya.docx");

                var items = new Dictionary<string, string>()
                {
                    {"<POST>", textBox1.Text },
                    {"<FULLNAME>", textBox2.Text },
                    {"<TIMEVACATION>", dateTimePicker2.Value.ToString("yyyy.MM.dd") },
                    {"<REASON>", richTextBox1.Text },
                    {"<TIMENOW>", dateTimePicker3.Value.ToString("yyyy.MM.dd") },
                    {"<WITH>", dateTimePicker1.Value.ToString("HH.mm")},
                    {"<END>", dateTimePicker4.Value.ToString("HH.mm")}
                };

                helper.Process(items);
            }
        }
    }
}
