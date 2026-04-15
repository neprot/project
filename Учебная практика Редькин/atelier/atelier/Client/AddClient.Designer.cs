namespace atelier
{
    partial class AddClient
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
            System.Windows.Forms.Label full_nameLabel;
            this.atelierDataSet = new atelier.atelierDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new atelier.atelierDataSetTableAdapters.clientsTableAdapter();
            this.tableAdapterManager = new atelier.atelierDataSetTableAdapters.TableAdapterManager();
            this.full_nameTextBox = new System.Windows.Forms.TextBox();
            this.AddNewClient = new System.Windows.Forms.Button();
            this.SaveNewClient = new System.Windows.Forms.Button();
            full_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.atelierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // full_nameLabel
            // 
            full_nameLabel.AutoSize = true;
            full_nameLabel.Location = new System.Drawing.Point(94, 52);
            full_nameLabel.Name = "full_nameLabel";
            full_nameLabel.Size = new System.Drawing.Size(81, 13);
            full_nameLabel.TabIndex = 2;
            full_nameLabel.Text = "ФИО клиента:";
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
            this.tableAdapterManager.fabricsTableAdapter = null;
            this.tableAdapterManager.modelsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.tailorsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = atelier.atelierDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // full_nameTextBox
            // 
            this.full_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "full_name", true));
            this.full_nameTextBox.Location = new System.Drawing.Point(97, 78);
            this.full_nameTextBox.Name = "full_nameTextBox";
            this.full_nameTextBox.Size = new System.Drawing.Size(271, 20);
            this.full_nameTextBox.TabIndex = 3;
            // 
            // AddNewClient
            // 
            this.AddNewClient.Location = new System.Drawing.Point(97, 136);
            this.AddNewClient.Name = "AddNewClient";
            this.AddNewClient.Size = new System.Drawing.Size(125, 23);
            this.AddNewClient.TabIndex = 4;
            this.AddNewClient.Text = "Добавить клиента";
            this.AddNewClient.UseVisualStyleBackColor = true;
            this.AddNewClient.Click += new System.EventHandler(this.AddNewClient_Click);
            // 
            // SaveNewClient
            // 
            this.SaveNewClient.Location = new System.Drawing.Point(242, 136);
            this.SaveNewClient.Name = "SaveNewClient";
            this.SaveNewClient.Size = new System.Drawing.Size(126, 23);
            this.SaveNewClient.TabIndex = 4;
            this.SaveNewClient.Text = "Сохранить клиента";
            this.SaveNewClient.UseVisualStyleBackColor = true;
            this.SaveNewClient.Click += new System.EventHandler(this.SaveNewClient_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 250);
            this.Controls.Add(this.SaveNewClient);
            this.Controls.Add(this.AddNewClient);
            this.Controls.Add(full_nameLabel);
            this.Controls.Add(this.full_nameTextBox);
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.Load += new System.EventHandler(this.AddClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atelierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private atelierDataSet atelierDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private atelierDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Button AddNewClient;
        private System.Windows.Forms.Button SaveNewClient;
        public atelierDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.TextBox full_nameTextBox;
    }
}