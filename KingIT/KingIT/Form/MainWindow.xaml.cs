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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace KingIT
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int EntryCol = 0;
       
        MySqlConnection connect = new MySqlConnection("server=localhost;user id=user57;password=wsruser57;database=user57;persistsecurityinfo=True;port=3306;sslmode=None");

       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            string Role = null;
            if (EntryCol < 3)
            {
                try
                {
                    MySqlCommand command = new MySqlCommand("select * from users where Login='" + textLogin.Text.Trim() + "'and Password='"+ textPass.Text.Trim() + "';", connect);
                    connect.Open();
                    MySqlDataReader data = command.ExecuteReader();
                    if (data.Read())
                    {
                        Role = data[3].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Неверно введен Логин или Пароль.");
                    }
                    SelectRole(Role);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка соединения с базой данных. \n\n\n\nПодрабнее:\n" + ex.ToString());
                }
                finally
                {
                    connect.Close();
                }
            }
            else
            {

            }
        }

        public void SelectRole(string role)
        {
            switch (role)
            {
                case "Администратор":
                    Admin MF = new Admin();
                    MF.Show();
                    this.Close();
                    break;
                case "Менеджер А":
                    Console.WriteLine("Case 2");
                    break;
                case "Менеджер С":
                    Console.WriteLine("Case 2");
                    break;
                case "Удален":
                    Console.WriteLine("Case 2");
                    break;

            }
        }

        private void textPass_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String allowchar = " ";

            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
            allowchar += "1,2,3,4,5,6,7,8,9,0";
            char[] a = { ',' };
            String[] ar = allowchar.Split(a);
            String pwd = " ";
            string temp = " ";
            Random r = new Random();

            for (int i = 0; i < 6; i++)
            {
                temp = ar[(r.Next(0, ar.Length))];
                pwd += temp;
            }
            textBox1.Text = pwd;
        }
    }
}
