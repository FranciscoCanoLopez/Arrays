using System.Drawing.Text;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        int[] Numbers;
        int index;
        int[,,] array3D;
        public Form1()
        {
            InitializeComponent();
            Numbers = new int[5];
            index = 0;
            array3D = new int[3, 3, 3];
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

        private void BTNSaveUnidimensional_Click(object sender, EventArgs e)
        {
            if (index < 5)
            {
                if (int.TryParse(TBunidimensional.Text, out int number))
                {
                    Numbers[index] = number;
                    index++;
                    TBunidimensional.Clear();
                    if (index == 5)
                    {
                        int sum = 0;
                        foreach (int num in Numbers)
                        {
                            sum += num;
                        }
                        MessageBox.Show("The sum of the numbers is: " + sum);
                        Numbers = new int[5];
                        index = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid number.");
                }
            }
        }

        private void ShowArray3D_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        array3D[i, j, k] = i + j + k;
                    }
                }
            }
            TBresult.Clear();
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        TBresult.AppendText($"Slot [{i},{j},{k}]\r\n");
                    }
                }
            }
        }

        private void BTClear_Click(object sender, EventArgs e)
        {
            TBresult.Clear();
        }
    }
}
