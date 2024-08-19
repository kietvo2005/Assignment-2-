using System.Diagnostics.Eventing.Reader;
using System.Drawing.Design;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Asm2
{
    public partial class Form1 : Form
    {
        public List<Invoice> invoices = new List<Invoice>(); // chua mot danh sach cac phan tu invoice      
        public const double VAT = 0.1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTypeOfCustomer.Items.Add("Household customer");
            cboTypeOfCustomer.Items.Add("Administration agency, public services");
            cboTypeOfCustomer.Items.Add("Production units");
            cboTypeOfCustomer.Items.Add("Business services");
            lvWaterBill.View = View.Details;
            lvWaterBill.Columns.Add("Customer Name", 200);
            lvWaterBill.Columns.Add("lastmonthwatermeter", 100);
            lvWaterBill.Columns.Add("thismonthwatermete", 100);
            lvWaterBill.Columns.Add("amount  of comsumption ", 200);
            lvWaterBill.Columns.Add("total water bill ", 150);                              
        }
        private void cboTypeOfCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customertype = cboTypeOfCustomer.Text;
            if (customertype == "Household customer")
            {
                txtNumberOfPeople.Enabled = true;
            }
            else
            {
                txtNumberOfPeople.Enabled = false;
                txtNumberOfPeople.Text = "";
            }
        }

        private void bntCaltulator_Click(object sender, EventArgs e)
        {

            string Customername = txtCustomerName.Text.Trim();
            string Customertype = cboTypeOfCustomer.Text;
            int numberofpeople = 0;
            double lastmonthwatermeter = 0;
            double thismonthwatermeter = 0;

            if (Customername == "")
            {
                MessageBox.Show("Please enter customer name .", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Customertype == "")
            {
                MessageBox.Show("Please enter customer type", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Customertype == "Household customer")
            {
                if (!int.TryParse(txtNumberOfPeople.Text, out numberofpeople) || numberofpeople <= 0)
                {
                    MessageBox.Show("Please enter Number of people.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!double.TryParse(txtLastMonthWaterMeter.Text, out lastmonthwatermeter) || lastmonthwatermeter < 0)
            {
                MessageBox.Show("Please enter Last month water meter .", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtThisMonthWaterMeter.Text, out thismonthwatermeter) || thismonthwatermeter < 0)
            {
                MessageBox.Show("Please enter this  month water meter .", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var waterBill = calculator(Customertype, numberofpeople, lastmonthwatermeter, thismonthwatermeter);
            ListViewItem t = new ListViewItem(Customername);
            t.SubItems.Add(lastmonthwatermeter.ToString());
            t.SubItems.Add(thismonthwatermeter.ToString());
            t.SubItems.Add(waterBill.Item1.ToString());
            t.SubItems.Add(waterBill.Item2.ToString());
            lvWaterBill.Items.Add(t);           
            Invoice invoice = new Invoice
            {
                customerName = Customername,
                lastMonthwatermeter = lastmonthwatermeter,
                thisMonthwatermeter = thismonthwatermeter,
                Consumption = waterBill.Item1,
                Watermoney = waterBill.Item2
            };
            invoices.Add(invoice);
        }

        private (double, double) calculator(string Customertype, int munberofcustomer, double lastmonthwatermeter, double thismonthwatermeter)
        {
            double consumption = thismonthwatermeter - lastmonthwatermeter; 
            double watermoney = 0;
            if (Customertype == "Household customer")
            {
                double averagePerson = consumption / munberofcustomer;
                if (averagePerson < 10)
                {
                    watermoney = consumption * 5973;
                }
                else if (averagePerson >= 10 && averagePerson < 20)
                {
                    watermoney = consumption * 7052;
                }
                else if (averagePerson >= 20 && averagePerson < 30)
                {
                    watermoney = consumption * 8699;
                }
                else if (averagePerson >= 30)
                {
                    watermoney = consumption * 15929;
                }
            }
            else if (Customertype == "Administration agency, public services")
            {
                watermoney = consumption * 9955;

            }
            else if (Customertype == "Production units")
            {
                watermoney = consumption * 11615;
            }
            else if (Customertype == "Business services")
            {
                watermoney = consumption * 22068;
            }
            watermoney += (watermoney * VAT);
            return (consumption, watermoney);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            lvWaterBill.Items.Clear();
            bool foundresults = false;
            if (search == "")
            {
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.customerName);
                    item.SubItems.Add(invoice.lastMonthwatermeter.ToString());
                    item.SubItems.Add(invoice.thisMonthwatermeter.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.Watermoney.ToString());
                    lvWaterBill.Items.Add(item);
                }
                foundresults = true;
            }
            else
            {
                foreach (Invoice invoice in invoices)
                {
                    if (invoice.customerName.ToLower().Contains(search.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(invoice.customerName);
                        item.SubItems.Add(invoice.lastMonthwatermeter.ToString());
                        item.SubItems.Add(invoice.thisMonthwatermeter.ToString());
                        item.SubItems.Add(invoice.Consumption.ToString());
                        item.SubItems.Add(invoice.Watermoney.ToString());
                        lvWaterBill.Items.Add(item);
                        foundresults = true;

                    }
                }
            }
            if (!foundresults)
            {
                ListViewItem item = new ListViewItem("No results found.");
                lvWaterBill.Items.Add(item);
            }
        }

        private void bntSortByName_Click(object sender, EventArgs e)
        {

            lvWaterBill.Items.Clear();
            for (int i = 0; i < invoices.Count; i++)
            {
                Invoice tam = invoices[i];
                for (int j = i + 1; j < invoices.Count; j++)
                {
                    if (string.Compare(tam.customerName, invoices[j].customerName) > 0)
                    {
                        invoices[i] = invoices[j];
                        invoices[j] = tam;
                        tam = invoices[i];



                    }
                }

            }

            for (int i = 0; i < invoices.Count; i++)
            {
                ListViewItem item = new ListViewItem(invoices[i].customerName);
                item.SubItems.Add(invoices[i].lastMonthwatermeter.ToString());
                item.SubItems.Add(invoices[i].thisMonthwatermeter.ToString());
                item.SubItems.Add(invoices[i].Consumption.ToString());
                item.SubItems.Add(invoices[i].Watermoney.ToString());
                lvWaterBill.Items.Add(item);
            }

        }

        private void bntSortByNameZA_Click(object sender, EventArgs e)
        {


            lvWaterBill.Items.Clear();
            for (int i = 0; i < invoices.Count; i++)
            {
                Invoice tam = invoices[i];
                for (int j = i + 1; j < invoices.Count; j++)
                {
                    if (string.Compare(tam.customerName, invoices[j].customerName) < 0)
                    {
                        tam = invoices[i];
                        invoices[i] = invoices[j];
                        invoices[j] = tam;            
                    }
                }

            }
            for (int i = 0; i < invoices.Count; i++)
            {
                ListViewItem item = new ListViewItem(invoices[i].customerName);
                item.SubItems.Add(invoices[i].lastMonthwatermeter.ToString());
                item.SubItems.Add(invoices[i].thisMonthwatermeter.ToString());
                item.SubItems.Add(invoices[i].Consumption.ToString());
                item.SubItems.Add(invoices[i].Watermoney.ToString());
                lvWaterBill.Items.Add(item);
            }
        }

        private void lvWaterBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = lvWaterBill.SelectedItems[0].Index;
                Invoice invoice = invoices[index];
                if (lvWaterBill.SelectedItems.Count > 0)
                {
                    Form2 form2 = new Form2(invoice.customerName, invoice.lastMonthwatermeter, invoice.thisMonthwatermeter, invoice.Consumption, invoice.Watermoney);
                    form2.Show();
                }
            } catch { }
            
        }
    }
    public class Invoice
    {
        public string customerName {  get  ; set; }
        public double lastMonthwatermeter { get; set; }
        public double thisMonthwatermeter { get; set; }
        public double Consumption { get; set; }
        public double Watermoney { get; set; }
    }

}


