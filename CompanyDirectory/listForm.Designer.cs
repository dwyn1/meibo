namespace CompanyDirectory
{
    partial class listForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtKana = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cmbBusho = new System.Windows.Forms.ComboBox();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.cmbYaku = new System.Windows.Forms.ComboBox();
            this.cmbEnter = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.MaskedTextBox();
            this.txtEnterday = new System.Windows.Forms.MaskedTextBox();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.dgvIppan = new System.Windows.Forms.DataGridView();
            this.buttonbefore = new System.Windows.Forms.Button();
            this.buttonnext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIppan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(65, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(70, 19);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtKana
            // 
            this.txtKana.Location = new System.Drawing.Point(141, 13);
            this.txtKana.Name = "txtKana";
            this.txtKana.Size = new System.Drawing.Size(72, 19);
            this.txtKana.TabIndex = 2;
            this.txtKana.TextChanged += new System.EventHandler(this.txtKana_TextChanged);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(561, 13);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 19);
            this.txtMail.TabIndex = 8;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // cmbBusho
            // 
            this.cmbBusho.FormattingEnabled = true;
            this.cmbBusho.Location = new System.Drawing.Point(220, 13);
            this.cmbBusho.Name = "cmbBusho";
            this.cmbBusho.Size = new System.Drawing.Size(75, 20);
            this.cmbBusho.TabIndex = 3;
            this.cmbBusho.SelectedIndexChanged += new System.EventHandler(this.cmbBusho_SelectedIndexChanged);
            this.cmbBusho.TextUpdate += new System.EventHandler(this.cmbBusho_TextUpdate);
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(382, 13);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(37, 20);
            this.cmbSex.TabIndex = 5;
            this.cmbSex.SelectedIndexChanged += new System.EventHandler(this.cmbSex_SelectedIndexChanged);
            this.cmbSex.TextUpdate += new System.EventHandler(this.cmbSex_TextUpdate);
            this.cmbSex.TextChanged += new System.EventHandler(this.cmbSex_TextChanged);
            // 
            // cmbYaku
            // 
            this.cmbYaku.FormattingEnabled = true;
            this.cmbYaku.Location = new System.Drawing.Point(301, 13);
            this.cmbYaku.Name = "cmbYaku";
            this.cmbYaku.Size = new System.Drawing.Size(75, 20);
            this.cmbYaku.TabIndex = 4;
            this.cmbYaku.SelectedIndexChanged += new System.EventHandler(this.cmbYaku_SelectedIndexChanged);
            this.cmbYaku.TextUpdate += new System.EventHandler(this.cmbYaku_TextUpdate);
            // 
            // cmbEnter
            // 
            this.cmbEnter.FormattingEnabled = true;
            this.cmbEnter.Location = new System.Drawing.Point(498, 13);
            this.cmbEnter.Name = "cmbEnter";
            this.cmbEnter.Size = new System.Drawing.Size(57, 20);
            this.cmbEnter.TabIndex = 7;
            this.cmbEnter.SelectedIndexChanged += new System.EventHandler(this.cmbEnter_SelectedIndexChanged);
            this.cmbEnter.TextUpdate += new System.EventHandler(this.cmbEnter_TextUpdate);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(13, 13);
            this.txtid.Mask = "999999";
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(46, 19);
            this.txtid.TabIndex = 0;
            this.txtid.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtid_MaskInputRejected);
            // 
            // txtEnterday
            // 
            this.txtEnterday.Location = new System.Drawing.Point(425, 14);
            this.txtEnterday.Mask = "0000年90月90日";
            this.txtEnterday.Name = "txtEnterday";
            this.txtEnterday.Size = new System.Drawing.Size(73, 19);
            this.txtEnterday.TabIndex = 6;
            this.txtEnterday.ValidatingType = typeof(System.DateTime);
            this.txtEnterday.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtEnterday_MaskInputRejected);
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(667, 9);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(75, 23);
            this.buttonsearch.TabIndex = 9;
            this.buttonsearch.Text = "検索";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // dgvIppan
            // 
            this.dgvIppan.AllowUserToAddRows = false;
            this.dgvIppan.AllowUserToDeleteRows = false;
            this.dgvIppan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIppan.Location = new System.Drawing.Point(13, 39);
            this.dgvIppan.Name = "dgvIppan";
            this.dgvIppan.ReadOnly = true;
            this.dgvIppan.RowTemplate.Height = 21;
            this.dgvIppan.Size = new System.Drawing.Size(737, 179);
            this.dgvIppan.TabIndex = 10;
            // 
            // buttonbefore
            // 
            this.buttonbefore.Location = new System.Drawing.Point(291, 224);
            this.buttonbefore.Name = "buttonbefore";
            this.buttonbefore.Size = new System.Drawing.Size(75, 23);
            this.buttonbefore.TabIndex = 11;
            this.buttonbefore.Text = "前へ";
            this.buttonbefore.UseVisualStyleBackColor = true;
            this.buttonbefore.Click += new System.EventHandler(this.buttonbefore_Click);
            // 
            // buttonnext
            // 
            this.buttonnext.Location = new System.Drawing.Point(394, 224);
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.Size = new System.Drawing.Size(75, 23);
            this.buttonnext.TabIndex = 12;
            this.buttonnext.Text = "次へ";
            this.buttonnext.UseVisualStyleBackColor = true;
            this.buttonnext.Click += new System.EventHandler(this.buttonnext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonnext);
            this.Controls.Add(this.buttonbefore);
            this.Controls.Add(this.dgvIppan);
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
            this.Name = "listForm";
            this.Text = "一般社員名簿";
            this.Load += new System.EventHandler(this.listForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIppan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtKana;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cmbBusho;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.ComboBox cmbYaku;
        private System.Windows.Forms.ComboBox cmbEnter;
        private System.Windows.Forms.MaskedTextBox txtid;
        private System.Windows.Forms.MaskedTextBox txtEnterday;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.DataGridView dgvIppan;
        private System.Windows.Forms.Button buttonbefore;
        private System.Windows.Forms.Button buttonnext;
        private System.Windows.Forms.Label label1;
    }
}