using System.Collections.Generic;
using System.Data;

namespace NoteTakingApp
{
    public partial class MainForm : Form
    {
        DataTable table;
        public MainForm()
        {
            InitializeComponent();
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            // DataSource returns the data that'll be stored in the table object
            notesList.DataSource = table;

            notesList.Columns["Messages"].Visible = false;
            notesList.Columns["Title"].Width = notesList.Width;
        }

        private void exitOption_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutOption_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Gabriel Barsani.");
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            titleText.Clear();
            messageText.Clear();
            titleText.Focus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            table.Rows.Add(titleText.Text, messageText.Text);
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            int index = notesList.CurrentCell.RowIndex;

            if (index >= 0)
            {
                titleText.Text = table.Rows[index].ItemArray[0].ToString();
                messageText.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this note?", "Delete note", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int index = notesList.CurrentCell.RowIndex;
                    table.Rows[index].Delete();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There's no selected note to delete.");
            }
            
        }

        private void notesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = notesList.CurrentCell.RowIndex;

            if (index >= 0)
            {
                titleText.Text = table.Rows[index].ItemArray[0].ToString();
                messageText.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }
    }
}