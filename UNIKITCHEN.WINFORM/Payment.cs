using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIKITCHEN.WINFORM
{

    public partial class Payment : Form
    {
        Kassa _kassa;
        public static bool isTextbox1Active = true;

        public Payment(Kassa kassa)
        {
            InitializeComponent();
            _kassa = kassa;

            txtPayment.LostFocus += new EventHandler(TextBox_LostFocus);

            btn_0.Click += new EventHandler(btnClick);
            btn_1.Click += new EventHandler(btnClick);
            btn_2.Click += new EventHandler(btnClick);
            btn_3.Click += new EventHandler(btnClick);
            btn_4.Click += new EventHandler(btnClick);
            btn_5.Click += new EventHandler(btnClick);
            btn_6.Click += new EventHandler(btnClick);
            btn_7.Click += new EventHandler(btnClick);
            btn_8.Click += new EventHandler(btnClick);
            btn_9.Click += new EventHandler(btnClick);
            btn_point.Click += new EventHandler(btnClick);

            this.txtTotal.Text =  _kassa.calculateTotal().ToString();

        }
        private void Btn_del_Click(object sender, EventArgs e)
        {
            if (isTextbox1Active)
            {
                txtPayment.Text = "";
            }
            else
            {
              //  txtM_QTY.Text = "";
            }
        }
        private void btnClick(object sender, EventArgs e)
        {
            string txt_num = (sender as Button).Text;
            //    txtM_NAME.Text += txt_num;
            if (isTextbox1Active)
            {
                txtPayment.Text += txt_num;
            }
            else
            {
                //txtM_QTY.Text += txt_num;
            }

        }
        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            if ((sender as TextBox).Name == "txtPayment")
            {
                isTextbox1Active = true;
            }
            else
            {
                isTextbox1Active = false;
            }
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;
            this.Hide();
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            double total = (txtTotal.Text == "" ? 0 : Convert.ToDouble(txtTotal.Text));
            double payment = (txtPayment.Text == "" ? 0 : Convert.ToDouble(txtPayment.Text));

            txtRemaind.Text = (payment - total).ToString();
        }

      
    }
}
