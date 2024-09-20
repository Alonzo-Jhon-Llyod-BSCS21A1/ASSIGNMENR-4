namespace WinFormsApp1
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            nameBox = new TextBox();
            idBox = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 61);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 0;
            label1.Text = "NAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 127);
            label2.Name = "label2";
            label2.Size = new Size(41, 30);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(150, 68);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(238, 23);
            nameBox.TabIndex = 2;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // idBox
            // 
            idBox.Location = new Point(150, 131);
            idBox.Name = "idBox";
            idBox.Size = new Size(238, 23);
            idBox.TabIndex = 3;
            idBox.TextChanged += idBox_TextChanged;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(287, 221);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(101, 34);
            saveButton.TabIndex = 4;
            saveButton.Text = "SAVE";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(429, 221);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(101, 34);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 316);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(idBox);
            Controls.Add(nameBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameBox;
        private TextBox idBox;
        private Button saveButton;
        private Button cancelButton;
    }
}