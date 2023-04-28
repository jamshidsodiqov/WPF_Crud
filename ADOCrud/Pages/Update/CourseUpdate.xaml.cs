using ADOCrud.Service.DTOs.Courses;
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

namespace ADOCrud.Pages.Update
{
    /// <summary>
    /// Interaction logic for CourseUpdate.xaml
    /// </summary>
    public partial class CourseUpdate : Page
    {
        public CourseUpdate()
        {
            InitializeComponent();
        }

        ICourseService CourseService = new CourseService();

        public  void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }

        public async void update_click(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(cost.Text);
            int num1 = int.Parse(id.Text);

            await CourseService.UpdateAsync(num1, new CourseForUpdateDTO
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
            id.Clear();
            courseType.Clear();

            MessageBox.Show("Course updated successfully");
        }
    }
}
