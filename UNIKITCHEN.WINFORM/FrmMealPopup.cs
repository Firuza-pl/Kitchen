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
    public partial class FrmMealPopup : Form
    {
        FrmMealBrowser _frmMealBrowser;
        MealRepository _mealRepository;
        UomRepository _uomRepository;
        CategoriRepository _categoriRepository;

        public FrmMealPopup(FrmMealBrowser frmMealBrowser,int M_ID=0)
        {
            _mealRepository = new MealRepository();
            _uomRepository = new UomRepository();
            _categoriRepository = new CategoriRepository();
            _frmMealBrowser = frmMealBrowser;

            InitializeComponent();
            LoadCombo();


            if (M_ID>0)
            {
                T_MEALS meals = _mealRepository.GetById(M_ID);

                string deneme = meals.M_CODE;

                txtM_ID.Text = meals.M_ID.ToString();
                txtM_CODE.Text = meals.M_CODE!=null ? meals.M_CODE.ToString():"";
                txtM_NAME.Text = meals.M_NAME.ToString();
                cmbM_CAT_ID.SelectedValue = meals.M_CAT_ID;
                cmbM_OU_ID.SelectedValue = meals.M_OU_ID;
                txtM_COFISENT.Text = meals.M_COFISENT.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtM_NAME.Text.Trim() == "" || cmbM_CAT_ID.SelectedIndex == -1 || cmbM_OU_ID.SelectedIndex == -1)
            {
                MessageBox.Show("Boş sahələri doldurun!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                T_MEALS meals = new T_MEALS()
                {
                    M_ID = Convert.ToInt32(txtM_ID.Text),
                    M_CODE = txtM_CODE.Text,
                    M_NAME = txtM_NAME.Text,
                    M_CAT_ID = Convert.ToInt32(cmbM_CAT_ID.SelectedValue),
                    M_OU_ID = Convert.ToInt32(cmbM_OU_ID.SelectedValue),
                    M_COFISENT = Convert.ToDouble(txtM_COFISENT.Text),
                    M_STATUS = 0
                };

                if (meals.M_ID == 0)
                {
                    meals.M_ID = _mealRepository.Insert(meals);
                }
                else
                {
                    meals.M_ID = _mealRepository.Update(meals);
                }

                if (meals.M_ID > 0)
                {
                    MessageBox.Show("Əməliyyat uğurla reallaşdı", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    _frmMealBrowser.GridLoad();
                 }
            }

        }

        private void LoadCombo()
        {

            //Category Load
            List<T_CATEGORY> categories = _categoriRepository.GetAll().ToList();
            categories.Reverse();

            cmbM_CAT_ID.DisplayMember = "CAT_NAME";
            cmbM_CAT_ID.ValueMember = "CAT_ID";
            cmbM_CAT_ID.DataSource = categories;
            cmbM_CAT_ID.SelectedIndex = -1;

            //UO load
            List<T_UOM> uoms = _uomRepository.GetAll().ToList();
            cmbM_OU_ID.DisplayMember = "UO_NAME";
            cmbM_OU_ID.ValueMember = "UO_ID";
            cmbM_OU_ID.DataSource = uoms;
            cmbM_OU_ID.SelectedIndex = -1;

        }

        private void txtM_COFISENT_KeyPress(object sender, KeyPressEventArgs e)
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
