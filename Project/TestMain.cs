using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms;

namespace Project
{
    public partial class TestMain : Form
    {
        private static Panel panelShow;
        private static TestMain frmMain;

        public TestMain()
        {
            InitializeComponent();
            frmMain = this;
            panelShow = panel1;   // panel1 ต้องมีใน Form Designer
        }

        public static Panel PanelShow { get => panelShow; }
        public static TestMain FrmMain { get => frmMain; }

        public void ShowControl(UserControl control)
        {
            PanelShow.Controls.Clear();
            control.Dock = DockStyle.Fill;
            PanelShow.Controls.Add(control);
        }

        private void TestMain_Load(object sender, EventArgs e)
        {
            ShowControl(new LoginForm());
        }
    }
}