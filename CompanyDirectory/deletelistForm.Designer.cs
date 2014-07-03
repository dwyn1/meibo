namespace CompanyDirectory
{
    partial class deletelistForm
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
            this.buttonReentry = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonnext = new System.Windows.Forms.Button();
            this.buttonbefore = new System.Windows.Forms.Button();
            this.dgvDelete = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReentry
            // 
            this.buttonReentry.Location = new System.Drawing.Point(13, 13);
            this.buttonReentry.Name = "buttonReentry";
            this.buttonReentry.Size = new System.Drawing.Size(75, 23);
            this.buttonReentry.TabIndex = 0;
            this.buttonReentry.Text = "在籍の変更";
            this.buttonReentry.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(104, 13);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "完全に消去";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonnext
            // 
            this.buttonnext.Location = new System.Drawing.Point(394, 263);
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.Size = new System.Drawing.Size(75, 23);
            this.buttonnext.TabIndex = 30;
            this.buttonnext.Text = "次へ";
            this.buttonnext.UseVisualStyleBackColor = true;
            // 
            // buttonbefore
            // 
            this.buttonbefore.Location = new System.Drawing.Point(291, 263);
            this.buttonbefore.Name = "buttonbefore";
            this.buttonbefore.Size = new System.Drawing.Size(75, 23);
            this.buttonbefore.TabIndex = 29;
            this.buttonbefore.Text = "前へ";
            this.buttonbefore.UseVisualStyleBackColor = true;
            // 
            // dgvDelete
            // 
            this.dgvDelete.AllowUserToAddRows = false;
            this.dgvDelete.AllowUserToDeleteRows = false;
            this.dgvDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelete.Location = new System.Drawing.Point(13, 78);
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.ReadOnly = true;
            this.dgvDelete.RowTemplate.Height = 21;
            this.dgvDelete.Size = new System.Drawing.Size(737, 179);
            this.dgvDelete.TabIndex = 28;
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(669, 50);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(75, 23);
            this.buttonsearch.TabIndex = 27;
            this.buttonsearch.Text = "検索";
            this.buttonsearch.UseVisualStyleBackColor = true;
            // 
            // txtEnterday
            // 
            this.txtEnterday.Location = new System.Drawing.Point(426, 52);
            this.txtEnterday.Mask = "0000年90月90日";
            this.txtEnterday.Name = "txtEnterday";
            this.txtEnterday.Size = new System.Drawing.Size(73, 19);
            this.txtEnterday.TabIndex = 26;
            this.txtEnterday.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(13, 52);
            this.txtid.Mask = "999999";
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(46, 19);
            this.txtid.TabIndex = 25;
            // 
            // cmbEnter
            // 
            this.cmbEnter.FormattingEnabled = true;
            this.cmbEnter.Location = new System.Drawing.Point(499, 52);
            this.cmbEnter.Name = "cmbEnter";
            this.cmbEnter.Size = new System.Drawing.Size(57, 20);
            this.cmbEnter.TabIndex = 24;
            // 
            // cmbYaku
            // 
            this.cmbYaku.FormattingEnabled = true;
            this.cmbYaku.Location = new System.Drawing.Point(301, 52);
            this.cmbYaku.Name = "cmbYaku";
            this.cmbYaku.Size = new System.Drawing.Size(75, 20);
            this.cmbYaku.TabIndex = 23;
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(382, 52);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(37, 20);
            this.cmbSex.TabIndex = 22;
            // 
            // cmbBusho
            // 
            this.cmbBusho.FormattingEnabled = true;
            this.cmbBusho.Location = new System.Drawing.Point(220, 52);
            this.cmbBusho.Name = "cmbBusho";
            this.cmbBusho.Size = new System.Drawing.Size(75, 20);
            this.cmbBusho.TabIndex = 21;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(563, 52);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 19);
            this.txtMail.TabIndex = 20;
            // 
            // txtKana
            // 
            this.txtKana.Location = new System.Drawing.Point(141, 52);
            this.txtKana.Name = "txtKana";
            this.txtKana.Size = new System.Drawing.Size(72, 19);
            this.txtKana.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(65, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(70, 19);
            this.txtName.TabIndex = 18;
            // 
            // deletelistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 298);
            this.Controls.Add(this.buttonnext);
            this.Controls.Add(this.buttonbefore);
            this.Controls.Add(this.dgvDelete);
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
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonReentry);
            this.Name = "deletelistForm";
            this.Text = "離籍社員名簿";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReentry;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonnext;
        private System.Windows.Forms.Button buttonbefore;
        private System.Windows.Forms.DataGridView dgvDelete;
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
    }
}