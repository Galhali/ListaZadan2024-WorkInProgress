using ListaZadan.Formularze;
using ListaZadan.Klasy;
using WinFormsApp1;

namespace ListaZadan.Kontrolki
{
    public partial class TasksControl : UserControl
    {
        private MainForm mainForm;
        private User loggedIn;
        private TodoTaskManager todoTaskManager;
        public TasksControl(MainForm manForm, User user)
        {
            InitializeComponent();
            this.mainForm = manForm;

            loggedIn = user;
            lblZalogowany.Text = loggedIn.Imie;

            todoTaskManager = new TodoTaskManager();
            todoTaskManager.ZaladujZadaniaUzytkownika(loggedIn.Id);

            foreach (TodoTask task in todoTaskManager.PobierzZadania(loggedIn.Id))
            {
                DodajZadanieDoListy(task);
            }

            Dock = DockStyle.Fill;
        }

        public void DodajZadanieDoListy(TodoTask task)
        {
            ListViewItem listItem = new ListViewItem(task.Id.ToString());
            listItem.SubItems.Add(task.Title);
            string zrobione = task.IsFinished ? "✓" : "✘";
            listItem.SubItems.Add(zrobione);

            lvZadania.Items.Add(listItem);
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            mainForm.PokazLoginControl();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            long id = todoTaskManager.ObliczNastepneId();
            TodoTask newTask = new TodoTask(id, loggedIn.Id, "", "", false);
            TaskDetails detailsForm = new TaskDetails(newTask);

            detailsForm.ShowDialog();
            if (detailsForm.IsSaved)
            {
                todoTaskManager.DodaZadanie(newTask);
                DodajZadanieDoListy(newTask);
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (lvZadania.SelectedItems.Count == 0)
            {
                MessageBox.Show("Najpierw zaznacz zadanie.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string taskId = lvZadania.SelectedItems[0].SubItems[0].Text;
                TodoTask task = todoTaskManager.ZnajdzZadanie(int.Parse(taskId));
                TaskDetails detailsForm = new TaskDetails(task);
                detailsForm.ShowDialog();

                if (detailsForm.IsSaved)
                {
                    todoTaskManager.AktualizujZadaniaUzytkownika(loggedIn.Id);
                    lvZadania.SelectedItems[0].SubItems[1].Text = task.Title;
                    lvZadania.SelectedItems[0].SubItems[2].Text = task.IsFinished ? "✓" : "✘";
                }
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (lvZadania.SelectedItems.Count == 0)
            {
                MessageBox.Show("Najpierw zaznacz zadanie.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string taskId = lvZadania.SelectedItems[0].SubItems[0].Text;
                todoTaskManager.UsunZadanie(int.Parse(taskId));
                lvZadania.Items.Remove(lvZadania.SelectedItems[0]);
            }
        }
    }
}
