namespace Forms_Örnek_2
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }
        List<string> studentlist = new List<string>();
        string[] sayilar = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        int sayac = 0;
        private void btnStudentNameAdd_Load(object sender, EventArgs e)
        {
            foreach (var student in studentlist)
            {
                lbxStudentList.Items.Clear();
                lbxStudentList.Items.Add(student);

            }
        }

        private void lbxStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            foreach (var sayi in sayilar)
            {
                if (tbxStudentNameText.Text.Contains(sayi))
                {
                    sayac++;
                }
            }


            if (tbxStudentNameText.Text.Length <= 1)
            {
                MessageBox.Show("İsim giriniz.");
            }
            else if (sayac >= 1)
            {
                MessageBox.Show("İsimde rakam bulunamaz.");
                tbxStudentNameText.Clear();
                sayac = 0;
            }
            else
            {
                lbxStudentList.Items.Add(tbxStudentNameText.Text);
                tbxStudentNameText.Clear();

                foreach (var student in studentlist)
                {
                    lbxStudentList.Items.Clear();
                    lbxStudentList.Items.Add(student);
                }
            }



        }

        private void tbxStudentNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStudentNameText_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentRemove_Click(object sender, EventArgs e)
        {
            lbxStudentList.Items.Remove(lbxStudentList.SelectedItem);
            foreach (var student in studentlist)
            {
                lbxStudentList.Items.Clear();
                lbxStudentList.Items.Add(student);
            }
        }
    }
}