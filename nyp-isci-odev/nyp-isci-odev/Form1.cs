namespace nyp_işçi_ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("İşçi");
            comboBox1.Items.Add("muhendis");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personal pers = new Personal
            (adTxt.Text, adresTxt.Text, comboBox1.Text, Convert.ToInt32(yasTxt.Text), Convert.ToInt32(mesaiTxt.Text));

            if (comboBox1.Text == "İşçi")

            {
                MessageBox.Show(pers.ucretHesapla().ToString());

            }
            else
            {
                pers.ucretHesapla(1000);
            }
        }
    }
}
