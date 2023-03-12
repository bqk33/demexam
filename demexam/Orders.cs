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
    public partial class Orders : Form
    {
        DB db = new DB();

        private MySqlCommandBuilder mySqlBuilder = null;

        private MySqlDataAdapter mySqlDataAdapter = null;

        private DataSet dataSet = null;

        private bool newRowAdding = false;

        public Orders()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.Manual; // запуск окна в нужной позиции
            //this.Location = new Point(0, 0);
        }

        public void LoadData()
        {
            try
            {
                //SELECT *, 'Delete' AS Command FROM `order`
                //SELECT id_order, discount_percentage, status, client.name AS `Name CL`, phone, service.name FROM `order`, client, service WHERE service.id_service=`order`.id_service AND client.id_client=`order`.id_client
                mySqlDataAdapter = new MySqlDataAdapter("SELECT *, 'Delete' AS Command FROM `orders`", db.getConnect());

                mySqlBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                mySqlBuilder.GetInsertCommand();
                mySqlBuilder.GetUpdateCommand();
                mySqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                mySqlDataAdapter.Fill(dataSet, "orders");

                dataGridOrders.DataSource = dataSet.Tables["orders"];

                for (int i = 0; i < dataGridOrders.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridOrders[7, i] = linkCell;
                }
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
                dataSet.Tables["orders"].Clear();

                mySqlDataAdapter.Fill(dataSet, "orders");

                dataGridOrders.DataSource = dataSet.Tables["orders"];

                for (int i = 0; i < dataGridOrders.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridOrders[7, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serviceComboBox()
        {
            db.openConnect();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `service`", db.getConnect());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            cboxService.DisplayMember = "name";
            cboxService.ValueMember = "id_service";
            cboxService.DataSource = table;
            cboxService.SelectedIndex = -1;

            db.closeConnect();
        }

        private void clientComboBox()
        {
            db.openConnect();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `client`", db.getConnect());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            cboxClient.DisplayMember = "phone";
            cboxClient.ValueMember = "id_client";
            cboxClient.DataSource = table;
            cboxClient.SelectedIndex = -1;

            db.closeConnect();
        }

        public int convertPhoneToId(string phone)
        {
            MySqlCommand command = new MySqlCommand($"SELECT id_client FROM client WHERE phone='{phone}'", db.getConnect());

            int id = Int32.Parse(command.ExecuteScalar().ToString());

            return id;
        }

        public int convertNameToId(string name)
        {
            MySqlCommand command = new MySqlCommand($"SELECT id_service FROM service WHERE name='{name}'", db.getConnect());

            int id = Int32.Parse(command.ExecuteScalar().ToString());

            return id;
        }
        
        public void addData()
        {
            db.openConnect();

            var query = "INSERT INTO `orders`(`discount_percentage`, `status`, `timee`, `id_client`, `id_employee`, `id_service`) VALUES (" + tboxPercent.Text + ", 1, '" + dateTimeOrder.Text + "', " +
                convertPhoneToId(cboxClient.Text) + ", 1, " + convertNameToId(cboxService.Text) + ")";

            MySqlCommand cmd = new MySqlCommand(query, db.getConnect());
            cmd.ExecuteNonQuery();

            db.closeConnect();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
            serviceComboBox();
            clientComboBox();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            addData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ChoiceAction choiceAction = new ChoiceAction();
            this.Hide();
            choiceAction.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 7)
                {
                    string task = dataGridOrders.Rows[e.RowIndex].Cells[7].Value.ToString();

                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;

                            dataGridOrders.Rows.RemoveAt(rowIndex);

                            dataSet.Tables["orders"].Rows[rowIndex].Delete();

                            mySqlDataAdapter.Update(dataSet, "orders");
                        }
                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;

                        dataSet.Tables["orders"].Rows[r]["discount_percentage"] = dataGridOrders.Rows[r].Cells["discount_percentage"].Value;
                        dataSet.Tables["orders"].Rows[r]["status"] = dataGridOrders.Rows[r].Cells["status"].Value;
                        dataSet.Tables["orders"].Rows[r]["timee"] = dataGridOrders.Rows[r].Cells["timee"].Value;
                        dataSet.Tables["orders"].Rows[r]["id_client"] = dataGridOrders.Rows[r].Cells["id_client"].Value;
                        dataSet.Tables["orders"].Rows[r]["id_employee"] = dataGridOrders.Rows[r].Cells["id_employee"].Value;
                        dataSet.Tables["orders"].Rows[r]["id_service"] = dataGridOrders.Rows[r].Cells["id_service"].Value;

                        mySqlDataAdapter.Update(dataSet, "orders");

                        dataGridOrders.Rows[e.RowIndex].Cells[7].Value = "Delete";
                    }


                    ReloadData();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dataGridOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(newRowAdding == false)
                {
                    int rowIndex = dataGridOrders.SelectedCells[0].RowIndex;

                    DataGridViewRow editingRow = dataGridOrders.Rows[rowIndex];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridOrders[7, rowIndex] = linkCell;

                    editingRow.Cells["Command"].Value = "Update";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
