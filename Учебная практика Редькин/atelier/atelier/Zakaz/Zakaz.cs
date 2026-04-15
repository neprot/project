using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace atelier
{
    public partial class Zakaz : Form
    {

        public int editingOrderId;

        public Zakaz()
        {
            InitializeComponent();
            this.Activated += MainForm_Activated;
            zakaz_tableDataGridView.CellDoubleClick += zakaz_tableDataGridView_CellDoubleClick;
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.atelierDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "atelierDataSet.zakaz_table". При необходимости она может быть перемещена или удалена.
            this.zakaz_tableTableAdapter.Fill(this.atelierDataSet.zakaz_table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "atelierDataSet.orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.atelierDataSet.orders);

        }

        private void zakaz_tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.zakaz_tableTableAdapter.FillBy(this.atelierDataSet.zakaz_table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.zakaz_tableTableAdapter.FillBy1(this.atelierDataSet.zakaz_table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm frm = new ClientForm();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddZakaz frm = new AddZakaz();
            frm.Show();
        }


        private void MainForm_Activated(object sender, EventArgs e)
        {
            zakaz_tableTableAdapter.Fill(atelierDataSet.zakaz_table);
        }



        private void zakaz_tableDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = this.zakaz_tableDataGridView.CurrentCell.RowIndex;
            int orderId = Convert.ToInt32(this.zakaz_tableDataGridView[0, rowIndex].Value);
            MessageBox.Show(""+orderId);
            // Открываем форму AddZakaz для редактирования
            AddZakaz frm = new AddZakaz();
            frm.editingOrderId = orderId;
            frm.Show();
        }

        private void ExportWord_Click(object sender, EventArgs e)
        {
            // Начало таблицы
            string html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>";

            // Добавление строки заголовка
            html += "<tr>";
            foreach (DataGridViewColumn column in zakaz_tableDataGridView.Columns)
            {
                html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.HeaderText + "</th>";
            }
            html += "</tr>";

            //Добавление строк данных
            foreach (DataGridViewRow row in zakaz_tableDataGridView.Rows)
            {
                html += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    html += "<td style='border: 1px solid #ccc'>" + cell.FormattedValue.ToString() + "</td>";
                }
                html += "</tr>";
            }
            //Конец таблицы
            html += "</table>";
            string htmlFilePath = @"D:\Фильмы.htm";
            File.WriteAllText(htmlFilePath, html);

            //Преобразовываем HTML-файл в документ Word
            _Application word = new Microsoft.Office.Interop.Word.Application();
            _Document wordDoc = word.Documents.Open(FileName: htmlFilePath, ReadOnly: false);
            wordDoc.SaveAs(FileName: @"D:\Фильмы.doc", FileFormat: WdSaveFormat.wdFormatRTF);//Задаём название экспортируемого файла
            ((_Document)wordDoc).Close();
            ((_Application)word).Quit();
            //Удаляем HTML-файл
            File.Delete(htmlFilePath);
            //Сообщаем пользователю об успешном завершении экспорта
            if (MessageBox.Show("Файл успешно создан и сохранён по пути D:\\Фильмы.doc", "Экспорт выполнен!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start(@"D:\Фильмы.doc");
            }


        }
    }
}
