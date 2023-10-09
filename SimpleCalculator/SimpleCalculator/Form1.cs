using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         private void btnclr_Click(object sender, EventArgs e)
        {
            txtTotal.Text="";
           
        }

       
       

        private void btneql_Click(object sender, EventArgs e)
        {
            string equation = txtTotal.Text;
            var result = new DataTable().Compute(equation, null);
            txtTotal.Text=result.ToString();
        }

        
        

        private void btn(object sender, EventArgs e)
        {
            Button button=(Button)sender;
            txtTotal.Text= txtTotal.Text + button.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
