namespace CompanyDirectory
{
    partial class systemForm
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
            this.buttonRiseki = new System.Windows.Forms.Button();
            this.buttonMast = new System.Windows.Forms.Button();
            this.buttonPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "閲覧内容を選んでください";
            // 
            // buttonRiseki
            // 
            this.buttonRiseki.Location = new System.Drawing.Point(47, 46);
            this.buttonRiseki.Name = "buttonRiseki";
            this.buttonRiseki.Size = new System.Drawing.Size(166, 23);
            this.buttonRiseki.TabIndex = 1;
            this.buttonRiseki.Text = "離籍者名簿";
            this.buttonRiseki.UseVisualStyleBackColor = true;
            // 
            // buttonMast
            // 
            this.buttonMast.Location = new System.Drawing.Point(47, 88);
            this.buttonMast.Name = "buttonMast";
            this.buttonMast.Size = new System.Drawing.Size(166, 23);
            this.buttonMast.TabIndex = 2;
            this.buttonMast.Text = "部署名・役職名";
            this.buttonMast.UseVisualStyleBackColor = true;
            this.buttonMast.Click += new System.EventHandler(this.buttonMast_Click);
            // 
            // buttonPass
            // 
            this.buttonPass.Location = new System.Drawing.Point(47, 130);
            this.buttonPass.Name = "buttonPass";
            this.buttonPass.Size = new System.Drawing.Size(166, 23);
            this.buttonPass.TabIndex = 3;
            this.buttonPass.Text = "管理用パスワード変更";
            this.buttonPass.UseVisualStyleBackColor = true;
            this.buttonPass.Click += new System.EventHandler(this.buttonPass_Click);
            // 
            // systemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 189);
            this.Controls.Add(this.buttonPass);
            this.Controls.Add(this.buttonMast);
            this.Controls.Add(this.buttonRiseki);
            this.Controls.Add(this.label1);
            this.Name = "systemForm";
            this.Text = "システムメンテナンス";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRiseki;
        private System.Windows.Forms.Button buttonMast;
        private System.Windows.Forms.Button buttonPass;
    }
}