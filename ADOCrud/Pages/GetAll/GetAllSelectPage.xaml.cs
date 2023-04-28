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

namespace ADOCrud.Pages.GetAll
{
    /// <summary>
    /// Interaction logic for GetAllSelectPage.xaml
    /// </summary>
    public partial class GetAllSelectPage : Page
    {
        public GetAllSelectPage()
        {
            InitializeComponent();
        }

        private void getallteacher_click(object sender, RoutedEventArgs e)
        {
            getallFrame.Content = new TeacherGetAll();
        }

        private void getallstudent_click(object sender, RoutedEventArgs e)
        {
            getallFrame.Content = new StudentGetAll();
        }

        private void getallcourse_click(object sender, RoutedEventArgs e)
        {
            getallFrame.Content = new CourseGetAll();
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }

    }
}
