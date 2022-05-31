namespace Lesson03
{
    partial class DLG_TantoshaKensaku
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CHB_fTaisha = new System.Windows.Forms.CheckBox();
            this.LB_Taishafuragu = new System.Windows.Forms.Label();
            this.TB_Bumonname = new System.Windows.Forms.TextBox();
            this.TB_Bumoncode = new System.Windows.Forms.TextBox();
            this.BT_BumonCode = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RD_PartialMatch = new System.Windows.Forms.RadioButton();
            this.RD_FirstMatch = new System.Windows.Forms.RadioButton();
            this.TB_Tentoshaname = new System.Windows.Forms.TextBox();
            this.TB_Tentoshacode = new System.Windows.Forms.TextBox();
            this.LB_Tantoshaname = new System.Windows.Forms.Label();
            this.LB_Tantoshacode = new System.Windows.Forms.Label();
            this.DGV_Tantousha = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BT_Close = new System.Windows.Forms.Button();
            this.BT_Clear = new System.Windows.Forms.Button();
            this.BT_Yomi = new System.Windows.Forms.Button();
            this.BT_Kensaku = new System.Windows.Forms.Button();
            this.stantousha_r2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stantousha_r = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKakunin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sBumon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBumon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dhenko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sktantousha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stantousha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctantousha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tantousha)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CHB_fTaisha);
            this.panel1.Controls.Add(this.LB_Taishafuragu);
            this.panel1.Controls.Add(this.TB_Bumonname);
            this.panel1.Controls.Add(this.TB_Bumoncode);
            this.panel1.Controls.Add(this.BT_BumonCode);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TB_Tentoshaname);
            this.panel1.Controls.Add(this.TB_Tentoshacode);
            this.panel1.Controls.Add(this.LB_Tantoshaname);
            this.panel1.Controls.Add(this.LB_Tantoshacode);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 111);
            this.panel1.TabIndex = 12;
            // 
            // CHB_fTaisha
            // 
            this.CHB_fTaisha.AutoSize = true;
            this.CHB_fTaisha.Location = new System.Drawing.Point(89, 86);
            this.CHB_fTaisha.Name = "CHB_fTaisha";
            this.CHB_fTaisha.Size = new System.Drawing.Size(48, 16);
            this.CHB_fTaisha.TabIndex = 11;
            this.CHB_fTaisha.Text = "退社";
            this.CHB_fTaisha.UseVisualStyleBackColor = true;
            this.CHB_fTaisha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHB_fTaisha_KeyDown);
            // 
            // LB_Taishafuragu
            // 
            this.LB_Taishafuragu.AutoSize = true;
            this.LB_Taishafuragu.Location = new System.Drawing.Point(4, 87);
            this.LB_Taishafuragu.Name = "LB_Taishafuragu";
            this.LB_Taishafuragu.Size = new System.Drawing.Size(65, 12);
            this.LB_Taishafuragu.TabIndex = 10;
            this.LB_Taishafuragu.Text = "退社フラグ";
            // 
            // TB_Bumonname
            // 
            this.TB_Bumonname.Enabled = false;
            this.TB_Bumonname.Location = new System.Drawing.Point(115, 58);
            this.TB_Bumonname.MaxLength = 50;
            this.TB_Bumonname.Name = "TB_Bumonname";
            this.TB_Bumonname.Size = new System.Drawing.Size(306, 19);
            this.TB_Bumonname.TabIndex = 9;
            // 
            // TB_Bumoncode
            // 
            this.TB_Bumoncode.Location = new System.Drawing.Point(89, 58);
            this.TB_Bumoncode.MaxLength = 2;
            this.TB_Bumoncode.Name = "TB_Bumoncode";
            this.TB_Bumoncode.Size = new System.Drawing.Size(20, 19);
            this.TB_Bumoncode.TabIndex = 8;
            this.TB_Bumoncode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Bumoncode_KeyDown);
            this.TB_Bumoncode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Bumoncode_KeyPress);
            this.TB_Bumoncode.Leave += new System.EventHandler(this.TB_Bumoncode_Leave);
            // 
            // BT_BumonCode
            // 
            this.BT_BumonCode.BackColor = System.Drawing.Color.LightCoral;
            this.BT_BumonCode.Location = new System.Drawing.Point(4, 56);
            this.BT_BumonCode.Name = "BT_BumonCode";
            this.BT_BumonCode.Size = new System.Drawing.Size(81, 23);
            this.BT_BumonCode.TabIndex = 7;
            this.BT_BumonCode.Text = "部門コード";
            this.BT_BumonCode.UseVisualStyleBackColor = false;
            this.BT_BumonCode.Click += new System.EventHandler(this.BT_BumonCode_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.RD_PartialMatch);
            this.panel2.Controls.Add(this.RD_FirstMatch);
            this.panel2.Location = new System.Drawing.Point(413, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 19);
            this.panel2.TabIndex = 6;
            // 
            // RD_PartialMatch
            // 
            this.RD_PartialMatch.AutoSize = true;
            this.RD_PartialMatch.Checked = true;
            this.RD_PartialMatch.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RD_PartialMatch.Location = new System.Drawing.Point(87, 1);
            this.RD_PartialMatch.Name = "RD_PartialMatch";
            this.RD_PartialMatch.Size = new System.Drawing.Size(71, 16);
            this.RD_PartialMatch.TabIndex = 5;
            this.RD_PartialMatch.TabStop = true;
            this.RD_PartialMatch.Text = "部分一致";
            this.RD_PartialMatch.UseVisualStyleBackColor = true;
            this.RD_PartialMatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RD_PartialMatch_KeyDown);
            // 
            // RD_FirstMatch
            // 
            this.RD_FirstMatch.AutoSize = true;
            this.RD_FirstMatch.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RD_FirstMatch.Location = new System.Drawing.Point(8, 1);
            this.RD_FirstMatch.Name = "RD_FirstMatch";
            this.RD_FirstMatch.Size = new System.Drawing.Size(71, 16);
            this.RD_FirstMatch.TabIndex = 4;
            this.RD_FirstMatch.Text = "先頭一致";
            this.RD_FirstMatch.UseVisualStyleBackColor = true;
            this.RD_FirstMatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RD_FirstMatch_KeyDown);
            // 
            // TB_Tentoshaname
            // 
            this.TB_Tentoshaname.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.TB_Tentoshaname.Location = new System.Drawing.Point(89, 32);
            this.TB_Tentoshaname.MaxLength = 50;
            this.TB_Tentoshaname.Name = "TB_Tentoshaname";
            this.TB_Tentoshaname.Size = new System.Drawing.Size(306, 19);
            this.TB_Tentoshaname.TabIndex = 3;
            this.TB_Tentoshaname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Tentoshaname_KeyDown);
            // 
            // TB_Tentoshacode
            // 
            this.TB_Tentoshacode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TB_Tentoshacode.Location = new System.Drawing.Point(89, 8);
            this.TB_Tentoshacode.MaxLength = 4;
            this.TB_Tentoshacode.Name = "TB_Tentoshacode";
            this.TB_Tentoshacode.Size = new System.Drawing.Size(30, 19);
            this.TB_Tentoshacode.TabIndex = 2;
            this.TB_Tentoshacode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Tentoshacode_KeyDown);
            this.TB_Tentoshacode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Tentoshacode_KeyPress);
            this.TB_Tentoshacode.Leave += new System.EventHandler(this.TB_Tentoshacode_Leave);
            // 
            // LB_Tantoshaname
            // 
            this.LB_Tantoshaname.AutoSize = true;
            this.LB_Tantoshaname.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_Tantoshaname.Location = new System.Drawing.Point(4, 36);
            this.LB_Tantoshaname.Name = "LB_Tantoshaname";
            this.LB_Tantoshaname.Size = new System.Drawing.Size(53, 12);
            this.LB_Tantoshaname.TabIndex = 1;
            this.LB_Tantoshaname.Text = "担当者名";
            // 
            // LB_Tantoshacode
            // 
            this.LB_Tantoshacode.AutoSize = true;
            this.LB_Tantoshacode.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_Tantoshacode.Location = new System.Drawing.Point(4, 11);
            this.LB_Tantoshacode.Name = "LB_Tantoshacode";
            this.LB_Tantoshacode.Size = new System.Drawing.Size(77, 12);
            this.LB_Tantoshacode.TabIndex = 0;
            this.LB_Tantoshacode.Text = "担当者コード";
            // 
            // DGV_Tantousha
            // 
            this.DGV_Tantousha.AllowUserToAddRows = false;
            this.DGV_Tantousha.AllowUserToDeleteRows = false;
            this.DGV_Tantousha.AllowUserToResizeRows = false;
            this.DGV_Tantousha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.DGV_Tantousha.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Tantousha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Tantousha.ColumnHeadersHeight = 20;
            this.DGV_Tantousha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Tantousha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctantousha,
            this.stantousha,
            this.sktantousha,
            this.dhenko,
            this.cBumon,
            this.sBumon,
            this.sKakunin,
            this.stantousha_r,
            this.stantousha_r2});
            this.DGV_Tantousha.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGV_Tantousha.GridColor = System.Drawing.Color.LightGray;
            this.DGV_Tantousha.Location = new System.Drawing.Point(3, 3);
            this.DGV_Tantousha.MultiSelect = false;
            this.DGV_Tantousha.Name = "DGV_Tantousha";
            this.DGV_Tantousha.ReadOnly = true;
            this.DGV_Tantousha.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_Tantousha.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.DGV_Tantousha.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Tantousha.RowTemplate.Height = 19;
            this.DGV_Tantousha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Tantousha.Size = new System.Drawing.Size(672, 409);
            this.DGV_Tantousha.TabIndex = 0;
            this.DGV_Tantousha.TabStop = false;
            this.DGV_Tantousha.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Tantousha_CellDoubleClick);
            this.DGV_Tantousha.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGV_Tantousha_RowPostPaint);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.DGV_Tantousha);
            this.panel3.Location = new System.Drawing.Point(3, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(680, 417);
            this.panel3.TabIndex = 13;
            // 
            // BT_Close
            // 
            this.BT_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(234)))), ((int)(((byte)(251)))));
            this.BT_Close.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Close.Location = new System.Drawing.Point(689, 491);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(75, 48);
            this.BT_Close.TabIndex = 17;
            this.BT_Close.Text = "閉じる";
            this.BT_Close.UseVisualStyleBackColor = false;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            this.BT_Close.MouseEnter += new System.EventHandler(this.BT_Close_MouseEnter);
            this.BT_Close.MouseLeave += new System.EventHandler(this.BT_Close_MouseLeave);
            // 
            // BT_Clear
            // 
            this.BT_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(234)))), ((int)(((byte)(251)))));
            this.BT_Clear.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Clear.Location = new System.Drawing.Point(689, 176);
            this.BT_Clear.Name = "BT_Clear";
            this.BT_Clear.Size = new System.Drawing.Size(75, 47);
            this.BT_Clear.TabIndex = 16;
            this.BT_Clear.Text = "クリア";
            this.BT_Clear.UseVisualStyleBackColor = false;
            this.BT_Clear.Click += new System.EventHandler(this.BT_Clear_Click);
            // 
            // BT_Yomi
            // 
            this.BT_Yomi.BackColor = System.Drawing.Color.Gold;
            this.BT_Yomi.Enabled = false;
            this.BT_Yomi.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Yomi.Location = new System.Drawing.Point(689, 121);
            this.BT_Yomi.Name = "BT_Yomi";
            this.BT_Yomi.Size = new System.Drawing.Size(75, 47);
            this.BT_Yomi.TabIndex = 15;
            this.BT_Yomi.Text = "読込む";
            this.BT_Yomi.UseVisualStyleBackColor = false;
            this.BT_Yomi.Click += new System.EventHandler(this.BT_Yomi_Click);
            // 
            // BT_Kensaku
            // 
            this.BT_Kensaku.BackColor = System.Drawing.Color.Gold;
            this.BT_Kensaku.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Kensaku.Location = new System.Drawing.Point(689, 4);
            this.BT_Kensaku.Name = "BT_Kensaku";
            this.BT_Kensaku.Size = new System.Drawing.Size(75, 48);
            this.BT_Kensaku.TabIndex = 14;
            this.BT_Kensaku.Text = "検索";
            this.BT_Kensaku.UseVisualStyleBackColor = false;
            this.BT_Kensaku.Click += new System.EventHandler(this.BT_Kensaku_Click);
            // 
            // stantousha_r2
            // 
            this.stantousha_r2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stantousha_r2.HeaderText = "略称2文字";
            this.stantousha_r2.Name = "stantousha_r2";
            this.stantousha_r2.ReadOnly = true;
            // 
            // stantousha_r
            // 
            this.stantousha_r.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stantousha_r.HeaderText = "担当者略称";
            this.stantousha_r.Name = "stantousha_r";
            this.stantousha_r.ReadOnly = true;
            // 
            // sKakunin
            // 
            this.sKakunin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sKakunin.HeaderText = "確認者";
            this.sKakunin.Name = "sKakunin";
            this.sKakunin.ReadOnly = true;
            this.sKakunin.Width = 80;
            // 
            // sBumon
            // 
            this.sBumon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sBumon.HeaderText = "部門名";
            this.sBumon.Name = "sBumon";
            this.sBumon.ReadOnly = true;
            this.sBumon.Width = 80;
            // 
            // cBumon
            // 
            this.cBumon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cBumon.HeaderText = "部門コード";
            this.cBumon.Name = "cBumon";
            this.cBumon.ReadOnly = true;
            this.cBumon.Width = 80;
            // 
            // dhenko
            // 
            this.dhenko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dhenko.HeaderText = "退社年月日";
            this.dhenko.Name = "dhenko";
            this.dhenko.ReadOnly = true;
            // 
            // sktantousha
            // 
            this.sktantousha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sktantousha.HeaderText = "担当者カナ";
            this.sktantousha.Name = "sktantousha";
            this.sktantousha.ReadOnly = true;
            this.sktantousha.Width = 120;
            // 
            // stantousha
            // 
            this.stantousha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stantousha.DataPropertyName = "tantoshaname";
            this.stantousha.HeaderText = "担当者名";
            this.stantousha.Name = "stantousha";
            this.stantousha.ReadOnly = true;
            this.stantousha.Width = 120;
            // 
            // ctantousha
            // 
            this.ctantousha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ctantousha.DataPropertyName = "tantoshacode";
            this.ctantousha.HeaderText = "担当者コード";
            this.ctantousha.Name = "ctantousha";
            this.ctantousha.ReadOnly = true;
            this.ctantousha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ctantousha.Width = 90;
            // 
            // DLG_TantoshaKensaku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(771, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.BT_Clear);
            this.Controls.Add(this.BT_Yomi);
            this.Controls.Add(this.BT_Kensaku);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaximizeBox = false;
            this.Name = "DLG_TantoshaKensaku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自社担当者検索";
            this.Load += new System.EventHandler(this.FRM_TantoshaKensaku_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tantousha)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RD_PartialMatch;
        private System.Windows.Forms.RadioButton RD_FirstMatch;
        private System.Windows.Forms.TextBox TB_Tentoshaname;
        private System.Windows.Forms.TextBox TB_Tentoshacode;
        private System.Windows.Forms.Label LB_Tantoshaname;
        private System.Windows.Forms.Label LB_Tantoshacode;
        private System.Windows.Forms.DataGridView DGV_Tantousha;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.Button BT_Clear;
        private System.Windows.Forms.Button BT_Yomi;
        private System.Windows.Forms.Button BT_Kensaku;
        public System.Windows.Forms.TextBox TB_Bumoncode;
        private System.Windows.Forms.Button BT_BumonCode;
        public System.Windows.Forms.TextBox TB_Bumonname;
        private System.Windows.Forms.Label LB_Taishafuragu;
        private System.Windows.Forms.CheckBox CHB_fTaisha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctantousha;
        private System.Windows.Forms.DataGridViewTextBoxColumn stantousha;
        private System.Windows.Forms.DataGridViewTextBoxColumn sktantousha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dhenko;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBumon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sBumon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKakunin;
        private System.Windows.Forms.DataGridViewTextBoxColumn stantousha_r;
        private System.Windows.Forms.DataGridViewTextBoxColumn stantousha_r2;
    }
}