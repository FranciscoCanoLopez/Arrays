using System.Drawing.Text;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly string[,] Person = new string[100, 2];
        private int Count = 0;

        private void BTNSave_Click(object sender, EventArgs e)
        {
            string name = TBName.Text;
            string age = TBAge.Text;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(age))
            {
                Person[Count, 0] = name;
                Person[Count, 1] = age;

                Count++;

                TBName.Clear();
                TBAge.Clear();

                UpdateTable();
            }
            else
            {
                MessageBox.Show("Please enter a name and age.");
            }


        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < Count; i++)
            {
                dataGridView1.Rows.Add(Person[i, 0], Person[i, 1]);
            }
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
