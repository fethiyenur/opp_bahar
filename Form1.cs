using System.Text;

namespace exp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCeaserCipher_TextChanged(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Ýlk baþta Caesar Cipher seçeneðini gizle
            groupBox2.Visible = false;
        }
        private void CaesarCipherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ROT3RadioButton.Checked)
            {
               
                groupBox2.Visible = false;
            }
            else if (CaesarCipherRadioButton.Checked)
            {
                
                groupBox2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = PasswordTextBox.Text;
            string encryptedMessage = "";
            bool success = false;

            if (ROT3RadioButton.Checked)
            {
                Encipher(password, out encryptedMessage, out success);
            }
            else if (CaesarCipherRadioButton.Checked)
            {
                int shift = 0;
                if (!int.TryParse(CaesarCipherCodeTextBox.Text, out shift))
                {
                    MessageBox.Show("Please enter a valid Caesar Cipher code (an integer).");
                    return;
                }

                Encipher(password, shift, out encryptedMessage, out success);
            }

            if (success)
            {
                SuccessLabel.Text = "Success";
                SuccessLabel.BackColor = System.Drawing.Color.Green;
                SuccessLabel.Visible = true;
                label3.Text = encryptedMessage;
            }
            else
            {
                SuccessLabel.Visible = false;
                label3.Text = "";
            }
        }
        private void Encipher(string input, out string encryptedMessage, out bool success)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char encryptedChar = (char)(c + 3);
                    if (char.IsUpper(c) && encryptedChar > 'Z')
                        encryptedChar = (char)(encryptedChar - 26);
                    else if (char.IsLower(c) && encryptedChar > 'z')
                        encryptedChar = (char)(encryptedChar - 26);

                    result.Append(encryptedChar);
                }
                else
                {
                    result.Append(c);
                }
            }

            encryptedMessage = result.ToString();
            success = true;
        }
        private void Encipher(string input, int shift, out string encryptedMessage, out bool success)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char encryptedChar = (char)(c + shift);
                    if (char.IsUpper(c) && encryptedChar > 'Z')
                        encryptedChar = (char)(encryptedChar - 26);
                    else if (char.IsLower(c) && encryptedChar > 'z')
                        encryptedChar = (char)(encryptedChar - 26);

                    result.Append(encryptedChar);
                }
                else
                {
                    result.Append(c);
                }
            }

            encryptedMessage = result.ToString();
            success = true;
        }

        private void EncryptedMessageTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
