namespace bai_5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var courses = new List<Course>
            {
                new("C01", "Lập trình C# cơ bản"),
                new("C02", "Thiết kế giao diện Windows Forms"),
                new("C03", "Lập trình Web với ASP.NET Core")
            };

            cboCourse.DataSource = courses;
            cboCourse.DisplayMember = nameof(Course.CourseName);
            cboCourse.ValueMember = nameof(Course.CourseCode);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var fullName = txtFullName.Text.Trim();
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Vui lòng nhập họ và tên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (cboCourse.SelectedItem is not Course selectedCourse)
            {
                MessageBox.Show("Vui lòng chọn khóa học.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCourse.Focus();
                return;
            }

            if (!mtxtPhone.MaskCompleted)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số điện thoại.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtPhone.Focus();
                return;
            }

            var gender = rdoMale.Checked ? "Nam" : rdoFemale.Checked ? "Nữ" : "Chưa chọn";
            try
            {
                new RegistrationRepository().Save(new CourseRegistration(
                    fullName,
                    gender,
                    selectedCourse.CourseCode,
                    selectedCourse.CourseName,
                    dtpBirthDate.Value,
                    mtxtPhone.Text,
                    chkUpdates.Checked));
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Không thể lưu đăng ký vào SQL Server LocalDB.\n{ex.Message}",
                    "Lỗi lưu dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var message = $"Thông tin đăng ký khóa học\n\n" +
                          $"Họ và tên: {fullName}\n" +
                          $"Giới tính: {gender}\n" +
                          $"Khóa học: {selectedCourse.CourseName} ({selectedCourse.CourseCode})\n" +
                          $"Ngày sinh: {dtpBirthDate.Value:dd/MM/yyyy}\n" +
                          $"Số điện thoại: {mtxtPhone.Text}\n" +
                          $"Nhận thông tin khóa học mới: {(chkUpdates.Checked ? "Có" : "Không")}";

            MessageBox.Show(message, "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private sealed record Course(string CourseCode, string CourseName);
    }
}
