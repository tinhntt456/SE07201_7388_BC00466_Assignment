using System.CodeDom.Compiler;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using static Assiment2.Form1;
namespace Assiment2
{
    public partial class Form1 : Form
    {
        public List<Invoice> Invoices = new List<Invoice>(); // chua mot danh sach phan tu mang kieu du lieu Invoice
        public const double VAT = 0.1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            cboTyPeOfCustomer.Items.Add("Household customer");
            cboTyPeOfCustomer.Items.Add("Administrative agency, public services");
            cboTyPeOfCustomer.Items.Add("Production units");
            cboTyPeOfCustomer.Items.Add("Business services");

            lvWaterBill.View = View.Details;
            lvWaterBill.Columns.Add("Customer Name", 200);
            lvWaterBill.Columns.Add("Last Month Water Meter", 200);
            lvWaterBill.Columns.Add("This Month Water Meter", 200);
            lvWaterBill.Columns.Add("Amount Of Consumption", 200);
            lvWaterBill.Columns.Add("Total Water Bill", 200);
        }

        private void cboTyPeOfCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerType = cboTyPeOfCustomer.Text;
            if (customerType == "Household customer")
            {
                txtNumberOfPeople.Enabled = true;
            }
            else
            {
                txtNumberOfPeople.Enabled = false;
                txtNumberOfPeople.Text = "";
            }
        }

        private void btnCaculator_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text.Trim();
            string customerType = cboTyPeOfCustomer.Text;
            int numberOfPeople = 0;
            double LastMonthWaterMeter = 0;
            double thisMothWaterMeter = 0;

            // validated

            if (customerType == "")
            {
                MessageBox.Show("Please enter customer name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsCustomerNameValid(customerName))
            {
                MessageBox.Show("Customer name should only contain letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (customerType == "")
            {
                MessageBox.Show("Please enter customer type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (customerType == "Household customer")
            {
                if (!int.TryParse(txtNumberOfPeople.Text, out numberOfPeople) || numberOfPeople <= 0)
                {
                    MessageBox.Show("Please enter number of people.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!double.TryParse(txtLastMonthWaterMeter.Text, out LastMonthWaterMeter) || LastMonthWaterMeter < 0)
            {
                MessageBox.Show("Please enter last month's water meter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtThisMonthWaterMeter.Text, out thisMothWaterMeter) || thisMothWaterMeter < 0)
            {
                MessageBox.Show("Please enter this month's water meter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (thisMothWaterMeter < LastMonthWaterMeter)
            {
                MessageBox.Show("This month's water meter reading cannot be less than last month's reading.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var waterBill = Calculator(customerType, numberOfPeople, LastMonthWaterMeter, thisMothWaterMeter); // waterBill chua thong tin tien nuoc gom (so nuoc da su dung, tien nuoc cua khach hang)
            // waterbill dang la kieu object
            // waterbill = (Item1, Item2) = (double, double) = (consumption, watermoney)

            // Show result
            ListViewItem item = new ListViewItem(customerName);
            item.SubItems.Add(LastMonthWaterMeter.ToString());
            item.SubItems.Add(thisMothWaterMeter.ToString());
            item.SubItems.Add(waterBill.Item1.ToString());
            item.SubItems.Add(waterBill.Item2.ToString());
            lvWaterBill.Items.Add(item);

            // Store Data
            Invoice invoice = new Invoice
            {
                CustomerName = customerName,
                LastMonthWaterMeter = LastMonthWaterMeter,
                ThisNonthWaterMeter = thisMothWaterMeter,
                Consumption = waterBill.Item1, // waterBill.Item1
                WaterMoney = waterBill.Item2, // waterBill.Item2
            };
            Invoices.Add(invoice);
        }

        private bool IsCustomerNameValid(string name)
        {
            // Check if the name contains only letters and spaces
            foreach (char c in name)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        private (double, double) Calculator(string customerType, int numberOfMember, double lastMonthWaterMeter, double thisMonthWaterMeter)
        {
            double consumption = thisMonthWaterMeter - lastMonthWaterMeter; // so khoi nuoc da su dung
            double waterMoney = 0;

            if (customerType == "Household customer")
            {
                double averagePerson = consumption / numberOfMember; // so luong trung binh moi nguoi = so nuoc da su dung / so thanh vien
                if (averagePerson < 10)
                {
                    waterMoney = consumption * 5973;
                }
                else if (averagePerson >= 10 && averagePerson < 20)
                {
                    waterMoney = consumption * 7052;
                }
                else if (averagePerson >= 20 && averagePerson < 30)
                {
                    waterMoney = consumption * 8699;
                }
                else if (averagePerson >= 30)
                {
                    waterMoney = consumption * 15929;
                }
            }
            else if (customerType == "Administrative agency, public services")
            {
                waterMoney = consumption * 9955;
            }
            else if (customerType == "Production units")
            {
                waterMoney = consumption * 11615;
            }
            else if (customerType == "Business services")
            {
                waterMoney = consumption * 22068;
            }

            waterMoney += (waterMoney * VAT);

            return (consumption, waterMoney);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        public class Invoice
        {
            public string CustomerName { get; set; }
            public double LastMonthWaterMeter { get; set; }
            public double ThisNonthWaterMeter { get; set; }
            public double Consumption { get; set; }
            public double WaterMoney { get; set; }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

            string search = txtSearch.Text.Trim();
            lvWaterBill.Items.Clear();
            bool foundResult = false;
            if (search == "")
            {

                foreach (Invoice invoice in Invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.ThisNonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());
                    lvWaterBill.Items.Add(item);
                }
                foundResult = true;
            }
            else
            {
                foreach (Invoice invoice in Invoices)
                {
                    if (invoice.CustomerName.ToLower().Contains(search))
                    { // CustomerName = abc, search = b => true
                        ListViewItem item = new ListViewItem(invoice.CustomerName);
                        item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.ThisNonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.Consumption.ToString());
                        item.SubItems.Add(invoice.WaterMoney.ToString());
                        lvWaterBill.Items.Add(item);
                        foundResult = true;

                    }
                }
                if (!foundResult)
                {
                    ListViewItem item = new ListViewItem("No result found.");
                    lvWaterBill.Items.Add(item);
                }
            }

        }

        private void txtSearch_TextChanged_2(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            lvWaterBill.Items.Clear();
            bool foundResult = false;
            if (search == "")
            {
                foreach (Invoice invoice in Invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.ThisNonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());
                    lvWaterBill.Items.Add(item);
                }
                foundResult = true;
            }
            else
            {
                foreach (Invoice invoice in Invoices)
                {
                    if (invoice.CustomerName == search)
                    { // CustomerName = abc, search = b => true
                        ListViewItem item = new ListViewItem(invoice.CustomerName);
                        item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.ThisNonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.Consumption.ToString());
                        item.SubItems.Add(invoice.WaterMoney.ToString());
                        lvWaterBill.Items.Add(item);
                        foundResult = true;

                    }
                }
                if (!foundResult)
                {
                    ListViewItem item = new ListViewItem("No result found.");
                    lvWaterBill.Items.Add(item);
                }
            }

        }

        private void lvWaterBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvWaterBill.SelectedItems.Count > 0)
            {
                int index = lvWaterBill.SelectedItems[0].Index;
                if (index >= 0 && index < Invoices.Count)
                {
                    Form2 bill = new Form2(Invoices[index].CustomerName, Invoices[index].LastMonthWaterMeter, Invoices[index].ThisNonthWaterMeter, Invoices[index].Consumption, Invoices[index].WaterMoney);
                    bill.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        private void bntSortByNameZA_Click(object sender, EventArgs e)
        {


            lvWaterBill.Items.Clear();
            for (int i = 0; i < Invoices.Count; i++)
            {

                Invoice tam = Invoices[i];
                for (int j = i + 1; j < Invoices.Count; j++)
                {
                    if (string.Compare(tam.CustomerName, Invoices[j].CustomerName) < 0)
                    {
                        Invoices[i] = Invoices[j];
                        Invoices[j] = tam;
                        tam = Invoices[i];
                    }
                }
            }
            for (int i = 0; i < Invoices.Count; i++)
            {
                ListViewItem item = new ListViewItem(Invoices[i].CustomerName);
                item.SubItems.Add(Invoices[i].LastMonthWaterMeter.ToString());
                item.SubItems.Add(Invoices[i].ThisNonthWaterMeter.ToString());
                item.SubItems.Add(Invoices[i].Consumption.ToString());
                item.SubItems.Add(Invoices[i].WaterMoney.ToString());
                lvWaterBill.Items.Add(item);
            }
        }
    }
}