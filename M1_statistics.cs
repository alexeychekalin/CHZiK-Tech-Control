using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class M1_statistics : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        string code_deffect;
        DateTime DT1;
        public M1_statistics(string _code, DateTime _time)
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

            DataGridViewColumn column1 = new DataGridViewColumn
            {
                HeaderText = "Форма",
                Width = 80,
                CellTemplate = new DataGridViewTextBoxCell()
            };
            DataGridViewColumn column2 = new DataGridViewColumn
            {
                HeaderText = "Сброс",
                Width = 80,
                CellTemplate = new DataGridViewTextBoxCell()
            };
            Grid_1.Columns.Add(column1);
            Grid_1.Columns.Add(column2);

            code_deffect = _code;
            DT1 = _time;
        }

        //Принимает код дефекта и час анализа
        private void M1_statistic_Load(object sender, EventArgs e)
        {
            label1.Text = code_deffect;
            var conn = DbWalker.GetConnection(Resources.Server, Resources.User, Resources.Password, Resources.secure, "CPS" + Resources.Cech);
            var sql = @"select Number_Mould, " + code_deffect + " from Line_" + Resources.LineControl + "_001" +
                      @" where " + code_deffect + " > 0 and Time ='" + DT1.ToString("yyyy-MM-dd HH:00:00.000") + "'";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            var command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[2]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
            }
            reader.Close();
            //conn.Close();
            foreach (string[] s in data)
                Grid_1.Rows.Add(s);

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
