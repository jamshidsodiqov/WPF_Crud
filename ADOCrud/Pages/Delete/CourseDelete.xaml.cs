using ADOCrud.Service.Interfaces;
using ADOCrud.Service.Services;
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
    /// Interaction logic for CourseDelete.xaml
    /// </summary>
    public partial class CourseDelete : Page
    {
        public CourseDelete()
        {
            InitializeComponent();
        }

        ICourseService CourseService = new CourseService();

        public async void delete_click(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(deletecourse_id.Text);

            await CourseService.DeleteAsync(num);

            deletecourse_id.Clear();

            MessageBox.Show("Course delete successfully");
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }
    }
}
