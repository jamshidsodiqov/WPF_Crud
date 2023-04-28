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

namespace ADOCrud.Pages.Get
{
    /// <summary>
    /// Interaction logic for GetSelectPage.xaml
    /// </summary>
    public partial class GetSelectPage : Page
    {
        public GetSelectPage()
        {
            InitializeComponent();
        }

        private void getteacher_click(object sender, RoutedEventArgs e)
        {
            getFrame.Content = new TeacherGet();
        }

        private void getstudent_click(object sender, RoutedEventArgs e)
        {
            getFrame.Content = new StudentGet();
        }

        private void getcourse_click(object sender, RoutedEventArgs e)
        {
            getFrame.Content = new CourseGet();
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }
    }
}
