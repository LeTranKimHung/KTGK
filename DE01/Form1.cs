using DE01.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DE01
{
    public partial class Form1 : Form
    {
        ModelStudent student = new ModelStudent();
        public Form1()
        {
            InitializeComponent();
            btntim.Click += new EventHandler(btntim_Click);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sinhvien> liststudent = student.Sinhviens.ToList();
            List<Lop> listlop = student.Lops.ToList();
            FillDataCBB(listlop);
            FillDataDGV(liststudent);
        }
        private void FillDataCBB(List<Lop> listlop)
        {
            cmblop.DataSource = listlop;
            cmblop.DisplayMember = "TenLop";
            cmblop.ValueMember = "MaLop";
        }
        private void FillDataDGV(List<Sinhvien> liststudent)
        {
            dgvsv.Rows.Clear();
            foreach (var student in liststudent)
            {
                int rownew = dgvsv.Rows.Add();
                dgvsv.Rows[rownew].Cells[0].Value = student.MaSV;
                dgvsv.Rows[rownew].Cells[1].Value = student.HotenSV;
                dgvsv.Rows[rownew].Cells[2].Value = student.NgaySinh;
                dgvsv.Rows[rownew].Cells[3].Value = student.Lop.TenLop;

            }

        }
        private void loadForm()
        {
            txthoten.Clear(); txtmssv.Clear();
        }
        private void loadDGV()
        {
            List<Sinhvien> newliststudent = student.Sinhviens.ToList();
            FillDataDGV(newliststudent);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu mã sinh viên đã tồn tại trong DataGridView
                if (checkIdSinhVien(txtmssv.Text) == -1)
                {
                    Sinhvien sv = new Sinhvien();
                    sv.MaSV = txtmssv.Text;
                    sv.HotenSV = txthoten.Text;
                    sv.NgaySinh = dateTimePicker1.Value;

                    // Gán mã lớp cho sinh viên
                    if (cmblop.SelectedItem != null)
                    {
                        sv.MaLop = (cmblop.SelectedItem as Lop)?.MaLop; // Gán mã lớp từ đối tượng Lop
                    }

                    // Thêm sinh viên vào cơ sở dữ liệu
                    student.Sinhviens.Add(sv);  // Thay vì AddOrUpdate nếu bạn muốn chỉ thêm mới
                    student.SaveChanges();

                    loadDGV();  // Cập nhật DataGridView
                    loadForm(); // Làm sạch form

                    MessageBox.Show($"Thêm sinh viên {sv.HotenSV} vào danh sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Sinh viên có mã {txtmssv.Text} đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private int checkIdSinhVien(string newIdSinhVien)
        {
            int length = dgvsv.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvsv.Rows[i].Cells[0].Value != null)
                    if (dgvsv.Rows[i].Cells[0].Value.ToString() == newIdSinhVien)
                        return i;
            }
            return -1;
        }
        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvsv.Rows.Count; i++)
            {
                if (dgvsv.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã sinh viên từ ô nhập liệu
                string studentID = txtmssv.Text;

                // Kiểm tra xem sinh viên có tồn tại không
                var studentToDelete = student.Sinhviens.FirstOrDefault(s => s.MaSV == studentID);

                if (studentToDelete == null)
                {
                    throw new Exception("Mã sinh viên không tồn tại trong hệ thống");
                }
                else
                {
                    // Xác nhận xóa
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "YES/NO", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.Yes)
                    {
                        // Xóa sinh viên khỏi danh sách và cơ sở dữ liệu
                        student.Sinhviens.Remove(studentToDelete);
                        student.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                        loadDGV(); // Tải lại DataGridView để cập nhật thông tin
                        loadForm(); // Xóa thông tin nhập liệu trên form

                        MessageBox.Show("Xóa sinh viên thành công!", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvsv.Rows[e.RowIndex];
                txtmssv.Text = row.Cells[0].Value.ToString();
                txthoten.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value != null)
                {
                    dateTimePicker1.Value = Convert.ToDateTime(row.Cells[2].Value);
                }
                cmblop.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            Sinhvien update = student.Sinhviens.FirstOrDefault(p => p.MaSV == txtmssv.Text);
            if (update != null)
            {
                update.HotenSV = txthoten.Text;
                update.NgaySinh = dateTimePicker1.Value;

                // Kiểm tra nếu ComboBox có giá trị được chọn và chuyển đổi về đối tượng Lop
                if (cmblop.SelectedItem != null)
                {
                    Lop selectedLop = cmblop.SelectedItem as Lop;  // Chuyển đổi đối tượng
                    update.Lop = selectedLop;  // Gán đối tượng Lop thay vì chuỗi
                }

                student.Sinhviens.AddOrUpdate(update);
                student.SaveChanges();
                loadDGV();
                loadForm();

                MessageBox.Show($"Sửa thông tin sinh viên {update.HotenSV} thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string searchMSSV = textBox3.Text.Trim();

            // Kiểm tra nếu TextBox trống
            if (string.IsNullOrWhiteSpace(searchMSSV))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm sinh viên theo mã sinh viên
            Sinhvien foundStudent = student.Sinhviens.FirstOrDefault(s => s.MaSV == searchMSSV);

            // Nếu tìm thấy sinh viên
            if (foundStudent != null)
            {
                // Hiển thị thông tin vào các TextBox và ComboBox để chỉnh sửa
                txtmssv.Text = foundStudent.MaSV;
                txthoten.Text = foundStudent.HotenSV;
                dateTimePicker1.Value = foundStudent.NgaySinh ?? DateTime.Now;

              
                cmblop.Text = foundStudent.Lop?.TenLop;  

               
                dgvsv.Rows.Clear();
                int rownew = dgvsv.Rows.Add();
                dgvsv.Rows[rownew].Cells[0].Value = foundStudent.MaSV;
                dgvsv.Rows[rownew].Cells[1].Value = foundStudent.HotenSV;
                dgvsv.Rows[rownew].Cells[2].Value = foundStudent.NgaySinh;
                dgvsv.Rows[rownew].Cells[3].Value = foundStudent.Lop;
            }
            else
            {
                // Nếu không tìm thấy sinh viên
                MessageBox.Show("Không tìm thấy sinh viên với mã số đã nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Lưu Tệp";
                saveFileDialog.Filter = "Tệp văn bản (*.txt)|*.txt|Tất cả các tệp (*.*)|*.*"; // Bạn có thể thay đổi định dạng tệp theo nhu cầu
                saveFileDialog.DefaultExt = "txt"; // Đặt phần mở rộng mặc định

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName; // Lấy đường dẫn tệp được chọn

                    // Giả sử bạn muốn lưu thông tin sinh viên vào tệp
                    try
                    {
                        // Tạo nội dung để lưu vào tệp
                        StringBuilder sb = new StringBuilder();
                        foreach (var student in student.Sinhviens.ToList())
                        {
                            sb.AppendLine($"Mã SV: {student.MaSV}, Tên: {student.HotenSV}, Ngày Sinh: {student.NgaySinh}, Lớp: {student.MaLop}");
                        }

                        // Ghi nội dung vào tệp
                        System.IO.File.WriteAllText(filePath, sb.ToString());
                        MessageBox.Show("Lưu tệp thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi lưu tệp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // Đóng form
                this.Close();
            }
        }

        private void btnkl_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn không muốn lưu các thay đổi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // Xóa nội dung trên form hoặc thực hiện các hành động khác nếu cần
                loadForm(); // Giả sử loadForm() sẽ xóa nội dung trên form

                MessageBox.Show("Thay đổi đã bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
