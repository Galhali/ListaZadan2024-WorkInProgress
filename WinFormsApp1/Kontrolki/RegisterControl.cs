using ListaZadan.Klasy;
using System.Text.RegularExpressions;
using WinFormsApp1;

namespace ListaZadan.Kontrolki
{
    public partial class RegisterControl : UserControl
    {
        private MainForm mainForm;
        public RegisterControl(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            Dock = DockStyle.Fill;
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            mainForm.PokazLoginControl();
        }

        private bool WalidujFormularz()
        {
            lblLoginWalidacja.Visible = false;
            lblImieWalidacja.Visible = false;
            lblHasloWalidacja.Visible = false;
            lblPowtorzHasloWalidacja.Visible = false;

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMin8Char = new Regex(@".{8,}");
            var hasSpecialChar = new Regex(@".*?[!@#\$&*~]");

            bool czyWszystkoPoprawne = true;

            if (string.IsNullOrWhiteSpace(tbImie.Text))
            {
                lblImieWalidacja.Text = "Imię jest wymagane";
                lblImieWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }

            if (string.IsNullOrWhiteSpace(tbLogin.Text))
            {
                lblLoginWalidacja.Text = "Login jest wymagany";
                lblLoginWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }
            else if (!mainForm.userManager.CzyLoginWolny(tbLogin.Text))
            {
                lblLoginWalidacja.Text = "Podany login jest już zajęty";
                lblLoginWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }

            if (string.IsNullOrWhiteSpace(tbHaslo.Text))
            {
                lblHasloWalidacja.Text = "Hasło jest wymagane";
                lblHasloWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }
            else if (!hasNumber.IsMatch(tbHaslo.Text))
            {
                lblHasloWalidacja.Text = "Hasło musi posiadać conajmniej jedną cyfrę";
                lblHasloWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }
            else if (!hasUpperChar.IsMatch(tbHaslo.Text))
            {
                lblHasloWalidacja.Text = "Hasło musi posiadać conajmniej jedną dużą literę";
                lblHasloWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }
            else if (!hasMin8Char.IsMatch(tbHaslo.Text))
            {
                lblHasloWalidacja.Text = "Hasło musi posiadać conajmniej osiem znaków";
                lblHasloWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }
            else if (!hasSpecialChar.IsMatch(tbHaslo.Text))
            {
                lblHasloWalidacja.Text = "Hasło musi posiadać conajmniej jeden znak specjalny np. !@#$&*~";
                lblHasloWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }

            if (string.IsNullOrWhiteSpace(tbPowtorzHaslo.Text))
            {
                lblPowtorzHasloWalidacja.Text = "Powtórzenie hasła jest wymagane";
                lblPowtorzHasloWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }
            else if (!string.IsNullOrWhiteSpace(tbHaslo.Text) && !string.IsNullOrWhiteSpace(tbPowtorzHaslo.Text))
            {
                if (tbHaslo.Text != tbPowtorzHaslo.Text)
                {
                    lblPowtorzHasloWalidacja.Text = "Podane hasła są różne";
                    lblPowtorzHasloWalidacja.Visible = true;
                    czyWszystkoPoprawne = false;
                }
            }

            return czyWszystkoPoprawne;
        }

        private void btnZarejestruj_Click(object sender, EventArgs e)
        {
            if(WalidujFormularz())
            {
                User newUser = new User(Guid.NewGuid().ToString(), tbImie.Text, tbLogin.Text, tbHaslo.Text);
                mainForm.userManager.DodajUzytkownika(newUser);
                mainForm.PokazTasksControl(newUser);
            }
        }
    }
}
