using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson03
{
    public partial class DLG_TantoshaKensaku : Form
    {
        FRM_Tantosha f1;        // create object of FRM_Tantosha
        String selectKyoten;
        Boolean IsClose=false;
        public DLG_TantoshaKensaku(FRM_Tantosha ff)
        {
            InitializeComponent();
            f1 = ff;
        }

        private void FRM_TantoshaKensaku_Load(object sender, EventArgs e)
        {

        }

        #region BT_BumonCode_Click
        private void BT_BumonCode_Click(object sender, EventArgs e)
        {
            try
            {   //get and check connection
                f1.connection.Open();
                f1.connection.Close();
                //call FRM_BumonKensaku Form
                DLG_BumonKensaku sform = new DLG_BumonKensaku(f1,this);
                sform.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    // connection error
                f1.connection.Close();
            }
        }
        #endregion

        #region TB_Tentoshacode_KeyPress and TB_Bumoncode_KeyPress
        private void TB_Tentoshacode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;     //only allow digit
            if (TB_Tentoshacode.TextLength == TB_Tentoshacode.MaxLength && TB_Tentoshacode.SelectionStart!= TB_Tentoshacode.TextLength && TB_Tentoshacode.SelectionLength==0 && char.IsDigit(e.KeyChar))
            {
                int selstart = TB_Tentoshacode.SelectionStart;
                TB_Tentoshacode.Text = TB_Tentoshacode.Text.Remove(TB_Tentoshacode.Text.Length - 1);
                TB_Tentoshacode.SelectionStart = selstart;
            }
        }
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
        #endregion

        #region TB_Tentoshacode_Leave
        private void TB_Tentoshacode_Leave(object sender, EventArgs e)
        {   //add 0 in front of the text when text length not equal 4
            while(TB_Tentoshacode.Text.Length<4 && TB_Tentoshacode.Text.Length != 0)
            {
                TB_Tentoshacode.Text = "0" + TB_Tentoshacode.Text;
            }
        }
        #endregion

        #region TB_Bumoncode_Leave
        private void TB_Bumoncode_Leave(object sender, EventArgs e)
        {
            if (IsClose == false)
            {
                try
                {
                    f1.connection.Open();       // get connection
                    // when textlenght is 1, add 0 before text
                    if (TB_Bumoncode.Text.Length != 0)
                    {
                        
                        if (TB_Bumoncode.Text.Length == 1)
                        {
                            TB_Bumoncode.Text = "0" + TB_Bumoncode.Text;
                        }
                         
                        //get bumon name from m_bumon table according bumon code
                        String query = "select cBUMON,sBUMON from m_bumon where cBUMON='" + TB_Bumoncode.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(query, f1.connection);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        // check bumon exist or not
                        if (reader.HasRows)
                        {   // bumon exist
                            while (reader.Read())
                            {
                                TB_Bumonname.Text = reader["sBUMON"].ToString();    // place bumon name in TB_Bumonname textbox
                            }
                        }
                        else
                        {   // bumon not exist
                            MessageBox.Show("データがありません。", "", MessageBoxButtons.OK);
                            TB_Bumonname.ResetText();
                            TB_Bumoncode.ResetText();
                            TB_Bumoncode.Focus();
                        }
                    }
                    else
                    {
                        TB_Bumonname.ResetText();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);        // connection error
                }

                f1.connection.Close();
            }
        }
        #endregion

        #region BT_Kensaku_Click
        private void BT_Kensaku_Click(object sender, EventArgs e)
        {
            try
            {
                f1.connection.Open();
                f1.connection.Close();      //check connection
                BT_Kensaku.Select();
                String tantoshacode = TB_Tentoshacode.Text;
                String tantoshaname = TB_Tentoshaname.Text;
                String bumoncode = TB_Bumoncode.Text;
                String ftaisha = "0";

                //check taisha flag checked or not
                if (CHB_fTaisha.Checked == true)
                {
                    ftaisha = "1";
                }

                // query for retrieve all data
                String query = "SELECT m_j_tantousha.*,m_j_tantousha.cKAKUNIN as Kakunin,m_bumon.sBUMON as sBumon,(SELECT sTANTOUSHA FROM m_j_tantousha where Kakunin=cTANTOUSHA) as sKAKUNIN FROM m_j_tantousha LEFT OUTER JOIN m_bumon on m_j_tantousha.cBUMON=m_bumon.cBumon where cTANTOUSHA!='0000' and m_j_tantousha.fTAISYA='" + ftaisha + "'";
                query += " and cTANTOUSHA is not null and cTANTOUSHA!='' and cTANTOUSHA!='0000' and cTANTOUSHA REGEXP '^[0-9]+$'";
                MySqlDataReader reader;

                f1.connection.Open();   // get connection
                MySqlCommand command = f1.connection.CreateCommand();       // create Mysql command
                if (bumoncode == "" && tantoshacode == "" && tantoshaname == "" && ftaisha == "0")      // check textbox blank

                {
                    DialogResult result = MessageBox.Show("全てのデータを検索すると、時間が掛かる場合があります。", "確認", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        query += " order by cTANTOUSHA asc";
                        command.CommandText = query;
                        reader = command.ExecuteReader();
                        DGV_Tantousha.Rows.Clear();         // datagridview row clear

                        //check data exist or not
                        if (reader.HasRows)
                        {
                            //data exist,add data in datagridview
                            while (reader.Read())
                            {
                                DGV_Tantousha.Rows.Add(reader["cTANTOUSHA"].ToString(), reader["sTANTOUSHA"].ToString(), reader["skTANTOUSHA"].ToString(), reader["dTAISHA"].ToString(), reader["cBUMON"].ToString(), reader["sBUMON"].ToString(), reader["sKAKUNIN"].ToString(), reader["sTANTOUSHA_R"].ToString(), reader["sTANTOUSHA_R2"].ToString());
                            }
                            BT_Yomi.Enabled = true;
                        }
                        else
                        {
                            // data not exists
                            MessageBox.Show("データがありません。", "", MessageBoxButtons.OK);
                            BT_Yomi.Enabled = false;
                        }
                    }
                }
                else
                {
                    // query for retrieve data according to tantousha code
                    if (tantoshacode != "")
                    {
                        query += " and cTANTOUSHA='" + tantoshacode + "'";

                    }
                    // query for retrieve data according tantousha name
                    if (tantoshaname != "")
                    {
                        if (RD_FirstMatch.Checked == true)
                        {
                            query += " and sTANTOUSHA collate utf8_unicode_ci LIKE '" + tantoshaname + "%'";    // tantousha name first match with tantoshaname textbox text
                        }
                        else
                        {
                            query += " and sTANTOUSHA collate utf8_unicode_ci LIKE '%" + tantoshaname + "%'";   // tantousha name partial match with tantoshaname textbox text
                        }
                    }
                    //query for retrieve data according bumon code
                    if (bumoncode != "")
                    {
                        query += " and m_j_tantousha.cBUMON='" + bumoncode + "'";

                    }
                    query += " order by cTANTOUSHA asc";  //data ascending according tantousha code
                    command.CommandText = query;
                    reader = command.ExecuteReader();
                    DGV_Tantousha.Rows.Clear();     // datagridview row clear

                    //check data exist or not
                    if (reader.HasRows)
                    {
                        //data exist,add data in datagridview
                        while (reader.Read())
                        {
                            DGV_Tantousha.Rows.Add(reader["cTANTOUSHA"].ToString(), reader["sTANTOUSHA"].ToString(), reader["skTANTOUSHA"].ToString(), reader["dTAISHA"].ToString(), reader["cBUMON"].ToString(), reader["sBUMON"].ToString(), reader["sKAKUNIN"].ToString(), reader["sTANTOUSHA_R"].ToString(), reader["sTANTOUSHA_R2"].ToString());
                        }
                        BT_Yomi.Enabled = true;

                    }
                    else
                    {
                        // data not exists
                        MessageBox.Show("データがありません。", "", MessageBoxButtons.OK);
                        BT_Yomi.Enabled = false;
                    }

                }
               
            }
            catch (Exception erg)
            {
                MessageBox.Show(erg.Message);       // connection error
            }
            f1.connection.Close();
        }
        #endregion

        #region BT_Clear_Click
        private void BT_Clear_Click(object sender, EventArgs e)
        {
            // Clear text of textboxes and rows of datagridview
            TB_Tentoshacode.ResetText();
            TB_Tentoshaname.ResetText();
            TB_Bumoncode.ResetText();
            TB_Bumonname.ResetText();
            CHB_fTaisha.Checked = false;
            RD_PartialMatch.Checked = true;
            BT_Yomi.Enabled = false;
            DGV_Tantousha.Rows.Clear();
        }
        #endregion

        #region KeyDown Events
        private void TB_Tentoshacode_KeyDown(object sender, KeyEventArgs e)
        {
            //when press "Enter" key at TB_Tentoshacode textbox, search data
            if (e.KeyCode == Keys.Enter)
            {
               // add 0 in front of the text when text length no equal 4
                while (TB_Tentoshacode.Text.Length < 4 && TB_Tentoshacode.Text.Length != 0)
                {
                    TB_Tentoshacode.Text = "0" + TB_Tentoshacode.Text;
                }
                BT_Kensaku_Click(this, new EventArgs());  //search data
            }
        }

        private void TB_Tentoshaname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_Kensaku_Click(this, new EventArgs());
            }
        }

        private void TB_Bumoncode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //if (TB_Bumoncode.Text.Length == 1)
                //{
                //    TB_Bumoncode.Text = "0" + TB_Bumoncode.Text;
                //}
               // TB_Bumoncode_Leave(null, null);
                BT_Kensaku_Click(this, new EventArgs());
            }
        }

        private void CHB_fTaisha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_Kensaku_Click(this, new EventArgs());
            }
        }

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

        #region Yomi()
        private void Yomi()
        {
            //Yomi data and place data to FRM_tantosha textboxes
            try
            {
                f1.connection.Open();       // get connection
                String tantoushaC = DGV_Tantousha.SelectedRows[0].Cells["ctantousha"].Value.ToString();     //get tantousha code 
                String query = "SELECT m_j_tantousha.*,m_bumon.sBUMON as sBumon FROM m_j_tantousha LEFT OUTER JOIN m_bumon on m_j_tantousha.cBUMON=m_bumon.cBumon where cTANTOUSHA ='" + tantoushaC + "'";     // retrieve data according tantousha code
                MySqlDataReader reader;
                MySqlCommand command = f1.connection.CreateCommand();       // create Mysql command
                command.CommandText = query;
                reader = command.ExecuteReader();       //read data with MySql Reader
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        f1.TB_TTSJidoCode.Text = tantoushaC;        // place tantousha code in TB_TTSJidoCode of FRM_Tantosha form
                        String pwd = reader["sPWD"].ToString();     // read Password
                        try
                        {
                            f1.TB_PWD.Text = f1.Decrypt(pwd);       // place password in TB_PWD of FRM_Tantosha form by decryption
                        }
                        catch
                        {
                            f1.TB_PWD.Text = "";    // password cannot be decrypted
                        }
                        //place data in textboxes of FRM_Tantosha form
                        f1.TB_TTSname.Text = reader["sTANTOUSHA"].ToString();
                        f1.TB_TTSkana.Text = reader["skTANTOUSHA"].ToString();
                        f1.TB_Sname.Text = reader["sTANTOUSHA_R"].ToString();
                        f1.TB_Sname2.Text = reader["sTANTOUSHA_R2"].ToString();
                        f1.TB_TTSMail.Text = reader["SMAIL"].ToString();
                        f1.TB_BumonCode.Text = reader["cBUMON"].ToString();
                        f1.TB_BumonName.Text = "ERR";       // bumon code not exists
                        if (reader["sBumon"].ToString() != "")
                        {
                            f1.TB_BumonName.Text =reader["sBumon"].ToString();
                        }
                        selectKyoten = reader["cKYOTEN"].ToString();    // read Kyoten code
                        //read taisha datetime 
                        if (reader["dTAISHA"].ToString() != "")
                        {
                            f1.DTP_Taisha.CustomFormat = "yyyy/MM/dd";
                            f1.DTP_Taisha.Checked = true;
                            f1.DTP_Taisha.Value = (DateTime)reader["dTAISHA"];
                        }
                        if (reader["fTAISYA"].ToString() == "1")
                        {
                            f1.CHB_Taishafuragu.Checked = true;
                        }
                        if (reader["fKANRISHA"].ToString() == "1")
                        {
                            f1.CHB_Kanrishafuragu.Checked = true;
                        }
                    }
                    reader.Close();
                    //read kyoten list
                    string KyotenQuery = "SELECT cCO,sKYOTEN FROM m_j_info";
                    MySqlCommand cmd = new MySqlCommand(KyotenQuery, f1.connection);
                    reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("cCO", typeof(string));
                    dt.Columns.Add("sKYOTEN", typeof(string));
                    dt.Rows.Add("");
                    dt.Load(reader);
                    cmd.ExecuteNonQuery();
                    //place kyoten list in combobox of FRM_Tantosha form
                    f1.CB_KyotenName.DisplayMember = "sKYOTEN";
                    f1.CB_KyotenName.ValueMember = "cCO";
                    f1.CB_KyotenName.DataSource = dt;
                    reader.Close();
                    //read kyoten according kyoten code
                    KyotenQuery = "SELECT sKYOTEN FROM m_j_info where cCO='" + selectKyoten + "'";
                    cmd = new MySqlCommand(KyotenQuery, f1.connection);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    string skyoten = "";
                    if (reader.HasRows)
                    {
                        skyoten = reader["sKYOTEN"].ToString();     // get kyoten name
                    }
                    int sindex = f1.CB_KyotenName.FindStringExact(skyoten);     //find selected index in combobox 
                    f1.CB_KyotenName.SelectedIndex = sindex;
                    reader.Close();
                    //read kotei list
                    String KoteiQuery = "SELECT sSAGYOBUNRUI,cSAGYOBUNRUI FROM m_shijisho_sagyobunrui where fDEL='0' order by nJUNBAN asc ";
                    cmd.CommandText = KoteiQuery;
                    reader = cmd.ExecuteReader();
                    // place kotei list in datagridview of FRM_Tantosha form
                    while (reader.Read())
                    {
                        f1.DGV_Kotei.Rows.Add(false, reader["sSAGYOBUNRUI"].ToString(), reader["cSAGYOBUNRUI"].ToString());
                    }
                    reader.Close();
                    // read kotei list according tantousha code
                    KoteiQuery = "SELECT cKOUTEI FROM m_tantoushakoutei where cTANTOUSHA='" + tantoushaC + "'";
                    cmd.CommandText = KoteiQuery;
                    reader = cmd.ExecuteReader();
                    // checked kotei in datagridview
                    while (reader.Read())
                    {
                        foreach (DataGridViewRow row in f1.DGV_Kotei.Rows)
                        {
                            if (reader["cKOUTEI"].ToString() == row.Cells["CKotei"].Value.ToString())
                            {
                                row.Cells["CheckBoxColumn"].Value = true;
                            }
                        }
                    }

                    if (f1.updateordelete == "update")      // BT_ChangeInput Click
                    {
                        // change textboxes enable
                        f1.TB_PWD.ForeColor = Color.Black;
                        f1.TB_TTSname.ForeColor = Color.Black;
                        f1.TB_TTSkana.ForeColor = Color.Black;
                        f1.TB_Sname.ForeColor = Color.Black;
                        f1.TB_Sname2.ForeColor = Color.Black;
                        f1.TB_TTSMail.ForeColor = Color.Black;
                        f1.TB_BumonCode.ForeColor = Color.Black;
                        f1.CB_KyotenName.ForeColor = Color.Black;
                        f1.DTP_Taisha.CalendarForeColor = Color.Green;
                        f1.TB_PWD.BackColor = Color.White;
                        f1.TB_TTSname.BackColor = Color.White;
                        f1.TB_Sname2.BackColor = Color.White;
                        f1.TB_BumonCode.BackColor = Color.White;
                        f1.TB_PWD.Enabled = true;
                        f1.TB_TTSname.Enabled = true;
                        f1.TB_TTSkana.Enabled = true;
                        f1.TB_Sname.Enabled = true;
                        f1.TB_Sname2.Enabled = true;
                        f1.BT_Bumoncode.Enabled = true;
                        f1.TB_BumonCode.Enabled = true;
                        f1.TB_TTSMail.Enabled = true;
                        f1.DTP_Taisha.Enabled = true;
                        f1.CHB_Taishafuragu.Enabled = true;
                        f1.CHB_Kanrishafuragu.Enabled = true;
                        f1.CB_KyotenName.Enabled = true;
                        f1.DGV_Kotei.Enabled = true;
                        f1.DGV_Kotei.Columns[0].DefaultCellStyle.SelectionBackColor = Color.White;
                        f1.DGV_Kotei.Columns[1].DefaultCellStyle.SelectionBackColor = SystemColors.ControlLight;
                        f1.BT_Cancel.Enabled = true;
                        f1.BT_Save.Enabled = true;
                        f1.BT_NewInput.Enabled = false;
                        f1.BT_ChangeInput.Enabled = false;
                        f1.BT_Delete.Enabled = false;
                        f1.updateordelete = "yesupdate";
                        f1.textchangeindex = 0;
                        f1.selectedindex = f1.CB_KyotenName.SelectedIndex;
                        f1.TB_PWD.SelectionStart = 0;
                        f1.TB_PWD.Select();
                    }
                    else        // BT_Delete Click
                    {
                        f1.updateordelete = "yesdelete";
                        f1.DGV_Kotei.Enabled = false;
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("データがありません。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);        // connection error
            }
            f1.connection.Close();
        }
        #endregion

        #region BT_Yomi_Click and DGV_Tantousha_CellDoubleClick and BT_Close_Click and BT_Close_MouseEnter and BT_Close_MouseLeave
        private void BT_Yomi_Click(object sender, EventArgs e)
        {
            Yomi();
        }
        private void DGV_Tantousha_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)    //check datagridview row index
                Yomi();
        }
        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BT_Close_MouseEnter(object sender, EventArgs e)
        {
            IsClose = true;      //for form close
        }
        private void BT_Close_MouseLeave(object sender, EventArgs e)
        {
            IsClose = false;
        }
        #endregion

        #region DGV_Tantousha_RowPostPaint
        private void DGV_Tantousha_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (DGV_Tantousha.Rows[e.RowIndex].Selected)
            {
                using (Pen pen = new Pen(Color.Black))
                {
                    int penWidth = 2;
                    pen.Width = penWidth;
                    int rowHeaderWidth = DGV_Tantousha.RowHeadersVisible ?
                                     DGV_Tantousha.RowHeadersWidth : 0;
                    int x = rowHeaderWidth;
                    int y = e.RowBounds.Top + (penWidth / 2);
                    int width = DGV_Tantousha.Columns.GetColumnsWidth(
                            DataGridViewElementStates.Visible) - DGV_Tantousha.HorizontalScrollingOffset + 1;
                    int height = e.RowBounds.Height - penWidth;
                    e.Graphics.DrawRectangle(pen, x, y, width, height);
                }

            }
        }


        #endregion

        
    }
}
