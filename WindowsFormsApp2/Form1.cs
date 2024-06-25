using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using WindowsFormsApp2;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace GiaoDien
{
    public partial class Form1 : Form
    {
        string connection = @"Data Source=ANHTUAN\MSSVQLSERVER;Initial Catalog=QLHS;Integrated Security=True;Encrypt=False";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();


        public Form1()
        {
            InitializeComponent();
            tabControl3.DrawItem += new DrawItemEventHandler(tabControl3_DrawItem);
            tabControl2.DrawItem += new DrawItemEventHandler(tabControl3_DrawItem);
            tabControl4.DrawItem += new DrawItemEventHandler(tabControl3_DrawItem);
            conn = new SqlConnection(connection);
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabControl3_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            Graphics g = e.Graphics;
            Brush _textBrush;

            TabPage _tabPage = tabControl.TabPages[e.Index];
            Rectangle _tabBounds = tabControl.GetTabRect(e.Index);

            _textBrush = new SolidBrush(SystemColors.ControlText);
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;

            // Vẽ văn bản với khoảng cách
            Rectangle textBounds = _tabBounds;
            textBounds.Offset(-20, 3); // Dịch chuyển văn bản xuống một chút
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, textBounds, _stringFlags);

            // Đo kích thước của văn bản
            SizeF textSize = g.MeasureString(_tabPage.Text, _tabFont);

            // Tính toán vị trí mới cho ảnh
            float imageX = _tabBounds.Right - 20 - (tabControl.ImageList.ImageSize.Width); // 20 là khoảng cách giữa ảnh và viền phải của tab
            float imageY = _tabBounds.Top + (_tabBounds.Height - tabControl.ImageList.ImageSize.Height) / 2;


            // Vẽ ảnh từ ImageList của tabControl
            if (e.Index < tabControl.ImageList.Images.Count)
            {
                System.Drawing.Image tabImage = tabControl.ImageList.Images[e.Index];
                g.DrawImage(tabImage, imageX, imageY);
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = null;
            //dt.Clear();
            string ten_hs = name.Text;
            string lop = COMBO_LOP.Text;
            string nam_sinh = bday.Text;

            // Kiểm tra xem tất cả các trường thông tin đều trống hay không
            if (string.IsNullOrEmpty(ten_hs) && string.IsNullOrEmpty(lop) && string.IsNullOrEmpty(nam_sinh))
            {
                MessageBox.Show("Xin hãy nhập thông tin để thực hiện tìm kiếm.");
                return; // Thoát khỏi phương thức để không thực hiện truy vấn
            }

            // Tiếp tục với các bước truy vấn nếu có ít nhất một trường thông tin không trống
            string query = "SELECT DISTINCT HoVaTen, Diem45, Diem15 FROM HSinh, Lop, Diem_HS, MONHOC WHERE HSinh.MaLop = Lop.IdLop AND HSinh.idHocSinh = Diem_HS.idHocSinh AND Diem_HS.idMonHoc = MONHOC.MAMH";

            // Thêm điều kiện cho tên học sinh nếu được cung cấp
            if (!string.IsNullOrEmpty(ten_hs))
            {
                query += " AND HoVaTen = '" + ten_hs + "'";
            }

            // Thêm điều kiện cho lớp nếu được cung cấp
            if (!string.IsNullOrEmpty(lop))
            {
                query += " AND TenLop = '" + lop + "'";
            }

            // Thêm điều kiện cho năm sinh nếu được cung cấp
            if (!string.IsNullOrEmpty(nam_sinh))
            {
                query += " AND NamSinh = '" + nam_sinh + "'";
            }

            try
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "C:\\Users\\kimta\\Documents\\Zalo Received Files\\WindowsFormsApp3\\WindowsFormsApp2\\WindowsFormsApp2\\rpttkmon.rdlc";

            using (var context = new QLHSEntities()) // Tên context của bạn
            {
                // Lấy danh sách lớp
                var lopList = context.Lops.ToList();

                // Tạo DataTable để chứa dữ liệu báo cáo
                DataTable reportTable = new DataTable();
                reportTable.Columns.Add("STT", typeof(int));
                reportTable.Columns.Add("Lop", typeof(string));
                reportTable.Columns.Add("SiSo", typeof(int));
                reportTable.Columns.Add("SoLuongDat", typeof(int));
                reportTable.Columns.Add("TiLe", typeof(double));

                // Tính toán dữ liệu cho từng lớp
                int stt = 1;
                foreach (var lop in lopList)
                {
                    string maLop = lop.IdLop;
                    var students = context.HSinhs.Where(h => h.MaLop == maLop).ToList();
                    int siSo = students.Count;

                    // Lấy danh sách các idHocSinh
                    var studentIds = students.Select(s => s.idHocSinh).ToList();

                    // Giả định tiêu chí "đạt" là điểm >= 5 cho cả Diem15 và Diem45
                    int soLuongDat = context.Diem_HS
                        .Where(d => studentIds.Contains(d.idHocSinh) && d.Diem15 >= 5 && d.Diem45 >= 5)
                        .Count();

                    double tiLe = (siSo > 0) ? (double)soLuongDat / siSo * 100 : 0;

                    reportTable.Rows.Add(stt++, lop.TenLop, siSo, soLuongDat, tiLe);
                }

                // Bind dữ liệu vào ReportViewer
                ReportDataSource reportDataSource = new ReportDataSource("ReportDataSet", reportTable);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                // Làm mới báo cáo
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
