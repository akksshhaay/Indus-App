using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IndusMap
{
    public partial class Register : Form
    {
        //**********************************************************
        public Register()
        {
            InitializeComponent();
        }
        //************************************************************
        private void buttonreg_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string name = textBoxname.Text.TrimEnd();
            string qual = textBoxqual.Text.TrimEnd();
            string email = textBoxemail.Text.TrimEnd();
            string pass = textBoxpass.Text.TrimEnd();
            string work = textBoxwork.Text.TrimEnd();
            string strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            string strQuery1 = "insert into Users (usname,password,work,qual,email) values('"+ name + "','"+ pass + "','"+ work + "','"+ qual + "','"+ email + "')";
            SqlCommand cmd1 = new SqlCommand(strQuery1);
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = con;
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
            Cursor.Current = Cursors.Default;
            this.Hide();
        }
        //************************************************************        
    }
}
