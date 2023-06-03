using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinForm_To_Do_List
{
    public partial class Form1 : Form
    {
        private List<Task> tasks;

        public Form1()
        {
            InitializeComponent();

            tasks = new List<Task>();
            listBoxTasks.DataSource = tasks;
            listBoxTasks.DisplayMember = "Description";
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Task newTask = new Task
            {
                Id = tasks.Count + 1,
                Description = txtTask.Text,
                IsCompleted = false
            };

            tasks.Add(newTask);
            listBoxTasks.Refresh();
            textTask.Clear();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                tasks.Remove((Task)listBoxTasks.SelectedItem);
                listBoxTasks.Refresh();
            }
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                Task selectedTask = (Task)listBoxTasks.SelectedItem;
                selectedTask.IsCompleted = true;
                listBoxTasks.Refresh();
            }
        }

        public class Task
        {
            public int Id { get; set; }
            public string? Description { get; set; }
            public bool IsCompleted { get; set; }
        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}