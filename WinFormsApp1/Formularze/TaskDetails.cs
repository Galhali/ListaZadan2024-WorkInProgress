using ListaZadan.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaZadan.Formularze
{
    public partial class TaskDetails : Form
    {
        public TodoTask todoTask;
        public bool IsSaved;

        public TaskDetails(TodoTask task)
        {
            InitializeComponent();
            todoTask = task;
            lblNumer.Text = todoTask.Id.ToString();
            tbTitle.Text = todoTask.Title;
            tbDescription.Text = todoTask.Description;
            cbIsReady.Checked = task.IsFinished;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            todoTask.Title = tbTitle.Text;
            todoTask.Description = tbDescription.Text;
            todoTask.IsFinished = cbIsReady.Checked;
            IsSaved = true;
            Close();
        }
    }
}
