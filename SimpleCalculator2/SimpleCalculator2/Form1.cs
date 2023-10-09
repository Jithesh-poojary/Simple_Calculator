using System.Data;

namespace SimpleCalculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtTotal.Text = "";
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            string equation = txtTotal.Text;
            var result = new DataTable().Compute(equation, null);
            txtTotal.Text = result.ToString();
        }

        private void btn(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtTotal.Text = txtTotal.Text + button.Text;
        }
    }
}