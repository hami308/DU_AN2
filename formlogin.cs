namespace GiaoDien_qlpks
{
    public partial class FormDangnhap : System.Windows.Forms.Form
    {
        public FormDangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Textbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || textBox2.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin", "THÔNG BÁO",MessageBoxButtons.YesNoCancel);
            }
            else
            {
                if ((textBox1.Text == "ha my") && (textBox2.Text == "123"))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    Form formchinh = new formchinh();
                    formchinh.ShowDialog();
                }
                else
                    MessageBox.Show("Vui lòng nhập lại thông tin", "THÔNG BÁO",MessageBoxButtons.YesNoCancel);

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormDangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}