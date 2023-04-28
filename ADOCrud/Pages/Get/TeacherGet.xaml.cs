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
    /// Interaction logic for TeacherGet.xaml
    /// </summary>
    public partial class TeacherGet : Page
    {
        public TeacherGet()
        {
            InitializeComponent();
        }

        ITeacherService TeacherService = new TeacherService();

        public async void getTeacher_click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(get_id.Text);

            var teacher = await TeacherService.GetAsync(c => c.Id == id);

            MessageBox.Show(teacher.FirstName + " " + teacher.LastName + " " + teacher.Field + teacher.Email + " " + teacher.PhoneNumber);
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }
    }
}
