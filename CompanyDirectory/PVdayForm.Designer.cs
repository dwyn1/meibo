namespace CompanyDirectory
{
    partial class PVdayForm
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
            this.labPV = new System.Windows.Forms.Label();
            this.buttonbefore = new System.Windows.Forms.Button();
            this.buttonnext = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "有給休暇使用日（直近の10日分表示）";
            // 
            // labPV
            // 
            this.labPV.AutoSize = true;
            this.labPV.Location = new System.Drawing.Point(52, 36);
            this.labPV.Name = "labPV";
            this.labPV.Size = new System.Drawing.Size(35, 12);
            this.labPV.TabIndex = 1;
            this.labPV.Text = "label2";
            // 
            // buttonbefore
            // 
            this.buttonbefore.Location = new System.Drawing.Point(54, 207);
            this.buttonbefore.Name = "buttonbefore";
            this.buttonbefore.Size = new System.Drawing.Size(44, 23);
            this.buttonbefore.TabIndex = 2;
            this.buttonbefore.Text = "前へ";
            this.buttonbefore.UseVisualStyleBackColor = true;
            this.buttonbefore.Click += new System.EventHandler(this.buttonbefore_Click);
            // 
            // buttonnext
            // 
            this.buttonnext.Location = new System.Drawing.Point(125, 207);
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.Size = new System.Drawing.Size(47, 23);
            this.buttonnext.TabIndex = 3;
            this.buttonnext.Text = "次へ";
            this.buttonnext.UseVisualStyleBackColor = true;
            this.buttonnext.Click += new System.EventHandler(this.buttonnext_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(188, 236);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // PVdayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 276);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonnext);
            this.Controls.Add(this.buttonbefore);
            this.Controls.Add(this.labPV);
            this.Controls.Add(this.label1);
            this.Name = "PVdayForm";
            this.Text = "有給使用日";
            this.Load += new System.EventHandler(this.PVdayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labPV;
        private System.Windows.Forms.Button buttonbefore;
        private System.Windows.Forms.Button buttonnext;
        private System.Windows.Forms.Button buttonOK;
    }
}