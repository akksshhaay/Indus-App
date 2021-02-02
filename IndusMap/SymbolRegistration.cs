using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndusMap
{
    public partial class SymbolRegistration : Form
    {
        Image img1;
        SqlConnection con;
        int symno;
        string temp = "A:\\CnnDataGrayScale1\\";
        public string pathOut4 = @"A:\Indus\HSM\IndusFont1840Out3";
        string strConnString;
        //***********************************************************************
        public SymbolRegistration()
        {
            InitializeComponent();
            strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            con = new SqlConnection(strConnString);
        }
        //***********************************************************************
        private void buttonAddSymbol_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            textBoxsymno.Text = symno.ToString();
            MemoryStream ms1 = new MemoryStream();
            img1.Save(ms1, ImageFormat.Jpeg);
            byte[]  photo1 = ms1.ToArray();
            ms1.Close();
            string strQuery1 = "insert into SymbolonSeal(symbolno,symbolonseal) values(@sno,@img);";
            SqlCommand cmd1 = new SqlCommand(strQuery1);
            cmd1.Parameters.Add("@img", SqlDbType.Image).Value = photo1;
            cmd1.Parameters.Add("@sno", SqlDbType.Int).Value = symno;
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = con;
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
            Cursor.Current = Cursors.Default;
        }
        //***********************************************************************
        private void buttonselectimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img1 = Image.FromFile(ofd.FileName);
                System.IO.FileInfo fInfo = new System.IO.FileInfo(ofd.FileName);
                string fn = fInfo.DirectoryName.Replace(temp,"");
                symno = int.Parse(fn);
                textBoxsymno.Text = symno.ToString();
                pictureBoxsymimg.Image = img1;
            }
        }
        //***********************************************************************
        private void button_addall_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string[] folders = Directory.GetDirectories(temp);
            int symnoall;
            for(int i=0;i<folders.Length;i++)
            {
                string[] flnmsall = Directory.GetFiles(folders[i], "*.bmp");
                for(int j=0;j<flnmsall.Length;j++)
                {
                    System.IO.FileInfo fInfo = new System.IO.FileInfo(flnmsall[j]);
                    string fn = fInfo.DirectoryName.Replace(temp, "");
                    symnoall = int.Parse(fn);
                    Bitmap b0 = new Bitmap(flnmsall[j]);
                    Image imgall = b0;
                    MemoryStream msall = new MemoryStream();
                    imgall.Save(msall, ImageFormat.Jpeg);
                    byte[] photoall = msall.ToArray();
                    msall.Close();
                    string strQuery1 = "insert into SymbolonSeal(symbolno,symbolonseal) values(@sno,@img);";
                    SqlCommand cmd1 = new SqlCommand(strQuery1);
                    cmd1.Parameters.Add("@img", SqlDbType.Image).Value = photoall;
                    cmd1.Parameters.Add("@sno", SqlDbType.Int).Value = symnoall;
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Connection = con;
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }
            }
            Cursor.Current = Cursors.Default;
        }
        //***********************************************************************
        private void button_excel_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string[] flnmsall = Directory.GetFiles(pathOut4);
            for (int i = 0; i < 1840; i++)
            {
                Bitmap b0 = new Bitmap(flnmsall[i]);             
                Size size = new Size(250, 300);
                Image newimg = new Bitmap(size.Width, size.Height);
                using (Graphics g = Graphics.FromImage((Bitmap)newimg))
                {
                    g.CompositingQuality = CompositingQuality.HighQuality;
                    g.CompositingMode = CompositingMode.SourceCopy;
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    g.DrawImage(b0, new Rectangle(Point.Empty, size));
                }
                MemoryStream ms3 = new MemoryStream();
                newimg.Save(ms3, ImageFormat.Jpeg);
                byte[] photo3 = ms3.ToArray();
                ms3.Close();
                string strQuery1 = "insert into SymbolData(id,symbol) values(@id,@img)";
                SqlCommand cmd1 = new SqlCommand(strQuery1);
                cmd1.Parameters.Add("@id", SqlDbType.Int).Value = i;
                cmd1.Parameters.Add("@img", SqlDbType.Image).Value = photo3;
                cmd1.CommandType = CommandType.Text;
                SqlConnection con = new SqlConnection(strConnString);
                cmd1.Connection = con;
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                con.Dispose();
            }
            Cursor.Current = Cursors.Default;         

        }
        //***********************************************************************
    }
}
