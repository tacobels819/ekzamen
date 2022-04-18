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

namespace EkzDem1.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddTaskList.xaml
    /// </summary>
    public partial class AddTaskList : Page
    {
        private List<Services.Task> tasks;
        public AddTaskList(Services.TaskList taskList)
        {
            InitializeComponent();
            tasks = new List<Services.Task>();
            tasks.Add(new Services.Task() { Title = "пример", Done = false, Due = DateTime.Now });
            taskName.Text = taskList.Name;
            frameTask.Navigate(new Pages.listTask(tasks));
        }
    }
}
