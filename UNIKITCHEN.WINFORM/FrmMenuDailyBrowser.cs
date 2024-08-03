using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNIKITCHEN.DBL.EntityFramework;
using UNIKITCHEN.DBL.Repositories.Repository;

namespace UNIKITCHEN.WINFORM
{
    public partial class FrmMenuDailyBrowser : Form
    {
        MenuDayRepository _menuDayRepository;

       
        public DataGridView DGVMAIN
        {
            get
            {
                return this.dgvMain;
            }
            set
            {
                this.dgvMain = value;
            }
        }
        public FrmMenuDailyBrowser()
        {
            InitializeComponent();

            _menuDayRepository = new MenuDayRepository();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FrmMenuDailyPopup frmMenuDailyPopup= new FrmMenuDailyPopup(this);
            frmMenuDailyPopup.Show();
        }

        public void GridLoad()
        {
            this.dgvMain.Rows.Clear();

            List<T_MENUDAY> lists = _menuDayRepository.GetAll().OrderByDescending(o=>o.MD_ID).ToList();

            foreach (T_MENUDAY item in lists)
            {
                this.dgvMain.Rows.Add(item.MD_ID, item.MD_DATE, item.MD_BLBGTIME, item.MD_BLENTIME);
            }

            this.dgvMain.Columns["MD_DATE"].DefaultCellStyle.Format = "dd-MM-yyyy";
            this.dgvMain.Columns["MD_BLBGTIME"].DefaultCellStyle.Format = "hh\\:mm";
            this.dgvMain.Columns["MD_BLENTIME"].DefaultCellStyle.Format = "hh\\:mm";

        }

        private void FrmMenuDailyBrowser_Load(object sender, EventArgs e)
        {
            GridLoad();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int MD_ID = Convert.ToInt32(this.dgvMain.CurrentRow.Cells["MD_ID"].Value.ToString() !="" ? this.dgvMain.CurrentRow.Cells["MD_ID"].Value: 0);


            if (MD_ID>0)
            {
                FrmMenuDailyPopup frmMenuDailyPopup = new FrmMenuDailyPopup(this, MD_ID);
                frmMenuDailyPopup.Show();
                
            }
            else
            {
                MessageBox.Show("Bir sətir seçin!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int MD_ID = Convert.ToInt32(this.dgvMain.CurrentRow.Cells["MD_ID"].Value.ToString() != "" ? this.dgvMain.CurrentRow.Cells["MD_ID"].Value : 0);

            if (MD_ID > 0)
            {
                var confirmResult = MessageBox.Show("Ləğv etməyə əminsiz??",
                                 "Təsdiq et!!",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (confirmResult == DialogResult.Yes)
                {
                    bool result = _menuDayRepository.Delete(MD_ID);

                    if (result)
                    {
                        MessageBox.Show("Əməliyyat uğurla reallaşdı!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GridLoad();
                    }
                    else
                    {
                        MessageBox.Show("Əməliyyat reallaşmadı!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                
            }
            else
            {
                MessageBox.Show("Bir sətir seçin!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
