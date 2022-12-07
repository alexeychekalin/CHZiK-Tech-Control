using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    class ControlMashines : Form1
    {
        DateTime DT1 = DateTime.Parse("2022-11-25 08:00:00.000");
        private int totalCPA = 0, totalCEJ = 0, msf_cj = 0, msf_1, msf_2, msf_3, msf_4, msf_5, msf_6, msf_7, msf_8;
        private int csbc_cj, csbc_14, csbc_15, csbc_16, csbc_17, csbc_18, csbc_19, csbc_20, csbc_21, csbc_22, csbc_23, csbc_24, csbc_25, csbc_26, csbc_27, csbc_28;

        private int mcal_totalCPA, mcal_totalCEJ, mcal_1, mcal_2, mcal_3, mcal_4, mcal_5, mcal_6, mcal_7, mcal_8, mcal_9, mcal_10;

        private int mcal_11, mcal_12, mcal_13, mcal_14, mcal_15, mcal_16, mcal_17;

        private int m1_totalCPA, m1_totalCEJ, m1_totalCES;
        private int m1_213, m1_414, m1_219, m1_220, m1_0241, m1_0243, m1_0245, m1_02414;

        private int icam_CPA, icam_CEJ, icam_c1, icam_c2, icam_c3, icam_c4, icam_c5, icam_c51, icam_c52, icam_c53, icam_c96, icam_c97, icam_c98, icam_c93, icam_c94;
        private int icam_c91, icam_c82;

        Form1 form;

        public ControlMashines(Form1 f)
        {
            form = f;
            sel_equipment();
            f.b_max.Click += new System.EventHandler(this.b_max_Click);
            f.b_min.Click += new System.EventHandler(this.b_min_Click);
            f.label160.Click += new System.EventHandler(this.label160_Click);
            f.label157.Click += new System.EventHandler(this.label157_Click);
            f.label158.Click += new System.EventHandler(this.label158_Click);
            f.label156.Click += new System.EventHandler(this.label156_Click);
            f.label155.Click += new System.EventHandler(this.label155_Click);
            f.label154.Click += new System.EventHandler(this.label154_Click);
            f.label153.Click += new System.EventHandler(this.label153_Click);
            f.label152.Click += new System.EventHandler(this.label152_Click);
            f.label151.Click += new System.EventHandler(this.label151_Click);


        }

        #region sel_equipment() Выбор состава оборудования от номера линии
        private void sel_equipment()
        {
            form.lab_visir.Text = DT1.ToString("HH:00  dd:MM:yyyy");

            if (Resources.Cech == "2" && Resources.LineControl == "1")
            {
                fill_tab_m4_old(); fill_tab_mcal(); fill_m1_old(); unvisible_icam();
            }
            if (Resources.Cech == "2" && Resources.LineControl == "2")
            {
                fill_tab_m4_old(); fill_m1_old(); fill_tab_icam(); unvisible_mcal();
            }
            if (Resources.Cech == "2" && Resources.LineControl == "3")
            {
                fill_tab_m4_old(); fill_tab_icam(); unvisible_mcal();
            }

            if (Resources.Cech == "3" && Resources.LineControl == "1")
            {
                fill_tab_m4_old(); fill_tab_icam(); fill_m1_old(); unvisible_mcal();
            }
            if (Resources.Cech == "3" && Resources.LineControl == "2")
            {
                fill_tab_m4_old(); fill_m1_old(); fill_tab_icam(); unvisible_mcal();
            }
            if (Resources.Cech == "3" && Resources.LineControl == "3")
            {
                fill_tab_m4_old(); fill_m1_old(); fill_tab_icam(); unvisible_mcal();
            }
        }
        #endregion

        #region Инкремент визира времени
        private void b_max_Click(object sender, EventArgs e)
        {
            DT1 = DT1.AddHours(1);
            //DT2 = DT2.AddHours(1);
            form.lab_visir.Text = DT1.ToString("HH:00  dd:MM:yyyy");
            sel_equipment();
        }
        #endregion

        #region Декремент визира времени
        private void b_min_Click(object sender, EventArgs e)
        {
            DT1 = DT1.AddHours(-1);
            //DT2 = DT2.AddHours(-1);
            form.lab_visir.Text = DT1.ToString("HH:00  dd:MM:yyyy");
            sel_equipment();
        }
        #endregion

        #region fill_tab_m4_old() Заполняем таблицу multi4 old
        private void fill_tab_m4_old()
        {
            var sql = @"select 
                totalCPA, totalCEJ, msf_cj, csbc_cj, msf_1, msf_2, msf_3, msf_4, msf_5, msf_6, msf_7,msf_8, csbc_14, csbc_15, csbc_17, csbc_18,
                csbc_19, csbc_20, csbc_23

                from CPS" + Resources.Cech + ".[dbo].[Line_" + Resources.LineControl + "_multi] " +
                 "where  Data BETWEEN '" + DT1.ToString("yyyy-MM-ddTHH:00:00.000") + "' AND '" + DT1.ToString("yyyy-MM-ddTHH:30:00.000") + "'";
            //form.label63.Text = sql.ToString();
            var conn = DbWalker.GetConnection(Resources.Server, Resources.User, Resources.Password, Resources.secure, "CPS" + Resources.Cech);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(@"Конструктор" + ex.Message);
                //return;
            }
            var command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            try
            {
                totalCPA = (int)reader["totalCPA"]; form.label130.Text = totalCPA.ToString();
                totalCEJ = (int)reader["totalCEJ"]; form.label129.Text = totalCEJ.ToString();
                msf_cj = (int)reader["msf_cj"];
                csbc_cj = (int)reader["csbc_cj"];
                msf_1 = (int)reader["msf_1"]; form.label93.Text = msf_1.ToString();
                msf_2 = (int)reader["msf_2"]; form.label103.Text = msf_2.ToString();
                msf_3 = (int)reader["msf_3"]; form.label102.Text = msf_3.ToString();
                msf_4 = (int)reader["msf_4"]; form.label100.Text = msf_4.ToString();
                msf_5 = (int)reader["msf_5"]; form.label99.Text = msf_5.ToString();
                msf_6 = (int)reader["msf_6"]; form.label97.Text = msf_6.ToString();
                msf_7 = (int)reader["msf_7"]; form.label96.Text = msf_7.ToString();
                msf_8 = (int)reader["msf_8"]; form.label94.Text = msf_8.ToString();
                double total_pr_hour = Math.Round((Convert.ToDouble(totalCEJ) * 100 / totalCPA), 2); form.label128.Text = total_pr_hour.ToString();

                //csbc_13 = (int)reader["csbc_13"]; form.label84.Text = csbc_13.ToString();
                csbc_14 = (int)reader["csbc_14"]; form.label91.Text = csbc_14.ToString();
                csbc_15 = (int)reader["csbc_15"]; form.label90.Text = csbc_15.ToString();
                csbc_17 = (int)reader["csbc_17"]; form.label88.Text = csbc_17.ToString();
                csbc_18 = (int)reader["csbc_18"]; form.label87.Text = csbc_18.ToString();
                csbc_19 = (int)reader["csbc_19"]; form.label85.Text = csbc_19.ToString();
                csbc_20 = (int)reader["csbc_20"]; form.label172.Text = csbc_20.ToString();
                csbc_23 = (int)reader["csbc_23"]; form.label171.Text = csbc_23.ToString();

                form.label84.Text = Math.Round((Convert.ToDouble(msf_cj) * 100 / totalCPA), 2).ToString();
                form.label82.Text = Math.Round((Convert.ToDouble(csbc_cj) * 100 / totalCPA), 2).ToString();

                #region Засветка зон с браками
                if (msf_1 > 0)
                {
                    form.label116.BackColor = Color.Orange; form.label93.BackColor = Color.Orange;
                }
                else
                {
                    form.label116.BackColor = Color.Honeydew; form.label93.BackColor = Color.Honeydew;
                }
                if (msf_2 > 0)
                {
                    form.label124.BackColor = Color.Orange; form.label103.BackColor = Color.Orange;
                }
                else
                {
                    form.label124.BackColor = Color.Honeydew; form.label103.BackColor = Color.Honeydew;
                }
                if (msf_3 > 0)
                {
                    form.label121.BackColor = Color.Orange; form.label102.BackColor = Color.Orange;
                }
                else
                {
                    form.label121.BackColor = Color.Honeydew; form.label102.BackColor = Color.Honeydew;
                }
                if (msf_4 > 0)
                {
                    form.label122.BackColor = Color.Orange; form.label100.BackColor = Color.Orange;
                }
                else
                {
                    form.label122.BackColor = Color.Honeydew; form.label100.BackColor = Color.Honeydew;
                }
                if (msf_5 > 0)
                {
                    form.label120.BackColor = Color.Orange; form.label99.BackColor = Color.Orange;
                }
                else
                {
                    form.label120.BackColor = Color.Honeydew; form.label99.BackColor = Color.Honeydew;
                }
                if (msf_6 > 0)
                {
                    form.label115.BackColor = Color.Orange; form.label97.BackColor = Color.Orange;
                }
                else
                {
                    form.label115.BackColor = Color.Honeydew; form.label97.BackColor = Color.Honeydew;
                }
                if (msf_7 > 0)
                {
                    form.label118.BackColor = Color.Orange; form.label96.BackColor = Color.Orange;
                }
                else
                {
                    form.label118.BackColor = Color.Honeydew; form.label96.BackColor = Color.Honeydew;
                }
                if (msf_8 > 0)
                {
                    form.label117.BackColor = Color.Orange; form.label94.BackColor = Color.Orange;
                }
                else
                {
                    form.label117.BackColor = Color.Honeydew; form.label94.BackColor = Color.Honeydew;
                }
                if (csbc_14 > 0)
                {
                    form.label91.BackColor = Color.Orange; form.label115.BackColor = Color.Orange;
                }
                else
                {
                    form.label91.BackColor = Color.Honeydew; form.label115.BackColor = Color.Honeydew;
                }
                if (csbc_15 > 0)
                {
                    form.label90.BackColor = Color.Orange; form.label114.BackColor = Color.Orange;
                }
                else
                {
                    form.label90.BackColor = Color.Honeydew; form.label114.BackColor = Color.Honeydew;
                }
                if (csbc_17 > 0)
                {
                    form.label88.BackColor = Color.Orange; form.label113.BackColor = Color.Orange;
                }
                else
                {
                    form.label88.BackColor = Color.Honeydew; form.label113.BackColor = Color.Honeydew;
                }
                if (csbc_18 > 0)
                {
                    form.label87.BackColor = Color.Orange; form.label108.BackColor = Color.Orange;
                }
                else
                {
                    form.label87.BackColor = Color.Honeydew; form.label108.BackColor = Color.Honeydew;
                }
                if (csbc_19 > 0)
                {
                    form.label85.BackColor = Color.Orange; form.label106.BackColor = Color.Orange;
                }
                else
                {
                    form.label85.BackColor = Color.Honeydew; form.label106.BackColor = Color.Honeydew;
                }
                if (csbc_20 > 0)
                {
                    form.label172.BackColor = Color.Orange; form.label170.BackColor = Color.Orange;
                }
                else
                {
                    form.label172.BackColor = Color.Honeydew; form.label170.BackColor = Color.Honeydew;
                }
                if (csbc_23 > 0)
                {
                    form.label171.BackColor = Color.Orange; form.label169.BackColor = Color.Orange;
                }
                else
                {
                    form.label171.BackColor = Color.Honeydew; form.label169.BackColor = Color.Honeydew;
                }
                #endregion
            }
            catch
            {
                form.label130.Text = "0"; form.label129.Text = "0"; form.label93.Text = "0"; form.label103.Text = "0"; form.label102.Text = "0"; form.label100.Text = "0"; form.label99.Text = "0";
                form.label97.Text = "0"; form.label96.Text = "0"; form.label94.Text = "0"; form.label91.Text = "0"; form.label90.Text = "0"; form.label88.Text = "0"; form.label87.Text = "0";
                form.label85.Text = "0"; form.label172.Text = "0"; form.label171.Text = "0"; form.label128.Text = "0"; form.label84.Text = "0"; form.label82.Text = "0";
            }
        }
        #endregion

        #region fill_tab_mcal() Заполняем таблицу MCAL
        private void fill_tab_mcal()
        {
            var sql = @"select 
                totalCPA, totalCEJ,
                mcal_1,  mcal_2, mcal_3, mcal_4, mcal_5, mcal_6, mcal_7, mcal_8, mcal_9, mcal_10, mcal_12, mcal_13, mcal_14, mcal_15, mcal_16, mcal_17

                from CPS" + Resources.Cech + ".[dbo].[Line_" + Resources.LineControl + "_mcal] " +
                 "where  Data BETWEEN '" + DT1.ToString("yyyy-MM-ddTHH:00:00.000") + "' AND '" + DT1.ToString("yyyy-MM-ddTHH:50:00.000") + "'";
            //form.label63.Text = sql.ToString();
            var conn = DbWalker.GetConnection(Resources.Server, Resources.User, Resources.Password, Resources.secure, "CPS" + Resources.Cech);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Конструктор" + ex.Message);
                return;
            }
            var command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            try
            {
                mcal_totalCPA = (int)reader["totalCPA"]; form.label18.Text = mcal_totalCPA.ToString();
                mcal_totalCEJ = (int)reader["totalCEJ"]; form.label21.Text = mcal_totalCEJ.ToString();
                double total_pr_hour = Math.Round((Convert.ToDouble(mcal_totalCEJ) * 100 / mcal_totalCPA), 2); form.label22.Text = total_pr_hour.ToString();
                mcal_1 = (int)reader["mcal_1"]; // сброс по визуалке
                double pr_mcal_1 = Math.Round((Convert.ToDouble(mcal_1) * 100 / mcal_totalCPA), 2); form.label73.Text = pr_mcal_1.ToString();
                mcal_2 = (int)reader["mcal_2"]; form.label58.Text = mcal_2.ToString();
                mcal_3 = (int)reader["mcal_3"]; form.label65.Text = mcal_3.ToString();
                mcal_4 = (int)reader["mcal_4"]; form.label64.Text = mcal_4.ToString();
                mcal_5 = (int)reader["mcal_5"]; form.label62.Text = mcal_5.ToString();
                mcal_6 = (int)reader["mcal_6"]; form.label61.Text = mcal_6.ToString();
                mcal_7 = (int)reader["mcal_7"]; form.label71.Text = mcal_7.ToString();
                mcal_8 = (int)reader["mcal_8"]; form.label90.Text = mcal_8.ToString();
                mcal_9 = (int)reader["mcal_9"]; form.label68.Text = mcal_9.ToString();
                mcal_10 = (int)reader["mcal_10"]; form.label67.Text = mcal_10.ToString();
                //mcal_11 = (int)reader["mcal_11"]; form.label100.Text= mcal_11.ToString(); удален не используется
                mcal_12 = (int)reader["mcal_12"]; form.label59.Text = mcal_12.ToString();
                mcal_13 = (int)reader["mcal_13"]; // сброс по геометрии
                double pr_mcal_13 = Math.Round((Convert.ToDouble(mcal_13) * 100 / mcal_totalCPA), 2); form.label81.Text = pr_mcal_13.ToString();
                mcal_14 = (int)reader["mcal_14"]; form.label79.Text = mcal_14.ToString();
                mcal_15 = (int)reader["mcal_15"]; form.label74.Text = mcal_15.ToString();
                mcal_16 = (int)reader["mcal_16"]; form.label76.Text = mcal_16.ToString();
                mcal_17 = (int)reader["mcal_17"]; form.label167.Text = mcal_17.ToString();

                #region Засветка зон с браками
                if (mcal_2 > 0)
                {
                    form.label58.BackColor = Color.Orange; form.label50.BackColor = Color.Orange;
                }
                else
                {
                    form.label58.BackColor = Color.Honeydew; form.label50.BackColor = Color.Honeydew;
                }
                if (mcal_3 > 0)
                {
                    form.label31.BackColor = Color.Orange; form.label65.BackColor = Color.Orange;
                }
                else
                {
                    form.label31.BackColor = Color.Honeydew; form.label65.BackColor = Color.Honeydew;
                }
                if (mcal_4 > 0)
                {
                    form.label38.BackColor = Color.Orange; form.label64.BackColor = Color.Orange;
                }
                else
                {
                    form.label38.BackColor = Color.Honeydew; form.label64.BackColor = Color.Honeydew;
                }
                if (mcal_5 > 0)
                {
                    form.label36.BackColor = Color.Orange; form.label62.BackColor = Color.Orange;
                }
                else
                {
                    form.label36.BackColor = Color.Honeydew; form.label62.BackColor = Color.Honeydew;
                }
                if (mcal_6 > 0)
                {
                    form.label39.BackColor = Color.Orange; form.label61.BackColor = Color.Orange;
                }
                else
                {
                    form.label39.BackColor = Color.Honeydew; form.label61.BackColor = Color.Honeydew;
                }
                if (mcal_7 > 0)
                {
                    form.label41.BackColor = Color.Orange; form.label71.BackColor = Color.Orange;
                }
                else
                {
                    form.label41.BackColor = Color.Honeydew; form.label71.BackColor = Color.Honeydew;
                }
                if (mcal_8 > 0)
                {
                    form.label42.BackColor = Color.Orange; form.label90.BackColor = Color.Orange;
                }
                else
                {
                    form.label42.BackColor = Color.Honeydew; form.label90.BackColor = Color.Honeydew;
                }
                if (mcal_9 > 0)
                {
                    form.label44.BackColor = Color.Orange; form.label68.BackColor = Color.Orange;
                }
                else
                {
                    form.label44.BackColor = Color.Honeydew; form.label68.BackColor = Color.Honeydew;
                }
                if (mcal_10 > 0)
                {
                    form.label47.BackColor = Color.Orange; form.label67.BackColor = Color.Orange;
                }
                else
                {
                    form.label47.BackColor = Color.Honeydew; form.label67.BackColor = Color.Honeydew;
                }
                if (mcal_12 > 0)
                {
                    form.label49.BackColor = Color.Orange; form.label59.BackColor = Color.Orange;
                }
                else
                {
                    form.label49.BackColor = Color.Honeydew; form.label59.BackColor = Color.Honeydew;
                }
                if (mcal_14 > 0)
                {
                    form.label52.BackColor = Color.Orange; form.label79.BackColor = Color.Orange;
                }
                else
                {
                    form.label52.BackColor = Color.Honeydew; form.label79.BackColor = Color.Honeydew;
                }
                if (mcal_15 > 0)
                {
                    form.label55.BackColor = Color.Orange; form.label74.BackColor = Color.Orange;
                }
                else
                {
                    form.label55.BackColor = Color.Honeydew; form.label74.BackColor = Color.Honeydew;
                }
                if (mcal_16 > 0)
                {
                    form.label53.BackColor = Color.Orange; form.label76.BackColor = Color.Orange;
                }
                else
                {
                    form.label53.BackColor = Color.Honeydew; form.label76.BackColor = Color.Honeydew;
                }
                if (mcal_17 > 0)
                {
                    form.label168.BackColor = Color.Orange; form.label167.BackColor = Color.Orange;
                }
                else
                {
                    form.label168.BackColor = Color.Honeydew; form.label167.BackColor = Color.Honeydew;
                }
                #endregion
            }
            catch
            {
                form.label18.Text = "0"; form.label21.Text = "0"; form.label22.Text = "0"; form.label73.Text = "0"; form.label58.Text = "0"; form.label65.Text = "0";
                form.label64.Text = "0"; form.label62.Text = "0"; form.label61.Text = "0"; form.label68.Text = "0"; form.label90.Text = "0"; form.label71.Text = "0"; form.label67.Text = "0";
                form.label59.Text = "0"; form.label79.Text = "0"; form.label74.Text = "0"; form.label167.Text = "0"; form.label76.Text = "0"; form.label81.Text = "0";
            }
        }


        #endregion

        #region fill_m1_old() Заполняем таблицу М1_old
        private void fill_m1_old()
        {
            var sql = @"select 
                sum(CPA) as CPA, sum(CEJ) as CEJ, sum(CES) as CES,
                sum(Deffect_213) as Deffect_213, sum(Deffect_414) as Deffect_414, sum(Deffect_219) as Deffect_219, sum(Deffect_220) as Deffect_220,
                sum(Deffect_024_1) as Deffect_024_1, sum(Deffect_024_3) as Deffect_024_3, sum(Deffect_024_5) as Deffect_024_5, sum(Deffect_024_14) as Deffect_024_14
                from CPS" + Resources.Cech + ".[dbo].[Line_" + Resources.LineControl + "_001] " +
                            "where  Time BETWEEN '" + DT1.ToString("yyyy-MM-ddTHH:00:00.000") + "' AND '" + DT1.ToString("yyyy-MM-ddTHH:59:00.000") + "'";
            //form.label63.Text = sql.ToString();
            var conn = DbWalker.GetConnection(Resources.Server, Resources.User, Resources.Password, Resources.secure, "CPS" + Resources.Cech);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(@"Конструктор" + ex.Message);
                //return;
            }
            var command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            try
            {
                m1_totalCPA = (int)reader["CPA"]; form.label166.Text = m1_totalCPA.ToString();
                m1_totalCES = (int)reader["CES"]; form.label137.Text = m1_totalCES.ToString();
                m1_totalCEJ = (int)reader["CEJ"];
                form.label165.Text = (m1_totalCEJ + m1_totalCES).ToString();

                double total_pr_hour = Math.Round((Convert.ToDouble(m1_totalCEJ) + Convert.ToDouble(m1_totalCES)) * 100 / m1_totalCPA, 2); form.label164.Text = total_pr_hour.ToString();

                m1_213 = (int)reader["Deffect_213"]; form.label145.Text = m1_213.ToString();
                m1_414 = (int)reader["Deffect_414"]; form.label144.Text = m1_414.ToString();
                m1_219 = (int)reader["Deffect_219"]; form.label143.Text = m1_219.ToString();
                m1_220 = (int)reader["Deffect_220"]; form.label142.Text = m1_220.ToString();
                m1_0241 = (int)reader["Deffect_024_1"]; form.label141.Text = m1_0241.ToString();
                m1_0243 = (int)reader["Deffect_024_3"]; form.label140.Text = m1_0243.ToString();
                m1_0245 = (int)reader["Deffect_024_5"]; form.label139.Text = m1_0245.ToString();
                m1_02414 = (int)reader["Deffect_024_14"]; form.label138.Text = m1_02414.ToString();

                #region Закраска зон
                if (m1_213 > 0)
                {
                    form.label145.BackColor = Color.Orange; form.label160.BackColor = Color.Orange;
                }
                else
                {
                    form.label145.BackColor = Color.Honeydew; form.label160.BackColor = Color.Honeydew;
                }
                if (m1_414 > 0)
                {
                    form.label144.BackColor = Color.Orange; form.label157.BackColor = Color.Orange;
                }
                else
                {
                    form.label144.BackColor = Color.Honeydew; form.label157.BackColor = Color.Honeydew;
                }
                if (m1_219 > 0)
                {
                    form.label143.BackColor = Color.Orange; form.label158.BackColor = Color.Orange;
                }
                else
                {
                    form.label143.BackColor = Color.Honeydew; form.label158.BackColor = Color.Honeydew;
                }
                if (m1_220 > 0)
                {
                    form.label142.BackColor = Color.Orange; form.label156.BackColor = Color.Orange;
                }
                else
                {
                    form.label142.BackColor = Color.Honeydew; form.label156.BackColor = Color.Honeydew;
                }
                if (m1_0241 > 0)
                {
                    form.label141.BackColor = Color.Orange; form.label155.BackColor = Color.Orange;
                }
                else
                {
                    form.label141.BackColor = Color.Honeydew; form.label155.BackColor = Color.Honeydew;
                }
                if (m1_0243 > 0)
                {
                    form.label140.BackColor = Color.Orange; form.label154.BackColor = Color.Orange;
                }
                else
                {
                    form.label140.BackColor = Color.Honeydew; form.label154.BackColor = Color.Honeydew;
                }
                if (m1_0245 > 0)
                {
                    form.label153.BackColor = Color.Orange; form.label139.BackColor = Color.Orange;
                }
                else
                {
                    form.label153.BackColor = Color.Honeydew; form.label139.BackColor = Color.Honeydew;
                }
                if (m1_02414 > 0)
                {
                    form.label152.BackColor = Color.Orange; form.label138.BackColor = Color.Orange;
                }
                else
                {
                    form.label152.BackColor = Color.Honeydew; form.label138.BackColor = Color.Honeydew;
                }
                if (m1_totalCES > 0)
                {
                    form.label151.BackColor = Color.Red; form.label137.BackColor = Color.Red;
                }
                else
                {
                    form.label151.BackColor = Color.Honeydew; form.label137.BackColor = Color.Honeydew;
                }
                #endregion
            }
            catch (Exception ex)
            {
                form.label166.Text = "0"; form.label165.Text = "0"; form.label137.Text = "0"; form.label164.Text = "0"; form.label145.Text = "0"; form.label144.Text = "0";
                form.label143.Text = "0"; form.label142.Text = "0"; form.label141.Text = "0"; form.label140.Text = "0"; form.label139.Text = "0"; form.label138.Text = "0";
            }
        }
        #endregion

        #region fill_tab_icam() заполняем таблицу ICAM
        private void fill_tab_icam()
        {
            var sql = @"select 
                CPA, CEJ, c1, c2, c3, c4, c5, c51, c52, c53, c82, c91, c96, c97, c98, c93, c94

                from CPS" + Resources.Cech + ".[dbo].[Line_" + Resources.LineControl + "_303] " +
                "where  Time BETWEEN '" + DT1.ToString("yyyy-MM-ddTHH:00:00.000") + "' AND '" + DT1.ToString("yyyy-MM-ddTHH:50:00.000") + "'";
            //form.label63.Text = sql.ToString();
            var conn = DbWalker.GetConnection(Resources.Server, Resources.User, Resources.Password, Resources.secure, "CPS" + Resources.Cech);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(@"Конструктор" + ex.Message);
                //return;
            }
            var command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            try
            {
                icam_CPA = (int)reader["CPA"]; form.label18.Text = icam_CPA.ToString();
                icam_CEJ = (int)reader["CEJ"]; form.label21.Text = icam_CEJ.ToString();
                double total_pr_hour = Math.Round((Convert.ToDouble(icam_CEJ) * 100 / icam_CPA), 2); form.label22.Text = total_pr_hour.ToString();
                icam_c1 = (int)reader["c1"];
                icam_c2 = (int)reader["c2"];
                icam_c3 = (int)reader["c3"];
                icam_c4 = (int)reader["c4"];
                icam_c5 = (int)reader["c5"];
                icam_c82 = (int)reader["c82"];
                icam_c91 = (int)reader["c91"];
                form.label135.Text = icam_c91.ToString();
                double pr_icam_visio = Math.Round((Convert.ToDouble(icam_c91) * 100 / icam_CPA), 2); form.label181.Text = pr_icam_visio.ToString();
                icam_c51 = (int)reader["c51"];
                icam_c52 = (int)reader["c52"];
                icam_c53 = (int)reader["c53"];
                icam_c96 = (int)reader["c96"]; form.label159.Text = icam_c96.ToString();
                icam_c97 = (int)reader["c97"]; form.label173.Text = icam_c97.ToString();
                icam_c98 = (int)reader["c98"]; form.label174.Text = icam_c98.ToString();
                icam_c93 = (int)reader["c93"]; form.label175.Text = icam_c93.ToString();
                icam_c94 = (int)reader["c94"]; form.label176.Text = icam_c94.ToString();
                form.label149.Text = icam_c82.ToString();
                double pr_icam_geom = Math.Round((Convert.ToDouble(icam_c82) * 100 / icam_CPA), 2); form.label182.Text = pr_icam_geom.ToString();
                int oval = icam_c51 + icam_c52 + icam_c53; form.label150.Text = oval.ToString();

                #region Засветка зон с браками
                if (icam_c91 > 0)
                {
                    form.label135.BackColor = Color.Orange; form.label134.BackColor = Color.Orange;
                }
                else
                {
                    form.label135.BackColor = Color.Honeydew; form.label134.BackColor = Color.Honeydew;
                }
                if (oval > 0)
                {
                    form.label150.BackColor = Color.Orange; form.label148.BackColor = Color.Orange;
                }
                else
                {
                    form.label150.BackColor = Color.Honeydew; form.label148.BackColor = Color.Honeydew;
                }
                if (icam_c96 > 0)
                {
                    form.label147.BackColor = Color.Orange; form.label159.BackColor = Color.Orange;
                }
                else
                {
                    form.label147.BackColor = Color.Honeydew; form.label159.BackColor = Color.Honeydew;
                }
                if (icam_c97 > 0)
                {
                    form.label146.BackColor = Color.Orange; form.label173.BackColor = Color.Orange;
                }
                else
                {
                    form.label146.BackColor = Color.Honeydew; form.label173.BackColor = Color.Honeydew;
                }
                if (icam_c98 > 0)
                {
                    form.label174.BackColor = Color.Orange; form.label136.BackColor = Color.Orange;
                }
                else
                {
                    form.label174.BackColor = Color.Honeydew; form.label136.BackColor = Color.Honeydew;
                }
                if (icam_c93 > 0)
                {
                    form.label175.BackColor = Color.Orange; form.label180.BackColor = Color.Orange;
                }
                else
                {
                    form.label175.BackColor = Color.Honeydew; form.label180.BackColor = Color.Honeydew;
                }
                if (icam_c94 > 0)
                {
                    form.label176.BackColor = Color.Orange; form.label179.BackColor = Color.Orange;
                }
                else
                {
                    form.label176.BackColor = Color.Honeydew; form.label179.BackColor = Color.Honeydew;
                }

                #endregion
            }
            catch
            {
                form.label135.Text = "0"; form.label159.Text = "0"; form.label173.Text = "0"; form.label174.Text = "0"; form.label175.Text = "0"; form.label176.Text = "0";
                form.label22.Text = "0"; form.label182.Text = "0"; form.label149.Text = "0"; form.label181.Text = "0"; form.label21.Text = "0"; form.label18.Text = "0"; form.label150.Text = "0";
            }

        }
        #endregion

        private void unvisible_icam()
        {
            form.label135.Visible = false; form.label134.Visible = false; form.label181.Visible = false; form.label148.Visible = false;
            form.label34.Visible = false; form.label182.Visible = false; form.label148.Visible = false; form.label150.Visible = false; form.label178.Visible = false;
            form.label147.Visible = false; form.label159.Visible = false; form.label146.Visible = false; form.label173.Visible = false; form.label103.Visible = false;
            form.label136.Visible = false; form.label174.Visible = false; form.label180.Visible = false; form.label175.Visible = false;
            form.label176.Visible = false; form.label179.Visible = false; form.label149.Visible = false; form.label178.Visible = false;
        }

        private void unvisible_mcal()
        {
            form.label34.Visible = false; form.label56.Visible = false; form.label61.Visible = false;
            form.label31.Visible = false; form.label65.Visible = false; form.label73.Visible = false; form.label38.Visible = false; form.label64.Visible = false;
            form.label36.Visible = false; form.label62.Visible = false; form.label39.Visible = false; form.label41.Visible = false; form.label42.Visible = false;
            form.label44.Visible = false; form.label47.Visible = false; form.label49.Visible = false; form.label50.Visible = false; form.label64.Visible = false;
            form.label61.Visible = false; form.label71.Visible = false; form.label70.Visible = false; form.label68.Visible = false; form.label67.Visible = false;
            form.label59.Visible = false; form.label58.Visible = false; form.label52.Visible = false; form.label79.Visible = false; form.label81.Visible = false;
            form.label53.Visible = false; form.label168.Visible = false; form.label55.Visible = false; form.label76.Visible = false; form.label74.Visible = false;
            form.label167.Visible = false; form.label56.Visible = false;
        }

        #region Вызов окон по статистике
        //Вызов окон по статистике
        private void label160_Click(object sender, EventArgs e)
        {
            call_stat("Deffect_213", DT1);
        }
        private void label157_Click(object sender, EventArgs e)
        {
            call_stat("Deffect_414", DT1);
        }

        private void label158_Click(object sender, EventArgs e)
        {
            call_stat("Deffect_219", DT1);
        }

        private void label156_Click(object sender, EventArgs e)
        {
            call_stat("Deffect_220", DT1);
        }
        private void label155_Click(object sender, EventArgs e)
        {
            call_stat("Deffect_024_1", DT1);
        }
        private void label154_Click(object sender, EventArgs e)
        {
            call_stat("Deffect_024_3", DT1);
        }
        private void label153_Click(object sender, EventArgs e)
        {
            call_stat("Deffect_024_5", DT1);
        }
        private void label152_Click(object sender, EventArgs e)
        {
            call_stat("Deffect_024_14", DT1);
        }
        private void label151_Click(object sender, EventArgs e)
        {
            call_stat("CES", DT1);
        }

        //вызов окна статистики по М1
        void call_stat(string code_deffect, DateTime DT1)
        {
            var m1_stat = new M1_statistics(code_deffect, DT1);
            m1_stat.ShowDialog();
        }

        #endregion
    }
}
