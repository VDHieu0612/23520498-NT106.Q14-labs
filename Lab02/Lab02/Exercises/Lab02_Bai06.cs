using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai06 : Form
    {
        private string dbPath = "Data Source=Monan.db"; // file SQLite
        private string selectedImagePath = ""; // đường dẫn ảnh

        public Lab02_Bai06()
        {
            InitializeComponent();
        }

        private void Lab02_Bai06_Load(object sender, EventArgs e)
        {
            // Tạo CSDL nếu chưa có
            CreateDatabase();
            // Tải danh sách người dùng vào ComboBox
            LoadNguoiDung();
            // Hiển thị danh sách món ăn
            LoadMonAn();
        }

        private void CreateDatabase()
        {
            // Tạo file SQLite nếu chưa tồn tại
            if (!File.Exists("MonAn.db"))
            {
                SQLiteConnection.CreateFile("MonAn.db");
            }
            using (var conn = new SQLiteConnection(dbPath))
            {
                conn.Open();

                string sqlNguoiDung = @"CREATE TABLE IF NOT EXISTS NguoiDung (
                                        IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                                        HoVaTen TEXT,
                                        QuyenHan TEXT);";

                string sqlMonAn = @"CREATE TABLE IF NOT EXISTS MonAn (
                                    IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                                    TenMonAn TEXT,
                                    HinhAnh TEXT,
                                    IDNCC INTEGER,
                                    FOREIGN KEY(IDNCC) REFERENCES NguoiDung(IDNCC));";

                using (var cmd = new SQLiteCommand(sqlNguoiDung, conn))
                    cmd.ExecuteNonQuery();
                using (var cmd = new SQLiteCommand(sqlMonAn, conn))
                    cmd.ExecuteNonQuery();

                // Nếu bảng người dùng rỗng thì thêm dữ liệu mẫu
                string check = "SELECT COUNT(*) FROM NguoiDung";
                using (var cmd = new SQLiteCommand(check, conn))
                {
                    long count = (long)cmd.ExecuteScalar();
                    if (count == 0)
                    {
                        string insert = @"INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES
                                          ('Võ Duy A', 'Admin'),
                                          ('Võ Duy B', 'User'),
                                          ('Võ Duy C', 'User');";
                        using (var cmd2 = new SQLiteCommand(insert, conn))
                            cmd2.ExecuteNonQuery();
                    }
                }

                conn.Close();
            }
        }

        private void LoadNguoiDung()
        {
            cbNguoiDung.Items.Clear();

            using (var conn = new SQLiteConnection(dbPath))
            {
                conn.Open();
                string sql = "SELECT IDNCC, HoVaTen FROM NguoiDung";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbNguoiDung.Items.Add(new ComboboxItem
                        {
                            Text = reader["HoVaTen"].ToString(),
                            Value = reader["IDNCC"].ToString()
                        });
                    }
                }
                conn.Close();
            }

            if (cbNguoiDung.Items.Count > 0)
                cbNguoiDung.SelectedIndex = 0;
        }

        private void LoadMonAn()
        {
            lvMonAn.Items.Clear();

            using (var conn = new SQLiteConnection(dbPath))
            {
                conn.Open();
                string sql = @"SELECT MonAn.IDMA, MonAn.TenMonAn, NguoiDung.HoVaTen
                               FROM MonAn
                               JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["IDMA"].ToString());
                        item.SubItems.Add(reader["TenMonAn"].ToString());
                        item.SubItems.Add(reader["HoVaTen"].ToString());
                        lvMonAn.Items.Add(item);
                    }
                }
                conn.Close();
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Ảnh (*.jpg; *.png)|*.jpg;*.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = dlg.FileName;
                    picHinhAnh.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtTenMon.Text, @"^[\p{L}\p{N}\s]+$"))
            {
                MessageBox.Show("Tên món ăn chỉ được chứa chữ cái, số và khoảng trắng, không có ký tự đặc biệt!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!");
                return;
            }

            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Vui lòng chọn ảnh cho món ăn!");
                return;
            }

            if (cbNguoiDung.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn người đóng góp!");
                return;
            }

            var selectedUser = (ComboboxItem)cbNguoiDung.SelectedItem;

            using (var conn = new SQLiteConnection(dbPath))
            {
                conn.Open();
                string sql = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@ten, @anh, @id)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ten", txtTenMon.Text);
                    cmd.Parameters.AddWithValue("@anh", selectedImagePath);
                    cmd.Parameters.AddWithValue("@id", selectedUser.Value);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

            MessageBox.Show("Thêm món ăn thành công!");
            LoadMonAn();
            txtTenMon.Clear();
            picHinhAnh.Image = null;
            selectedImagePath = "";
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(dbPath))
            {
                conn.Open();
                string sql = @"SELECT MonAn.TenMonAn, MonAn.HinhAnh, NguoiDung.HoVaTen
                               FROM MonAn
                               JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC";
                var dt = new DataTable();
                using (var da = new SQLiteDataAdapter(sql, conn))
                {
                    da.Fill(dt);
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có món ăn nào trong cơ sở dữ liệu!");
                    return;
                }

                Random rnd = new Random();
                int index = rnd.Next(dt.Rows.Count);
                var row = dt.Rows[index];

                string ten = row["TenMonAn"].ToString();
                string nguoi = row["HoVaTen"].ToString();
                string anh = row["HinhAnh"].ToString();

                txtKetqua.Text = ten;

                if (File.Exists(anh))
                    picHinhAnh.Image = Image.FromFile(anh);
                else
                    picHinhAnh.Image = null;

                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvMonAn.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xóa!");
                return;
            }

            // Lấy ID món được chọn
            var selectedItem = lvMonAn.SelectedItems[0];
            string idMonAn = selectedItem.SubItems[0].Text;

            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa món có ID = {idMonAn} không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                using (var conn = new SQLiteConnection(dbPath))
                {
                    conn.Open();
                    string sql = "DELETE FROM MonAn WHERE IDMA = @id";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idMonAn);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                MessageBox.Show("Đã xóa món ăn thành công!");
                LoadMonAn();
            }
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public override string ToString() => Text;
    }
}

