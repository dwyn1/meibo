namespace CompanyDirectory
{
    partial class chooseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKojin = new System.Windows.Forms.Button();
            this.bottonMeibo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "閲覧内容を選択してください";
            // 
            // buttonKojin
            // 
            this.buttonKojin.Location = new System.Drawing.Point(12, 43);
            this.buttonKojin.Name = "buttonKojin";
            this.buttonKojin.Size = new System.Drawing.Size(100, 25);
            this.buttonKojin.TabIndex = 1;
            this.buttonKojin.Text = "個人情報";
            this.buttonKojin.UseVisualStyleBackColor = true;
            this.buttonKojin.Click += new System.EventHandler(this.buttonKojin_Click);
            // 
            // bottonMeibo
            // 
            this.bottonMeibo.Location = new System.Drawing.Point(129, 43);
            this.bottonMeibo.Name = "bottonMeibo";
            this.bottonMeibo.Size = new System.Drawing.Size(100, 25);
            this.bottonMeibo.TabIndex = 2;
            this.bottonMeibo.Text = "社員名簿";
            this.bottonMeibo.UseVisualStyleBackColor = true;
            this.bottonMeibo.Click += new System.EventHandler(this.bottonMeibo_Click);
            // 
            // chooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 87);
            this.Controls.Add(this.bottonMeibo);
            this.Controls.Add(this.buttonKojin);
            this.Controls.Add(this.label1);
            this.Name = "chooseForm";
            this.Text = "閲覧内容";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKojin;
        private System.Windows.Forms.Button bottonMeibo;
    }
}