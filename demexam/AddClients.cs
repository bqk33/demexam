using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace demexam
{
    public partial class AddClients : Form
    {
        DB db = new DB();

        private MySqlCommandBuilder mySqlBuilder = null;

        private MySqlDataAdapter mySqlDataAdapter = null;

        private DataSet dataSet = null;
        public AddClients()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                //SELECT *, 'Delete' AS Command FROM `order`
                //SELECT id_order, discount_percentage, status, client.name AS `Name CL`, phone, service.name FROM `order`, client, service WHERE service.id_service=`order`.id_service AND client.id_client=`order`.id_client
                mySqlDataAdapter = new MySqlDataAdapter("SELECT name, adress, phone FROM `client`", db.getConnect());

                mySqlBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                dataSet = new DataSet();

                mySqlDataAdapter.Fill(dataSet, "client");

                dataGridClients.DataSource = dataSet.Tables["client"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ReloadData()
        {
            try
            {
                dataSet.Tables["client"].Clear();

                mySqlDataAdapter.Fill(dataSet, "client");

                dataGridClients.DataSource = dataSet.Tables["client"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ChoiceAction choiceAction = new ChoiceAction();
            this.Hide();
            choiceAction.ShowDialog();
            this.Close();
        }

        private void AddClients_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            db.openConnect();

            var query = "INSERT INTO `client`(`name`, `adress`, `phone`) VALUES ('" + tboxNameClient.Text + "', '" + tboxAdressClient.Text + "', '" + tboxPhoneClient.Text + "')";

            MySqlCommand cmd = new MySqlCommand(query, db.getConnect());
            cmd.ExecuteNonQuery();

            db.closeConnect();
        }
    }
}
