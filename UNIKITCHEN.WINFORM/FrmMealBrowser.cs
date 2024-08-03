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
    public partial class FrmMealBrowser : Form
    {
        MealRepository _mealRepository;
        UomRepository _uomRepository;
        CategoriRepository _categoriRepository;

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
        public FrmMealBrowser()
        {
            InitializeComponent();

            _mealRepository = new MealRepository();
            _uomRepository = new UomRepository();
            _categoriRepository = new CategoriRepository();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FrmMealPopup frmMealPopup = new FrmMealPopup(this);
            frmMealPopup.ShowDialog(this);
        }

        public void GridLoad()
        {
            
            var list = _mealRepository.GetAll()
                                        .Where(w=>w.M_ID!=1 && w.M_STATUS==0)
                                        .Select(
                                            s => new
                                            {
                                                M_ID = s.M_ID,
                                                M_CODE = s.M_CODE,
                                                M_NAME = s.M_NAME,
                                                M_CAT_ID = s.M_CAT_ID,
                                                CAT_NAME = _categoriRepository.GetById(s.M_CAT_ID ?? 0).CAT_NAME,
                                                M_UO_ID = s.M_OU_ID,
                                                UO_NAME = _uomRepository.GetById(s.M_OU_ID ?? 0).UO_NAME

                                            }
                                        )
                                        .OrderByDescending(o=>o.M_ID).ToList();

            
            this.dgvMain.DataSource = list;
                                       
        }

       
        public void FrmMealBrowser_Load(object sender, EventArgs e)
        {
            GridLoad();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvMain.CurrentRow!=null)
            {
                int M_ID = Convert.ToInt32(this.dgvMain.CurrentRow.Cells["M_ID"].Value);

                FrmMealPopup frmMealPopup = new FrmMealPopup(this, M_ID);
                frmMealPopup.ShowDialog(this);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvMain.CurrentRow!=null)
            {
                int M_ID = Convert.ToInt32(this.dgvMain.CurrentRow.Cells["M_ID"].Value);

                if (M_ID > 0)
                {
                    var confirmResult = MessageBox.Show("Ləğv etməyə əminsiz??",
                                     "Təsdiq et!!",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirmResult == DialogResult.Yes)
                    {


                        bool result = _mealRepository.Delete(M_ID);

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
