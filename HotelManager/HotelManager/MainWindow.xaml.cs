using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Tools.Extension;
using HotelManager.Models;
using HotelManager.UserControl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Effects;
using MessageBox = HandyControl.Controls.MessageBox;
using TabControl = HandyControl.Controls.TabControl;
using TabItem = HandyControl.Controls.TabItem;
using TextBox = HandyControl.Controls.TextBox;

namespace HotelManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        static string baseAccountUrl = "https://hotelmanagerapi.azurewebsites.net/api/account/";
        static string baseServicesUrl = "https://hotelmanagerapi.azurewebsites.net/api/services/";
        static string baseRoomUrl = "https://hotelmanagerapi.azurewebsites.net/api/room/";
        static string baseRoomBookUrl = "https://hotelmanagerapi.azurewebsites.net/api/roombook/";
        static string baseCustomerUrl = "https://hotelmanagerapi.azurewebsites.net/api/customer/";
        static string baseServicesUseUrl = "https://hotelmanagerapi.azurewebsites.net/api/servicesuse/";

        static HttpClient client = new HttpClient();

        #region Main
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            txtbRegister.MouseLeftButtonDown += new MouseButtonEventHandler(txtbRegister_MouseLeftButtonDown);
        }
        private void txtbRegister_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Dialog.Show(new RegisterDialog());
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }
        #endregion

        #region Function
        private async void Login()
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Password)) // kiểm tra các ô phải được điền
            {
                LoginLd.Visibility = Visibility.Visible;// cái này chỉ là show cái loading lúc send request đăng nhập
                string urlGetAccountByUsername = string.Concat(baseAccountUrl, txtUsername.Text);//lấy username từ ô username trên GUI
                HttpResponseMessage getAccountByUsername = await client.GetAsync(urlGetAccountByUsername);// tạo 1 request tới cái api của table Account trong database
                if (getAccountByUsername.IsSuccessStatusCode)// nếu có tồn tại cái username người dùng vừa điền
                {
                    var responseBody = getAccountByUsername.Content.ReadAsStringAsync();//tạo 1 biến chưa cái string json  vừa request về
                    JObject rss = JObject.Parse(responseBody.Result); //ép kiểu về dạng object cho dễ truy cập các properties như [username] hay [pass]
                    if (txtPassword.Password == rss["Pass"].ToString()) //check pass người dùng nhập vào trên GUI so sánh với cái properties [Pass]
                    {
                        //vào trong đây có nghĩa là thành công
                        LoginLd.Visibility = Visibility.Hidden; //ẩn cái thanh loading đi
                        Growl.Success("Đăng nhập Thành công!\nXin chào " + rss["Name"].ToString(), "MainWindow");// send thông báo
                        txtbStaffName.Text = rss["Name"].ToString();// lấy tên người dùng theo user name pass vừa login
                        //dưới đây là phân quyền hơi chuối vì không thêm cái properties isAdmin nên phần trực tiếp dựa vào username
                        if ((rss["Username"].ToString()).Contains("admin"))// kiểm tra trong username nếu có cụm từ admin
                        {//đúng thì hiện chữ quản lí
                            txtbStaffRole.Text = "Quản Lý";
                            txtbStaffRole.Foreground = Brushes.Red;
                            mnuItemAccountList.Visibility = Visibility.Visible;
                        }
                        else//sai thì hiện chữ nhân viên
                        {
                            txtbStaffRole.Foreground = Brushes.Black;
                            txtbStaffRole.Text = "Nhân Viên";
                            mnuItemAccountList.Visibility = Visibility.Collapsed;// ẩn các tính năng của mục quản lí
                        }
                        LoginUI.Visibility = Visibility.Hidden; // ẩn giao diện đăng nhập
                        statusbargrid.Visibility = Visibility.Visible; // hiện thanh menu
                        tlMenu.Visibility = Visibility.Visible;// hiện thanh trạng thái
                    }
                    else { LoginLd.Visibility = Visibility.Hidden; Growl.Error("Sai tài khoản hoặc mật khẩu!", "MainWindow"); }
                }
                else { LoginLd.Visibility = Visibility.Hidden; Growl.Error("Sai tài khoản hoặc mật khẩu!", "MainWindow"); }
            }
            else Growl.Warning("Nhập tài khoản hoặc mật khẩu!!", "MainWindow");
        }
        private void LogoutHiden()
        {
            LoginUI.Visibility = Visibility.Visible;
            statusbargrid.Visibility = Visibility.Hidden;
            tlMenu.Visibility = Visibility.Hidden;
            tlAddAccount.Visibility = Visibility.Hidden;
            grpAccountList.Visibility = Visibility.Hidden;
            tlAddServices.Visibility = Visibility.Hidden;
            grpServicesList.Visibility = Visibility.Hidden;
            tlAddRoom.Visibility = Visibility.Hidden;
            grpRoomList.Visibility = Visibility.Hidden;
            grpRoomBookInfo.Visibility = Visibility.Hidden;
            grpRoomBookList.Visibility = Visibility.Hidden;
            grpCustomerList.Visibility = Visibility.Hidden;
            grpCustomerUseServicesAdd.Visibility = Visibility.Hidden;
            grpCustomerBook.Visibility = Visibility.Hidden;
            grpOrderRoomList.Visibility = Visibility.Hidden;
            grpRoomConfirm.Visibility = Visibility.Hidden;
            grpConfirmRoomList.Visibility = Visibility.Hidden;
            grpPayCustomerList.Visibility = Visibility.Hidden;
            grpPayCustomer.Visibility = Visibility.Hidden;
        }
        private async void ListLoad<tblName>(string apiURL, DataGrid datagrid)
        {
            var getList = await client.GetAsync(apiURL);
            if (getList.IsSuccessStatusCode)
            {
                var getResponsestring = await getList.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<tblName>>(getResponsestring);
                datagrid.ItemsSource = result;
                if (datagrid == dtgRoom)
                {
                    int number = dtgRoom.Items.Count;
                    lbRoomNumber.Content = "Số lượng Phòng: " + number.ToString();
                }
                ListLoading.Visibility = Visibility.Hidden;
            }
        }
        private async void ShowRoomBookListOrder()
        {
            var room = await client.GetAsync(baseRoomUrl);
            if (room.IsSuccessStatusCode)
            {
                var getResponsestring = await room.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<TblRoom>>(getResponsestring);
                List<TblRoom> RoomNormal = new List<TblRoom>();
                List<TblRoom> RoomVIP = new List<TblRoom>();
                List<TblRoom> RoomLUXURY = new List<TblRoom>();
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i].IdRoom.StartsWith("T") && !result[i].RStatus.StartsWith("C") && !result[i].RStatus.StartsWith("Đ")) RoomNormal.Add(result[i]);
                    if (result[i].IdRoom.StartsWith("V") && !result[i].RStatus.StartsWith("C") && !result[i].RStatus.StartsWith("Đ")) RoomVIP.Add(result[i]);
                    if (result[i].IdRoom.StartsWith("L") && !result[i].RStatus.StartsWith("C") && !result[i].RStatus.StartsWith("Đ")) RoomLUXURY.Add(result[i]);
                }
                dtgRoomNormal.ItemsSource = RoomNormal;
                dtgRoomVip.ItemsSource = RoomVIP;
                dtgRoomLuxury.ItemsSource = RoomLUXURY;
                ListLoading.Visibility = Visibility.Hidden;
            }
            var customer = await client.GetAsync(baseCustomerUrl);
            if (customer.IsSuccessStatusCode)
            {
                var getResponsestring = await customer.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<TblCustomer>>(getResponsestring);
                for (int i = 0; i < result.Count; i++) cbIdcard.Items.Add(result[i].IdCard);
            }
        }
        private async void ShowConfirmRoomBookList()
        {
            var room = await client.GetAsync(baseRoomUrl);
            if (room.IsSuccessStatusCode)
            {
                var getResponsestring = await room.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<TblRoom>>(getResponsestring);
                List<TblRoom> ConfirmRoomNormal = new List<TblRoom>();
                List<TblRoom> ConfirmRoomVIP = new List<TblRoom>();
                List<TblRoom> ConfirmRoomLUXURY = new List<TblRoom>();
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i].IdRoom.StartsWith("T") && !result[i].RStatus.StartsWith("C") && result[i].RStatus.StartsWith("Đ") || result[i].RStatus.StartsWith("O")) ConfirmRoomNormal.Add(result[i]);
                    if (result[i].IdRoom.StartsWith("V") && !result[i].RStatus.StartsWith("C") && result[i].RStatus.StartsWith("Đ") || result[i].RStatus.StartsWith("O")) ConfirmRoomVIP.Add(result[i]);
                    if (result[i].IdRoom.StartsWith("L") && !result[i].RStatus.StartsWith("C") && result[i].RStatus.StartsWith("Đ") || result[i].RStatus.StartsWith("O")) ConfirmRoomLUXURY.Add(result[i]);
                }
                dtgConfirmRoomNormal.ItemsSource = ConfirmRoomNormal;
                dtgConfirmRoomVip.ItemsSource = ConfirmRoomVIP;
                dtgConfirmRoomLuxury.ItemsSource = ConfirmRoomLUXURY;
                ListLoading.Visibility = Visibility.Hidden;
            }
        }
        private async void CreateAccount(string AccountJson)
        {
            JObject _newAccountO = JObject.Parse(AccountJson);
            var content = new StringContent(_newAccountO.ToString(), Encoding.UTF8, "application/json");
            HttpResponseMessage postAccount = await client.PostAsync(baseAccountUrl, content);
            if (postAccount.IsSuccessStatusCode) { Growl.Success("Tạo thành công!", "MainWindow"); ListLoad<TblAccount>(baseAccountUrl, dtgAccount); }
            else Growl.Warning("Tài khoản đã tồn tại", "MainWindow");
        }
        private async void AddServices(string ServicesJson)
        {
            JObject _newServicesO = JObject.Parse(ServicesJson);
            var content = new StringContent(_newServicesO.ToString(), Encoding.UTF8, "application/json");
            HttpResponseMessage postServices = await client.PostAsync(baseServicesUrl, content);
            if (postServices.IsSuccessStatusCode) { Growl.Success("Tạo thành công!", "MainWindow"); ListLoad<TblServices>(baseServicesUrl, dtgServices); }
            else Growl.Error("Lỗi", "MainWindow");
        }
        private async void AddRoom(string RoomJson)
        {
            JObject _newRoomO = JObject.Parse(RoomJson);
            var content = new StringContent(_newRoomO.ToString(), Encoding.UTF8, "application/json");
            HttpResponseMessage postRoom = await client.PostAsync(baseRoomUrl, content);
            if (postRoom.IsSuccessStatusCode) { Growl.Success("Tạo thành công!", "MainWindow"); ListLoad<TblRoom>(baseRoomUrl, dtgRoom); }
            else Growl.Error("Lỗi", "MainWindow");
        }
        private async void AddServicesUse(string ServicesUseJson)
        {
            JObject _newServicesUseO = JObject.Parse(ServicesUseJson);
            var content = new StringContent(_newServicesUseO.ToString(), Encoding.UTF8, "application/json");
            HttpResponseMessage postServicesuse = await client.PostAsync(baseServicesUseUrl, content);
            if (postServicesuse.IsSuccessStatusCode) Growl.Success("Thêm dịch vụ thành công!!", "MainWindow");
            else Growl.Error("Thêm dịch vụ thất bại!!", "MainWindow");
        }
        private async void LoadInfo(string comboboxText)
        {
            if (cbIdcard.SelectedIndex == -1)
            {
                txtCusInput.Clear();
                cbGenderInput.Text = string.Empty;
                txtPhoneInput.Clear();
                txtAddressInput.Clear();
            }
            else
            {
                HttpResponseMessage customer = await client.GetAsync(baseCustomerUrl + comboboxText);
                if (customer.IsSuccessStatusCode)
                {
                    var responseBody = customer.Content.ReadAsStringAsync();
                    JObject rss = JObject.Parse(responseBody.Result);
                    if (cbIdcard.Text == rss["idCard"].ToString())
                    {
                        txtCusInput.Text = rss["cusName"].ToString();
                        cbGenderInput.Text = rss["cusGender"].ToString();
                        txtPhoneInput.Text = rss["cusPhone"].ToString();
                        txtAddressInput.Text = rss["cusAddress"].ToString();
                    }
                    else
                    {
                        txtCusInput.Clear();
                        cbGenderInput.Text = string.Empty;
                        txtPhoneInput.Clear();
                        txtAddressInput.Clear();
                    }
                }
            }
        }
        private void OrderRoomSelect(DataGrid datagrid, object sender, SelectionChangedEventArgs e)
        {
            DataGrid g = sender as DataGrid;
            if (g != null && e.AddedItems.Count == 0 && e.RemovedItems.Count > 0) g.SelectedItem = e.RemovedItems[0];
            else
            {
                TblRoom room = (TblRoom)datagrid.SelectedItem;
                txtbRoomIDInput.Text = room.IdRoom;
                txtbRoomPriceInput.Text = room.RPrice.ToString();
                txtbRoomTypeInput.Text = room.RType;
            }
        }
        private async void PostRoomBook(string OrderRoomJson, string OrderCustomerjson = "")
        {
            if (string.IsNullOrEmpty(OrderCustomerjson))
            {
                JObject _newRoomBookO = JObject.Parse(OrderRoomJson);
                var contentRoomBook = new StringContent(_newRoomBookO.ToString(), Encoding.UTF8, "application/json");
                HttpResponseMessage postRoomBook = await client.PostAsync(baseRoomBookUrl, contentRoomBook);
                if (postRoomBook.IsSuccessStatusCode)
                {
                    string roomStatusUpdate = " { \"idRoom\": \"" + txtbRoomIDInput.Text + "\",  \"rType\": \"" + txtbRoomTypeInput.Text + "\",  \"rPrice\": " + txtbRoomPriceInput.Text + ",  \"rStatus\": \"Có Khách\" } ";
                    JObject _newRoomStatusUpdatekO = JObject.Parse(roomStatusUpdate);
                    var contentRoom = new StringContent(_newRoomStatusUpdatekO.ToString(), Encoding.UTF8, "application/json");
                    HttpResponseMessage putRoomStatus = await client.PutAsync(baseRoomUrl + txtbRoomIDInput.Text, contentRoom);
                    if (putRoomStatus.IsSuccessStatusCode)
                    {
                        Growl.Success("Đặt phòng Thành Công!!", "MainWindow");
                        ShowRoomBookListOrder();
                    }
                    else Growl.Error("Lỗi đỗi trạng thái phòng", "MainWindow");
                }
                else Growl.Error("Lỗi đặt phòng", "MainWindow");
            }
            else
            {
                JObject _newCustomerO = JObject.Parse(OrderCustomerjson);
                var contentCustomer = new StringContent(_newCustomerO.ToString(), Encoding.UTF8, "application/json");
                HttpResponseMessage postCustomer = await client.PostAsync(baseCustomerUrl, contentCustomer);
                if (postCustomer.IsSuccessStatusCode)
                {
                    JObject _newRoomBookO = JObject.Parse(OrderRoomJson);
                    var contentRoomBook = new StringContent(_newRoomBookO.ToString(), Encoding.UTF8, "application/json");
                    HttpResponseMessage postRoomBook = await client.PostAsync(baseRoomBookUrl, contentRoomBook);
                    if (postRoomBook.IsSuccessStatusCode)
                    {
                        string roomStatusUpdate = " { \"idRoom\": \"" + txtbRoomIDInput.Text + "\",  \"rType\": \"" + txtbRoomTypeInput.Text + "\",  \"rPrice\": " + txtbRoomPriceInput.Text + ",  \"rStatus\": \"Có Khách\" } ";
                        JObject _newRoomStatusUpdatekO = JObject.Parse(roomStatusUpdate);
                        var contentRoom = new StringContent(_newRoomStatusUpdatekO.ToString(), Encoding.UTF8, "application/json");
                        HttpResponseMessage putRoomStatus = await client.PutAsync(baseRoomUrl + txtbRoomIDInput.Text, contentRoom);
                        if (putRoomStatus.IsSuccessStatusCode)
                        {
                            Growl.Success("Đặt phòng Thành Công!!", "MainWindow");
                            ShowRoomBookListOrder();
                        }
                        else Growl.Error("Lỗi đỗi trạng thái phòng", "MainWindow");
                    }
                    else Growl.Error("Lỗi đặt phòng", "MainWindow");
                }
                else Growl.Error("Lỗi thêm mới customer", "MainWindow");
            }
        }
        private async void deteleServicesUse()
        {
            HttpResponseMessage deleteServicesUseById = await client.DeleteAsync(baseServicesUseUrl + lbIdservicesUse.Content.ToString().Split(':').Last().Trim());
            if (deleteServicesUseById.IsSuccessStatusCode)
            {
                Growl.Success("Thành công!", "MainWindow");
                ListLoad<TblRoombook>(baseRoomBookUrl, dtgRoomBook);
            }
            else Growl.Error("Thất bại!", "MainWindow");
        }
        private async void putServicesUse(string editServicesJson, string id)
        {
            JObject _editServicesO = JObject.Parse(editServicesJson);
            var content = new StringContent(_editServicesO.ToString(), Encoding.UTF8, "application/json");
            if (!string.IsNullOrEmpty(txtNewServicesUseNumber.Text))
            {
                HttpResponseMessage putRequestAccountJson = await client.PutAsync(baseServicesUseUrl + id, content);
                if (putRequestAccountJson.IsSuccessStatusCode)
                {
                    Growl.Success("Thành công!", "MainWindow");
                    ListLoad<TblRoombook>(baseRoomBookUrl, dtgRoomBook);
                }
                else Growl.Error("Thất bại!", "MainWindow");
            }
            else Growl.Warning("Nhập số lượng cần sửa", "MainWindow");
        }
        private async void putRoomStatus (string editRoomBookStatusJson, string idroom)
        {
            JObject _editRoomStatusO = JObject.Parse(editRoomBookStatusJson);
            var content = new StringContent(_editRoomStatusO.ToString(), Encoding.UTF8, "application/json");
            HttpResponseMessage putRequestAccountJson = await client.PutAsync(baseRoomUrl + idroom, content);
            if (putRequestAccountJson.IsSuccessStatusCode)
            {
                Growl.Success("Thành công!", "MainWindow");
            }
            else Growl.Error("Thất bại!", "MainWindow");
          
        }
        private void PassConfirmInfo(DataGrid dtgName, object sender, SelectionChangedEventArgs e)
        {
            string staffname = string.Empty;
            string sd = string.Empty;
            string ed = string.Empty;
            string idroom = string.Empty;
            string cusname = string.Empty;
            string idcard = string.Empty;
            string phone = string.Empty;
            string address = string.Empty;

            DataGrid g = sender as DataGrid;
            if (g != null && e.AddedItems.Count == 0 && e.RemovedItems.Count > 0) g.SelectedItem = e.RemovedItems[0];
            else
            {
                TblRoom room = (TblRoom)dtgName.SelectedItem;
                foreach (var item in room.TblRoombook)
                {
                    staffname = item.StaffName;
                    sd = item.StartDate.ToString();
                    ed = item.EndDate.ToString();
                    idroom = item.IdRoom;
                    cusname = item.TblCustomer.CusName;
                    idcard = item.TblCustomer.IdCard;
                    phone = item.TblCustomer.CusPhone;
                    address = item.TblCustomer.CusAddress;
                }
                lbConfirmCusName.Content = "Tên Khách Hàng: " + cusname;
                lbConfirmCusID.Content = "Số CMND: " + idcard;
                lbConfirmCusPhone.Content = "Số Điện Thoại: " + phone;
                lbConfirmCusAdrress.Content = "Địa Chỉ: " + address;
                lbConfirmCusRoomID.Content = "Mã Phòng: " + idroom;
                if (staffname.Contains("Online")) lbConfirmCusStaffName.Content = staffname;
                else lbConfirmCusStaffName.Content = "Tên Nhân Viên: " + staffname;
                lbConfirmCusStartDate.Content = "Ngày Đặt: " + sd.Substring(0, 10);
                lbConfirmCusEndDate.Content = "Ngày Kết Thúc: " + ed.Substring(0, 10);
            }
        }
        private async void LoadPayCustomer(string apiURL, DataGrid datagrid)
        {
            var getList = await client.GetAsync(apiURL);
            if (getList.IsSuccessStatusCode)
            {
                List<TblCustomer> payCustomerRoom = new List<TblCustomer>();
                var getResponsestring = await getList.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<TblCustomer>>(getResponsestring);
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i].TblRoombook != null)
                    {
                        foreach (var item in result[i].TblRoombook)
                        {
                            if (item.TblRoom.RStatus.StartsWith("C"))
                            {
                                payCustomerRoom.Add(result[i]);
                            }
                        }
                    }
                }
                datagrid.ItemsSource = payCustomerRoom.Distinct().ToList() ;
                ListLoading.Visibility = Visibility.Hidden;
            }
        }
        private void LoadPayServices()
        {
            TblCustomer customerinfo = (TblCustomer)dtgPayCustomer.SelectedItem;
            List<TblServices> payServices = new List<TblServices>();
            foreach (var item in customerinfo.TblServicesuse)
            {
                payServices.Add(item.TblServices);
            }

            var queryServices = from s in payServices
                                join su in customerinfo.TblServicesuse on s.IdService equals su.IdService
                                select new
                                {
                                    s.SerName,
                                    s.SerPrice,
                                    su.Number,
                                    Total = s.SerPrice * su.Number
                                };
            dtgPayServicesList.ItemsSource = queryServices;
        }
        #endregion

        #region MenuClick
        private void mnuRoomConfirm_Click(object sender, RoutedEventArgs e)
        {
            ListLoading.Visibility = Visibility.Visible;

            tlAddAccount.Visibility = Visibility.Hidden;
            grpAccountList.Visibility = Visibility.Hidden;
            tlAddServices.Visibility = Visibility.Hidden;
            grpServicesList.Visibility = Visibility.Hidden;
            tlAddRoom.Visibility = Visibility.Hidden;
            grpRoomList.Visibility = Visibility.Hidden;
            grpRoomBookInfo.Visibility = Visibility.Hidden;
            grpRoomBookList.Visibility = Visibility.Hidden;
            grpCustomerList.Visibility = Visibility.Hidden;
            grpCustomerUseServicesAdd.Visibility = Visibility.Hidden;
            grpCustomerBook.Visibility = Visibility.Hidden;
            grpOrderRoomList.Visibility = Visibility.Hidden;
            grpRoomConfirm.Visibility = Visibility.Visible;
            grpConfirmRoomList.Visibility = Visibility.Visible;
            grpPayCustomerList.Visibility = Visibility.Hidden;
            grpPayCustomer.Visibility = Visibility.Hidden;
            ShowConfirmRoomBookList();
        }
        private void mnuRoomOrder_Click(object sender, RoutedEventArgs e)
        {
            ListLoading.Visibility = Visibility.Visible;

            tlAddAccount.Visibility = Visibility.Hidden;
            grpAccountList.Visibility = Visibility.Hidden;
            tlAddServices.Visibility = Visibility.Hidden;
            grpServicesList.Visibility = Visibility.Hidden;
            tlAddRoom.Visibility = Visibility.Hidden;
            grpRoomList.Visibility = Visibility.Hidden;
            grpRoomBookInfo.Visibility = Visibility.Hidden;
            grpRoomBookList.Visibility = Visibility.Hidden;
            grpCustomerList.Visibility = Visibility.Hidden;
            grpCustomerUseServicesAdd.Visibility = Visibility.Hidden;
            grpCustomerBook.Visibility = Visibility.Visible;
            grpOrderRoomList.Visibility = Visibility.Visible;
            grpRoomConfirm.Visibility = Visibility.Hidden;
            grpConfirmRoomList.Visibility = Visibility.Hidden;
            grpPayCustomerList.Visibility = Visibility.Hidden;
            grpPayCustomer.Visibility = Visibility.Hidden;
            ShowRoomBookListOrder();
        }
        private void mnuUseServices_Click(object sender, RoutedEventArgs e)
        {
            ListLoading.Visibility = Visibility.Visible;

            tlAddAccount.Visibility = Visibility.Hidden;
            grpAccountList.Visibility = Visibility.Hidden;
            tlAddServices.Visibility = Visibility.Hidden;
            grpServicesList.Visibility = Visibility.Hidden;
            tlAddRoom.Visibility = Visibility.Hidden;
            grpRoomList.Visibility = Visibility.Hidden;
            grpRoomBookInfo.Visibility = Visibility.Hidden;
            grpRoomBookList.Visibility = Visibility.Hidden;
            grpCustomerList.Visibility = Visibility.Visible;
            grpCustomerUseServicesAdd.Visibility = Visibility.Visible;
            grpCustomerBook.Visibility = Visibility.Hidden;
            grpOrderRoomList.Visibility = Visibility.Hidden;
            grpRoomConfirm.Visibility = Visibility.Hidden;
            grpConfirmRoomList.Visibility = Visibility.Hidden;
            grpPayCustomerList.Visibility = Visibility.Hidden;
            grpPayCustomer.Visibility = Visibility.Hidden;
            ListLoad<TblCustomer>(baseCustomerUrl, dtgCustomer);
        }
        private void mnuRoomChangeRoom_Click(object sender, RoutedEventArgs e)
        {

        }
        private void mnuRoomPaid_Click(object sender, RoutedEventArgs e)
        {
            ListLoading.Visibility = Visibility.Visible;

            tlAddAccount.Visibility = Visibility.Hidden;
            grpAccountList.Visibility = Visibility.Hidden;
            tlAddServices.Visibility = Visibility.Hidden;
            grpServicesList.Visibility = Visibility.Hidden;
            tlAddRoom.Visibility = Visibility.Hidden;
            grpRoomList.Visibility = Visibility.Hidden;
            grpRoomBookInfo.Visibility = Visibility.Hidden;
            grpRoomBookList.Visibility = Visibility.Hidden;
            grpCustomerList.Visibility = Visibility.Hidden;
            grpCustomerUseServicesAdd.Visibility = Visibility.Hidden;
            grpCustomerBook.Visibility = Visibility.Hidden;
            grpOrderRoomList.Visibility = Visibility.Hidden;
            grpRoomConfirm.Visibility = Visibility.Hidden;
            grpConfirmRoomList.Visibility = Visibility.Hidden;
            grpPayCustomerList.Visibility = Visibility.Visible;
            grpPayCustomer.Visibility = Visibility.Visible;
            LoadPayCustomer(baseCustomerUrl, dtgPayCustomer);
        }
        #endregion

        private async void getAccountInfo(string userName)
        {
            var info = await client.GetAsync(baseAccountUrl + userName);
            AccountInfor accountInfo = new AccountInfor();
            if (info.IsSuccessStatusCode)
            {
                var responseBody = info.Content.ReadAsStringAsync();
                JObject rss = JObject.Parse(responseBody.Result);
                if (string.Compare(userName, rss["Username"].ToString())==0)
                {
                    accountInfo.txtbUsername.Text = "TÊN NGƯỜI DÙNG: "+ rss["Username"].ToString();
                }
            }
           
            accountInfo.txtbName.Text = "HỌ TÊN: "+ txtbStaffName.Text;
            accountInfo.txtbRole.Text = "QUYỀN HẠN: "+  txtbStaffRole.Text;

            Dialog.Show(accountInfo);
        }
        #region mnuItemClick
        private void mnuAccountInfo_Click(object sender, RoutedEventArgs e)
        {
            
            getAccountInfo(txtUsername.Text);
        }
        private void mnuItemLogout_Click(object sender, RoutedEventArgs e)
        {
            Growl.Info("Bạn đã đăng xuất!!", "MainWindow");
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.SelectionStart = txtUsername.Text.Length;
            LogoutHiden();

        }
        private void mnuItemAccountList_Click(object sender, RoutedEventArgs e)
        {
            ListLoading.Visibility = Visibility.Visible;

            tlAddAccount.Visibility = Visibility.Visible;
            grpAccountList.Visibility = Visibility.Visible;
            tlAddServices.Visibility = Visibility.Hidden;
            grpServicesList.Visibility = Visibility.Hidden;
            tlAddRoom.Visibility = Visibility.Hidden;
            grpRoomList.Visibility = Visibility.Hidden;
            grpRoomBookInfo.Visibility = Visibility.Hidden;
            grpRoomBookList.Visibility = Visibility.Hidden;
            grpCustomerList.Visibility = Visibility.Hidden;
            grpCustomerUseServicesAdd.Visibility = Visibility.Hidden;
            grpCustomerBook.Visibility = Visibility.Hidden;
            grpOrderRoomList.Visibility = Visibility.Hidden;
            grpRoomConfirm.Visibility = Visibility.Hidden;
            grpConfirmRoomList.Visibility = Visibility.Hidden;
            grpPayCustomerList.Visibility = Visibility.Hidden;
            grpPayCustomer.Visibility = Visibility.Hidden;
            ListLoad<TblAccount>(baseAccountUrl, dtgAccount);
        }
        private void mnuItemServicesList_Click(object sender, RoutedEventArgs e)
        {
            ListLoading.Visibility = Visibility.Visible;

            tlAddAccount.Visibility = Visibility.Hidden;
            grpAccountList.Visibility = Visibility.Hidden;
            tlAddServices.Visibility = Visibility.Visible;
            grpServicesList.Visibility = Visibility.Visible;
            tlAddRoom.Visibility = Visibility.Hidden;
            grpRoomList.Visibility = Visibility.Hidden;
            grpRoomBookInfo.Visibility = Visibility.Hidden;
            grpRoomBookList.Visibility = Visibility.Hidden;
            grpCustomerList.Visibility = Visibility.Hidden;
            grpCustomerUseServicesAdd.Visibility = Visibility.Hidden;
            grpCustomerBook.Visibility = Visibility.Hidden;
            grpOrderRoomList.Visibility = Visibility.Hidden;
            grpRoomConfirm.Visibility = Visibility.Hidden;
            grpConfirmRoomList.Visibility = Visibility.Hidden;
            grpPayCustomerList.Visibility = Visibility.Hidden;
            grpPayCustomer.Visibility = Visibility.Hidden;
            ListLoad<TblServices>(baseServicesUrl, dtgServices);
        }
        private void mnuItemRoomList_Click(object sender, RoutedEventArgs e)
        {
            ListLoading.Visibility = Visibility.Visible;

            tlAddAccount.Visibility = Visibility.Hidden;
            grpAccountList.Visibility = Visibility.Hidden;
            tlAddServices.Visibility = Visibility.Hidden;
            grpServicesList.Visibility = Visibility.Hidden;
            tlAddRoom.Visibility = Visibility.Visible;
            grpRoomList.Visibility = Visibility.Visible;
            grpRoomBookInfo.Visibility = Visibility.Hidden;
            grpRoomBookList.Visibility = Visibility.Hidden;
            grpCustomerList.Visibility = Visibility.Hidden;
            grpCustomerUseServicesAdd.Visibility = Visibility.Hidden;
            grpCustomerBook.Visibility = Visibility.Hidden;
            grpOrderRoomList.Visibility = Visibility.Hidden;
            grpRoomConfirm.Visibility = Visibility.Hidden;
            grpConfirmRoomList.Visibility = Visibility.Hidden;
            grpPayCustomerList.Visibility = Visibility.Hidden;
            grpPayCustomer.Visibility = Visibility.Hidden;
            ListLoad<TblRoom>(baseRoomUrl, dtgRoom);
            
        }
        private void mnuItemRoomBookList_Click(object sender, RoutedEventArgs e)
        {
            ListLoading.Visibility = Visibility.Visible;

            tlAddAccount.Visibility = Visibility.Hidden;
            grpAccountList.Visibility = Visibility.Hidden;
            tlAddServices.Visibility = Visibility.Hidden;
            grpServicesList.Visibility = Visibility.Hidden;
            tlAddRoom.Visibility = Visibility.Hidden;
            grpRoomList.Visibility = Visibility.Hidden;
            grpRoomBookInfo.Visibility = Visibility.Visible;
            grpRoomBookList.Visibility = Visibility.Visible;
            grpCustomerList.Visibility = Visibility.Hidden;
            grpCustomerUseServicesAdd.Visibility = Visibility.Hidden;
            grpCustomerBook.Visibility = Visibility.Hidden;
            grpOrderRoomList.Visibility = Visibility.Hidden;
            grpRoomConfirm.Visibility = Visibility.Hidden;
            grpConfirmRoomList.Visibility = Visibility.Hidden;
            grpPayCustomerList.Visibility = Visibility.Hidden;
            grpPayCustomer.Visibility = Visibility.Hidden;
            ListLoad<TblRoombook>(baseRoomBookUrl, dtgRoomBook);
        }
        #endregion

        #region Account Manager (tblAccount)
        private void dtgAccount_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            TblAccount getCurrentSelectedAccount = (TblAccount)dtgAccount.SelectedItem;
            var curUsername = getCurrentSelectedAccount.Username;
            var newNameEdit = getCurrentSelectedAccount.Name;
            var newPassEdit = getCurrentSelectedAccount.Pass;
            string _editedAcount = " {\"Username\": \"" + curUsername + "\", \"Pass\": \"" + newPassEdit + "\",\"Name\": \"" + newNameEdit + "\"} ";
            JObject _newAccount = JObject.Parse(_editedAcount);
            var content = new StringContent(_newAccount.ToString(), Encoding.UTF8, "application/json");
            HttpResponseMessage putRequestAccountJson = client.PutAsync(baseAccountUrl + curUsername, content).Result;
            if (putRequestAccountJson.IsSuccessStatusCode)
            {
                Growl.Success("Thành công!", "MainWindow");
            }
            else Growl.Error("Thất bại!", "MainWindow");

        }//PUT Request
        private void contextDelete_Click(object sender, RoutedEventArgs e)
        {
            TblAccount account = (TblAccount)dtgAccount.SelectedItem;
            var curUsername = account.Username;
            HttpResponseMessage deleteRequestAccountByUsername = client.DeleteAsync(baseAccountUrl + curUsername).Result;
            if (deleteRequestAccountByUsername.IsSuccessStatusCode)
            {
                Growl.Success("Thành công!", "MainWindow");
                ListLoad<TblAccount>(baseAccountUrl, dtgAccount);
            }
            else Growl.Error("Thất bại!", "MainWindow");
        }//Delete Request
        private void btnAccountRegister_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRegUsername.Text) && !string.IsNullOrEmpty(txtRegPassword.Password) && !string.IsNullOrEmpty(txtRegName.Text))
            {
                string AccountJson = string.Empty;
                if (tgIsAdmin.IsChecked == true)
                {
                    AccountJson = " {\"Username\": \"" + txtRegUsername.Text + "admin" + "\", \"Pass\": \"" + txtRegPassword.Password + "\",\"Name\": \"" + txtRegName.Text + "\"} ";
                    CreateAccount(AccountJson);
                    ListLoad<TblAccount>(baseAccountUrl, dtgAccount);
                }
                else
                {
                    AccountJson = " {\"Username\": \"" + txtRegUsername.Text + "\", \"Pass\": \"" + txtRegPassword.Password + "\",\"Name\": \"" + txtRegName.Text + "\"} ";
                    CreateAccount(AccountJson);
                    ListLoad<TblAccount>(baseAccountUrl, dtgAccount);
                }
            }
        }//Post Request
        #endregion

        #region Services Manager (tblServices)
        private void dtgServices_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            TblServices getCurrentSelectedServices = (TblServices)dtgServices.SelectedItem;
            var IdServices = getCurrentSelectedServices.IdService;
            var newNameEdit = getCurrentSelectedServices.SerName;
            var newPriceEdit = getCurrentSelectedServices.SerPrice;
            var newUnitEdit = getCurrentSelectedServices.SerUnit;
            string _editedServices = " {\"idService\": \"" + IdServices + "\",\"serName\": \"" + newNameEdit + "\",\"serPrice\":" + newPriceEdit + ",\"serUnit\": \"" + newUnitEdit + "\"} ";
            JObject _newServices = JObject.Parse(_editedServices);
            var content = new StringContent(_newServices.ToString(), Encoding.UTF8, "application/json");
            HttpResponseMessage putRequestAccountJson = client.PutAsync(baseServicesUrl + IdServices, content).Result;
            if (putRequestAccountJson.IsSuccessStatusCode)
            {
                Growl.Success("Thành công!", "MainWindow");
            }
            else Growl.Error("Thất bại!", "MainWindow");
        }//PUT Request

        private void contextServicesDelete_Click(object sender, RoutedEventArgs e)
        {
            TblServices services = (TblServices)dtgServices.SelectedItem;
            var curServices = services.IdService;
            HttpResponseMessage deleteCurrentSelectedServicesById = client.DeleteAsync(baseServicesUrl + curServices).Result;
            if (deleteCurrentSelectedServicesById.IsSuccessStatusCode)
            {
                Growl.Success("Thành công!", "MainWindow");
                ListLoad<TblServices>(baseServicesUrl, dtgServices);
            }
            else Growl.Error("Thất bại!", "MainWindow");
        }//Delete Request

        private void btnServivesAdd_Click(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrEmpty(txtServicesName.Text) && !string.IsNullOrEmpty(txtServicesPrice.Text) && !string.IsNullOrEmpty(txtServicesUnit.Text))
            {
                string ServicesJson = string.Empty;
                JArray rss;
                HttpResponseMessage getAccountCount = client.GetAsync(baseServicesUrl).Result;
                if (getAccountCount.IsSuccessStatusCode)
                {
                    var responseBody = getAccountCount.Content.ReadAsStringAsync();
                    rss = JArray.Parse(responseBody.Result);
                    int id = rss.Count + 1;
                    ServicesJson = " {\"idService\": \"DV00" + id + "\",\"serName\": \"" + txtServicesName.Text + "\",\"serPrice\": " + txtServicesPrice.Text + ",\"serUnit\": \"" + txtServicesUnit.Text + "\"} ";
                    AddServices(ServicesJson);
                }
            }
        }//Post Request

        #endregion

        #region Room Manager (tblRoom)
        private void contextRoomDelete_Click(object sender, RoutedEventArgs e)
        {
            TblRoom room = (TblRoom)dtgRoom.SelectedItem;
            var curRoom = room.IdRoom;
            HttpResponseMessage deleteCurrentSelectedRoomById = client.DeleteAsync(baseRoomUrl + curRoom).Result;
            if (deleteCurrentSelectedRoomById.IsSuccessStatusCode)
            {
                Growl.Success("Thành công!", "MainWindow");
                ListLoad<TblRoom>(baseRoomUrl, dtgRoom);
            }
            else Growl.Error("Thất bại!", "MainWindow");
        }//Delete Request
        private void btnRoomAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRoomPrice.Text) && !string.IsNullOrEmpty(cbRoomTypeAdd.Text))
            {
                if (cbRoomTypeAdd.Text.Contains("Thường Đơn"))
                {
                    string thuongdon = "T10";
                    JArray rss;
                    HttpResponseMessage getRoomCount = client.GetAsync(baseRoomUrl).Result;
                    List<string> _room = new List<string>();
                    if (getRoomCount.IsSuccessStatusCode)
                    {
                        var responseBody = getRoomCount.Content.ReadAsStringAsync();
                        rss = JArray.Parse(responseBody.Result);
                        for (int i = 0; i < rss.Count; i++)
                        {
                            if ((rss[i]["idRoom"].ToString()).StartsWith(thuongdon))
                            {
                                _room.Add(rss[i]["idRoom"].ToString());
                            }
                        }
                        int id = _room.Count + 1;
                        string RoomJson = " {\"idRoom\": \"" + thuongdon + "" + id + "\",\"rType\": \"" + cbRoomTypeAdd.Text + "\",\"rPrice\":" + txtRoomPrice.Text + ",\"rStatus\": \"Trống\"} ";
                        AddRoom(RoomJson);
                    }
                }
                else if (cbRoomTypeAdd.Text.Contains("Thường Đôi"))
                {
                    string thuongdoi = "T20";
                    JArray rss;
                    HttpResponseMessage getRoomCount = client.GetAsync(baseRoomUrl).Result;
                    List<string> _room = new List<string>();
                    if (getRoomCount.IsSuccessStatusCode)
                    {
                        var responseBody = getRoomCount.Content.ReadAsStringAsync();
                        rss = JArray.Parse(responseBody.Result);
                        for (int i = 0; i < rss.Count; i++)
                        {
                            if ((rss[i]["idRoom"].ToString()).StartsWith(thuongdoi))
                            {
                                _room.Add(rss[i]["idRoom"].ToString());
                            }
                        }
                        int id = _room.Count + 1;
                        string RoomJson = " {\"idRoom\": \"" + thuongdoi + "" + id + "\",\"rType\": \"" + cbRoomTypeAdd.Text + "\",\"rPrice\":" + txtRoomPrice.Text + ",\"rStatus\": \"Trống\"} ";
                        AddRoom(RoomJson);
                    }
                }
                else if (cbRoomTypeAdd.Text.Contains("VIP Đơn"))
                {
                    string vipdon = "V10";
                    JArray rss;
                    HttpResponseMessage getRoomCount = client.GetAsync(baseRoomUrl).Result;
                    List<string> _room = new List<string>();
                    if (getRoomCount.IsSuccessStatusCode)
                    {
                        var responseBody = getRoomCount.Content.ReadAsStringAsync();
                        rss = JArray.Parse(responseBody.Result);
                        for (int i = 0; i < rss.Count; i++)
                        {
                            if ((rss[i]["idRoom"].ToString()).StartsWith(vipdon))
                            {
                                _room.Add(rss[i]["idRoom"].ToString());
                            }
                        }
                        int id = _room.Count + 1;
                        string RoomJson = " {\"idRoom\": \"" + vipdon + "" + id + "\",\"rType\": \"" + cbRoomTypeAdd.Text + "\",\"rPrice\":" + txtRoomPrice.Text + ",\"rStatus\": \"Trống\"} ";
                        AddRoom(RoomJson);
                    }
                }
                else if (cbRoomTypeAdd.Text.Contains("VIP Đôi"))
                {
                    string vipdoi = "V20";
                    JArray rss;
                    HttpResponseMessage getRoomCount = client.GetAsync(baseRoomUrl).Result;
                    List<string> _room = new List<string>();
                    if (getRoomCount.IsSuccessStatusCode)
                    {
                        var responseBody = getRoomCount.Content.ReadAsStringAsync();
                        rss = JArray.Parse(responseBody.Result);
                        for (int i = 0; i < rss.Count; i++)
                        {
                            if ((rss[i]["idRoom"].ToString()).StartsWith(vipdoi))
                            {
                                _room.Add(rss[i]["idRoom"].ToString());
                            }
                        }
                        int id = _room.Count + 1;
                        string RoomJson = " {\"idRoom\": \"" + vipdoi + "" + id + "\",\"rType\": \"" + cbRoomTypeAdd.Text + "\",\"rPrice\":" + txtRoomPrice.Text + ",\"rStatus\": \"Trống\"} ";
                        AddRoom(RoomJson);
                    }
                }
                else if (cbRoomTypeAdd.Text.Contains("Hạng Sang Đơn"))
                {
                    string luxurydon = "L10";
                    JArray rss;
                    HttpResponseMessage getRoomCount = client.GetAsync(baseRoomUrl).Result;
                    List<string> _room = new List<string>();
                    if (getRoomCount.IsSuccessStatusCode)
                    {
                        var responseBody = getRoomCount.Content.ReadAsStringAsync();
                        rss = JArray.Parse(responseBody.Result);
                        for (int i = 0; i < rss.Count; i++)
                        {
                            if ((rss[i]["idRoom"].ToString()).StartsWith(luxurydon))
                            {
                                _room.Add(rss[i]["idRoom"].ToString());
                            }
                        }
                        int id = _room.Count + 1;
                        string RoomJson = " {\"idRoom\": \"" + luxurydon + "" + id + "\",\"rType\": \"" + cbRoomTypeAdd.Text + "\",\"rPrice\":" + txtRoomPrice.Text + ",\"rStatus\": \"Trống\"} ";
                        AddRoom(RoomJson);
                    }
                }
                else
                {
                    string luxurydoi = "L20";
                    JArray rss;
                    HttpResponseMessage getRoomCount = client.GetAsync(baseRoomUrl).Result;
                    List<string> _room = new List<string>();
                    if (getRoomCount.IsSuccessStatusCode)
                    {
                        var responseBody = getRoomCount.Content.ReadAsStringAsync();
                        rss = JArray.Parse(responseBody.Result);
                        for (int i = 0; i < rss.Count; i++)
                        {
                            if ((rss[i]["idRoom"].ToString()).StartsWith(luxurydoi))
                            {
                                _room.Add(rss[i]["idRoom"].ToString());
                            }
                        }
                        int id = _room.Count + 1;
                        string RoomJson = " {\"idRoom\": \"" + luxurydoi + "" + id + "\",\"rType\": \"" + cbRoomTypeAdd.Text + "\",\"rPrice\":" + txtRoomPrice.Text + ",\"rStatus\": \"Trống\"} ";
                        AddRoom(RoomJson);
                    }
                }
            }
        }//Post Request
        private void cbRoomTypeAdd_DropDownClosed(object sender, EventArgs e)
        {
            if (cbRoomTypeAdd.Text.Contains("Thường Đơn")) txtRoomPrice.Text = "300000";
            else if (cbRoomTypeAdd.Text.Contains("Thường Đôi")) txtRoomPrice.Text = "400000";
            else if (cbRoomTypeAdd.Text.Contains("VIP Đơn")) txtRoomPrice.Text = "600000";
            else if (cbRoomTypeAdd.Text.Contains("VIP Đôi")) txtRoomPrice.Text = "800000";
            else if (cbRoomTypeAdd.Text.Contains("Hạng Sang Đơn")) txtRoomPrice.Text = "1000000";
            else txtRoomPrice.Text = "1300000";
        }
        private void tgIsEditRoomPrice_Checked(object sender, RoutedEventArgs e)
        {
            txtRoomPrice.IsReadOnly = false;
        }
        private void searchRoom_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox searchRoom = (TextBox)sender;
            string filterText = searchRoom.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(dtgRoom.ItemsSource);

            if (!string.IsNullOrEmpty(filterText))
            {
                cv.Filter = o =>
                {
                    TblRoom p = o as TblRoom;
                    return (p.IdRoom.ToUpper().StartsWith(filterText.ToUpper()));
                };
            }
            else ListLoad<TblRoom>(baseRoomUrl, dtgRoom);
        }//Search Bar

        #endregion

        #region Room Book Manager (tblRoombook Model)
        private void dtgRoomBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid g = sender as DataGrid;
            if (g != null && e.AddedItems.Count == 0 && e.RemovedItems.Count > 0)
            {
                g.SelectedItem = e.RemovedItems[0];
            }
            else
            {
                TblRoombook roombook = (TblRoombook)dtgRoomBook.SelectedItem;
                if (roombook.StaffName.Contains("Online")) lbStaffName.Content = roombook.StaffName;
                else lbStaffName.Content = "Nhân Viên Đặt Phòng: " + roombook.StaffName;
                lbRoomBookID.Content = "Mã Phòng Đặt: " + roombook.IdRoombook;
                lbIdRoom.Content = "Mã phòng: " + roombook.IdRoom;
                lbCustomername.Content = "Tên Khách Hàng:  " + roombook.TblCustomer.CusName;
                lbIDCard.Content = "Số CMND: " + roombook.TblCustomer.IdCard;
                lbDateBook.Content = "Ngày Đặt: " + roombook.StartDate.ToString().Substring(0, 10);
                lbDateCheckin.Content = "Ngày Đến: " + roombook.StartDate.ToString().Substring(0, 10);
                lbDateEnd.Content = "Ngày Kết Thúc: " + roombook.EndDate.ToString().Substring(0, 10);
                
                
                List<string> sername = new List<string>();
                DateTime rbStartDate = DateTime.Parse(roombook.StartDate.ToString().Substring(0, 10));
                DateTime rbEndDate = DateTime.Parse(roombook.EndDate.ToString().Substring(0, 10));
                DateTime serviceUsedate = new DateTime();

                foreach (var item in roombook.TblCustomer.TblServicesuse)
                {
                    serviceUsedate = DateTime.Parse(item.DateUse.ToString().Substring(0, 10));
                    if (rbStartDate.Date <= serviceUsedate.Date && serviceUsedate.Date <= rbEndDate.Date) sername.Add(item.TblServices.SerName);
                }

                listboxServices.ItemsSource = sername;
                lbServicesCount.Content = "DỊCH VỤ ĐANG DÙNG: " + listboxServices.Items.Count;
                lbIdservicesUse.Content = "Mã Dịch Vụ Dùng: ";
                lbIdservicesinfomation.Content = "Mã Dịch Vụ: ";
                lbServicesName.Content = "Tên Dịch Vụ: ";
                lbServicesDateUse.Content = "Ngày Dùng: ";
                lbservicesNumber.Content = "Số Lượng: ";
            }
        }

        private void listboxServices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TblRoombook roombook = (TblRoombook)dtgRoomBook.SelectedItem;
            foreach (var item in roombook.TblCustomer.TblServicesuse)
            {
                if (listboxServices.SelectedIndex == -1) { }
                else if (listboxServices.SelectedItem.ToString() == item.TblServices.SerName)
                {
                    lbIdservicesUse.Content = "Mã Dịch Vụ Dùng: " + item.IdServiceuse;
                    lbIdservicesinfomation.Content = "Mã Dịch Vụ: " + item.TblServices.IdService;
                    lbServicesName.Content = "Tên Dịch Vụ: " + item.TblServices.SerName;
                    lbServicesDateUse.Content = "Ngày Dùng: " + item.DateUse.ToString().Substring(0, 10);
                    lbservicesNumber.Content = "Số Lượng: " + item.Number;
                }
            }
        }

        private void btnDeleteServicesUse_Click(object sender, RoutedEventArgs e)
        {
            deteleServicesUse();
        }//Delete Request

        private void btnEditServicesUse_Click(object sender, RoutedEventArgs e)
        {
            var id = lbIdservicesUse.Content.ToString().Split(':').Last().Trim();
            var number = txtNewServicesUseNumber.Text;
            var idservices = lbIdservicesinfomation.Content.ToString().Split(':').Last().Trim();
            var dateuse = Convert.ToDateTime(lbServicesDateUse.Content.ToString().Split(':').Last()).ToString("yyyy-MM-dd").Trim();
            var idCard = lbIDCard.Content.ToString().Split(':').Last().Trim();
            string _editServices = " {\"idServiceuse\": " + id + ",\"idCard\": \"" + idCard + "\",\"idService\": \"" + idservices + "\",\"number\": " + number + ",\"dateUse\": \"" + dateuse + "\"} ";
            putServicesUse(_editServices,id);
        }//Put Request

        private void searchRoomBook_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox searchRoomBook = (TextBox)sender;
            string filterText = searchRoomBook.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(dtgRoomBook.ItemsSource);

            if (!string.IsNullOrEmpty(filterText))
            {
                cv.Filter = o =>
                {
                    TblRoombook p = o as TblRoombook;
                    return (p.IdRoom.ToUpper().StartsWith(filterText.ToUpper()));
                };
            }
            else ListLoad<TblRoombook>(baseRoomBookUrl, dtgRoomBook); 
        }

        #endregion

        #region Add Services (TblServices)
        private void btnUseServicesAdd_Click(object sender, RoutedEventArgs e)
        {
            if (dtgCustomer.SelectedItem == null) Growl.Warning("Hãy chọn khách hàng cần thêm!!", "MainWindow");
            else if (dtgUseServices.SelectedItem == null) Growl.Warning("Hãy chọn dịch vụ cần thêm!!", "MainWindow");
            else
            {
                TblCustomer getCurrentCustomer = (TblCustomer)dtgCustomer.SelectedItem;
                TblServices getCurrentServicesID = (TblServices)dtgUseServices.SelectedItem;
                string selectservicesid = getCurrentServicesID.IdService;
                string idcard = getCurrentCustomer.IdCard;
                int number = Convert.ToInt32(nudNumberServices.Value);
                string date = dtpDateServicesUse.SelectedDate.Value.ToString("yyyy-MM-dd");
                string ServicesUseJson = " {\"idCard\": \"" + idcard + "\",\"idService\": \"" + selectservicesid + "\",\"number\": " + number + ",\"dateUse\": \"" + date + "\"} ";
                AddServicesUse(ServicesUseJson);
            }
        }//Post Request

        private void dtgUseServices_Initialized(object sender, EventArgs e)
        {
            ListLoad<TblServices>(baseServicesUrl, dtgUseServices);
        }//Get request for select servives

        private void searchCustomer_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox searchCustomer = (TextBox)sender;
            string filterText = searchCustomer.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(dtgCustomer.ItemsSource);

            if (!string.IsNullOrEmpty(filterText))
            {
                cv.Filter = o =>
                {
                    TblCustomer p = o as TblCustomer;
                    if (filterText.All(char.IsDigit)) return (p.IdCard.ToUpper().StartsWith(filterText.ToUpper()));
                    else return (p.CusName.ToUpper().StartsWith(filterText.ToUpper()));
                };
            }
            else ListLoad<TblCustomer>(baseCustomerUrl, dtgCustomer);
        }
        #endregion

        #region Order Room (tblCustomer,tblRoomBook,tblRoom)
        private void cbIdcard_KeyUp(object sender, KeyEventArgs e)
        {
            LoadInfo(cbIdcard.Text);
        }
        private void cbIdcard_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbIdcard.SelectedIndex == -1)
            { }
            else LoadInfo(cbIdcard.SelectedItem.ToString());
        }

        private void dtgRoomNormal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OrderRoomSelect(dtgRoomNormal, sender, e);
        }

        private void dtgRoomVip_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OrderRoomSelect(dtgRoomVip, sender, e);
        }

        private void dtgRoomLuxury_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OrderRoomSelect(dtgRoomLuxury, sender, e);
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            string[] items = new string[cbIdcard.Items.Count];
            for (int i = 0; i < cbIdcard.Items.Count; i++) items[i] = cbIdcard.Items[i].ToString();
            string newOrderRoom = " {\"idCard\": \"" + cbIdcard.Text + "\",\"idRoom\": \"" + txtbRoomIDInput.Text + "\",\"startDate\": \"" + Convert.ToDateTime(dtpStartDateOrder.Text).ToString("yyyy-MM-dd").Trim() + "\",\"endDate\": \"" + Convert.ToDateTime(dtpEndDateOrder.Text).ToString("yyyy-MM-dd").Trim() + "\",\"staffName\": \"" + txtbStaffName.Text + "\"} ";
            //"+ txtbStaffName.Text+ "
            string newOrderCustomer = " {\"idCard\": \"" + cbIdcard.Text + "\",\"cusName\": \"" + txtCusInput.Text + "\",\"cusAddress\": \"" + txtAddressInput.Text + "\",\"cusGender\": \"" + cbGenderInput.Text + "\",\"cusPhone\": \"" + txtPhoneInput.Text + "\"} ";
           
            int pos = Array.IndexOf(items, cbIdcard.Text);
            if (pos > -1) PostRoomBook(newOrderRoom);//old
            else PostRoomBook(newOrderRoom, newOrderCustomer);//new

        }//Post Request
        #endregion

        #region Confirm Room
        private void dtgConfirmRoomNormal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PassConfirmInfo(dtgConfirmRoomNormal, sender, e);

        }
        private void dtgConfirmRoomVip_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PassConfirmInfo(dtgConfirmRoomVip, sender, e);
        }
        private void dtgConfirmRoomLuxury_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PassConfirmInfo(dtgConfirmRoomLuxury, sender, e);
        }
        private void btnConfirmRoomBook_Click(object sender, RoutedEventArgs e)
        {
            string roomStatusJson = string.Empty;
            string idrom = lbConfirmCusRoomID.Content.ToString().Split(':').Last().Trim();
            TblRoom roomN = (TblRoom)dtgConfirmRoomNormal.SelectedItem;
            TblRoom roomV = (TblRoom)dtgConfirmRoomVip.SelectedItem;
            TblRoom roomL = (TblRoom)dtgConfirmRoomLuxury.SelectedItem;
            if (idrom.StartsWith("T"))
            {
                roomStatusJson = " { \"idRoom\": \"" + roomN.IdRoom + "\",  \"rType\": \"" + roomN.RType + "\",  \"rPrice\": " + roomN.RPrice + ",  \"rStatus\": \"Có Khách\" } ";
                putRoomStatus(roomStatusJson, roomN.IdRoom);
                ShowConfirmRoomBookList();
            }
            else if (idrom.StartsWith("V"))
            {
                roomStatusJson = " { \"idRoom\": \"" + roomV.IdRoom + "\",  \"rType\": \"" + roomV.RType + "\",  \"rPrice\": " + roomV.RPrice + ",  \"rStatus\": \"Có Khách\" } ";
                putRoomStatus(roomStatusJson, roomV.IdRoom);
                ShowConfirmRoomBookList();
            }
            else
            {
                roomStatusJson = " { \"idRoom\": \"" + roomL.IdRoom + "\",  \"rType\": \"" + roomL.RType + "\",  \"rPrice\": " + roomL.RPrice + ",  \"rStatus\": \"Có Khách\" } ";
                putRoomStatus(roomStatusJson, roomL.IdRoom);
                ShowConfirmRoomBookList();
            }
        }

        #endregion

        #region Room Paid
        private void dtgPayCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtGiveMoney.Text = string.Empty;
            txtbBackMoney.Text = "Trả Lại: ";
            DataGrid g = sender as DataGrid;
            if (g != null && e.AddedItems.Count == 0 && e.RemovedItems.Count > 0) g.SelectedItem = e.RemovedItems[0];
            else
            {
                TblCustomer customerinfo = (TblCustomer)dtgPayCustomer.SelectedItem;
                TblRoombook roombinfo = new TblRoombook();
                List<TblRoom> roominfo = new List<TblRoom>();
                for (int i = 0; i < customerinfo.TblRoombook.Count; i++)
                {
                    roombinfo = (TblRoombook)customerinfo.TblRoombook[i];
                    roominfo.Add(customerinfo.TblRoombook[i].TblRoom);
                }

                lbPayCusName.Content = "Tên Khách: " + customerinfo.CusName;
                lbPayIdCard.Content = "Số CMND: " + customerinfo.IdCard;
                lbPayStartDate.Content = "Ngày Đến: " + roombinfo.StartDate.ToString().Substring(0, 10);
                lbPayEndDate.Content = "Ngày Đi: " + roombinfo.EndDate.ToString().Substring(0, 10);
                dtgPayRoomList.ItemsSource = roominfo;
                DateTime ed = DateTime.Parse(roombinfo.EndDate.ToString().Substring(0, 10));
                DateTime sd = DateTime.Parse(roombinfo.StartDate.ToString().Substring(0, 10));
                var stayDate = ed.Subtract(sd).Days;
                List<int> roomPrice = new List<int>();
                List<int> allRoomPrice = new List<int>();
                foreach (TblRoom item in dtgPayRoomList.Items)
                {
                    roomPrice.Add(item.RPrice.ToInt32());
                }
                for (int i = 0; i < roomPrice.Count; i++)
                {
                    allRoomPrice.Add(roomPrice[i] * stayDate);
                }

                dvdPayTotalRoomPrice.Content = "Thành Tiền: " + (allRoomPrice.Sum().ToString("N0")) + "VND";
                LoadPayServices();
                List<int> servicesPrice = new List<int>();
                List<int> servicesNumber = new List<int>();
                foreach (var item in dtgPayServicesList.Items)
                {
                    string number = item.ToString().Split('=')[3].Split(',').First();
                    string price = item.ToString().Split('=')[2].Split(',').First();
                    servicesPrice.Add(price.ToInt32());
                    servicesNumber.Add(number.ToInt32());
                }
                List<int> serviceTotalPrice = new List<int>(servicesPrice.Zip(servicesNumber, (a, b) => a * b));
                dvdPayTotalServicesPrice.Content = "Tổng Tiền Dịch Vụ: " + serviceTotalPrice.Sum().ToString("N0") + "VND";
                lbPayTotalPrice.Content = "Tổng Thành Tiền: " + ((dvdPayTotalRoomPrice.Content.ToString().Split(':').Last().Trim('V', 'N', 'D').Replace(".", "")).ToInt32() + (dvdPayTotalServicesPrice.Content.ToString().Split(':').Last().Trim('V', 'N', 'D').Replace(".", "")).ToInt32()).ToString("N0") + " VND";

            }
        }

        class MyItem
        {
            public string Date { get; set; }
            public string Name { get; set; }
            public string Number { get; set; }
            public string Price { get; set; }
        }
        private void btnPaid_Click(object sender, RoutedEventArgs e)
        {
            TblCustomer customerinfo = (TblCustomer)dtgPayCustomer.SelectedItem;
            TblRoombook roombinfo = new TblRoombook();
            List<string> idRoomBook = new List<string>();
            List<string> room = new List<string>();
            List<string> idServiceUse = new List<string>();
            for (int i = 0; i < customerinfo.TblRoombook.Count; i++)
            {
                roombinfo = (TblRoombook)customerinfo.TblRoombook[i];
            }
            foreach (var item in customerinfo.TblRoombook)
            {
                room.Add(item.IdRoom);
                idRoomBook.Add(item.IdRoombook.ToString());
            }

            foreach (var item in customerinfo.TblServicesuse)
            {
                idServiceUse.Add(item.IdServiceuse.ToString());
            }

            List<TblServices> payServices = new List<TblServices>();
            foreach (var item in customerinfo.TblServicesuse)
            {
                payServices.Add(item.TblServices);
            }
            if (dtgPayCustomer.SelectedItem != null)
            {
                if (txtGiveMoney.Text != "")
                {
                    txtbBackMoney.Text = "Trả Lại: " + (txtGiveMoney.Text.ToInt32() - (lbPayTotalPrice.Content.ToString().Split(':').Last().Trim('V', 'N', 'D').Replace(".", "").ToInt32())).ToString("N0");
                    InvoiceDialog dl = new InvoiceDialog();
                    dl.txtbIdRoomBook.Text = "Hoá đơn số: " + roombinfo.IdRoombook.ToString();
                    dl.txtbCusName.Text = "Họ Tên                 :     " + customerinfo.CusName;
                    dl.txtbCusGender.Text = "Giới Tính              :     " + customerinfo.CusGender;
                    dl.txtbCusAddress.Text = "Địa Chỉ                 :     " + customerinfo.CusAddress;
                    dl.txtbCusPhone.Text = "Số Điện Thoại      :     " + customerinfo.CusPhone;
                    dl.txtbIdRoom.Text = "Phòng                  :     " + string.Join(",", room);
                    dl.txtbRType.Text = roombinfo.TblRoom.RType;
                    dl.txtbStartDate.Text = roombinfo.StartDate.ToString().Substring(0, 10);
                    dl.txtbEndDate.Text = roombinfo.EndDate.ToString().Substring(0, 10);
                    dl.txtbStayDate.Text = DateTime.Parse(roombinfo.EndDate.ToString().Substring(0, 10)).Subtract(DateTime.Parse(roombinfo.StartDate.ToString().Substring(0, 10))).Days.ToString();
                    dl.txtbStaffname.Text = roombinfo.StaffName;
                    dl.txtbTotalRoomPrice.Text = dvdPayTotalRoomPrice.Content.ToString().Split(':').Last().Trim('V', 'N', 'D').Replace(".", "");
                    dl.txtbTotalPrice.Text = lbPayTotalPrice.Content.ToString().Split(':').Last().Trim('V', 'N', 'D').Replace(".", "");
                    dl.txtbStartDateRoom.Text = roombinfo.StartDate.ToString().Substring(0, 10);

                    foreach (var item in customerinfo.TblServicesuse)
                    {
                        dl.listboxServices.Items.Add(new MyItem { Date = item.DateUse.ToString().Substring(0, 10), Name = item.TblServices.SerName, Number = item.Number.ToString(), Price = item.TblServices.SerPrice.ToString() });
                    }
                    List<string> json = new List<string>();
                    for (int i = 0; i < room.Count; i++)
                    {
                        string roomjson = "{ \"idRoom\": \"" + room[i] + "\",  \"rType\": \"" + roombinfo.TblRoom.RType + "\",  \"rPrice\": " + roombinfo.TblRoom.RPrice + ",  \"rStatus\": \"Trống\" }";
                        json.Add(roomjson);
                    }
                    RoomPaid(baseRoomBookUrl, baseRoomUrl, baseServicesUseUrl, idRoomBook, room, idServiceUse, json);
                    LoadPayCustomer(baseCustomerUrl, dtgPayCustomer);
                    Growl.Ask("Đã Thanh Toán\nBạn có muốn in hoá đơn không ?", isConfirmed =>
                    {
                        if (isConfirmed == true) Dialog.Show(dl);
                        return true;
                    }, "MainWindow");
                }
                else Growl.Warning("Điền Số Tiền Khách Đưa", "MainWindow");
            }
            else Growl.Warning("Chọn Phòng Thanh Toán", "MainWindow");
        }
        private async void RoomPaid(string baseRoomBookUrl, string baseRoomUrl, string baseServicesUseUrl, List<string> idRoomBook, List<string> idRoom, List<string> idServicesUse, List<string> json)
        {
            var serviceDel = new HttpResponseMessage();
            var roomBookDel = new HttpResponseMessage();
            var putRoom = new HttpResponseMessage();

            for (int i = 0; i < idRoomBook.Count; i++)
            {
                roomBookDel = await client.DeleteAsync(baseRoomBookUrl + idRoomBook[i]);
                if (roomBookDel.IsSuccessStatusCode)
                {
                    JObject restoreRoom = JObject.Parse(json[i]);
                    var contentRoom = new StringContent(restoreRoom.ToString(), Encoding.UTF8, "application/json");
                    putRoom = await client.PutAsync(baseRoomUrl + idRoom[i], contentRoom);
                    if (!putRoom.IsSuccessStatusCode) Growl.Error("Lỗi Put phòng", "MainWindow");
                }
                else Growl.Error("Lỗi Xoá roomBook", "MainWondow");
            }
            for (int i = 0; i < idServicesUse.Count; i++) serviceDel = await client.DeleteAsync(baseServicesUseUrl + idServicesUse[i]);
            if (serviceDel.IsSuccessStatusCode) Growl.Success("Đã Thanh Toán!!", "MainWindow");

        } 
        #endregion
    }
}
