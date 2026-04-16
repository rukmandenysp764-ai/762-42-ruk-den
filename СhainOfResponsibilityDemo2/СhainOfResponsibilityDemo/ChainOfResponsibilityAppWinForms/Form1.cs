using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainOfResponsibilityAppWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnStart_Click_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();

            Product product = new Product();

            QualityControlClient client = new QualityControlClient();
            client.RunInspection(product);

            foreach (var step in product.InspectionLog)
            {
                lstLog.Items.Add(step);
            }

            if (!product.IsRejectedMethod())
                lblResult.Text = "PASSED";
            else
                lblResult.Text = "REJECTED";
        }


        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


