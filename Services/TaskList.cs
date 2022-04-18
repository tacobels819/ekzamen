using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TaskList
    {
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }
        public string GetName()
        { 
            return Name;
        }
        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }
        public List<Task> GetTasks()
        {
            return Tasks;
        }
        public void Remove(Task task)
        {
            Tasks.Remove(task);
        }
        public List<Task> GetTasksByToday()
        {
            return (List<Task>)Tasks.Where(t => t.Due.Date == DateTime.Now.Date).OrderBy(t => t.Due).ToList();
        }
    }
}
