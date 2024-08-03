namespace UNIKITCHEN.WINFORM
{
    partial class FrmMealPopup
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbM_OU_ID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbM_CAT_ID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtM_COFISENT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtM_NAME = new System.Windows.Forms.TextBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtM_CODE = new System.Windows.Forms.TextBox();
            this.txtM_ID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbM_OU_ID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbM_CAT_ID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtM_COFISENT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtM_NAME);
            this.panel1.Controls.Add(this.lblErrorMessage);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtM_CODE);
            this.panel1.Controls.Add(this.txtM_ID);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 180);
            this.panel1.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(251, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Ölçü";
            // 
            // cmbM_OU_ID
            // 
            this.cmbM_OU_ID.FormattingEnabled = true;
            this.cmbM_OU_ID.Location = new System.Drawing.Point(306, 81);
            this.cmbM_OU_ID.Name = "cmbM_OU_ID";
            this.cmbM_OU_ID.Size = new System.Drawing.Size(121, 21);
            this.cmbM_OU_ID.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Kateqori";
            // 
            // cmbM_CAT_ID
            // 
            this.cmbM_CAT_ID.FormattingEnabled = true;
            this.cmbM_CAT_ID.Location = new System.Drawing.Point(115, 81);
            this.cmbM_CAT_ID.Name = "cmbM_CAT_ID";
            this.cmbM_CAT_ID.Size = new System.Drawing.Size(121, 21);
            this.cmbM_CAT_ID.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(439, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Kofisent";
            // 
            // txtM_COFISENT
            // 
            this.txtM_COFISENT.Location = new System.Drawing.Point(534, 36);
            this.txtM_COFISENT.Name = "txtM_COFISENT";
            this.txtM_COFISENT.Size = new System.Drawing.Size(100, 20);
            this.txtM_COFISENT.TabIndex = 42;
            this.txtM_COFISENT.Text = "0";
            this.txtM_COFISENT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtM_COFISENT_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Adı";
            // 
            // txtM_NAME
            // 
            this.txtM_NAME.Location = new System.Drawing.Point(306, 36);
            this.txtM_NAME.Name = "txtM_NAME";
            this.txtM_NAME.Size = new System.Drawing.Size(121, 20);
            this.txtM_NAME.TabIndex = 42;
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
            this.btnSave.Location = new System.Drawing.Point(526, 140);
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
            this.label3.Location = new System.Drawing.Point(43, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Kodu";
            // 
            // txtM_CODE
            // 
            this.txtM_CODE.Location = new System.Drawing.Point(115, 38);
            this.txtM_CODE.Name = "txtM_CODE";
            this.txtM_CODE.Size = new System.Drawing.Size(121, 20);
            this.txtM_CODE.TabIndex = 4;
            // 
            // txtM_ID
            // 
            this.txtM_ID.Location = new System.Drawing.Point(0, 0);
            this.txtM_ID.Name = "txtM_ID";
            this.txtM_ID.Size = new System.Drawing.Size(100, 20);
            this.txtM_ID.TabIndex = 0;
            this.txtM_ID.Text = "0";
            this.txtM_ID.Visible = false;
            // 
            // FrmMealPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 181);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMealPopup";
            this.Text = "FrmMealPopup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtM_CODE;
        private System.Windows.Forms.TextBox txtM_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbM_OU_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbM_CAT_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtM_COFISENT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtM_NAME;
    }
}