using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
using WinFormsApp1.Properties;


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

            controlMashineChart.Series = new ISeries[]
           {
                new LineSeries<ObservablePoint>
                {
                   Values = new ObservablePoint[]
                    {
                        new ObservablePoint(0, 4),
                        new ObservablePoint(1, 3),
                        new ObservablePoint(3, 8),
                        new ObservablePoint(18, 6),
                        new ObservablePoint(20, 12)
                    }
                }
           };
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

        private void materialButton6_Click(object sender, EventArgs e)
        {
            var nf = new NotFinish();
            nf.ShowDialog();
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            var nf = new NotFinish();
            nf.ShowDialog();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            var nf = new NotFinish();
            nf.ShowDialog();
        }

        private void materialButton4_Click_1(object sender, EventArgs e)
        {
            var pp = new Perepack();
            pp.ShowDialog();
        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            var pp = new Perepack();
            pp.ShowDialog();
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(materialTabControl1.SelectedIndex)
            {
                case 7:
                    var cm =  new ControlMashines(this);
                    break;
            }
        }
    }
}
