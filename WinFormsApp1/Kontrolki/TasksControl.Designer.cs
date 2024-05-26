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
            button1 = new Button();
            btnWyloguj = new Button();
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
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
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
            // TasksControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnWyloguj);
            Controls.Add(button1);
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
        private Button button1;
        private Button btnWyloguj;
    }
}
