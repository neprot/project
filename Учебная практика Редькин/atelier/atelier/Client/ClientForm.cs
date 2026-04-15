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
    public partial class ClientForm : Form
    {
        public int clientID;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.atelierDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "atelierDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.atelierDataSet.clients);

        }

        private void AddCliendButton_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.Show();
            this.Close();
        }


        private void clientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = this.clientsDataGridView.CurrentCell.RowIndex;
            int clientID = Convert.ToInt32(this.clientsDataGridView[0, rowIndex].Value);
            EditClient EditClient = new EditClient();
            EditClient.clientID = clientID;
            EditClient.Show();
            this.Close();
        }
    }
}
