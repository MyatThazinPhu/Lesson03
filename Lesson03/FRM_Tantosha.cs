using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace Lesson03
{
    public partial class FRM_Tantosha : Form
    {
        #region Variable Declaration

        public MySqlConnection connection;
        public string server;
        public string database;
        public string uid;
        public string password;
        public int textchangeindex = 0;
        public String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public String folder = "\\demo20\\";
        public string updateordelete;
        private Timer timer = new Timer();
        public string oldtext;
        public Boolean savesuccess;
        public int selectedindex;
        #endregion

        public FRM_Tantosha()
        {
            InitializeComponent();

        }

        #region Demo_test
        public Boolean Demo_test()
        {
            if (System.IO.File.Exists(path + folder + "demo20.xml"))    // check demo20 exist or not
            {
                XmlDocument doc = new XmlDocument();       //create xmldocument object
                string path1 = path + folder + "demo20.xml";

                // check demo20 correct or not
                try
                {
                    doc.Load(path1);  // load demo20 file
                    // read demo20 file and get values
                    var theserver = doc.SelectNodes("/DEMO20/DBList/DB-SERV/Values");
                    server = theserver[0].InnerText;
                    var thedbname = doc.SelectNodes("/DEMO20/DBList/DB-NAME/Values");
                    database = thedbname[0].InnerText;
                    var theusername = doc.SelectNodes("/DEMO20/DBList/DB-USER/Values");
                    uid = theusername[0].InnerText;
                    var thepassword = doc.SelectNodes("/DEMO20/DBList/DB-PASS/Values");
                    password = thepassword[0].InnerText;
                    string connectionString;
                    connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                    connection = new MySqlConnection(connectionString);
                    return true;
                }

                //demo20 file incorrect
                catch
                {
                    MessageBox.Show("Demo20 file is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.Close();
                    return false;
                }


            }
            //demo20 not exists
            else
            {
                MessageBox.Show("Demo20 file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.Close();
                return false;

            }

        }
        #endregion

        #region FRM_Tantosha_Load
        private void FRM_Tantosha_Load(object sender, EventArgs e)
        {
            //check demo20 and connection
            if (Demo_test())
            {
                try
                {
                    connection.Open();
                    connection.Close();
                }
                catch (Exception erg)
                {
                    MessageBox.Show(erg.Message);       //connection error
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
        #endregion

        #region BT_NewInput_Click
        private void BT_NewInput_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();      // get connection
                // change textboxes enable
                TB_TTSJidoCode.BackColor = Color.White;
                TB_PWD.BackColor = Color.White;
                TB_TTSname.BackColor = Color.White;
                TB_Sname2.BackColor = Color.White;
                TB_BumonCode.BackColor = Color.White;
                BT_NewInput.Enabled = false;
                BT_ChangeInput.Enabled = false;
                BT_Save.Enabled = true;
                BT_Cancel.Enabled = true;
                BT_Delete.Enabled = false;
                TB_TTSJidoCode.Enabled = true;
                BT_JidoCode.Enabled = true;
                TB_PWD.Enabled = true;
                TB_TTSname.Enabled = true;
                TB_TTSkana.Enabled = true;
                TB_Sname.Enabled = true;
                TB_Sname2.Enabled = true;
                TB_TTSMail.Enabled = true;
                CB_KyotenName.Enabled = true;
                BT_Bumoncode.Enabled = true;
                TB_BumonCode.Enabled = true;
                DGV_Kotei.Enabled = true;
                DTP_Taisha.Enabled = true;
                CHB_Kanrishafuragu.Enabled = true;
                CHB_Taishafuragu.Enabled = true;

                //retrieve kyoten list from database and place in combobox
                string KyotenQuery = "SELECT cCO,sKYOTEN FROM m_j_info";
                MySqlCommand cmd = new MySqlCommand(KyotenQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("cCO", typeof(string));
                dt.Columns.Add("sKYOTEN", typeof(string));
                dt.Rows.Add("");
                dt.Load(reader);
                cmd.ExecuteNonQuery();
                CB_KyotenName.ResetText();
                CB_KyotenName.DisplayMember = "sKYOTEN";
                CB_KyotenName.ValueMember = "cCO";
                CB_KyotenName.DataSource = dt;

                //read Kotei list from database and add in datagridview
                String KoteiQuery = "SELECT sSAGYOBUNRUI,cSAGYOBUNRUI FROM m_shijisho_sagyobunrui where fDEL='0' order by nJUNBAN asc ";
                cmd.CommandText = KoteiQuery;
                reader = cmd.ExecuteReader();
                DGV_Kotei.Rows.Clear();
                while (reader.Read())
                {
                    DGV_Kotei.Rows.Add(false, reader["sSAGYOBUNRUI"].ToString(), reader["cSAGYOBUNRUI"].ToString());
                }
                DGV_Kotei.Columns[0].DefaultCellStyle.SelectionBackColor = Color.White;
                DGV_Kotei.Columns[1].DefaultCellStyle.SelectionBackColor = SystemColors.ControlLight;
                TB_TTSJidoCode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);        // connection error
            }
            connection.Close();
        }
        #endregion

        #region BT_Cancel_Click
        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("取消してもよろしいでしょうか？", "確認", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                ChangeEnable();     // change textbox enable
            }
        }
        #endregion

        #region TB_BumonCode_Leave
        private void TB_BumonCode_Leave(object sender, EventArgs e)
        {
            try
            {
                connection.Open();      // get connection
                if (TB_BumonCode.Text.Length != 0)
                {
                    if (TB_BumonCode.Text.Length == 1)
                    {
                        TB_BumonCode.Text = "0" + TB_BumonCode.Text;
                    }
                    // read bumon name accordin bumoncode
                    String query = "select cBUMON,sBUMON from m_bumon where cBUMON='" + TB_BumonCode.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            TB_BumonName.Text = reader["sBUMON"].ToString();        //place bumon name in textbox
                        }
                    }
                    else
                    {
                        MessageBox.Show("データがありません。", "", MessageBoxButtons.OK);        //bumon not exist
                        TB_BumonName.ResetText();
                        TB_BumonCode.ResetText();
                        TB_BumonCode.Focus();
                    }
                }
                else
                {
                    TB_BumonName.ResetText();
                    TB_BumonCode.ResetText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);        // connection error
            }
            connection.Close();
        }
        #endregion

        #region BT_Bumoncode_Click
        private void BT_Bumoncode_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();      // check connection
                connection.Close();
                string c = TB_BumonCode.Text;
                DLG_BumonKensaku sform = new DLG_BumonKensaku(this, null);       // call FRM_BumonKensaku form
                sform.ShowDialog();
                if (c != TB_BumonCode.Text)
                    TextboxForecolorChange(TB_BumonCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);        // connection error
                connection.Close();
            }

        }
        #endregion

        #region KeyPress Event

        // TB_TTSname,TB_TTSkana,TB_Sname,TB_Sname2,TB_TTSMail,TB_PWD,TB_BumonCode,TB_TTSJidoCode KeyPress
        private void TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((TextBox)sender) == TB_BumonCode || ((TextBox)sender) == TB_TTSJidoCode)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);         // bumon code and tantousha code allow enter numbers
            }
            else if (((TextBox)sender) == TB_PWD)
            {
                e.Handled = e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '\x1';      // password not allow special characters
            }
            else if (((TextBox)sender) == TB_Sname2)
            {
                e.Handled = char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Back;        // not allow enter space in 略称２文字
            }
            // \x1 is ctrl+a, \u001a is ctrl+z, \x3 is ctrl+c ,\u0016 is ctrl+v,\b is backspace

            if (!char.IsControl(e.KeyChar))
            {
                if (((TextBox)sender).SelectionLength == 1)
                {
                    string text = ((TextBox)sender).SelectedText;
                    char c = Convert.ToChar(text);
                    if ((((TextBox)sender) == TB_BumonCode && char.IsDigit(e.KeyChar)) || (((TextBox)sender) != TB_BumonCode && ((TextBox)sender) != TB_PWD && ((TextBox)sender) != TB_Sname2) || (((TextBox)sender) == TB_PWD && e.KeyChar != (char)Keys.Space && (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar))) || (((TextBox)sender) == TB_Sname2 && !char.IsSeparator(e.KeyChar)))
                    {
                        if (e.KeyChar != c)         // check keypress key and selected text are same or not
                        {
                            TextboxForecolorChange((TextBox)sender);
                        }
                    }
                }
                else if (((TextBox)sender).SelectionLength > 1)
                {
                    if ((((TextBox)sender) == TB_BumonCode && char.IsDigit(e.KeyChar)) || (((TextBox)sender) != TB_BumonCode && ((TextBox)sender) != TB_PWD && ((TextBox)sender) != TB_Sname2) || (((TextBox)sender) == TB_PWD && e.KeyChar != (char)Keys.Space && (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar))) || (((TextBox)sender) == TB_Sname2 && !char.IsSeparator(e.KeyChar)))
                    {
                        TextboxForecolorChange((TextBox)sender);
                    }
                }
                else
                {
                    if (((TextBox)sender).MaxLength != ((TextBox)sender).Text.Length)
                    {
                        if ((((TextBox)sender) == TB_PWD && e.KeyChar != (char)Keys.Space && (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar))) || ((TextBox)sender) != TB_PWD)
                        {
                            TextboxForecolorChange((TextBox)sender);
                        }
                    }
                    else
                    {
                        if (((((TextBox)sender) == TB_BumonCode || ((TextBox)sender) == TB_TTSJidoCode) && char.IsDigit(e.KeyChar)) || (((TextBox)sender) == TB_PWD && e.KeyChar != (char)Keys.Space && (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar))))
                        {
                            if (((TextBox)sender).SelectionStart != ((TextBox)sender).Text.Length && e.KeyChar != (char)Keys.Back && ((TextBox)sender).SelectionLength == 0)
                            {
                                int selstart = ((TextBox)sender).SelectionStart;
                                string text = ((TextBox)sender).Text;
                                ((TextBox)sender).Text = ((TextBox)sender).Text.Remove(((TextBox)sender).Text.Length - 1);
                                ((TextBox)sender).SelectionStart = selstart;
                                if ((selstart != 0 && text != ((TextBox)sender).Text + e.KeyChar.ToString()) || (selstart == 0 && text != e.KeyChar.ToString() + ((TextBox)sender).Text))       // for bumon code
                                {
                                    TextboxForecolorChange((TextBox)sender);
                                }

                            }
                        }
                    }
                }

            }
            else if (e.KeyChar == '\u0016' && Clipboard.GetText() != "" && ((TextBox)sender) != TB_PWD && ((TextBox)sender) != TB_Sname2)      // paste in textbox by clicking ctrl+c
            {
                if (((TextBox)sender) == TB_BumonCode || ((TextBox)sender) == TB_TTSJidoCode)
                {
                    if (Regex.IsMatch(Clipboard.GetText(), @"^\d+$"))        // check clipboard text is numbers or not
                    {
                        if (((TextBox)sender).SelectionLength == 1)
                        {
                            string text = ((TextBox)sender).SelectedText;
                            if (Clipboard.GetText() != text)
                            {
                                TextboxForecolorChange((TextBox)sender);
                            }
                        }
                        else if (((TextBox)sender).SelectionLength == 0)
                        {
                            if (((TextBox)sender).MaxLength == ((TextBox)sender).Text.Length && ((TextBox)sender).SelectionStart != ((TextBox)sender).Text.Length && e.KeyChar != (char)Keys.Back)
                            {
                                int selstart = ((TextBox)sender).SelectionStart;
                                int txtlength = ((TextBox)sender).TextLength;
                                string text = ((TextBox)sender).Text;
                                string substring = text.Substring(selstart);
                                if (substring.Length < Clipboard.GetText().Length)
                                {
                                    for (int i = selstart; i < txtlength; i++)
                                    {
                                        ((TextBox)sender).Text = ((TextBox)sender).Text.Remove(((TextBox)sender).Text.Length - 1);
                                    }
                                }
                                else
                                {
                                    for (int i = 0; i < Clipboard.GetText().Length; i++)
                                    {
                                        ((TextBox)sender).Text = ((TextBox)sender).Text.Remove(((TextBox)sender).Text.Length - 1);
                                    }
                                }
                                ((TextBox)sender).SelectionStart = selstart;
                                if ((selstart != 0 && text != ((TextBox)sender).Text + Clipboard.GetText()) || (selstart == 0 && text != Clipboard.GetText() + ((TextBox)sender).Text))
                                {
                                    TextboxForecolorChange((TextBox)sender);
                                }
                            }
                            else if (((TextBox)sender).MaxLength != ((TextBox)sender).Text.Length)
                            {
                                TextboxForecolorChange((TextBox)sender);
                            }
                        }
                        else
                        {
                            string text = ((TextBox)sender).SelectedText;
                            if (Clipboard.GetText() != text)
                            {
                                TextboxForecolorChange((TextBox)sender);
                            }
                        }
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (((TextBox)sender).SelectionLength != 0)
                    {
                        string text = ((TextBox)sender).SelectedText;
                        if (Clipboard.GetText() != text)
                        {
                            TextboxForecolorChange((TextBox)sender);
                        }
                    }
                    else if (((TextBox)sender).MaxLength != ((TextBox)sender).Text.Length)
                    {
                        TextboxForecolorChange((TextBox)sender);
                    }
                }
            }
            else if (e.KeyChar == '\x1')            //for ctrl+a
            {
                ((TextBox)sender).SelectAll();
                e.Handled = true;
            }
            else if (e.KeyChar == '\b' && (((TextBox)sender).SelectionStart != 0 || ((TextBox)sender).SelectionLength > 0))       // for backspace
            {
                TextboxForecolorChange((TextBox)sender);
            }
        }
        #endregion

        #region Textboxes KeyDown and TextChanged and MouseDown

        // TB_PWD,TB_TTSname,TB_TTSkana,TB_Sname,TB_Sname2,TB_TTSMail,TB_BumonCode KeyDown
        private void TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && ((TextBox)sender).SelectionStart != ((TextBox)sender).Text.Length)
            {
                TextboxForecolorChange((TextBox)sender);
            }
        }
        private void TB_TextChanged(object sender, EventArgs e)
        {
            if ((TextBox)sender == TB_BumonCode || (TextBox)sender == TB_TTSJidoCode)
            {
                ((TextBox)sender).Text = Microsoft.VisualBasic.Strings.StrConv(((TextBox)sender).Text, VbStrConv.Narrow);
            }
            else if ((TextBox)sender == TB_Sname2)
            {
                if (System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(TB_Sname2.Text) == 4)
                {
                    TB_Sname2.MaxLength = TB_Sname2.Text.Length;
                }
                else if (System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(TB_Sname2.Text) > 4)
                {
                    TB_Sname2.Text = TB_Sname2.Text.Remove(TB_Sname2.Text.Length - 1);
                }
                else
                {
                    TB_Sname2.MaxLength = 4;
                }
                TB_Sname2.SelectionStart = TB_Sname2.Text.Length;
            }
        }

        private void TB_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((TextBox)sender).ContextMenu = new ContextMenu();
            }
        }
        #endregion

        #region BT_TTSJidoCode_Click
        private void BT_TTSJidoCode_Click(object sender, EventArgs e)
        {
            //retrieve auto tantousha code
            String query = "select * from m_j_tantousha where cTANTOUSHA is not null and cTANTOUSHA!='' and cTANTOUSHA!='0000' and cTANTOUSHA REGEXP '^[0-9]+$' order by cTANTOUSHA asc ";
            int temp = 0;
            int code = 0;
            try
            {
                connection.Open();      // get connection
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = query;
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())          // read data
                {
                    String c = reader["cTANTOUSHA"].ToString();
                    code = Int32.Parse(c);      // convert tantousha code into integer

                    // check code differences > 1
                    if (code - temp == 1 && code != 9999)
                    {
                        temp = code;
                    }
                }
                reader.Close();
                if (temp != 9999)
                {
                    temp += 1;
                }
                String autocode = temp.ToString();
                // add 0 in front of the text when text length not equal 
                while (autocode.Length < 4 && autocode.Length != 0)
                {
                    autocode = "0" + autocode;
                }
                TB_TTSJidoCode.Text = autocode;     // place tantousha code in textbox
            }
            catch (Exception erg)
            {
                MessageBox.Show(erg.Message);       // connection error

            }
            connection.Close();
        }
        #endregion

        #region BT_ChangeInput_Click and  RequiredFieldIsBlank()
        private void BT_ChangeInput_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();      // check connection
                connection.Close();
                updateordelete = "update";
                textchangeindex = 0;
                DLG_TantoshaKensaku sform = new DLG_TantoshaKensaku(this);      // call FRM_TantoshaKensaku form
                sform.ShowDialog();
                BT_NewInput.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }
        private bool RequiredFieldIsBlank(TextBox tb)
        {
            // check txtboxes blank or not
            if (tb.Text == null || tb.Text == "")
            {
                tb.BackColor = Color.FromArgb(255, 255, 128);
                return true;
            }
            else
            {
                tb.BackColor = Color.White;
                return false;
            }
        }

        #endregion

        #region BT_Save_Click
        private void BT_Save_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();      // check connection
                DialogResult result = MessageBox.Show("登録してもよろしいでしょうか？", "確認", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    // check textboxes blank
                    Boolean blankTantoushaC = RequiredFieldIsBlank(TB_TTSJidoCode);
                    Boolean blankPWD = RequiredFieldIsBlank(TB_PWD);
                    Boolean blankTantoushaS = RequiredFieldIsBlank(TB_TTSname);
                    Boolean blankshortname2 = RequiredFieldIsBlank(TB_Sname2);
                    Boolean blankBumonC = RequiredFieldIsBlank(TB_BumonCode);
                    if (blankBumonC || blankTantoushaC || blankPWD || blankTantoushaS || blankshortname2)
                    {
                        MessageBox.Show("入力して下さい。", "", MessageBoxButtons.OK);
                    }
                    else if (TB_TTSJidoCode.Text == "0000")        // check code '0000'
                    {
                        if (!TB_TTSJidoCode.Enabled)
                        {
                            TB_TTSJidoCode.BackColor = DefaultBackColor;
                        }
                        TB_TTSJidoCode.ResetText();
                        MessageBox.Show("コードが０に設定できません。", "", MessageBoxButtons.OK);
                        TB_TTSJidoCode.Focus();

                    }
                    else
                    {
                        SaveData();     // save data in database
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);        // connection error
            }
            connection.Close();
        }
        #endregion

        #region SaveData()
        private void SaveData()
        {
            //get textboxes value
            String TantoushaC = TB_TTSJidoCode.Text;
            String TantoushaS = TB_TTSname.Text;
            String PWD = Encrypt(TB_PWD.Text);      //Encrypt password 
            String TantoushaSk = TB_TTSkana.Text;
            String TantoushaR = TB_Sname.Text;
            String TantoushaR2 = TB_Sname2.Text;
            String Mail = TB_TTSMail.Text;
            String KyotenC = CB_KyotenName.SelectedValue.ToString();
            String BumonC = TB_BumonCode.Text;
            String TaishaD = "null";
            if (DTP_Taisha.CustomFormat == "yyyy/MM/dd")
            {
                TaishaD = "'" + DTP_Taisha.Value.Date.ToString("yyyy-MM-dd") + " 00:00:00'";
            }
            String TaishaF = "0";
            String KanrishaF = "0";
            String KakuninC = null;
            if (CHB_Taishafuragu.Checked == true)
            {
                TaishaF = "1";
                KakuninC = "9999";
            }
            if (CHB_Kanrishafuragu.Checked == true)
            {
                KanrishaF = "1";
            }
            String datequery = "SELECT NOW()";      // get server datetime
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = datequery;
            DateTime dt = (DateTime)command.ExecuteScalar();
            String datetime = dt.ToString("yyyy-MM-dd hh:mm:ss");

            try
            {
                // check save or update
                if (TB_TTSJidoCode.Enabled == true)
                {
                    //save data in m_j_tantousha table
                    string q = "SELECT * FROM m_j_tantousha where cTANTOUSHA='" + TantoushaC + "'";
                    command.CommandText = q;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)         // check tantousha code exist or not
                    {
                        MessageBox.Show("データが既に存在しています。");      // tantousha code duplicate
                        savesuccess = false;
                        reader.Close();
                    }
                    else
                    {
                        reader.Close();
                        String query = "INSERT INTO m_j_tantousha";
                        query += " (`cTANTOUSHA`, `sTANTOUSHA`, `skTANTOUSHA`, `sTANTOUSHA_R`, `sTANTOUSHA_R2`, `dTAISHA`, `cBUMON`, `cKAKUNIN`, `sPWD`, `fTAISYA`, `dHENKOU`, `cHENKOUSYA`, `fKANRISHA`, `SMAIL`, `cKYOTEN`, `cKOTEI`, `ngenkatanka`)";
                        query += " VALUES ('" + TantoushaC + "', '" + TantoushaS + "', '" + TantoushaSk + "', '" + TantoushaR + "', '" + TantoushaR2 + "', " + TaishaD + ", '" + BumonC + "', '" + KakuninC + "', '" + PWD + "', '" + TaishaF + "', '" + datetime + "', '9999', '" + KanrishaF + "', '" + Mail + "', '" + KyotenC + "', null, null)";
                        command.CommandText = query;
                        command.ExecuteNonQuery();

                        //delete m_tantoushakoutei data according tantousha code for avoid duplicate data error
                        command = new MySqlCommand("DELETE FROM `m_tantoushakoutei` WHERE `cTANTOUSHA`='" + TantoushaC + "'", connection);
                        command.ExecuteNonQuery();

                        //insert koutei list in m_tantoushakoutei table
                        for (int i = 0; i < DGV_Kotei.Rows.Count; i++)
                        {
                            if (Convert.ToBoolean(DGV_Kotei.Rows[i].Cells[0].Value) == true)
                            {
                                String KouteiC = DGV_Kotei.Rows[i].Cells["CKotei"].Value.ToString();
                                String query1 = "INSERT INTO m_tantoushakoutei (`cTANTOUSHA`, `cKOUTEI`) VALUES('" + TantoushaC + "', '" + KouteiC + "')";
                                command.CommandText = query1;
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("登録しました。", "", MessageBoxButtons.OK);       // save successful
                        ChangeEnable();         // change textbox enable
                        savesuccess = true;
                    }
                }
                else
                {
                    //update data in m_j_tantousha table
                    string query = "UPDATE `m_j_tantousha` SET `sTANTOUSHA`='" + TantoushaS + "', `skTANTOUSHA`='" + TantoushaSk;
                    query += "', `sTANTOUSHA_R`='" + TantoushaR + "', `sTANTOUSHA_R2`='" + TantoushaR2 + "', `dTAISHA`=" + TaishaD;
                    query += ", `cBUMON`='" + BumonC + "', `cKAKUNIN`='" + KakuninC + "', `sPWD`='" + PWD + "', `fTAISYA`='" + TaishaF;
                    query += "', `dHENKOU`='" + datetime + "', `cHENKOUSYA`='9999', `fKANRISHA`='" + KanrishaF + "', `SMAIL`='" + Mail;
                    query += "', `cKYOTEN`='" + KyotenC + "', `cKOTEI`=null, `ngenkatanka`=null WHERE `cTANTOUSHA`='" + TantoushaC + "'";
                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    //delete m_tantoushakoutei data according tantousha code for avoid duplicate data error
                    command = new MySqlCommand("DELETE FROM `m_tantoushakoutei` WHERE `cTANTOUSHA`='" + TantoushaC + "'", connection);
                    command.ExecuteNonQuery();

                    //insert koutei list in m_tantoushakoutei table
                    for (int i = 0; i < DGV_Kotei.Rows.Count; i++)
                    {
                        if (Convert.ToBoolean(DGV_Kotei.Rows[i].Cells[0].Value) == true)
                        {
                            String KouteiC = DGV_Kotei.Rows[i].Cells["CKotei"].Value.ToString();
                            String query1 = "INSERT INTO m_tantoushakoutei (`cTANTOUSHA`, `cKOUTEI`) VALUES('" + TantoushaC + "', '" + KouteiC + "')";
                            command.CommandText = query1;
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("登録しました。", "", MessageBoxButtons.OK);       // update successful
                    ChangeEnable();         // change textbox enable
                    savesuccess = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show("登録できませんでした。", "", MessageBoxButtons.OK);
                savesuccess = false;
            }

        }
        #endregion

        #region ChangeEnable()
        private void ChangeEnable()
        {
            // change textboxes enable
            BT_NewInput.Enabled = true;
            BT_ChangeInput.Enabled = true;
            BT_Save.Enabled = false;
            BT_Cancel.Enabled = false;
            BT_Delete.Enabled = true;
            TB_TTSJidoCode.ResetText();
            TB_TTSJidoCode.Enabled = false;
            BT_JidoCode.Enabled = false;
            TB_PWD.ResetText();
            TB_PWD.Enabled = false;
            TB_TTSname.ResetText();
            TB_TTSname.Enabled = false;
            TB_TTSkana.ResetText();
            TB_TTSkana.Enabled = false;
            TB_Sname.ResetText();
            TB_Sname.Enabled = false;
            TB_Sname2.ResetText();
            TB_Sname2.Enabled = false;
            TB_TTSMail.ResetText();
            TB_TTSMail.Enabled = false;
            CB_KyotenName.ResetText();
            CB_KyotenName.Enabled = false;
            BT_Bumoncode.Enabled = false;
            TB_BumonCode.ResetText();
            TB_BumonName.ResetText();
            TB_BumonCode.Enabled = false;
            DGV_Kotei.Rows.Clear();
            DGV_Kotei.Enabled = false;
            DTP_Taisha.Value = DateTime.Today;
            DTP_Taisha.CustomFormat = "____/__/__";
            DTP_Taisha.Enabled = false;
            CHB_Kanrishafuragu.Checked = false;
            CHB_Taishafuragu.Checked = false;
            CHB_Kanrishafuragu.Enabled = false;
            CHB_Taishafuragu.Enabled = false;
            TB_TTSJidoCode.BackColor = DefaultBackColor;
            TB_PWD.BackColor = DefaultBackColor;
            TB_TTSname.BackColor = DefaultBackColor;
            TB_Sname2.BackColor = DefaultBackColor;
            TB_BumonCode.BackColor = DefaultBackColor;
            DTP_Taisha.Checked = false;
        }
        #endregion

        #region TB_TTSJidoCode_Leave
        private void TB_TTSJidoCode_Leave(object sender, EventArgs e)
        {
            // add 0 in front of the text when text lenght not equal 4
            while (TB_TTSJidoCode.Text.Length < 4 && TB_TTSJidoCode.Text.Length != 0)
            {
                TB_TTSJidoCode.Text = "0" + TB_TTSJidoCode.Text;
            }
        }
        #endregion

        #region TB_Sname2_Leave and timerTick
        private void TB_Sname2_Leave(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(timer_Tick);         // set timer 
            timer.Interval = 1;
            timer.Enabled = true;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            // check textbox text byte 
            //allow 4 byte
            if (System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(TB_Sname2.Text) != 4 && TB_Sname2.Text.Length != 0)
            {
                MessageBox.Show("担当者略称２文字は全角２文字、または半角４文字で登録してください。");
                TB_Sname2.ResetText();
                TB_Sname2.Focus();
            }
        }
        #endregion

        #region Encrypt and Decrypt
        public string Encrypt(string clearText)
        {
            #region delete
            //string EncryptionKey = "demo20";
            //byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            //using (Aes encryptor = Aes.Create())
            //{
            //    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            //    encryptor.Key = pdb.GetBytes(32);
            //    encryptor.IV = pdb.GetBytes(16);
            //    using (MemoryStream ms = new MemoryStream())
            //    {
            //        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
            //        {
            //            cs.Write(clearBytes, 0, clearBytes.Length);
            //            cs.Close();
            //        }
            //        clearText = Convert.ToBase64String(ms.ToArray());
            //    }
            //}
            //return clearText;
            #endregion

            string sKey;
            byte[] bKey;    //3DESの暗号キー
            byte[] bVector;//3DESのVector
            byte[] bEnc_Bfor;//暗号文 暗号化前
            byte[] bEnc;//暗号文

            TripleDES tdes = TripleDES.Create();
            // 暗号キーの取得
            sKey = GenerateKeyFromPassword("demo20", tdes.KeySize, tdes.BlockSize);
            if (sKey == null) return null;//エラー処理
                                          //string→bytes
            bEnc_Bfor = Encoding.UTF8.GetBytes(clearText);
            bKey = Convert.FromBase64String(sKey);
            bVector = Encoding.Default.GetBytes("00000000");

            //パラメータ設定
            tdes.IV = bVector;
            tdes.Key = bKey;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            // encryption
            ICryptoTransform ict = tdes.CreateEncryptor();
            bEnc = ict.TransformFinalBlock(bEnc_Bfor, 0, bEnc_Bfor.Length);

            return Convert.ToBase64String(bEnc, 0, bEnc.Length);
        }
        public string Decrypt(string cipherText)
        {
            #region delete
            //string EncryptionKey = "demo20";
            //cipherText = cipherText.Replace(" ", "+");
            //byte[] cipherBytes = Convert.FromBase64String(cipherText);
            //using (Aes encryptor = Aes.Create())
            //{
            //    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            //    encryptor.Key = pdb.GetBytes(32);
            //    encryptor.IV = pdb.GetBytes(16);
            //    using (MemoryStream ms = new MemoryStream())
            //    {
            //        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
            //        {
            //            cs.Write(cipherBytes, 0, cipherBytes.Length);
            //            cs.Close();
            //        }
            //        cipherText = Encoding.Unicode.GetString(ms.ToArray());
            //    }
            //}
            //return cipherText;
            #endregion

            string sKey;
            byte[] bKey;//3DESの暗号キー
            byte[] bVector;//3DESのVector
            byte[] bEnc;//復号文
            byte[] bDnc;//暗号文 

            TripleDES tdes = TripleDES.Create();
            // 暗号キーの取得
            sKey = GenerateKeyFromPassword("demo20", tdes.KeySize, tdes.BlockSize);
            if (sKey == null) return null;//エラー処理
                                          //string→bytes
            bDnc = Convert.FromBase64String(cipherText);
            bKey = Convert.FromBase64String(sKey);
            bVector = Encoding.Default.GetBytes("00000000");

            //パラメータ設定
            tdes.IV = bVector;
            tdes.Key = bKey;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            // encryption
            ICryptoTransform ict = tdes.CreateEncryptor();
            ict = tdes.CreateDecryptor();
            bEnc = ict.TransformFinalBlock(bDnc, 0, bDnc.Length);

            //
            return Encoding.UTF8.GetString(bEnc);
        }
        #endregion

        #region GenerateKeyFromPassword
        private static string GenerateKeyFromPassword(string password, int keySize, int blockSize)
        {
            try
            {
                //パスワードから共有キーと初期化ベクタを作成する
                //saltを決める
                byte[] salt = System.Text.Encoding.UTF8.GetBytes("saltは必ず8バイト以上");
                //Rfc2898Derivebytesオブジェクトを作成する
                System.Security.Cryptography.Rfc2898DeriveBytes derivebytes =
                    new System.Security.Cryptography.Rfc2898DeriveBytes(password, salt);
                //.NET Framework 1.1以下の時は、PasswordDerivebytesを使用する
                //System.Security.Cryptography.PasswordDerivebytes derivebytes =
                //    new System.Security.Cryptography.PasswordDerivebytes(password, salt);
                //反復処理回数を指定する デフォルトで1000回
                derivebytes.IterationCount = 1000;

                //共有キーと初期化ベクタを生成する
                byte[] key;
                string sKey;
                key = derivebytes.GetBytes(keySize / 8);
                sKey = Convert.ToBase64String(key);
                return sKey;
                //iv = derivebytes.GetBytes(blockSize / 8);
                //iv = Encoding.Default.GetBytes("00000000");
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region BT_Delete_Click
        private void BT_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();      // check connection
                connection.Close();
                updateordelete = "delete";
                DLG_TantoshaKensaku sform = new DLG_TantoshaKensaku(this);      // call FRM_TantoshaKensaku form
                sform.ShowDialog();
                if (updateordelete == "yesdelete")
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("削除してもよろしいでしょうか？", "確認", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            connection.Open();      // get connection
                            //delete data from m_j_tantousha table according to tantousha code
                            string ctantousha = TB_TTSJidoCode.Text;
                            MySqlCommand cmd = new MySqlCommand("DELETE FROM `m_j_tantousha` WHERE `cTANTOUSHA`='" + ctantousha + "'", connection);
                            cmd.ExecuteNonQuery();
                            //delete koutei lists from m_tantoushakoutei table according to tantousha code
                            cmd = new MySqlCommand("DELETE FROM `m_tantoushakoutei` WHERE `cTANTOUSHA`='" + ctantousha + "'", connection);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("削除しました。", "", MessageBoxButtons.OK);
                            ChangeEnable();
                        }
                        else
                        {
                            ChangeEnable();     // textbox enable change
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);        // connection error
                    }
                    connection.Close();
                }
                BT_NewInput.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);        // connection error
                connection.Close();
            }
        }
        #endregion

        # region BT_Close_Click and  FRM_Tantosha_FormClosing
        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FRM_Tantosha_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (BT_NewInput.Enabled == true || (BT_NewInput.Enabled == false && textchangeindex == 0 && BT_JidoCode.Enabled ==false))
                {
                    e.Cancel = false;
                }
                else
                {
                    DialogResult result = MessageBox.Show("項目が変更されています。保存しますか？", "確認", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            connection.Open(); // get connection

                            // check textboxes blank or not
                            Boolean blankTantoushaC = RequiredFieldIsBlank(TB_TTSJidoCode);
                            Boolean blankPWD = RequiredFieldIsBlank(TB_PWD);
                            Boolean blankTantoushaS = RequiredFieldIsBlank(TB_TTSname);
                            Boolean blankshortname2 = RequiredFieldIsBlank(TB_Sname2);
                            Boolean blankBumonC = RequiredFieldIsBlank(TB_BumonCode);
                            if (blankBumonC || blankTantoushaC || blankPWD || blankTantoushaS || blankshortname2)
                            {
                                MessageBox.Show("入力して下さい。", "", MessageBoxButtons.OK);
                                e.Cancel = true;
                            }
                            else if (TB_TTSJidoCode.Text == "0000")        // check code '0000'
                            {
                                if (!TB_TTSJidoCode.Enabled)
                                {
                                    TB_TTSJidoCode.BackColor = DefaultBackColor;
                                }
                                TB_TTSJidoCode.ResetText();
                                MessageBox.Show("コードが０に設定できません。", "", MessageBoxButtons.OK);
                                TB_TTSJidoCode.Focus();
                                e.Cancel = true;
                            }
                            else
                            {
                                SaveData();             // insert data into database
                                if (!savesuccess)
                                {
                                    e.Cancel = true;
                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            e.Cancel = true;
                        }
                        connection.Close();
                    }
                    else if (result == DialogResult.No)
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }

                }

            }
        }
        #endregion

        #region Value change,text change Event
        private void DGV_Kotei_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            textchangeindex = 1;    // for form closing
        }
        private void DTP_Taisha_ValueChanged(object sender, EventArgs e)
        {
            DTP_Taisha.CustomFormat = (DTP_Taisha.Value != DTP_Taisha.MinDate) ? "yyyy/MM/dd" : " ";
            textchangeindex = 1;      // for form closing
        }
        private void CB_KyotenName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedindex != CB_KyotenName.SelectedIndex)
            {
                if (TB_TTSJidoCode.Enabled == false)
                {
                    CB_KyotenName.ForeColor = Color.Red;
                    textchangeindex = 1;        //for form closing
                }
                else
                {
                    CB_KyotenName.ForeColor = Color.Black;
                }
            }
        }
        private void CHB_Taishafuragu_CheckedChanged(object sender, EventArgs e)
        {
            textchangeindex = 1;        // for form closing
        }
        private void CHB_Kanrishafuragu_CheckedChanged(object sender, EventArgs e)
        {
            textchangeindex = 1;        // for form closing
        }

        #endregion

        #region DTP_Taisha_KeyDown and TextboxForecolorChange
        private void DTP_Taisha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                DTP_Taisha.Value = DateTime.Today;
                DTP_Taisha.CustomFormat = "____/__/__";
                DTP_Taisha.Checked = false;
            }
        }
        private void TextboxForecolorChange(TextBox txt)
        {
            if (TB_TTSJidoCode.Enabled == false)
            {
                txt.ForeColor = Color.Red;
                textchangeindex = 1;
            }
            else
            {
                txt.ForeColor = Color.Black;
            }
        }

        #endregion

        #region DGV_Kotei_RowPostPaint & DGV_Kotei_CurrentCellChanged
        private void DGV_Kotei_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (DGV_Kotei.Rows[e.RowIndex].Selected)
            {
                using (Pen pen = new Pen(Color.Black))
                {
                    int penWidth = 2;
                    pen.Width = penWidth;
                    int rowHeaderWidth = DGV_Kotei.RowHeadersVisible ?
                                     DGV_Kotei.RowHeadersWidth : 0;
                    int x = rowHeaderWidth;
                    int y = e.RowBounds.Top + (penWidth / 2);
                    int width = DGV_Kotei.Columns.GetColumnsWidth(
                            DataGridViewElementStates.Visible) - DGV_Kotei.HorizontalScrollingOffset + 1;
                    int height = e.RowBounds.Height - penWidth;
                    e.Graphics.DrawRectangle(pen, x, y, width, height);
                }

            }
        }
        private void DGV_Kotei_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGV_Kotei.CurrentCell != null && DGV_Kotei.CurrentCell.Selected)
            {
                int index = DGV_Kotei.CurrentCell.ColumnIndex;
                DGV_Kotei.Columns[index].DefaultCellStyle.SelectionBackColor = Color.White;
                if (index != 0)
                {
                    DGV_Kotei.Columns[index - 1].DefaultCellStyle.SelectionBackColor = SystemColors.ControlLight;
                }
                else
                {
                    DGV_Kotei.Columns[index + 1].DefaultCellStyle.SelectionBackColor = SystemColors.ControlLight;
                }
            }
        }




        #endregion

        
    }
}
