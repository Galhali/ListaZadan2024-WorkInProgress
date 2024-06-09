using ListaZadan.Klasy;
using ListaZadan.Kontrolki;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public UserManager userManager;

        public MainForm()
        {
            InitializeComponent();
            userManager = new UserManager();
            PokazLoginControl();
        }

        public void PokazLoginControl()
        {
            Controls.Clear();
            Controls.Add(new LoginControl(this));
        }

        public void PokazRegisterControl()
        {
            Controls.Clear();
            Controls.Add(new RegisterControl(this));
        }

        public void PokazTasksControl(User user)
        {
            Controls.Clear();
            Controls.Add(new TasksControl(this, user)); 
        }
    }
}
