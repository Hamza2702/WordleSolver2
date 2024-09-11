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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Word2
{
    public partial class WordleSolver : Form
    {
        int existingTextBoxCount = 5;
        int newTextBoxCount = 5;
        List<String> words = new List<String>();

        Stack<String> invalidLetters = new Stack<string>();
        Stack<String> validLetters = new Stack<string>();
        List<string> correctLetters = new List<string>(new string[5]);
        String correctWord = "";
        public WordleSolver()
        {
            InitializeComponent();
            foreach (Control control in groupBoxCorrect.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Name.Contains("txtBoxCorrect1"))
                    {
                        (control as TextBox).TextChanged += TxtBoxCorrect1_TextChanged;
                        (control as TextBox).KeyUp += TxtBoxCorrect1_KeyUp;
                    }
                    if (control.Name.Contains("txtBoxCorrect2"))
                    {
                        (control as TextBox).TextChanged += TxtBoxCorrect2_TextChanged;
                        (control as TextBox).KeyUp += TxtBoxCorrect2_KeyUp;
                    }
                    if (control.Name.Contains("txtBoxCorrect3"))
                    {
                        (control as TextBox).TextChanged += TxtBoxCorrect3_TextChanged;
                       // (control as TextBox).KeyUp += TxtBoxCorrect3_KeyUp;
                    }
                    if (control.Name.Contains("txtBoxCorrect4"))
                    {
                        (control as TextBox).TextChanged += TxtBoxCorrect4_TextChanged;
                       // (control as TextBox).KeyUp += TxtBoxCorrect4_KeyUp;
                    }
                    if (control.Name.Contains("txtBoxCorrect5"))
                    {
                        (control as TextBox).TextChanged += TxtBoxCorrect5_TextChanged;
                       // (control as TextBox).KeyUp += TxtBoxCorrect5_KeyUp;
                    }
                }
            }
        }

        private void TxtBoxCorrect1_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;

            // If the text box is empty, don't process
            if (string.IsNullOrEmpty(textbox.Text))
            {
                correctLetters[0] = "";
            }
            else
            {
                correctLetters[0] = textbox.Text;
            }

            FilterLetter(textbox);
            FindCorrectWord();
        }

        private void TxtBoxCorrect1_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textbox = sender as TextBox;

            // If backspace and the text box is empty, don't process
            if (e.KeyCode == Keys.Back && string.IsNullOrEmpty(textbox.Text))
            {
                e.SuppressKeyPress = true; // Prevents the backspace key from being processed
                correctLetters[0] = ""; // Clear the specific position in the list
                correctWord = string.Join("", correctLetters);
                FindCorrectWord();
                return;
            }
        }
        // TEXT BOX 2
        private void TxtBoxCorrect2_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;

            // If the text box is empty, don't process
            if (string.IsNullOrEmpty(textbox.Text))
            {
                correctLetters[0] = "";
            }
            else
            {
                correctLetters[0] = textbox.Text;
            }

            FilterLetter(textbox);
            FindCorrectWord();
        }

        private void TxtBoxCorrect2_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textbox = sender as TextBox;

            // If backspace and the text box is empty, don't process
            if (e.KeyCode == Keys.Back && string.IsNullOrEmpty(textbox.Text))
            {
                e.SuppressKeyPress = true; // Prevents the backspace key from being processed
                correctLetters[1] = ""; // Clear the specific position in the list
                FindCorrectWord();
                correctWord = string.Join("", correctLetters);
                return;
            }
        }
        // TEXT BOX 3
        private void TxtBoxCorrect3_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox1 = sender as TextBox;
            //correctLetters.Push(txtBoxCorrect3.Text);
            FindCorrectWord();
        }
        private void TxtBoxCorrect4_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox1 = sender as TextBox;
            //correctLetters.Push(txtBoxCorrect4.Text);
            FindCorrectWord();
        }
        private void TxtBoxCorrect5_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox1 = sender as TextBox;
            //correctLetters.Push(txtBoxCorrect5.Text);
            FindCorrectWord();
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
        private void btnCorrectClear_Click(object sender, EventArgs e)
        {
            
        }

        private void FindCorrectWord()
        {
            // Clear list
            listBoxWords.Items.Clear();

            // Filter the words
            var filteredWords = words.Where(word =>
            {
                if (correctLetters.Any(l => !string.IsNullOrEmpty(l)))
                {
                    // Check if each word contains the required amount of letters
                    bool includeCheck = correctLetters.All(l => string.IsNullOrEmpty(l) || word.Count(c => c == l[0]) >= correctLetters.Count(x => x == l));

                    // Check if the word doesn't contain any excluded letters
                    bool excludeCheck = invalidLetters.All(l => string.IsNullOrEmpty(l) || !word.Contains(l));

                    return includeCheck && excludeCheck;
                }
                return false;
            });

            // Add to list box
            foreach (var word in filteredWords)
            {
                listBoxWords.Items.Add(word);
            }

            MessageBox.Show(correctWord);
        }

        private void FilterLetter(TextBox tb)
        {
            string letter = tb.Text.Trim().ToLower();
            // If not a single character or '-'
            if (letter.Length != 1)
            {
                tb.Clear();
                return;
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
