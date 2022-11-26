namespace xp
{
    public partial class LoginMenu : Form
    {
        Menu m = new Menu();
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if(textKey.Text != "xp")
            {
                MessageBox.Show("Error 101: key is uncorrect!");
            }
            else
            {
                this.Hide();
                m.Show();
            }
        }
    }
}