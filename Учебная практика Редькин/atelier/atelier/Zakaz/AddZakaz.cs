using atelier.atelierDataSetTableAdapters;
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
    public partial class AddZakaz : Form
    {
        public int editingOrderId;


        public AddZakaz(Zakaz form)
        {
            InitializeComponent();
        }

        public AddZakaz()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.atelierDataSet);

        }

        private void AddZakaz_Load(object sender, EventArgs e)
        {

            this.tailorsTableAdapter.Fill(this.atelierDataSet.tailors);
            this.ordersTableAdapter.Fill(this.atelierDataSet.orders);
            this.fabricsTableAdapter.Fill(this.atelierDataSet.fabrics);
            this.modelsTableAdapter.Fill(this.atelierDataSet.models);
            this.clientsTableAdapter.Fill(this.atelierDataSet.clients);

            // Клиенты
            comboClient.DataSource = clientsTableAdapter.GetData();
            comboClient.DisplayMember = "full_name";  // то, что видно
            comboClient.ValueMember = "id";           // то, что сохранится

            // Модели
            comboModel.DataSource = modelsTableAdapter.GetData();
            comboModel.DisplayMember = "name";
            comboModel.ValueMember = "id";

            // Ткани
            comboFabric.DataSource = fabricsTableAdapter.GetData();
            comboFabric.DisplayMember = "name";
            comboFabric.ValueMember = "id";

            // Закройщики
            comboTailor.DataSource = tailorsTableAdapter.GetData();
            comboTailor.DisplayMember = "full_name";
            comboTailor.ValueMember = "id";

            // Дата заказа по умолчанию
            dateOrder.Value = DateTime.Now;


            comboClient.SelectedIndexChanged += (s, a) => UpdateZakazInfo();
            comboModel.SelectedIndexChanged += (s, a) => UpdateZakazInfo();
            comboFabric.SelectedIndexChanged += (s, a) => UpdateZakazInfo();
            comboTailor.SelectedIndexChanged += (s, a) => UpdateZakazInfo();

            dateOrder.ValueChanged += (s, a) => UpdateZakazInfo();
            dateFitting.ValueChanged += (s, a) => UpdateZakazInfo();
            dateFitting.ValueChanged += (s, a) => UpdateZakazInfo();

            


            

            if (editingOrderId != null)
            {
                // Загружаем данные заказа из таблицы orders
                DataRow orderRow = atelierDataSet.orders.FindByid(editingOrderId);
                if (orderRow != null)
                {
                    comboClient.SelectedValue = orderRow["client_id"];
                    comboModel.SelectedValue = orderRow["model_id"];
                    comboFabric.SelectedValue = orderRow["fabric_id"];
                    comboTailor.SelectedValue = orderRow["tailor_id"];
                    dateOrder.Value = Convert.ToDateTime(orderRow["order_date"]);

                    if (orderRow["fitting_date"] != DBNull.Value)
                    {
                        dateFitting.Checked = true;
                        dateFitting.Value = Convert.ToDateTime(orderRow["fitting_date"]);
                    }
                    else
                    {
                        dateFitting.Checked = false;
                    }
                }
            }



            UpdateZakazInfo();
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int clientId = (int)comboClient.SelectedValue;
                int modelId = (int)comboModel.SelectedValue;
                int fabricId = (int)comboFabric.SelectedValue;
                int tailorId = (int)comboTailor.SelectedValue;

                DateTime orderDate = dateOrder.Value;
                DateTime fittingDate;

                if (dateFitting.Checked)
                    fittingDate = dateFitting.Value;
                else
                    fittingDate = new DateTime(1900, 1, 1);


                MessageBox.Show("" + editingOrderId);

                if (editingOrderId == null)
                {
                    // Новый заказ
                    ordersTableAdapter.Insert(clientId, modelId, fabricId, tailorId, orderDate, fittingDate, false, null);
                    MessageBox.Show("Заказ успешно добавлен!");
                }
                else
                {

                    // Обновление существующего
                    var row = atelierDataSet.orders.FindByid(editingOrderId);
                    row.client_id = clientId;
                    row.model_id = modelId;
                    row.fabric_id = fabricId;
                    row.tailor_id = tailorId;
                    row.order_date = orderDate;
                    ordersTableAdapter.Update(row);
                    MessageBox.Show("Заказ успешно сохранен!");
                }




                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }


        private void UpdateZakazInfo()
        {
            string client = comboClient.Text;
            string model = comboModel.Text;
            string fabric = comboFabric.Text;
            string tailor = comboTailor.Text;
            string orderDate = dateOrder.Value.ToShortDateString();
            string fittingDate = dateFitting.Checked
                ? dateFitting.Value.ToShortDateString()
                : "не назначена";

            ZakazInfo.Text =
                $"Клиент: {client}\n" +
                $"Модель: {model}\n" +
                $"Ткань: {fabric}\n" +
                $"Закройщик: {tailor}\n" +
                $"Дата заказа: {orderDate}\n" +
                $"Дата примерки: {fittingDate}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.Show();
        }

        private void AddZakaz_Activated(object sender, EventArgs e)
        {
            // Загружаем клиентов из базы
            this.clientsTableAdapter.Fill(this.atelierDataSet.clients);

            // Если нужно, сбрасываем выбор
            comboClient.SelectedIndex = -1;
        }









    }



}
