using ADOCrud.Data.Repository;
using ADOCrud.Domain.Configuration;
using ADOCrud.Domain.Entities.Courses;
using ADOCrud.Service.DTOs.Courses;
using ADOCrud.Service.Interfaces;
using ADOCrud.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    /// Interaction logic for CourseGetAll.xaml
    /// </summary>
    public partial class CourseGetAll : Page
    {
        public CourseGetAll()
        {
            InitializeComponent();
        }

        ICourseService CourseService = new CourseService();

        private async void getallcourse_click(object sender, RoutedEventArgs e)
        {
            PaginationParams paginationParams = new PaginationParams();
            paginationParams.PageSize = 0;
            paginationParams.PageIndex = 0;

            foreach (var user in await CourseService.GetAllAsync(paginationParams))
            {
                CourseForViewDTO courseData = new CourseForViewDTO();
                courseData.Name = user.Name;
                courseData.Description = user.Description;
                courseData.Author = user.Author;
                courseData.Cost = user.Cost;
                DataGrid.Items.Add(courseData);
            }
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }

    }
}
