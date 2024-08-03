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
    public partial class FrmDepozitPopup : Form
    {
        OperationRepository _operationRepository;
        FrmDepozitBrowser _frmDepozitBrowser;


        public FrmDepozitPopup(FrmDepozitBrowser frmDepozitBrowser, int OPR_ID = 0)
        {
            _operationRepository = new OperationRepository();
            _frmDepozitBrowser = frmDepozitBrowser;

            InitializeComponent();


            if (OPR_ID > 0)
            {
                T_OPERATION _operation = _operationRepository.GetById(OPR_ID);

                txtOPR_ID.Text = _operation.OPR_ID.ToString();
                txtOPR_TOTAL.Text = _operation.OPR_TOTAL.ToString();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtOPR_TOTAL.Text.Trim()=="")
            {
                MessageBox.Show("Depozit totalın boş keçmə!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            else
            {
                int maxID = _operationRepository.getMaxID();

                T_OPERATION depozit = new T_OPERATION()
                {
                    OPR_ID = Convert.ToInt32(txtOPR_ID.Text),
                    OPR_NO = "OPR-" + (++maxID),
                    OPR_TYPE = 5,
                    OPR_STYPE = 0,
                    OPR_DATE = DateTime.Now,
                    OPR_F_ID = 0,
                    OPR_E_ID = 0,
                    OPR_BL = false,
                    OPR_STATUS = 0,
                    OPR_TOTAL = Convert.ToDouble(txtOPR_TOTAL.Text)
                };

                int result;

                if (Convert.ToInt32(txtOPR_ID.Text) == 0)
                {
                    result = _operationRepository.Insert(depozit);



                }
                else
                {
                    result = _operationRepository.Update(depozit);



                }

                if (result > 0)
                {
                    MessageBox.Show("Əməliyyat uğurla reallaşdı", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    _frmDepozitBrowser.GridLoad();

                    resetAllControl();
                }
            }

           

        }


        private void resetAllControl()
        {
            txtOPR_ID.Text = "0";
            txtOPR_TOTAL.Text = "0";
           
        }

        private void txtOPR_TOTAL_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
