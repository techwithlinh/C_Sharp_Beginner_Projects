namespace Lập_trình_C__WinForm
{
    public partial class MainForm : Form
    {
        private int counter = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            counter++;
            lblCount.Text = counter.ToString();
        }
    }
}