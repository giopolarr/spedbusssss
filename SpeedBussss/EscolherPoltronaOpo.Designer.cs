namespace SpeedBussss
{
    partial class EscolherPoltronaOpo
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
            this.cb_escolherpoltronaOpo = new System.Windows.Forms.ComboBox();
            this.bt_verificapoltronaOpo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_escolherpoltronaOpo
            // 
            this.cb_escolherpoltronaOpo.FormattingEnabled = true;
            this.cb_escolherpoltronaOpo.Location = new System.Drawing.Point(344, 616);
            this.cb_escolherpoltronaOpo.Name = "cb_escolherpoltronaOpo";
            this.cb_escolherpoltronaOpo.Size = new System.Drawing.Size(121, 21);
            this.cb_escolherpoltronaOpo.TabIndex = 0;
            // 
            // bt_verificapoltronaOpo
            // 
            this.bt_verificapoltronaOpo.Location = new System.Drawing.Point(541, 589);
            this.bt_verificapoltronaOpo.Name = "bt_verificapoltronaOpo";
            this.bt_verificapoltronaOpo.Size = new System.Drawing.Size(189, 58);
            this.bt_verificapoltronaOpo.TabIndex = 1;
            this.bt_verificapoltronaOpo.UseVisualStyleBackColor = true;
            this.bt_verificapoltronaOpo.Click += new System.EventHandler(this.bt_verificapoltronaOpo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(922, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EscolherPoltronaOpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpeedBussss.Properties.Resources.Orange_Bus_Tour_Online_Service_Poster__17_;
            this.ClientSize = new System.Drawing.Size(1122, 788);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_verificapoltronaOpo);
            this.Controls.Add(this.cb_escolherpoltronaOpo);
            this.Name = "EscolherPoltronaOpo";
            this.Text = "EscolherPoltronaOpo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_escolherpoltronaOpo;
        private System.Windows.Forms.Button bt_verificapoltronaOpo;
        private System.Windows.Forms.Button button1;
    }
}