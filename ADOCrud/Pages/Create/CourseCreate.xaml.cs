using ADOCrud.Domain.Entities.Courses;
using ADOCrud.Domain.Enums;
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

namespace ADOCrud.Pages.Create
{
    /// <summary>
    /// Interaction logic for CourseCreate.xaml
    /// </summary>
    public partial class CourseCreate : Page
    {
        public CourseCreate()
        {
            InitializeComponent();
        }

        ICourseService CourseService = new CourseService();

        public async void create_click(object sender, System.Windows.RoutedEventArgs e)
        {
            int num = int.Parse(cost.Text);
            await CourseService.CreateAsync(new CourseForCreationDTO
            {
                Name = name.Text,
                Description = description.Text,
                Author = author.Text,
                Cost = num,
                CourseType = ADOCrud.Domain.Enums.CourseType.offline,
                Updated = DateTime.UtcNow,
                Created = DateTime.UtcNow,

            });

            name.Clear();
            description.Clear();
            author.Clear();
            cost.Clear();
            courseType.Clear();

            MessageBox.Show("Course created successfully");
        }

        private void exitbtn_click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }
    }
}
