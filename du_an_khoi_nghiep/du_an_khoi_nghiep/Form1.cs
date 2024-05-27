namespace du_an_khoi_nghiep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("kết nối với thiết bị thành công ,Bạn có muốn xem hướng dẫn sử dụng không?", caption: "kết nối thành công", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                huongdan formhd = new huongdan();
                formhd.ShowDialog();
            }
            else
            {
                huongdan2cs form2 = new huongdan2cs();
                form2.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}