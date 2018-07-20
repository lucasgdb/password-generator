using System.Linq;

namespace password_generator
{
    public partial class frmPassGen : System.Windows.Forms.Form
    {
        public frmPassGen()
        {
            InitializeComponent();
        }

        void clickButton(System.Windows.Forms.Button btn)
        {
            picLogo.Select();
            System.Windows.Forms.Button[] btns = { btnNum, btnLower, btnUpper, btnSymbol };
            for (int i = 0; i < btns.Length; i++)
                if (btns[i] == btn && btn.BackColor != System.Drawing.Color.Teal)
                    btn.BackColor = System.Drawing.Color.Teal;
                else if (btns[i] != btn)
                    btns[i].BackColor = System.Drawing.Color.LightSeaGreen;
        }

        void clickButtons(System.Windows.Forms.Button btn)
        {
            picLogo.Select();
            if (btn.BackColor == System.Drawing.Color.LightSeaGreen) btn.BackColor = System.Drawing.Color.Teal;
            else btn.BackColor = System.Drawing.Color.LightSeaGreen;
        }

        void checkSecutiryPass(string str)
        {
            int totalPontos = 0;

            totalPontos += System.Math.Min(6, str.Length) * 10;
            totalPontos += System.Math.Min(2, str.Length - System.Text.RegularExpressions.Regex.Replace(str, "[A-Z]", "").Length) * 5;
            totalPontos += System.Math.Min(2, str.Length - System.Text.RegularExpressions.Regex.Replace(str, "[a-z]", "").Length) * 5;
            totalPontos += System.Math.Min(2, str.Length - System.Text.RegularExpressions.Regex.Replace(str, "[0-9]", "").Length) * 5;
            totalPontos += System.Math.Min(2, System.Text.RegularExpressions.Regex.Replace(str, "[a-zA-Z0-9]", "").Length) * 5;

            for (int i = 1; i < str.Length; i++)
                if (str[i] == str[i - 1])
                {
                    totalPontos -= 30; break;
                }

            if (totalPontos < 50)
            {
                picLevelPass.BackColor = System.Drawing.Color.Red;
                tip.SetToolTip(picLevelPass, "Senha INACEITÁVEL (" + totalPontos + " pontos)");
            }
            else if (totalPontos < 60)
            {
                picLevelPass.BackColor = System.Drawing.Color.DarkOrange;
                tip.SetToolTip(picLevelPass, "Senha PÉSSIMA (" + totalPontos + " pontos)");
            }
            else if (totalPontos < 80)
            {
                picLevelPass.BackColor = System.Drawing.Color.Yellow;
                tip.SetToolTip(picLevelPass, "Senha RUIM (" + totalPontos + " pontos)");
            }
            else if (totalPontos < 100)
            {
                picLevelPass.BackColor = System.Drawing.Color.Lime;
                tip.SetToolTip(picLevelPass, "Senha BOA (" + totalPontos + " pontos)");
            }
            else
            {
                picLevelPass.BackColor = System.Drawing.Color.DarkGreen;
                tip.SetToolTip(picLevelPass, "Senha EXCELENTE (" + totalPontos + " pontos)");
            }
        }

        private void frmPassGenerator_Load(object sender, System.EventArgs e)
        {
            if (!Properties.Settings.Default.Symbols)            
                clickButtons(btnSymbols);
        
            if (!Properties.Settings.Default.Numbers)
                clickButtons(btnNumbers);

            if (!Properties.Settings.Default.Lower)
                clickButtons(btnLowers);

            if (!Properties.Settings.Default.Upper)
                clickButtons(btnUppers);

            if (Properties.Settings.Default.Similar)
                cbSimilar.Checked = true;

            if (Properties.Settings.Default.Ambiguous)
                cbAmbiguous.Checked = true;

            if (Properties.Settings.Default.Equals)
                cbEqualChar.Checked = true;

            if (!Properties.Settings.Default.LevelPass)
                cbLevelPass.Checked = false;
        }

        private void frmPassGen_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            picLogo.Select();
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
            picLogo.Select();
            txtPassword.Clear();

            System.Random rnd = new System.Random();
            string chars = string.Empty, passGenerated = string.Empty, symbols = "!@#$%&*-+=?_^", numbers = "0123456789",
                lowers = "abcdefghijklmnopqrstuvxwyz", uppers = "ABCDEFGHIJKLMNOPQRSTUVXWYZ", symbols2 = "{}[]()/\\'\"`~,;:.<>";
            int amountChar = (int)upAmountPass.Value;

            if (btnSymbols.BackColor == System.Drawing.Color.Teal) chars += symbols;
            if (btnNumbers.BackColor == System.Drawing.Color.Teal) chars += numbers;
            if (btnLowers.BackColor == System.Drawing.Color.Teal) chars += lowers;
            if (btnUppers.BackColor == System.Drawing.Color.Teal) chars += uppers;
            if (btnSymbols.BackColor == System.Drawing.Color.Teal && !cbAmbiguous.Checked) chars += symbols2;

            if (chars.Length < 6)
            {
                picLevelPass.BackColor = System.Drawing.SystemColors.Control;
                tip.SetToolTip(picLevelPass, null);
            }
            else
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

                if (cbLevelPass.Checked) checkSecutiryPass(passGenerated);

                txtPassword.Text = passGenerated;
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
            picLogo.Select();
        }

        private void btnCopy_Click(object sender, System.EventArgs e)
        {
            picLogo.Select();
            if (txtPassword.Text.Trim() != string.Empty)
                System.Windows.Forms.Clipboard.SetText(txtPassword.Text.Trim());
            else System.Windows.Forms.Clipboard.Clear();
        }

        private void frmPassGen_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (btnSymbols.BackColor == System.Drawing.Color.Teal)
                Properties.Settings.Default.Symbols = true;
            else Properties.Settings.Default.Symbols = false;

            if (btnNumbers.BackColor == System.Drawing.Color.Teal)
                Properties.Settings.Default.Numbers = true;
            else Properties.Settings.Default.Numbers = false;

            if (btnLowers.BackColor == System.Drawing.Color.Teal)
                Properties.Settings.Default.Lower = true;
            else Properties.Settings.Default.Lower = false;

            if (btnUppers.BackColor == System.Drawing.Color.Teal)
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

            if (cbLevelPass.Checked)
                Properties.Settings.Default.LevelPass = true;
            else Properties.Settings.Default.LevelPass = false;

            Properties.Settings.Default.Save();
        }

        private void btnNumbers_Click(object sender, System.EventArgs e)
        {
            clickButtons(btnNumbers);
        }

        private void btnLowers_Click(object sender, System.EventArgs e)
        {
            clickButtons(btnLowers);
        }

        private void btnUppers_Click(object sender, System.EventArgs e)
        {
            clickButtons(btnUppers);
        }

        private void btnSymbols_Click(object sender, System.EventArgs e)
        {
            clickButtons(btnSymbols);
        }

        private void tsmiInfo_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Programa desenvolvido por Lucas Naja", "Créditos", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        private void tsmiGitHub_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.github.com/LucasNaja/password-generator");
        }

        private void cbLevelPass_CheckedChanged(object sender, System.EventArgs e)
        {
            if (cbLevelPass.Checked) { picLevelPass.Visible = true; picLevelPass.BackColor = System.Drawing.SystemColors.Control; }
            else picLevelPass.Visible = false;
        }

        private void picLogo_Click(object sender, System.EventArgs e)
        {
            picLogo.Select();
        }

        private void picLevelPass_Click(object sender, System.EventArgs e)
        {
            picLogo.Select();
            checkSecutiryPass(txtPassword.Text);
        }
    }
}
