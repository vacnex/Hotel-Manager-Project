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

namespace HotelManager.UserControl
{
    /// <summary>
    /// Interaction logic for InvoiceDialog.xaml
    /// </summary>
    public partial class InvoiceDialog
    {
        public InvoiceDialog()
        {
            InitializeComponent();
        }

        private void print_Click(object sender, RoutedEventArgs e)
        {
            print.Visibility = Visibility.Hidden;
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(bill, "test");
            }
        }

        private void txtbCurrentDate_Initialized(object sender, EventArgs e)
        {
            txtbCurrentDate.Text = DateTime.Now.ToString("ddd dd/MM/yyyy");
        }
    }
}
