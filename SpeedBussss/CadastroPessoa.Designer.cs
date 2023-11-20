namespace SpeedBussss
{
    partial class CadastroPessoa
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
            this.nomeBox = new System.Windows.Forms.TextBox();
            this.cpfBox = new System.Windows.Forms.MaskedTextBox();
            this.sexoBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.telefoneBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // nomeBox
            // 
            this.nomeBox.Location = new System.Drawing.Point(288, 324);
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.Size = new System.Drawing.Size(352, 20);
            this.nomeBox.TabIndex = 2;
            // 
            // cpfBox
            // 
            this.cpfBox.Location = new System.Drawing.Point(288, 405);
            this.cpfBox.Mask = "000,000,000-00";
            this.cpfBox.Name = "cpfBox";
            this.cpfBox.Size = new System.Drawing.Size(87, 20);
            this.cpfBox.TabIndex = 3;
            // 
            // sexoBox
            // 
            this.sexoBox.FormattingEnabled = true;
            this.sexoBox.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Prefiro não responder"});
            this.sexoBox.Location = new System.Drawing.Point(288, 442);
            this.sexoBox.Name = "sexoBox";
            this.sexoBox.Size = new System.Drawing.Size(121, 21);
            this.sexoBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // telefoneBox
            // 
            this.telefoneBox.Location = new System.Drawing.Point(288, 368);
            this.telefoneBox.Mask = "(00) 00000-0000";
            this.telefoneBox.Name = "telefoneBox";
            this.telefoneBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneBox.TabIndex = 7;
            // 
            // CadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpeedBussss.Properties.Resources.Orange_Bus_Tour_Online_Service_Poster__19_;
            this.ClientSize = new System.Drawing.Size(1120, 745);
            this.Controls.Add(this.telefoneBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sexoBox);
            this.Controls.Add(this.cpfBox);
            this.Controls.Add(this.nomeBox);
            this.Name = "CadastroPessoa";
            this.Text = "CadastroPessoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nomeBox;
        private System.Windows.Forms.MaskedTextBox cpfBox;
        private System.Windows.Forms.ComboBox sexoBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox telefoneBox;
    }
}