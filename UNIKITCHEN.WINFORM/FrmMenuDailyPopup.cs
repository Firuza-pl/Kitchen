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
    public partial class FrmMenuDailyPopup : Form
    {
        MealRepository _mealRepository;
        UomRepository _uomRepository;
        MenuDayRepository _menuDayRepository;
        FrmMenuDailyBrowser _menuDailyBrowser;

        public FrmMenuDailyPopup(FrmMenuDailyBrowser menuDailyBrowser,int MD_ID=0)
        {
            InitializeComponent();

            _mealRepository = new MealRepository();
            _uomRepository = new UomRepository();
            _menuDayRepository = new MenuDayRepository();
            _menuDailyBrowser = menuDailyBrowser;

            LoadCombo();

            if (MD_ID>0)
            {
               T_MENUDAY menuDay =  _menuDayRepository.GetById(MD_ID);

                if (menuDay!=null)
                {
                    txtMD_ID.Text = menuDay.MD_ID.ToString();
                    dtpMD_BLBGTIME.Text = menuDay.MD_BLBGTIME.ToString();
                    dtpMD_BLENTIME.Text = menuDay.MD_BLENTIME.ToString();


                    List<T_MENUDAYLINE> lines = _menuDayRepository.getLineById(MD_ID);


                    this.dgvMenuDayLine.Rows.Clear();

                    foreach (T_MENUDAYLINE item in lines)
                    {
                        int M_ID = Convert.ToInt32(item.MDL_M_ID);
                        string M_NAME =_mealRepository.GetById(item.MDL_M_ID??0).M_NAME;
                        int UO_ID = Convert.ToInt32(item.MDL_UO_ID);
                        string UO_NAME = _uomRepository.GetById(item.MDL_UO_ID??0).UO_NAME;
                        double M_QTY = Convert.ToDouble(item.MDL_QTY);

                        this.dgvMenuDayLine.Rows.Add(M_ID, M_NAME, UO_ID, UO_NAME, M_QTY);
                    }
                    
                }
            }
          

        }

        private void FrmMenuDailyPopup_Load(object sender, EventArgs e)
        {

             dtpMD_BLBGTIME.Format =  DateTimePickerFormat.Custom;
             dtpMD_BLBGTIME.CustomFormat = "HH:mm";
             dtpMD_BLBGTIME.ShowUpDown = true;
            //dtpMD_BLBGTIME.Text = "13:00";

             dtpMD_BLENTIME.Format = DateTimePickerFormat.Custom;
             dtpMD_BLENTIME.CustomFormat = "HH:mm";
             dtpMD_BLENTIME.ShowUpDown = true;
            //dtpMD_BLENTIME.Text = "16:00";

            //ResetAllControl();


        }

        private void LoadCombo()
        {

            //Meals Load
            List<T_MEALS> meals = _mealRepository.GetAll().Where(w=>w.M_ID!=1).ToList();
            meals.Reverse();

            cmbMDL_M_ID.DisplayMember = "M_NAME";
            cmbMDL_M_ID.ValueMember = "M_ID";

            cmbMDL_M_ID.DataSource = meals;

            cmbMDL_M_ID.SelectedIndex = -1;

            //UO load
            List<T_UOM> uoms = _uomRepository.GetAll().ToList();
            cmbMDL_UO_ID.DisplayMember = "UO_NAME";
            cmbMDL_UO_ID.ValueMember = "UO_ID";

            cmbMDL_UO_ID.DataSource = uoms;
            cmbMDL_UO_ID.SelectedIndex = -1;

        }

        private void cmbMDL_M_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMDL_M_ID.SelectedIndex!=-1)
            {
               T_MEALS meals =  _mealRepository.GetById(int.Parse(cmbMDL_M_ID.SelectedValue.ToString()));

                cmbMDL_UO_ID.SelectedValue = meals.M_OU_ID;
                txtMDL_QTY.Text = "0";
            }
           
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            if (cmbMDL_M_ID.SelectedIndex!=-1 && cmbMDL_UO_ID.SelectedIndex!=-1 && txtMDL_QTY.Text!="0")
            {
                int M_ID = Convert.ToInt32(cmbMDL_M_ID.SelectedValue);
                string M_NAME = cmbMDL_M_ID.Text;
                int UO_ID = Convert.ToInt32(cmbMDL_UO_ID.SelectedValue);
                string UO_NAME = cmbMDL_UO_ID.Text;
                double M_QTY = Convert.ToDouble(txtMDL_QTY.Text);

                this.dgvMenuDayLine.Rows.Add(M_ID, M_NAME, UO_ID, UO_NAME, M_QTY);
            }
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.dgvMenuDayLine.Rows.Count==0)
            {
                MessageBox.Show("Menu əlavə edin!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(TimeSpan.Parse(dtpMD_BLBGTIME.Text).CompareTo(TimeSpan.Parse(dtpMD_BLENTIME.Text)) >= 0)
            {
                MessageBox.Show("Başlangıc saatı Bitiş saatında az olmalı!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                T_MENUDAY menuDay = new T_MENUDAY()
                {
                    MD_ID = Convert.ToInt32(txtMD_ID.Text),
                    MD_BLBGTIME = TimeSpan.Parse(dtpMD_BLBGTIME.Text),
                    MD_BLENTIME = TimeSpan.Parse(dtpMD_BLENTIME.Text),
                    MD_DATE = DateTime.Now,
                    MD_U_ID = LoginInfo.userID,
                    MD_CRDATE = DateTime.Now,
                    MD_STATUS = 0
                };



                if (menuDay.MD_ID == 0)
                {
                    menuDay.MD_ID = _menuDayRepository.Insert(menuDay);
                }
                else
                {
                    menuDay.MD_ID = _menuDayRepository.Update(menuDay);
                }

                if (menuDay.MD_ID > 0)
                {

                    _menuDayRepository.DeleteLine(menuDay.MD_ID);

                    List<T_MENUDAYLINE> lines = new List<T_MENUDAYLINE>();

                    foreach (DataGridViewRow row in this.dgvMenuDayLine.Rows)
                    {
                        T_MENUDAYLINE menuDayLine = new T_MENUDAYLINE()
                        {
                            MDL_MD_ID = menuDay.MD_ID,
                            MDL_M_ID = Convert.ToInt32(row.Cells["MDL_M_ID"].Value),
                            MDL_UO_ID = Convert.ToInt32(row.Cells["MDL_UO_ID"].Value),
                            MDL_QTY = Convert.ToDecimal(row.Cells["MDL_QTY"].Value),
                            MDL_STATUS = 0
                        };

                        lines.Add(menuDayLine);
                    }

                    var result = _menuDayRepository.InsertLine(lines);

                    if (result > 0)
                    {
                        MessageBox.Show("Əməliyyat uğurla reallaşdı!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _menuDailyBrowser.GridLoad();

                        this.Hide();
                    }
                }
            }
            
            

        }

        private void ResetAllControl()
        {
            this.dgvMenuDayLine.Rows.Clear();

            txtMD_ID.Text = "0";
            cmbMDL_M_ID.SelectedIndex = -1;
            cmbMDL_UO_ID.SelectedIndex = -1;
            txtMDL_QTY.Text = "0";
        }

        private void txtMDL_QTY_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            int selectedIndex = this.dgvMenuDayLine.SelectedRows[0].Index;

            this.dgvMenuDayLine.Rows.RemoveAt(selectedIndex);
        }
    }
}
