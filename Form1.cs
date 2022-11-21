using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsApp1
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;


            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = false;


            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE);

            DrawerUseColors = true;
            DrawerAutoShow = true;
            FormStyle = FormStyles.ActionBar_40;


            // ТАЙМЕР
            timer1.Interval = 5;
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void users_SelectedIndexChanged(object sender, EventArgs e)
        {
            var password = new password();
            password.ShowDialog();
        }

        private void materialTextBox22_Click(object sender, EventArgs e)
        {
            MaterialDialog materialDialog = new MaterialDialog(this, "Dialog Title", "Dialogs inform users about a task and can contain critical information, require decisions, or involve multiple tasks.", "OK", true, "Cancel");
            DialogResult result = materialDialog.ShowDialog(this);
        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage19_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void isolAddBrack_Click(object sender, EventArgs e)
        {
            var newBrack = new IsolBrack();
            newBrack.ShowDialog();
        }

        private void isolChangeBrack_Click(object sender, EventArgs e)
        {
            var newBrack = new IsolBrack();
            newBrack.ShowDialog();
        }

        private void isolShowBrack_Click(object sender, EventArgs e)
        {
            var newBrack = new IsolBrack();
            newBrack.ShowDialog();
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialCard9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void isolBalanceMainData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
