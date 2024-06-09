using ListaZadan.Klasy;
using WinFormsApp1;

namespace ListaZadan.Kontrolki
{
    public partial class LoginControl : UserControl
    {
        private MainForm mainForm;

        public LoginControl(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            Dock = DockStyle.Fill;
        }

        private void btnZalozKonto_Click(object sender, EventArgs e)
        {
            mainForm.PokazRegisterControl();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbLogin.Text) || string.IsNullOrWhiteSpace(tbHaslo.Text))
            {
                lblWalidacjaLogowania.Text = "Login i hasło jest wymagane";
                lblWalidacjaLogowania.Visible = true;
            }
            else
            {
                User uzytkownik = mainForm.userManager.WyszukajUzytkownika(tbLogin.Text, tbHaslo.Text);
                if(uzytkownik == null)
                {
                    lblWalidacjaLogowania.Text = "Niepoprawny login lub hasło";
                    lblWalidacjaLogowania.Visible = true;
                }
                else
                {
                    mainForm.PokazTasksControl(uzytkownik);
                }
            }
        }
    }
}
