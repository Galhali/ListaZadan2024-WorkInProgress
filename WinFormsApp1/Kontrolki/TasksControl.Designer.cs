namespace ListaZadan.Kontrolki
{
    partial class TasksControl
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
            lblTytul = new Label();
            lblZalogowanyText = new Label();
            lblZalogowany = new Label();
            btnDodaj = new Button();
            btnWyloguj = new Button();
            btnEdytuj = new Button();
            btnUsun = new Button();
            lvZadania = new ListView();
            colId = new ColumnHeader();
            colTitle = new ColumnHeader();
            colIsReady = new ColumnHeader();
            SuspendLayout();
            // 
            // lblTytul
            // 
            lblTytul.AutoSize = true;
            lblTytul.Font = new Font("Comic Sans MS", 28F, FontStyle.Regular, GraphicsUnit.Point);
            lblTytul.Location = new Point(3, 2);
            lblTytul.Margin = new Padding(2, 0, 2, 0);
            lblTytul.Name = "lblTytul";
            lblTytul.Size = new Size(136, 53);
            lblTytul.TabIndex = 0;
            lblTytul.Text = "TODO";
            // 
            // lblZalogowanyText
            // 
            lblZalogowanyText.AutoSize = true;
            lblZalogowanyText.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblZalogowanyText.Location = new Point(151, 20);
            lblZalogowanyText.Margin = new Padding(2, 0, 2, 0);
            lblZalogowanyText.Name = "lblZalogowanyText";
            lblZalogowanyText.Size = new Size(159, 25);
            lblZalogowanyText.TabIndex = 1;
            lblZalogowanyText.Text = "Zalogowany jako";
            // 
            // lblZalogowany
            // 
            lblZalogowany.AutoSize = true;
            lblZalogowany.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblZalogowany.Location = new Point(312, 20);
            lblZalogowany.Margin = new Padding(2, 0, 2, 0);
            lblZalogowany.Name = "lblZalogowany";
            lblZalogowany.Size = new Size(85, 25);
            lblZalogowany.TabIndex = 2;
            lblZalogowany.Text = "Anonim";
            // 
            // btnDodaj
            // 
            btnDodaj.Font = new Font("Microsoft Sans Serif", 27F, FontStyle.Regular, GraphicsUnit.Point);
            btnDodaj.Location = new Point(412, 76);
            btnDodaj.Margin = new Padding(2);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(77, 194);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "🞥";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnWyloguj
            // 
            btnWyloguj.Font = new Font("Microsoft Sans Serif", 27F, FontStyle.Regular, GraphicsUnit.Point);
            btnWyloguj.Location = new Point(412, 22);
            btnWyloguj.Margin = new Padding(2);
            btnWyloguj.Name = "btnWyloguj";
            btnWyloguj.Size = new Size(77, 47);
            btnWyloguj.TabIndex = 4;
            btnWyloguj.Text = "⮜";
            btnWyloguj.UseVisualStyleBackColor = true;
            btnWyloguj.Click += btnWyloguj_Click;
            // 
            // btnEdytuj
            // 
            btnEdytuj.Font = new Font("Microsoft Sans Serif", 27F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdytuj.Location = new Point(412, 275);
            btnEdytuj.Margin = new Padding(2);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(77, 194);
            btnEdytuj.TabIndex = 5;
            btnEdytuj.Text = "✏";
            btnEdytuj.UseVisualStyleBackColor = true;
            btnEdytuj.Click += btnEdytuj_Click;
            // 
            // btnUsun
            // 
            btnUsun.Font = new Font("Microsoft Sans Serif", 27F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsun.Location = new Point(412, 474);
            btnUsun.Margin = new Padding(2);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(77, 110);
            btnUsun.TabIndex = 6;
            btnUsun.Text = "🗑";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // lvZadania
            // 
            lvZadania.Columns.AddRange(new ColumnHeader[] { colId, colTitle, colIsReady });
            lvZadania.FullRowSelect = true;
            lvZadania.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvZadania.Location = new Point(17, 76);
            lvZadania.Margin = new Padding(2);
            lvZadania.MultiSelect = false;
            lvZadania.Name = "lvZadania";
            lvZadania.ShowGroups = false;
            lvZadania.Size = new Size(383, 509);
            lvZadania.TabIndex = 7;
            lvZadania.UseCompatibleStateImageBehavior = false;
            lvZadania.View = View.Details;
            // 
            // colId
            // 
            colId.Text = "Id";
            colId.Width = 38;
            // 
            // colTitle
            // 
            colTitle.Text = "Tytuł";
            colTitle.Width = 286;
            // 
            // colIsReady
            // 
            colIsReady.Text = "Zrobione";
            // 
            // TasksControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lvZadania);
            Controls.Add(btnUsun);
            Controls.Add(btnEdytuj);
            Controls.Add(btnWyloguj);
            Controls.Add(btnDodaj);
            Controls.Add(lblZalogowany);
            Controls.Add(lblZalogowanyText);
            Controls.Add(lblTytul);
            Margin = new Padding(2);
            Name = "TasksControl";
            Size = new Size(514, 594);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTytul;
        private Label lblZalogowanyText;
        private Label lblZalogowany;
        private Button btnDodaj;
        private Button btnWyloguj;
        private Button btnEdytuj;
        private Button btnUsun;
        private ListView lvZadania;
        private ColumnHeader colId;
        private ColumnHeader colTitle;
        private ColumnHeader colIsReady;
    }
}
