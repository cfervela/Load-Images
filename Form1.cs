namespace fernandaVelaLoadImages
{
    public partial class Form1 : Form
    {
        OpenFileDialog open = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadMovies_Click(object sender, EventArgs e)
        {
            open.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png|GIF|*.gif";
            open.Multiselect = true;

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(open.FileNames[0].ToString());
                pictureBox2.Image = System.Drawing.Image.FromFile(open.FileNames[1].ToString());
                pictureBox3.Image = System.Drawing.Image.FromFile(open.FileNames[2].ToString());
                pictureBox4.Image = System.Drawing.Image.FromFile(open.FileNames[3].ToString());
                pictureBox5.Image = System.Drawing.Image.FromFile(open.FileNames[4].ToString());
                pictureBox6.Image = System.Drawing.Image.FromFile(open.FileNames[5].ToString());
            }

        }
    }
}
