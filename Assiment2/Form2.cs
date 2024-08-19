namespace Assiment2
{
    public partial class Form2 : Form
    {
        string CustomerName;
        double LastMonthWaterMeter;
        double ThisMonthWaterMeter;
        double Consumption;
        double WaterMoney;
        public Form2(string CustomerName, double LastMonthWaterMeter, double ThisMonthWaterMeter, double Consumption, double WaterMoney)
        {
            InitializeComponent();
            this.CustomerName = CustomerName;
            this.LastMonthWaterMeter = LastMonthWaterMeter;
            this.ThisMonthWaterMeter = ThisMonthWaterMeter;
            this.Consumption = Consumption;
            this.WaterMoney = WaterMoney;

            txtNameOfCustomer.Text = CustomerName;
            txtThisMonthWater.Text = ThisMonthWaterMeter.ToString();
            txtLastMonthWater.Text = LastMonthWaterMeter.ToString();
            txtConsumption.Text = Consumption.ToString();
            txtWaterMoney.Text = WaterMoney.ToString();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment success");
        }
    }
}