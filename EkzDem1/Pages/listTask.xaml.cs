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
    /// Логика взаимодействия для listTask.xaml
    /// </summary>
    public partial class listTask : Page
    {
        public listTask(List<Services.Task> tasks)
        {
            InitializeComponent();
            ListViewTasks.ItemsSource = tasks;
        }
    }
}
