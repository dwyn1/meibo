namespace CompanyDirectory
{
    partial class postlistForm
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
            this.buttonnext = new System.Windows.Forms.Button();
            this.buttonbefore = new System.Windows.Forms.Button();
            this.dgvYakuin = new System.Windows.Forms.DataGridView();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.txtEnterday = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.MaskedTextBox();
            this.cmbEnter = new System.Windows.Forms.ComboBox();
            this.cmbYaku = new System.Windows.Forms.ComboBox();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.cmbBusho = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtKana = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtJuusho = new System.Windows.Forms.TextBox();
            this.txtTell = new System.Windows.Forms.MaskedTextBox();
            this.txtBirthday = new System.Windows.Forms.MaskedTextBox();
            this.cmbBirth = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYakuin)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonnext
            // 
            this.buttonnext.Location = new System.Drawing.Point(549, 223);
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.Size = new System.Drawing.Size(75, 23);
            this.buttonnext.TabIndex = 30;
            this.buttonnext.Text = "次へ";
            this.buttonnext.UseVisualStyleBackColor = true;
            this.buttonnext.Click += new System.EventHandler(this.buttonnext_Click);
            // 
            // buttonbefore
            // 
            this.buttonbefore.Location = new System.Drawing.Point(446, 223);
            this.buttonbefore.Name = "buttonbefore";
            this.buttonbefore.Size = new System.Drawing.Size(75, 23);
            this.buttonbefore.TabIndex = 29;
            this.buttonbefore.Text = "前へ";
            this.buttonbefore.UseVisualStyleBackColor = true;
            this.buttonbefore.Click += new System.EventHandler(this.buttonbefore_Click);
            // 
            // dgvYakuin
            // 
            this.dgvYakuin.AllowUserToAddRows = false;
            this.dgvYakuin.AllowUserToDeleteRows = false;
            this.dgvYakuin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYakuin.Location = new System.Drawing.Point(12, 38);
            this.dgvYakuin.Name = "dgvYakuin";
            this.dgvYakuin.ReadOnly = true;
            this.dgvYakuin.RowTemplate.Height = 21;
            this.dgvYakuin.Size = new System.Drawing.Size(1117, 179);
            this.dgvYakuin.TabIndex = 28;
            this.dgvYakuin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYakuin_CellContentClick);
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(982, 10);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(75, 23);
            this.buttonsearch.TabIndex = 27;
            this.buttonsearch.Text = "検索";
            this.buttonsearch.UseVisualStyleBackColor = true;
            // 
            // txtEnterday
            // 
            this.txtEnterday.Location = new System.Drawing.Point(425, 12);
            this.txtEnterday.Mask = "0000年90月90日";
            this.txtEnterday.Name = "txtEnterday";
            this.txtEnterday.Size = new System.Drawing.Size(73, 19);
            this.txtEnterday.TabIndex = 26;
            this.txtEnterday.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(12, 12);
            this.txtid.Mask = "999999";
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(46, 19);
            this.txtid.TabIndex = 25;
            this.txtid.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtid_MaskInputRejected);
            // 
            // cmbEnter
            // 
            this.cmbEnter.FormattingEnabled = true;
            this.cmbEnter.Location = new System.Drawing.Point(498, 12);
            this.cmbEnter.Name = "cmbEnter";
            this.cmbEnter.Size = new System.Drawing.Size(57, 20);
            this.cmbEnter.TabIndex = 24;
            // 
            // cmbYaku
            // 
            this.cmbYaku.FormattingEnabled = true;
            this.cmbYaku.Location = new System.Drawing.Point(300, 12);
            this.cmbYaku.Name = "cmbYaku";
            this.cmbYaku.Size = new System.Drawing.Size(75, 20);
            this.cmbYaku.TabIndex = 23;
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(381, 12);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(37, 20);
            this.cmbSex.TabIndex = 22;
            this.cmbSex.SelectedIndexChanged += new System.EventHandler(this.cmbSex_SelectedIndexChanged);
            // 
            // cmbBusho
            // 
            this.cmbBusho.FormattingEnabled = true;
            this.cmbBusho.Location = new System.Drawing.Point(219, 12);
            this.cmbBusho.Name = "cmbBusho";
            this.cmbBusho.Size = new System.Drawing.Size(75, 20);
            this.cmbBusho.TabIndex = 21;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(561, 12);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 19);
            this.txtMail.TabIndex = 20;
            // 
            // txtKana
            // 
            this.txtKana.Location = new System.Drawing.Point(140, 12);
            this.txtKana.Name = "txtKana";
            this.txtKana.Size = new System.Drawing.Size(72, 19);
            this.txtKana.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(64, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(70, 19);
            this.txtName.TabIndex = 18;
            // 
            // txtJuusho
            // 
            this.txtJuusho.Location = new System.Drawing.Point(731, 12);
            this.txtJuusho.Name = "txtJuusho";
            this.txtJuusho.Size = new System.Drawing.Size(100, 19);
            this.txtJuusho.TabIndex = 32;
            // 
            // txtTell
            // 
            this.txtTell.Location = new System.Drawing.Point(667, 12);
            this.txtTell.Mask = "999999999999";
            this.txtTell.Name = "txtTell";
            this.txtTell.Size = new System.Drawing.Size(58, 19);
            this.txtTell.TabIndex = 34;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(837, 12);
            this.txtBirthday.Mask = "0000年90月90日";
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(73, 19);
            this.txtBirthday.TabIndex = 35;
            this.txtBirthday.ValidatingType = typeof(System.DateTime);
            // 
            // cmbBirth
            // 
            this.cmbBirth.FormattingEnabled = true;
            this.cmbBirth.Location = new System.Drawing.Point(910, 12);
            this.cmbBirth.Name = "cmbBirth";
            this.cmbBirth.Size = new System.Drawing.Size(57, 20);
            this.cmbBirth.TabIndex = 36;
            // 
            // postlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 262);
            this.Controls.Add(this.cmbBirth);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.txtTell);
            this.Controls.Add(this.txtJuusho);
            this.Controls.Add(this.buttonnext);
            this.Controls.Add(this.buttonbefore);
            this.Controls.Add(this.dgvYakuin);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.txtEnterday);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.cmbEnter);
            this.Controls.Add(this.cmbYaku);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.cmbBusho);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtKana);
            this.Controls.Add(this.txtName);
            this.Name = "postlistForm";
            this.Text = "役員用社員名簿";
            ((System.ComponentModel.ISupportInitialize)(this.dgvYakuin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonnext;
        private System.Windows.Forms.Button buttonbefore;
        private System.Windows.Forms.DataGridView dgvYakuin;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.MaskedTextBox txtEnterday;
        private System.Windows.Forms.MaskedTextBox txtid;
        private System.Windows.Forms.ComboBox cmbEnter;
        private System.Windows.Forms.ComboBox cmbYaku;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.ComboBox cmbBusho;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtKana;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtJuusho;
        private System.Windows.Forms.MaskedTextBox txtTell;
        private System.Windows.Forms.MaskedTextBox txtBirthday;
        private System.Windows.Forms.ComboBox cmbBirth;
    }
}