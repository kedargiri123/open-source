using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billing_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 1;
          double totalamount=0;
        private void btnaddtolist_Click(object sender, EventArgs e)
        {
            adddata();
            gettotalamount();
        }
        public void adddata()
        {
            dgvresult.Rows.Add(i, txtproductname.Text, txtquantity.Text, txtrate.Text, txtamount.Text); i++;
        }
        public void gettotalamount()
        {
            for(int i=0;i<dgvresult.Rows.Count;i++)
            {
                totalamount = totalamount + Convert.ToDouble(dgvresult.Rows[i].Cells["amount"].Value.ToString());
            }
            lblgrosstotal.Text = totalamount.ToString();
        }
        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            Double quantity = Convert.ToDouble(txtquantity.Text);
            Double rate = Convert.ToDouble(txtrate.Text);
            Double amount = quantity * rate;
            txtamount.Text = amount.ToString();
        }
    }
}
