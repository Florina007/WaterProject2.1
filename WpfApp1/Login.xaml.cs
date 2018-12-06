using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-NKAKESF\SQLEXPRESS; Initial Catalog=WaterLogic2; Integrated Security=true;");
            try
            {
                if(sqlCon.State == System.Data.ConnectionState.Closed)
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(1) FROM Login WHERE Username=@Username AND Password=@Password";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    sqlCmd.Parameters.AddWithValue("@Password", txtPass.Password);

                    int IsValidUser = Convert.ToInt32(sqlCmd.ExecuteScalar());
                    if (IsValidUser == 1)
                    {
                        MainWindow menu = new MainWindow();

                        Login login = new Login();
                        menu.Show();
                        login.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                }
                else
                {
                    MessageBox.Show("Username and Password is required");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
