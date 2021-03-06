using System;

namespace StudentManager
{
    public partial class EditOrRemoveForm : Form
    {
        StudentEntity student;
        UpdateDataHandler UpdateData;

        public EditOrRemoveForm(StudentEntity student)
        {
            this.student = student;
            InitializeComponent();
        }

        private void EditOrRemoveForm_Load(object sender, EventArgs e)
        {
            this.firstNameTextField.Texts = student.first_name;
            this.lastNameTextField.Texts = student.last_name;
            this.birthdateDatePicker.Value = DateTime.Parse(student.birthdate);
            this.maleRadio.Checked = student.gender == StudentEntity.GenderType.Male.ToString();
            this.famaleRadio.Checked = student.gender == StudentEntity.GenderType.Famale.ToString();
            this.phoneNumberTextField.Texts = student.phone;
            this.addressTextField.Texts = student.address;
            if (student.avatar.Length > 0)
                this.avatarPicture.Image = Helper.GetImageFromUrl(student.avatar);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SQLHandler sqlHandler = new SQLHandler();
            sqlHandler.deleteStudentByIdSQL(student.id);
            this.UpdateData();
        }
    }
}
