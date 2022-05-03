namespace WinFormsApp1
{
    public partial class StudentRegisterationForm : Form
    {
        int studentId;
        string studentName, address;
        private int nameLength = 5;
        public StudentRegisterationForm()
        {
            InitializeComponent();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            try
            {
                    studentId = Convert.ToInt32(txtBox_studentId.Text);
                    address = txtBox_address.Text;
                    studentName = txtBox_studentName.Text;

                    if (studentName.Length > nameLength)
                {
                    MessageBox.Show($"Name shoud not be longer than {nameLength} words", "Invalid input", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    ClearInput();
                }
                else
                {
                    MessageBox.Show($"StudentId : {studentId}\nName : {studentName}\nAddress : {address}","Student Information",MessageBoxButtons.OK);

                }


            }catch(FormatException fe)
            {
                MessageBox.Show($"Error : {fe.Message}","Student Id input format error");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}","Uncatched exception");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            // Check the confirmation from the user
           if(DialogResult.Yes == MessageBox.Show("Are you sure to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                Close();
                Application.Exit();
            }
        }

        // Helper functions
        private void ClearInput()
        {
            txtBox_address.Text = "";
            txtBox_studentId.Text = "";
            txtBox_studentName.Text = "";
        }
    }
}