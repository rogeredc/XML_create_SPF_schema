namespace XMLcreate
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_create_Interface = new System.Windows.Forms.Button();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.tabControlGV = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DataGV1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DataGV2 = new System.Windows.Forms.DataGridView();
            this.btn_create_Property = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_CLear = new System.Windows.Forms.Button();
            this.tabControlGV.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_create_Interface
            // 
            this.btn_create_Interface.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_create_Interface.Location = new System.Drawing.Point(703, 171);
            this.btn_create_Interface.Name = "btn_create_Interface";
            this.btn_create_Interface.Size = new System.Drawing.Size(191, 122);
            this.btn_create_Interface.TabIndex = 0;
            this.btn_create_Interface.Text = "Create Interface XML";
            this.btn_create_Interface.UseVisualStyleBackColor = true;
            this.btn_create_Interface.Click += new System.EventHandler(this.btn_create_Interface_Click);
            // 
            // tbxPath
            // 
            this.tbxPath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxPath.Location = new System.Drawing.Point(12, 37);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(672, 34);
            this.tbxPath.TabIndex = 2;
            this.tbxPath.Text = "Choosing Excel File.....";
            // 
            // btn_Open
            // 
            this.btn_Open.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Open.Location = new System.Drawing.Point(703, 37);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(191, 99);
            this.btn_Open.TabIndex = 3;
            this.btn_Open.Text = "OPEN";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // tabControlGV
            // 
            this.tabControlGV.Controls.Add(this.tabPage1);
            this.tabControlGV.Controls.Add(this.tabPage2);
            this.tabControlGV.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControlGV.Location = new System.Drawing.Point(12, 96);
            this.tabControlGV.Name = "tabControlGV";
            this.tabControlGV.SelectedIndex = 0;
            this.tabControlGV.Size = new System.Drawing.Size(672, 514);
            this.tabControlGV.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DataGV1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Interface";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DataGV1
            // 
            this.DataGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV1.Location = new System.Drawing.Point(0, 0);
            this.DataGV1.Name = "DataGV1";
            this.DataGV1.RowTemplate.Height = 27;
            this.DataGV1.Size = new System.Drawing.Size(664, 478);
            this.DataGV1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DataGV2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Property";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DataGV2
            // 
            this.DataGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV2.Location = new System.Drawing.Point(0, 1);
            this.DataGV2.Name = "DataGV2";
            this.DataGV2.RowTemplate.Height = 27;
            this.DataGV2.Size = new System.Drawing.Size(662, 484);
            this.DataGV2.TabIndex = 0;
            // 
            // btn_create_Property
            // 
            this.btn_create_Property.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_create_Property.Location = new System.Drawing.Point(703, 343);
            this.btn_create_Property.Name = "btn_create_Property";
            this.btn_create_Property.Size = new System.Drawing.Size(191, 122);
            this.btn_create_Property.TabIndex = 6;
            this.btn_create_Property.Text = "Create Property XML";
            this.btn_create_Property.UseVisualStyleBackColor = true;
            this.btn_create_Property.Click += new System.EventHandler(this.btn_create_Property_Click);
            // 
            // btn_CLear
            // 
            this.btn_CLear.Image = ((System.Drawing.Image)(resources.GetObject("btn_CLear.Image")));
            this.btn_CLear.Location = new System.Drawing.Point(703, 493);
            this.btn_CLear.Name = "btn_CLear";
            this.btn_CLear.Size = new System.Drawing.Size(110, 109);
            this.btn_CLear.TabIndex = 7;
            this.btn_CLear.UseVisualStyleBackColor = true;
            this.btn_CLear.Click += new System.EventHandler(this.btn_CLear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 641);
            this.Controls.Add(this.btn_CLear);
            this.Controls.Add(this.btn_create_Property);
            this.Controls.Add(this.tabControlGV);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.btn_create_Interface);
            this.Name = "Form1";
            this.Text = "CDW Schema Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlGV.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create_Interface;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.TabControl tabControlGV;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DataGV1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DataGV2;
        private System.Windows.Forms.Button btn_create_Property;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_CLear;
    }
}

