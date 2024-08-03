using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNIKITCHEN.DBL.Repositories.Repository;

namespace UNIKITCHEN.WINFORM
{
    public partial class FrmDepozitBrowser : Form
    {
        public DataGridView DGVMAIN
        {
            get
            {
                return this.dgvMain;
            }
            set
            {
                this.dgvMain = DGVMAIN;
            }
        }


        OperationRepository _operationRepository;
        public FrmDepozitBrowser()
        {
            _operationRepository = new OperationRepository();

            InitializeComponent();

        }

        private void FrmDepozitBrowser_Load(object sender, EventArgs e)
        {

            //lblUserName.Text = "deneme";
            this.StartPosition = FormStartPosition.CenterScreen;

            GridLoad();
        }


        public void GridLoad()
        {
            var list = _operationRepository.GetAll()
                .Where(w => w.OPR_TYPE == 5 && w.OPR_STATUS!=-1)
                .Select(s => new { OPR_ID = s.OPR_ID, OPR_NO = s.OPR_NO, OPR_DATE = s.OPR_DATE, OPR_TOTAL = s.OPR_TOTAL }).OrderByDescending(o=>o.OPR_ID).ToList();


            this.dgvMain.DataSource = list;
            this.dgvMain.Columns["OPR_DATE"].DefaultCellStyle.Format = "dd-MM-yyyy";

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FrmDepozitPopup frmDepozitPopup = new FrmDepozitPopup(this);
            frmDepozitPopup.ShowDialog(this); 

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int OPR_ID = Convert.ToInt32(this.dgvMain.CurrentRow.Cells["OPR_ID"].Value.ToString());
        
            if (OPR_ID > 0)
            {
                FrmDepozitPopup frmDepozitPopup = new FrmDepozitPopup(this,OPR_ID);
                frmDepozitPopup.ShowDialog(this);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Ləğv etməyə əminsiz??",
                                 "Təsdiq et!!",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmResult == DialogResult.Yes)
            {
                int OPR_ID = Convert.ToInt32(this.dgvMain.CurrentRow.Cells["OPR_ID"].Value.ToString());

                if (OPR_ID > 0)
                {
                    bool result = _operationRepository.Delete(OPR_ID);

                    if (result)
                    {
                        MessageBox.Show("Əməliyyat uğurla reallaşdı", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GridLoad();
                    }
                    else
                    {
                        MessageBox.Show("Əməliyyat reallaşmadı", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }


        }
    }
}
