using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing.Drawing2D;

namespace IndusMap
{
    public partial class AddSealData : Form
    {
        //************************************************************************************************************
        Image img1, img2, img3;
        string sealdescription, sealwebsites, strConnString;
        int sealtime,broken, location, symtype, sealtype, sealno;
        //************************************************************************************************************
        public AddSealData()
        {
            
            InitializeComponent();
        }
        //************************************************************************************************************
        private void AddSealData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'indusDbDataSet4.Year' table. You can move, or remove it, as needed.
            this.yearTableAdapter.Fill(this.indusDbDataSet4.Year);
            // TODO: This line of code loads data into the 'indusDbDataSet3.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.indusDbDataSet3.Location); 
            // TODO: This line of code loads data into the 'indusDbDataSet2.MotifMaster' table. You can move, or remove it, as needed.
            this.motifMasterTableAdapter.Fill(this.indusDbDataSet2.MotifMaster);
            // TODO: This line of code loads data into the 'indusDbDataSet1.ClassType' table. You can move, or remove it, as needed.
            this.classTypeTableAdapter1.Fill(this.indusDbDataSet1.ClassType);
            // TODO: This line of code loads data into the 'indusDbDataSet.ClassType' table. You can move, or remove it, as needed.
            this.classTypeTableAdapter.Fill(this.indusDbDataSet.ClassType);
            strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        }
        //************************************************************************************************************
        private void buttonoriseal_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img1 = Image.FromFile(ofd.FileName);
                pictureBox1.Image = img1;
            }
        }
        //************************************************************************************************************
        private void buttonsymbolicimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img2 = Image.FromFile(ofd.FileName);
                pictureBox2.Image = img2;
            }
        }
        //************************************************************************************************************
        private void buttontxtimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img3 = Image.FromFile(ofd.FileName);
                pictureBox3.Image = img3;
            }
        }
        //************************************************************************************************************
        private void button_adddata_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            sealdescription = txtboxdesc.Text.ToString().TrimEnd();
            sealwebsites = txtboxwebsite.Text.ToString().TrimEnd(); 
            if(chkboxbroken.Checked)
            {
                broken=1;
            }
            else
            {
                broken=0;
            }
            location = (int)comboboxlocation.SelectedValue;
            symtype =  (int)comboboxsymbolicimage.SelectedValue;
            sealtype = (int)comboboxsealtype.SelectedValue;
            sealtime = (int)(cbYear.SelectedValue);
            //string strQuery2 = "insert into Images(OriginalSeal,SymbolicImage,TextImage) values (@OriginalSeal, @SymbolicImage, @TextImage)";

            //adding images
            Size size = new Size(400, 400);
            byte[] photo1, photo2, photo3 ;
            if (img1 != null)
            {
                MemoryStream ms1 = new MemoryStream();
                Image sealimage = img1;
                Image newimg = new Bitmap(size.Width, size.Height);
                using (Graphics g = Graphics.FromImage((Bitmap)newimg))
                {
                    g.CompositingQuality = CompositingQuality.HighQuality;
                    g.CompositingMode = CompositingMode.SourceCopy;
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    g.DrawImage(sealimage, new Rectangle(Point.Empty, size));
                }
                newimg.Save(ms1, ImageFormat.Jpeg);
                photo1 = ms1.ToArray();
                ms1.Close();
            }
            else
            {
                photo1 = null;
            }

            if (img2 != null)
            {
                MemoryStream ms2 = new MemoryStream();
                Image symbolimage = img2;
                Image newimg1 = new Bitmap(size.Width, size.Height);
                using (Graphics g = Graphics.FromImage((Bitmap)newimg1))
                {
                    g.CompositingQuality = CompositingQuality.HighQuality;
                    g.CompositingMode = CompositingMode.SourceCopy;
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    g.DrawImage(symbolimage, new Rectangle(Point.Empty, size));
                }
                newimg1.Save(ms2, ImageFormat.Jpeg);
                photo2 = ms2.ToArray();
                ms2.Close();
            }
            else
            {
                photo2 = null;
            }

            if (img3 != null)
            {
                MemoryStream ms3 = new MemoryStream();
                Image textimage = img3;
                Image newimg2 = new Bitmap(size.Width, size.Height);
                using (Graphics g = Graphics.FromImage((Bitmap)newimg2))
                {
                    g.CompositingQuality = CompositingQuality.HighQuality;
                    g.CompositingMode = CompositingMode.SourceCopy;
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    g.DrawImage(textimage, new Rectangle(Point.Empty, size));
                }
                newimg2.Save(ms3, ImageFormat.Jpeg);
                photo3 = ms3.ToArray();
                ms3.Close();
            }
            else
            {
                photo3 = null;
            }

            if (sealwebsites=="")
            {
                lblValidatorWL.Visible = true;
            }
            else
            {
                lblValidatorWL.Visible = false;

                string strQuery1 = "insert into ClassData(link,img,textImg,symImg,descp,fk_classId,fk_locId,fk_year,isBroken,fk_motif) values(@link,@img,@textImg,@symImg,@descp,@fk_classId,@fk_locId,@year,@isBroken,@fk_motif)";
                SqlCommand cmd1 = new SqlCommand(strQuery1);
                cmd1.Parameters.Add("@link", SqlDbType.VarChar).Value = sealwebsites;
                if(img1!=null)
                    cmd1.Parameters.Add("@img", SqlDbType.Image).Value = photo1;
                else
                    cmd1.Parameters.Add("@img", SqlDbType.Image).Value = DBNull.Value;
                if (img2 != null)
                    cmd1.Parameters.Add("@textImg", SqlDbType.Image).Value = photo2;
                else
                    cmd1.Parameters.Add("@textImg", SqlDbType.Image).Value = DBNull.Value;
                if (img3 != null)
                    cmd1.Parameters.Add("@symImg", SqlDbType.Image).Value = photo3;
                else
                    cmd1.Parameters.Add("@symImg", SqlDbType.Image).Value = DBNull.Value;

                cmd1.Parameters.Add("@descp", SqlDbType.VarChar).Value = sealdescription;               
                cmd1.Parameters.Add("@fk_classId", SqlDbType.Int).Value = sealtype;
                cmd1.Parameters.Add("@fk_locId", SqlDbType.Int).Value = location;
                cmd1.Parameters.Add("@year", SqlDbType.Int).Value = sealtime;
                cmd1.Parameters.Add("@isBroken", SqlDbType.Int).Value = broken;
                cmd1.Parameters.Add("@fk_motif", SqlDbType.Int).Value = symtype;

                //Connecting to database
                SqlConnection con = new SqlConnection(strConnString);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = con;
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                Cursor.Current = Cursors.Default;
                this.Hide();
                lblValidatorWL.Visible = false;
            }
        }
        //************************************************************************************************************      
        private void pictureBoxhelp_Click(object sender, EventArgs e)
        {
            HelpSymbol hs = new HelpSymbol();
            hs.Show();
        }
        //************************************************************************************************************      
        //************************************************************************************************************      
    }
}
