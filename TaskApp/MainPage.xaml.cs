namespace TaskApp
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Formats.Tar;

    public partial class MainPage : ContentPage
    {
        public ObservableCollection<TaskItem> Tasks { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<TaskItem>();
            taskList.ItemsSource = Tasks;
        }

        private void OnAddTaskClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(taskEntry.Text))
            {
                Tasks.Add(new TaskItem { Name = taskEntry.Text });
                taskEntry.Text = "";
            }
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var task = button.BindingContext as TaskItem;
            Tasks.Remove(task);
        }
    }

    public class TaskItem
    {
        public string Name { get; set; }
    }
}ssss
