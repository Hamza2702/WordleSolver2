using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word2
{
    public partial class WordleSolver : Form
    {
        int existingTextBoxCount = 5;
        int newTextBoxCount = 5;
        List<String> words = new List<String>();

        public WordleSolver()
        {
            InitializeComponent();
        }
        private void FormLoad(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            // Load words
            LoadWordsFromFile("words.txt");
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            AddRow();
        }


        private void btnInvalidClear_Click(object sender, EventArgs e)
        {
            foreach (var txtBoxInvalid in groupBoxInvalid.Controls.OfType<TextBox>())
            {
                txtBoxInvalid.Clear();
            }
        }

        private void AddRow()
        {
            // Track the number of textboxes added
            int textBoxCount = groupBoxInvalid.Controls.OfType<TextBox>().Count();

            // Allow add two rows
            if (groupBoxInvalid.Size.Height != 143)
            {
                groupBoxInvalid.Size = new Size(groupBoxInvalid.Size.Width, groupBoxInvalid.Size.Height + 40);

                for (int i = 0; i < newTextBoxCount; i++)
                {
                    // Calculate the index for the new textbox
                    int newIndex = textBoxCount + i + 1;

                    // Find the existing textbox
                    TextBox existingTextBox = (TextBox)groupBoxInvalid.Controls["txtBoxInvalid" + ((newIndex - 1) % existingTextBoxCount + 1)];

                    // Create a new TextBox
                    TextBox txtBoxInvalid = new TextBox();
                    txtBoxInvalid.Name = "txtBoxInvalid" + newIndex;
                    txtBoxInvalid.Location = new Point(existingTextBox.Location.X, existingTextBox.Location.Y + 40 * ((newIndex - 1) / existingTextBoxCount));
                    txtBoxInvalid.Size = new Size(existingTextBox.Size.Width, existingTextBox.Size.Height);
                    txtBoxInvalid.BackColor = Color.White;
                    txtBoxInvalid.ForeColor = Color.Black;
                    txtBoxInvalid.Font = existingTextBox.Font;

                    // Add the new TextBox to the GroupBox
                    groupBoxInvalid.Controls.Add(txtBoxInvalid);
                }

                // Update the count of existing textboxes
                existingTextBoxCount += newTextBoxCount;
            }
            newTextBoxCount += 5;
        }

        private void LoadWordsFromFile(string filePath)
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read all lines from file
                string[] fileWords = File.ReadAllLines(filePath);

                foreach (var item in fileWords)
                {
                    string word = item.Trim().ToLower();

                    // Add word if it isn't empty
                    if (!string.IsNullOrEmpty(word))
                    {
                        words.Add(word);
                    }
                }
            }
            else
            {
                MessageBox.Show("File doesn't exist");
            }
        }
    }
}
