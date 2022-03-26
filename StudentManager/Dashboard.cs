using System.Data.SqlClient;
using System.Data;


namespace StudentManager
{
    public delegate void UpdateDataHandler();
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.UpdateData += () =>
            {
                this.FetchDataToTable();
            };

            addStudentForm.ShowDialog();
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentIndex = this.studentsTable.CurrentCell.RowIndex;

            if (currentIndex > -1)
            {
                DataGridViewRow row = this.studentsTable.Rows[currentIndex];
                StudentEntity student = new StudentEntity();
                student
                .setId(Int32.Parse(row.Cells["id"].Value.ToString()))
                .setFirstName(row.Cells["first_name"].Value.ToString())
                .setLastName(row.Cells["last_name"].Value.ToString())
                .setBirthdate(DateTime.Parse(row.Cells["birthdate"].Value.ToString()))
                .setPhone(row.Cells["phone"].Value.ToString())
                .setGender(row.Cells["gender"].Value.ToString() == "Male" ? StudentEntity.GenderType.Male : StudentEntity.GenderType.Famale)
                .setAddress(row.Cells["address"].Value.ToString())
                .setAvatar(row.Cells["avatarURL"].Value.ToString());


                EditOrRemoveForm editOrRemoveForm = new EditOrRemoveForm(student);
                editOrRemoveForm.ShowDialog();
            }

        }

        private void FetchDataToTable()
        {
            SQLHandler sqlHandler = new SQLHandler();
            SqlDataAdapter da = sqlHandler.getAllStudentsAdapter();
            DataTable tb = new DataTable();

            da.Fill(tb);
            this.studentsTable.DataSource = tb;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.FetchDataToTable();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void studentsTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.studentsTable.Columns[e.ColumnIndex].Name == "avatar")
            {
                e.Value = Helper.GetImageFromUrl(e.Value.ToString());
            }
        }


        public void refreshButton_Click(object sender, EventArgs e)
        {
            this.FetchDataToTable();
        }

        private void studentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentsTable_ColumnDividerDoubleClick(object sender, DataGridViewColumnDividerDoubleClickEventArgs e)
        {
        }
    }
}
