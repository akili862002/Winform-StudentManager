namespace StudentManager
{
    public partial class AddStudentForm : Form
    {
        public event UpdateDataHandler UpdateData;
        public AddStudentForm()
        {
            InitializeComponent();
        }

        #region Unuse functions
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cusTextField5_Load(object sender, EventArgs e)
        {

        }

        private void studentIdTextField_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void avatarPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(opnfd.FileName);
                Console.WriteLine("w: " + img.Width);
                Console.WriteLine("h: " + img.Height);
                if (img.Width != img.Height)
                {
                    MessageBox.Show(String.Format("Please select a square image! ({0}x{1})", img.Width, img.Height), "Error");
                    return;
                }
                this.avatarPicture.Image = img;
            }
        }

        private void closeDialog()
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.closeDialog();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            StudentEntity student = new StudentEntity();
            student
               .setFirstName(this.firstNameTextField.Texts)
               .setLastName(this.lastNameTextField.Texts)
               .setBirthdate(this.birthdateDatePicker.Value)
               .setPhone(this.phoneNumberTextField.Texts)
               .setAddress(this.firstNameTextField.Texts)
               .setAvatar("https://cdn-icons-png.flaticon.com/128/149/149071.png");
            if (this.maleRadio.Checked)
                student.setGender(StudentEntity.GenderType.Male);
            if (this.famaleRadio.Checked)
                student.setGender(StudentEntity.GenderType.Famale);
            SQLHandler sqlHandler = new SQLHandler();

            sqlHandler.createStudentSQL(student);
            this.closeDialog();
            UpdateData();
        }
    }
}
