using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai04 : Form
    {
        class Student
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string Phone { get; set; }
            public float Course1 { get; set; }
            public float Course2 { get; set; }
            public float Course3 { get; set; }
            public float Average { get; set; }
        }

        private List<Student> students = new List<Student>();
        private int currentIndex = 0;

        string inputPath = "D:\\LTM\\LAB02\\Lab02\\Lab02\\Input-Output\\input4.txt";
        string outputPath = "D:\\LTM\\LAB02\\Lab02\\Lab02\\Input-Output\\output4.txt";

        public Lab02_Bai04()
        {
            InitializeComponent();
        }

        private bool ValidateInput(out string message)
        {
            message = "";
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtCourse1.Text) ||
                string.IsNullOrWhiteSpace(txtCourse2.Text) ||
                string.IsNullOrWhiteSpace(txtCourse3.Text))
            {
                message = "Vui lòng nhập đầy đủ thông tin!";
                return false;
            }

            if (txtID.Text.Length != 8 || !txtID.Text.All(char.IsDigit))
            {
                message = "MSSV phải gồm 8 chữ số!";
                return false;
            }

            if (txtPhone.Text.Length != 10 || !txtPhone.Text.All(char.IsDigit) || txtPhone.Text[0] != '0')
            {
                message = "Số điện thoại phải có 10 chữ số và bắt đầu bằng 0!";
                return false;
            }

            if (!float.TryParse(txtCourse1.Text, out float c1) ||
                !float.TryParse(txtCourse2.Text, out float c2) ||
                !float.TryParse(txtCourse3.Text, out float c3))
            {
                message = "Điểm phải là số!";
                return false;
            }

            if (c1 < 0 || c1 > 10 || c2 < 0 || c2 > 10 || c3 < 0 || c3 > 10)
            {
                message = "Điểm phải nằm trong khoảng 0 đến 10!";
                return false;
            }

            return true;
        }

        // Add: Thêm vào danh sách tạm và ghi vào input4.txt dạng text
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out string msg))
            {
                MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student s = new Student
            {
                Name = txtName.Text,
                ID = txtID.Text,
                Phone = txtPhone.Text,
                Course1 = float.Parse(txtCourse1.Text),
                Course2 = float.Parse(txtCourse2.Text),
                Course3 = float.Parse(txtCourse3.Text)
            };
            s.Average = (s.Course1 + s.Course2 + s.Course3) / 3;

            students.Add(s);

            // Ghi vào input4.txt dạng text array
            try
            {
                using (StreamWriter sw = new StreamWriter(inputPath, true, Encoding.UTF8))
                {
                    sw.WriteLine($"{s.Name}|{s.ID}|{s.Phone}|{s.Course1}|{s.Course2}|{s.Course3}");
                }

                UpdateStudentListDisplay();
                MessageBox.Show("Đã thêm sinh viên và ghi vào input4.txt!");

                txtName.Clear();
                txtID.Clear();
                txtPhone.Clear();
                txtCourse1.Clear();
                txtCourse2.Clear();
                txtCourse3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi ghi file: {ex.Message}");
            }
        }

        private void UpdateStudentListDisplay()
        {
            rtbDanhSach.Clear();
            if (students.Count == 0)
            {
                rtbDanhSach.Text = "Danh sách trống!";
                return;
            }

            rtbDanhSach.AppendText("DANH SÁCH SINH VIÊN\n");
            rtbDanhSach.AppendText("=========================================\n");

            foreach (var s in students)
            {
                rtbDanhSach.AppendText(
                    $"Họ tên: {s.Name}\n" +
                    $"MSSV: {s.ID}\n" +
                    $"SĐT: {s.Phone}\n" +
                    $"Điểm: {s.Course1}, {s.Course2}, {s.Course3}\n" +
                    $"Trung bình: {s.Average:F2}\n" +
                    "-----------------------------------------\n"
                );
            }
        }

        // Write: Đọc từ input4.txt, tính TB, ghi vào output4.txt dạng JSON
        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(inputPath))
                {
                    MessageBox.Show("File input4.txt không tồn tại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Đọc từ input4.txt
                students.Clear();
                var lines = File.ReadAllLines(inputPath, Encoding.UTF8);

                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var parts = line.Split('|');
                    if (parts.Length != 6) continue;

                    Student s = new Student
                    {
                        Name = parts[0],
                        ID = parts[1],
                        Phone = parts[2],
                        Course1 = float.Parse(parts[3]),
                        Course2 = float.Parse(parts[4]),
                        Course3 = float.Parse(parts[5])
                    };
                    s.Average = (s.Course1 + s.Course2 + s.Course3) / 3;

                    students.Add(s);
                }

                if (students.Count == 0)
                {
                    MessageBox.Show("Danh sách sinh viên trống. Vui lòng thêm sinh viên trước!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ghi vào output4.txt dạng JSON
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };

                string json = JsonSerializer.Serialize(students, options);
                File.WriteAllText(outputPath, json, Encoding.UTF8);

                MessageBox.Show($"Đã ghi {students.Count} sinh viên vào output4.txt!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateStudentListDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Read: Đọc từ output4.txt (JSON) và hiển thị
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(outputPath))
                {
                    MessageBox.Show("File output4.txt không tồn tại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string json = File.ReadAllText(outputPath, Encoding.UTF8);
                students = JsonSerializer.Deserialize<List<Student>>(json) ?? new List<Student>();

                if (students.Count > 0)
                {
                    currentIndex = 0;
                    DisplayStudent(currentIndex);
                    UpdateStudentListDisplay();
                }

                MessageBox.Show($"Đã đọc {students.Count} sinh viên từ output4.txt!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Lỗi định dạng JSON: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đọc file: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayStudent(int index)
        {
            if (index < 0 || index >= students.Count) return;

            var s = students[index];
            txtName_1.Text = s.Name;
            txtID_1.Text = s.ID;
            txtPhone_1.Text = s.Phone;
            txtCourse1_1.Text = s.Course1.ToString();
            txtCourse2_1.Text = s.Course2.ToString();
            txtCourse3_1.Text = s.Course3.ToString();
            txtAverage.Text = s.Average.ToString("F2");

            lblPage.Text = $"{index + 1}/{students.Count}";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (students.Count == 0) return;
            currentIndex = (currentIndex - 1 + students.Count) % students.Count;
            DisplayStudent(currentIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (students.Count == 0) return;
            currentIndex = (currentIndex + 1) % students.Count;
            DisplayStudent(currentIndex);
        }
    }
}