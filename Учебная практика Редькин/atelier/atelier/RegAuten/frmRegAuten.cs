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
    public partial class frmRegAuten : Form
    {
        public frmRegAuten()
        {
            InitializeComponent();
        }

        private void frmRegAuten_Load(object sender, EventArgs e)
        {
            this.registerTableAdapter.Fill(this.atelierDataSet.register);
            txtPassword.UseSystemPasswordChar = true;
            registerBindingSource.AddNew();

        }

        private Boolean checkuser()
        {
            var letLogin = txtLogin.Text;
            registerBindingSource.Filter = $"login_user Like '{letLogin}'";
            if (registerBindingSource.Count > 0)
            {
                MessageBox.Show("Такой аккаунт уже существует!");
                return true;
            }
            else return false;
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {

            var letLogin = txtLogin.Text;
            var letPassword = md5.hashPassword(txtPassword.Text);

            if (string.IsNullOrWhiteSpace(letLogin) || string.IsNullOrWhiteSpace(letPassword))
            {
                MessageBox.Show("Укажите логин и пароль!");
                return;
            }

            if (checkuser()) return;

            try
            {

                DataRow newRow = atelierDataSet.register.NewRow();
                newRow["login_user"] = letLogin;
                newRow["password_user"] = letPassword;
                atelierDataSet.register.Rows.Add(newRow);

                this.registerTableAdapter.Update(atelierDataSet.register);

                MessageBox.Show("Вы успешно зарегистрировались!");
                new frmAuten().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }

        }


        private void frmRegAuten_Load_1(object sender, EventArgs e)
        {

            this.registerTableAdapter.Fill(this.atelierDataSet.register);

        }




    }
}
