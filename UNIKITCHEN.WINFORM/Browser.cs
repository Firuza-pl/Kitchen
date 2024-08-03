using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNIKITCHEN.DBL.Entity;
using UNIKITCHEN.DBL.EntityFramework;
using UNIKITCHEN.DBL.Repositories.Repository;

namespace UNIKITCHEN.WINFORM
{
    public partial class Browser : Form
    {
        OperationRepository _operationRepository;
        ZRepository _zRepository;
        public Browser()
        {
            _operationRepository = new OperationRepository();
            _zRepository = new ZRepository();

            InitializeComponent();
        }

        private void Browser_Load(object sender, EventArgs e)
        {

            dtpBegin.Value = DateTime.Now;
            dtpBegin.Enabled = false;

            GridLoad();

            this.StartPosition = FormStartPosition.CenterScreen;

            //this.WindowState = FormWindowState.Maximized;
        }

        private void GridLoad()
        {
            //dgvMain.Rows.Clear();

            dgvMain.DataSource = _operationRepository.GetOperations();
        }

        private void dtpBegin_ValueChanged(object sender, EventArgs e)
        {
       
            GridLoad();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.Hide();

            Kassa cash = new Kassa();
            cash.Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Siz melumat; silməyə əminsiz?",
                                      "Əməliyyatı təsdiqlə",
                                      MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                int oprID = Convert.ToInt32(dgvMain.CurrentRow.Cells["OPR_ID"].Value.ToString());

                bool result = _operationRepository.Delete(oprID);

                if (result)
                {
                    MessageBox.Show("Məlumat silindi", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridLoad();
                }
                else
                {
                    MessageBox.Show("Məlumat silinmədi", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();

            int oprID = Convert.ToInt32(dgvMain.CurrentRow.Cells["OPR_ID"].Value.ToString());

            Kassa kassa = new Kassa(oprID);
            kassa.Show();
        }

        private void btnEndOfDay_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Günü sonlandırmaya əminsiz??",
                                 "Təsdiq et!!",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmResult == DialogResult.Yes)
            {


                T_Z z = new T_Z()
                {
                    Z_NO = "Z-" + _zRepository.getMaxNo(),
                    Z_DATE = DateTime.Now,
                    Z_U_ID = LoginInfo.userID
                };

                int Z_ID = _zRepository.Insert(z);

                if (Z_ID > 0)
                {
                    List<SP_GETOPERATIONOFTHEDAYE_Result> operations = _operationRepository.getOperationsOfTheDay().ToList();

                    double Total = 0;

                    foreach (SP_GETOPERATIONOFTHEDAYE_Result operation in operations)
                    {
                        T_OPERATION oPERATION = new T_OPERATION()
                        {
                            OPR_ID     = operation.OPR_ID,
                            OPR_NO     = operation.OPR_NO,
                            OPR_BL     = operation.OPR_BL,
                            OPR_DATE   = operation.OPR_DATE,
                            OPR_E_ID   = operation.OPR_E_ID,
                            OPR_F_ID   = operation.OPR_F_ID,
                            OPR_STATUS = operation.OPR_STATUS,
                            OPR_STYPE  = operation.OPR_STYPE,
                            OPR_TOTAL  = operation.OPR_TOTAL,
                            OPR_TYPE   = operation.OPR_TYPE,
                            OPR_Z_ID   = Z_ID
                        };

                        var result = _operationRepository.Update(oPERATION);

                        if (result > 0)
                        {
                            Total += (operation.OPR_TOTAL ?? 0);
                        }
                    }

                    z.Z_AMOUNT = Total;
                }

                var _Z_ID = _zRepository.Update(z);

                if (_Z_ID > 0)
                {
                    int oprMaxID = _operationRepository.getMaxID();
                    T_OPERATION operationZ = new T_OPERATION()
                    {
                        OPR_NO = "OPR-" + (++oprMaxID),
                        OPR_TYPE = 4,
                        OPR_STYPE = 0,
                        OPR_BL = false,
                        OPR_DATE = DateTime.Now,
                        OPR_F_ID = 0,
                        OPR_E_ID = 0,
                        OPR_STATUS = 0,
                        OPR_TOTAL = z.Z_AMOUNT
                    };

                    _operationRepository.Insert(operationZ);

                    MessageBox.Show("Əməliyyat uğurla reallaşdı", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Əməliyyat reallaşmadı", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
           
        }

   
    }
}
