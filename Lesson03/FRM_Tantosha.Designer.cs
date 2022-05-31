namespace Lesson03
{
    partial class FRM_Tantosha
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_Close = new System.Windows.Forms.Button();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_ChangeInput = new System.Windows.Forms.Button();
            this.BT_NewInput = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CHB_Kanrishafuragu = new System.Windows.Forms.CheckBox();
            this.CHB_Taishafuragu = new System.Windows.Forms.CheckBox();
            this.DTP_Taisha = new System.Windows.Forms.DateTimePicker();
            this.DGV_Kotei = new System.Windows.Forms.DataGridView();
            this.CheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Kotei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CKotei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CB_KyotenName = new System.Windows.Forms.ComboBox();
            this.TB_BumonCode = new System.Windows.Forms.TextBox();
            this.TB_BumonName = new System.Windows.Forms.TextBox();
            this.TB_TTSMail = new System.Windows.Forms.TextBox();
            this.TB_Sname2 = new System.Windows.Forms.TextBox();
            this.TB_Sname = new System.Windows.Forms.TextBox();
            this.TB_TTSkana = new System.Windows.Forms.TextBox();
            this.TB_TTSname = new System.Windows.Forms.TextBox();
            this.TB_PWD = new System.Windows.Forms.TextBox();
            this.TB_TTSJidoCode = new System.Windows.Forms.TextBox();
            this.BT_JidoCode = new System.Windows.Forms.Button();
            this.LB_Kanrishafuragu = new System.Windows.Forms.Label();
            this.LB_Taishafuragu = new System.Windows.Forms.Label();
            this.LB_Taishanengappi = new System.Windows.Forms.Label();
            this.BT_Bumoncode = new System.Windows.Forms.Button();
            this.LB_Kotei = new System.Windows.Forms.Label();
            this.LB_KyotenName = new System.Windows.Forms.Label();
            this.LB_TTSMail = new System.Windows.Forms.Label();
            this.LB_Sname2 = new System.Windows.Forms.Label();
            this.LB_TTSsname = new System.Windows.Forms.Label();
            this.LB_TTSkana = new System.Windows.Forms.Label();
            this.LB_TTSname = new System.Windows.Forms.Label();
            this.LB_PWD = new System.Windows.Forms.Label();
            this.LB_TTScode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Kotei)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BT_Close);
            this.panel1.Controls.Add(this.BT_Delete);
            this.panel1.Controls.Add(this.BT_Cancel);
            this.panel1.Controls.Add(this.BT_Save);
            this.panel1.Controls.Add(this.BT_ChangeInput);
            this.panel1.Controls.Add(this.BT_NewInput);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 68);
            this.panel1.TabIndex = 0;
            // 
            // BT_Close
            // 
            this.BT_Close.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Close.Location = new System.Drawing.Point(979, 11);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(91, 44);
            this.BT_Close.TabIndex = 5;
            this.BT_Close.Text = "閉じる";
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // BT_Delete
            // 
            this.BT_Delete.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Delete.Location = new System.Drawing.Point(562, 11);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(91, 44);
            this.BT_Delete.TabIndex = 4;
            this.BT_Delete.Text = "削除";
            this.BT_Delete.UseVisualStyleBackColor = true;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Enabled = false;
            this.BT_Cancel.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Cancel.Location = new System.Drawing.Point(385, 11);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(91, 44);
            this.BT_Cancel.TabIndex = 3;
            this.BT_Cancel.Text = "取消";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.Enabled = false;
            this.BT_Save.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Save.Location = new System.Drawing.Point(287, 11);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(91, 44);
            this.BT_Save.TabIndex = 2;
            this.BT_Save.Text = "保存";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // BT_ChangeInput
            // 
            this.BT_ChangeInput.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_ChangeInput.Location = new System.Drawing.Point(110, 11);
            this.BT_ChangeInput.Name = "BT_ChangeInput";
            this.BT_ChangeInput.Size = new System.Drawing.Size(91, 44);
            this.BT_ChangeInput.TabIndex = 1;
            this.BT_ChangeInput.Text = "変更入力";
            this.BT_ChangeInput.UseVisualStyleBackColor = true;
            this.BT_ChangeInput.Click += new System.EventHandler(this.BT_ChangeInput_Click);
            // 
            // BT_NewInput
            // 
            this.BT_NewInput.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_NewInput.Location = new System.Drawing.Point(12, 11);
            this.BT_NewInput.Name = "BT_NewInput";
            this.BT_NewInput.Size = new System.Drawing.Size(91, 44);
            this.BT_NewInput.TabIndex = 0;
            this.BT_NewInput.Text = "新規入力";
            this.BT_NewInput.UseVisualStyleBackColor = true;
            this.BT_NewInput.Click += new System.EventHandler(this.BT_NewInput_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(396, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 69);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(176, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "入力画面";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CHB_Kanrishafuragu);
            this.panel3.Controls.Add(this.CHB_Taishafuragu);
            this.panel3.Controls.Add(this.DTP_Taisha);
            this.panel3.Controls.Add(this.DGV_Kotei);
            this.panel3.Controls.Add(this.CB_KyotenName);
            this.panel3.Controls.Add(this.TB_BumonCode);
            this.panel3.Controls.Add(this.TB_BumonName);
            this.panel3.Controls.Add(this.TB_TTSMail);
            this.panel3.Controls.Add(this.TB_Sname2);
            this.panel3.Controls.Add(this.TB_Sname);
            this.panel3.Controls.Add(this.TB_TTSkana);
            this.panel3.Controls.Add(this.TB_TTSname);
            this.panel3.Controls.Add(this.TB_PWD);
            this.panel3.Controls.Add(this.TB_TTSJidoCode);
            this.panel3.Controls.Add(this.BT_JidoCode);
            this.panel3.Controls.Add(this.LB_Kanrishafuragu);
            this.panel3.Controls.Add(this.LB_Taishafuragu);
            this.panel3.Controls.Add(this.LB_Taishanengappi);
            this.panel3.Controls.Add(this.BT_Bumoncode);
            this.panel3.Controls.Add(this.LB_Kotei);
            this.panel3.Controls.Add(this.LB_KyotenName);
            this.panel3.Controls.Add(this.LB_TTSMail);
            this.panel3.Controls.Add(this.LB_Sname2);
            this.panel3.Controls.Add(this.LB_TTSsname);
            this.panel3.Controls.Add(this.LB_TTSkana);
            this.panel3.Controls.Add(this.LB_TTSname);
            this.panel3.Controls.Add(this.LB_PWD);
            this.panel3.Controls.Add(this.LB_TTScode);
            this.panel3.Location = new System.Drawing.Point(396, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 454);
            this.panel3.TabIndex = 2;
            // 
            // CHB_Kanrishafuragu
            // 
            this.CHB_Kanrishafuragu.AutoSize = true;
            this.CHB_Kanrishafuragu.Enabled = false;
            this.CHB_Kanrishafuragu.Location = new System.Drawing.Point(106, 420);
            this.CHB_Kanrishafuragu.Name = "CHB_Kanrishafuragu";
            this.CHB_Kanrishafuragu.Size = new System.Drawing.Size(15, 14);
            this.CHB_Kanrishafuragu.TabIndex = 28;
            this.CHB_Kanrishafuragu.UseVisualStyleBackColor = true;
            this.CHB_Kanrishafuragu.CheckedChanged += new System.EventHandler(this.CHB_Kanrishafuragu_CheckedChanged);
            // 
            // CHB_Taishafuragu
            // 
            this.CHB_Taishafuragu.AutoSize = true;
            this.CHB_Taishafuragu.Enabled = false;
            this.CHB_Taishafuragu.Location = new System.Drawing.Point(106, 395);
            this.CHB_Taishafuragu.Name = "CHB_Taishafuragu";
            this.CHB_Taishafuragu.Size = new System.Drawing.Size(48, 16);
            this.CHB_Taishafuragu.TabIndex = 27;
            this.CHB_Taishafuragu.Text = "退社";
            this.CHB_Taishafuragu.UseVisualStyleBackColor = true;
            this.CHB_Taishafuragu.CheckedChanged += new System.EventHandler(this.CHB_Taishafuragu_CheckedChanged);
            // 
            // DTP_Taisha
            // 
            this.DTP_Taisha.AllowDrop = true;
            this.DTP_Taisha.Checked = false;
            this.DTP_Taisha.CustomFormat = "____/__/__";
            this.DTP_Taisha.Enabled = false;
            this.DTP_Taisha.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DTP_Taisha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Taisha.Location = new System.Drawing.Point(106, 366);
            this.DTP_Taisha.Name = "DTP_Taisha";
            this.DTP_Taisha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DTP_Taisha.RightToLeftLayout = true;
            this.DTP_Taisha.Size = new System.Drawing.Size(84, 19);
            this.DTP_Taisha.TabIndex = 26;
            this.DTP_Taisha.Value = new System.DateTime(2019, 4, 11, 0, 0, 0, 0);
            this.DTP_Taisha.ValueChanged += new System.EventHandler(this.DTP_Taisha_ValueChanged);
            this.DTP_Taisha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DTP_Taisha_KeyDown);
            // 
            // DGV_Kotei
            // 
            this.DGV_Kotei.AllowUserToAddRows = false;
            this.DGV_Kotei.AllowUserToDeleteRows = false;
            this.DGV_Kotei.AllowUserToResizeColumns = false;
            this.DGV_Kotei.AllowUserToResizeRows = false;
            this.DGV_Kotei.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Kotei.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Kotei.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Kotei.ColumnHeadersVisible = false;
            this.DGV_Kotei.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxColumn,
            this.Kotei,
            this.CKotei});
            this.DGV_Kotei.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Kotei.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Kotei.Enabled = false;
            this.DGV_Kotei.GridColor = System.Drawing.Color.LightGray;
            this.DGV_Kotei.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGV_Kotei.Location = new System.Drawing.Point(106, 214);
            this.DGV_Kotei.MultiSelect = false;
            this.DGV_Kotei.Name = "DGV_Kotei";
            this.DGV_Kotei.RowHeadersVisible = false;
            this.DGV_Kotei.RowHeadersWidth = 15;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Kotei.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Kotei.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DGV_Kotei.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DGV_Kotei.RowTemplate.Height = 20;
            this.DGV_Kotei.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Kotei.Size = new System.Drawing.Size(183, 146);
            this.DGV_Kotei.TabIndex = 25;
            this.DGV_Kotei.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Kotei_CellValueChanged);
            this.DGV_Kotei.CurrentCellChanged += new System.EventHandler(this.DGV_Kotei_CurrentCellChanged);
            this.DGV_Kotei.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGV_Kotei_RowPostPaint);
            // 
            // CheckBoxColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.CheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.CheckBoxColumn.HeaderText = "Column1";
            this.CheckBoxColumn.Name = "CheckBoxColumn";
            this.CheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckBoxColumn.Width = 20;
            // 
            // Kotei
            // 
            this.Kotei.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.Kotei.DefaultCellStyle = dataGridViewCellStyle3;
            this.Kotei.HeaderText = "Column1";
            this.Kotei.Name = "Kotei";
            this.Kotei.ReadOnly = true;
            this.Kotei.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CKotei
            // 
            this.CKotei.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CKotei.HeaderText = "Column1";
            this.CKotei.Name = "CKotei";
            this.CKotei.Visible = false;
            this.CKotei.Width = 5;
            // 
            // CB_KyotenName
            // 
            this.CB_KyotenName.BackColor = System.Drawing.SystemColors.Window;
            this.CB_KyotenName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_KyotenName.Enabled = false;
            this.CB_KyotenName.FormattingEnabled = true;
            this.CB_KyotenName.Location = new System.Drawing.Point(106, 162);
            this.CB_KyotenName.Name = "CB_KyotenName";
            this.CB_KyotenName.Size = new System.Drawing.Size(307, 20);
            this.CB_KyotenName.TabIndex = 24;
            this.CB_KyotenName.SelectedIndexChanged += new System.EventHandler(this.CB_KyotenName_SelectedIndexChanged);
            // 
            // TB_BumonCode
            // 
            this.TB_BumonCode.Enabled = false;
            this.TB_BumonCode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TB_BumonCode.Location = new System.Drawing.Point(106, 189);
            this.TB_BumonCode.MaxLength = 2;
            this.TB_BumonCode.Name = "TB_BumonCode";
            this.TB_BumonCode.Size = new System.Drawing.Size(18, 19);
            this.TB_BumonCode.TabIndex = 23;
            this.TB_BumonCode.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_BumonCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_KeyDown);
            this.TB_BumonCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            this.TB_BumonCode.Leave += new System.EventHandler(this.TB_BumonCode_Leave);
            this.TB_BumonCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TB_MouseDown);
            // 
            // TB_BumonName
            // 
            this.TB_BumonName.Enabled = false;
            this.TB_BumonName.Location = new System.Drawing.Point(130, 189);
            this.TB_BumonName.Name = "TB_BumonName";
            this.TB_BumonName.Size = new System.Drawing.Size(283, 19);
            this.TB_BumonName.TabIndex = 22;
            // 
            // TB_TTSMail
            // 
            this.TB_TTSMail.Enabled = false;
            this.TB_TTSMail.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.TB_TTSMail.Location = new System.Drawing.Point(106, 137);
            this.TB_TTSMail.MaxLength = 50;
            this.TB_TTSMail.Name = "TB_TTSMail";
            this.TB_TTSMail.Size = new System.Drawing.Size(307, 19);
            this.TB_TTSMail.TabIndex = 21;
            this.TB_TTSMail.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_TTSMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_KeyDown);
            this.TB_TTSMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            this.TB_TTSMail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TB_MouseDown);
            // 
            // TB_Sname2
            // 
            this.TB_Sname2.Enabled = false;
            this.TB_Sname2.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.TB_Sname2.Location = new System.Drawing.Point(352, 112);
            this.TB_Sname2.MaxLength = 4;
            this.TB_Sname2.Name = "TB_Sname2";
            this.TB_Sname2.Size = new System.Drawing.Size(61, 19);
            this.TB_Sname2.TabIndex = 20;
            this.TB_Sname2.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_Sname2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_KeyDown);
            this.TB_Sname2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            this.TB_Sname2.Leave += new System.EventHandler(this.TB_Sname2_Leave);
            this.TB_Sname2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TB_MouseDown);
            // 
            // TB_Sname
            // 
            this.TB_Sname.Enabled = false;
            this.TB_Sname.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.TB_Sname.Location = new System.Drawing.Point(106, 112);
            this.TB_Sname.MaxLength = 10;
            this.TB_Sname.Name = "TB_Sname";
            this.TB_Sname.Size = new System.Drawing.Size(111, 19);
            this.TB_Sname.TabIndex = 19;
            this.TB_Sname.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_Sname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_KeyDown);
            this.TB_Sname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            this.TB_Sname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TB_MouseDown);
            // 
            // TB_TTSkana
            // 
            this.TB_TTSkana.Enabled = false;
            this.TB_TTSkana.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.TB_TTSkana.Location = new System.Drawing.Point(106, 87);
            this.TB_TTSkana.MaxLength = 50;
            this.TB_TTSkana.Name = "TB_TTSkana";
            this.TB_TTSkana.Size = new System.Drawing.Size(307, 19);
            this.TB_TTSkana.TabIndex = 18;
            this.TB_TTSkana.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_TTSkana.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_KeyDown);
            this.TB_TTSkana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            this.TB_TTSkana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TB_MouseDown);
            // 
            // TB_TTSname
            // 
            this.TB_TTSname.BackColor = System.Drawing.SystemColors.Window;
            this.TB_TTSname.Enabled = false;
            this.TB_TTSname.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.TB_TTSname.Location = new System.Drawing.Point(106, 62);
            this.TB_TTSname.MaxLength = 50;
            this.TB_TTSname.Name = "TB_TTSname";
            this.TB_TTSname.Size = new System.Drawing.Size(307, 19);
            this.TB_TTSname.TabIndex = 17;
            this.TB_TTSname.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_TTSname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_KeyDown);
            this.TB_TTSname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            this.TB_TTSname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TB_MouseDown);
            // 
            // TB_PWD
            // 
            this.TB_PWD.Enabled = false;
            this.TB_PWD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TB_PWD.Location = new System.Drawing.Point(106, 37);
            this.TB_PWD.MaxLength = 8;
            this.TB_PWD.Name = "TB_PWD";
            this.TB_PWD.PasswordChar = '●';
            this.TB_PWD.Size = new System.Drawing.Size(111, 19);
            this.TB_PWD.TabIndex = 16;
            this.TB_PWD.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_PWD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_KeyDown);
            this.TB_PWD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            this.TB_PWD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TB_MouseDown);
            // 
            // TB_TTSJidoCode
            // 
            this.TB_TTSJidoCode.Enabled = false;
            this.TB_TTSJidoCode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TB_TTSJidoCode.Location = new System.Drawing.Point(106, 12);
            this.TB_TTSJidoCode.MaxLength = 4;
            this.TB_TTSJidoCode.Name = "TB_TTSJidoCode";
            this.TB_TTSJidoCode.Size = new System.Drawing.Size(30, 19);
            this.TB_TTSJidoCode.TabIndex = 15;
            this.TB_TTSJidoCode.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_TTSJidoCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            this.TB_TTSJidoCode.Leave += new System.EventHandler(this.TB_TTSJidoCode_Leave);
            this.TB_TTSJidoCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TB_MouseDown);
            // 
            // BT_JidoCode
            // 
            this.BT_JidoCode.BackColor = System.Drawing.Color.Gold;
            this.BT_JidoCode.Enabled = false;
            this.BT_JidoCode.Location = new System.Drawing.Point(142, 10);
            this.BT_JidoCode.Name = "BT_JidoCode";
            this.BT_JidoCode.Size = new System.Drawing.Size(75, 23);
            this.BT_JidoCode.TabIndex = 14;
            this.BT_JidoCode.Text = "自動コード";
            this.BT_JidoCode.UseVisualStyleBackColor = false;
            this.BT_JidoCode.Click += new System.EventHandler(this.BT_TTSJidoCode_Click);
            // 
            // LB_Kanrishafuragu
            // 
            this.LB_Kanrishafuragu.AutoSize = true;
            this.LB_Kanrishafuragu.Location = new System.Drawing.Point(18, 421);
            this.LB_Kanrishafuragu.Name = "LB_Kanrishafuragu";
            this.LB_Kanrishafuragu.Size = new System.Drawing.Size(77, 12);
            this.LB_Kanrishafuragu.TabIndex = 13;
            this.LB_Kanrishafuragu.Text = "管理者フラグ";
            // 
            // LB_Taishafuragu
            // 
            this.LB_Taishafuragu.AutoSize = true;
            this.LB_Taishafuragu.Location = new System.Drawing.Point(18, 396);
            this.LB_Taishafuragu.Name = "LB_Taishafuragu";
            this.LB_Taishafuragu.Size = new System.Drawing.Size(65, 12);
            this.LB_Taishafuragu.TabIndex = 11;
            this.LB_Taishafuragu.Text = "退社フラグ";
            // 
            // LB_Taishanengappi
            // 
            this.LB_Taishanengappi.AutoSize = true;
            this.LB_Taishanengappi.Location = new System.Drawing.Point(18, 371);
            this.LB_Taishanengappi.Name = "LB_Taishanengappi";
            this.LB_Taishanengappi.Size = new System.Drawing.Size(65, 12);
            this.LB_Taishanengappi.TabIndex = 10;
            this.LB_Taishanengappi.Text = "退社年月日";
            // 
            // BT_Bumoncode
            // 
            this.BT_Bumoncode.BackColor = System.Drawing.Color.LightCoral;
            this.BT_Bumoncode.Enabled = false;
            this.BT_Bumoncode.Location = new System.Drawing.Point(18, 187);
            this.BT_Bumoncode.Name = "BT_Bumoncode";
            this.BT_Bumoncode.Size = new System.Drawing.Size(75, 23);
            this.BT_Bumoncode.TabIndex = 9;
            this.BT_Bumoncode.Text = "部門コード";
            this.BT_Bumoncode.UseVisualStyleBackColor = false;
            this.BT_Bumoncode.Click += new System.EventHandler(this.BT_Bumoncode_Click);
            // 
            // LB_Kotei
            // 
            this.LB_Kotei.AutoSize = true;
            this.LB_Kotei.Location = new System.Drawing.Point(18, 226);
            this.LB_Kotei.Name = "LB_Kotei";
            this.LB_Kotei.Size = new System.Drawing.Size(29, 12);
            this.LB_Kotei.TabIndex = 8;
            this.LB_Kotei.Text = "工程";
            // 
            // LB_KyotenName
            // 
            this.LB_KyotenName.AutoSize = true;
            this.LB_KyotenName.Location = new System.Drawing.Point(18, 165);
            this.LB_KyotenName.Name = "LB_KyotenName";
            this.LB_KyotenName.Size = new System.Drawing.Size(41, 12);
            this.LB_KyotenName.TabIndex = 7;
            this.LB_KyotenName.Text = "拠点名";
            // 
            // LB_TTSMail
            // 
            this.LB_TTSMail.AutoSize = true;
            this.LB_TTSMail.Location = new System.Drawing.Point(18, 140);
            this.LB_TTSMail.Name = "LB_TTSMail";
            this.LB_TTSMail.Size = new System.Drawing.Size(89, 12);
            this.LB_TTSMail.TabIndex = 6;
            this.LB_TTSMail.Text = "メールアドレス";
            // 
            // LB_Sname2
            // 
            this.LB_Sname2.AutoSize = true;
            this.LB_Sname2.Location = new System.Drawing.Point(281, 115);
            this.LB_Sname2.Name = "LB_Sname2";
            this.LB_Sname2.Size = new System.Drawing.Size(65, 12);
            this.LB_Sname2.TabIndex = 5;
            this.LB_Sname2.Text = "略称２文字";
            // 
            // LB_TTSsname
            // 
            this.LB_TTSsname.AutoSize = true;
            this.LB_TTSsname.Location = new System.Drawing.Point(18, 115);
            this.LB_TTSsname.Name = "LB_TTSsname";
            this.LB_TTSsname.Size = new System.Drawing.Size(65, 12);
            this.LB_TTSsname.TabIndex = 4;
            this.LB_TTSsname.Text = "担当者略称";
            // 
            // LB_TTSkana
            // 
            this.LB_TTSkana.AutoSize = true;
            this.LB_TTSkana.Location = new System.Drawing.Point(18, 90);
            this.LB_TTSkana.Name = "LB_TTSkana";
            this.LB_TTSkana.Size = new System.Drawing.Size(65, 12);
            this.LB_TTSkana.TabIndex = 3;
            this.LB_TTSkana.Text = "担当者カナ";
            // 
            // LB_TTSname
            // 
            this.LB_TTSname.AutoSize = true;
            this.LB_TTSname.Location = new System.Drawing.Point(18, 65);
            this.LB_TTSname.Name = "LB_TTSname";
            this.LB_TTSname.Size = new System.Drawing.Size(53, 12);
            this.LB_TTSname.TabIndex = 2;
            this.LB_TTSname.Text = "担当者名";
            // 
            // LB_PWD
            // 
            this.LB_PWD.AutoSize = true;
            this.LB_PWD.Location = new System.Drawing.Point(18, 40);
            this.LB_PWD.Name = "LB_PWD";
            this.LB_PWD.Size = new System.Drawing.Size(65, 12);
            this.LB_PWD.TabIndex = 1;
            this.LB_PWD.Text = "パスワード";
            // 
            // LB_TTScode
            // 
            this.LB_TTScode.AutoSize = true;
            this.LB_TTScode.Location = new System.Drawing.Point(18, 15);
            this.LB_TTScode.Name = "LB_TTScode";
            this.LB_TTScode.Size = new System.Drawing.Size(77, 12);
            this.LB_TTScode.TabIndex = 0;
            this.LB_TTScode.Text = "担当者コード";
            // 
            // FRM_Tantosha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "FRM_Tantosha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自社担当者";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Tantosha_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Tantosha_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Kotei)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button BT_Save;
        public System.Windows.Forms.Button BT_ChangeInput;
        public System.Windows.Forms.Button BT_NewInput;
        public System.Windows.Forms.Button BT_Close;
        public System.Windows.Forms.Button BT_Delete;
        public System.Windows.Forms.Button BT_Cancel;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LB_TTSname;
        public System.Windows.Forms.Label LB_PWD;
        public System.Windows.Forms.Label LB_TTScode;
        public System.Windows.Forms.Label LB_TTSkana;
        public System.Windows.Forms.Label LB_Kotei;
        public System.Windows.Forms.Label LB_KyotenName;
        public System.Windows.Forms.Label LB_TTSMail;
        public System.Windows.Forms.Label LB_Sname2;
        public System.Windows.Forms.Label LB_TTSsname;
        public System.Windows.Forms.Label LB_Taishafuragu;
        public System.Windows.Forms.Label LB_Taishanengappi;
        public System.Windows.Forms.Button BT_Bumoncode;
        public System.Windows.Forms.Button BT_JidoCode;
        public System.Windows.Forms.Label LB_Kanrishafuragu;
        public System.Windows.Forms.TextBox TB_TTSJidoCode;
        public System.Windows.Forms.TextBox TB_PWD;
        public System.Windows.Forms.TextBox TB_TTSname;
        public System.Windows.Forms.TextBox TB_TTSkana;
        public System.Windows.Forms.TextBox TB_Sname;
        public System.Windows.Forms.TextBox TB_Sname2;
        public System.Windows.Forms.TextBox TB_TTSMail;
        public System.Windows.Forms.TextBox TB_BumonName;
        public System.Windows.Forms.TextBox TB_BumonCode;
        public System.Windows.Forms.ComboBox CB_KyotenName;
        public System.Windows.Forms.DataGridView DGV_Kotei;
        public System.Windows.Forms.CheckBox CHB_Taishafuragu;
        public System.Windows.Forms.CheckBox CHB_Kanrishafuragu;
        public System.Windows.Forms.DateTimePicker DTP_Taisha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kotei;
        private System.Windows.Forms.DataGridViewTextBoxColumn CKotei;
    }
}

