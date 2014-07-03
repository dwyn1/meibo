namespace CompanyDirectory
{
    partial class masterForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBusho = new System.Windows.Forms.TabPage();
            this.dgvBusho = new System.Windows.Forms.DataGridView();
            this.tabYaku = new System.Windows.Forms.TabPage();
            this.dgvYaku = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabBusho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusho)).BeginInit();
            this.tabYaku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYaku)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBusho);
            this.tabControl1.Controls.Add(this.tabYaku);
            this.tabControl1.Location = new System.Drawing.Point(24, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(168, 194);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBusho
            // 
            this.tabBusho.Controls.Add(this.dgvBusho);
            this.tabBusho.Location = new System.Drawing.Point(4, 22);
            this.tabBusho.Name = "tabBusho";
            this.tabBusho.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusho.Size = new System.Drawing.Size(160, 168);
            this.tabBusho.TabIndex = 0;
            this.tabBusho.Text = "部署名";
            this.tabBusho.UseVisualStyleBackColor = true;
            // 
            // dgvBusho
            // 
            this.dgvBusho.AllowUserToAddRows = false;
            this.dgvBusho.AllowUserToDeleteRows = false;
            this.dgvBusho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusho.Location = new System.Drawing.Point(7, 7);
            this.dgvBusho.Name = "dgvBusho";
            this.dgvBusho.ReadOnly = true;
            this.dgvBusho.RowTemplate.Height = 21;
            this.dgvBusho.Size = new System.Drawing.Size(147, 155);
            this.dgvBusho.TabIndex = 0;
            // 
            // tabYaku
            // 
            this.tabYaku.Controls.Add(this.dgvYaku);
            this.tabYaku.Location = new System.Drawing.Point(4, 22);
            this.tabYaku.Name = "tabYaku";
            this.tabYaku.Padding = new System.Windows.Forms.Padding(3);
            this.tabYaku.Size = new System.Drawing.Size(160, 168);
            this.tabYaku.TabIndex = 1;
            this.tabYaku.Text = "役職名";
            this.tabYaku.UseVisualStyleBackColor = true;
            // 
            // dgvYaku
            // 
            this.dgvYaku.AllowUserToAddRows = false;
            this.dgvYaku.AllowUserToDeleteRows = false;
            this.dgvYaku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYaku.Location = new System.Drawing.Point(7, 7);
            this.dgvYaku.Name = "dgvYaku";
            this.dgvYaku.ReadOnly = true;
            this.dgvYaku.RowTemplate.Height = 21;
            this.dgvYaku.Size = new System.Drawing.Size(147, 155);
            this.dgvYaku.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDelete.Location = new System.Drawing.Point(175, 212);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 60;
            this.buttonDelete.Text = "消去";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAdd.Location = new System.Drawing.Point(93, 212);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 59;
            this.buttonAdd.Text = "追加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonChange
            // 
            this.buttonChange.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChange.Location = new System.Drawing.Point(12, 212);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 58;
            this.buttonChange.Text = "変更";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(208, 242);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(75, 23);
            this.buttoncancel.TabIndex = 61;
            this.buttoncancel.Text = "キャンセル";
            this.buttoncancel.UseVisualStyleBackColor = true;
            // 
            // masterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 276);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.tabControl1);
            this.Name = "masterForm";
            this.Text = "マスタ変更";
            this.tabControl1.ResumeLayout(false);
            this.tabBusho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusho)).EndInit();
            this.tabYaku.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYaku)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBusho;
        private System.Windows.Forms.DataGridView dgvBusho;
        private System.Windows.Forms.TabPage tabYaku;
        private System.Windows.Forms.DataGridView dgvYaku;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttoncancel;
    }
}