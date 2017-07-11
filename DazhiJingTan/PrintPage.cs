using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DazhiJingTan
{
    public partial class PrintPage : Form
    {
        public PrintPage()
        {
            InitializeComponent();
        }

        public PrintPage(double[] StFile)
        {
            // 初始化
            InitializeComponent();
            // 
            Graphics canvas = picBox.CreateGraphics();
            Color redColor = Color.Red;
            Pen redPen = new Pen(redColor);
            Brush brush = new SolidBrush(redColor);
            // canvas.PageUnit = GraphicsUnit.Millimeter;
            canvas.DrawString("大智静探", new Font("Arial", 15, FontStyle.Regular), brush, 10, 10);
        }
    }
}
