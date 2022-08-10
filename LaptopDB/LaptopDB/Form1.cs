using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LaptopDB
{
    public partial class Form1 : Form
    {
        //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PJQUAAP\\MYSERVER;Database=MyLaptopDB;Integrated Security=True");
        //SqlDataAdapter adapter = new SqlDataAdapter();
        //DataSet ds = new DataSet();
        //string currentId = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.manufacturerProductTableAdapter.Fill(this.myLaptopDBDataSet.ManufacturerProduct);
            this.laptopSpecificationsTableAdapter.Fill(this.myLaptopDBDataSet.LaptopSpecifications);
            //GetRecords();
        }

        
        private void manufacturerProductBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manufacturerProductBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myLaptopDBDataSet);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int i = laptopSpecificationsDataGridView.CurrentRow.Index;
            int currentId = Convert.ToInt32(laptopSpecificationsDataGridView[0, i].Value.ToString());

            this.myLaptopDBDataSet.LaptopSpecifications.FindByid(currentId).Delete();
            //this.myLaptopDBDataSet.LaptopSpecifications.AcceptChanges();

            this.laptopSpecificationsTableAdapter.Update(this.myLaptopDBDataSet.LaptopSpecifications);
            //GetRecords();
        }

        public void GetRecords()
        {
         /*   ds = new DataSet();
            adapter = new SqlDataAdapter("select*from LaptopSpecifications", connection);
            adapter.Fill(ds, "LaptopSpecifications");
            laptopSpecificationsDataGridView.DataSource = ds;
            laptopSpecificationsDataGridView.DataMember = "LaptopSpecifications";*/
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            /*ds = new DataSet();
            adapter = new SqlDataAdapter("insert into LaptopSpecifications (idManufacturer,Model,CoreCount,VideoMemory,RAM,HDD,SSD,Price)Values" + "('" + idManufacturerTextBox1.Text + "','" + modelTextBox1.Text + "','" + coreCountTextBox1.Text + "','" + videoMemoryTextBox1.Text + "','" + rAMTextBox1.Text + "','" + hDDTextBox1.Text + "','" + sSDTextBox1.Text + "','" + priceTextBox1.Text + "')", connection);
            adapter.Fill(ds, "LaptopSpecifications");
            GetRecords();*/

            var row = this.myLaptopDBDataSet.ManufacturerProduct.FindByid(Convert.ToInt32(idManufacturerTextBox1.Text));

            this.myLaptopDBDataSet.LaptopSpecifications.AddLaptopSpecificationsRow(row, modelTextBox1.Text, Convert.ToInt32(coreCountTextBox1.Text), Convert.ToInt32(videoMemoryTextBox1.Text), Convert.ToInt32(rAMTextBox1.Text), Convert.ToInt32(hDDTextBox1.Text), Convert.ToInt32(sSDTextBox1.Text), Convert.ToInt32(priceTextBox1.Text));
            this.laptopSpecificationsTableAdapter.Update(this.myLaptopDBDataSet.LaptopSpecifications);

            /*var a = this.myLaptopDBDataSet.LaptopSpecifications.FindByid(1);
            a.HDD = 43;*/

            idManufacturerTextBox1.Clear();
            modelTextBox1.Clear();
            coreCountTextBox1.Clear();
            videoMemoryTextBox1.Clear();
            rAMTextBox1.Clear();
            hDDTextBox1.Clear();
            sSDTextBox1.Clear();
            priceTextBox1.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int i = laptopSpecificationsDataGridView.CurrentRow.Index;
            int currentId = Convert.ToInt32(laptopSpecificationsDataGridView[0, i].Value.ToString());
            this.myLaptopDBDataSet.LaptopSpecifications.FindByid(currentId);
            this.laptopSpecificationsTableAdapter.Update(this.myLaptopDBDataSet.LaptopSpecifications);
            idManufacturerTextBox1.Text = laptopSpecificationsDataGridView[1, i].Value.ToString();
            modelTextBox1.Text = laptopSpecificationsDataGridView[2, i].Value.ToString();
            coreCountTextBox1.Text = laptopSpecificationsDataGridView[3, i].Value.ToString();
            videoMemoryTextBox1.Text = laptopSpecificationsDataGridView[4, i].Value.ToString();
            rAMTextBox1.Text = laptopSpecificationsDataGridView[5, i].Value.ToString();
            hDDTextBox1.Text = laptopSpecificationsDataGridView[6, i].Value.ToString();
            sSDTextBox1.Text = laptopSpecificationsDataGridView[7, i].Value.ToString();
            priceTextBox1.Text = laptopSpecificationsDataGridView[8, i].Value.ToString();

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
               //ds = new DataSet();
               var row = this.myLaptopDBDataSet.ManufacturerProduct.FindByid(Convert.ToInt32(idManufacturerTextBox1.Text));
            

            this.laptopSpecificationsTableAdapter.Update(this.myLaptopDBDataSet.LaptopSpecifications);
            this.myLaptopDBDataSet.LaptopSpecifications.AcceptChanges();
            //adapter = new SqlDataAdapter("update LaptopSpecifications set idManufacturer='" + idManufacturerTextBox1.Text + "',Model='" + modelTextBox1.Text + "',CoreCount='" + coreCountTextBox1.Text + "',VideoMemory='" + videoMemoryTextBox1.Text + "',RAM='" + rAMTextBox1.Text + "',HDD='" + hDDTextBox1.Text + "',SSD='" + sSDTextBox1.Text + "',Price='" + priceTextBox1.Text + "'where id=" + currentId, connection);
            //adapter.Fill(ds, "LaptopSpecifications");

            idManufacturerTextBox1.Clear();
            modelTextBox1.Clear();
            coreCountTextBox1.Clear();
            videoMemoryTextBox1.Clear();
            rAMTextBox1.Clear();
            hDDTextBox1.Clear();
            sSDTextBox1.Clear();
            priceTextBox1.Clear();
            //GetRecords();
        }

    }
}
