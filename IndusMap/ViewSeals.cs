using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace IndusMap
{
    public partial class ViewSeals : Form
    {
        //****************************************************************
        IndsMap im;
        public string cloc;
        SqlConnection con;
        string strQuery;
        DataSet dataSet;
        bool symbol;
        int cx, cy;
        Rectangle rect;
        int symno;
        int subsymno;
        string pathout=@"A:\CnnSymbol";
        //****************************************************************
        public ViewSeals()
        {
            InitializeComponent();
            im = new IndsMap();
            symbol = false;
            string strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            con=new SqlConnection(strConnString);
        }
        //****************************************************************
        public void DisplayselectedSymbols(string sender,string query)
        {
            if(sender == "pictureBox1")
            {
                strQuery = "select C.img,C.imgNo,C.symImg from ClassData C,Location L where C.fk_locId=L.id and L.locName='" + cloc + "'";
            }
            else if (sender == "button2")
            {
                strQuery = "select C.img,C.imgNo,C.symImg from ClassData C";
            }
            else if(sender == "cust")
            {
                strQuery = query;
            }
            else if(sender == "symbol")
            {
                symbol = true;
                symno = int.Parse(query);
                strQuery = "select C.symbolonseal from SymbolonSeal C where C.symbolno=" + symno + "";
            }
            SqlCommand cmd1 = new SqlCommand(strQuery);
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = con;
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd1);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            con.Close();
            int count = dataSet.Tables[0].Rows.Count;
            if (count > 0 && sender != "symbol")
            {
                Byte[] data = new Byte[0];
                if (dataSet.Tables[0].Rows[0]["img"] != DBNull.Value)
                    data = (Byte[])(dataSet.Tables[0].Rows[0]["img"]);
                else
                    data = (Byte[])(dataSet.Tables[0].Rows[0]["symImg"]);
                MemoryStream mem = new MemoryStream(data);
                Bitmap b0 = new Bitmap(Image.FromStream(mem));
                mem.Close();
                int wn = 3;
                int hn = (count + wn - 1) / wn;
                int wk = (int)(b0.Width * 1.1);
                int hk = (int)(b0.Height * 1.2);
                Bitmap bm = new Bitmap(wk * wn, hk * hn);
                Graphics g = Graphics.FromImage(bm);
                //g.Clear(Color.LightBlue);
                for (int n = 0; n < count; n++)
                {
                    Byte[] ddata = new Byte[0];
                    if (dataSet.Tables[0].Rows[n]["img"] != DBNull.Value)
                         ddata = (Byte[])(dataSet.Tables[0].Rows[n]["img"]);
                    else
                         ddata = (Byte[])(dataSet.Tables[0].Rows[n]["symImg"]);
                    MemoryStream mem1 = new MemoryStream(ddata);
                    Bitmap bn = new Bitmap(Image.FromStream(mem1));
                    mem.Close();
                    int x = (n % wn) * wk;
                    int y = (n / wn) * hk;
                    g.DrawImage(bn, new Point(x, y));
                    Font drawFont = new Font("Arial", 20);
                    SolidBrush drawBrush = new SolidBrush(Color.Black);
                    PointF drawPoint = new PointF(x + 10, y + b0.Height);
                    int no = (int)dataSet.Tables[0].Rows[n]["imgNo"]; 
                    string nm = no.ToString();
                    g.DrawString(nm, drawFont, drawBrush, drawPoint);
                }
                g.Dispose();
                pictureBoxseal.Image = bm;
                pictureBoxseal.Size = bm.Size;
            }
            else if (count > 0 && sender == "symbol")
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(dataSet.Tables[0].Rows[0]["symbolonseal"]);
                MemoryStream mem = new MemoryStream(data);
                Bitmap b0 = new Bitmap(Image.FromStream(mem));
                mem.Close();
                int wn = 3;
                int hn = (count + wn - 1) / wn;
                int wk = (int)(b0.Width * 1.1);
                int hk = (int)(b0.Height * 1.2);
                Bitmap bm = new Bitmap(wk * wn, hk * hn);
                Graphics g = Graphics.FromImage(bm);
                //g.Clear(Color.LightBlue);
                for (int n = 0; n < count; n++)
                {
                    Byte[] ddata = new Byte[0];
                    ddata = (Byte[])(dataSet.Tables[0].Rows[n]["symbolonseal"]);
                    MemoryStream mem1 = new MemoryStream(ddata);
                    Bitmap bn = new Bitmap(Image.FromStream(mem1));
                    mem.Close();
                    int x = (n % wn) * wk;
                    int y = (n / wn) * hk;
                    g.DrawImage(bn, new Point(x, y));
                }
                g.Dispose();
                pictureBoxseal.Image = bm;
                pictureBoxseal.Size = bm.Size;
            }
            else
            {            
                MessageBox.Show("No seals found for "+cloc);
                this.Hide();
            }
        }
        //*******************************************************************
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!symbol)
            {
                int wn = 3;
                int count = dataSet.Tables[0].Rows.Count;
                Byte[] data = new Byte[0];
                if (dataSet.Tables[0].Rows[0]["img"] != DBNull.Value)
                    data = (Byte[])(dataSet.Tables[0].Rows[0]["img"]);
                else
                    data = (Byte[])(dataSet.Tables[0].Rows[0]["symImg"]);
                MemoryStream mem = new MemoryStream(data);
                Bitmap b0 = new Bitmap(Image.FromStream(mem));
                mem.Close();
                int hn = (count + wn - 1) / wn;
                int wk = (int)(b0.Width * 1.1);
                int hk = (int)(b0.Height * 1.2);
                int n1 = e.Y / hk;
                int n2 = e.X / wk;
                int n = n1 * wn + n2;
                int no = (int)dataSet.Tables[0].Rows[n]["imgNo"];
                ViewOneSeal vos = new ViewOneSeal();
                vos.Show();
                vos.ShowData(no);
            }
            else
            {
                pictureBoxsymbol.Visible = true;
                buttonCrop.Visible = true;
                comboBoxtype.Visible = true;
                int count = dataSet.Tables[0].Rows.Count;
                int wn = 3;
                Byte[] data = new Byte[0];
                data = (Byte[])(dataSet.Tables[0].Rows[0]["symbolonseal"]);
                MemoryStream mem = new MemoryStream(data);
                Bitmap b0 = new Bitmap(Image.FromStream(mem));
                mem.Close();
                int hn = (count + wn - 1) / wn;
                int wk = (int)(b0.Width * 1.1);
                int hk = (int)(b0.Height * 1.2);
                int n1 = e.Y / hk;
                int n2 = e.X / wk;
                int n = n1 * wn + n2;
                subsymno = n;
                pictureBoxsymbol.Enabled = true;
                pictureBoxsymbol.BorderStyle = BorderStyle.FixedSingle;
                Byte[] data1 = new Byte[0];
                data1 = (Byte[])(dataSet.Tables[0].Rows[n]["symbolonseal"]);
                MemoryStream mem1 = new MemoryStream(data1);
                Bitmap b01 = new Bitmap(Image.FromStream(mem1));
                mem1.Close();
                pictureBoxsymbol.Image = b01;
                pictureBoxsymbol.Size = b01.Size;
            }
        }
        //****************************************************************
        private void pictureBoxsymbol_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            cx = e.X;
            cy = e.Y;
            int fno = (int)comboBoxtype.SelectedValue;
            //pictureBoxsymbol.Refresh();      
            string strQuery1 = "insert into FeaturesLoc(fk_symNo,fk_fno,locationx,locationy,ssNo) values(@sn,@fn,@lx,@ly,@subsym)";
            SqlCommand cmd1 = new SqlCommand(strQuery1);
            cmd1.Parameters.Add("@sn", SqlDbType.Int).Value = symno;
            cmd1.Parameters.Add("@fn", SqlDbType.Int).Value = fno;
            cmd1.Parameters.Add("@lx", SqlDbType.Int).Value = cx;
            cmd1.Parameters.Add("@ly", SqlDbType.Int).Value = cy;
            cmd1.Parameters.Add("@subsym", SqlDbType.Int).Value = subsymno;
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = con;
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
            Cursor.Current = Cursors.Default;
        }
        //****************************************************************
        //private void pictureBoxsymbol_Paint(object sender, PaintEventArgs e)
        //{
        //    //rect = new Rectangle(cx-27,cy-27,54,54);
        //    //e.Graphics.DrawRectangle(new Pen(Color.Green), rect);
        //}
        //****************************************************************
        //private void buttonCrop_Click(object sender, EventArgs e)
        //{

        //}
        //****************************************************************
        private void ViewSeals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'indusDbDataSet6.FeatureData' table. You can move, or remove it, as needed.
            this.featureDataTableAdapter.Fill(this.indusDbDataSet6.FeatureData);
            // TODO: This line of code loads data into the 'indusDbDataSet5.SymbolData' table. You can move, or remove it, as needed.
            this.symbolDataTableAdapter.Fill(this.indusDbDataSet5.SymbolData);

        }
        //****************************************************************
    }
}
