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
    public partial class Company : Form
    {
        FirmRepository _firmRepository;
        EmployeeRepository _employeeRepository;
        Kassa _kassa;
        public Company(Kassa kassa)
        {
            //,int firmID=-1,int employeeID=-1
            _firmRepository = new FirmRepository();
            _employeeRepository = new EmployeeRepository();

            InitializeComponent();

            LoadCombo();

            //cmbFirms.SelectedValue = firmID;
            //EmployeeFirmLoad(firmID);
            _kassa = kassa;


        }

        private void LoadCombo()
        {
            //Categories Load
            List<T_FIRMS> firms = _firmRepository.GetAll().ToList();
            cmbFirms.DisplayMember = "F_NAME";
            cmbFirms.ValueMember = "F_ID";
            cmbFirms.DataSource = firms;
            cmbFirms.SelectedIndex = -1;

            
        }

        private void cmbFirms_SelectedValueChanged(object sender, EventArgs e)
        {

            // int count = dataGridViewEmpleyees.Rows.Count;
            

            ComboBox cmbCompany = sender as ComboBox;

            int firmID = Convert.ToInt32(cmbCompany.SelectedValue);

            EmployeeFirmLoad(firmID);


        }

        private void EmployeeFirmLoad(int firmID)
        {
            var employees = _employeeRepository.GetEmployeeByFirm(firmID)
               .Select(s => new {
                   E_ID = s.E_ID,
                   E_NAME = s.E_NAME,
                   E_SNAME = s.E_SNAME,
                   E_STATUS = (s.E_STATUS == 0 ? "Aktiv" : "Passiv")
               }).ToList();

            if (employees.Count > 0)
            {
                dataGridViewEmpleyees.DataSource = employees;
            }

        }

        private void dataGridViewEmpleyees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string selectedEmployeeID = dataGridViewEmpleyees.CurrentRow.Cells["E_ID"].Value.ToString();
            string selectedFirmID = cmbFirms.SelectedValue.ToString();

            _kassa.SELECTED_EMPLOYEEID = int.Parse(selectedEmployeeID);
            _kassa.SELECTED_FIRMID = int.Parse(selectedFirmID);

            this.Hide();
        }

        private void dataGridViewEmpleyees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Company_Load(object sender, EventArgs e)
        {


            //Reset DatagridView
            dataGridViewEmpleyees.DataSource = new List<T_EMPLOYEE>();

            dataGridViewEmpleyees.Columns["E_ID"].Visible = false;
            dataGridViewEmpleyees.Columns["E_F_ID"].Visible = false;
            dataGridViewEmpleyees.Columns["E_CODE"].Visible = false;

            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btnCompanySave_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleyees.CurrentRow==null)
            {
                MessageBox.Show("İşçı seçin!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string selectedEmployeeID = dataGridViewEmpleyees.CurrentRow.Cells["E_ID"].Value.ToString();
                string selectedFirmID = cmbFirms.SelectedValue.ToString();

                _kassa.SELECTED_EMPLOYEEID = int.Parse(selectedEmployeeID);
                _kassa.SELECTED_FIRMID = int.Parse(selectedFirmID);

                this.Hide();
            }

           
        }
    }
}
