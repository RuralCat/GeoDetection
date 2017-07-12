using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DazhiJingTan
{
    public partial class JingTan : Form
    {
        #region 属性

        public GeoDetector GeoDet;
        public const int GridShowNumber = 50;

        #endregion

        #region 构造函数

        public JingTan()
        {
            InitializeComponent();
        }

        #endregion

        #region 控件方法
        private void importFileBtn_Click(object sender, EventArgs e)
        {
            // 打开文件对话框，准备获取静探文件路径
            OpenFileDialog stFileDialog = new OpenFileDialog();
            stFileDialog.Filter = "dat文件(*.dat)|*.dat|文本文件(*.txt)|*.txt|所有文件|*.*";
            stFileDialog.FilterIndex = 1;
            stFileDialog.RestoreDirectory = true;
            stFileDialog.Multiselect = false;
            // 获取文件名并打开
            if (stFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 导入文件数据
                GeoDet = new GeoDetector(stFileDialog.FileName);
                // 将数据填充在数据面板中
                fillDataIntoGrid();
                // 更新参数数据
                updateStProperty();
            }
        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            // 获取保存文件的路径
            SaveFileDialog stFileDialog = new SaveFileDialog();
            stFileDialog.Filter = "dat文件(*.dat)|*.dat|文本文件(*.txt)|*.txt|所有文件|*.*";
            stFileDialog.FilterIndex = 1;
            stFileDialog.RestoreDirectory = true;
            if (stFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 更新参数数据
                updateStProperty(false);
                // 写入文件
                GeoDet.SaveFile(stFileDialog.FileName);
            }
        }

        private void stDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (stDataGridView.Rows[e.RowIndex].Cells[1].Value != null)
                GeoDet.StFile[e.RowIndex] = (double)stDataGridView.Rows[e.RowIndex].Cells[1].Value;
        }

        private void updateStProperty(bool fileToUI = true)
        {
            if (fileToUI)
            {
                // 将读取的参数更新到面板中
                projectNumberText.Text = GeoDet.ProjectNumber;
                holeNumberText.Text = GeoDet.HoleNumber;
                probeNumberText.Text = GeoDet.ProbeNumber;
                testDateText.Text = GeoDet.TestDate;
                coneSquareText.Text = GeoDet.ConeHeadSquare;
                labelCoffiText.Text = GeoDet.LabelCoffi;
            }
            else
            {
                // 将面板更改的数据更新到参数上
                GeoDet.ProjectNumber = projectNumberText.Text;
                GeoDet.HoleNumber = holeNumberText.Text;
                GeoDet.ProbeNumber = probeNumberText.Text;
                GeoDet.TestDate = testDateText.Text;
                GeoDet.ConeHeadSquare = coneSquareText.Text;
                GeoDet.LabelCoffi = labelCoffiText.Text;
            }
        }

        #endregion

        #region 文件方法


        private void fillDataIntoGrid()
        {
            // 添加表格头
            stDataGridView.Columns.Clear();
            stDataGridView.Columns.Add("depth", "深度（m)");
            stDataGridView.Columns.Add("nowel", "比贯入阻力Ps（MPa）");
            // 添加数据
            for (int k = 0; k < GeoDet.PointCount; k++)
            {
                stDataGridView.Rows.Add();
                stDataGridView.Rows[k].Cells[0].Value = ((k + 1) * GeoDetector.DepthGap);
                stDataGridView.Rows[k].Cells[1].Value = GeoDet.StFile[k];
            }
            // 添加相关属性
            stDataGridView.Columns[0].ReadOnly = true;
        }

        


        #endregion

        private void printViewBtn_Click(object sender, EventArgs e)
        {
            PrintPage page = new PrintPage(GeoDet);
            page.Show();
        }
    }

    public class GeoDetector
    {
        #region 属性

        public double[] StFile { get; set; }
        public string ProjectNumber { get; set; }
        public string HoleNumber { get; set; }
        public double HoleDepth { get; set; }
        public string ProbeNumber { get; set; }
        public string TestDate { get; set; }
        public string ConeHeadSquare { get; set; }
        public string LabelCoffi { get; set; }
        public int PointCount { get; set; }
        public const double DepthGap = 0.1;

        #endregion

        public GeoDetector(string filePath)
        {
            StFile = new double[5000];
            importFile(filePath);
        }

        #region 公有方法

        public void SaveFile(string filePath)
        {
            this.saveFile(filePath);
        }

        #endregion

        #region 私有方法

        private void importFile(string filePath)
        {
            // 创建文件流
            FileStream stStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader stReader = new StreamReader(stStream);
            // 读取各项参数
            this.TestDate = stReader.ReadLine();
            this.HoleNumber = stReader.ReadLine();
            this.ProjectNumber = stReader.ReadLine();
            for (int k = 0; k < 2; k++) stReader.ReadLine();
            this.ProbeNumber = stReader.ReadLine();
            this.ConeHeadSquare = stReader.ReadLine();
            this.LabelCoffi = stReader.ReadLine();
            for (int k = 0; k < 5; k++) stReader.ReadLine();
            // 读取比贯入阻力数据
            this.PointCount = 0;
            string tempString = null;
            while (!stReader.EndOfStream)
            {
                tempString = stReader.ReadLine();
                if (tempString != "")
                {
                    StFile[this.PointCount] = Convert.ToDouble(tempString);
                    this.PointCount = this.PointCount + 1;
                }
            }
            this.HoleDepth = this.PointCount * GeoDetector.DepthGap;
            // 完成读取关闭文件
            if (stStream != null)
            {
                stReader.Close();
                stStream.Close();
            }
        }

        private void saveFile(string filePath)
        {
            // 创建文件流
            FileStream stStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            StreamWriter stWriter = new StreamWriter(stStream);
            // 写入参数
            stWriter.WriteLine(this.TestDate);
            stWriter.WriteLine(this.HoleNumber);
            stWriter.WriteLine(this.ProbeNumber);
            for (int k = 0; k < 2; k++) stWriter.WriteLine("");
            stWriter.WriteLine(this.ProbeNumber);
            stWriter.WriteLine(this.ConeHeadSquare);
            stWriter.WriteLine(this.LabelCoffi);
            stWriter.WriteLine("20");
            for (int k = 0; k < 3; k++) stWriter.WriteLine("0");
            stWriter.WriteLine("");
            // 写入数据
            for (int k = 0; k < this.PointCount; k++)
                stWriter.WriteLine(this.StFile[k]);
            // 关闭文件
            if (stStream != null)
            {
                stWriter.Close();
                stStream.Close();
            }
        }

        #endregion

    }
}
