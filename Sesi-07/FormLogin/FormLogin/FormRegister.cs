using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class FormRegister : Form
    {
        Config db = new Config();
        public FormRegister()
        {
            InitializeComponent();

            db.Connect("userdata");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbUsername.Text) || String.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Please input name, username, and password!");
            }
            else
            {
                db.Execute("INSERT INTO user_info (names, username, password) VALUES ('" + tbName.Text + "', '" + tbUsername.Text + "', '" + tbPassword.Text + "')");
                MessageBox.Show("Registration success!");
                this.Close();
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
