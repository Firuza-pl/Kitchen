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
    public partial class FrmMealPricePopup : Form
    {
        MealRepository _mealRepository;
        MealPriceRepository _mealPriceRepository;
        FrmMealPriceBrowser _mealPriceBrowser;
        public FrmMealPricePopup(FrmMealPriceBrowser mealPriceBrowser,int MP_ID=0)
        {
            _mealRepository = new MealRepository();
            _mealPriceRepository = new MealPriceRepository();
            _mealPriceBrowser = mealPriceBrowser;

            InitializeComponent();

            LoadCombo();

            if (MP_ID>0)
            {
               T_MEALPRICE mealPrice = _mealPriceRepository.GetById(MP_ID);

                if (mealPrice!=null)
                {
                    txtMP_ID.Text = mealPrice.MP_ID.ToString();
                    cmbMP_M_ID.SelectedValue = mealPrice.MP_M_ID;
                    dtpMP_BGDATE.Text = Convert.ToDateTime(mealPrice.MP_BGDATE).ToString("yyyy-MM-dd");
                    dtpMP_ENDATE.Text = Convert.ToDateTime(mealPrice.MP_ENDATE).ToString("yyyy-MM-dd");
                    txtMP_AMOUNT.Text = mealPrice.MP_AMOUNT.ToString();
                }
            }
        }

        private void FrmMealPricePopup_Load(object sender, EventArgs e)
        {
            dtpMP_BGDATE.Format = DateTimePickerFormat.Custom;
            dtpMP_BGDATE.CustomFormat = "yyyy-MM-dd";
            // dtpMP_BGDATE.ShowUpDown = true;


            dtpMP_ENDATE.Format = DateTimePickerFormat.Custom;
            dtpMP_ENDATE.CustomFormat = "yyyy-MM-dd";
            // dtpMP_BGDATE.ShowUpDown = true;


        }

        private void LoadCombo()
        {

            //Category Load
            List<T_MEALS> meals = _mealRepository.GetAll().ToList();
            meals.Reverse();

            cmbMP_M_ID.DisplayMember = "M_NAME";
            cmbMP_M_ID.ValueMember = "M_ID";
            cmbMP_M_ID.DataSource = meals;
            cmbMP_M_ID.SelectedIndex = -1;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtMP_AMOUNT.Text=="0" || cmbMP_M_ID.SelectedIndex==-1)
            {
                MessageBox.Show("Sahələri boş keçməyin!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                T_MEALPRICE mealPrice = new T_MEALPRICE()
                {
                    MP_ID = Convert.ToInt32(txtMP_ID.Text),
                    MP_M_ID = Convert.ToInt32(cmbMP_M_ID.SelectedValue),
                    MP_BGDATE = Convert.ToDateTime(dtpMP_BGDATE.Text),
                    MP_ENDATE = Convert.ToDateTime(dtpMP_ENDATE.Text),
                    MP_AMOUNT = Convert.ToDouble(txtMP_AMOUNT.Text),
                    MP_CRDATE = DateTime.Now,
                    MP_U_ID = LoginInfo.userID,
                    MP_STATUS = 0
                };

                if (mealPrice.MP_ID == 0)
                {
                    mealPrice.MP_ID = _mealPriceRepository.Insert(mealPrice);
                }
                else
                {
                    mealPrice.MP_ID = _mealPriceRepository.Update(mealPrice);
                }

                if (mealPrice.MP_ID > 0)
                {
                    MessageBox.Show("Əməliyyat uğurla reallaşdı!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    _mealPriceBrowser.GridLoad();

                   
                }
            }
           
        }
    }
}
