using System;
using System.Windows.Forms;


namespace Project
{
    public partial class LoginForm : UserControl
    {
        public static LoginForm login;
        public LoginForm()
        {
            login = this;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ตรวจสอบ user pass ตามต้องการ
            if (txtUser.Text == "admin" && txtPass.Text == "1234")
            {
                // ไปหน้า Main
                TestMain.FrmMain.ShowControl(new MainForm());
            }
            else
            {
                MessageBox.Show("Username / Password ไม่ถูกต้อง");
            }
        }

        
    }
}
