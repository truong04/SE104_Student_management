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
            // TODO: This line of code loads data into the 'qLHSDataSet.H_KY' table. You can move, or remove it, as needed.
            this.h_KYTableAdapter.Fill(this.qLHSDataSet.H_KY);
            // TODO: This line of code loads data into the 'qLHSDataSet1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLHSDataSet1.MONHOC);
            // TODO: This line of code loads data into the 'qLHSDataSet.H_KY' table. You can move, or remove it, as needed.
            this.h_KYTableAdapter.Fill(this.qLHSDataSet.H_KY);
            reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
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
        private void tabControl2_DrawItem(object sender, DrawItemEventArgs e)
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
        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
            // Thiết lập đường dẫn đến tệp .rdlc
            
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (this.reportViewer1.Visible == false)
            {
                this.reportViewer1.Visible = true;
            }

            this.reportViewer1.LocalReport.ReportPath = "C:\\Users\\kimta\\Documents\\Zalo Received Files\\WindowsFormsApp3\\WindowsFormsApp2\\WindowsFormsApp2\\rpttkmon.rdlc";

            // Sử dụng context để lấy dữ liệu từ cơ sở dữ liệu
            using (var context = new BCcontext())
            {
                // Lấy giá trị đã chọn từ ComboBox học kỳ và môn học
                string hocKyId = comboBox1.SelectedValue?.ToString();
                string monHocId = comboBox2.SelectedValue?.ToString();

                if (hocKyId != null && monHocId != null)
                {
                    // Lấy danh sách các idHocSinh thỏa mãn điều kiện học kỳ và môn học đã chọn
                    var studentIds = context.Diem_HS
                        .Where(d => d.MONHOC.TENMH == monHocId && d.H_KY.TenHK == hocKyId && d.Diem15 >= 5 && d.Diem45 >= 5)
                        .Select(d => d.idHocSinh)
                        .Distinct()
                        .ToList();

                    // Lấy thông tin lớp và số lượng học sinh
                    var reportData = context.HSinhs
                        .Where(h => studentIds.Contains(h.idHocSinh))
                        .GroupBy(h => h.MaLop)
                        .Select(g => new bctkmon
                        {
                            Malop = context.Lops.FirstOrDefault(l => l.IdLop == g.Key).TenLop,
                            Siso = g.Count(),
                            Soluongdat = g.Count(s => studentIds.Contains(s.idHocSinh)),
                            Tile = g.Count() > 0 ? (float)g.Count(s => studentIds.Contains(s.idHocSinh)) / g.Count() * 100 : 0,
                            TenMh = monHocId, // Gán monHocId vào bctkmon
                            Tenhk = hocKyId    // Gán hocKyId vào bctkmon
                        })
                        .ToList();

                    // Bind dữ liệu vào ReportViewer
                    ReportDataSource reportDataSource = new ReportDataSource("DataSet1", reportData);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                    // Làm mới báo cáo
                    this.reportViewer1.RefreshReport();
                }
            }
        }
        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.reportViewer2.Visible == false)
            {
                this.reportViewer2.Visible = true;
            }

            this.reportViewer2.LocalReport.ReportPath = "C:\\Users\\kimta\\Documents\\Zalo Received Files\\WindowsFormsApp3\\WindowsFormsApp2\\WindowsFormsApp2\\rpttkhk.rdlc";

            // Sử dụng context để lấy dữ liệu từ cơ sở dữ liệu
            using (var context = new BCcontext())
            {
                // Lấy giá trị đã chọn từ ComboBox học kỳ và môn học
                string hocKyId = comboBox3.SelectedValue?.ToString();

                if (hocKyId != null)
                {
                    // Lấy danh sách các idHocSinh thỏa mãn điều kiện học kỳ và môn học đã chọn
                    var studentIds = context.Diem_HS
                        .Where(d => d.H_KY.TenHK == hocKyId && d.Diem15 >= 5 && d.Diem45 >= 5)
                        .Select(d => d.idHocSinh)
                        .Distinct()
                        .ToList();

                    // Lấy thông tin lớp và số lượng học sinh
                    var reportData = context.HSinhs
                        .Where(h => studentIds.Contains(h.idHocSinh))
                        .GroupBy(h => h.MaLop)
                        .Select(g => new bctkmon
                        {
                            Malop = context.Lops.FirstOrDefault(l => l.IdLop == g.Key).TenLop,
                            Siso = g.Count(),
                            Soluongdat = g.Count(s => studentIds.Contains(s.idHocSinh)),
                            Tile = g.Count() > 0 ? (float)g.Count(s => studentIds.Contains(s.idHocSinh)) / g.Count() * 100 : 0,
                            Tenhk = hocKyId    // Gán hocKyId vào bctkmon
                        })
                        .ToList();

                    // Bind dữ liệu vào ReportViewer
                    ReportDataSource reportDataSource = new ReportDataSource("DataSet1", reportData);
                    this.reportViewer2.LocalReport.DataSources.Clear();
                    this.reportViewer2.LocalReport.DataSources.Add(reportDataSource);

                    // Làm mới báo cáo
                    this.reportViewer2.RefreshReport();
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage16_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
