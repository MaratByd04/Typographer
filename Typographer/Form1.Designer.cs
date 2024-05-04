namespace Typographer
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
            TextBox = new TextBox();
            EditButton = new Button();
            SuspendLayout();
            // 
            // TextBox
            // 
            TextBox.Location = new Point(12, 86);
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(1185, 352);
            TextBox.TabIndex = 2;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(0, 0);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(157, 43);
            EditButton.TabIndex = 0;
            EditButton.Text = "Редактировать текст ";
            EditButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 450);
            Controls.Add(EditButton);
            Controls.Add(TextBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Typography App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox TextBox;
        public Button EditButton;
    }
}
