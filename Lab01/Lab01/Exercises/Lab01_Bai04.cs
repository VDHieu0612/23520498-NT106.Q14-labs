using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Lab01.Exercises
{
    public partial class Lab01_Bai04 : Form
    {
        private Dictionary<string, (double Price, List<int> Rooms)> movies = new();
        private Dictionary<string, List<string>> soldTickets = new();
        private List<Button> selectedSeats = new();

        public Lab01_Bai04() => InitializeComponent();

        private void Lab01_Bai04_Load(object sender, EventArgs e)
        {
            movies.Add("Đào, phở và piano", (45000, new() { 1, 2, 3 }));
            movies.Add("Mai", (100000, new() { 2, 3 }));
            movies.Add("Gặp lại chị bầu", (70000, new() { 1 }));
            movies.Add("Tarot", (90000, new() { 3 }));

            cbChonPhim.Items.AddRange(movies.Keys.ToArray());

            foreach (Control c in gbChonGhe.Controls)
                if (c is Button b) b.Click += SeatButton_Click;
        }

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
            LoadSoldTickets();
            txtThongTin.Clear();
        }

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

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                cbChonPhim.SelectedItem == null ||
                cbPhongChieu.SelectedItem == null ||
                selectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin và chọn ghế!"); return;
            }

            string movie = cbChonPhim.Text;
            int room = Convert.ToInt32(cbPhongChieu.Text);
            double basePrice = movies[movie].Price, total = 0;
            var sb = new StringBuilder();
            sb.AppendLine($"Họ tên: {txtHoTen.Text}\r\nPhim: {movie}\r\nPhòng chiếu: {room}\r\nGhế:");

            var key = $"{movie}-{room}";
            if (!soldTickets.ContainsKey(key)) soldTickets[key] = new();

            foreach (var seat in selectedSeats)
            {
                double price = CalcPrice(seat.Text, basePrice);
                sb.AppendLine($"{seat.Text} - {price:N0}đ");
                total += price;
                soldTickets[key].Add(seat.Text);
                seat.BackColor = Color.Red; seat.Enabled = false;
            }

            txtThongTin.Text = sb + $"Tổng tiền: {total:N0}đ";
            selectedSeats.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (var s in selectedSeats) s.BackColor = SystemColors.Control;
            selectedSeats.Clear();
            txtHoTen.Clear(); txtThongTin.Clear();
            cbChonPhim.SelectedIndex = -1; cbPhongChieu.Items.Clear();
            ResetSeats();
        }

        private double CalcPrice(string seat, double basePrice)
        {
            char row = seat[0]; int col = int.Parse(seat.Substring(1));
            if ((row == 'A' || row == 'C') && (col == 1 || col == 5)) return basePrice / 4;
            if (row == 'B' && col >= 2 && col <= 4) return basePrice * 2;
            return basePrice;
        }

        private void ResetSeats()
        {
            foreach (Control c in gbChonGhe.Controls)
                if (c is Button b) { b.Enabled = true; b.BackColor = SystemColors.Control; }
            selectedSeats.Clear();
        }

        private void LoadSoldTickets()
        {
            if (cbChonPhim.SelectedItem == null || cbPhongChieu.SelectedItem == null) return;
            string key = $"{cbChonPhim.Text}-{cbPhongChieu.Text}";
            if (!soldTickets.ContainsKey(key)) return;

            foreach (Control c in gbChonGhe.Controls)
                if (c is Button b && soldTickets[key].Contains(b.Text))
                { b.BackColor = Color.Red; b.Enabled = false; }
        }
    }
}
