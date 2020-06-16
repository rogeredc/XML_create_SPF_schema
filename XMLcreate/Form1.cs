using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace XMLcreate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btn_Open_Click(object sender, EventArgs e)
        {

            try
            {

                OpenFileDialog dlg = new OpenFileDialog();               

                dlg.RestoreDirectory = true;
                dlg.Title = "Open Excel File";
                dlg.Filter = "Excel|*.xlsx;*.xlsm";
                
                if (dlg.ShowDialog() == DialogResult.OK && dlg.FileName != "")
                {
                    this.tbxPath.Text = dlg.FileName;
                }
                else
                {
                    this.tbxPath.Text = "Choosing Excel File...";
                }

                DataSet ds = new DataSet();

                ExcelProcess excel1 = new ExcelProcess(this.tbxPath.Text);
                ds = excel1.Import();
                this.DataGV1.DataSource = ds.Tables["Interface"];
                this.DataGV2.DataSource = ds.Tables["Property"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_create_Property_Click(object sender, EventArgs e)
        {
            XmlDocument doc = null;
            SaveFileDialog dlg = new SaveFileDialog();

            dlg.Title = "Save File";
            dlg.Filter = "XML Files (*.xml)|*.xml";
            string fileSavePath = null;

            XmlProcess_Property xml_Property = new XmlProcess_Property(this.tbxPath.Text);
            doc = xml_Property.Export();

            if (dlg.ShowDialog() == DialogResult.OK && dlg.FileName != "")
            {
                fileSavePath = dlg.FileName;
            }

            doc.Save(fileSavePath);
           

            MessageBox.Show($"檔案成功匯出於：{fileSavePath}");
            System.Diagnostics.Process.Start("iexplore.exe", fileSavePath);

        }



        private void btn_create_Interface_Click(object sender, EventArgs e)
        {
            XmlDocument doc = null;
            SaveFileDialog dlg = new SaveFileDialog();

            dlg.Title = "Save File";
            dlg.Filter = "XML Files (*.xml)|*.xml";
            string fileSavePath = null;

            XmlProcess_Interface xml_Interface = new XmlProcess_Interface(this.tbxPath.Text);
            doc = xml_Interface.Export();

            if (dlg.ShowDialog() == DialogResult.OK && dlg.FileName != "")
            {
                fileSavePath = dlg.FileName;
            }

            doc.Save(fileSavePath);

            MessageBox.Show($"檔案成功匯出於：{fileSavePath}");
            System.Diagnostics.Process.Start("iexplore.exe", fileSavePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_CLear_Click(object sender, EventArgs e)
        {
            try
            {
                this.DataGV1.DataSource = null;
                this.DataGV1.Refresh();
                this.DataGV2.DataSource = null;
                this.DataGV2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


}
