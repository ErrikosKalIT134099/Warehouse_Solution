using System;
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

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            
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
    }
}
