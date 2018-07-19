using System.Linq;

namespace password_generator
{
    public partial class frmPassGen : System.Windows.Forms.Form
    {
        public frmPassGen()
        {
            InitializeComponent();
            clickButton(btnNum);
        }

        void clickButton(System.Windows.Forms.Button btn)
        {
            pGenerator.Select();
            System.Windows.Forms.Button[] btns = { btnNum, btnLower, btnUpper, btnSymbol };
            for (int i = 0; i < btns.Length; i++)
                if (btns[i] == btn && btn.BackColor != System.Drawing.Color.Teal)
                    btn.BackColor = System.Drawing.Color.Teal;
                else if (btns[i] != btn)
                    btns[i].BackColor = System.Drawing.Color.LightSeaGreen;
        }

        private void frmPassGenerator_Load(object sender, System.EventArgs e)
        {
            if (!Properties.Settings.Default.Symbols)
                cbSymbols.Checked = false;

            if (!Properties.Settings.Default.Numbers)
                cbNumbers.Checked = false;

            if (!Properties.Settings.Default.Lower)
                cbLower.Checked = false;

            if (!Properties.Settings.Default.Upper)
                cbUpper.Checked = false;

            if (Properties.Settings.Default.Similar)
                cbSimilar.Checked = true;

            if (Properties.Settings.Default.Ambiguous)
                cbAmbiguous.Checked = true;

            if (Properties.Settings.Default.Equals)
                cbEqualChar.Checked = true;

            if (Properties.Settings.Default.Multiple)
                cbMultPass.Checked = true;

            if (!Properties.Settings.Default.LevelPass)
                cbLevelPass.Checked = false;
        }

        private void frmPassGen_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            pGenerator.Select();
        }

        private void pGenerator_Click(object sender, System.EventArgs e)
        {
            pGenerator.Select();
        }

        private void btnNum_Click(object sender, System.EventArgs e)
        {
            clickButton(btnNum);
        }

        private void btnLower_Click(object sender, System.EventArgs e)
        {
            clickButton(btnLower);
        }

        private void btnUpper_Click(object sender, System.EventArgs e)
        {
            clickButton(btnUpper);
        }

        private void btnSymbol_Click(object sender, System.EventArgs e)
        {
            clickButton(btnSymbol);
        }

        private void btnGenerate_Click(object sender, System.EventArgs e)
        {
            pGenerator.Select();
            txtPassword.Clear();

            System.Random rnd = new System.Random();
            string chars = string.Empty, passGenerated = string.Empty, symbols = "!@#$%&*-+=?_^", numbers = "0123456789",
                lowers = "abcdefghijklmnopqrstuvxwyz", uppers = "ABCDEFGHIJKLMNOPQRSTUVXWYZ", symbols2 = "{}[]()/\\'\"`~,;:.<>";
            int amountChar = (int)upAmountPass.Value, amountPass = (upMultPass.Enabled ? (int)upMultPass.Value : 1);

            if (cbSymbols.Checked) chars += symbols;
            if (cbNumbers.Checked) chars += numbers;
            if (cbLower.Checked) chars += lowers;
            if (cbUpper.Checked) chars += uppers;
            if (!cbAmbiguous.Checked && cbSymbols.Checked) chars += symbols2;

            if (chars.Length < 6)
            {
                picLevelPass.BackColor = System.Drawing.Color.Transparent;
                tip.SetToolTip(picLevelPass, null);
            }

            for (int k = 0; k < (chars.Length >= 6 ? amountPass : 0); k++)
            {
                passGenerated = string.Empty;

                if (btnNum.BackColor == System.Drawing.Color.Teal)
                    passGenerated += numbers[rnd.Next(0, numbers.Length)];
                else if (btnLower.BackColor == System.Drawing.Color.Teal)
                    passGenerated += lowers[rnd.Next(0, lowers.Length)];
                else if (btnUpper.BackColor == System.Drawing.Color.Teal)
                    passGenerated += uppers[rnd.Next(0, uppers.Length)];
                else if (btnSymbol.BackColor == System.Drawing.Color.Teal)
                    passGenerated += (symbols + (!cbAmbiguous.Checked ? symbols2 : string.Empty))[rnd.Next(0, symbols.Length + (!cbAmbiguous.Checked ? symbols2.Length : 0))];

                for (int i = 1; i < amountChar; i++)
                {
                    char ch = chars[rnd.Next(0, chars.Length)];

                    if (cbEqualChar.Checked)
                        while (passGenerated[i - 1] == ch)
                            ch = chars[rnd.Next(0, chars.Length)];
                    else if (cbSimilar.Checked)
                    {   // i l 1 o 0 O
                        char[] chL = { 'i', 'l', '1', 'o', '0', 'O' };
                        for (int j = 0; j < chL.Length; j++)
                            if (passGenerated[i - 1] == chL[j])
                                while (ch == 'i' || ch == 'l' || ch == '1' || ch == 'o' || ch == '0' || ch == 'O' && ch != chL[j])
                                    ch = chars[rnd.Next(0, chars.Length)];
                    }
                    passGenerated += ch;
                }
                if (cbLevelPass.Enabled && cbLevelPass.Checked)
                {
                    int totalPontos = 0;

                    totalPontos += System.Math.Min(6, passGenerated.Length) * 10;
                    totalPontos += System.Math.Min(2, passGenerated.Length - System.Text.RegularExpressions.Regex.Replace(passGenerated, "[A-Z]", "").Length) * 5;
                    totalPontos += System.Math.Min(2, passGenerated.Length - System.Text.RegularExpressions.Regex.Replace(passGenerated, "[a-z]", "").Length) * 5;
                    totalPontos += System.Math.Min(2, passGenerated.Length - System.Text.RegularExpressions.Regex.Replace(passGenerated, "[0-9]", "").Length) * 5;
                    totalPontos += System.Math.Min(2, System.Text.RegularExpressions.Regex.Replace(passGenerated, "[a-zA-Z0-9]", "").Length) * 5;

                    for (int i = 1; i < passGenerated.Length; i++)
                        if (passGenerated[i] == passGenerated[i - 1])
                        {
                            totalPontos -= 30; break;
                        }

                    if (totalPontos < 50)
                    {
                        picLevelPass.BackColor = System.Drawing.Color.Red;
                        tip.SetToolTip(picLevelPass, "Senha inaceitável");
                    }
                    else if (totalPontos < 60)
                    {
                        picLevelPass.BackColor = System.Drawing.Color.DarkOrange;
                        tip.SetToolTip(picLevelPass, "Senha péssima");
                    }
                    else if (totalPontos < 80)
                    {
                        picLevelPass.BackColor = System.Drawing.Color.Yellow;
                        tip.SetToolTip(picLevelPass, "Senha ruim");
                    }
                    else if (totalPontos < 100)
                    {
                        picLevelPass.BackColor = System.Drawing.Color.Lime;
                        tip.SetToolTip(picLevelPass, "Senha boa");
                    }
                    else
                    {
                        picLevelPass.BackColor = System.Drawing.Color.DarkGreen;
                        tip.SetToolTip(picLevelPass, "Senha excelente");
                    }
                }
                txtPassword.Text += passGenerated + (k == amountPass - 1 ? string.Empty : System.Environment.NewLine);
            }
        }

        private void cbMultPass_CheckedChanged(object sender, System.EventArgs e)
        {
            if (cbMultPass.Checked)
            {
                txtPassword.Clear();
                upMultPass.Enabled = true;
                picLevelPass.Visible = false;
                tip.SetToolTip(picLevelPass, null);
                cbLevelPass.Enabled = false;
                btnGenerate.Location = new System.Drawing.Point(306, 281);
                btnSave.Location = new System.Drawing.Point(197, 281);
                picLevelPass.Location = new System.Drawing.Point(57, 281);
                btnCopy.Location = new System.Drawing.Point(88, 281);
                txtPassword.Multiline = true;
                txtPassword.Size = new System.Drawing.Size(393, 263);
                txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            }
            else
            {
                txtPassword.Clear();
                upMultPass.Enabled = false;
                picLevelPass.Visible = true;
                cbLevelPass.Enabled = true;
                picLevelPass.BackColor = System.Drawing.Color.Transparent;
                btnGenerate.Location = new System.Drawing.Point(306, 47);
                btnSave.Location = new System.Drawing.Point(297, 79);
                picLevelPass.Location = new System.Drawing.Point(275, 47);
                btnCopy.Location = new System.Drawing.Point(297, 111);
                txtPassword.Multiline = false;
                txtPassword.Size = new System.Drawing.Size(393, 29);
                txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (txtPassword.Text.Trim().Length >= 6)
            {
                int i = 1;
                while (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Senha gerada" + i + ".txt"))
                    i++;

                System.IO.StreamWriter sw = new System.IO.StreamWriter(System.Windows.Forms.Application.StartupPath + "\\Senha gerada" + i + ".txt");
                sw.Write(txtPassword.Text);
                sw.Close();
                System.Windows.Forms.MessageBox.Show("Senha(s) salva(s) com sucesso! " + System.Windows.Forms.Application.StartupPath + "\\Senha gerada" + i + ".txt", "Sucesso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            else System.Windows.Forms.MessageBox.Show("Primeiro gere uma senha para salvar!", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            pGenerator.Select();
        }

        private void btnCopy_Click(object sender, System.EventArgs e)
        {
            pGenerator.Select();
            if (txtPassword.Text.Trim() != string.Empty)
                System.Windows.Forms.Clipboard.SetText(txtPassword.Text.Trim());
            else System.Windows.Forms.Clipboard.Clear();
        }

        private void picGitHub_Click(object sender, System.EventArgs e)
        {
            pGenerator.Select();
            System.Diagnostics.Process.Start("http://github.com/LucasNaja/password-generator");
        }

        private void frmPassGen_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (cbSymbols.Checked)
                Properties.Settings.Default.Symbols = true;
            else Properties.Settings.Default.Symbols = false;

            if (cbNumbers.Checked)
                Properties.Settings.Default.Numbers = true;
            else Properties.Settings.Default.Numbers = false;

            if (cbLower.Checked)
                Properties.Settings.Default.Lower = true;
            else Properties.Settings.Default.Lower = false;

            if (cbUpper.Checked)
                Properties.Settings.Default.Upper = true;
            else Properties.Settings.Default.Upper = false;

            if (cbSimilar.Checked)
                Properties.Settings.Default.Similar = true;
            else Properties.Settings.Default.Similar = false;

            if (cbAmbiguous.Checked)
                Properties.Settings.Default.Ambiguous = true;
            else Properties.Settings.Default.Ambiguous = false;

            if (cbEqualChar.Checked)
                Properties.Settings.Default.Equals = true;
            else Properties.Settings.Default.Equals = false;

            if (cbMultPass.Checked)
                Properties.Settings.Default.Multiple = true;
            else Properties.Settings.Default.Multiple = false;

            if (cbLevelPass.Enabled = true && cbLevelPass.Checked)
                Properties.Settings.Default.LevelPass = true;
            else Properties.Settings.Default.LevelPass = false;

            Properties.Settings.Default.Save();
        }

        private void picGitHub_MouseEnter(object sender, System.EventArgs e)
        {
            picGitHub.Location = new System.Drawing.Point(picGitHub.Location.X - 1, picGitHub.Location.Y - 1);
            picGitHub.Size = new System.Drawing.Size(picGitHub.Size.Width + 2, picGitHub.Size.Height + 2);
        }

        private void picGitHub_MouseLeave(object sender, System.EventArgs e)
        {
            picGitHub.Location = new System.Drawing.Point(picGitHub.Location.X + 1, picGitHub.Location.Y + 1);
            picGitHub.Size = new System.Drawing.Size(picGitHub.Size.Width - 2, picGitHub.Size.Height - 2);
        }

        private void picInfo_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Programa desenvolvido por Lucas Naja", "Créditos", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        private void picInfo_MouseEnter(object sender, System.EventArgs e)
        {
            picInfo.Location = new System.Drawing.Point(picInfo.Location.X - 1, picInfo.Location.Y - 1);
            picInfo.Size = new System.Drawing.Size(picInfo.Size.Width + 2, picInfo.Size.Height + 2);
        }

        private void picInfo_MouseLeave(object sender, System.EventArgs e)
        {
            picInfo.Location = new System.Drawing.Point(picInfo.Location.X + 1, picInfo.Location.Y + 1);
            picInfo.Size = new System.Drawing.Size(picInfo.Size.Width - 2, picInfo.Size.Height - 2);
        }
    }
}
