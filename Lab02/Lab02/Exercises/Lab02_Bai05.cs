using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab02.Exercises
{
    public partial class Lab02_Bai05 : Form
    {
        private Dictionary<string, (double Price, List<int> Rooms)> movies = new Dictionary<string, (double Price, List<int> Rooms)>();
        private Dictionary<string, List<string>> soldTickets = new Dictionary<string, List<string>>();
        private List<Button> selectedSeats = new List<Button>();
        private const string TicketFile = "D:\\LTM\\LAB02\\Lab02\\Lab02\\Input-Output\\tickets.txt";
        private const string OutputFile = "D:\\LTM\\LAB02\\Lab02\\Lab02\\Input-Output\\output5.txt";
        private const string InputFile = "D:\\LTM\\LAB02\\Lab02\\Lab02\\Input-Output\\input5.txt";

        public Lab02_Bai05() => InitializeComponent();

        private void Lab02_Bai05_Load(object sender, EventArgs e)
        {
            LoadMoviesFromFile(InputFile);
            cbChonPhim.Items.AddRange(movies.Keys.ToArray());

            foreach (Control c in gbChonGhe.Controls)
                if (c is Button b) b.Click += SeatButton_Click;

            // Load dữ liệu vé đã bán vào bộ nhớ
            LoadTicketsFromFile(TicketFile);

            // Ẩn ProgressBar ban đầu
            if (progressBar1 != null)
                progressBar1.Visible = false;
        }

        // ==================== Chọn phim và phòng chiếu ====================
        private void cbChonPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPhongChieu.Items.Clear();
            txtThongTin.Clear();
            ResetSeats();

            if (cbChonPhim.SelectedItem == null) return;
            foreach (int room in movies[cbChonPhim.Text].Rooms)
                cbPhongChieu.Items.Add(room);
        }

        private void cbPhongChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetSeats();
            LoadSoldSeatsDisplay();
            txtThongTin.Clear();
        }

        // ==================== Chọn ghế ====================
        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button seat = sender as Button;
            if (!seat.Enabled) return;

            if (seat.BackColor == SystemColors.Control)
            {
                seat.BackColor = Color.SkyBlue;
                selectedSeats.Add(seat);
            }
            else if (seat.BackColor == Color.SkyBlue)
            {
                seat.BackColor = SystemColors.Control;
                selectedSeats.Remove(seat);
            }
        }

        // ==================== Thanh toán ====================
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                cbChonPhim.SelectedItem == null ||
                cbPhongChieu.SelectedItem == null ||
                selectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin và chọn ghế!");
                return;
            }

            string movie = cbChonPhim.Text;
            int room = Convert.ToInt32(cbPhongChieu.Text);
            double basePrice = movies[movie].Price, total = 0;
            var sb = new StringBuilder();
            sb.AppendLine($"Họ tên: {txtHoTen.Text}\r\nPhim: {movie}\r\nPhòng chiếu: {room}\r\nGhế:");

            var key = $"{movie}-{room}";
            if (!soldTickets.ContainsKey(key)) soldTickets[key] = new List<string>();

            // Lưu danh sách ghế để ghi file
            var seatsToWrite = new List<(Button seat, double price)>();

            foreach (var seat in selectedSeats)
            {
                double price = CalcPrice(seat.Text, basePrice);
                sb.AppendLine($"{seat.Text} - {price:N0}đ");
                total += price;

                // Thêm vào danh sách ghế đã bán (tránh trùng lặp)
                if (!soldTickets[key].Contains(seat.Text))
                {
                    soldTickets[key].Add(seat.Text);
                    seatsToWrite.Add((seat, price));
                }
            }

            // Ghi ra file vé bán
            foreach (var item in seatsToWrite)
            {
                File.AppendAllText(TicketFile, $"{movie}|{room}|{item.seat.Text}|{item.price}\n");
            }

            // Cập nhật giao diện ghế sau khi đã thêm vào soldTickets
            foreach (var seat in selectedSeats)
            {
                seat.BackColor = Color.Red;
                seat.Enabled = false;
            }

            txtThongTin.Text = sb + $"Tổng tiền: {total:N0}đ";
            selectedSeats.Clear();

            // Cập nhật thống kê ra file
            WriteStatisticsToFile();
        }

        // ==================== Hủy ====================
        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (var s in selectedSeats) s.BackColor = SystemColors.Control;
            selectedSeats.Clear();
            txtHoTen.Clear(); txtThongTin.Clear();
            cbChonPhim.SelectedIndex = -1; cbPhongChieu.Items.Clear();
            ResetSeats();
        }

        // ==================== Tính giá ====================
        private double CalcPrice(string seat, double basePrice)
        {
            char row = seat[0]; int col = int.Parse(seat.Substring(1));
            if ((row == 'A' || row == 'C') && (col == 1 || col == 5)) return basePrice / 4;
            if (row == 'B' && col >= 2 && col <= 4) return basePrice * 2;
            return basePrice;
        }

        // ==================== Reset ====================
        private void ResetSeats()
        {
            foreach (Control c in gbChonGhe.Controls)
                if (c is Button b) { b.Enabled = true; b.BackColor = SystemColors.Control; }
            selectedSeats.Clear();
        }

        // ==================== Reset toàn bộ ====================
        private void btnResetAll_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn reset toàn bộ dữ liệu?",
                                          "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) return;

            // Xóa dữ liệu trong file để làm mới
            if (File.Exists(TicketFile))
                File.WriteAllText(TicketFile, string.Empty);
            if (File.Exists(OutputFile))
                File.WriteAllText(OutputFile, string.Empty);

            // Xóa dữ liệu trong bộ nhớ
            soldTickets.Clear();
            selectedSeats.Clear();
            txtHoTen.Clear();
            txtThongTin.Clear();
            cbChonPhim.SelectedIndex = -1;
            cbPhongChieu.Items.Clear();

            // Reset giao diện ghế
            ResetSeats();

            MessageBox.Show("Đã reset toàn bộ dữ liệu!");
        }

        // ==================== File I/O ====================
        private void LoadSoldSeatsDisplay()
        {
            if (cbChonPhim.SelectedItem == null || cbPhongChieu.SelectedItem == null)
                return;

            string movie = cbChonPhim.Text.Trim();
            string room = cbPhongChieu.Text.Trim();
            string key = $"{movie}-{room}";

            // Đọc trực tiếp từ file để lấy danh sách ghế đã bán
            List<string> soldSeats = new List<string>();

            if (File.Exists(TicketFile))
            {
                foreach (string line in File.ReadAllLines(TicketFile))
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var parts = line.Split('|');
                    if (parts.Length < 3) continue;

                    string fileMovie = parts[0].Trim();
                    string fileRoom = parts[1].Trim();
                    string fileSeat = parts[2].Trim();

                    // Chỉ lấy ghế của phim và phòng đang chọn
                    if (fileMovie.Equals(movie, StringComparison.OrdinalIgnoreCase) &&
                        fileRoom.Equals(room, StringComparison.OrdinalIgnoreCase))
                    {
                        if (!soldSeats.Contains(fileSeat))
                            soldSeats.Add(fileSeat);
                    }
                }
            }

            // Kết hợp với ghế đã bán trong phiên hiện tại (từ bộ nhớ)
            if (soldTickets.ContainsKey(key))
            {
                foreach (string seat in soldTickets[key])
                {
                    if (!soldSeats.Contains(seat))
                        soldSeats.Add(seat);
                }
            }

            // Cập nhật giao diện ghế
            foreach (Control c in gbChonGhe.Controls)
            {
                if (c is Button b)
                {
                    string seatName = b.Text.Trim();
                    if (soldSeats.Contains(seatName))
                    {
                        b.BackColor = Color.Red;
                        b.Enabled = false;
                    }
                    else
                    {
                        b.BackColor = SystemColors.Control;
                        b.Enabled = true;
                    }
                }
            }
        }

        private void LoadTicketsFromFile(string file)
        {
            if (!File.Exists(file))
                return;

            // Xóa dữ liệu cũ để tránh đọc lại nhiều lần
            soldTickets.Clear();

            foreach (string line in File.ReadAllLines(file))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split('|');
                if (parts.Length != 4) continue;

                string movie = parts[0].Trim();
                string room = parts[1].Trim();
                string seat = parts[2].Trim();

                string key = $"{movie}-{room}";
                if (!soldTickets.ContainsKey(key))
                    soldTickets[key] = new List<string>();

                // Thêm ghế vào danh sách nếu chưa có (tránh trùng lặp)
                if (!soldTickets[key].Contains(seat))
                    soldTickets[key].Add(seat);
            }
        }

        private void LoadMoviesFromFile(string file)
        {
            if (!File.Exists(file))
            {
                MessageBox.Show("Không tìm thấy file: " + file);
                return;
            }

            foreach (string line in File.ReadAllLines(file))
            {
                var parts = line.Split('|');
                if (parts.Length < 3) continue;

                string name = parts[0];
                double price = double.Parse(parts[1]);
                List<int> rooms = parts[2].Split(',').Select(int.Parse).ToList();

                movies[name] = (price, rooms);
            }
        }

        private void WriteStatisticsToFile()
        {
            // Hiển thị và reset ProgressBar
            if (progressBar1 != null)
            {
                progressBar1.Value = 0;
                progressBar1.Visible = true;
                progressBar1.Refresh();
            }

            var statList = new List<(string Movie, int Sold, int Total, double Percent, double Revenue)>();

            int totalMovies = movies.Count;
            int processed = 0;

            foreach (var movie in movies)
            {
                int totalSeats = 15 * movie.Value.Rooms.Count;

                // Đếm số vé đã bán của phim này
                int sold = soldTickets
                    .Where(k => k.Key.StartsWith(movie.Key + "-"))
                    .Sum(k => k.Value.Count);

                // Tính doanh thu cho phim này từ file
                double revenue = 0;
                if (File.Exists(TicketFile))
                {
                    revenue = File.ReadAllLines(TicketFile)
                        .Where(l => !string.IsNullOrWhiteSpace(l) && l.StartsWith(movie.Key + "|"))
                        .Select(l =>
                        {
                            var p = l.Split('|');
                            return p.Length >= 4 ? double.Parse(p[3]) : 0;
                        })
                        .Sum();
                }

                double percent = totalSeats == 0 ? 0 : (double)sold / totalSeats * 100;

                statList.Add((movie.Key, sold, totalSeats, percent, revenue));

                // Cập nhật progress bar
                processed++;
                if (progressBar1 != null)
                {
                    progressBar1.Value = (int)((processed / (double)totalMovies) * 100);
                    progressBar1.Refresh();
                    System.Threading.Thread.Sleep(100); // Hiệu ứng để thấy progress
                }
            }

            // Xếp hạng theo doanh thu giảm dần
            var ranked = statList.OrderByDescending(x => x.Revenue).ToList();

            var sb = new StringBuilder();
            sb.AppendLine("╔════════════════════════════════════════════════════════════════════════════════╗");
            sb.AppendLine("║                    THỐNG KÊ DOANH THU PHÒNG VÉ                                ║");
            sb.AppendLine("╚════════════════════════════════════════════════════════════════════════════════╝");
            sb.AppendLine();
            sb.AppendLine($"{"Tên phim",-30} | {"Vé bán",10} | {"Vé tồn",10} | {"Tỉ lệ (%)",10} | {"Doanh thu (VND)",20} | {"Hạng",5}");
            sb.AppendLine(new string('─', 110));

            for (int i = 0; i < ranked.Count; i++)
            {
                var m = ranked[i];
                sb.AppendLine($"{m.Movie,-30} | {m.Sold,10} | {m.Total - m.Sold,10} | {m.Percent,10:F2} | {m.Revenue,20:N0} | {i + 1,5}");
            }

            sb.AppendLine(new string('─', 110));
            sb.AppendLine($"Tổng doanh thu: {ranked.Sum(x => x.Revenue):N0} VND");
            sb.AppendLine($"Tổng vé bán ra: {ranked.Sum(x => x.Sold)}");
            sb.AppendLine($"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");

            File.WriteAllText(OutputFile, sb.ToString(), Encoding.UTF8);

            // Hoàn thành progress bar
            if (progressBar1 != null)
            {
                progressBar1.Value = 100;
                progressBar1.Refresh();
                System.Threading.Thread.Sleep(300); // Hiệu ứng chờ
                progressBar1.Visible = false;
            }
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            // Xuất file thống kê
            WriteStatisticsToFile();

            // Hiển thị thông báo và mở file
            var result = MessageBox.Show(
                $"Đã xuất thống kê vào file:\n{OutputFile}\n\nBạn có muốn mở file không?",
                "Thống kê thành công",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                try
                {
                    System.Diagnostics.Process.Start("notepad.exe", OutputFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể mở file: {ex.Message}");
                }
            }
        }
    }
}