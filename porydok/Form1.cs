namespace porydok
{
    public partial class Form1 : Form
    {
        private List<string> imagePaths = new List<string>
        {
            @"C:\Users\User\Desktop\HONDA_ASIMO.jpg",
            @"C:\Users\User\Desktop\30 Роботы 2.png",
            @"C:\Users\User\Desktop\images.jpg"
        };
        private int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            ShowImage();
        }

        private void ShowImage()
        {
            pictureBox2.ImageLocation = imagePaths[currentIndex];
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            label1.Text = $"Робот {currentIndex + 1} из {imagePaths.Count}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
        
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + imagePaths.Count) % imagePaths.Count;
            ShowImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % imagePaths.Count;
            ShowImage();
        }
    }
}
