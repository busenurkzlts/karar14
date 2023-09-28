namespace karar14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tutar;
            tutar = Convert.ToDouble(textBox1.Text);
            if (radioButton2.Checked == true || radioButton3.Checked == true)
            {
                tutar = tutar + (tutar * 0.05);
            }
            if (radioButton4.Checked == true || radioButton5.Checked == true)
            {
                tutar = tutar + (tutar * 0.10);
            }
            MessageBox.Show("ödenecek toplam tutar" + tutar.ToString() + "TL");
        }
    }
}