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
    public partial class ShopboxEdit : Form
    {
        Kassa _kassa;
        public static bool isTextbox1Active =true;
        public ShopboxEdit(Kassa kassa, string M_ID = "")
        {
            InitializeComponent();

           
            _kassa = kassa;

            txtM_ID.Text = _kassa.SHOPBASKET.CurrentRow.Cells["M_ID"].Value.ToString();
            txtM_NAME.Text = _kassa.SHOPBASKET.CurrentRow.Cells["M_NAME"].Value.ToString();
            txtM_PRICE.Text = _kassa.SHOPBASKET.CurrentRow.Cells["M_PRICE"].Value.ToString();
            txtM_QTY.Text = _kassa.SHOPBASKET.CurrentRow.Cells["M_QTY"].Value.ToString();
            txtM_TOTAL.Text = _kassa.SHOPBASKET.CurrentRow.Cells["M_TOTAL"].Value.ToString();


            txtM_PRICE.LostFocus += new EventHandler(TextBox_LostFocus);
            txtM_QTY.LostFocus += new EventHandler(TextBox_LostFocus);

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
        }

        private void Btn_del_Click(object sender, EventArgs e)
        {
            if (isTextbox1Active)
            {
                txtM_PRICE.Text = "";
            }
            else
            {
                txtM_QTY.Text = "";
            }
        }
        private void btnClick(object sender, EventArgs e)
        {
            string txt_num = (sender as Button).Text;
            if (isTextbox1Active)
            {
                txtM_PRICE.Text += txt_num;
            }
            else
            {
                txtM_QTY.Text += txt_num;
            }
      }
        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            if ((sender as TextBox).Name == "txtM_PRICE")
            {
                isTextbox1Active = true;
            }
            else
            {
                isTextbox1Active = false;
            }
        }

        private void btnShopBoxSave_Click(object sender, EventArgs e)
        {
            int M_ID = Convert.ToInt32(txtM_ID.Text);
            double M_QTY = Convert.ToDouble(txtM_QTY.Text.Trim()!="" ? txtM_QTY.Text : "0" );
            double M_TOTAL = Convert.ToDouble(txtM_TOTAL.Text);

           // Kassa kassa = new Kassa();


            DataGridView shopBasket = _kassa.SHOPBASKET;
           
            foreach (DataGridViewRow item in shopBasket.Rows)
            {
                if (item.Cells["M_ID"].Value.ToString() == M_ID.ToString())
                {
                    item.Cells["M_QTY"].Value = M_QTY;
                    item.Cells["M_TOTAL"].Value = M_TOTAL;
                    break;
                }
            }

            _kassa.SHOPBASKET= shopBasket;
            _kassa.lblBasketTotal.Text = String.Format("{0:f2}", Convert.ToDouble(_kassa.calculateTotal()).ToString(",0.00"));

            this.Hide();
        
        }

        private void txtM_QTY_TextChanged(object sender, EventArgs e)
        {
            txtM_TOTAL.Text = (Convert.ToDouble(txtM_QTY.Text=="" ? "0":txtM_QTY.Text) * Convert.ToDouble(txtM_PRICE.Text=="" ? "0": txtM_PRICE.Text)).ToString();
        }

      
        private void txtM_QTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_1_Click(object sender, EventArgs e)
        {

        }
    }
}
