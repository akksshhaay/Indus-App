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
    public partial class Login : Form
    {
        IndsMap im;
        string name, strConnString;
        //********************************************************************
        public Login()
        {
            InitializeComponent();
        }
        //********************************************************************
        public Login(IndsMap imRef)
        {
            InitializeComponent();
            im = imRef;
        }
        //********************************************************************
        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string un,pass;
            un=textBoxun.Text.TrimEnd();
            pass=textBoxpass.Text.TrimEnd();
            //  DB
            strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            string strQuery1 ="select usname from Users where email='"+un+"' and password='"+pass+"'";
            SqlCommand cmd1 = new SqlCommand(strQuery1);
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = con;
            con.Open();
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                name = (String.Format("{0}", reader["usname"]));
                im.loggedin = true;
                im.lblwlcm1.Text = "Welcome " + name;
                im.buttonEdit.Enabled = true;
                im.button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Enter Valid Credentials");
            }
            reader.Close();
            con.Close();
            Cursor.Current = Cursors.Default;
            this.Hide();
        }
        //********************************************************************
    }
}
