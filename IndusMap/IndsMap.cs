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
    public partial class IndsMap : Form
    {
        //*******************************************************************
        struct port
        {
            public string site;
            public Point location;
        }
        //*******************************************************************
        public string LabelText
        {
            get
            {
                return this.lblwlcm1.Text;
            }
            set
            {
                this.lblwlcm1.Text = value;
            }
        }
        //*******************************************************************
        Bitmap mapBmp;
        int x, y;
        float oldheight, oldwidth;
        float newheight, newwidth;
        string mapFlnm = @"A:\IndusDBApp\indusmap1.jpg";
        port[] ports;
        int mxPorts = 0;
        SqlConnection con;
        public string clickedlocation, strConnString;
        public bool loggedin;
        //*******************************************************************
        public IndsMap()
        {
            InitializeComponent();
            //this.lblwlcm1.Visible = false;
            this.buttonEdit.Enabled = false;
            this.button1.Enabled = false;
            loggedin = false;
            ports = new port[100];
            strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            con = new SqlConnection(strConnString);
            lblwlcm.Visible = false;
        }
        //*******************************************************************
        private void IndsMap_Shown(object sender, EventArgs e)
        {
            mapBmp = new Bitmap(mapFlnm);
            pictureBox1.Image = mapBmp;
            pictureBox1.Size = panel1.Size;
            oldheight = panel1.Height;
            oldwidth = panel1.Width;
            newheight = panel1.Height;
            newwidth = panel1.Width;
        }
        //*******************************************************************
        private void IndsMap_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Size = panel1.Size;
        }
        //*******************************************************************
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            x = e.X;
            y = e.Y;
            lblwlcm.Text = pt.ToString();
            float newx = x * (oldwidth / newwidth);
            float newy = y * (oldheight / newheight);
            x = (int)newx;
            y = (int)newy;
            lblwlcm.Text = "X=" + x + ",Y=" + y;
            if (e.Button == MouseButtons.Left)
            {//Operation
                string strQuery = "select x,y,locName from Location";
                SqlCommand cmd1 = new SqlCommand(strQuery);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = con;
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd1);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                con.Close();
                int count = dataSet.Tables[0].Rows.Count;
                mxPorts = count;
                for (int m = 0; m < count; m++)
                {
                    ports[m].site = (string)dataSet.Tables[0].Rows[m]["locName"];
                    int xt = (int)dataSet.Tables[0].Rows[m]["x"];
                    int yt = (int)dataSet.Tables[0].Rows[m]["y"];
                    Point ptdb = new Point(xt, yt);
                    ports[m].location = ptdb;
                }
                Rectangle rect = new Rectangle(x - 5, y - 5, 15, 15);
                for (int n = 0; n < mxPorts; n++)
                {
                    if (rect.Contains(ports[n].location))
                    {
                        txBxSite.Text = ports[n].site;
                        clickedlocation = ports[n].site;
                        break;
                    }
                }
                ViewSeals vs = new ViewSeals();
                vs.cloc = clickedlocation.TrimEnd();
                vs.Show();
                vs.DisplayselectedSymbols("pictureBox1","");
            }
            if (e.Button == MouseButtons.Right)
            {//Training
                Cursor.Current = Cursors.WaitCursor;
                ports[mxPorts].site = txBxSite.Text;
                ports[mxPorts].location = new Point(x, y);
                string strQuery2 = "insert into Location(x,y,locName) values (@x, @y, @name)";
                SqlCommand cmd2 = new SqlCommand(strQuery2);
                cmd2.Parameters.AddWithValue("@x", ports[mxPorts].location.X);
                cmd2.Parameters.AddWithValue("@y", ports[mxPorts].location.Y);
                cmd2.Parameters.AddWithValue("@name", ports[mxPorts].site);
                cmd2.CommandType = CommandType.Text;
                cmd2.Connection = con;
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();
                if (mxPorts < 100)
                    mxPorts++;
                Cursor.Current = Cursors.Default;
            }           
        }
        //*******************************************************************
        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            newheight = panel1.Height;
            newwidth = panel1.Width;                    
        }
        //*******************************************************************
        private void button1_Click(object sender, EventArgs e)
        {
            AddSealData asd = new AddSealData();
            asd.Show();
        }
        //*******************************************************************
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //*******************************************************************
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login ln = new Login(this);
            ln.Show();
        }
        //*******************************************************************
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
        }
        //*******************************************************************
        private void IndsMap_Load(object sender, EventArgs e)
        {
            //lblwlcm.Text = "Welcome User";
        }
        //*******************************************************************
        //public void login()
        //{
        //    if (loggedin)
        //    {
        //        this.lblwlcm1.Visible = true;
        //        this.buttonEdit.Enabled = true;
        //        this.button1.Enabled = true;
        //    }
        //}
        ////*******************************************************************
        //private void lblwlcm1_Click(object sender, EventArgs e)
        //{
        //    this.lblwlcm1.Text = "Welcome " + uname;
        //    this.buttonEdit.Enabled = true;
        //    this.button1.Enabled = true;
        //}
        //*******************************************************************
        private void button2_Click(object sender, EventArgs e)
        {
            ViewSeals vs = new ViewSeals();
            vs.Show();
            vs.DisplayselectedSymbols("button2","");
        }
        //*******************************************************************
        private void buttonEdit_Click(object sender, EventArgs e)
        {  
            //remaining implementation
            //ViewSeals vs = new ViewSeals();
            //vs.Show();
        }
        //*******************************************************************
        private void buttonCust_Click(object sender, EventArgs e)
        {
            CustomView cv = new CustomView();
            cv.Show();
        }
        //*******************************************************************
        private void buttonCNNtraining_Click(object sender, EventArgs e)
        {
            CNNTrainingForm cnntr = new CNNTrainingForm(this);
            cnntr.Show();
        }
        //*******************************************************************
    }
}