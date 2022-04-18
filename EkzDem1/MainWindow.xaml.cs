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

namespace EkzDem1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Services.TaskList task = new Services.TaskList() { Name = "Новый лист" };
            ListViewTasks.Items.Add(task);
        }

        private void ListViewTasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var task = (Services.TaskList)ListViewTasks.SelectedItem;
            mainFrame.Navigate(new Pages.AddTaskList(task));
        }
    }
}
