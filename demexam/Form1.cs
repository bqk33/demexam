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
    public partial class Form1 : Form
    {
        DB db = new DB();
        //MySqlConnection connect = new MySqlConnection("server=localhost;uid=root;" +
        //        "database=dbexam");
        //public void openConnect()
        //{
        //    if (connect.State == System.Data.ConnectionState.Closed)
        //        connect.Open();
        //}
        //public void closeConnect()
        //{
        //    if (connect.State == System.Data.ConnectionState.Open)
        //        connect.Close();
        //}
        //public MySqlConnection getConnect()
        //{
        //    return connect;
        //}
        public Form1()
        {
            InitializeComponent();
            //MySqlConnection connect;
            //string myConnectionString;

            //myConnectionString = "server=localhost;uid=root;" +
            //    "database=dbexam";

            //try
            //{
            //    connect = new MySqlConnection();
            //    connect.ConnectionString = myConnectionString;
            //    connect.Open();
            //    // запрос
            //    string sql = "SELECT login FROM employee";
            //    // объект для выполнения SQL-запроса
            //    MySqlCommand command = new MySqlCommand(sql, connect);
            //    // выполняем запрос и получаем ответ
            //    string name = command.ExecuteScalar().ToString();
            //    // выводим ответ в консоль
            //    MessageBox.Show(name);



                //        //// запрос
                //        //string sql = "SELECT name,description FROM service";
                //        //// объект для выполнения SQL-запроса
                //        //MySqlCommand command = new MySqlCommand(sql, connect);
                //        //// объект для чтения ответа сервера
                //        //MySqlDataReader reader = command.ExecuteReader();
                //        //// читаем результат
                //        //while (reader.Read())
                //        //{
                //        //    // элементы массива [] - это значения столбцов из запроса SELECT
                //        //    MessageBox.Show(reader[0].ToString() + " " + reader[1].ToString());
                //        //}
                //        //reader.Close(); // закрываем reader
                //}
                //catch (MySql.Data.MySqlClient.MySqlException ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            db.openConnect();
            var query = "SELECT id_employee FROM employee WHERE login = '" + tboxLogin.Text + "' AND password = '" + tboxPassword.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnect());
            string result = string.Empty;
            try
            {
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    result = dataReader.GetString(0);
                }

                dataReader.Close();

                if (!string.IsNullOrEmpty(result))
                {
                    this.Hide();
                    Form2 forma2 = new Form2();
                    forma2.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
                    forma2.Show();
                }
                else
                {
                    MessageBox.Show("Неправильно введен логин или пароль.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            db.closeConnect();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                tboxPassword.PasswordChar = (char)0;
            }
            else
            {
                tboxPassword.PasswordChar = '●';
            }
        }

        private void tboxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Используйте только латинскую кириллицу и цифры!", "Внимание");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                db.openConnect();
                MessageBox.Show("Подключен.");
                db.closeConnect();
            }
            catch
            {
                MessageBox.Show("Не подключен.");
            }
        }
    }
}
