using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atelier
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
            this.FormClosed += AddClient_FormClosed;
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.atelierDataSet);

        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "atelierDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.atelierDataSet.clients);
            clientsBindingSource.AddNew();



        }

        private void AddNewClient_Click(object sender, EventArgs e)
        {
            clientsBindingSource.AddNew();
        }

        private void SaveNewClient_Click(object sender, EventArgs e)
        {
            this.clientsBindingSource.EndEdit(); // Завершаем редактирование объекта BindingSource
            this.tableAdapterManager.UpdateAll(this.atelierDataSet); // Обновляем данные DataSet через менеджер адаптера таблиц
            new ClientForm().Show(); // Открываем форму Актеры
            this.Close(); // Закрываем текущую форму
        }

        private void AddClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClientForm cf = new ClientForm();
            cf.Show();
        }

    }
}
