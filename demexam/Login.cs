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
    public partial class Login : Form
    {
        DB db = new DB();

        public Login()
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
            string type = "employee";
            try
            {
                string result = checkPassword(type);
                if (string.IsNullOrEmpty(result))
                {
                    type = "client";
                    result = checkPassword(type);
                }
                if (!string.IsNullOrEmpty(result) && type == "employee")
                {
                    ChoiceAction choiceAction = new ChoiceAction();
                    this.Hide();
                    choiceAction.ShowDialog();
                    this.Close();
                    //this.Hide();
                    //Orders forma2 = new Orders();
                    //forma2.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
                    //forma2.Show();
                }
                else if (!string.IsNullOrEmpty(result) && type == "client") 
                {
                    //ChoiceAction choiceAction = new ChoiceAction();
                    //this.Hide();
                    //choiceAction.ShowDialog();
                    //this.Close();
                    MessageBox.Show("llooasd");
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

        private string checkPassword(string type)
        {
            var query = $"SELECT id_{type} FROM {type} WHERE login = '" + tboxLogin.Text + "' AND password = '" + tboxPassword.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnect());

            string result = string.Empty;

            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                result = dataReader.GetString(0);
            }

            dataReader.Close();
            return result;
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
            if (!((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
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
