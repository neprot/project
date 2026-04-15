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
    public partial class EditClient : Form
    {
        public int clientID;
        public EditClient()
        {
            InitializeComponent();
            this.FormClosed += EditClient_FormClosed;
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.atelierDataSet);

        }

        private void EditClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "atelierDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.atelierDataSet.clients);

            this.clientsBindingSource.Position = clientsBindingSource.Find("ID", Convert.ToInt32(clientID));

        }

        private void ApdateClient_Click(object sender, EventArgs e)
        {
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.atelierDataSet);
            new ClientForm().Show();
            this.Close();
        }

        private void DellClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                clientsBindingSource.RemoveAt(clientsBindingSource.Find("ID", Convert.ToInt32(clientID)));
                this.clientsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.atelierDataSet);
                new ClientForm().Show();
                this.Close();
            }
        }

        private void EditClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClientForm cf = new ClientForm();
            cf.Show();
        }


    }
}
