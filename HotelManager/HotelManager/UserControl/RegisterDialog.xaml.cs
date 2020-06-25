using HandyControl.Controls;
using HandyControl.Data;
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
using System.Net.Http;
using MessageBox = HandyControl.Controls.MessageBox;
using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json.Linq;

namespace HotelManager.UserControl
{
    /// <summary>
    /// Interaction logic for RegisterDialog.xaml
    /// </summary>
    public partial class RegisterDialog 
    {
        static string apiurl = "https://hotelmanagerapi.azurewebsites.net/api/account/";
        HttpClient client = new HttpClient();
        public RegisterDialog()
        {
            InitializeComponent();
            
        }

        void msg()
        {
            MessageBoxResult result = MessageBox.Show("Đăng ký thành công.\nQuay lại đăng nhập?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.Yes)
            {
                ButtonClose.Command.Execute(null);
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Password) && !string.IsNullOrEmpty(txtConfirmPassword.Password) && !string.IsNullOrEmpty(txtName.Text))
            {
                try
                {
                    string comp = string.Concat(apiurl, txtUsername.Text);
                    string LoginString = client.GetStringAsync(comp).Result;
                    JObject rss = JObject.Parse(LoginString);
                    string usrGet = rss["Username"].ToString();
                    if (txtUsername.Text == usrGet)
                    {
                        imgErrorUsername.Visibility = Visibility.Visible;
                        txtUsername.IsError = true;
                        Growl.WarningGlobal("Người dùng đã tồn tại!!\nHãy nhập lại.");
                        if (txtConfirmPassword.Password != txtPassword.Password)
                        {
                            imgErrorPassword.Visibility = Visibility.Visible;
                            Growl.WarningGlobal("Mật khẩu không trùng nhau!!");
                        }
                    }
                }
                catch (Exception)
                {
                    if (txtConfirmPassword.Password != txtPassword.Password)
                    {
                        imgErrorPassword.Visibility = Visibility.Visible;
                        Growl.WarningGlobal("Mật khẩu không trùng nhau!!");
                    } 
                    else
                    {
                        string isAdmin = txtUsername.Text + "admin";
                        if (tgIsAdmin.IsChecked == true)
                        {
                            string _newAccount = " {\"Username\": \"" + isAdmin + "\", \"Pass\": \"" + txtPassword.Password + "\",\"Name\": \"" + txtName.Text + "\"} ";
                            JObject _newAccountO = JObject.Parse(_newAccount);
                            var content = new StringContent(_newAccountO.ToString(), Encoding.UTF8, "application/json");
                            client.PostAsync(apiurl, content);
                            msg();
                        }
                        else
                        {
                            string _newAccount = " {\"Username\": \"" + txtUsername.Text + "\", \"Pass\": \"" + txtPassword.Password + "\",\"Name\": \"" + txtName.Text + "\"} ";
                            JObject _newAccountO = JObject.Parse(_newAccount);
                            var content = new StringContent(_newAccountO.ToString(), Encoding.UTF8, "application/json");
                            client.PostAsync(apiurl, content);
                            msg();
                        }
                    }
                    
                }

            }
            else
            {
                Growl.WarningGlobal("vui lòng điền đủ thông tin!!!");
            }


        }

        private void txtPassword_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (txtPassword.Password.Equals(txtConfirmPassword.Password))
            {
                btnRegister.IsEnabled = true;
            }
            else
            {
                imgErrorPassword.Visibility = Visibility.Visible;
                btnRegister.IsEnabled = false;
            }
                
        
        }

        private void txtUsername_MouseEnter(object sender, MouseEventArgs e)
        {
            imgErrorUsername.Visibility = Visibility.Hidden;
        }

        private void txtConfirmPassword_MouseEnter(object sender, MouseEventArgs e)
        {
            imgErrorPassword.Visibility = Visibility.Hidden;
        }
    }
}
