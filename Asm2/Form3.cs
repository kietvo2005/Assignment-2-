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
    public partial class Form3 : Form
    {
        public Form3(string CustomerName, double lastMonthwatermeter, double thisMonthwatermeter, double Consumption, double Watermoney)
        {
            InitializeComponent();
            lbCustomerName.Text = CustomerName;
            lbLastMonthWaterMeter.Text = lastMonthwatermeter.ToString();
            lbThisMonthWaterMeter.Text = thisMonthwatermeter.ToString();
            lbConsumption.Text = Consumption.ToString();
            lbWaterMoney.Text = Watermoney.ToString();


        }
    }
}
