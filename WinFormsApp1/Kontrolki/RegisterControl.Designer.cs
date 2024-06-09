namespace ListaZadan.Kontrolki
{
    partial class RegisterControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            btnCofnij = new Button();
            lblTytulText = new Label();
            gbDaneUzytkownika = new GroupBox();
            lblPowtorzHasloWalidacja = new Label();
            lblHasloWalidacja = new Label();
            lblLoginWalidacja = new Label();
            lblImieWalidacja = new Label();
            tbPowtorzHaslo = new TextBox();
            tbHaslo = new TextBox();
            tbLogin = new TextBox();
            tbImie = new TextBox();
            lblPowtorzHasloText = new Label();
            lblHasloText = new Label();
            lblLoginText = new Label();
            lblImieText = new Label();
            btnZarejestruj = new Button();
            gbDaneUzytkownika.SuspendLayout();
            SuspendLayout();
            // 
            // btnCofnij
            // 
            btnCofnij.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Regular, GraphicsUnit.Point);
            btnCofnij.Location = new Point(19, 25);
            btnCofnij.Margin = new Padding(2);
            btnCofnij.Name = "btnCofnij";
            btnCofnij.Size = new Size(111, 47);
            btnCofnij.TabIndex = 0;
            btnCofnij.Text = "⮜";
            btnCofnij.UseVisualStyleBackColor = true;
            btnCofnij.Click += btnCofnij_Click;
            // 
            // lblTytulText
            // 
            lblTytulText.AutoSize = true;
            lblTytulText.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point);
            lblTytulText.Location = new Point(184, 29);
            lblTytulText.Margin = new Padding(2, 0, 2, 0);
            lblTytulText.Name = "lblTytulText";
            lblTytulText.Size = new Size(210, 44);
            lblTytulText.TabIndex = 1;
            lblTytulText.Text = "Rejestracja";
            // 
            // gbDaneUzytkownika
            // 
            gbDaneUzytkownika.Controls.Add(lblPowtorzHasloWalidacja);
            gbDaneUzytkownika.Controls.Add(lblHasloWalidacja);
            gbDaneUzytkownika.Controls.Add(lblLoginWalidacja);
            gbDaneUzytkownika.Controls.Add(lblImieWalidacja);
            gbDaneUzytkownika.Controls.Add(tbPowtorzHaslo);
            gbDaneUzytkownika.Controls.Add(tbHaslo);
            gbDaneUzytkownika.Controls.Add(tbLogin);
            gbDaneUzytkownika.Controls.Add(tbImie);
            gbDaneUzytkownika.Controls.Add(lblPowtorzHasloText);
            gbDaneUzytkownika.Controls.Add(lblHasloText);
            gbDaneUzytkownika.Controls.Add(lblLoginText);
            gbDaneUzytkownika.Controls.Add(lblImieText);
            gbDaneUzytkownika.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            gbDaneUzytkownika.Location = new Point(15, 100);
            gbDaneUzytkownika.Margin = new Padding(2);
            gbDaneUzytkownika.Name = "gbDaneUzytkownika";
            gbDaneUzytkownika.Padding = new Padding(2);
            gbDaneUzytkownika.Size = new Size(486, 325);
            gbDaneUzytkownika.TabIndex = 2;
            gbDaneUzytkownika.TabStop = false;
            gbDaneUzytkownika.Text = "Dane nowego użytkownika";
            // 
            // lblPowtorzHasloWalidacja
            // 
            lblPowtorzHasloWalidacja.AutoSize = true;
            lblPowtorzHasloWalidacja.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPowtorzHasloWalidacja.ForeColor = Color.Red;
            lblPowtorzHasloWalidacja.Location = new Point(182, 279);
            lblPowtorzHasloWalidacja.Margin = new Padding(2, 0, 2, 0);
            lblPowtorzHasloWalidacja.Name = "lblPowtorzHasloWalidacja";
            lblPowtorzHasloWalidacja.Size = new Size(155, 20);
            lblPowtorzHasloWalidacja.TabIndex = 13;
            lblPowtorzHasloWalidacja.Text = "Labelka na walidacje";
            lblPowtorzHasloWalidacja.TextAlign = ContentAlignment.MiddleRight;
            lblPowtorzHasloWalidacja.Visible = false;
            // 
            // lblHasloWalidacja
            // 
            lblHasloWalidacja.AutoSize = true;
            lblHasloWalidacja.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHasloWalidacja.ForeColor = Color.Red;
            lblHasloWalidacja.Location = new Point(182, 208);
            lblHasloWalidacja.Margin = new Padding(2, 0, 2, 0);
            lblHasloWalidacja.Name = "lblHasloWalidacja";
            lblHasloWalidacja.Size = new Size(155, 20);
            lblHasloWalidacja.TabIndex = 12;
            lblHasloWalidacja.Text = "Labelka na walidacje";
            lblHasloWalidacja.TextAlign = ContentAlignment.MiddleRight;
            lblHasloWalidacja.Visible = false;
            // 
            // lblLoginWalidacja
            // 
            lblLoginWalidacja.AutoSize = true;
            lblLoginWalidacja.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginWalidacja.ForeColor = Color.Red;
            lblLoginWalidacja.Location = new Point(182, 137);
            lblLoginWalidacja.Margin = new Padding(2, 0, 2, 0);
            lblLoginWalidacja.Name = "lblLoginWalidacja";
            lblLoginWalidacja.Size = new Size(155, 20);
            lblLoginWalidacja.TabIndex = 11;
            lblLoginWalidacja.Text = "Labelka na walidacje";
            lblLoginWalidacja.TextAlign = ContentAlignment.MiddleRight;
            lblLoginWalidacja.Visible = false;
            // 
            // lblImieWalidacja
            // 
            lblImieWalidacja.AutoSize = true;
            lblImieWalidacja.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblImieWalidacja.ForeColor = Color.Red;
            lblImieWalidacja.Location = new Point(182, 71);
            lblImieWalidacja.Margin = new Padding(2, 0, 2, 0);
            lblImieWalidacja.Name = "lblImieWalidacja";
            lblImieWalidacja.Size = new Size(155, 20);
            lblImieWalidacja.TabIndex = 10;
            lblImieWalidacja.Text = "Labelka na walidacje";
            lblImieWalidacja.TextAlign = ContentAlignment.MiddleRight;
            lblImieWalidacja.Visible = false;
            // 
            // tbPowtorzHaslo
            // 
            tbPowtorzHaslo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbPowtorzHaslo.Location = new Point(182, 251);
            tbPowtorzHaslo.Margin = new Padding(2);
            tbPowtorzHaslo.Name = "tbPowtorzHaslo";
            tbPowtorzHaslo.Size = new Size(236, 32);
            tbPowtorzHaslo.TabIndex = 9;
            // 
            // tbHaslo
            // 
            tbHaslo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbHaslo.Location = new Point(182, 179);
            tbHaslo.Margin = new Padding(2);
            tbHaslo.Name = "tbHaslo";
            tbHaslo.Size = new Size(236, 32);
            tbHaslo.TabIndex = 8;
            // 
            // tbLogin
            // 
            tbLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbLogin.Location = new Point(182, 109);
            tbLogin.Margin = new Padding(2);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(236, 32);
            tbLogin.TabIndex = 7;
            // 
            // tbImie
            // 
            tbImie.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbImie.Location = new Point(182, 40);
            tbImie.Margin = new Padding(2);
            tbImie.Name = "tbImie";
            tbImie.Size = new Size(236, 32);
            tbImie.TabIndex = 6;
            // 
            // lblPowtorzHasloText
            // 
            lblPowtorzHasloText.AutoSize = true;
            lblPowtorzHasloText.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPowtorzHasloText.Location = new Point(20, 253);
            lblPowtorzHasloText.Margin = new Padding(2, 0, 2, 0);
            lblPowtorzHasloText.Name = "lblPowtorzHasloText";
            lblPowtorzHasloText.Size = new Size(140, 25);
            lblPowtorzHasloText.TabIndex = 5;
            lblPowtorzHasloText.Text = "Powtórz hasło:";
            lblPowtorzHasloText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHasloText
            // 
            lblHasloText.AutoSize = true;
            lblHasloText.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblHasloText.Location = new Point(99, 182);
            lblHasloText.Margin = new Padding(2, 0, 2, 0);
            lblHasloText.Name = "lblHasloText";
            lblHasloText.Size = new Size(68, 25);
            lblHasloText.TabIndex = 4;
            lblHasloText.Text = "Hasło:";
            lblHasloText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLoginText
            // 
            lblLoginText.AutoSize = true;
            lblLoginText.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginText.Location = new Point(100, 111);
            lblLoginText.Margin = new Padding(2, 0, 2, 0);
            lblLoginText.Name = "lblLoginText";
            lblLoginText.Size = new Size(66, 25);
            lblLoginText.TabIndex = 3;
            lblLoginText.Text = "Login:";
            lblLoginText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblImieText
            // 
            lblImieText.AutoSize = true;
            lblImieText.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblImieText.Location = new Point(115, 43);
            lblImieText.Margin = new Padding(2, 0, 2, 0);
            lblImieText.Name = "lblImieText";
            lblImieText.Size = new Size(54, 25);
            lblImieText.TabIndex = 2;
            lblImieText.Text = "Imię:";
            lblImieText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnZarejestruj
            // 
            btnZarejestruj.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Regular, GraphicsUnit.Point);
            btnZarejestruj.Location = new Point(141, 455);
            btnZarejestruj.Margin = new Padding(2);
            btnZarejestruj.Name = "btnZarejestruj";
            btnZarejestruj.Size = new Size(237, 47);
            btnZarejestruj.TabIndex = 3;
            btnZarejestruj.Text = "Zarejestruj";
            btnZarejestruj.UseVisualStyleBackColor = true;
            btnZarejestruj.Click += btnZarejestruj_Click;
            // 
            // RegisterControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnZarejestruj);
            Controls.Add(gbDaneUzytkownika);
            Controls.Add(lblTytulText);
            Controls.Add(btnCofnij);
            Margin = new Padding(2);
            Name = "RegisterControl";
            Size = new Size(514, 594);
            gbDaneUzytkownika.ResumeLayout(false);
            gbDaneUzytkownika.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCofnij;
        private Label lblTytulText;
        private GroupBox gbDaneUzytkownika;
        private Label lblLoginText;
        private Label lblImieText;
        private Label lblPowtorzHasloText;
        private Label lblHasloText;
        private TextBox tbPowtorzHaslo;
        private TextBox tbHaslo;
        private TextBox tbLogin;
        private TextBox tbImie;
        private Label lblImieWalidacja;
        private Label lblPowtorzHasloWalidacja;
        private Label lblHasloWalidacja;
        private Label lblLoginWalidacja;
        private Button btnZarejestruj;
    }
}
