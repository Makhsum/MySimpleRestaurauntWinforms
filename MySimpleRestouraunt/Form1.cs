using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySimpleRestouraunt.controllers;

namespace MySimpleRestouraunt
{
  public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Employee employee = new Employee();

        private void submitrequest_Click(object sender, EventArgs e)
        {
           
            int quantity = int.Parse(this.quantity.Text);
            if (Chiken.Checked)
            {
                ChickenOrder chickenOrder = new ChickenOrder(quantity);
                employee.NewRequest(quantity,chickenOrder);
            }
            if (Egg.Checked)
            {
                EggOrder egg = new EggOrder(quantity);
                employee.NewRequest(quantity,egg);
                quality.Text = egg.GetQuality().ToString();
            }
            
            
        }

        private void copyrequest_Click(object sender, EventArgs e)
        {
            employee.CopyRequest();
            employee.Inspect(employee.menuitem);
        }

        private void preparefood_Click(object sender, EventArgs e)
        {
            employee.PrepareFood(employee.menuitem);
            result.Text = employee.PrepareFood(employee.menuitem);
        }
    }
}