using ADOCrud.Domain.Configuration;
using ADOCrud.Domain.Entities.Teachers;
using ADOCrud.Service.DTOs.Courses;
using ADOCrud.Service.DTOs.Teachers;
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

namespace ADOCrud.Pages.GetAll
{
    /// <summary>
    /// Interaction logic for TeacherGetAll.xaml
    /// </summary>
    public partial class TeacherGetAll : Page
    {
        public TeacherGetAll()
        {
            InitializeComponent();
        }

        ITeacherService TeacherService = new TeacherService();

        public async void getallteacher_click(object sender, RoutedEventArgs e)
        {
            PaginationParams paginationParams = new PaginationParams();
            paginationParams.PageSize = 0;
            paginationParams.PageIndex = 0;

            foreach (var user in await TeacherService.GetAllAsync(paginationParams))
            {
                TeacherForViewDTO teacherData = new TeacherForViewDTO();

                teacherData.FirstName = user.FirstName;
                teacherData.LastName = user.LastName;
                teacherData.Field = user.Field;
                teacherData.Email = user.Email;
                teacherData.PhoneNumber = user.PhoneNumber;

                DataGrid.Items.Add(teacherData);
            }
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }

    }
}
