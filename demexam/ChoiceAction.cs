using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demexam
{
    public partial class ChoiceAction : Form
    {
        public ChoiceAction()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void btnOpenAddClients_Click(object sender, EventArgs e)
        {
            AddClients addClients = new AddClients();
            this.Hide();
            addClients.ShowDialog();
            this.Close();
        }

        private void btnOpenOrders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            this.Hide();
            orders.ShowDialog();
            this.Close();
        }
    }
}
