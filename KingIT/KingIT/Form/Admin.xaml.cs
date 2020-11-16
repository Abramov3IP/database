using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;
using KingIT.Form;

namespace KingIT
{

    public partial class Admin : Window
    {
        List<Users> tabl = new List<Users>();


        // MySqlConnection connect = new MySqlConnection("server=10.0.7.240;userid=user62;password=wsruser62;" +
        //     "database=user62;port=3306;persistsecurityinfo=True;sslmode=None");
         MySqlConnection connect = new MySqlConnection("server=localhost;userid=root;password=p}V8PZ7qbdDd;" +
            "database=greate;port=3306;persistsecurityinfo=True;sslmode=None");
        public Admin()
        {
            InitializeComponent();
            try
            {
                connect.Open();
                AdminGrid.ClearValue(ItemsControl.ItemsSourceProperty);
                ShowTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных. \n\n\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally
            {
                connect.Close();
            }
        }
        public void ShowTable()
        {
            MySqlCommand cmd = new MySqlCommand("select users.FIO, users.Login, users.Password, users.Role, users.Telephone, users.Gender, users.Foto from users inner join role on users.Role=role.Role", connect);
            try
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                AdminGrid.ItemsSource = dt.DefaultView;
            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }

            try
            {
                connect.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] Fio = reader[0].ToString().Split('*');
                    tabl.Add(new Users { Surname = Fio[0],
                        Name = Fio[1],Patronymic = Fio[2], Login = reader[1].ToString(), Password = Convert.ToInt32(reader[2]), 
                       Role = reader[3].ToString(), Gender = reader[4].ToString(), TeleNum = Convert.ToInt32(reader[5]),
                       Foto = reader[7].ToString()});
                }
            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                AdminGrid.ItemsSource = tabl;
            }
            else
            {
                List<Users> newUsers = new List<Users>();
                newUsers = tabl.FindAll(City => City.Surname.Contains(SearchTextBox.Text));
                AdminGrid.ItemsSource = newUsers;
            }
        }

        private void CoMeCut(object sender, RoutedEventArgs e)
        {
            tabl[AdminGrid.SelectedIndex].Role="Удален";
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            var senderBtn = sender as Button;
            string dd = senderBtn.Content.ToString();
            if (dd == "Редактировать")
            {
                EditingAd MF = new EditingAd();
                MF.Show();
                MF.LoginBox.Text =tabl[AdminGrid.SelectedIndex].Login;
            }
            else
            {
                EditingAd MF = new EditingAd();
                MF.Show();
            }
        }

        private void AdminGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
