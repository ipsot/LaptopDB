namespace LaptopDB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idManufacturerLabel1;
            System.Windows.Forms.Label modelLabel1;
            System.Windows.Forms.Label coreCountLabel1;
            System.Windows.Forms.Label videoMemoryLabel1;
            System.Windows.Forms.Label rAMLabel1;
            System.Windows.Forms.Label hDDLabel1;
            System.Windows.Forms.Label sSDLabel1;
            System.Windows.Forms.Label priceLabel1;
            this.myLaptopDBDataSet = new LaptopDB.MyLaptopDBDataSet();
            this.manufacturerProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerProductTableAdapter = new LaptopDB.MyLaptopDBDataSetTableAdapters.ManufacturerProductTableAdapter();
            this.tableAdapterManager = new LaptopDB.MyLaptopDBDataSetTableAdapters.TableAdapterManager();
            this.laptopSpecificationsTableAdapter = new LaptopDB.MyLaptopDBDataSetTableAdapters.LaptopSpecificationsTableAdapter();
            this.manufacturerProductDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laptopSpecificationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laptopSpecificationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.idManufacturerTextBox1 = new System.Windows.Forms.TextBox();
            this.modelTextBox1 = new System.Windows.Forms.TextBox();
            this.coreCountTextBox1 = new System.Windows.Forms.TextBox();
            this.videoMemoryTextBox1 = new System.Windows.Forms.TextBox();
            this.rAMTextBox1 = new System.Windows.Forms.TextBox();
            this.hDDTextBox1 = new System.Windows.Forms.TextBox();
            this.sSDTextBox1 = new System.Windows.Forms.TextBox();
            this.priceTextBox1 = new System.Windows.Forms.TextBox();
            this.Updatebutton = new System.Windows.Forms.Button();
            idManufacturerLabel1 = new System.Windows.Forms.Label();
            modelLabel1 = new System.Windows.Forms.Label();
            coreCountLabel1 = new System.Windows.Forms.Label();
            videoMemoryLabel1 = new System.Windows.Forms.Label();
            rAMLabel1 = new System.Windows.Forms.Label();
            hDDLabel1 = new System.Windows.Forms.Label();
            sSDLabel1 = new System.Windows.Forms.Label();
            priceLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myLaptopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopSpecificationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopSpecificationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idManufacturerLabel1
            // 
            idManufacturerLabel1.AutoSize = true;
            idManufacturerLabel1.Location = new System.Drawing.Point(40, 282);
            idManufacturerLabel1.Name = "idManufacturerLabel1";
            idManufacturerLabel1.Size = new System.Drawing.Size(84, 13);
            idManufacturerLabel1.TabIndex = 26;
            idManufacturerLabel1.Text = "id Manufacturer:";
            // 
            // modelLabel1
            // 
            modelLabel1.AutoSize = true;
            modelLabel1.Location = new System.Drawing.Point(40, 308);
            modelLabel1.Name = "modelLabel1";
            modelLabel1.Size = new System.Drawing.Size(39, 13);
            modelLabel1.TabIndex = 28;
            modelLabel1.Text = "Model:";
            // 
            // coreCountLabel1
            // 
            coreCountLabel1.AutoSize = true;
            coreCountLabel1.Location = new System.Drawing.Point(40, 334);
            coreCountLabel1.Name = "coreCountLabel1";
            coreCountLabel1.Size = new System.Drawing.Size(63, 13);
            coreCountLabel1.TabIndex = 30;
            coreCountLabel1.Text = "Core Count:";
            // 
            // videoMemoryLabel1
            // 
            videoMemoryLabel1.AutoSize = true;
            videoMemoryLabel1.Location = new System.Drawing.Point(40, 360);
            videoMemoryLabel1.Name = "videoMemoryLabel1";
            videoMemoryLabel1.Size = new System.Drawing.Size(77, 13);
            videoMemoryLabel1.TabIndex = 32;
            videoMemoryLabel1.Text = "Video Memory:";
            // 
            // rAMLabel1
            // 
            rAMLabel1.AutoSize = true;
            rAMLabel1.Location = new System.Drawing.Point(40, 386);
            rAMLabel1.Name = "rAMLabel1";
            rAMLabel1.Size = new System.Drawing.Size(34, 13);
            rAMLabel1.TabIndex = 34;
            rAMLabel1.Text = "RAM:";
            // 
            // hDDLabel1
            // 
            hDDLabel1.AutoSize = true;
            hDDLabel1.Location = new System.Drawing.Point(40, 412);
            hDDLabel1.Name = "hDDLabel1";
            hDDLabel1.Size = new System.Drawing.Size(34, 13);
            hDDLabel1.TabIndex = 36;
            hDDLabel1.Text = "HDD:";
            // 
            // sSDLabel1
            // 
            sSDLabel1.AutoSize = true;
            sSDLabel1.Location = new System.Drawing.Point(40, 438);
            sSDLabel1.Name = "sSDLabel1";
            sSDLabel1.Size = new System.Drawing.Size(32, 13);
            sSDLabel1.TabIndex = 38;
            sSDLabel1.Text = "SSD:";
            // 
            // priceLabel1
            // 
            priceLabel1.AutoSize = true;
            priceLabel1.Location = new System.Drawing.Point(40, 464);
            priceLabel1.Name = "priceLabel1";
            priceLabel1.Size = new System.Drawing.Size(34, 13);
            priceLabel1.TabIndex = 40;
            priceLabel1.Text = "Price:";
            // 
            // myLaptopDBDataSet
            // 
            this.myLaptopDBDataSet.DataSetName = "MyLaptopDBDataSet";
            this.myLaptopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manufacturerProductBindingSource
            // 
            this.manufacturerProductBindingSource.DataMember = "ManufacturerProduct";
            this.manufacturerProductBindingSource.DataSource = this.myLaptopDBDataSet;
            // 
            // manufacturerProductTableAdapter
            // 
            this.manufacturerProductTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LaptopSpecificationsTableAdapter = this.laptopSpecificationsTableAdapter;
            this.tableAdapterManager.ManufacturerProductTableAdapter = this.manufacturerProductTableAdapter;
            this.tableAdapterManager.UpdateOrder = LaptopDB.MyLaptopDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // laptopSpecificationsTableAdapter
            // 
            this.laptopSpecificationsTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerProductDataGridView
            // 
            this.manufacturerProductDataGridView.AutoGenerateColumns = false;
            this.manufacturerProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manufacturerProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.manufacturerProductDataGridView.DataSource = this.manufacturerProductBindingSource;
            this.manufacturerProductDataGridView.Location = new System.Drawing.Point(12, 28);
            this.manufacturerProductDataGridView.Name = "manufacturerProductDataGridView";
            this.manufacturerProductDataGridView.Size = new System.Drawing.Size(244, 220);
            this.manufacturerProductDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Manufacturer";
            this.dataGridViewTextBoxColumn2.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // laptopSpecificationsBindingSource
            // 
            this.laptopSpecificationsBindingSource.DataMember = "FK_LaptopSpecifications_ManufacturerProduct";
            this.laptopSpecificationsBindingSource.DataSource = this.manufacturerProductBindingSource;
            // 
            // laptopSpecificationsDataGridView
            // 
            this.laptopSpecificationsDataGridView.AutoGenerateColumns = false;
            this.laptopSpecificationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laptopSpecificationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.laptopSpecificationsDataGridView.DataSource = this.laptopSpecificationsBindingSource;
            this.laptopSpecificationsDataGridView.Location = new System.Drawing.Point(358, 28);
            this.laptopSpecificationsDataGridView.Name = "laptopSpecificationsDataGridView";
            this.laptopSpecificationsDataGridView.Size = new System.Drawing.Size(944, 227);
            this.laptopSpecificationsDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn3.HeaderText = "id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idManufacturer";
            this.dataGridViewTextBoxColumn4.HeaderText = "idManufacturer";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn5.HeaderText = "Model";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CoreCount";
            this.dataGridViewTextBoxColumn6.HeaderText = "CoreCount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "VideoMemory";
            this.dataGridViewTextBoxColumn7.HeaderText = "VideoMemory";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RAM";
            this.dataGridViewTextBoxColumn8.HeaderText = "RAM";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "HDD";
            this.dataGridViewTextBoxColumn9.HeaderText = "HDD";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SSD";
            this.dataGridViewTextBoxColumn10.HeaderText = "SSD";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn11.HeaderText = "Price";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(370, 270);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(49, 493);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(130, 493);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // idManufacturerTextBox1
            // 
            this.idManufacturerTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laptopSpecificationsBindingSource, "idManufacturer", true));
            this.idManufacturerTextBox1.Location = new System.Drawing.Point(130, 279);
            this.idManufacturerTextBox1.Name = "idManufacturerTextBox1";
            this.idManufacturerTextBox1.Size = new System.Drawing.Size(100, 20);
            this.idManufacturerTextBox1.TabIndex = 27;
            // 
            // modelTextBox1
            // 
            this.modelTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laptopSpecificationsBindingSource, "Model", true));
            this.modelTextBox1.Location = new System.Drawing.Point(130, 305);
            this.modelTextBox1.Name = "modelTextBox1";
            this.modelTextBox1.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox1.TabIndex = 29;
            // 
            // coreCountTextBox1
            // 
            this.coreCountTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laptopSpecificationsBindingSource, "CoreCount", true));
            this.coreCountTextBox1.Location = new System.Drawing.Point(130, 331);
            this.coreCountTextBox1.Name = "coreCountTextBox1";
            this.coreCountTextBox1.Size = new System.Drawing.Size(100, 20);
            this.coreCountTextBox1.TabIndex = 31;
            // 
            // videoMemoryTextBox1
            // 
            this.videoMemoryTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laptopSpecificationsBindingSource, "VideoMemory", true));
            this.videoMemoryTextBox1.Location = new System.Drawing.Point(130, 357);
            this.videoMemoryTextBox1.Name = "videoMemoryTextBox1";
            this.videoMemoryTextBox1.Size = new System.Drawing.Size(100, 20);
            this.videoMemoryTextBox1.TabIndex = 33;
            // 
            // rAMTextBox1
            // 
            this.rAMTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laptopSpecificationsBindingSource, "RAM", true));
            this.rAMTextBox1.Location = new System.Drawing.Point(130, 383);
            this.rAMTextBox1.Name = "rAMTextBox1";
            this.rAMTextBox1.Size = new System.Drawing.Size(100, 20);
            this.rAMTextBox1.TabIndex = 35;
            // 
            // hDDTextBox1
            // 
            this.hDDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laptopSpecificationsBindingSource, "HDD", true));
            this.hDDTextBox1.Location = new System.Drawing.Point(130, 409);
            this.hDDTextBox1.Name = "hDDTextBox1";
            this.hDDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.hDDTextBox1.TabIndex = 37;
            // 
            // sSDTextBox1
            // 
            this.sSDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laptopSpecificationsBindingSource, "SSD", true));
            this.sSDTextBox1.Location = new System.Drawing.Point(130, 435);
            this.sSDTextBox1.Name = "sSDTextBox1";
            this.sSDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.sSDTextBox1.TabIndex = 39;
            // 
            // priceTextBox1
            // 
            this.priceTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laptopSpecificationsBindingSource, "Price", true));
            this.priceTextBox1.Location = new System.Drawing.Point(130, 461);
            this.priceTextBox1.Name = "priceTextBox1";
            this.priceTextBox1.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox1.TabIndex = 41;
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(212, 492);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(75, 23);
            this.Updatebutton.TabIndex = 42;
            this.Updatebutton.Text = "Применить изменение";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1871, 652);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(idManufacturerLabel1);
            this.Controls.Add(this.idManufacturerTextBox1);
            this.Controls.Add(modelLabel1);
            this.Controls.Add(this.modelTextBox1);
            this.Controls.Add(coreCountLabel1);
            this.Controls.Add(this.coreCountTextBox1);
            this.Controls.Add(videoMemoryLabel1);
            this.Controls.Add(this.videoMemoryTextBox1);
            this.Controls.Add(rAMLabel1);
            this.Controls.Add(this.rAMTextBox1);
            this.Controls.Add(hDDLabel1);
            this.Controls.Add(this.hDDTextBox1);
            this.Controls.Add(sSDLabel1);
            this.Controls.Add(this.sSDTextBox1);
            this.Controls.Add(priceLabel1);
            this.Controls.Add(this.priceTextBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.laptopSpecificationsDataGridView);
            this.Controls.Add(this.manufacturerProductDataGridView);
            this.Name = "Form1";
            this.Text = "Laptop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myLaptopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopSpecificationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopSpecificationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MyLaptopDBDataSet myLaptopDBDataSet;
        private System.Windows.Forms.BindingSource manufacturerProductBindingSource;
        private MyLaptopDBDataSetTableAdapters.ManufacturerProductTableAdapter manufacturerProductTableAdapter;
        private MyLaptopDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MyLaptopDBDataSetTableAdapters.LaptopSpecificationsTableAdapter laptopSpecificationsTableAdapter;
        private System.Windows.Forms.DataGridView manufacturerProductDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource laptopSpecificationsBindingSource;
        private System.Windows.Forms.DataGridView laptopSpecificationsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox idManufacturerTextBox1;
        private System.Windows.Forms.TextBox modelTextBox1;
        private System.Windows.Forms.TextBox coreCountTextBox1;
        private System.Windows.Forms.TextBox videoMemoryTextBox1;
        private System.Windows.Forms.TextBox rAMTextBox1;
        private System.Windows.Forms.TextBox hDDTextBox1;
        private System.Windows.Forms.TextBox sSDTextBox1;
        private System.Windows.Forms.TextBox priceTextBox1;
        private System.Windows.Forms.Button Updatebutton;
    }
}

