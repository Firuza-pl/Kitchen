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
using UNIKITCHEN.DBL.Repositories.Repository;

namespace UNIKITCHEN.WINFORM
{
    public partial class Login : Form
    {
        SystemRepository _systemRepository;
       
        public Login()
        {
            _systemRepository = new SystemRepository();
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLoginModel user = new UserLoginModel()
            {
                USERNAME = txtUsername.TextName.Trim(),
                PASSWORD = txtPassword.TextName.Trim() 
            };
            

            if (user.USERNAME == "" || user.PASSWORD == "")
            {
                lblErrorMessage.Text = "İstifadəçi adını və ya şifrəni daxil edin...";
            }
            else
            {
                var checkUser = _systemRepository.Login(user);

                if (checkUser != null)
                {
                    //int userID = checkUser.U_ID;
                    //string userName = checkUser.U_USERNAME;

                    LoginInfo.userID = checkUser.U_ID;
                    LoginInfo.userName = checkUser.U_USERNAME;

                    if (checkUser.U_TYPE == 1)
                    {
                        Kassa kassa = new Kassa();
                        kassa.Show();
                        lblErrorMessage.Text = "";
                        this.Hide();
                    }
                    else if (checkUser.U_TYPE==2)
                    {
                        FrmMain frmMain = new FrmMain();
                        frmMain.Show();
                        lblErrorMessage.Text = "";
                        this.Hide();
                    }
                }
                else
                {
                    lblErrorMessage.Text = "İstifadəçi adını və ya şifrəni düzgün daxil edin...";
                }
             }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
           // this.StartPosition = FormStartPosition.CenterParent;
        }

    }
}
