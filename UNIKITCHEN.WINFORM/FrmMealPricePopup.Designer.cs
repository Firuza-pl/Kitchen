namespace UNIKITCHEN.WINFORM
{
    partial class FrmMealPricePopup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMP_ID = new System.Windows.Forms.TextBox();
            this.cmbMP_M_ID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMP_BGDATE = new System.Windows.Forms.DateTimePicker();
            this.dtpMP_ENDATE = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMP_AMOUNT = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.txtMP_AMOUNT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpMP_ENDATE);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpMP_BGDATE);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbMP_M_ID);
            this.panel1.Controls.Add(this.lblErrorMessage);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMP_ID);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 216);
            this.panel1.TabIndex = 52;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblErrorMessage.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.White;
            this.lblErrorMessage.Location = new System.Drawing.Point(11, 129);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 20);
            this.lblErrorMessage.TabIndex = 41;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(494, 139);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 30);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Yadda saxla";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Yimək Adı";
            // 
            // txtMP_ID
            // 
            this.txtMP_ID.Location = new System.Drawing.Point(0, 0);
            this.txtMP_ID.Name = "txtMP_ID";
            this.txtMP_ID.Size = new System.Drawing.Size(100, 20);
            this.txtMP_ID.TabIndex = 0;
            this.txtMP_ID.Text = "0";
            this.txtMP_ID.Visible = false;
            // 
            // cmbMP_M_ID
            // 
            this.cmbMP_M_ID.FormattingEnabled = true;
            this.cmbMP_M_ID.Location = new System.Drawing.Point(112, 49);
            this.cmbMP_M_ID.Name = "cmbMP_M_ID";
            this.cmbMP_M_ID.Size = new System.Drawing.Size(121, 21);
            this.cmbMP_M_ID.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Başlanğıc Tarixi";
            // 
            // dtpMP_BGDATE
            // 
            this.dtpMP_BGDATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMP_BGDATE.Location = new System.Drawing.Point(433, 47);
            this.dtpMP_BGDATE.Name = "dtpMP_BGDATE";
            this.dtpMP_BGDATE.Size = new System.Drawing.Size(138, 20);
            this.dtpMP_BGDATE.TabIndex = 44;
            // 
            // dtpMP_ENDATE
            // 
            this.dtpMP_ENDATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMP_ENDATE.Location = new System.Drawing.Point(433, 98);
            this.dtpMP_ENDATE.Name = "dtpMP_ENDATE";
            this.dtpMP_ENDATE.Size = new System.Drawing.Size(138, 20);
            this.dtpMP_ENDATE.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(304, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Bitiş Tarixi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Qiymət";
            // 
            // txtMP_AMOUNT
            // 
            this.txtMP_AMOUNT.Location = new System.Drawing.Point(112, 98);
            this.txtMP_AMOUNT.Name = "txtMP_AMOUNT";
            this.txtMP_AMOUNT.Size = new System.Drawing.Size(121, 20);
            this.txtMP_AMOUNT.TabIndex = 48;
            this.txtMP_AMOUNT.Text = "0";
            // 
            // FrmMealPricePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 213);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMealPricePopup";
            this.Text = "FrmMealPricePopup";
            this.Load += new System.EventHandler(this.FrmMealPricePopup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMP_ID;
        private System.Windows.Forms.ComboBox cmbMP_M_ID;
        private System.Windows.Forms.DateTimePicker dtpMP_BGDATE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMP_AMOUNT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpMP_ENDATE;
        private System.Windows.Forms.Label label2;
    }
}