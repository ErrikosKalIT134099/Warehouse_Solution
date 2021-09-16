
namespace Warehouse_Sol
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.arKivotiouLB = new System.Windows.Forms.Label();
            this.arKivotiouTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.headTB = new System.Windows.Forms.TextBox();
            this.melosTB = new System.Windows.Forms.TextBox();
            this.melos2TB = new System.Windows.Forms.TextBox();
            this.changeDetBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewBTN = new System.Windows.Forms.Button();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveBTN = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.quantityTBGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUnitCBGV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materialCBGV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sizeCBGV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoryCBGV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLB.Location = new System.Drawing.Point(242, 9);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(382, 24);
            this.titleLB.TabIndex = 0;
            this.titleLB.Text = "Δελτίο Απογράφης Προϊόντων Αποθήκης";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ημερομηνία Απογραφής: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // arKivotiouLB
            // 
            this.arKivotiouLB.AutoSize = true;
            this.arKivotiouLB.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arKivotiouLB.Location = new System.Drawing.Point(15, 209);
            this.arKivotiouLB.Name = "arKivotiouLB";
            this.arKivotiouLB.Size = new System.Drawing.Size(141, 17);
            this.arKivotiouLB.TabIndex = 3;
            this.arKivotiouLB.Text = "Αριθμός Κιβωτίου: ";
            // 
            // arKivotiouTB
            // 
            this.arKivotiouTB.Location = new System.Drawing.Point(174, 209);
            this.arKivotiouTB.Name = "arKivotiouTB";
            this.arKivotiouTB.Size = new System.Drawing.Size(100, 20);
            this.arKivotiouTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Διευθυντής: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Λοιπά Μέλη:";
            // 
            // headTB
            // 
            this.headTB.Enabled = false;
            this.headTB.Location = new System.Drawing.Point(18, 286);
            this.headTB.Name = "headTB";
            this.headTB.Size = new System.Drawing.Size(160, 20);
            this.headTB.TabIndex = 7;
            // 
            // melosTB
            // 
            this.melosTB.Enabled = false;
            this.melosTB.Location = new System.Drawing.Point(18, 363);
            this.melosTB.Name = "melosTB";
            this.melosTB.Size = new System.Drawing.Size(160, 20);
            this.melosTB.TabIndex = 8;
            // 
            // melos2TB
            // 
            this.melos2TB.Enabled = false;
            this.melos2TB.Location = new System.Drawing.Point(18, 399);
            this.melos2TB.Name = "melos2TB";
            this.melos2TB.Size = new System.Drawing.Size(160, 20);
            this.melos2TB.TabIndex = 9;
            // 
            // changeDetBTN
            // 
            this.changeDetBTN.Location = new System.Drawing.Point(190, 245);
            this.changeDetBTN.Name = "changeDetBTN";
            this.changeDetBTN.Size = new System.Drawing.Size(108, 23);
            this.changeDetBTN.TabIndex = 10;
            this.changeDetBTN.Text = "Αλλαγή Στοιχείων";
            this.changeDetBTN.UseVisualStyleBackColor = true;
            this.changeDetBTN.Click += new System.EventHandler(this.changeDetBTN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Διαγραφή \'Ολων";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewBTN
            // 
            this.printPreviewBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printPreviewBTN.Location = new System.Drawing.Point(363, 716);
            this.printPreviewBTN.Name = "printPreviewBTN";
            this.printPreviewBTN.Size = new System.Drawing.Size(145, 49);
            this.printPreviewBTN.TabIndex = 13;
            this.printPreviewBTN.Text = "Προεπισκόπηση";
            this.printPreviewBTN.UseVisualStyleBackColor = true;
            this.printPreviewBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGV
            // 
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantityTBGV,
            this.mUnitCBGV,
            this.materialCBGV,
            this.sizeCBGV,
            this.categoryCBGV});
            this.dataGV.Location = new System.Drawing.Point(40, 485);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(802, 224);
            this.dataGV.TabIndex = 12;
            this.dataGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_CellEndEdit);
            this.dataGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGV_DataError);
            this.dataGV.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGV_DefaultValuesNeeded);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(332, 245);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(91, 23);
            this.saveBTN.TabIndex = 15;
            this.saveBTN.Text = "Αποθήκευση";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Visible = false;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // quantityTBGV
            // 
            this.quantityTBGV.HeaderText = "Ποσότητα";
            this.quantityTBGV.Name = "quantityTBGV";
            // 
            // mUnitCBGV
            // 
            this.mUnitCBGV.HeaderText = "Μονάδα Μέτρησης";
            this.mUnitCBGV.Items.AddRange(new object[] {
            "Τεμ.",
            "Ζευγ."});
            this.mUnitCBGV.Name = "mUnitCBGV";
            // 
            // materialCBGV
            // 
            this.materialCBGV.HeaderText = "Υλικό";
            this.materialCBGV.Name = "materialCBGV";
            // 
            // sizeCBGV
            // 
            this.sizeCBGV.HeaderText = "Μέγεθος";
            this.sizeCBGV.Name = "sizeCBGV";
            // 
            // categoryCBGV
            // 
            this.categoryCBGV.HeaderText = "Κατηγορία";
            this.categoryCBGV.Items.AddRange(new object[] {
            "Καινούργια",
            "Μεταχειρισμένα"});
            this.categoryCBGV.Name = "categoryCBGV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(884, 777);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.printPreviewBTN);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changeDetBTN);
            this.Controls.Add(this.melos2TB);
            this.Controls.Add(this.melosTB);
            this.Controls.Add(this.headTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arKivotiouTB);
            this.Controls.Add(this.arKivotiouLB);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Απογραφή Προιόντων Αποθήκης";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label arKivotiouLB;
        private System.Windows.Forms.TextBox arKivotiouTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox headTB;
        private System.Windows.Forms.TextBox melosTB;
        private System.Windows.Forms.TextBox melos2TB;
        private System.Windows.Forms.Button changeDetBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button printPreviewBTN;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityTBGV;
        private System.Windows.Forms.DataGridViewComboBoxColumn mUnitCBGV;
        private System.Windows.Forms.DataGridViewComboBoxColumn materialCBGV;
        private System.Windows.Forms.DataGridViewComboBoxColumn sizeCBGV;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryCBGV;
    }
}

