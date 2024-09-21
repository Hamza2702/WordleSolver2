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

        List<String> invalidLetters = new List<string>(new string[26]);
        List<String> validLetters = new List<string>(new string[5]);
        List<string> correctLetters = new List<string>(new string[5]);
        string letter;
        public WordleSolver()
        {
            InitializeComponent();
            // Correct
            foreach (Control control in groupBoxCorrect.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Name.Contains("txtBoxCorrect1"))
                    {
                        (control as TextBox).TextChanged += TxtBoxCorrect1_TextChanged;
                        (control as TextBox).KeyDown += TxtBoxCorrect1_KeyDown;
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
            // Valid
            foreach (Control control in groupBoxValid.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Name.Contains("txtBoxValid1"))
                    {
                        (control as TextBox).TextChanged += TxtBoxValid1_TextChanged;
                    }
                    if (control.Name.Contains("txtBoxValid2"))
                    {
                        (control as TextBox).TextChanged += TxtBoxValid2_TextChanged;
                    }
                    if (control.Name.Contains("txtBoxValid3"))
                    {
                        (control as TextBox).TextChanged += TxtBoxValid3_TextChanged;
                    }
                    if (control.Name.Contains("txtBoxValid4"))
                    {
                        (control as TextBox).TextChanged += TxtBoxValid4_TextChanged;
                    }
                    if (control.Name.Contains("txtBoxValid5"))
                    {
                        (control as TextBox).TextChanged += TxtBoxValid5_TextChanged;
                    }
                }
            }
            // Invalid
            foreach (Control control in groupBoxInvalid.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Name.Contains("txtBoxInvalid1"))
                    {
                        (control as TextBox).TextChanged += TxtBoxInvalid1_TextChanged;
                    }
                    if (control.Name.Contains("txtBoxInvalid2"))
                    {
                        (control as TextBox).TextChanged += TxtBoxInvalid2_TextChanged;
                    }
                    if (control.Name.Contains("txtBoxInvalid3"))
                    {
                        (control as TextBox).TextChanged += TxtBoxInvalid3_TextChanged;
                    }
                    if (control.Name.Contains("txtBoxInvalid4"))
                    {
                        (control as TextBox).TextChanged += TxtBoxInvalid4_TextChanged;
                    }
                    if (control.Name.Contains("txtBoxInvalid5"))
                    {
                        (control as TextBox).TextChanged += TxtBoxInvalid5_TextChanged;
                    }
                    if (control.Name.Contains("txtBoxInvalid6"))
                    {
                        (control as TextBox).TextChanged += TxtBoxInvalid6_TextChanged;
                    }
                    if (control.Name.Contains("txtBoxInvalid7"))
                    {
                        (control as TextBox).TextChanged += TxtBoxInvalid7_TextChanged;
                    }
                    if (control.Name.Contains("txtBoxInvalid8"))
                    {
                        (control as TextBox).TextChanged += TxtBoxInvalid8_TextChanged;
                    }
                    if (control.Name.Contains("txtBoxInvalid9"))
                    {
                        (control as TextBox).TextChanged += TxtBoxInvalid9_TextChanged;
                    }
                    if (control.Name.Contains("txtBoxInvalid10"))
                    {
                        (control as TextBox).TextChanged += TxtBoxInvalid10_TextChanged;
                    }
                }
            }
        }
        

        // CORRECT
        // TEXT BOX 1
        private void TxtBoxCorrect1_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            CorrectTextChanged(textbox, e, 0);
        }

        private void TxtBoxCorrect1_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textbox = sender as TextBox;

            // If backspace and is empty, don't process
            if (e.KeyCode == Keys.Back && string.IsNullOrEmpty(textbox.Text))
            {
                e.SuppressKeyPress = true; // Stop backspace key from being processed
                FindCorrectWord(); // Update list box
                return;
            }
        }
        // TEXT BOX 2
        private void TxtBoxCorrect2_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            CorrectTextChanged(textbox, e, 1);
        }

        private void TxtBoxCorrect2_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textbox = sender as TextBox;
            CorrectKeyUp(textbox, e);
        }
        // TEXT BOX 3
        private void TxtBoxCorrect3_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            CorrectTextChanged(textbox, e, 2);
        }
        private void TxtBoxCorrect3_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textbox = sender as TextBox;
            CorrectKeyUp(textbox, e);
        }
        // TEXT BOX 4
        private void TxtBoxCorrect4_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            CorrectTextChanged(textbox, e, 3);

        }

        private void TxtBoxCorrect4_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textbox = sender as TextBox;
            CorrectKeyUp(textbox, e);
        }
        // TEXT BOX 5
        private void TxtBoxCorrect5_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            letter = textbox.Text.Trim().ToLower();
            textbox.Text = letter;

            // If empty, don't process
            if (string.IsNullOrEmpty(textbox.Text))
            {
                correctLetters[4] = "";
            }
            else
            {
                correctLetters[4] = textbox.Text;
            }

            FilterLetter(textbox);
            FindCorrectWord();
        }
        private void TxtBoxCorrect5_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textbox = sender as TextBox;
            CorrectKeyUp(textbox, e);
        }
        private void FormLoad(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            // Load words
            LoadWordsFromFile("words.txt");
        }

        // VALID
        // TEXT BOX 1
        private void TxtBoxValid1_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            letter = textbox.Text.Trim().ToLower();
            textbox.Text = letter;

            // If empty, don't process
            if (string.IsNullOrEmpty(textbox.Text))
            {
                validLetters[0] = "";
            }
            else
            {
                validLetters[0] = textbox.Text;
            }

            FilterLetter(textbox);
            FindCorrectWord();
        }

        // TEXT BOX 2
        private void TxtBoxValid2_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            letter = textbox.Text.Trim().ToLower();
            textbox.Text = letter;

            // If empty, don't process
            if (string.IsNullOrEmpty(textbox.Text))
            {
                validLetters[1] = "";
            }
            else
            {
                validLetters[1] = textbox.Text;
            }

            FilterLetter(textbox);
            FindCorrectWord();
        }

        // TEXT BOX 3
        private void TxtBoxValid3_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            letter = textbox.Text.Trim().ToLower();
            textbox.Text = letter;

            // If empty, don't process
            if (string.IsNullOrEmpty(textbox.Text))
            {
                validLetters[2] = "";
            }
            else
            {
                validLetters[2] = textbox.Text;
            }

            FilterLetter(textbox);
            FindCorrectWord();
        }

        // TEXT BOX 4
        private void TxtBoxValid4_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            letter = textbox.Text.Trim().ToLower();
            textbox.Text = letter;

            // If empty, don't process
            if (string.IsNullOrEmpty(textbox.Text))
            {
                validLetters[3] = "";
            }
            else
            {
                validLetters[3] = textbox.Text;
            }

            FilterLetter(textbox);
            FindCorrectWord();
        }

        // TEXT BOX 5
        private void TxtBoxValid5_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            letter = textbox.Text.Trim().ToLower();
            textbox.Text = letter;

            // If empty, don't process
            if (string.IsNullOrEmpty(textbox.Text))
            {
                validLetters[4] = "";
            }
            else
            {
                validLetters[4] = textbox.Text;
            }

            FilterLetter(textbox);
            FindCorrectWord();
        }

        private void TxtBoxInvalid1_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textbox = sender as TextBox;
            CorrectKeyUp(textbox, e);
        }

        // INVALID
        // TEXT BOX 1
        private void TxtBoxInvalid1_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            InvalidTextChanged(textbox, e, 0);
        }
        // TEXT BOX 2
        private void TxtBoxInvalid2_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            InvalidTextChanged(textbox, e, 1);
        }
        // TEXT BOX 3
        private void TxtBoxInvalid3_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            InvalidTextChanged(textbox, e, 2);
        }
        // TEXT BOX 4
        private void TxtBoxInvalid4_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            InvalidTextChanged(textbox, e, 3);
        }
        // TEXT BOX 5
        private void TxtBoxInvalid5_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            InvalidTextChanged(textbox, e, 4);
        }
        // TEXT BOX 6
        private void TxtBoxInvalid6_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            InvalidTextChanged(textbox, e, 5);
        }
        // TEXT BOX 7
        private void TxtBoxInvalid7_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            InvalidTextChanged(textbox, e, 6);
        }
        // TEXT BOX 8
        private void TxtBoxInvalid8_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            InvalidTextChanged(textbox, e, 7);
        }
        // TEXT BOX 9
        private void TxtBoxInvalid9_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            InvalidTextChanged(textbox, e, 8);
        }
        // TEXT BOX 10
        private void TxtBoxInvalid10_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            InvalidTextChanged(textbox, e, 9);
        }

        private void InvalidTextChanged(TextBox textbox, EventArgs e, int v)
        {
            letter = textbox.Text.Trim().ToLower();
            textbox.Text = letter;

            // If empty, don't process
            if (string.IsNullOrEmpty(textbox.Text))
            {
                invalidLetters[v] = "";
            }
            else
            {
                invalidLetters[v] = textbox.Text;
            }

            FilterLetter(textbox);
            FindCorrectWord();
        }

        // BUTTONS
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
            foreach (Control control in groupBoxCorrect.Controls)
            {
                control.Text = "";
            }
            txtBoxCorrect1.Focus();
        }
        private void FindCorrectWord()
        {
            int wordCount = 0;
            // Clear list
            listBoxWords.Items.Clear();

            // Invalid Letters check
            foreach (var letter in correctLetters.Concat(validLetters))
            {
                if (!string.IsNullOrEmpty(letter) && invalidLetters.Contains(letter))
                {
                    MessageBox.Show($"The letter '{letter}' is invalid.", "Invalid Letter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Filter the words
            var filteredWords = words.Where(word =>
            {
                // Check if the word matches the exact sequence of letters in correctLetters
                for (int i = 0; i < correctLetters.Count; i++)
                {
                    if (!string.IsNullOrEmpty(correctLetters[i]) && word.Length > i && word[i] != correctLetters[i][0])
                    {
                        return false;
                    }
                }

                // Check for valid letters
                for (int i = 0; i < validLetters.Count; i++)
                {
                    if (!string.IsNullOrEmpty(validLetters[i]))
                    {
                        // Ensure the word contains the valid letter but not in the validLetters[i] position
                        if (!word.Contains(validLetters[i][0]) || (word.Length > i && word[i] == validLetters[i][0]))
                        {
                            return false;
                        }
                    }
                }

                // Check if the word doesn't contain any excluded letters
                bool excludeCheck = invalidLetters.All(l => string.IsNullOrEmpty(l) || !word.Contains(l));

                return excludeCheck;
            });

            // Add to list box
            foreach (var word in filteredWords)
            {
                wordCount++;
                listBoxWords.Items.Add(word);
            }

            // Update label
            lblPossibleWords.Text = ($"Possible words: {wordCount}");
        }

        private void FilterLetter(TextBox tb)
        {
            letter = tb.Text.Trim().ToLower();
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

                    // Assign the TextChanged event handler
                    txtBoxInvalid.TextChanged += new EventHandler(TxtBoxInvalid_TextChanged);
                }

                // Update the count of existing textboxes
                existingTextBoxCount += newTextBoxCount;
            }
            newTextBoxCount += 5;
        }

        private void TxtBoxInvalid_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            InvalidTextChanged(textbox, e, int.Parse(textbox.Name.Replace("txtBoxInvalid", "")) - 1);
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

        // CORRECT
        private void CorrectKeyUp(TextBox textbox, KeyEventArgs e)
        {

            // If backspace and is empty, don't process
            if (e.KeyCode == Keys.Back && string.IsNullOrEmpty(textbox.Text))
            {
                e.SuppressKeyPress = true; // Stop backspace key from being processed
                FindCorrectWord(); // Update list box

                if (string.IsNullOrEmpty(textbox.Text))
                {
                    // Focus on previous textbox
                    GroupBox groupBox = textbox.Parent as GroupBox;
                    Control prevTextBox = groupBox.GetNextControl(textbox, false);
                    if (prevTextBox != null && prevTextBox is TextBox)
                    {
                        prevTextBox.Focus();
                    }
                }
                return;
            }
        }

        private void CorrectTextChanged(TextBox textbox, EventArgs e, int v)
        {
            letter = textbox.Text.Trim().ToLower();
            textbox.Text = letter;

            // If empty, don't process
            if (string.IsNullOrEmpty(textbox.Text))
            {
                correctLetters[v] = "";
            }
            else
            {
                correctLetters[v] = textbox.Text;
            }

            FilterLetter(textbox);
            FindCorrectWord();

            // Focus onto next textbox
            GroupBox groupBox = textbox.Parent as GroupBox;
            if (groupBox != null)
            {
                this.SelectNextControl(textbox, true, true, true, true);
            }
        }

        // VALID

        // INVALID
    }
}
