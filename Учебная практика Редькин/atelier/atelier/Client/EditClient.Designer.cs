namespace atelier
{
    partial class EditClient
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
            this.ApdateClient = new System.Windows.Forms.Button();
            this.DellClient = new System.Windows.Forms.Button();
            full_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.atelierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // full_nameLabel
            // 
            full_nameLabel.AutoSize = true;
            full_nameLabel.Location = new System.Drawing.Point(216, 69);
            full_nameLabel.Name = "full_nameLabel";
            full_nameLabel.Size = new System.Drawing.Size(75, 13);
            full_nameLabel.TabIndex = 1;
            full_nameLabel.Text = "Фио Клиента";
            // 
            // full_nameTextBox
            // 
            this.full_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "full_name", true));
            this.full_nameTextBox.Location = new System.Drawing.Point(219, 94);
            this.full_nameTextBox.Name = "full_nameTextBox";
            this.full_nameTextBox.Size = new System.Drawing.Size(388, 20);
            this.full_nameTextBox.TabIndex = 2;
            // 
            // ApdateClient
            // 
            this.ApdateClient.Location = new System.Drawing.Point(216, 149);
            this.ApdateClient.Name = "ApdateClient";
            this.ApdateClient.Size = new System.Drawing.Size(194, 23);
            this.ApdateClient.TabIndex = 3;
            this.ApdateClient.Text = "Сохранить изменения";
            this.ApdateClient.UseVisualStyleBackColor = true;
            this.ApdateClient.Click += new System.EventHandler(this.ApdateClient_Click);
            // 
            // DellClient
            // 
            this.DellClient.Location = new System.Drawing.Point(416, 149);
            this.DellClient.Name = "DellClient";
            this.DellClient.Size = new System.Drawing.Size(191, 23);
            this.DellClient.TabIndex = 3;
            this.DellClient.Text = "Удалить клиента";
            this.DellClient.UseVisualStyleBackColor = true;
            this.DellClient.Click += new System.EventHandler(this.DellClient_Click);
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 341);
            this.Controls.Add(this.DellClient);
            this.Controls.Add(this.ApdateClient);
            this.Controls.Add(full_nameLabel);
            this.Controls.Add(this.full_nameTextBox);
            this.Name = "EditClient";
            this.Text = "EditClien";
            this.Load += new System.EventHandler(this.EditClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atelierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private atelierDataSet atelierDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private atelierDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private atelierDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox full_nameTextBox;
        private System.Windows.Forms.Button ApdateClient;
        private System.Windows.Forms.Button DellClient;
    }
}