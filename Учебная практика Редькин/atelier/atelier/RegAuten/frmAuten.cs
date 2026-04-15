using atelier;
using proektCrypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmAuten : Form
    {
        public frmAuten()
        {
            InitializeComponent();
            txtLogin.Text = "админ";
            txtPassword.Text = "1";
        }

        private void frmAuten_Load(object sender, EventArgs e)
        {
            this.registerTableAdapter.Fill(this.atelierDataSet.register);
            txtPassword.UseSystemPasswordChar = true;

        }

        private Boolean checkuser()
        {
            if (registerBindingSource.Count == 0)
            {
                MessageBox.Show("Такого аккаунта не существует!");
                return true;
            }
            else return false;
        }

        private void linkLbRegistr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmRegAuten().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var letLogin = txtLogin.Text;
            var letPassword = md5.hashPassword(txtPassword.Text);

            registerBindingSource.Filter = $"login_user like '{letLogin}' and password_user like '{letPassword}'";

            if (checkuser()) return;

            if (Convert.ToString(((DataRowView)registerBindingSource.Current).Row["login_user"]) == letLogin &&
                Convert.ToString(((DataRowView)registerBindingSource.Current).Row["password_user"]) == letPassword)
            {
                MessageBox.Show("Вы успешно вошли!");
                new Zakaz().Show();
                this.Hide();
            }
        }

        private void registerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.atelierDataSet);

        }

        private void frmAuten_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "atelierDataSet.register". При необходимости она может быть перемещена или удалена.
            this.registerTableAdapter.Fill(this.atelierDataSet.register);

        }

        private void registerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.registerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.atelierDataSet);

        }

        private void frmAuten_Load_2(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "atelierDataSet.register". При необходимости она может быть перемещена или удалена.
            this.registerTableAdapter.Fill(this.atelierDataSet.register);

        }

    }
}
