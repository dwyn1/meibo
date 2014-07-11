namespace CompanyDirectory
{
    partial class takePVForm
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
            this.Blacklabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labId = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labAllPV = new System.Windows.Forms.Label();
            this.labTakePV = new System.Windows.Forms.Label();
            this.labHavePV = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Blacklabel
            // 
            this.Blacklabel.AutoSize = true;
            this.Blacklabel.ForeColor = System.Drawing.Color.Black;
            this.Blacklabel.Location = new System.Drawing.Point(138, 9);
            this.Blacklabel.Name = "Blacklabel";
            this.Blacklabel.Size = new System.Drawing.Size(159, 12);
            this.Blacklabel.TabIndex = 0;
            this.Blacklabel.Text = "有給の使用日を入力してください";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 30);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "氏名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "全有給所持数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "消費有給";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "残り有給";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "使用日";
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(339, 48);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(44, 12);
            this.labId.TabIndex = 8;
            this.labId.Text = "Number";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(339, 69);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(35, 12);
            this.labName.TabIndex = 9;
            this.labName.Text = "label9";
            // 
            // labAllPV
            // 
            this.labAllPV.AutoSize = true;
            this.labAllPV.Location = new System.Drawing.Point(339, 115);
            this.labAllPV.Name = "labAllPV";
            this.labAllPV.Size = new System.Drawing.Size(41, 12);
            this.labAllPV.TabIndex = 10;
            this.labAllPV.Text = "label10";
            // 
            // labTakePV
            // 
            this.labTakePV.AutoSize = true;
            this.labTakePV.Location = new System.Drawing.Point(339, 136);
            this.labTakePV.Name = "labTakePV";
            this.labTakePV.Size = new System.Drawing.Size(41, 12);
            this.labTakePV.TabIndex = 11;
            this.labTakePV.Text = "label11";
            // 
            // labHavePV
            // 
            this.labHavePV.AutoSize = true;
            this.labHavePV.Location = new System.Drawing.Point(339, 157);
            this.labHavePV.Name = "labHavePV";
            this.labHavePV.Size = new System.Drawing.Size(41, 12);
            this.labHavePV.TabIndex = 12;
            this.labHavePV.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(386, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 15;
            this.label13.Text = "日";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(386, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 14;
            this.label14.Text = "日";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(386, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 13;
            this.label15.Text = "日";
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(336, 238);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(75, 23);
            this.buttoncancel.TabIndex = 17;
            this.buttoncancel.Text = "キャンセル";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(252, 238);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "確定";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            // 
            // takePVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labHavePV);
            this.Controls.Add(this.labTakePV);
            this.Controls.Add(this.labAllPV);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Blacklabel);
            this.Name = "takePVForm";
            this.Text = "有給消費";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Blacklabel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labAllPV;
        private System.Windows.Forms.Label labTakePV;
        private System.Windows.Forms.Label labHavePV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
    }
}