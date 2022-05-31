namespace Lesson03
{
    partial class DLG_BumonKensaku
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
            this.DGV_Bumonlist = new System.Windows.Forms.DataGridView();
            this.cbumon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbumon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RD_PartialMatch = new System.Windows.Forms.RadioButton();
            this.RD_FirstMatch = new System.Windows.Forms.RadioButton();
            this.TB_Bumonname = new System.Windows.Forms.TextBox();
            this.TB_Bumoncode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BT_Close = new System.Windows.Forms.Button();
            this.BT_Clear = new System.Windows.Forms.Button();
            this.BT_Yomi = new System.Windows.Forms.Button();
            this.BT_Kensaku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bumonlist)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Bumonlist
            // 
            this.DGV_Bumonlist.AllowUserToAddRows = false;
            this.DGV_Bumonlist.AllowUserToDeleteRows = false;
            this.DGV_Bumonlist.AllowUserToResizeRows = false;
            this.DGV_Bumonlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.DGV_Bumonlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Bumonlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Bumonlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Bumonlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbumon,
            this.sbumon});
            this.DGV_Bumonlist.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGV_Bumonlist.GridColor = System.Drawing.Color.LightGray;
            this.DGV_Bumonlist.Location = new System.Drawing.Point(3, 2);
            this.DGV_Bumonlist.MultiSelect = false;
            this.DGV_Bumonlist.Name = "DGV_Bumonlist";
            this.DGV_Bumonlist.ReadOnly = true;
            this.DGV_Bumonlist.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.DGV_Bumonlist.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Bumonlist.RowTemplate.Height = 19;
            this.DGV_Bumonlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Bumonlist.Size = new System.Drawing.Size(639, 438);
            this.DGV_Bumonlist.TabIndex = 0;
            this.DGV_Bumonlist.TabStop = false;
            this.DGV_Bumonlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Bumonlist_CellDoubleClick);
            this.DGV_Bumonlist.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGV_Bumonlist_RowPostPaint);
            // 
            // cbumon
            // 
            this.cbumon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cbumon.DataPropertyName = "bumoncode";
            this.cbumon.HeaderText = "部門コード";
            this.cbumon.Name = "cbumon";
            this.cbumon.ReadOnly = true;
            this.cbumon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbumon.Width = 140;
            // 
            // sbumon
            // 
            this.sbumon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sbumon.DataPropertyName = "bumonname";
            this.sbumon.HeaderText = "部門名";
            this.sbumon.Name = "sbumon";
            this.sbumon.ReadOnly = true;
            this.sbumon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sbumon.Width = 480;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TB_Bumonname);
            this.panel1.Controls.Add(this.TB_Bumoncode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 85);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.RD_PartialMatch);
            this.panel2.Controls.Add(this.RD_FirstMatch);
            this.panel2.Location = new System.Drawing.Point(402, 47);
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
            // TB_Bumonname
            // 
            this.TB_Bumonname.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.TB_Bumonname.Location = new System.Drawing.Point(81, 47);
            this.TB_Bumonname.Name = "TB_Bumonname";
            this.TB_Bumonname.Size = new System.Drawing.Size(304, 19);
            this.TB_Bumonname.TabIndex = 3;
            this.TB_Bumonname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Bumonname_KeyDown);
            // 
            // TB_Bumoncode
            // 
            this.TB_Bumoncode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TB_Bumoncode.Location = new System.Drawing.Point(81, 19);
            this.TB_Bumoncode.MaxLength = 2;
            this.TB_Bumoncode.Name = "TB_Bumoncode";
            this.TB_Bumoncode.Size = new System.Drawing.Size(20, 19);
            this.TB_Bumoncode.TabIndex = 2;
            this.TB_Bumoncode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Bumoncode_KeyDown);
            this.TB_Bumoncode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Bumoncode_KeyPress);
            this.TB_Bumoncode.Leave += new System.EventHandler(this.TB_Bumoncode_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "部門名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "部門コード";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.DGV_Bumonlist);
            this.panel3.Location = new System.Drawing.Point(3, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 444);
            this.panel3.TabIndex = 7;
            // 
            // BT_Close
            // 
            this.BT_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(234)))), ((int)(((byte)(251)))));
            this.BT_Close.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Close.Location = new System.Drawing.Point(656, 490);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(75, 48);
            this.BT_Close.TabIndex = 11;
            this.BT_Close.Text = "閉じる";
            this.BT_Close.UseVisualStyleBackColor = false;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // BT_Clear
            // 
            this.BT_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(234)))), ((int)(((byte)(251)))));
            this.BT_Clear.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Clear.Location = new System.Drawing.Point(656, 148);
            this.BT_Clear.Name = "BT_Clear";
            this.BT_Clear.Size = new System.Drawing.Size(75, 48);
            this.BT_Clear.TabIndex = 10;
            this.BT_Clear.Text = "クリア";
            this.BT_Clear.UseVisualStyleBackColor = false;
            this.BT_Clear.Click += new System.EventHandler(this.BT_Clear_Click);
            // 
            // BT_Yomi
            // 
            this.BT_Yomi.BackColor = System.Drawing.Color.Gold;
            this.BT_Yomi.Enabled = false;
            this.BT_Yomi.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Yomi.Location = new System.Drawing.Point(656, 93);
            this.BT_Yomi.Name = "BT_Yomi";
            this.BT_Yomi.Size = new System.Drawing.Size(75, 48);
            this.BT_Yomi.TabIndex = 9;
            this.BT_Yomi.Text = "読込む";
            this.BT_Yomi.UseVisualStyleBackColor = false;
            this.BT_Yomi.Click += new System.EventHandler(this.BT_Yomi_Click);
            // 
            // BT_Kensaku
            // 
            this.BT_Kensaku.BackColor = System.Drawing.Color.Gold;
            this.BT_Kensaku.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Kensaku.Location = new System.Drawing.Point(656, 3);
            this.BT_Kensaku.Name = "BT_Kensaku";
            this.BT_Kensaku.Size = new System.Drawing.Size(75, 48);
            this.BT_Kensaku.TabIndex = 8;
            this.BT_Kensaku.Text = "検索";
            this.BT_Kensaku.UseVisualStyleBackColor = false;
            this.BT_Kensaku.Click += new System.EventHandler(this.BT_Kensaku_Click);
            // 
            // DLG_BumonKensaku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(734, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.BT_Clear);
            this.Controls.Add(this.BT_Yomi);
            this.Controls.Add(this.BT_Kensaku);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaximizeBox = false;
            this.Name = "DLG_BumonKensaku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部門検索";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bumonlist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Bumonlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbumon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbumon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RD_PartialMatch;
        private System.Windows.Forms.RadioButton RD_FirstMatch;
        private System.Windows.Forms.TextBox TB_Bumonname;
        private System.Windows.Forms.TextBox TB_Bumoncode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.Button BT_Clear;
        private System.Windows.Forms.Button BT_Yomi;
        private System.Windows.Forms.Button BT_Kensaku;
    }
}