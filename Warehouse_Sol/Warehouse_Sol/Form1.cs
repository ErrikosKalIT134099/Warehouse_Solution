using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using static Warehouse_Sol.Settings.SettingsAssistant;
namespace Warehouse_Sol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            headTB.Text = settings.current.dieft;
            melos2TB.Text = settings.current.melos2;
            melosTB.Text = settings.current.melos;
        }
        string connString = "Provider=Microsoft.ACE.OLEDB.12.0;data source=WarehouseDB.mdb";
        private void Form1_Load(object sender, EventArgs e)
        {

            dataGV.RowHeadersVisible = false;
             //fill sto box tou GV
            this.dataGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataTable results = new DataTable();
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT items FROM kinds", conn);

                conn.Open();

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

                adapter.Fill(results);

                foreach (DataRow row in results.Rows)
                {
                    materialCBGV.Items.Add(row["items"].ToString());
                }
                conn.Close();
            }

        }

        public int GetItemsiD(string materialName)
        {

            string sqlQuery = "SELECT `ID` from `kinds` WHERE `items`=?";
            int result = 0;
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                var cmd = new OleDbCommand(sqlQuery, conn);
                cmd.Parameters.Add("?", OleDbType.VarChar, 255).Value = materialName;
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        result = reader.GetInt32(0);
                        Console.WriteLine(result);
                    }
                }
            }
            finally
            {
                conn.Close();
            }

            return result;


        }

        private void changeDetBTN_Click(object sender, EventArgs e)
        {
            melos2TB.Enabled = true;
            melosTB.Enabled = true;
            headTB.Enabled = true;
            saveBTN.Visible = true;
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {

            settings.current.dieft = headTB.Text;
            settings.current.melos = melosTB.Text;
            settings.current.melos2 = melos2TB.Text;
            settings.writeSettings();
            melos2TB.Enabled = false;
            melosTB.Enabled = false;
            headTB.Enabled = false;
            saveBTN.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGV.Rows.Clear();
        }

        private void dataGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
                int columnIndex = dataGV.CurrentCell.ColumnIndex;
                int rowIndex = dataGV.CurrentCell.RowIndex;

                if (columnIndex == 2)
                {
                    DataGridViewComboBoxCell matCB = dataGV.Rows[e.RowIndex].Cells[2] as DataGridViewComboBoxCell;
                    DataGridViewComboBoxCell megethosCB = dataGV.Rows[e.RowIndex].Cells[3] as DataGridViewComboBoxCell;

                    megethosCB.Items.Clear();

                    string materialValue = matCB.Value.ToString();
                    int itemsID = GetItemsiD(materialValue);


                    DataTable results = new DataTable();
                    using (OleDbConnection conn = new OleDbConnection(connString))
                    {
                        OleDbCommand cmd = new OleDbCommand("SELECT sizes FROM allSizes where kinds_ID=" + itemsID, conn);

                        conn.Open();

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

                        adapter.Fill(results);

                        foreach (DataRow row in results.Rows)
                        {
                            megethosCB.Items.Add(row["sizes"].ToString());
                        }
                        conn.Close();
                    }
                }
            }

        private void dataGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dataGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dataGV.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    //((DataGridViewComboBoxColumn)dataGV.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }
        int countedNo = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            int flagError = 0;
            dataGV.AllowUserToAddRows = false;

            foreach (DataGridViewRow rw in this.dataGV.Rows)
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Υπάρχει κενό κελί");
                        flagError = 1;
                    }
                }
            }

            countedNo = 0;
            if (flagError == 0)
            {
                // printDocument1.PrinterSettings.Copies = 3;
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.Size = new System.Drawing.Size(1000, 1000);
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                flagError = 0;
            }

            dataGV.AllowUserToAddRows = true;
        }

        private void dataGV_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["mUnitCBGV"].Value = "Τεμ.";
            e.Row.Cells["categoryCBGV"].Value = "Καινούργια";
        }
    }
    }

