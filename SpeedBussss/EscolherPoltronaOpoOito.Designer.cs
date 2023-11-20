namespace SpeedBussss
{
    partial class EscolherPoltronaOpoOito
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
            this.cb_escolherpoltronaopooito = new System.Windows.Forms.ComboBox();
            this.bt_verificapol = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_escolherpoltronaopooito
            // 
            this.cb_escolherpoltronaopooito.FormattingEnabled = true;
            this.cb_escolherpoltronaopooito.Location = new System.Drawing.Point(344, 617);
            this.cb_escolherpoltronaopooito.Name = "cb_escolherpoltronaopooito";
            this.cb_escolherpoltronaopooito.Size = new System.Drawing.Size(121, 21);
            this.cb_escolherpoltronaopooito.TabIndex = 0;
            // 
            // bt_verificapol
            // 
            this.bt_verificapol.Location = new System.Drawing.Point(539, 582);
            this.bt_verificapol.Name = "bt_verificapol";
            this.bt_verificapol.Size = new System.Drawing.Size(196, 65);
            this.bt_verificapol.TabIndex = 1;
            this.bt_verificapol.UseVisualStyleBackColor = true;
            this.bt_verificapol.Click += new System.EventHandler(this.bt_verificapol_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(893, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 93);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EscolherPoltronaOpoOito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpeedBussss.Properties.Resources.Orange_Bus_Tour_Online_Service_Poster__17_5;
            this.ClientSize = new System.Drawing.Size(1120, 794);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_verificapol);
            this.Controls.Add(this.cb_escolherpoltronaopooito);
            this.Name = "EscolherPoltronaOpoOito";
            this.Text = "EscolherPoltronaOpoOito";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_escolherpoltronaopooito;
        private System.Windows.Forms.Button bt_verificapol;
        private System.Windows.Forms.Button button1;
    }
}