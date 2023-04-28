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
    /// Interaction logic for TeacherDelete.xaml
    /// </summary>
    public partial class TeacherDelete : Page
    {
        public TeacherDelete()
        {
            InitializeComponent();
        }

        ITeacherService TeacherService = new TeacherService();

        public async void delete_click(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(deleteteacher_id.Text);

            await TeacherService.DeleteAsync(num);

            deleteteacher_id.Clear();

            MessageBox.Show("Teacher delete successfully");
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }
    }
}
