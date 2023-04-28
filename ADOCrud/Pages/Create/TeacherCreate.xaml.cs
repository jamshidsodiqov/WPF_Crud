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

namespace ADOCrud.Pages.Create
{
    
    public partial class TeacherCreate : Page
    {
        public TeacherCreate()
        {
            InitializeComponent();
        }

        ITeacherService TeacherService = new TeacherService();

        public async void create_click(object sender, RoutedEventArgs e)
        {
            await TeacherService.CreateAsync(new TeacherForCreationDTO
            {
                FirstName = firstname.Text,
                LastName = lastname.Text,
                Field = field.Text,
                Email = email.Text,
                PhoneNumber = phone.Text,
                Updated = DateTime.UtcNow,
                Created = DateTime.UtcNow,
            });

            firstname.Clear();
            lastname.Clear();
            email.Clear();
            field.Clear();
            phone.Clear();

            MessageBox.Show("Teacher created successfully");
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }
    }
}
