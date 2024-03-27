namespace exp3
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
            label2 = new Label();
            CaesarCipherCodeTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuccessLabel = new Label();
            ROT3RadioButton = new RadioButton();
            CaesarCipherRadioButton = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 1;
            label2.Text = "Ceaser Cipher: ";
            // 
            // CaesarCipherCodeTextBox
            // 
            CaesarCipherCodeTextBox.Location = new Point(12, 70);
            CaesarCipherCodeTextBox.Name = "CaesarCipherCodeTextBox";
            CaesarCipherCodeTextBox.Size = new Size(161, 27);
            CaesarCipherCodeTextBox.TabIndex = 2;
            CaesarCipherCodeTextBox.TextChanged += txtCeaserCipher_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(24, 89);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(161, 27);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.TextChanged += txtPassword_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(67, 267);
            button1.Name = "button1";
            button1.Size = new Size(193, 29);
            button1.TabIndex = 6;
            button1.Text = "ENCRYPT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(24, 39);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 0;
            label1.Text = "Password: ";
            // 
            // SuccessLabel
            // 
            SuccessLabel.AutoSize = true;
            SuccessLabel.BackColor = Color.LightGreen;
            SuccessLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            SuccessLabel.Location = new Point(284, 270);
            SuccessLabel.Name = "SuccessLabel";
            SuccessLabel.Size = new Size(230, 23);
            SuccessLabel.TabIndex = 7;
            SuccessLabel.Text = "               SUCCESS               ";
            SuccessLabel.Visible = false;
            // 
            // ROT3RadioButton
            // 
            ROT3RadioButton.AutoSize = true;
            ROT3RadioButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ROT3RadioButton.Location = new Point(310, 88);
            ROT3RadioButton.Name = "ROT3RadioButton";
            ROT3RadioButton.Size = new Size(72, 27);
            ROT3RadioButton.TabIndex = 8;
            ROT3RadioButton.TabStop = true;
            ROT3RadioButton.Text = "ROT3";
            ROT3RadioButton.UseVisualStyleBackColor = true;
            // 
            // CaesarCipherRadioButton
            // 
            CaesarCipherRadioButton.AutoSize = true;
            CaesarCipherRadioButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            CaesarCipherRadioButton.Location = new Point(310, 155);
            CaesarCipherRadioButton.Name = "CaesarCipherRadioButton";
            CaesarCipherRadioButton.Size = new Size(137, 27);
            CaesarCipherRadioButton.TabIndex = 9;
            CaesarCipherRadioButton.TabStop = true;
            CaesarCipherRadioButton.Text = "Ceaser Cipher";
            CaesarCipherRadioButton.UseVisualStyleBackColor = true;
            CaesarCipherRadioButton.CheckedChanged += CaesarCipherRadioButton_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(CaesarCipherRadioButton);
            groupBox1.Controls.Add(ROT3RadioButton);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(SuccessLabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(PasswordTextBox);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(544, 342);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(CaesarCipherCodeTextBox);
            groupBox2.Location = new Point(18, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(214, 109);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(310, 302);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 11;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 447);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private TextBox CaesarCipherCodeTextBox;
        private TextBox PasswordTextBox;
        private Button button1;
        private Label label1;
        private Label SuccessLabel;
        private RadioButton ROT3RadioButton;
        private RadioButton CaesarCipherRadioButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
    }
}
