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
            lblImieText = new Label();
            lblLoginText = new Label();
            lblHasloText = new Label();
            lblPowtorzHasloText = new Label();
            tbImie = new TextBox();
            tbLogin = new TextBox();
            tbHaslo = new TextBox();
            tbPowtorzHaslo = new TextBox();
            lblImieWalidacja = new Label();
            lblLoginWalidacja = new Label();
            lblHasloWalidacja = new Label();
            lblPowtorzHasloWalidacja = new Label();
            btnZarejestruj = new Button();
            gbDaneUzytkownika.SuspendLayout();
            SuspendLayout();
            // 
            // btnCofnij
            // 
            btnCofnij.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Regular, GraphicsUnit.Point);
            btnCofnij.Location = new Point(27, 42);
            btnCofnij.Name = "btnCofnij";
            btnCofnij.Size = new Size(159, 78);
            btnCofnij.TabIndex = 0;
            btnCofnij.Text = "⮜";
            btnCofnij.UseVisualStyleBackColor = true;
            // 
            // lblTytulText
            // 
            lblTytulText.AutoSize = true;
            lblTytulText.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point);
            lblTytulText.Location = new Point(263, 49);
            lblTytulText.Name = "lblTytulText";
            lblTytulText.Size = new Size(308, 64);
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
            gbDaneUzytkownika.Location = new Point(21, 166);
            gbDaneUzytkownika.Name = "gbDaneUzytkownika";
            gbDaneUzytkownika.Size = new Size(694, 542);
            gbDaneUzytkownika.TabIndex = 2;
            gbDaneUzytkownika.TabStop = false;
            gbDaneUzytkownika.Text = "Dane nowego użytkownika";
            // 
            // lblImieText
            // 
            lblImieText.AutoSize = true;
            lblImieText.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblImieText.Location = new Point(164, 71);
            lblImieText.Name = "lblImieText";
            lblImieText.Size = new Size(77, 36);
            lblImieText.TabIndex = 2;
            lblImieText.Text = "Imię:";
            lblImieText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLoginText
            // 
            lblLoginText.AutoSize = true;
            lblLoginText.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginText.Location = new Point(143, 185);
            lblLoginText.Name = "lblLoginText";
            lblLoginText.Size = new Size(98, 36);
            lblLoginText.TabIndex = 3;
            lblLoginText.Text = "Login:";
            lblLoginText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHasloText
            // 
            lblHasloText.AutoSize = true;
            lblHasloText.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblHasloText.Location = new Point(142, 303);
            lblHasloText.Name = "lblHasloText";
            lblHasloText.Size = new Size(99, 36);
            lblHasloText.TabIndex = 4;
            lblHasloText.Text = "Hasło:";
            lblHasloText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPowtorzHasloText
            // 
            lblPowtorzHasloText.AutoSize = true;
            lblPowtorzHasloText.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPowtorzHasloText.Location = new Point(29, 422);
            lblPowtorzHasloText.Name = "lblPowtorzHasloText";
            lblPowtorzHasloText.Size = new Size(212, 36);
            lblPowtorzHasloText.TabIndex = 5;
            lblPowtorzHasloText.Text = "Powtórz hasło:";
            lblPowtorzHasloText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbImie
            // 
            tbImie.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbImie.Location = new Point(260, 67);
            tbImie.Name = "tbImie";
            tbImie.Size = new Size(336, 44);
            tbImie.TabIndex = 6;
            // 
            // tbLogin
            // 
            tbLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbLogin.Location = new Point(260, 181);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(336, 44);
            tbLogin.TabIndex = 7;
            // 
            // tbHaslo
            // 
            tbHaslo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbHaslo.Location = new Point(260, 299);
            tbHaslo.Name = "tbHaslo";
            tbHaslo.Size = new Size(336, 44);
            tbHaslo.TabIndex = 8;
            // 
            // tbPowtorzHaslo
            // 
            tbPowtorzHaslo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbPowtorzHaslo.Location = new Point(260, 418);
            tbPowtorzHaslo.Name = "tbPowtorzHaslo";
            tbPowtorzHaslo.Size = new Size(336, 44);
            tbPowtorzHaslo.TabIndex = 9;
            // 
            // lblImieWalidacja
            // 
            lblImieWalidacja.AutoSize = true;
            lblImieWalidacja.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblImieWalidacja.ForeColor = Color.Red;
            lblImieWalidacja.Location = new Point(260, 118);
            lblImieWalidacja.Name = "lblImieWalidacja";
            lblImieWalidacja.Size = new Size(238, 29);
            lblImieWalidacja.TabIndex = 10;
            lblImieWalidacja.Text = "Labelka na walidacje";
            lblImieWalidacja.TextAlign = ContentAlignment.MiddleRight;
            lblImieWalidacja.Visible = false;
            // 
            // lblLoginWalidacja
            // 
            lblLoginWalidacja.AutoSize = true;
            lblLoginWalidacja.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginWalidacja.ForeColor = Color.Red;
            lblLoginWalidacja.Location = new Point(260, 228);
            lblLoginWalidacja.Name = "lblLoginWalidacja";
            lblLoginWalidacja.Size = new Size(238, 29);
            lblLoginWalidacja.TabIndex = 11;
            lblLoginWalidacja.Text = "Labelka na walidacje";
            lblLoginWalidacja.TextAlign = ContentAlignment.MiddleRight;
            lblLoginWalidacja.Visible = false;
            // 
            // lblHasloWalidacja
            // 
            lblHasloWalidacja.AutoSize = true;
            lblHasloWalidacja.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHasloWalidacja.ForeColor = Color.Red;
            lblHasloWalidacja.Location = new Point(260, 346);
            lblHasloWalidacja.Name = "lblHasloWalidacja";
            lblHasloWalidacja.Size = new Size(238, 29);
            lblHasloWalidacja.TabIndex = 12;
            lblHasloWalidacja.Text = "Labelka na walidacje";
            lblHasloWalidacja.TextAlign = ContentAlignment.MiddleRight;
            lblHasloWalidacja.Visible = false;
            // 
            // lblPowtorzHasloWalidacja
            // 
            lblPowtorzHasloWalidacja.AutoSize = true;
            lblPowtorzHasloWalidacja.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPowtorzHasloWalidacja.ForeColor = Color.Red;
            lblPowtorzHasloWalidacja.Location = new Point(260, 465);
            lblPowtorzHasloWalidacja.Name = "lblPowtorzHasloWalidacja";
            lblPowtorzHasloWalidacja.Size = new Size(238, 29);
            lblPowtorzHasloWalidacja.TabIndex = 13;
            lblPowtorzHasloWalidacja.Text = "Labelka na walidacje";
            lblPowtorzHasloWalidacja.TextAlign = ContentAlignment.MiddleRight;
            lblPowtorzHasloWalidacja.Visible = false;
            // 
            // btnZarejestruj
            // 
            btnZarejestruj.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Regular, GraphicsUnit.Point);
            btnZarejestruj.Location = new Point(202, 758);
            btnZarejestruj.Name = "btnZarejestruj";
            btnZarejestruj.Size = new Size(338, 78);
            btnZarejestruj.TabIndex = 3;
            btnZarejestruj.Text = "Zarejestruj";
            btnZarejestruj.UseVisualStyleBackColor = true;
            // 
            // RegisterControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnZarejestruj);
            Controls.Add(gbDaneUzytkownika);
            Controls.Add(lblTytulText);
            Controls.Add(btnCofnij);
            Name = "RegisterControl";
            Size = new Size(735, 990);
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
