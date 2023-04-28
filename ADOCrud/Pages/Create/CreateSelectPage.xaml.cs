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

namespace ADOCrud.Pages.Create
{
    /// <summary>
    /// Interaction logic for CreateSelectPage.xaml
    /// </summary>
    public partial class CreateSelectPage : Page
    {
        public CreateSelectPage()
        {
            InitializeComponent();
        }

        private void createcourse_click(object sender, RoutedEventArgs e)
        {
            createFrame.Content = new CourseCreate();
        }

        private void createstudent_click(object sender, RoutedEventArgs e)
        {
            createFrame.Content = new StudentCreate();
        }

        private void createteacher_click(object sender, RoutedEventArgs e)
        {
            createFrame.Content = new TeacherCreate();
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }
    }
}
