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
            lblTytul.Location = new Point(4, 4);
            lblTytul.Name = "lblTytul";
            lblTytul.Size = new Size(202, 79);
            lblTytul.TabIndex = 0;
            lblTytul.Text = "TODO";
            // 
            // lblZalogowanyText
            // 
            lblZalogowanyText.AutoSize = true;
            lblZalogowanyText.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblZalogowanyText.Location = new Point(216, 34);
            lblZalogowanyText.Name = "lblZalogowanyText";
            lblZalogowanyText.Size = new Size(240, 36);
            lblZalogowanyText.TabIndex = 1;
            lblZalogowanyText.Text = "Zalogowany jako";
            // 
            // lblZalogowany
            // 
            lblZalogowany.AutoSize = true;
            lblZalogowany.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblZalogowany.Location = new Point(446, 34);
            lblZalogowany.Name = "lblZalogowany";
            lblZalogowany.Size = new Size(123, 36);
            lblZalogowany.TabIndex = 2;
            lblZalogowany.Text = "Anonim";
            // 
            // btnDodaj
            // 
            btnDodaj.Font = new Font("Microsoft Sans Serif", 27F, FontStyle.Regular, GraphicsUnit.Point);
            btnDodaj.Location = new Point(588, 127);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(110, 323);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "🞥";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnWyloguj
            // 
            btnWyloguj.Font = new Font("Microsoft Sans Serif", 27F, FontStyle.Regular, GraphicsUnit.Point);
            btnWyloguj.Location = new Point(588, 36);
            btnWyloguj.Name = "btnWyloguj";
            btnWyloguj.Size = new Size(110, 78);
            btnWyloguj.TabIndex = 4;
            btnWyloguj.Text = "⮜";
            btnWyloguj.UseVisualStyleBackColor = true;
            // 
            // btnEdytuj
            // 
            btnEdytuj.Font = new Font("Microsoft Sans Serif", 27F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdytuj.Location = new Point(588, 459);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(110, 323);
            btnEdytuj.TabIndex = 5;
            btnEdytuj.Text = "✏";
            btnEdytuj.UseVisualStyleBackColor = true;
            // 
            // btnUsun
            // 
            btnUsun.Font = new Font("Microsoft Sans Serif", 27F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsun.Location = new Point(588, 790);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(110, 183);
            btnUsun.TabIndex = 6;
            btnUsun.Text = "🗑";
            btnUsun.UseVisualStyleBackColor = true;
            // 
            // lvZadania
            // 
            lvZadania.Columns.AddRange(new ColumnHeader[] { colId, colTitle, colIsReady });
            lvZadania.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvZadania.Location = new Point(24, 127);
            lvZadania.Name = "lvZadania";
            lvZadania.ShowGroups = false;
            lvZadania.Size = new Size(545, 846);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lvZadania);
            Controls.Add(btnUsun);
            Controls.Add(btnEdytuj);
            Controls.Add(btnWyloguj);
            Controls.Add(btnDodaj);
            Controls.Add(lblZalogowany);
            Controls.Add(lblZalogowanyText);
            Controls.Add(lblTytul);
            Name = "TasksControl";
            Size = new Size(735, 990);
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
