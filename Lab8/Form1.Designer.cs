namespace Lab8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            browseButton = new Button();
            submitButton = new Button();
            exitButton = new Button();
            searchBox = new TextBox();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // browseButton
            // 
            browseButton.Location = new Point(591, 68);
            browseButton.Margin = new Padding(4, 4, 4, 4);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(118, 36);
            browseButton.TabIndex = 0;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(302, 496);
            submitButton.Margin = new Padding(4, 4, 4, 4);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(118, 36);
            submitButton.TabIndex = 1;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(569, 496);
            exitButton.Margin = new Padding(4, 4, 4, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(118, 36);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(241, 70);
            searchBox.Margin = new Padding(4, 4, 4, 4);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(314, 31);
            searchBox.TabIndex = 3;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 25;
            listBox.Location = new Point(302, 140);
            listBox.Margin = new Padding(4, 4, 4, 4);
            listBox.Name = "listBox";
            listBox.Size = new Size(383, 304);
            listBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(listBox);
            Controls.Add(searchBox);
            Controls.Add(exitButton);
            Controls.Add(submitButton);
            Controls.Add(browseButton);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button browseButton;
        private Button submitButton;
        private Button exitButton;
        private TextBox searchBox;
        private ListBox listBox;
    }
}