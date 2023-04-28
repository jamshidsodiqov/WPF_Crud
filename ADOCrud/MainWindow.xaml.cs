
using ADOCrud.Pages;
using ADOCrud.Pages.Create;
using ADOCrud.Pages.Delete;
using ADOCrud.Pages.Get;
using ADOCrud.Pages.GetAll;
using ADOCrud.Pages.Update;
using System.Windows;

namespace ADOCrud
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void createbtn_click(object sender, RoutedEventArgs e)
        {
            myFrame.Content = new CreateSelectPage();
        }

        private void deletebtn_click(object sender, RoutedEventArgs e)
        {
            myFrame.Content = new DeleteSelectPage();
        }

        private void getallbtn_click(object sender, RoutedEventArgs e)
        {
            myFrame.Content = new GetAllSelectPage();
        }

        private void getbtn_click(object sender, RoutedEventArgs e)
        {
            myFrame.Content = new GetSelectPage();
        }

        private void updatebtn_click(object sender, RoutedEventArgs e)
        {
            myFrame.Content = new UpdateSelectPage();
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
