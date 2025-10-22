using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab02
{
    public partial class Lab02_Bai03 : Form
    {
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        // Đọc file input3.txt
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "D:\\LTM\\LAB02\\Lab02\\Lab02\\Input-Output\\input3.txt";
                // Kiểm tra file có tồn tại không
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Không tìm thấy file input3.txt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Đọc file
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fs))
                {
                    string content = sr.ReadToEnd();
                    rtbNoiDung.Text = content;
                }

                MessageBox.Show("Đọc file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tính toán và ghi ra file output3.txt
        private void btnCalc_Click(object sender, EventArgs e)
        {
            string inputPath = "D:\\LTM\\LAB02\\Lab02\\Lab02\\Input-Output\\input3.txt";
            string outputPath = "D:\\LTM\\LAB02\\Lab02\\Lab02\\Input-Output\\output3.txt";
            // Kiểm tra file output có tồn tại không
            if (!File.Exists(outputPath))
            {
                MessageBox.Show("Không tìm thấy file output3.txt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra file input có tồn tại không
            if (!File.Exists(inputPath))
            {
                MessageBox.Show("Không tìm thấy file input3.txt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Đọc nội dung file input
            string[] lines = File.ReadAllLines(inputPath);
            // Kiểm tra rỗng
            if (lines.Length == 0 || lines.All(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("File input3.txt rỗng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<string> outputLines = new List<string>();
            // Kiểm tra từng biểu thức có lỗi không
            int errorCount = 0;
            foreach (var expr in lines)
            {
                try
                {
                    double result = EvaluateExpression(expr);
                    outputLines.Add($"{expr} = {result}");
                }
                catch
                {
                    errorCount++;
                    outputLines.Add($"{expr} = Lỗi biểu thức");
                }
            }
            // Báo kết quả tổng quát
            if (errorCount == 0)
                MessageBox.Show("Các biểu thức hợp lệ. Tính toán thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"Có {errorCount} biểu thức bị lỗi trong file input3.txt!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // Ghi kết quả vào file output3
            File.WriteAllLines(outputPath, outputLines);
            MessageBox.Show("Đã ghi kết quả vào output3.txt");
        }
        // Hàm tính toán biểu thức
        private double EvaluateExpression(string expr)
        {
            Stack<double> values = new Stack<double>();
            Stack<char> ops = new Stack<char>();

            for (int i = 0; i < expr.Length; i++)
            {
                if (expr[i] == ' ') continue;

                if (char.IsDigit(expr[i]))
                {
                    string num = "";
                    while (i < expr.Length && (char.IsDigit(expr[i]) || expr[i] == '.'))
                    {
                        num += expr[i];
                        i++;
                    }
                    i--;
                    values.Push(double.Parse(num));
                }
                else if (expr[i] == '(')
                {
                    ops.Push(expr[i]);
                }
                else if (expr[i] == ')')
                {
                    while (ops.Peek() != '(')
                        values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));
                    ops.Pop();
                }
                else if ("+-*/".Contains(expr[i]))
                {
                    while (ops.Count > 0 && HasPrecedence(expr[i], ops.Peek()))
                        values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));
                    ops.Push(expr[i]);
                }
            }

            while (ops.Count > 0)
                values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));

            return values.Pop();
        }

        // Kiểm tra độ ưu tiên
        private bool HasPrecedence(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')') return false;
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-')) return false;
            return true;
        }

        // Thực hiện phép toán
        private double ApplyOp(char op, double b, double a)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return b == 0 ? 0 : a / b;
            }
            return 0;
        }
    }
}
