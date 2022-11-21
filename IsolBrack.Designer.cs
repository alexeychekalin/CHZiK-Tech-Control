
namespace WinFormsApp1
{
    partial class IsolBrack
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
            this.line = new MaterialSkin.Controls.MaterialComboBox();
            this.palletNumber = new MaterialSkin.Controls.MaterialTextBox2();
            this.smena = new MaterialSkin.Controls.MaterialComboBox();
            this.assortment = new MaterialSkin.Controls.MaterialComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.count = new MaterialSkin.Controls.MaterialTextBox2();
            this.formNumber = new MaterialSkin.Controls.MaterialTextBox2();
            this.deffectNumber = new MaterialSkin.Controls.MaterialComboBox();
            this.whereDeffect = new MaterialSkin.Controls.MaterialComboBox();
            this.brackInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save = new MaterialSkin.Controls.MaterialButton();
            this.isolAddBrack = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.brackInfo)).BeginInit();
            this.SuspendLayout();
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
            this.line.Location = new System.Drawing.Point(25, 58);
            this.line.MaxDropDownItems = 4;
            this.line.MouseState = MaterialSkin.MouseState.OUT;
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(193, 49);
            this.line.StartIndex = 0;
            this.line.TabIndex = 5;
            // 
            // palletNumber
            // 
            this.palletNumber.AnimateReadOnly = false;
            this.palletNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.palletNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.palletNumber.Depth = 0;
            this.palletNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.palletNumber.HideSelection = true;
            this.palletNumber.Hint = "Номер паллета";
            this.palletNumber.LeadingIcon = null;
            this.palletNumber.Location = new System.Drawing.Point(243, 129);
            this.palletNumber.MaxLength = 32767;
            this.palletNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.palletNumber.Name = "palletNumber";
            this.palletNumber.PasswordChar = '\0';
            this.palletNumber.PrefixSuffixText = null;
            this.palletNumber.ReadOnly = false;
            this.palletNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.palletNumber.SelectedText = "";
            this.palletNumber.SelectionLength = 0;
            this.palletNumber.SelectionStart = 0;
            this.palletNumber.ShortcutsEnabled = true;
            this.palletNumber.Size = new System.Drawing.Size(193, 48);
            this.palletNumber.TabIndex = 4;
            this.palletNumber.TabStop = false;
            this.palletNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.palletNumber.TrailingIcon = null;
            this.palletNumber.UseSystemPasswordChar = false;
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
            this.smena.Location = new System.Drawing.Point(243, 58);
            this.smena.MaxDropDownItems = 4;
            this.smena.MouseState = MaterialSkin.MouseState.OUT;
            this.smena.Name = "smena";
            this.smena.Size = new System.Drawing.Size(193, 49);
            this.smena.StartIndex = 0;
            this.smena.TabIndex = 5;
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
            this.assortment.Location = new System.Drawing.Point(462, 58);
            this.assortment.MaxDropDownItems = 4;
            this.assortment.MouseState = MaterialSkin.MouseState.OUT;
            this.assortment.Name = "assortment";
            this.assortment.Size = new System.Drawing.Size(193, 49);
            this.assortment.StartIndex = 0;
            this.assortment.TabIndex = 5;
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.Location = new System.Drawing.Point(25, 127);
            this.date.MinimumSize = new System.Drawing.Size(0, 48);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(193, 48);
            this.date.TabIndex = 6;
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
            this.count.Location = new System.Drawing.Point(462, 129);
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
            this.count.TabIndex = 4;
            this.count.TabStop = false;
            this.count.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.count.TrailingIcon = null;
            this.count.UseSystemPasswordChar = false;
            // 
            // formNumber
            // 
            this.formNumber.AnimateReadOnly = false;
            this.formNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.formNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.formNumber.Depth = 0;
            this.formNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.formNumber.HideSelection = true;
            this.formNumber.Hint = "Номер формы";
            this.formNumber.LeadingIcon = null;
            this.formNumber.Location = new System.Drawing.Point(25, 199);
            this.formNumber.MaxLength = 32767;
            this.formNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.formNumber.Name = "formNumber";
            this.formNumber.PasswordChar = '\0';
            this.formNumber.PrefixSuffixText = null;
            this.formNumber.ReadOnly = false;
            this.formNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.formNumber.SelectedText = "";
            this.formNumber.SelectionLength = 0;
            this.formNumber.SelectionStart = 0;
            this.formNumber.ShortcutsEnabled = true;
            this.formNumber.Size = new System.Drawing.Size(193, 48);
            this.formNumber.TabIndex = 4;
            this.formNumber.TabStop = false;
            this.formNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.formNumber.TrailingIcon = null;
            this.formNumber.UseSystemPasswordChar = false;
            // 
            // deffectNumber
            // 
            this.deffectNumber.AutoResize = false;
            this.deffectNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deffectNumber.Depth = 0;
            this.deffectNumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.deffectNumber.DropDownHeight = 174;
            this.deffectNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deffectNumber.DropDownWidth = 121;
            this.deffectNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.deffectNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deffectNumber.FormattingEnabled = true;
            this.deffectNumber.Hint = "Номер дефекта";
            this.deffectNumber.IntegralHeight = false;
            this.deffectNumber.ItemHeight = 43;
            this.deffectNumber.Location = new System.Drawing.Point(243, 198);
            this.deffectNumber.MaxDropDownItems = 4;
            this.deffectNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.deffectNumber.Name = "deffectNumber";
            this.deffectNumber.Size = new System.Drawing.Size(193, 49);
            this.deffectNumber.StartIndex = 0;
            this.deffectNumber.TabIndex = 5;
            // 
            // whereDeffect
            // 
            this.whereDeffect.AutoResize = false;
            this.whereDeffect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.whereDeffect.Depth = 0;
            this.whereDeffect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.whereDeffect.DropDownHeight = 174;
            this.whereDeffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.whereDeffect.DropDownWidth = 121;
            this.whereDeffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.whereDeffect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.whereDeffect.FormattingEnabled = true;
            this.whereDeffect.Hint = "Расположение дефекта";
            this.whereDeffect.IntegralHeight = false;
            this.whereDeffect.ItemHeight = 43;
            this.whereDeffect.Location = new System.Drawing.Point(462, 199);
            this.whereDeffect.MaxDropDownItems = 4;
            this.whereDeffect.MouseState = MaterialSkin.MouseState.OUT;
            this.whereDeffect.Name = "whereDeffect";
            this.whereDeffect.Size = new System.Drawing.Size(193, 49);
            this.whereDeffect.StartIndex = 0;
            this.whereDeffect.TabIndex = 5;
            // 
            // brackInfo
            // 
            this.brackInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.brackInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brackInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn24,
            this.Column1});
            this.brackInfo.Location = new System.Drawing.Point(25, 279);
            this.brackInfo.Name = "brackInfo";
            this.brackInfo.RowTemplate.Height = 25;
            this.brackInfo.Size = new System.Drawing.Size(630, 363);
            this.brackInfo.TabIndex = 8;
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
            // save
            // 
            this.save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.save.Depth = 0;
            this.save.HighEmphasis = true;
            this.save.Icon = null;
            this.save.Location = new System.Drawing.Point(554, 662);
            this.save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.save.MouseState = MaterialSkin.MouseState.HOVER;
            this.save.Name = "save";
            this.save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.save.Size = new System.Drawing.Size(101, 36);
            this.save.TabIndex = 9;
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
            this.isolAddBrack.Location = new System.Drawing.Point(439, 662);
            this.isolAddBrack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.isolAddBrack.MouseState = MaterialSkin.MouseState.HOVER;
            this.isolAddBrack.Name = "isolAddBrack";
            this.isolAddBrack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.isolAddBrack.Size = new System.Drawing.Size(82, 36);
            this.isolAddBrack.TabIndex = 10;
            this.isolAddBrack.Text = "Отмена";
            this.isolAddBrack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.isolAddBrack.UseAccentColor = false;
            this.isolAddBrack.UseVisualStyleBackColor = true;
            this.isolAddBrack.Click += new System.EventHandler(this.isolAddBrack_Click);
            // 
            // IsolBrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 714);
            this.Controls.Add(this.save);
            this.Controls.Add(this.isolAddBrack);
            this.Controls.Add(this.brackInfo);
            this.Controls.Add(this.date);
            this.Controls.Add(this.assortment);
            this.Controls.Add(this.whereDeffect);
            this.Controls.Add(this.deffectNumber);
            this.Controls.Add(this.smena);
            this.Controls.Add(this.line);
            this.Controls.Add(this.formNumber);
            this.Controls.Add(this.count);
            this.Controls.Add(this.palletNumber);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "IsolBrack";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изолятор брака";
            ((System.ComponentModel.ISupportInitialize)(this.brackInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox line;
        private MaterialSkin.Controls.MaterialTextBox2 palletNumber;
        private MaterialSkin.Controls.MaterialComboBox smena;
        private MaterialSkin.Controls.MaterialComboBox assortment;
        private System.Windows.Forms.DateTimePicker date;
        private MaterialSkin.Controls.MaterialTextBox2 count;
        private MaterialSkin.Controls.MaterialTextBox2 formNumber;
        private MaterialSkin.Controls.MaterialComboBox deffectNumber;
        private MaterialSkin.Controls.MaterialComboBox whereDeffect;
        private System.Windows.Forms.DataGridView brackInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private MaterialSkin.Controls.MaterialButton save;
        private MaterialSkin.Controls.MaterialButton isolAddBrack;
    }
}