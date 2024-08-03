using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using UNIKITCHEN.DBL.Repositories.Repository;
using UNIKITCHEN.DBL.EntityFramework;
using UNIKITCHEN.DBL.Entity;

namespace UNIKITCHEN.WINFORM
{
    public partial class Kassa : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeft,
        int nTop,
        int nRight,
        int nBottom,
        int nWidthEllipse,
        int nHeightEllipse
            );
        //  int top_btn = 40;
        int left_btn = 50;
        //  int top_text = 13;
        int left_text = 20;


        CategoriRepository _categoryRepository;
        OperationRepository _operationRepository;
        SpecodeRepository _specodeRepository;
        MealRepository _mealRepository;
        MealPriceRepository _mealPriceRepository;
        AppendixRepository _appendixRepository;
        //public static int userID;
        //public static string userName;

        //public static int selectedEmployeeID;
        //public static int selectedFirmID;

        public bool  IS_BISNEESLUNCH { get; set; }
        public int SELECTED_EMPLOYEEID { get; set; }
        public int SELECTED_FIRMID { get; set; }
        public DataGridView SHOPBASKET
        {
            get
            {
                return this.dataGridViewBasket;
            }
            set
            {
                this.dataGridViewBasket = value;
            }
        }
      
        public Kassa(int oprID = 0)
        {
            _operationRepository = new OperationRepository();
            _categoryRepository = new CategoriRepository();
            _operationRepository = new OperationRepository();
            _specodeRepository = new SpecodeRepository();
            _mealRepository = new MealRepository();
            _mealPriceRepository = new MealPriceRepository();
            _appendixRepository = new AppendixRepository();

            InitializeComponent();
            LoadCombo();

            lblUserName.Text = LoginInfo.userName.ToUpper();

            if (oprID > 0)
            {
                T_OPERATION operation = _operationRepository.GetById(oprID);

                txtOprID.Text = operation.OPR_ID.ToString();
                SELECTED_FIRMID = operation.OPR_F_ID ?? 0;
                SELECTED_EMPLOYEEID = operation.OPR_E_ID ?? 0;
                lblBasketTotal.Text = operation.OPR_TOTAL.ToString();

                var operationLine = _operationRepository
                    .getByIdForLine(operation.OPR_ID)
                    .Select(s => new
                    {
                        M_ID = s.OPRL_M_ID ?? 0,
                        M_NAME = _mealRepository.GetById(s.OPRL_M_ID ?? 0).M_NAME,
                        M_PRICE = s.OPRL_PRICE ?? 0,
                        M_QTY = s.OPRL_QTY ?? 0,
                        M_TOTAL = s.OPRL_TOTAL ?? 0,
                        M_CAT_ID = _mealRepository.GetById(s.OPRL_M_ID??0).M_CAT_ID??0
                    }).ToList();

                foreach (var item in operationLine)
                {
                  
                    dataGridViewBasket.Rows.Add(item.M_ID, item.M_NAME, item.M_PRICE, item.M_QTY, item.M_TOTAL,item.M_CAT_ID);
                }

                btnCancel.Visible = true;
                btnGiveBack.Visible = true;
                pictureBoxCancel.Visible = true;
                pictureBoxGiveBack.Visible = true;
                //dataGridViewBasket.DataSource = operationLine;
            }
            else
            {
                btnCancel.Visible = false;
                btnGiveBack.Visible = false;
                pictureBoxCancel.Visible = false;
                pictureBoxGiveBack.Visible = false;
            }
        }
        private void Kassa_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            //this.FormBorderStyle = FormBorderStyle.None;

           this.WindowState = FormWindowState.Maximized;
            //lblUserName.Text = "deneme";
            this.StartPosition = FormStartPosition.CenterScreen;


            Timer MyTimer = new Timer();
            MyTimer.Interval = (1000); // 45 mins
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();

            IS_BISNEESLUNCH = false;

            foreach (DataGridViewRow row in this.dataGridViewBasket.Rows)
            {
                int m_id = Convert.ToInt32(row.Cells["M_ID"].Value);

                if (m_id == 1)
                {
                    IS_BISNEESLUNCH = true;

                    btnBisnessLunch.BackColor = Color.Green;
                    btnBisnessLunch.ForeColor = Color.White;

                }
               
            }


            
        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            toolStripStatusLabel1.ForeColor = Color.Maroon;
        }



        //private void Button23_Click(object sender, EventArgs e)
        //{
        //    Company frmOutly = new Company();
        //    //  frmOutly.Show();
        //    frmOutly.StartPosition = FormStartPosition.CenterParent;
        //    frmOutly.ShowDialog(this);
        //}

        private void LoadCombo()
        {

            //Categories Load
            List<T_CATEGORY> categories = _categoryRepository.GetAll()
                .Concat(
                    _specodeRepository.GetAllByType("MENU_TYPE").Select(s => new T_CATEGORY { CAT_ID = s.SC_ID, CAT_NAME = s.SC_NAME }
                    )
               ).ToList();
            categories.Reverse();

            cmbCategory.DisplayMember = "CAT_NAME";
            cmbCategory.ValueMember = "CAT_ID";

            cmbCategory.DataSource = categories;

            cmbCategory.SelectedIndex = -1;

        }

        private void cmbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cmbCategory = sender as ComboBox;

            int CategoryID = Convert.ToInt32(cmbCategory.SelectedValue);

            GenerateMenus(CategoryID);

        }

        private void GenerateMenus(int CategoryID)
        {
            flowLayoutPanel1.Controls.Clear();


            if (CategoryID == 1)
            {
                var cetegoriesDaily = getMenusDaily(CategoryID).ToList()
                .GroupBy(g => new { CATEGORY_ID = g.CAT_ID, CATEGORY_NAME = g.CAT_NAME,CATEGORY_IMG = g.CAT_IMG })
                .Select(s => new { CAT_ID = s.Key.CATEGORY_ID, CAT_NAME = s.Key.CATEGORY_NAME,CAT_IMG = s.Key.CATEGORY_IMG });


                int i = 0;
                foreach (var item in cetegoriesDaily)
                {
                    //Menu Header Label
                    Panel panel = new Panel();

                    PictureBox pictureBox = new PictureBox();
                  //  pictureBox.Image = Image.FromFile(item.CAT_IMG);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Width = 20;
                    pictureBox.Height = 20;

                    Label label = new Label();
                    label.Text = item.CAT_NAME;

                    //label.Top = top_text;
                    label.ForeColor = Color.Maroon;
                    
                    label.Left = left_text;
                    label.Font = new Font("Lucida Calligraphy", 11.75F, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));

                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(label);
                    //     panel.Location = new Point(10, i * 100);
                    panel.Size = new Size(800, 20);

                    flowLayoutPanel1.Controls.Add(panel);

                    FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();

                    var menus = getMenusDaily(item.CAT_ID);

                    foreach (var btnItem in menus)
                    {
                        Button menu = new Button();
                        menu.Text = btnItem.M_NAME;
                        menu.Name = "btn" + btnItem.M_NAME;
                        menu.Tag = btnItem.M_ID;

                        menu.Left = left_btn;
                        //   menu.Top = top_btn;
                        menu.Size = new Size(138, 47);
                        menu.ForeColor = Color.White;
                        menu.BackColor = Color.Maroon;
                        menu.FlatStyle = FlatStyle.Flat;
                        menu.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                        menu.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, menu.Width, menu.Height, 50, 50));
                        menu.Size = new Size(138, 47);
                        menu.TextAlign = ContentAlignment.MiddleCenter;

                        menu.Click += new EventHandler(addShopBox);
                        flowLayoutPanel.Controls.Add(menu);
                    }

                    // flowLayoutPanel.Location = new Point(10, ++i * 100);
                    flowLayoutPanel.Size = new Size(800, 130);

                    flowLayoutPanel1.Controls.Add(flowLayoutPanel);

                    i++;
                }

            }
            else
            {
                var cetegories = getMenus(CategoryID).ToList()
                .GroupBy(g => new { CATEGORY_ID = g.CAT_ID, CATEGORY_NAME = g.CAT_NAME, CATEGORY_IMG = g.CAT_IMG })
                .Select(s => new { CAT_ID = s.Key.CATEGORY_ID, CAT_NAME = s.Key.CATEGORY_NAME, CAT_IMG = s.Key.CATEGORY_IMG });


                int i = 0;
                foreach (var item in cetegories)
                {
                    //Menu Header Label
                    Panel panel = new Panel();

                    PictureBox pictureBox = new PictureBox();
                 //   pictureBox.Image = Image.FromFile(item.CAT_IMG);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Width = 20;
                    pictureBox.Height = 20;

                    Label label = new Label();
                    label.Text = item.CAT_NAME;

                    //label.Top = top_text;
                    label.ForeColor = Color.Maroon;
                    label.Left = left_text;
                    label.Font = new Font("Lucida Calligraphy", 11.75F, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));

                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(label);
                    //    panel.Location = new Point(10, i * 100);
                    panel.Size = new Size(800, 20);

                    flowLayoutPanel1.Controls.Add(panel);

                    FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();

                    var menus = getMenus(item.CAT_ID);

                    foreach (var btnItem in menus)
                    {
                        Button menu = new Button();
                        menu.Text = btnItem.M_NAME;
                        menu.Name = "btn" + btnItem.M_NAME;
                        menu.Tag = btnItem.M_ID;

                        menu.Left = left_btn;
                        //   menu.Top = top_btn;
                        menu.Size = new Size(138, 47);
                        menu.ForeColor = Color.White;
                        menu.BackColor = Color.Maroon;
                        menu.FlatStyle = FlatStyle.Flat;
                        menu.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                        menu.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, menu.Width, menu.Height, 50, 50));
                        menu.Size = new Size(138, 47);
                        menu.TextAlign = ContentAlignment.MiddleCenter;

                        menu.Click += new EventHandler(addShopBox);
                        flowLayoutPanel.Controls.Add(menu);
                    }

                    //        flowLayoutPanel.Location = new Point(10, ++i * 100);
                    flowLayoutPanel.Size = new Size(800, 130);

                    flowLayoutPanel1.Controls.Add(flowLayoutPanel);

                    i++;
                }
            }

        }


        private void addShopBox(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            int MealID = Convert.ToInt32(btn.Tag);
            string MealName = btn.Text;
            int MealCategory = _mealRepository.GetById(MealID).M_CAT_ID ?? 0;

            double MealPrice=0;

//if (checkBisnessLunch(MealID))
         //   {
                if (IS_BISNEESLUNCH == false)
                {
                    T_MEALPRICE mealPrice = _mealPriceRepository.GetMealPrice(MealID);
                    if (mealPrice!=null)
                    {
                        MealPrice = mealPrice.MP_AMOUNT??0;
                    }
                    else
                    {
                        MealPrice = 0;
                    }
                }
                else
                {
                    var appendix = _appendixRepository.GetBisnessLunch(SELECTED_FIRMID);

                    if (appendix != null)
                    {
                        if (MealID == 1)
                        {
                            MealPrice = appendix.A_PRICE ?? 0;

                        }
                        else
                        {
                            MealPrice = 0;
                        }
                    }
                    else
                    {
                        MealPrice = 0;
                    }
                }

                if (this.dataGridViewBasket.Rows.Count == 0)
                {

                    //dataGridViewBasket.DataSource = new List<ShopBasket>();
                    //dataGridViewBasket.Columns["M_ID"].Visible = false;

                    this.dataGridViewBasket.Rows.Add(MealID, MealName, MealPrice, 1, MealPrice * 1, MealCategory);

                }
                else
                {
                    bool isFinded = false;
                    int rowIndex = 0;

                    foreach (DataGridViewRow row in this.dataGridViewBasket.Rows)
                    {
                        //string deneme = row.Cells[0].Value.ToString();

                        if (row.Cells["M_ID"].Value.ToString() == MealID.ToString())
                        {
                            isFinded = true;

                            break;
                        }
                        rowIndex++;
                    }


                    if (isFinded == true)
                    {
                        this.dataGridViewBasket.Rows[rowIndex].Cells["M_QTY"].Value = Convert.ToInt32(this.dataGridViewBasket.Rows[rowIndex].Cells["M_QTY"].Value) + 1;
                        this.dataGridViewBasket.Rows[rowIndex].Cells["M_TOTAL"].Value = Convert.ToDecimal(this.dataGridViewBasket.Rows[rowIndex].Cells["M_PRICE"].Value) * Convert.ToDecimal(this.dataGridViewBasket.Rows[rowIndex].Cells["M_QTY"].Value);
                    }
                    else
                    {
                        this.dataGridViewBasket.Rows.Add(MealID, MealName, MealPrice, 1, MealPrice * 1, MealCategory);
                    }
                }

                //return
                lblBasketTotal.Text = String.Format("{0:f2}", Convert.ToDouble(calculateTotal()).ToString(",0.00"));

          //  }
            //else
            //{
            //    MessageBox.Show("Bizness lunch oldugu ucun her yemekden bir eded daxil edin!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}




        }

        private List<SP_GETMENUS_Result> getMenus(int CAT_ID = 1)
        {

            List<SP_GETMENUS_Result> listMenus = _operationRepository.GetMenusByCat(CAT_ID).ToList();

            return listMenus;
        }

        private List<SP_GETMENUSDAILY_Result> getMenusDaily(int CAT_ID = 1)
        {

            List<SP_GETMENUSDAILY_Result> listMenus = _operationRepository.GetMenusDaily(CAT_ID).ToList();

            return listMenus;
        }

        public double calculateTotal()
        {
            double sum = 0; //Double, because we are dealing with money, which is a decimal

            for (int i = 0; i < this.dataGridViewBasket.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridViewBasket.Rows[i].Cells["M_TOTAL"].Value); //This takes the value of your selected cell within your ingredients datagrid (they need to be only numbers, no letters since we're converting to a double)
            }

            return sum;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            string textSearch = textBox.Text;

            flowLayoutPanel1.Controls.Clear();


            var menus = _mealRepository.SearchMeal(textSearch).ToList();

            Panel panel = new Panel();

            Label label = new Label();
            label.Text = "Axtarış nəticəsi...";

            //label.Top = top_text;
            label.ForeColor = Color.Maroon;
            label.Left = left_text;
            label.Font = new Font("Lucida Calligraphy", 11.75F, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
            label.Size = new Size(800, 40);

            panel.Controls.Add(label);
            //     panel.Location = new Point(10, i * 100);
            panel.Size = new Size(800, 40);

            flowLayoutPanel1.Controls.Add(panel);

            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();

            foreach (var btnItem in menus)
            {
                Button menu = new Button();
                menu.Text = btnItem.M_NAME;
                menu.Name = "btn" + btnItem.M_NAME;
                menu.Tag = btnItem.M_ID;

                menu.Left = left_btn;
                //   menu.Top = top_btn;
                menu.Size = new Size(138, 47);
                menu.ForeColor = Color.White;
                menu.BackColor = Color.Maroon;
                menu.FlatStyle = FlatStyle.Flat;
                menu.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                menu.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, menu.Width, menu.Height, 50, 50));
                menu.Size = new Size(138, 47);
                menu.TextAlign = ContentAlignment.MiddleCenter;

                menu.Click += new EventHandler(addShopBox);
                flowLayoutPanel.Controls.Add(menu);
            }

            flowLayoutPanel.Size = new Size(800, 90);

            flowLayoutPanel1.Controls.Add(flowLayoutPanel);

        }



        private void resetAllControl()
        {
            txtOprID.Text = "0";
            SELECTED_FIRMID = 0;
            SELECTED_EMPLOYEEID = 0;
            flowLayoutPanel1.Controls.Clear();
            //cmbCategory.SelectedIndex = 0;

            int CategoryID = Convert.ToInt32(cmbCategory.SelectedValue);

            GenerateMenus(CategoryID);

            txtSearch.Text = "";

            dataGridViewBasket.Rows.Clear();
            lblBasketTotal.Text = String.Format("{0:f2}", Convert.ToDouble(calculateTotal()).ToString(",0.00"));


            Company company = new Company(this);

            company.dataGridViewEmpleyees.DataSource = new List<T_EMPLOYEE>();

            company.dataGridViewEmpleyees.Columns["E_ID"].Visible = false;
            company.dataGridViewEmpleyees.Columns["E_F_ID"].Visible = false;
            company.dataGridViewEmpleyees.Columns["E_CODE"].Visible = false;


            IS_BISNEESLUNCH = false;
            btnBisnessLunch.BackColor = Color.White;
            btnBisnessLunch.ForeColor = Color.Maroon;

        }

        private void OperationSave(int F_ID, int E_ID, short OPR_TYPE, short OPR_STYPE)
        {
            T_OPERATION operation = new T_OPERATION()
            {
                OPR_ID = Convert.ToInt32(txtOprID.Text == "" ? "0" : txtOprID.Text),
                OPR_NO = "OPR-" + _operationRepository.getMaxID(),
                OPR_TYPE = OPR_TYPE,
                OPR_STYPE = OPR_STYPE,
                OPR_DATE = DateTime.Now,
                OPR_F_ID = F_ID,
                OPR_E_ID = E_ID,
                OPR_STATUS = 0,
                OPR_BL = IS_BISNEESLUNCH,
                OPR_TOTAL = calculateTotal()
            };

            int OPR_ID;

            if (operation.OPR_ID == 0)
            {
                OPR_ID = _operationRepository.Insert(operation);
            }
            else
            {
                OPR_ID = _operationRepository.Update(operation);
            }

            if (OPR_ID > 0)
            {
                _operationRepository.DeleteLine(OPR_ID);

                foreach (DataGridViewRow row in this.dataGridViewBasket.Rows)
                {

                    T_OPERATIONLINE operationLine = new T_OPERATIONLINE()
                    {
                        ORRL_OPR_ID = OPR_ID,
                        OPRL_M_ID = Convert.ToInt32(row.Cells["M_ID"].Value),
                        OPRL_UOM_ID = _mealRepository.GetById(Convert.ToInt32(row.Cells["M_ID"].Value)).M_OU_ID,
                        OPRL_PRICE = Convert.ToDouble(row.Cells["M_PRICE"].Value),
                        OPRL_QTY = Convert.ToDouble(row.Cells["M_QTY"].Value),
                        OPRL_TOTAL = Convert.ToDouble(row.Cells["M_TOTAL"].Value)
                    };


                    _operationRepository.InsertLine(operationLine);
                }

                resetAllControl();

                MessageBox.Show("Əməliyyat uğurla reallaşdı", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (dataGridViewBasket.Rows.Count == 0)
            {
                MessageBox.Show("Səbət boşdur", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Payment payment = new Payment(this);
                DialogResult dr = payment.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    OperationSave(SELECTED_FIRMID, SELECTED_EMPLOYEEID, 1, 1);
                    
                }
                
               
            }
        }

        private void btnPosterminal_Click(object sender, EventArgs e)
        {
            if (dataGridViewBasket.Rows.Count == 0)
            {
                MessageBox.Show("Səbət boşdur", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                OperationSave(SELECTED_FIRMID, SELECTED_EMPLOYEEID, 1, 2);
            }

        }


        private void btnDebit_Click(object sender, EventArgs e)
        {
            if (dataGridViewBasket.Rows.Count == 0)
            {
                MessageBox.Show("Səbət boşdur", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                OperationSave(SELECTED_FIRMID, SELECTED_EMPLOYEEID, 0, 3);
            }

        }

        private void btnGiveBack_Click(object sender, EventArgs e)
        {
            if (dataGridViewBasket.Rows.Count == 0)
            {
                MessageBox.Show("Səbət boşdur", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (Convert.ToInt32(txtOprID.Text) > 0)
                {
                    OperationSave(SELECTED_FIRMID, SELECTED_EMPLOYEEID, 3, 0);

                    this.Hide();

                    Browser browser = new Browser();
                    browser.Show();
                }
                else
                {
                    MessageBox.Show("Zəhmət olmasa bir satış seçin", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }


        private void btnFirmAdd_Click(object sender, EventArgs e)
        {
            Company frmOutly = new Company(this);
            //  frmOutly.Show();
            frmOutly.StartPosition = FormStartPosition.CenterParent;

            frmOutly.ShowDialog(this);
        }

        private void btnComeBack_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Geri qayıtmağa əminsiz??",
                                 "Təsdiq et!!",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmResult == DialogResult.Yes)
            {

                this.Hide();
                Browser browser = new Browser();
                browser.StartPosition = FormStartPosition.CenterParent;
                browser.ShowDialog(this);
            }




        }

      
        private void btLogOut_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Programdan çıxış etməyə əminsiz??",
                                    "Təsdiq et!!",
                                    MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (confirmResult == DialogResult.Yes)
            {
                this.Hide();

                Login loginForm = new Login();
                loginForm.StartPosition = FormStartPosition.CenterParent;
                loginForm.ShowDialog(this);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Ləğv etməyə əminsiz??",
                                 "Təsdiq et!!",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmResult == DialogResult.Yes)
            {

                if (Convert.ToInt32(txtOprID.Text) > 0)
                {
                    int oprID = Convert.ToInt32(txtOprID.Text);

                    bool result = _operationRepository.Delete(oprID);

                    if (result)
                    {
                        MessageBox.Show("Məlumat ləğv edildi", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();

                        Browser browser = new Browser();
                        browser.Show();
                    }
                    else
                    {
                        MessageBox.Show("Məlumat ləğv edilmədi", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("Zəhmət olmasa bir satış seçin", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }


            


        }

        private void btnShopboxEdit_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewBasket.CurrentRow!=null)
            {
                string M_ID = this.dataGridViewBasket.CurrentRow.Cells["M_ID"].Value.ToString();
                string M_NAME = this.dataGridViewBasket.CurrentRow.Cells["M_NAME"].Value.ToString();
                string M_PRICE = this.dataGridViewBasket.CurrentRow.Cells["M_PRICE"].Value.ToString();
                string M_QTY = this.dataGridViewBasket.CurrentRow.Cells["M_QTY"].Value.ToString();
                string M_TOTAL = this.dataGridViewBasket.CurrentRow.Cells["M_TOTAL"].Value.ToString();

                if (M_ID!="1")
                {
                    ShopboxEdit shopboxEdit = new ShopboxEdit(this);
                    //,M_ID, M_NAME, M_PRICE, M_QTY, M_TOTAL
                    shopboxEdit.StartPosition = FormStartPosition.CenterScreen;
                    shopboxEdit.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Bisness lunch'i dəyişdirə bilməzsiniz", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Səbətiniz boşdur", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public  void changeShobox(int M_ID, double M_QTY, double M_TOTAL)
        {

            foreach (DataGridViewRow row in this.dataGridViewBasket.Rows)
            {
                string m_id = row.Cells["M_ID"].Value.ToString();
            }
            // DataTable data = (DataTable)(dataGridViewBasket.DataSource);
        }

        private void btnBisnessLunch_Click(object sender, EventArgs e)
        {
            //if (ChekShopBoxForBisnessLunch())
            //{
                IS_BISNEESLUNCH = !IS_BISNEESLUNCH;

                //if (IS_BISNEESLUNCH)
                //{
                    btnBisnessLunch.BackColor = Color.Green;
                    btnBisnessLunch.ForeColor = Color.White;

                    double MealPrice;

                    if (SELECTED_FIRMID > 0)
                    {
                        T_APPENDIX appendix = _appendixRepository.GetBisnessLunch(SELECTED_FIRMID);

                        if (appendix != null)
                        {
                            MealPrice = _appendixRepository.GetBisnessLunch(SELECTED_FIRMID).A_PRICE ?? 0;
                        }
                        else
                        {
                            MealPrice = 5;
                        }

                    }
                    else
                    {
                        MealPrice = 5;
                    }

                    this.dataGridViewBasket.Rows.Insert(0, 1, "Bisness Lunch", MealPrice, 1, MealPrice * 1, 0);

                    if (this.dataGridViewBasket.Rows.Count > 1)
                    {

                        for (int k = 0; k < this.dataGridViewBasket.Rows.Count; k++)
                        {
                            DataGridViewRow row = this.dataGridViewBasket.Rows[k];

                            int m_id = Convert.ToInt32(row.Cells["M_ID"].Value);

                            if (m_id != 1)
                            {
                                this.dataGridViewBasket.Rows[k].Cells["M_PRICE"].Value = 0;
                                this.dataGridViewBasket.Rows[k].Cells["M_TOTAL"].Value = 0 * Convert.ToDouble(this.dataGridViewBasket.Rows[k].Cells["M_QTY"].Value);

                            }


                        }
                    }

               // }
                //else
                //{
                //    btnBisnessLunch.BackColor = Color.White;
                //    btnBisnessLunch.ForeColor = Color.Maroon;


                //    bool chekBisnessRemove = false;

                //    for (int i = 0; i < this.dataGridViewBasket.Rows.Count; i++)
                //    {
                //        var row = this.dataGridViewBasket.Rows[i];

                //        int m_id = Convert.ToInt32(row.Cells["M_ID"].Value);
                //        if (m_id == 1)
                //        {
                //            this.dataGridViewBasket.Rows.Remove(row);
                //            chekBisnessRemove = true;
                //        }

                //        i++;
                //    }

                //    if (chekBisnessRemove)
                //    {

                //        int k = 0;
                //        foreach (DataGridViewRow row in this.dataGridViewBasket.Rows)
                //        {
                //            int m_id = Convert.ToInt32(row.Cells["M_ID"].Value);
                //            string m_price = this.dataGridViewBasket.Rows[k].Cells["M_PRICE"].Value.ToString();
                //            string m_qty = this.dataGridViewBasket.Rows[k].Cells["M_QTY"].Value.ToString();

                //            T_MEALPRICE mealPrice = _mealPriceRepository.GetMealPrice(m_id);

                //            this.dataGridViewBasket.Rows[k].Cells["M_PRICE"].Value = mealPrice != null ? mealPrice.MP_AMOUNT : 0;
                //            this.dataGridViewBasket.Rows[k].Cells["M_TOTAL"].Value = Convert.ToDouble(m_price) * Convert.ToDouble(m_qty);



                //            k++;
                //        }
                //    }
                //}

                lblBasketTotal.Text = String.Format("{0:f2}", Convert.ToDouble(calculateTotal()).ToString(",0.00"));
            //}
            //else
            //{
            //    MessageBox.Show("Səbətiniz bisness lunch menusun desteklemir", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }

        private bool checkBisnessLunch(int M_ID)
        {
            int CAT_ID = _mealRepository.GetById(M_ID).M_CAT_ID ?? 0;

            if (IS_BISNEESLUNCH)
            {
                foreach (DataGridViewRow row in this.dataGridViewBasket.Rows)
                {
                    if (Convert.ToInt32(row.Cells["M_CAT_ID"].Value) == CAT_ID)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        //private bool ChekShopBoxForBisnessLunch()
        //{
        //   // bool checkBisness = true;

        //    foreach (DataGridViewRow rowMain in this.dataGridViewBasket.Rows)
        //    {
        //        int CAT_ID = Convert.ToInt32(rowMain.Cells["M_CAT_ID"].Value);
        //        int M_QTY = Convert.ToInt32(rowMain.Cells["M_QTY"].Value);

        //        int count = 0;

        //        foreach (DataGridViewRow row in this.dataGridViewBasket.Rows)
        //        {
        //            if (Convert.ToInt32(row.Cells["M_CAT_ID"].Value) == CAT_ID)
        //            {
        //                //checkBisness = false;

        //                count = count + M_QTY;
        //            }
        //        }
        //        if (count>1 )
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        private void btnShopBasketDelete_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Silmək üçün əminsiz??",
                                "Təsdiq et!!",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmResult == DialogResult.Yes)
            {
                if (this.dataGridViewBasket.CurrentRow != null)
                {
                    string M_ID = this.dataGridViewBasket.CurrentRow.Cells["M_ID"].Value.ToString();

                    if (M_ID != "1")
                    {
                        foreach (DataGridViewRow row in this.dataGridViewBasket.Rows)
                        {
                            if (row.Cells["M_ID"].Value.ToString() == M_ID)
                            {
                                this.dataGridViewBasket.Rows.Remove(row);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bisness lunchı silə bilməzsiniz", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    this.lblBasketTotal.Text = String.Format("{0:f2}", Convert.ToDouble(calculateTotal()).ToString(",0.00"));


                }
                else
                {
                    MessageBox.Show("Səbətiniz boşdur", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
          
          
        }

        private void pictureBoxCancel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewBasket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnComeBack_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Maroon;
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
