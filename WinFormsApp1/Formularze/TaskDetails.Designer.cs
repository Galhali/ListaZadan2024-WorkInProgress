namespace ListaZadan.Formularze
{
    partial class TaskDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumerText = new Label();
            lblNumer = new Label();
            lblTytulText = new Label();
            lblOpisText = new Label();
            tbTitle = new TextBox();
            cbIsReady = new CheckBox();
            tbDescription = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblNumerText
            // 
            lblNumerText.AutoSize = true;
            lblNumerText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumerText.Location = new Point(8, 9);
            lblNumerText.Name = "lblNumerText";
            lblNumerText.Size = new Size(81, 25);
            lblNumerText.TabIndex = 0;
            lblNumerText.Text = "Numer:";
            // 
            // lblNumer
            // 
            lblNumer.AutoSize = true;
            lblNumer.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumer.Location = new Point(82, 9);
            lblNumer.Name = "lblNumer";
            lblNumer.Size = new Size(51, 25);
            lblNumer.TabIndex = 1;
            lblNumer.Text = "123";
            // 
            // lblTytulText
            // 
            lblTytulText.AutoSize = true;
            lblTytulText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTytulText.Location = new Point(24, 49);
            lblTytulText.Name = "lblTytulText";
            lblTytulText.Size = new Size(65, 25);
            lblTytulText.TabIndex = 2;
            lblTytulText.Text = "Tytuł:";
            // 
            // lblOpisText
            // 
            lblOpisText.AutoSize = true;
            lblOpisText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblOpisText.Location = new Point(27, 104);
            lblOpisText.Name = "lblOpisText";
            lblOpisText.Size = new Size(62, 25);
            lblOpisText.TabIndex = 3;
            lblOpisText.Text = "Opis:";
            // 
            // tbTitle
            // 
            tbTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbTitle.Location = new Point(89, 46);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(410, 31);
            tbTitle.TabIndex = 4;
            // 
            // cbIsReady
            // 
            cbIsReady.AutoSize = true;
            cbIsReady.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbIsReady.Location = new Point(508, 47);
            cbIsReady.Name = "cbIsReady";
            cbIsReady.Size = new Size(202, 29);
            cbIsReady.TabIndex = 5;
            cbIsReady.Text = "Czy zakończone?";
            cbIsReady.UseVisualStyleBackColor = true;
            // 
            // tbDescription
            // 
            tbDescription.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbDescription.Location = new Point(89, 101);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(619, 77);
            tbDescription.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(730, 36);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 142);
            btnSave.TabIndex = 7;
            btnSave.Text = "💾";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // TaskDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 218);
            Controls.Add(btnSave);
            Controls.Add(tbDescription);
            Controls.Add(cbIsReady);
            Controls.Add(tbTitle);
            Controls.Add(lblOpisText);
            Controls.Add(lblTytulText);
            Controls.Add(lblNumer);
            Controls.Add(lblNumerText);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TaskDetails";
            Text = "Zadanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumerText;
        private Label lblNumer;
        private Label lblTytulText;
        private Label lblOpisText;
        private TextBox tbTitle;
        private CheckBox cbIsReady;
        private TextBox tbDescription;
        private Button btnSave;
    }
}