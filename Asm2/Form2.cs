using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asm2
{
    public partial class Form2 : Form
    {
        ListViewItem seleceditem;
        string CustomerName;
        double lastMonthwatermeter;
        double thisMonthwatermeter;
        double Consumption;
        double Watermoney;
        public Form2(string CustomerName, double lastMonthwatermeter, double thisMonthwatermeter, double Consumption, double Watermoney)
        {

            InitializeComponent();
            this.CustomerName = CustomerName;
            this.lastMonthwatermeter = lastMonthwatermeter;
            this.thisMonthwatermeter = thisMonthwatermeter;
            this.Consumption = Consumption;
            this.Watermoney = Watermoney;

            lbCustomerName.Text = CustomerName;
            lbLastMonthWaterMeter.Text = lastMonthwatermeter.ToString() + "  m/s";
            lbThisMonthWaterMeter.Text = thisMonthwatermeter.ToString() + "  m/s";
            lbConsumption.Text = Consumption.ToString();
            lbWaterBill.Text = Watermoney.ToString() + "  $";

        }

        private void bntPayment_Click(object sender, EventArgs e)
        {

          Form3 form3 = new Form3(CustomerName,lastMonthwatermeter,thisMonthwatermeter,Consumption,Watermoney);
            form3.Show();
        }
    }
}
