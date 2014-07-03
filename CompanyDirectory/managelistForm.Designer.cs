namespace CompanyDirectory
{
    partial class managelistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managelistForm));
            this.cmbBirth = new System.Windows.Forms.ComboBox();
            this.txtBirthday = new System.Windows.Forms.MaskedTextBox();
            this.txtTell = new System.Windows.Forms.MaskedTextBox();
            this.txtJuusho = new System.Windows.Forms.TextBox();
            this.buttonnext = new System.Windows.Forms.Button();
            this.buttonbefore = new System.Windows.Forms.Button();
            this.dgvKanri = new System.Windows.Forms.DataGridView();
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
            this.txtPw = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPV = new System.Windows.Forms.Button();
            this.mainteLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKanri)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBirth
            // 
            this.cmbBirth.FormattingEnabled = true;
            resources.ApplyResources(this.cmbBirth, "cmbBirth");
            this.cmbBirth.Name = "cmbBirth";
            // 
            // txtBirthday
            // 
            resources.ApplyResources(this.txtBirthday, "txtBirthday");
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.ValidatingType = typeof(System.DateTime);
            // 
            // txtTell
            // 
            resources.ApplyResources(this.txtTell, "txtTell");
            this.txtTell.Name = "txtTell";
            // 
            // txtJuusho
            // 
            resources.ApplyResources(this.txtJuusho, "txtJuusho");
            this.txtJuusho.Name = "txtJuusho";
            // 
            // buttonnext
            // 
            resources.ApplyResources(this.buttonnext, "buttonnext");
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.UseVisualStyleBackColor = true;
            // 
            // buttonbefore
            // 
            resources.ApplyResources(this.buttonbefore, "buttonbefore");
            this.buttonbefore.Name = "buttonbefore";
            this.buttonbefore.UseVisualStyleBackColor = true;
            // 
            // dgvKanri
            // 
            this.dgvKanri.AllowUserToAddRows = false;
            this.dgvKanri.AllowUserToDeleteRows = false;
            this.dgvKanri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvKanri, "dgvKanri");
            this.dgvKanri.Name = "dgvKanri";
            this.dgvKanri.ReadOnly = true;
            this.dgvKanri.RowTemplate.Height = 21;
            // 
            // buttonsearch
            // 
            resources.ApplyResources(this.buttonsearch, "buttonsearch");
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.UseVisualStyleBackColor = true;
            // 
            // txtEnterday
            // 
            resources.ApplyResources(this.txtEnterday, "txtEnterday");
            this.txtEnterday.Name = "txtEnterday";
            this.txtEnterday.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            resources.ApplyResources(this.txtid, "txtid");
            this.txtid.Name = "txtid";
            // 
            // cmbEnter
            // 
            this.cmbEnter.FormattingEnabled = true;
            resources.ApplyResources(this.cmbEnter, "cmbEnter");
            this.cmbEnter.Name = "cmbEnter";
            // 
            // cmbYaku
            // 
            this.cmbYaku.FormattingEnabled = true;
            resources.ApplyResources(this.cmbYaku, "cmbYaku");
            this.cmbYaku.Name = "cmbYaku";
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            resources.ApplyResources(this.cmbSex, "cmbSex");
            this.cmbSex.Name = "cmbSex";
            // 
            // cmbBusho
            // 
            this.cmbBusho.FormattingEnabled = true;
            resources.ApplyResources(this.cmbBusho, "cmbBusho");
            this.cmbBusho.Name = "cmbBusho";
            // 
            // txtMail
            // 
            resources.ApplyResources(this.txtMail, "txtMail");
            this.txtMail.Name = "txtMail";
            // 
            // txtKana
            // 
            resources.ApplyResources(this.txtKana, "txtKana");
            this.txtKana.Name = "txtKana";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // txtPw
            // 
            resources.ApplyResources(this.txtPw, "txtPw");
            this.txtPw.Name = "txtPw";
            // 
            // buttonChange
            // 
            resources.ApplyResources(this.buttonChange, "buttonChange");
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonAdd
            // 
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            resources.ApplyResources(this.buttonDelete, "buttonDelete");
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonPV
            // 
            resources.ApplyResources(this.buttonPV, "buttonPV");
            this.buttonPV.Name = "buttonPV";
            this.buttonPV.UseVisualStyleBackColor = true;
            // 
            // mainteLink
            // 
            resources.ApplyResources(this.mainteLink, "mainteLink");
            this.mainteLink.LinkColor = System.Drawing.Color.Black;
            this.mainteLink.Name = "mainteLink";
            this.mainteLink.TabStop = true;
            // 
            // managelistForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainteLink);
            this.Controls.Add(this.buttonPV);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.cmbBirth);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.txtTell);
            this.Controls.Add(this.txtJuusho);
            this.Controls.Add(this.buttonnext);
            this.Controls.Add(this.buttonbefore);
            this.Controls.Add(this.dgvKanri);
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
            this.Name = "managelistForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKanri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBirth;
        private System.Windows.Forms.MaskedTextBox txtBirthday;
        private System.Windows.Forms.MaskedTextBox txtTell;
        private System.Windows.Forms.TextBox txtJuusho;
        private System.Windows.Forms.Button buttonnext;
        private System.Windows.Forms.Button buttonbefore;
        private System.Windows.Forms.DataGridView dgvKanri;
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
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPV;
        private System.Windows.Forms.LinkLabel mainteLink;
    }
}