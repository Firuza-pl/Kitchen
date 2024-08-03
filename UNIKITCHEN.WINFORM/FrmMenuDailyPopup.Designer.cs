namespace UNIKITCHEN.WINFORM
{
    partial class FrmMenuDailyPopup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMenuDayLine = new System.Windows.Forms.DataGridView();
            this.MDL_M_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MDL_M_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MDL_UO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MDL_UO_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MDL_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtMDL_QTY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMDL_UO_ID = new System.Windows.Forms.ComboBox();
            this.cmbMDL_M_ID = new System.Windows.Forms.ComboBox();
            this.dtpMD_BLENTIME = new System.Windows.Forms.DateTimePicker();
            this.dtpMD_BLBGTIME = new System.Windows.Forms.DateTimePicker();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMD_ID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuDayLine)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMenuDayLine
            // 
            this.dgvMenuDayLine.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvMenuDayLine.AllowUserToAddRows = false;
            this.dgvMenuDayLine.AllowUserToDeleteRows = false;
            this.dgvMenuDayLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMenuDayLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenuDayLine.BackgroundColor = System.Drawing.Color.White;
            this.dgvMenuDayLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMenuDayLine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenuDayLine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenuDayLine.ColumnHeadersHeight = 30;
            this.dgvMenuDayLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MDL_M_ID,
            this.MDL_M_NAME,
            this.MDL_UO_ID,
            this.MDL_UO_NAME,
            this.MDL_QTY});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenuDayLine.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMenuDayLine.EnableHeadersVisualStyles = false;
            this.dgvMenuDayLine.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dgvMenuDayLine.Location = new System.Drawing.Point(1, 160);
            this.dgvMenuDayLine.Name = "dgvMenuDayLine";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenuDayLine.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMenuDayLine.RowHeadersVisible = false;
            this.dgvMenuDayLine.RowHeadersWidth = 45;
            this.dgvMenuDayLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenuDayLine.Size = new System.Drawing.Size(721, 240);
            this.dgvMenuDayLine.TabIndex = 16;
            // 
            // MDL_M_ID
            // 
            this.MDL_M_ID.DataPropertyName = "MDL_M_ID";
            this.MDL_M_ID.HeaderText = "MDL_M_ID";
            this.MDL_M_ID.Name = "MDL_M_ID";
            this.MDL_M_ID.Visible = false;
            // 
            // MDL_M_NAME
            // 
            this.MDL_M_NAME.DataPropertyName = "MDL_M_NAME";
            this.MDL_M_NAME.HeaderText = "Menu";
            this.MDL_M_NAME.Name = "MDL_M_NAME";
            // 
            // MDL_UO_ID
            // 
            this.MDL_UO_ID.DataPropertyName = "MDL_UO_ID";
            this.MDL_UO_ID.HeaderText = "MDL_UO_ID";
            this.MDL_UO_ID.Name = "MDL_UO_ID";
            this.MDL_UO_ID.Visible = false;
            // 
            // MDL_UO_NAME
            // 
            this.MDL_UO_NAME.DataPropertyName = "MDL_UO_NAME";
            this.MDL_UO_NAME.HeaderText = "Ölçü";
            this.MDL_UO_NAME.Name = "MDL_UO_NAME";
            // 
            // MDL_QTY
            // 
            this.MDL_QTY.DataPropertyName = "MDL_QTY";
            this.MDL_QTY.HeaderText = "Miqdar";
            this.MDL_QTY.Name = "MDL_QTY";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtMDL_QTY);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbMDL_UO_ID);
            this.panel1.Controls.Add(this.cmbMDL_M_ID);
            this.panel1.Controls.Add(this.dtpMD_BLENTIME);
            this.panel1.Controls.Add(this.dtpMD_BLBGTIME);
            this.panel1.Controls.Add(this.btnAddLine);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtMD_ID);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 161);
            this.panel1.TabIndex = 51;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(587, 112);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 30);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Ləğv Et";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtMDL_QTY
            // 
            this.txtMDL_QTY.Location = new System.Drawing.Point(458, 95);
            this.txtMDL_QTY.Name = "txtMDL_QTY";
            this.txtMDL_QTY.Size = new System.Drawing.Size(100, 20);
            this.txtMDL_QTY.TabIndex = 45;
            this.txtMDL_QTY.Text = "0";
            this.txtMDL_QTY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMDL_QTY_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(383, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Miqdar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(201, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Ölçü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Menu";
            // 
            // cmbMDL_UO_ID
            // 
            this.cmbMDL_UO_ID.Enabled = false;
            this.cmbMDL_UO_ID.FormattingEnabled = true;
            this.cmbMDL_UO_ID.Location = new System.Drawing.Point(256, 97);
            this.cmbMDL_UO_ID.Name = "cmbMDL_UO_ID";
            this.cmbMDL_UO_ID.Size = new System.Drawing.Size(121, 21);
            this.cmbMDL_UO_ID.TabIndex = 43;
            // 
            // cmbMDL_M_ID
            // 
            this.cmbMDL_M_ID.FormattingEnabled = true;
            this.cmbMDL_M_ID.Location = new System.Drawing.Point(65, 97);
            this.cmbMDL_M_ID.Name = "cmbMDL_M_ID";
            this.cmbMDL_M_ID.Size = new System.Drawing.Size(121, 21);
            this.cmbMDL_M_ID.TabIndex = 43;
            this.cmbMDL_M_ID.SelectedIndexChanged += new System.EventHandler(this.cmbMDL_M_ID_SelectedIndexChanged);
            // 
            // dtpMD_BLENTIME
            // 
            this.dtpMD_BLENTIME.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMD_BLENTIME.Location = new System.Drawing.Point(383, 29);
            this.dtpMD_BLENTIME.Name = "dtpMD_BLENTIME";
            this.dtpMD_BLENTIME.Size = new System.Drawing.Size(111, 20);
            this.dtpMD_BLENTIME.TabIndex = 42;
            // 
            // dtpMD_BLBGTIME
            // 
            this.dtpMD_BLBGTIME.CustomFormat = "";
            this.dtpMD_BLBGTIME.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMD_BLBGTIME.Location = new System.Drawing.Point(154, 30);
            this.dtpMD_BLBGTIME.Name = "dtpMD_BLBGTIME";
            this.dtpMD_BLBGTIME.Size = new System.Drawing.Size(111, 20);
            this.dtpMD_BLBGTIME.TabIndex = 41;
            // 
            // btnAddLine
            // 
            this.btnAddLine.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddLine.AutoSize = true;
            this.btnAddLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.btnAddLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLine.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLine.ForeColor = System.Drawing.Color.White;
            this.btnAddLine.Location = new System.Drawing.Point(587, 60);
            this.btnAddLine.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(108, 30);
            this.btnAddLine.TabIndex = 40;
            this.btnAddLine.Text = "Əlavə et";
            this.btnAddLine.UseVisualStyleBackColor = false;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(271, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Bitiş tarixi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "Başlanğıc tarix";
            // 
            // txtMD_ID
            // 
            this.txtMD_ID.Location = new System.Drawing.Point(0, 0);
            this.txtMD_ID.Name = "txtMD_ID";
            this.txtMD_ID.Size = new System.Drawing.Size(100, 20);
            this.txtMD_ID.TabIndex = 0;
            this.txtMD_ID.Text = "0";
            this.txtMD_ID.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(589, 405);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 30);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Yadda saxla";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmMenuDailyPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 449);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMenuDayLine);
            this.Name = "FrmMenuDailyPopup";
            this.Text = "FrmMenuDailyPopup";
            this.Load += new System.EventHandler(this.FrmMenuDailyPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuDayLine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvMenuDayLine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMD_ID;
        private System.Windows.Forms.DateTimePicker dtpMD_BLENTIME;
        private System.Windows.Forms.DateTimePicker dtpMD_BLBGTIME;
        private System.Windows.Forms.TextBox txtMDL_QTY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMDL_UO_ID;
        private System.Windows.Forms.ComboBox cmbMDL_M_ID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn MDL_M_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MDL_M_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MDL_UO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MDL_UO_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MDL_QTY;
        private System.Windows.Forms.Button btnDelete;
    }
}