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
    public partial class FrmMealPriceBrowser : Form
    {
        MealPriceRepository _mealPriceRepository;
        MealRepository _mealRepository;
        public FrmMealPriceBrowser()
        {
            _mealPriceRepository = new MealPriceRepository();
            _mealRepository = new MealRepository();

            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FrmMealPricePopup frmMealPricePopup = new FrmMealPricePopup(this);
            frmMealPricePopup.Show();
        }

        public void GridLoad()
        {
            var list = _mealPriceRepository.GetAll()
                                            .Select(s=>new {
                                                MP_ID = s.MP_ID,
                                                MP_M_ID=s.MP_M_ID,
                                                M_NAME = _mealRepository.GetById(s.MP_M_ID??0).M_NAME,
                                                MP_BGDATE = s.MP_BGDATE,
                                                MP_ENDATE =s.MP_ENDATE,
                                                MP_AMOUNT = s.MP_AMOUNT
                                            }).ToList();

            this.dgvMain.DataSource = list;
            this.dgvMain.Columns["MP_BGDATE"].DefaultCellStyle.Format = "dd-MM-yyyy";
            this.dgvMain.Columns["MP_ENDATE"].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        private void FrmMealPriceBrowser_Load(object sender, EventArgs e)
        {
            GridLoad();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvMain.CurrentRow!=null)
            {
                int MP_ID = Convert.ToInt32(this.dgvMain.CurrentRow.Cells["MP_ID"].Value);

                FrmMealPricePopup frmMealPricePopup = new FrmMealPricePopup(this, MP_ID);
                frmMealPricePopup.Show(this);
            }
            else
            {
                MessageBox.Show("Bir sətir seçin!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvMain.CurrentRow != null)
            {
                int MP_ID = Convert.ToInt32(this.dgvMain.CurrentRow.Cells["MP_ID"].Value);

                if (MP_ID > 0)
                {
                    var confirmResult = MessageBox.Show("Ləğv etməyə əminsiz??",
                                     "Təsdiq et!!",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirmResult == DialogResult.Yes)
                    {
                        bool result = _mealPriceRepository.Delete(MP_ID);

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
}
