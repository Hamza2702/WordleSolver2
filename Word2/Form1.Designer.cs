namespace Word2
{
    partial class WordleSolver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordleSolver));
            this.txtBoxCorrect1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExclude = new System.Windows.Forms.Label();
            this.lblInclude = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPossibleWords = new System.Windows.Forms.Label();
            this.listBoxWords = new System.Windows.Forms.ListBox();
            this.lblWordle = new System.Windows.Forms.Label();
            this.btnCorrectClear = new System.Windows.Forms.Button();
            this.groupBoxCorrect = new System.Windows.Forms.GroupBox();
            this.txtBoxCorrect5 = new System.Windows.Forms.TextBox();
            this.txtBoxCorrect4 = new System.Windows.Forms.TextBox();
            this.txtBoxCorrect3 = new System.Windows.Forms.TextBox();
            this.txtBoxCorrect2 = new System.Windows.Forms.TextBox();
            this.groupBoxValid = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBoxInvalid = new System.Windows.Forms.GroupBox();
            this.txtBoxInvalid5 = new System.Windows.Forms.TextBox();
            this.txtBoxInvalid4 = new System.Windows.Forms.TextBox();
            this.txtBoxInvalid3 = new System.Windows.Forms.TextBox();
            this.txtBoxInvalid2 = new System.Windows.Forms.TextBox();
            this.txtBoxInvalid1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValidClear = new System.Windows.Forms.Button();
            this.btnInvalidClear = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.groupBoxCorrect.SuspendLayout();
            this.groupBoxValid.SuspendLayout();
            this.groupBoxInvalid.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxCorrect1
            // 
            this.txtBoxCorrect1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCorrect1.Location = new System.Drawing.Point(6, 19);
            this.txtBoxCorrect1.Name = "txtBoxCorrect1";
            this.txtBoxCorrect1.Size = new System.Drawing.Size(20, 31);
            this.txtBoxCorrect1.TabIndex = 15;
            this.txtBoxCorrect1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBoxCorrect1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(29)))));
            this.label1.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Correct Letters";
            // 
            // lblExclude
            // 
            this.lblExclude.AutoSize = true;
            this.lblExclude.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.lblExclude.ForeColor = System.Drawing.Color.White;
            this.lblExclude.Location = new System.Drawing.Point(59, 321);
            this.lblExclude.Name = "lblExclude";
            this.lblExclude.Size = new System.Drawing.Size(0, 28);
            this.lblExclude.TabIndex = 10;
            // 
            // lblInclude
            // 
            this.lblInclude.AutoSize = true;
            this.lblInclude.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.lblInclude.ForeColor = System.Drawing.Color.White;
            this.lblInclude.Location = new System.Drawing.Point(86, 222);
            this.lblInclude.Name = "lblInclude";
            this.lblInclude.Size = new System.Drawing.Size(0, 28);
            this.lblInclude.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Goldenrod;
            this.label2.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valid Letters";
            // 
            // lblPossibleWords
            // 
            this.lblPossibleWords.AutoSize = true;
            this.lblPossibleWords.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPossibleWords.ForeColor = System.Drawing.Color.White;
            this.lblPossibleWords.Location = new System.Drawing.Point(379, 127);
            this.lblPossibleWords.Name = "lblPossibleWords";
            this.lblPossibleWords.Size = new System.Drawing.Size(227, 42);
            this.lblPossibleWords.TabIndex = 9;
            this.lblPossibleWords.Text = "Possible words: 0";
            // 
            // listBoxWords
            // 
            this.listBoxWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxWords.FormattingEnabled = true;
            this.listBoxWords.ItemHeight = 16;
            this.listBoxWords.Location = new System.Drawing.Point(386, 169);
            this.listBoxWords.Name = "listBoxWords";
            this.listBoxWords.Size = new System.Drawing.Size(265, 288);
            this.listBoxWords.TabIndex = 8;
            // 
            // lblWordle
            // 
            this.lblWordle.AutoSize = true;
            this.lblWordle.Font = new System.Drawing.Font("Poppins", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordle.ForeColor = System.Drawing.Color.White;
            this.lblWordle.Location = new System.Drawing.Point(166, 9);
            this.lblWordle.Name = "lblWordle";
            this.lblWordle.Size = new System.Drawing.Size(381, 84);
            this.lblWordle.TabIndex = 7;
            this.lblWordle.Text = "Wordle Solver";
            // 
            // btnCorrectClear
            // 
            this.btnCorrectClear.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrectClear.Location = new System.Drawing.Point(220, 185);
            this.btnCorrectClear.Name = "btnCorrectClear";
            this.btnCorrectClear.Size = new System.Drawing.Size(81, 34);
            this.btnCorrectClear.TabIndex = 16;
            this.btnCorrectClear.Text = "Clear";
            this.btnCorrectClear.UseVisualStyleBackColor = true;
            this.btnCorrectClear.Click += new System.EventHandler(this.btnCorrectClear_Click);
            // 
            // groupBoxCorrect
            // 
            this.groupBoxCorrect.Controls.Add(this.txtBoxCorrect5);
            this.groupBoxCorrect.Controls.Add(this.txtBoxCorrect4);
            this.groupBoxCorrect.Controls.Add(this.txtBoxCorrect3);
            this.groupBoxCorrect.Controls.Add(this.txtBoxCorrect2);
            this.groupBoxCorrect.Controls.Add(this.txtBoxCorrect1);
            this.groupBoxCorrect.Location = new System.Drawing.Point(64, 169);
            this.groupBoxCorrect.Name = "groupBoxCorrect";
            this.groupBoxCorrect.Size = new System.Drawing.Size(136, 65);
            this.groupBoxCorrect.TabIndex = 17;
            this.groupBoxCorrect.TabStop = false;
            // 
            // txtBoxCorrect5
            // 
            this.txtBoxCorrect5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCorrect5.Location = new System.Drawing.Point(110, 19);
            this.txtBoxCorrect5.Name = "txtBoxCorrect5";
            this.txtBoxCorrect5.Size = new System.Drawing.Size(20, 31);
            this.txtBoxCorrect5.TabIndex = 19;
            this.txtBoxCorrect5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBoxCorrect5_KeyUp);
            // 
            // txtBoxCorrect4
            // 
            this.txtBoxCorrect4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCorrect4.Location = new System.Drawing.Point(84, 19);
            this.txtBoxCorrect4.Name = "txtBoxCorrect4";
            this.txtBoxCorrect4.Size = new System.Drawing.Size(20, 31);
            this.txtBoxCorrect4.TabIndex = 18;
            this.txtBoxCorrect4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBoxCorrect4_KeyUp);
            // 
            // txtBoxCorrect3
            // 
            this.txtBoxCorrect3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCorrect3.Location = new System.Drawing.Point(58, 19);
            this.txtBoxCorrect3.Name = "txtBoxCorrect3";
            this.txtBoxCorrect3.Size = new System.Drawing.Size(20, 31);
            this.txtBoxCorrect3.TabIndex = 17;
            this.txtBoxCorrect3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBoxCorrect3_KeyUp);
            // 
            // txtBoxCorrect2
            // 
            this.txtBoxCorrect2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCorrect2.Location = new System.Drawing.Point(32, 19);
            this.txtBoxCorrect2.Name = "txtBoxCorrect2";
            this.txtBoxCorrect2.Size = new System.Drawing.Size(20, 31);
            this.txtBoxCorrect2.TabIndex = 16;
            this.txtBoxCorrect2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBoxCorrect2_KeyUp);
            // 
            // groupBoxValid
            // 
            this.groupBoxValid.Controls.Add(this.textBox1);
            this.groupBoxValid.Controls.Add(this.textBox2);
            this.groupBoxValid.Controls.Add(this.textBox3);
            this.groupBoxValid.Controls.Add(this.textBox4);
            this.groupBoxValid.Controls.Add(this.textBox5);
            this.groupBoxValid.Location = new System.Drawing.Point(64, 287);
            this.groupBoxValid.Name = "groupBoxValid";
            this.groupBoxValid.Size = new System.Drawing.Size(136, 65);
            this.groupBoxValid.TabIndex = 20;
            this.groupBoxValid.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(110, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(20, 31);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(84, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(20, 31);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(58, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(20, 31);
            this.textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(32, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(20, 31);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(6, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(20, 31);
            this.textBox5.TabIndex = 15;
            // 
            // groupBoxInvalid
            // 
            this.groupBoxInvalid.Controls.Add(this.txtBoxInvalid5);
            this.groupBoxInvalid.Controls.Add(this.txtBoxInvalid4);
            this.groupBoxInvalid.Controls.Add(this.txtBoxInvalid3);
            this.groupBoxInvalid.Controls.Add(this.txtBoxInvalid2);
            this.groupBoxInvalid.Controls.Add(this.txtBoxInvalid1);
            this.groupBoxInvalid.Location = new System.Drawing.Point(64, 401);
            this.groupBoxInvalid.Name = "groupBoxInvalid";
            this.groupBoxInvalid.Size = new System.Drawing.Size(139, 63);
            this.groupBoxInvalid.TabIndex = 21;
            this.groupBoxInvalid.TabStop = false;
            // 
            // txtBoxInvalid5
            // 
            this.txtBoxInvalid5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInvalid5.Location = new System.Drawing.Point(110, 19);
            this.txtBoxInvalid5.Name = "txtBoxInvalid5";
            this.txtBoxInvalid5.Size = new System.Drawing.Size(20, 31);
            this.txtBoxInvalid5.TabIndex = 19;
            // 
            // txtBoxInvalid4
            // 
            this.txtBoxInvalid4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInvalid4.Location = new System.Drawing.Point(84, 19);
            this.txtBoxInvalid4.Name = "txtBoxInvalid4";
            this.txtBoxInvalid4.Size = new System.Drawing.Size(20, 31);
            this.txtBoxInvalid4.TabIndex = 18;
            // 
            // txtBoxInvalid3
            // 
            this.txtBoxInvalid3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInvalid3.Location = new System.Drawing.Point(58, 19);
            this.txtBoxInvalid3.Name = "txtBoxInvalid3";
            this.txtBoxInvalid3.Size = new System.Drawing.Size(20, 31);
            this.txtBoxInvalid3.TabIndex = 17;
            // 
            // txtBoxInvalid2
            // 
            this.txtBoxInvalid2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInvalid2.Location = new System.Drawing.Point(32, 19);
            this.txtBoxInvalid2.Name = "txtBoxInvalid2";
            this.txtBoxInvalid2.Size = new System.Drawing.Size(20, 31);
            this.txtBoxInvalid2.TabIndex = 16;
            // 
            // txtBoxInvalid1
            // 
            this.txtBoxInvalid1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInvalid1.Location = new System.Drawing.Point(6, 19);
            this.txtBoxInvalid1.Name = "txtBoxInvalid1";
            this.txtBoxInvalid1.Size = new System.Drawing.Size(20, 31);
            this.txtBoxInvalid1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 34);
            this.label3.TabIndex = 22;
            this.label3.Text = "Invalid letters";
            // 
            // btnValidClear
            // 
            this.btnValidClear.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidClear.Location = new System.Drawing.Point(220, 303);
            this.btnValidClear.Name = "btnValidClear";
            this.btnValidClear.Size = new System.Drawing.Size(81, 34);
            this.btnValidClear.TabIndex = 23;
            this.btnValidClear.Text = "Clear";
            this.btnValidClear.UseVisualStyleBackColor = true;
            // 
            // btnInvalidClear
            // 
            this.btnInvalidClear.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvalidClear.Location = new System.Drawing.Point(220, 401);
            this.btnInvalidClear.Name = "btnInvalidClear";
            this.btnInvalidClear.Size = new System.Drawing.Size(81, 34);
            this.btnInvalidClear.TabIndex = 24;
            this.btnInvalidClear.Text = "Clear";
            this.btnInvalidClear.UseVisualStyleBackColor = true;
            this.btnInvalidClear.Click += new System.EventHandler(this.btnInvalidClear_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRow.Location = new System.Drawing.Point(220, 441);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(81, 33);
            this.btnAddRow.TabIndex = 25;
            this.btnAddRow.Text = "Add row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // WordleSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(681, 581);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.btnInvalidClear);
            this.Controls.Add(this.btnValidClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxInvalid);
            this.Controls.Add(this.groupBoxValid);
            this.Controls.Add(this.groupBoxCorrect);
            this.Controls.Add(this.btnCorrectClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExclude);
            this.Controls.Add(this.lblInclude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPossibleWords);
            this.Controls.Add(this.listBoxWords);
            this.Controls.Add(this.lblWordle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WordleSolver";
            this.Text = "Wordle Solver";
            this.Load += new System.EventHandler(this.FormLoad);
            this.groupBoxCorrect.ResumeLayout(false);
            this.groupBoxCorrect.PerformLayout();
            this.groupBoxValid.ResumeLayout(false);
            this.groupBoxValid.PerformLayout();
            this.groupBoxInvalid.ResumeLayout(false);
            this.groupBoxInvalid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxCorrect1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExclude;
        private System.Windows.Forms.Label lblInclude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPossibleWords;
        private System.Windows.Forms.ListBox listBoxWords;
        private System.Windows.Forms.Label lblWordle;
        private System.Windows.Forms.Button btnCorrectClear;
        private System.Windows.Forms.GroupBox groupBoxCorrect;
        private System.Windows.Forms.TextBox txtBoxCorrect5;
        private System.Windows.Forms.TextBox txtBoxCorrect4;
        private System.Windows.Forms.TextBox txtBoxCorrect3;
        private System.Windows.Forms.TextBox txtBoxCorrect2;
        private System.Windows.Forms.GroupBox groupBoxValid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBoxInvalid;
        private System.Windows.Forms.TextBox txtBoxInvalid5;
        private System.Windows.Forms.TextBox txtBoxInvalid4;
        private System.Windows.Forms.TextBox txtBoxInvalid3;
        private System.Windows.Forms.TextBox txtBoxInvalid2;
        private System.Windows.Forms.TextBox txtBoxInvalid1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValidClear;
        private System.Windows.Forms.Button btnInvalidClear;
        private System.Windows.Forms.Button btnAddRow;
    }
}

