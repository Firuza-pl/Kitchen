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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        

        private void FrmMain_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            //lblUserName.Text = "deneme";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void gününYeməyiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenForm();

            FrmMenuDailyBrowser frmMenuDailyBrowser = new FrmMenuDailyBrowser();
            frmMenuDailyBrowser.MdiParent = this;
            frmMenuDailyBrowser.Show();
        }

        private void depozitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenForm();

            FrmDepozitBrowser frmDepozitBrowser = new FrmDepozitBrowser();
            frmDepozitBrowser.MdiParent = this;
            frmDepozitBrowser.Show();

            
        }

        private void yeməklərToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenForm();

            FrmMealBrowser frmMealBrowser = new FrmMealBrowser();
            frmMealBrowser.MdiParent = this;
            frmMealBrowser.Show();
        }


        private void CloseAllOpenForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Close();
                }
            }
        }

        private void yemekQiymetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenForm();

            FrmMealPriceBrowser frmMealPriceBrowser = new FrmMealPriceBrowser();
            frmMealPriceBrowser.MdiParent = this;
            frmMealPriceBrowser.Show();
        }

        private void ÇıxışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Programdan çıxış etməyə əminsiz??",
                                    "Təsdiq et!!",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmResult == DialogResult.Yes)
            {
                this.Hide();
                
                Login loginForm = new Login();
                loginForm.StartPosition = FormStartPosition.CenterParent;
                loginForm.ShowDialog(this);
            }
        }
    }
}
