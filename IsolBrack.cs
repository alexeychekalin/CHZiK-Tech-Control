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
    public partial class IsolBrack : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public IsolBrack()
        {
            InitializeComponent();
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
        }

        private void isolAddBrack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
