using ADOCrud.Domain.Entities.Courses;
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
    /// Interaction logic for StudentCreate.xaml
    /// </summary>
    public partial class StudentCreate : Page
    {
        public StudentCreate()
        {
            InitializeComponent();
        }

        IStudentService StudentService = new StudentService();

        public async void create_click(object sender, System.Windows.RoutedEventArgs e)
        {
            int num = int.Parse(course.Text);

            await StudentService.CreateAsync(new StudentForCreationDTO
            {
                FirstName = firstname.Text,
                LastName = lastname.Text,
                Email = email.Text,
                Password = password.Password,
                PhoneNumber = phone.Text,
                CourseId = num,
                Updated = DateTime.UtcNow,
                Created = DateTime.UtcNow,

            });

            firstname.Clear();
            lastname.Clear();
            email.Clear();
            password.Clear();
            phone.Clear();
            course.Clear();

            MessageBox.Show("Student created successfully");
        }

        private void exitbtn_click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }
    }
}
