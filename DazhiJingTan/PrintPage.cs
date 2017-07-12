using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DazhiJingTan
{
    public partial class PrintPage : Form
    {
        #region 属性

        public GeoDetector GeDet;

        #endregion

        public PrintPage()
        {
            InitializeComponent();
        }

        public PrintPage(GeoDetector gedet)
        {
            // 初始化
            InitializeComponent();
            // 
            GeDet = gedet;
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            Graphics canvas = picBox.CreateGraphics();
            Color redColor = Color.Red;
            Pen redPen = new Pen(redColor, 2);
            Brush brush = new SolidBrush(redColor);
            // canvas.PageUnit = GraphicsUnit.Millimeter;
            canvas.DrawString("大智静探", new Font("Arial", 15, FontStyle.Regular), brush, 100, 10);
            canvas.DrawLine(redPen, 10, 10, 100, 100);
        }
    }
}
