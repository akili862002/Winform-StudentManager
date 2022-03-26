
namespace StudentManager {
    public partial class Login : Form 
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextBox.Texts;
            string password = this.passwordTextBox.Texts;
            Console.WriteLine("Username: ", username);
            Console.WriteLine("Password: ", password);
            
            if (password.Length < 5)
            {
                MessageBox.Show("Username or Password is not correct!", "Error");
                return;
            } else
            {
                // Authenticated
                this.DialogResult = DialogResult.OK;
                return;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cusTextField1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}