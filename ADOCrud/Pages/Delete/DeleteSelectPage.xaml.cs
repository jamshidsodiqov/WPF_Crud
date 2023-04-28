using ADOCrud.Pages.Create;
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

namespace ADOCrud.Pages.Delete
{
    /// <summary>
    /// Interaction logic for DeleteSelectPage.xaml
    /// </summary>
    public partial class DeleteSelectPage : Page
    {
        public DeleteSelectPage()
        {
            InitializeComponent();
        }

        private void deletecourse_click(object sender, RoutedEventArgs e)
        {
            deleteFrame.Content = new CourseDelete();
        }

        private void deletestudent_click(object sender, RoutedEventArgs e)
        {
            deleteFrame.Content = new StudentDelete();
        }

        private void deleteteacher_click(object sender, RoutedEventArgs e)
        {
            deleteFrame.Content = new TeacherDelete();
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }
    }
}
