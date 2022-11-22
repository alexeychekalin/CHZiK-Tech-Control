
namespace WinFormsApp1
{
    partial class NotFinish
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
            this.save = new MaterialSkin.Controls.MaterialButton();
            this.isolAddBrack = new MaterialSkin.Controls.MaterialButton();
            this.brackInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.assortment = new MaterialSkin.Controls.MaterialComboBox();
            this.smena = new MaterialSkin.Controls.MaterialComboBox();
            this.line = new MaterialSkin.Controls.MaterialComboBox();
            this.countPallet = new MaterialSkin.Controls.MaterialTextBox2();
            this.count = new MaterialSkin.Controls.MaterialTextBox2();
            this.talon = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.brackInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.save.Depth = 0;
            this.save.HighEmphasis = true;
            this.save.Icon = null;
            this.save.Location = new System.Drawing.Point(547, 638);
            this.save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.save.MouseState = MaterialSkin.MouseState.HOVER;
            this.save.Name = "save";
            this.save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.save.Size = new System.Drawing.Size(64, 36);
            this.save.TabIndex = 21;
            this.save.Text = "ОК";
            this.save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.save.UseAccentColor = false;
            this.save.UseVisualStyleBackColor = true;
            // 
            // isolAddBrack
            // 
            this.isolAddBrack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.isolAddBrack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.isolAddBrack.Depth = 0;
            this.isolAddBrack.HighEmphasis = true;
            this.isolAddBrack.Icon = null;
            this.isolAddBrack.Location = new System.Drawing.Point(432, 638);
            this.isolAddBrack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.isolAddBrack.MouseState = MaterialSkin.MouseState.HOVER;
            this.isolAddBrack.Name = "isolAddBrack";
            this.isolAddBrack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.isolAddBrack.Size = new System.Drawing.Size(82, 36);
            this.isolAddBrack.TabIndex = 22;
            this.isolAddBrack.Text = "Отмена";
            this.isolAddBrack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.isolAddBrack.UseAccentColor = false;
            this.isolAddBrack.UseVisualStyleBackColor = true;
            this.isolAddBrack.Click += new System.EventHandler(this.isolAddBrack_Click);
            // 
            // brackInfo
            // 
            this.brackInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.brackInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brackInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn24,
            this.Column1});
            this.brackInfo.Location = new System.Drawing.Point(18, 255);
            this.brackInfo.Name = "brackInfo";
            this.brackInfo.RowTemplate.Height = 25;
            this.brackInfo.Size = new System.Drawing.Size(630, 363);
            this.brackInfo.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "Форма";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.HeaderText = "Дефект";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Место";
            this.Column1.Name = "Column1";
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.Location = new System.Drawing.Point(18, 103);
            this.date.MinimumSize = new System.Drawing.Size(4, 48);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(193, 48);
            this.date.TabIndex = 19;
            // 
            // assortment
            // 
            this.assortment.AutoResize = false;
            this.assortment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.assortment.Depth = 0;
            this.assortment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.assortment.DropDownHeight = 174;
            this.assortment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assortment.DropDownWidth = 121;
            this.assortment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.assortment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.assortment.FormattingEnabled = true;
            this.assortment.Hint = "Ассортимент";
            this.assortment.IntegralHeight = false;
            this.assortment.ItemHeight = 43;
            this.assortment.Location = new System.Drawing.Point(455, 34);
            this.assortment.MaxDropDownItems = 4;
            this.assortment.MouseState = MaterialSkin.MouseState.OUT;
            this.assortment.Name = "assortment";
            this.assortment.Size = new System.Drawing.Size(193, 49);
            this.assortment.StartIndex = 0;
            this.assortment.TabIndex = 14;
            // 
            // smena
            // 
            this.smena.AutoResize = false;
            this.smena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.smena.Depth = 0;
            this.smena.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.smena.DropDownHeight = 174;
            this.smena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smena.DropDownWidth = 121;
            this.smena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.smena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.smena.FormattingEnabled = true;
            this.smena.Hint = "Смена";
            this.smena.IntegralHeight = false;
            this.smena.ItemHeight = 43;
            this.smena.Items.AddRange(new object[] {
            "Смена 1",
            "Смена 2",
            "Смена 3",
            "Смена 4"});
            this.smena.Location = new System.Drawing.Point(236, 34);
            this.smena.MaxDropDownItems = 4;
            this.smena.MouseState = MaterialSkin.MouseState.OUT;
            this.smena.Name = "smena";
            this.smena.Size = new System.Drawing.Size(193, 49);
            this.smena.StartIndex = 0;
            this.smena.TabIndex = 17;
            // 
            // line
            // 
            this.line.AutoResize = false;
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line.Depth = 0;
            this.line.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.line.DropDownHeight = 174;
            this.line.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.line.DropDownWidth = 121;
            this.line.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.line.FormattingEnabled = true;
            this.line.Hint = "Линия";
            this.line.IntegralHeight = false;
            this.line.ItemHeight = 43;
            this.line.Items.AddRange(new object[] {
            "Линия 1",
            "Линия 2",
            "Линия 3"});
            this.line.Location = new System.Drawing.Point(18, 34);
            this.line.MaxDropDownItems = 4;
            this.line.MouseState = MaterialSkin.MouseState.OUT;
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(193, 49);
            this.line.StartIndex = 0;
            this.line.TabIndex = 18;
            // 
            // countPallet
            // 
            this.countPallet.AnimateReadOnly = false;
            this.countPallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.countPallet.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.countPallet.Depth = 0;
            this.countPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.countPallet.HideSelection = true;
            this.countPallet.Hint = "Количество в паллете";
            this.countPallet.LeadingIcon = null;
            this.countPallet.Location = new System.Drawing.Point(18, 175);
            this.countPallet.MaxLength = 32767;
            this.countPallet.MouseState = MaterialSkin.MouseState.OUT;
            this.countPallet.Name = "countPallet";
            this.countPallet.PasswordChar = '\0';
            this.countPallet.PrefixSuffixText = null;
            this.countPallet.ReadOnly = false;
            this.countPallet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.countPallet.SelectedText = "";
            this.countPallet.SelectionLength = 0;
            this.countPallet.SelectionStart = 0;
            this.countPallet.ShortcutsEnabled = true;
            this.countPallet.Size = new System.Drawing.Size(193, 48);
            this.countPallet.TabIndex = 11;
            this.countPallet.TabStop = false;
            this.countPallet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.countPallet.TrailingIcon = null;
            this.countPallet.UseSystemPasswordChar = false;
            // 
            // count
            // 
            this.count.AnimateReadOnly = false;
            this.count.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.count.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.count.Depth = 0;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.count.HideSelection = true;
            this.count.Hint = "Количесво изделий";
            this.count.LeadingIcon = null;
            this.count.Location = new System.Drawing.Point(455, 105);
            this.count.MaxLength = 32767;
            this.count.MouseState = MaterialSkin.MouseState.OUT;
            this.count.Name = "count";
            this.count.PasswordChar = '\0';
            this.count.PrefixSuffixText = null;
            this.count.ReadOnly = false;
            this.count.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.count.SelectedText = "";
            this.count.SelectionLength = 0;
            this.count.SelectionStart = 0;
            this.count.ShortcutsEnabled = true;
            this.count.Size = new System.Drawing.Size(193, 48);
            this.count.TabIndex = 12;
            this.count.TabStop = false;
            this.count.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.count.TrailingIcon = null;
            this.count.UseSystemPasswordChar = false;
            // 
            // talon
            // 
            this.talon.AnimateReadOnly = false;
            this.talon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.talon.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.talon.Depth = 0;
            this.talon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.talon.HideSelection = true;
            this.talon.Hint = "Номер талона";
            this.talon.LeadingIcon = null;
            this.talon.Location = new System.Drawing.Point(236, 105);
            this.talon.MaxLength = 32767;
            this.talon.MouseState = MaterialSkin.MouseState.OUT;
            this.talon.Name = "talon";
            this.talon.PasswordChar = '\0';
            this.talon.PrefixSuffixText = null;
            this.talon.ReadOnly = false;
            this.talon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.talon.SelectedText = "";
            this.talon.SelectionLength = 0;
            this.talon.SelectionStart = 0;
            this.talon.ShortcutsEnabled = true;
            this.talon.Size = new System.Drawing.Size(193, 48);
            this.talon.TabIndex = 13;
            this.talon.TabStop = false;
            this.talon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.talon.TrailingIcon = null;
            this.talon.UseSystemPasswordChar = false;
            // 
            // NotFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 698);
            this.Controls.Add(this.save);
            this.Controls.Add(this.isolAddBrack);
            this.Controls.Add(this.brackInfo);
            this.Controls.Add(this.date);
            this.Controls.Add(this.assortment);
            this.Controls.Add(this.smena);
            this.Controls.Add(this.line);
            this.Controls.Add(this.countPallet);
            this.Controls.Add(this.count);
            this.Controls.Add(this.talon);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "NotFinish";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotFinish";
            ((System.ComponentModel.ISupportInitialize)(this.brackInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton save;
        private MaterialSkin.Controls.MaterialButton isolAddBrack;
        private System.Windows.Forms.DataGridView brackInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DateTimePicker date;
        private MaterialSkin.Controls.MaterialComboBox assortment;
        private MaterialSkin.Controls.MaterialComboBox smena;
        private MaterialSkin.Controls.MaterialComboBox line;
        private MaterialSkin.Controls.MaterialTextBox2 countPallet;
        private MaterialSkin.Controls.MaterialTextBox2 count;
        private MaterialSkin.Controls.MaterialTextBox2 talon;
    }
}