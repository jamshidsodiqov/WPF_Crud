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

namespace ADOCrud.Pages.Update
{
    /// <summary>
    /// Interaction logic for UpdateSelectPage.xaml
    /// </summary>
    public partial class UpdateSelectPage : Page
    {
        public UpdateSelectPage()
        {
            InitializeComponent();
        }

        private void updatestudent_click(object sender, RoutedEventArgs e)
        {
            updateFrame.Content = new StudentUpdate();
        }

        private void updatecourse_click(object sender, RoutedEventArgs e)
        {
            updateFrame.Content = new CourseUpdate();
        }

        private void updateteacher_click(object sender, RoutedEventArgs e)
        {
            updateFrame.Content = new TeacherUpdate();
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }
    }
}
