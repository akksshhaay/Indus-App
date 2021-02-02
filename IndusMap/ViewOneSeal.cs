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
    public partial class ViewOneSeal : Form
    {
        //*********************************************************************************
        SqlConnection con;
        int year;
        //*********************************************************************************
        public ViewOneSeal()
        {
            InitializeComponent();
            string strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            con = new SqlConnection(strConnString);
            Bitmap timeimg = new Bitmap(@"A:\IndusDBApp\timeline.bmp");
            pictureBoxtime.Image = timeimg;
        }
        //*********************************************************************************
        public void ShowData(int no)
        {
            string strQuery = "select C.img,C.textImg,C.symImg,C.descp,C.link,T.className,M.motifName,L.locName,Y.yr,C.isBroken from ClassData C,Location L,ClassType T,MotifMaster M,Year Y where C.fk_locId=L.id and C.fk_classId=T.Id and C.fk_year=Y.id and C.fk_motif=M.id and C.imgNo="+ no+" ";          
            SqlCommand cmd1 = new SqlCommand(strQuery);
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = con;
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd1);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            con.Close();
            int count = dataSet.Tables[0].Rows.Count;
            if(count>0)
            {
                Byte[] ddata = new Byte[0];
                if (dataSet.Tables[0].Rows[0]["img"] != DBNull.Value)
                {
                    ddata = (Byte[])(dataSet.Tables[0].Rows[0]["img"]);
                     MemoryStream mem1 = new MemoryStream(ddata);
                     pictureBox1.Image = Image.FromStream(mem1);
                }
                else
                {
                    //pictureBox1.Visible = false;
                }

                    
                Byte[] ddata1 = new Byte[0];
                if (dataSet.Tables[0].Rows[0]["textImg"] != DBNull.Value)
                {
                    ddata1 = (Byte[])(dataSet.Tables[0].Rows[0]["textImg"]);
                    MemoryStream mem2 = new MemoryStream(ddata1);
                    pictureBox2.Image = Image.FromStream(mem2);
                }
                else
                {
                    //pictureBox2.Visible = false;
                }

                Byte[] ddata2 = new Byte[0];
                if (dataSet.Tables[0].Rows[0]["symImg"] != DBNull.Value)
                {
                    ddata2 = (Byte[])(dataSet.Tables[0].Rows[0]["symImg"]);
                    MemoryStream mem3 = new MemoryStream(ddata2);
                    pictureBox3.Image = Image.FromStream(mem3);
                }

                textBoxdesc.Text = (string)dataSet.Tables[0].Rows[0]["descp"];
                textBoxlink.Text = (string)dataSet.Tables[0].Rows[0]["link"];
                year = (int)dataSet.Tables[0].Rows[0]["yr"];

                //int display = 2600 - year;
                //int dx = 35 + display;
                //Graphics g = pictureBoxtime.CreateGraphics();
                //Point p1 = new Point(dx, 21);
                //Point p2 = new Point(dx, 78);
                //Pen p = new Pen(Color.Red);
                //g.DrawLine(p, p1, p2);
                //Point p3 = new Point(dx - 32, 5);
                //g.DrawString("Year=" + year.ToString(), Font, Brushes.Red, p3);

                textBoxsealtype.Text = (string)dataSet.Tables[0].Rows[0]["className"];
                textBoxloc.Text = (string)dataSet.Tables[0].Rows[0]["locName"];
                textBoximgtype.Text = (string)dataSet.Tables[0].Rows[0]["motifName"];
                int broken = (int)dataSet.Tables[0].Rows[0]["isBroken"];
                if(broken==1)
                {
                    textBoxbrk.Text = "Yes";
                }
                else
                {
                    textBoxbrk.Text = "No";
                }
            }
        }
        //*********************************************************************************
        private void pictureBoxtime_Click(object sender, EventArgs e)
        {
            if (year == 0000)
            {
                MessageBox.Show("Seal's Time is not Available");
            }
            else
            {
                int display = 2600 - year;
                int dx = 35 + display;
                Graphics g = pictureBoxtime.CreateGraphics();
                Point p1 = new Point(dx, 21);
                Point p2 = new Point(dx, 78);
                Pen p = new Pen(Color.Red);
                g.DrawLine(p, p1, p2);
                Point p3 = new Point(dx - 32, 5);
                g.DrawString("Year=" + year.ToString(), Font, Brushes.Red, p3);
            }
        }

        //*********************************************************************************
        
    }
}
