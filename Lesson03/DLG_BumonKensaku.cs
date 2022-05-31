using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lesson03
{
    public partial class DLG_BumonKensaku : Form
    {
        FRM_Tantosha f1;        // create object FRM_Tantosha
        DLG_TantoshaKensaku f2; // create object FRM_TantoshaKensaku
        public DLG_BumonKensaku(FRM_Tantosha f,DLG_TantoshaKensaku ff)
        {
            InitializeComponent();
            f1 = f;
            f2 = ff;
        }
        
        #region BT_Kensaku_Click
        private void BT_Kensaku_Click(object sender, EventArgs e)
        {
            // get textboxes value
            String bumoncode = TB_Bumoncode.Text;
            String bumonname = TB_Bumonname.Text;
            // query for retrieve all data
            String query = "select cBUMON,sBUMON from m_bumon where 1=1 and cBUMON is not null and cBUMON!='' and cBUMON!='00' and cBUMON REGEXP '^[0-9]+$'";
            MySqlDataReader reader;
            try
            {
                f1.connection.Open();       // get connection
                MySqlCommand command = f1.connection.CreateCommand();
                if (bumoncode == "" && bumonname == "")

                {
                    DialogResult result = MessageBox.Show("全てのデータを検索すると、時間が掛かる場合があります。", "確認", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        query += " order by cBUMON asc";
                        command.CommandText = query;
                        reader = command.ExecuteReader();
                        DGV_Bumonlist.Rows.Clear();
                        //read data and add in datagridview 
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                DGV_Bumonlist.Rows.Add(reader["cBUMON"].ToString(), reader["sBUMON"].ToString());
                            }
                            BT_Yomi.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("データがありません。", "", MessageBoxButtons.OK);        // data not exists
                            BT_Yomi.Enabled = false;
                        }
                    }
                }
                else
                {
                    if (bumoncode != "")        // retrieve data according to bumon code
                    {
                        query += " and cBUMON='" + bumoncode + "'";

                    }
                    if (bumonname != "")        // retrieve data according to bumon name
                    {
                        if (RD_FirstMatch.Checked == true)
                        {
                            query += " and sBUMON collate utf8_unicode_ci LIKE '" + bumonname + "%'"; // bumon name fist match with textbox text
                        }
                        else
                        {
                            query += " and sBUMON collate utf8_unicode_ci LIKE '%" + bumonname + "%'";// bumon name partial match with textbox text
                        }
                    }
                    query += " order by cBUMON asc";
                    command.CommandText = query;
                    reader = command.ExecuteReader();
                    DGV_Bumonlist.Rows.Clear();
                    //check data exists or not
                    if (reader.HasRows)
                    {
                        //read data and add in datagridview
                        while (reader.Read())
                        {
                            DGV_Bumonlist.Rows.Add(reader["cBUMON"].ToString(), reader["sBUMON"].ToString());
                        }
                        BT_Yomi.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("データがありません。", "", MessageBoxButtons.OK);        // data not exists
                        BT_Yomi.Enabled = false;
                    }

                }


            }
            catch (Exception erg)
            {
                MessageBox.Show(erg.Message);       // connection error

            }

            f1.connection.Close();
            BT_Kensaku.Select();
        }
        #endregion

        #region BT_Close_Click and BT_Clear_Click
        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Clear_Click(object sender, EventArgs e)
        {
            TB_Bumoncode.ResetText();
            TB_Bumonname.ResetText();
            DGV_Bumonlist.Rows.Clear();
            RD_PartialMatch.Checked = true;
            BT_Yomi.Enabled = false;
        }
        #endregion

        #region TB_Bumoncode_KeyPress and TB_Bumoncode_Leave
        private void TB_Bumoncode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;     //only allow digit
            if (TB_Bumoncode.TextLength == TB_Bumoncode.MaxLength && TB_Bumoncode.SelectionStart != TB_Bumoncode.TextLength && TB_Bumoncode.SelectionLength == 0 && char.IsDigit(e.KeyChar))
            {
                int selstart = TB_Bumoncode.SelectionStart;
                TB_Bumoncode.Text = TB_Bumoncode.Text.Remove(TB_Bumoncode.Text.Length - 1);
                TB_Bumoncode.SelectionStart = selstart;
            }
        }

        private void TB_Bumoncode_Leave(object sender, EventArgs e)
        {
            if (TB_Bumoncode.Text.Length == 1)
            {
                TB_Bumoncode.Text = "0" + TB_Bumoncode.Text;
            }
        }
        #endregion

        #region DGV_Bumonlist_CellDoubleClick and BT_Yomi_Click and Yomi()
        private void DGV_Bumonlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                Yomi();
        }

        private void BT_Yomi_Click(object sender, EventArgs e)
        {
            Yomi();
        }
        private void Yomi()
        {
            try
            {
                f1.connection.Open();       // get connection
                if (f1.TB_BumonCode.Enabled == false)       // check kensaku or shinki
                {
                    f2.TB_Bumoncode.Text= DGV_Bumonlist.SelectedRows[0].Cells["cbumon"].Value.ToString();
                    f2.TB_Bumonname.Text= DGV_Bumonlist.SelectedRows[0].Cells["sbumon"].Value.ToString();
                }
                else
                {
                    f1.TB_BumonCode.Text = DGV_Bumonlist.SelectedRows[0].Cells["cbumon"].Value.ToString();
                    f1.TB_BumonName.Text = DGV_Bumonlist.SelectedRows[0].Cells["sbumon"].Value.ToString();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);        // connection error
            }
            f1.connection.Close();
        }
        #endregion

        #region TB_Bumoncode_KeyDown and TB_Bumonname_KeyDown
        private void TB_Bumoncode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TB_Bumoncode.Text.Length == 1)
                {
                    TB_Bumoncode.Text = "0" + TB_Bumoncode.Text;
                }
                BT_Kensaku_Click(this, new EventArgs());
            }
        }

        private void TB_Bumonname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_Kensaku_Click(this, new EventArgs());
            }
        }
        #endregion

        #region RD_FirstMatch_KeyDown and RD_PartialMatch_KeyDown
        private void RD_FirstMatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_Kensaku_Click(this, new EventArgs());
            }
        }

        private void RD_PartialMatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_Kensaku_Click(this, new EventArgs());
            }
        }
        #endregion

        #region DGV_Bumonlist_RowPostPaint
        private void DGV_Bumonlist_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (DGV_Bumonlist.Rows[e.RowIndex].Selected)
            {
                using (Pen pen = new Pen(Color.Black))
                {
                    int penWidth = 2;
                    pen.Width = penWidth;
                    int rowHeaderWidth = DGV_Bumonlist.RowHeadersVisible ?
                                     DGV_Bumonlist.RowHeadersWidth : 0;
                    int x = rowHeaderWidth;
                    int y = e.RowBounds.Top + (penWidth / 2);
                    int width = DGV_Bumonlist.Columns.GetColumnsWidth(
                            DataGridViewElementStates.Visible) - DGV_Bumonlist.HorizontalScrollingOffset + 1;
                    int height = e.RowBounds.Height - penWidth;
                    e.Graphics.DrawRectangle(pen, x, y, width, height);
                }

            }
            
            }
        #endregion
    }
}
