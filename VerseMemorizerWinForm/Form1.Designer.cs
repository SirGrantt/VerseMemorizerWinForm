namespace VerseMemorizerWinForm
{
    partial class Form1
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
            this.tbChpt = new System.Windows.Forms.TextBox();
            this.tbBook = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbTranslation = new System.Windows.Forms.TextBox();
            this.labelBook = new System.Windows.Forms.Label();
            this.labelChpt = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelTranslation = new System.Windows.Forms.Label();
            this.tbVerse = new System.Windows.Forms.RichTextBox();
            this.tbVNumber = new System.Windows.Forms.TextBox();
            this.labelVNumber = new System.Windows.Forms.Label();
            this.labelVerse = new System.Windows.Forms.Label();
            this.btnAddVerse = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbChpt
            // 
            this.tbChpt.Location = new System.Drawing.Point(107, 70);
            this.tbChpt.Name = "tbChpt";
            this.tbChpt.Size = new System.Drawing.Size(88, 20);
            this.tbChpt.TabIndex = 0;
            this.tbChpt.TextChanged += new System.EventHandler(this.tbChpt_TextChanged);
            // 
            // tbBook
            // 
            this.tbBook.Location = new System.Drawing.Point(12, 70);
            this.tbBook.Name = "tbBook";
            this.tbBook.Size = new System.Drawing.Size(89, 20);
            this.tbBook.TabIndex = 1;
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(278, 70);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(100, 20);
            this.tbCategory.TabIndex = 2;
            // 
            // tbTranslation
            // 
            this.tbTranslation.Location = new System.Drawing.Point(384, 70);
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.Size = new System.Drawing.Size(100, 20);
            this.tbTranslation.TabIndex = 3;
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Location = new System.Drawing.Point(12, 54);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(32, 13);
            this.labelBook.TabIndex = 4;
            this.labelBook.Text = "Book";
            // 
            // labelChpt
            // 
            this.labelChpt.AutoSize = true;
            this.labelChpt.Location = new System.Drawing.Point(104, 54);
            this.labelChpt.Name = "labelChpt";
            this.labelChpt.Size = new System.Drawing.Size(44, 13);
            this.labelChpt.TabIndex = 5;
            this.labelChpt.Text = "Chapter";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(278, 54);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(49, 13);
            this.labelCategory.TabIndex = 6;
            this.labelCategory.Text = "Category";
            // 
            // labelTranslation
            // 
            this.labelTranslation.AutoSize = true;
            this.labelTranslation.Location = new System.Drawing.Point(384, 54);
            this.labelTranslation.Name = "labelTranslation";
            this.labelTranslation.Size = new System.Drawing.Size(59, 13);
            this.labelTranslation.TabIndex = 7;
            this.labelTranslation.Text = "Translation";
            // 
            // tbVerse
            // 
            this.tbVerse.Location = new System.Drawing.Point(41, 109);
            this.tbVerse.Name = "tbVerse";
            this.tbVerse.Size = new System.Drawing.Size(418, 153);
            this.tbVerse.TabIndex = 9;
            this.tbVerse.Text = "";
            // 
            // tbVNumber
            // 
            this.tbVNumber.Location = new System.Drawing.Point(201, 70);
            this.tbVNumber.Name = "tbVNumber";
            this.tbVNumber.Size = new System.Drawing.Size(71, 20);
            this.tbVNumber.TabIndex = 10;
            // 
            // labelVNumber
            // 
            this.labelVNumber.AutoSize = true;
            this.labelVNumber.Location = new System.Drawing.Point(198, 54);
            this.labelVNumber.Name = "labelVNumber";
            this.labelVNumber.Size = new System.Drawing.Size(74, 13);
            this.labelVNumber.TabIndex = 11;
            this.labelVNumber.Text = "Verse Number";
            // 
            // labelVerse
            // 
            this.labelVerse.AutoSize = true;
            this.labelVerse.Location = new System.Drawing.Point(38, 93);
            this.labelVerse.Name = "labelVerse";
            this.labelVerse.Size = new System.Drawing.Size(34, 13);
            this.labelVerse.TabIndex = 12;
            this.labelVerse.Text = "Verse";
            // 
            // btnAddVerse
            // 
            this.btnAddVerse.Location = new System.Drawing.Point(252, 302);
            this.btnAddVerse.Name = "btnAddVerse";
            this.btnAddVerse.Size = new System.Drawing.Size(75, 23);
            this.btnAddVerse.TabIndex = 13;
            this.btnAddVerse.Text = "Add Verse";
            this.btnAddVerse.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(333, 302);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update Verse";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(427, 302);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 23);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove Verse";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 367);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddVerse);
            this.Controls.Add(this.labelVerse);
            this.Controls.Add(this.labelVNumber);
            this.Controls.Add(this.tbVNumber);
            this.Controls.Add(this.tbVerse);
            this.Controls.Add(this.labelTranslation);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelChpt);
            this.Controls.Add(this.labelBook);
            this.Controls.Add(this.tbTranslation);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.tbBook);
            this.Controls.Add(this.tbChpt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbChpt;
        private System.Windows.Forms.TextBox tbBook;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbTranslation;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.Label labelChpt;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelTranslation;
        private System.Windows.Forms.RichTextBox tbVerse;
        private System.Windows.Forms.TextBox tbVNumber;
        private System.Windows.Forms.Label labelVNumber;
        private System.Windows.Forms.Label labelVerse;
        private System.Windows.Forms.Button btnAddVerse;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}

