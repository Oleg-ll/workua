namespace EasyFlat
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        

        private void Continue_Click_1(object sender, EventArgs e) 
        {
            Form2 newForm = new Form2(); // ������� ��������� Form2
            newForm.Show(); // ��������� Form2
            this.Hide(); // �������� Form1 (����� ����� ���� ���������)
        }
    }
}