using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndusMap
{
    public partial class CNNTrainingForm : Form
    {
        //**************************************************************
        IndsMap im1;
        SqlConnection con;
        string strQuery;
        DataSet dataSet;
        int index = 0;
        int indexsym = 0;
        int count = 0;
        int tindexsym;
        int tindex;
        public string pathOut3 = @"A:\Indus\HSM\IndusFont1840Out3";
        int currsymbol;
        Bitmap sealbmp;
        int flip;
        //**************************************************************
        public CNNTrainingForm()
        {
            InitializeComponent();
        }
        //**************************************************************
        public CNNTrainingForm(IndsMap im)
        {
            InitializeComponent();
            flip = 0;
            this.im1 = im;
            string strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            con = new SqlConnection(strConnString);
            strQuery = "select C.img,C.imgNo,C.symImg from ClassData C";
            SqlCommand cmd1 = new SqlCommand(strQuery);
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = con;
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd1);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            con.Close();
            count = dataSet.Tables[0].Rows.Count;

            int wn = 10;
            string[] flnmsall = Directory.GetFiles(pathOut3, "*.bmp");
            Bitmap b0 = new Bitmap(flnmsall[0]);
            int hn = (flnmsall.Length + wn - 1) / wn;
            int wk = (int)(b0.Width * 1.1);
            int hk = (int)(b0.Height * 1.5);
            Bitmap bm = new Bitmap(wk * wn, hk * hn);
            Graphics g = Graphics.FromImage(bm);
            g.Clear(Color.LightBlue);
            for (int n = 0; n < flnmsall.Length; n++)
            {
                Bitmap bn = new Bitmap(flnmsall[n]);
                FileInfo fi = new FileInfo(flnmsall[n]);
                string nm = fi.Name.Replace(".bmp", "");
                int x = (n % wn) * wk;
                int y = (n / wn) * hk;
                g.DrawImage(bn, new Point(x, y));
                Font drawFont = new Font("Arial", 8);
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                PointF drawPoint = new PointF(x + 10, y + b0.Height);
                g.DrawString(nm, drawFont, drawBrush, drawPoint);
            }
            g.Dispose();
        //    bm.Save("IndusSymbols.jpg");
            pictureBoxsymbol.Image = bm;
            pictureBoxsymbol.Size = bm.Size;
        }
        //**************************************************************
        private void buttonnextseal_Click(object sender, EventArgs e)
        {
            if (index < count)
            {
                flip = 0;
                Byte[] data = new Byte[0];
                if (dataSet.Tables[0].Rows[index]["img"] != DBNull.Value)
                    data = (Byte[])(dataSet.Tables[0].Rows[index]["img"]);
                else
                    data = (Byte[])(dataSet.Tables[0].Rows[index]["symImg"]);
                MemoryStream mem = new MemoryStream(data);
                sealbmp = (Bitmap)Image.FromStream(mem);
                pictureBoxseal.Image = sealbmp;
                tindex = index;               
                index++;
                labelseal.Text = index.ToString();
            }
            else if(index==count)
            {
                index = 0;
                Byte[] data = new Byte[0];
                if (dataSet.Tables[0].Rows[index]["img"] != DBNull.Value)
                    data = (Byte[])(dataSet.Tables[0].Rows[index]["img"]);
                else
                    data = (Byte[])(dataSet.Tables[0].Rows[index]["symImg"]);
                MemoryStream mem = new MemoryStream(data);
                sealbmp = (Bitmap)Image.FromStream(mem);
                pictureBoxseal.Image = sealbmp;
                tindex = index;
                index++;
                labelseal.Text = index.ToString();
            }
        }
        //**************************************************************
        private void pictureBoxseal_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int x = e.X;
            int y = e.Y;
            int sealno = (int)dataSet.Tables[0].Rows[tindex]["imgNo"];          
            string strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            con = new SqlConnection(strConnString);
            string strQueryloc = "insert into LocSymbol values(" + sealno + "," + currsymbol + "," + x + "," + y + ","+flip+")";
            SqlCommand cmd2 = new SqlCommand(strQueryloc);
            cmd2.CommandType = CommandType.Text;
            cmd2.Connection = con;
            con.Open();        
            cmd2.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            Cursor.Current = Cursors.Default;
        }
        //**************************************************************
        private void pictureBoxsymbol_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int wn = 10;
            string[] flnmsall = Directory.GetFiles(pathOut3, "*.bmp");
            Bitmap b0 = new Bitmap(flnmsall[0]);
            int hn = (flnmsall.Length + wn - 1) / wn;
            int wk = (int)(b0.Width * 1.1);
            int hk = (int)(b0.Height * 1.5);
            int n1 = e.Y / hk;
            int n2 = e.X / wk;
            currsymbol = n1 * wn + n2;
            labelsymb.Text = currsymbol.ToString();
            Cursor.Current = Cursors.Default;
        }
        //**************************************************************      
        private void buttonmirror_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            sealbmp.RotateFlip(RotateFlipType.Rotate180FlipY);
            pictureBoxseal.Image = sealbmp;
            if (flip == 0)
                flip = 1;
            else if (flip == 1)
                flip = 0;
            Cursor.Current = Cursors.Default;
        }
        //**************************************************************        
        private void buttonSealSymbol_Click(object sender, EventArgs e)
        {
            ViewSymbolSeal vss = new ViewSymbolSeal();
            vss.Show();
            vss.viewindussymbol();
        }
        //**************************************************************        
        private void buttonSymReg_Click(object sender, EventArgs e)
        {
            SymbolRegistration sr = new SymbolRegistration();
            sr.Show();
        }
        //**************************************************************        
    }
}
