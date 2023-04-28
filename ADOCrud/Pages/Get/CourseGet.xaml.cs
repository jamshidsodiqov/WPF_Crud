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

namespace ADOCrud.Pages.Get
{
    /// <summary>
    /// Interaction logic for CourseGet.xaml
    /// </summary>
    public partial class CourseGet : Page
    {
        public CourseGet()
        {
            InitializeComponent();
        }

        ICourseService CourseService = new CourseService();

        public async void get_click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(get_id.Text);

            var course = await CourseService.GetAsync(c => c.Id == id);

            MessageBox.Show(course.Name + " " + course.Description + " "  + course.Author + " " + course.Cost + " " + course.CourseType);
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }
    }
}
