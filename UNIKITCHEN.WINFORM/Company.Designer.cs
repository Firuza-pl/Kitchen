namespace UNIKITCHEN.WINFORM
{
    partial class Company
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCompanySave = new System.Windows.Forms.Button();
            this.dataGridViewEmpleyees = new System.Windows.Forms.DataGridView();
            this.E_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbFirms = new System.Windows.Forms.ComboBox();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleyees)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel6.Controls.Add(this.btnCompanySave);
            this.panel6.Controls.Add(this.dataGridViewEmpleyees);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.cmbFirms);
            this.panel6.Location = new System.Drawing.Point(3, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(632, 309);
            this.panel6.TabIndex = 13;
            // 
            // btnCompanySave
            // 
            this.btnCompanySave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCompanySave.AutoSize = true;
            this.btnCompanySave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.btnCompanySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompanySave.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanySave.ForeColor = System.Drawing.Color.White;
            this.btnCompanySave.Location = new System.Drawing.Point(400, 21);
            this.btnCompanySave.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompanySave.Name = "btnCompanySave";
            this.btnCompanySave.Size = new System.Drawing.Size(108, 30);
            this.btnCompanySave.TabIndex = 36;
            this.btnCompanySave.Text = "Yadda saxla";
            this.btnCompanySave.UseVisualStyleBackColor = false;
            this.btnCompanySave.Click += new System.EventHandler(this.btnCompanySave_Click);
            // 
            // dataGridViewEmpleyees
            // 
            this.dataGridViewEmpleyees.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewEmpleyees.AllowUserToDeleteRows = false;
            this.dataGridViewEmpleyees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmpleyees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmpleyees.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmpleyees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmpleyees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmpleyees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEmpleyees.ColumnHeadersHeight = 30;
            this.dataGridViewEmpleyees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.E_ID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmpleyees.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewEmpleyees.EnableHeadersVisualStyles = false;
            this.dataGridViewEmpleyees.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridViewEmpleyees.Location = new System.Drawing.Point(-1, 71);
            this.dataGridViewEmpleyees.Name = "dataGridViewEmpleyees";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmpleyees.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewEmpleyees.RowHeadersVisible = false;
            this.dataGridViewEmpleyees.RowHeadersWidth = 45;
            this.dataGridViewEmpleyees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmpleyees.Size = new System.Drawing.Size(633, 236);
            this.dataGridViewEmpleyees.TabIndex = 15;
            // 
            // E_ID
            // 
            this.E_ID.DataPropertyName = "E_ID";
            this.E_ID.HeaderText = "E_ID";
            this.E_ID.Name = "E_ID";
            this.E_ID.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "E_NAME";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "E_SNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Soyad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "E_STATUS";
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(9, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 27);
            this.label15.TabIndex = 35;
            this.label15.Text = "Firma";
            // 
            // cmbFirms
            // 
            this.cmbFirms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFirms.DropDownHeight = 100;
            this.cmbFirms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFirms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFirms.FormattingEnabled = true;
            this.cmbFirms.IntegralHeight = false;
            this.cmbFirms.Location = new System.Drawing.Point(104, 19);
            this.cmbFirms.Name = "cmbFirms";
            this.cmbFirms.Size = new System.Drawing.Size(268, 32);
            this.cmbFirms.TabIndex = 10;
            this.cmbFirms.SelectedValueChanged += new System.EventHandler(this.cmbFirms_SelectedValueChanged);
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 308);
            this.Controls.Add(this.panel6);
            this.Name = "Company";
            this.Text = "Company";
            this.Load += new System.EventHandler(this.Company_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleyees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.DataGridView dataGridViewEmpleyees;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbFirms;
        private System.Windows.Forms.DataGridViewTextBoxColumn E_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnCompanySave;
    }
}