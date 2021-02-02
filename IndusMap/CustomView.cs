using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndusMap
{
    public partial class CustomView : Form
    {
        //******************************************************************************
        string strqur, year;
        int phase=0;
        Bitmap timeimg = new Bitmap(@"A:\IndusDBApp\timeline.bmp");
        //******************************************************************************
        public CustomView()
        {
            InitializeComponent();            
            pictureBoxtime.Image = timeimg;
        }
        //******************************************************************************
        private void CustomView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'indusDbDataSet2.MotifMaster' table. You can move, or remove it, as needed.
            this.motifMasterTableAdapter.Fill(this.indusDbDataSet2.MotifMaster);
            // TODO: This line of code loads data into the 'indusDbDataSet1.ClassType' table. You can move, or remove it, as needed.
            this.classTypeTableAdapter.Fill(this.indusDbDataSet1.ClassType);

        }
        //******************************************************************************
        private void pictureBoxtime_MouseDown(object sender, MouseEventArgs e)
        {
            int dx = 55; ;
            int x = e.X;
            int temp = x - 35;
            int year = 2600 - temp;
            if (year <= 2600 && year > 2450)
            {
                phase = 1;
                dx = x;
                Graphics g = pictureBoxtime.CreateGraphics();
                Point p3 = new Point(dx - 20, 5);
                g.DrawString("Phase 1", Font, Brushes.Red, p3);
            }
            else if (year <= 2450 && year > 2200)
            {
                phase = 2;
                dx = x;
                Graphics g = pictureBoxtime.CreateGraphics();
                Point p3 = new Point(dx - 20, 5);
                g.DrawString("Phase 2", Font, Brushes.Red, p3);
            }
            else if (year <= 2200 && year >= 1900)
            {
                phase = 3;
                dx = x;
                Graphics g = pictureBoxtime.CreateGraphics();
                Point p3 = new Point(dx - 20, 5);
                g.DrawString("Phase 3", Font, Brushes.Red, p3);
            }
            
        }
        //******************************************************************************
        private void button1_Click(object sender, EventArgs e)
        {
            int broken,sealtype,motiftype;

            if (chkboxbroken.Checked)
                broken = 1;
            else
                broken = 0;

            sealtype = (int)comboboxsealtype.SelectedValue;
            motiftype = (int)comboboxsymbolicimage.SelectedValue;
            
            if(phase ==1)
                strqur = "select C.img,C.imgNo,C.symImg from ClassData C where C.isBroken=" + broken + " and C.fk_motif=" + motiftype + " and C.fk_classId=" + sealtype + " and ( C.fk_year=9 or C.fk_year=7 or C.fk_year=6) ";
            else if (phase ==2)
                strqur = "select C.img,C.imgNo,C.symImg from ClassData C where C.isBroken=" + broken + " and C.fk_motif=" + motiftype + " and C.fk_classId=" + sealtype + "and ( C.fk_year=4 or C.fk_year=5 )";
            else if(phase ==3)
                strqur = "select C.img,C.imgNo,C.symImg from ClassData C where C.isBroken=" + broken + " and C.fk_motif=" + motiftype + " and C.fk_classId=" + sealtype + " and ( C.fk_year=1 or C.fk_year=2 or C.fk_year=3 or C.fk_year=3) ";
            else if (phase == 0)
                strqur = "select C.img,C.imgNo,C.symImg from ClassData C where C.isBroken=" + broken + " and C.fk_motif=" + motiftype + " and C.fk_classId=" + sealtype + " ";

            pictureBoxtime.Image = timeimg;
            ViewSeals vs = new ViewSeals();
            vs.Show();
            vs.DisplayselectedSymbols("cust",strqur);
        }
        //******************************************************************************            
    }
}
