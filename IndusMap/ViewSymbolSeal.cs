using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndusMap
{
    public partial class ViewSymbolSeal : Form
    {
        //***********************************************************************
        string pathOut3 = @"A:\Indus\HSM\IndusFont1840Out3";
        int currsymbol;
        //***********************************************************************
        public ViewSymbolSeal()
        {
            InitializeComponent();
        }
        //***********************************************************************
        public void viewindussymbol()
        {
            int wn = 16;
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
                string nm = n.ToString();
                int x = (n % wn) * wk;
                int y = (n / wn) * hk;
                g.DrawImage(bn, new Point(x, y));
                Font drawFont = new Font("Arial", 8);
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                PointF drawPoint = new PointF(x + 10, y + b0.Height);
                g.DrawString(nm, drawFont, drawBrush, drawPoint);
            }
            g.Dispose();
            pictureBoxsymbol.Image = bm;
            pictureBoxsymbol.Size = bm.Size;
        }
        //***********************************************************************
        private void pictureBoxsymbol_Click(object sender, EventArgs e)
        {
            
        }
        //***********************************************************************
        private void pictureBoxsymbol_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int wn = 16;
            string[] flnmsall = Directory.GetFiles(pathOut3, "*.bmp");
            Bitmap b0 = new Bitmap(flnmsall[0]);
            int hn = (flnmsall.Length + wn - 1) / wn;
            int wk = (int)(b0.Width * 1.1);
            int hk = (int)(b0.Height * 1.5);
            int n1 = e.Y / hk;
            int n2 = e.X / wk;
            currsymbol = n1 * wn + n2;
            textBox1.Text = currsymbol.ToString();
            Cursor.Current = Cursors.Default;
            string num = currsymbol.ToString();
            ViewSeals vs = new ViewSeals();
            vs.DisplayselectedSymbols("symbol", num);
            vs.Show();
        }
        //***********************************************************************
        //***********************************************************************      
    }
}
