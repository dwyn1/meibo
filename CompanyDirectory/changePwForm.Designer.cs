namespace CompanyDirectory
{
    partial class changePwForm
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
            this.buttonPwOK = new System.Windows.Forms.Button();
            this.txtNewPw = new System.Windows.Forms.TextBox();
            this.txtNowPw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Redlabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCheckPw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPwOK
            // 
            this.buttonPwOK.Location = new System.Drawing.Point(154, 158);
            this.buttonPwOK.Name = "buttonPwOK";
            this.buttonPwOK.Size = new System.Drawing.Size(86, 23);
            this.buttonPwOK.TabIndex = 13;
            this.buttonPwOK.Text = "変更を適用";
            this.buttonPwOK.UseVisualStyleBackColor = true;
            this.buttonPwOK.Click += new System.EventHandler(this.buttonPwOK_Click);
            // 
            // txtNewPw
            // 
            this.txtNewPw.Location = new System.Drawing.Point(140, 91);
            this.txtNewPw.Name = "txtNewPw";
            this.txtNewPw.PasswordChar = '*';
            this.txtNewPw.Size = new System.Drawing.Size(100, 19);
            this.txtNewPw.TabIndex = 12;
            this.txtNewPw.TextChanged += new System.EventHandler(this.txtNewPw_TextChanged);
            // 
            // txtNowPw
            // 
            this.txtNowPw.Location = new System.Drawing.Point(140, 53);
            this.txtNowPw.Name = "txtNowPw";
            this.txtNowPw.PasswordChar = '*';
            this.txtNowPw.Size = new System.Drawing.Size(100, 19);
            this.txtNowPw.TabIndex = 11;
            this.txtNowPw.TextChanged += new System.EventHandler(this.txtNowPw_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "新しいパスワード";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "現在の使用パスワード";
            // 
            // Redlabel
            // 
            this.Redlabel.AutoSize = true;
            this.Redlabel.ForeColor = System.Drawing.Color.Red;
            this.Redlabel.Location = new System.Drawing.Point(85, 29);
            this.Redlabel.Name = "Redlabel";
            this.Redlabel.Size = new System.Drawing.Size(0, 12);
            this.Redlabel.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "パスワードを変更します";
            // 
            // txtCheckPw
            // 
            this.txtCheckPw.Location = new System.Drawing.Point(140, 116);
            this.txtCheckPw.Name = "txtCheckPw";
            this.txtCheckPw.PasswordChar = '*';
            this.txtCheckPw.Size = new System.Drawing.Size(100, 19);
            this.txtCheckPw.TabIndex = 15;
            this.txtCheckPw.TextChanged += new System.EventHandler(this.txtCheckPw_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "確認のためもう一度入力";
            // 
            // changePwForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 193);
            this.Controls.Add(this.txtCheckPw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPwOK);
            this.Controls.Add(this.txtNewPw);
            this.Controls.Add(this.txtNowPw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Redlabel);
            this.Controls.Add(this.label5);
            this.Name = "changePwForm";
            this.Text = "Pw変更";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPwOK;
        private System.Windows.Forms.TextBox txtNewPw;
        private System.Windows.Forms.TextBox txtNowPw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Redlabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCheckPw;
        private System.Windows.Forms.Label label1;

    }
}