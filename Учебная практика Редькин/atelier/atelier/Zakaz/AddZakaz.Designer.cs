namespace atelier
{
    partial class AddZakaz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.comboFabric = new System.Windows.Forms.ComboBox();
            this.comboTailor = new System.Windows.Forms.ComboBox();
            this.atelierDataSet = new atelier.atelierDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new atelier.atelierDataSetTableAdapters.clientsTableAdapter();
            this.tableAdapterManager = new atelier.atelierDataSetTableAdapters.TableAdapterManager();
            this.fabricsTableAdapter = new atelier.atelierDataSetTableAdapters.fabricsTableAdapter();
            this.modelsTableAdapter = new atelier.atelierDataSetTableAdapters.modelsTableAdapter();
            this.ordersTableAdapter = new atelier.atelierDataSetTableAdapters.ordersTableAdapter();
            this.tailorsTableAdapter = new atelier.atelierDataSetTableAdapters.tailorsTableAdapter();
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fabricsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tailorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.dateFitting = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ZakazInfo = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.atelierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailorsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboClient
            // 
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(19, 37);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(198, 21);
            this.comboClient.TabIndex = 0;
            // 
            // comboModel
            // 
            this.comboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(19, 47);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(198, 177);
            this.comboModel.TabIndex = 0;
            // 
            // comboFabric
            // 
            this.comboFabric.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboFabric.FormattingEnabled = true;
            this.comboFabric.Location = new System.Drawing.Point(283, 48);
            this.comboFabric.Name = "comboFabric";
            this.comboFabric.Size = new System.Drawing.Size(198, 177);
            this.comboFabric.TabIndex = 0;
            // 
            // comboTailor
            // 
            this.comboTailor.FormattingEnabled = true;
            this.comboTailor.Location = new System.Drawing.Point(29, 46);
            this.comboTailor.Name = "comboTailor";
            this.comboTailor.Size = new System.Drawing.Size(198, 21);
            this.comboTailor.TabIndex = 0;
            // 
            // atelierDataSet
            // 
            this.atelierDataSet.DataSetName = "atelierDataSet";
            this.atelierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.atelierDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.fabricsTableAdapter = this.fabricsTableAdapter;
            this.tableAdapterManager.modelsTableAdapter = this.modelsTableAdapter;
            this.tableAdapterManager.ordersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.tailorsTableAdapter = this.tailorsTableAdapter;
            this.tableAdapterManager.UpdateOrder = atelier.atelierDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fabricsTableAdapter
            // 
            this.fabricsTableAdapter.ClearBeforeFill = true;
            // 
            // modelsTableAdapter
            // 
            this.modelsTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tailorsTableAdapter
            // 
            this.tailorsTableAdapter.ClearBeforeFill = true;
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataMember = "models";
            this.modelsBindingSource.DataSource = this.atelierDataSet;
            // 
            // fabricsBindingSource
            // 
            this.fabricsBindingSource.DataMember = "fabrics";
            this.fabricsBindingSource.DataSource = this.atelierDataSet;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.atelierDataSet;
            // 
            // tailorsBindingSource
            // 
            this.tailorsBindingSource.DataMember = "tailors";
            this.tailorsBindingSource.DataSource = this.atelierDataSet;
            // 
            // dateOrder
            // 
            this.dateOrder.Location = new System.Drawing.Point(27, 126);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.Size = new System.Drawing.Size(200, 20);
            this.dateOrder.TabIndex = 1;
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(600, 445);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(209, 23);
            this.btnSaveOrder.TabIndex = 2;
            this.btnSaveOrder.Text = "Сохранить заказ";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // dateFitting
            // 
            this.dateFitting.Location = new System.Drawing.Point(27, 181);
            this.dateFitting.Name = "dateFitting";
            this.dateFitting.Size = new System.Drawing.Size(200, 20);
            this.dateFitting.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboClient);
            this.groupBox1.Location = new System.Drawing.Point(24, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 137);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиент";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboModel);
            this.groupBox2.Controls.Add(this.comboFabric);
            this.groupBox2.Location = new System.Drawing.Point(24, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 269);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Заказ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ткань";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Модель";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dateOrder);
            this.groupBox3.Controls.Add(this.dateFitting);
            this.groupBox3.Controls.Add(this.comboTailor);
            this.groupBox3.Location = new System.Drawing.Point(571, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 224);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Мастер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата примерки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Закройщик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата заказа";
            // 
            // ZakazInfo
            // 
            this.ZakazInfo.AutoSize = true;
            this.ZakazInfo.Location = new System.Drawing.Point(6, 25);
            this.ZakazInfo.Name = "ZakazInfo";
            this.ZakazInfo.Size = new System.Drawing.Size(65, 13);
            this.ZakazInfo.TabIndex = 4;
            this.ZakazInfo.Text = "Закройщик";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ZakazInfo);
            this.groupBox4.Location = new System.Drawing.Point(307, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(543, 137);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Информация о заказе";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить клиета";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddZakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 521);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveOrder);
            this.Name = "AddZakaz";
            this.Text = "AddZakaz";
            this.Load += new System.EventHandler(this.AddZakaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atelierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailorsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboClient;
        private System.Windows.Forms.ComboBox comboModel;
        private System.Windows.Forms.ComboBox comboFabric;
        private System.Windows.Forms.ComboBox comboTailor;
        private atelierDataSet atelierDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private atelierDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private atelierDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private atelierDataSetTableAdapters.modelsTableAdapter modelsTableAdapter;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private atelierDataSetTableAdapters.fabricsTableAdapter fabricsTableAdapter;
        private System.Windows.Forms.BindingSource fabricsBindingSource;
        private atelierDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private atelierDataSetTableAdapters.tailorsTableAdapter tailorsTableAdapter;
        private System.Windows.Forms.BindingSource tailorsBindingSource;
        private System.Windows.Forms.DateTimePicker dateOrder;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.DateTimePicker dateFitting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ZakazInfo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
    }
}