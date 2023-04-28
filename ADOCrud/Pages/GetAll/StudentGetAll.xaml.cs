using ADOCrud.Domain.Configuration;
using ADOCrud.Service.DTOs.Courses;
using ADOCrud.Service.DTOs.Students;
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
    /// Interaction logic for StudentGetAll.xaml
    /// </summary>
    public partial class StudentGetAll : Page
    {
        public StudentGetAll()
        {
            InitializeComponent();
        }

        IStudentService StudentService = new StudentService();

        private async void getallstudent_click(object sender, RoutedEventArgs e)
        {
            PaginationParams paginationParams = new PaginationParams();
            paginationParams.PageSize = 0;
            paginationParams.PageIndex = 0;

            foreach (var user in await StudentService.GetAllAsync(paginationParams))
            {
                StudentForViewDTO studentData = new StudentForViewDTO();

                studentData.Id = user.Id;
                studentData.FirstName = user.FirstName;
                studentData.LastName = user.LastName;
                studentData.Email = user.Email;
                studentData.CourseId = user.CourseId;

                DataGrid.Items.Add(studentData);
            }
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }

    }
}
