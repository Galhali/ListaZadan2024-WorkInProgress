namespace ListaZadan.Kontrolki
{
    partial class LoginControl
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
            lblTytulText = new Label();
            lblLinia = new Label();
            lblLoginText = new Label();
            lblHasloText = new Label();
            tbLogin = new TextBox();
            tbHaslo = new TextBox();
            lblWalidacjaLogowania = new Label();
            btnZaloguj = new Button();
            btnZalozKonto = new Button();
            SuspendLayout();
            // 
            // lblTytulText
            // 
            lblTytulText.AutoSize = true;
            lblTytulText.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTytulText.Location = new Point(147, 36);
            lblTytulText.Name = "lblTytulText";
            lblTytulText.Size = new Size(210, 42);
            lblTytulText.TabIndex = 0;
            lblTytulText.Text = "Lista zadań";
            // 
            // lblLinia
            // 
            lblLinia.AutoSize = true;
            lblLinia.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLinia.Location = new Point(51, 85);
            lblLinia.Name = "lblLinia";
            lblLinia.Size = new Size(403, 13);
            lblLinia.TabIndex = 1;
            lblLinia.Text = "__________________________________________________________________";
            // 
            // lblLoginText
            // 
            lblLoginText.AutoSize = true;
            lblLoginText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginText.Location = new Point(51, 157);
            lblLoginText.Name = "lblLoginText";
            lblLoginText.Size = new Size(71, 25);
            lblLoginText.TabIndex = 2;
            lblLoginText.Text = "Login:";
            lblLoginText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHasloText
            // 
            lblHasloText.AutoSize = true;
            lblHasloText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHasloText.Location = new Point(49, 199);
            lblHasloText.Name = "lblHasloText";
            lblHasloText.Size = new Size(73, 25);
            lblHasloText.TabIndex = 3;
            lblHasloText.Text = "Hasło:";
            lblHasloText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbLogin
            // 
            tbLogin.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbLogin.Location = new Point(129, 154);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(225, 31);
            tbLogin.TabIndex = 4;
            // 
            // tbHaslo
            // 
            tbHaslo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbHaslo.Location = new Point(129, 196);
            tbHaslo.Name = "tbHaslo";
            tbHaslo.PasswordChar = '*';
            tbHaslo.Size = new Size(225, 31);
            tbHaslo.TabIndex = 5;
            // 
            // lblWalidacjaLogowania
            // 
            lblWalidacjaLogowania.AutoSize = true;
            lblWalidacjaLogowania.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblWalidacjaLogowania.ForeColor = Color.Red;
            lblWalidacjaLogowania.Location = new Point(105, 264);
            lblWalidacjaLogowania.Name = "lblWalidacjaLogowania";
            lblWalidacjaLogowania.Size = new Size(295, 25);
            lblWalidacjaLogowania.TabIndex = 6;
            lblWalidacjaLogowania.Text = "Nieprawidłowy login lub hasło";
            lblWalidacjaLogowania.TextAlign = ContentAlignment.MiddleCenter;
            lblWalidacjaLogowania.Visible = false;
            // 
            // btnZaloguj
            // 
            btnZaloguj.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnZaloguj.Location = new Point(140, 347);
            btnZaloguj.Name = "btnZaloguj";
            btnZaloguj.Size = new Size(225, 51);
            btnZaloguj.TabIndex = 7;
            btnZaloguj.Text = "Zaloguj";
            btnZaloguj.UseVisualStyleBackColor = true;
            btnZaloguj.Click += btnZaloguj_Click;
            // 
            // btnZalozKonto
            // 
            btnZalozKonto.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnZalozKonto.Location = new Point(140, 416);
            btnZalozKonto.Name = "btnZalozKonto";
            btnZalozKonto.Size = new Size(225, 51);
            btnZalozKonto.TabIndex = 8;
            btnZalozKonto.Text = "Załóż konto";
            btnZalozKonto.UseVisualStyleBackColor = true;
            btnZalozKonto.Click += btnZalozKonto_Click;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnZalozKonto);
            Controls.Add(btnZaloguj);
            Controls.Add(lblWalidacjaLogowania);
            Controls.Add(tbHaslo);
            Controls.Add(tbLogin);
            Controls.Add(lblHasloText);
            Controls.Add(lblLoginText);
            Controls.Add(lblLinia);
            Controls.Add(lblTytulText);
            Name = "LoginControl";
            Size = new Size(515, 680);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTytulText;
        private Label lblLinia;
        private Label lblLoginText;
        private Label lblHasloText;
        private TextBox tbLogin;
        private TextBox tbHaslo;
        private Label lblWalidacjaLogowania;
        private Button btnZaloguj;
        private Button btnZalozKonto;
    }
}
