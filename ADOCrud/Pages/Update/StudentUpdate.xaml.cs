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

namespace ADOCrud.Pages.Update
{
    /// <summary>
    /// Interaction logic for StudentUpdate.xaml
    /// </summary>
    public partial class StudentUpdate : Page
    {
        public StudentUpdate()
        {
            InitializeComponent();
        }

        IStudentService StudentService = new StudentService();

        public async void updatestudent_click(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(course.Text);
            int num1 = int.Parse(student_id.Text);

            await StudentService.UpdateAsync(num1,new StudentForUpdateDTO
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
            course.Clear();
            student_id.Clear();
            phone.Clear();

            MessageBox.Show("Student updated successfully");
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }

        
    }
}
