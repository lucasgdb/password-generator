namespace password_generator
{
    partial class frmPassGen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPassGen));
            this.cbSymbols = new System.Windows.Forms.CheckBox();
            this.cbUpper = new System.Windows.Forms.CheckBox();
            this.cbLower = new System.Windows.Forms.CheckBox();
            this.cbSimilar = new System.Windows.Forms.CheckBox();
            this.cbAmbiguous = new System.Windows.Forms.CheckBox();
            this.cbNumbers = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.upAmountPass = new System.Windows.Forms.NumericUpDown();
            this.btnNum = new System.Windows.Forms.Button();
            this.btnUpper = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnSymbol = new System.Windows.Forms.Button();
            this.cbMultPass = new System.Windows.Forms.CheckBox();
            this.upMultPass = new System.Windows.Forms.NumericUpDown();
            this.pGenerator = new System.Windows.Forms.Panel();
            this.picGitHub = new System.Windows.Forms.PictureBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.picLevelPass = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbLevelPass = new System.Windows.Forms.CheckBox();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.cbEqualChar = new System.Windows.Forms.CheckBox();
            this.lblFirstChar = new System.Windows.Forms.Label();
            this.picInfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.upAmountPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upMultPass)).BeginInit();
            this.pGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLevelPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSymbols
            // 
            this.cbSymbols.AutoSize = true;
            this.cbSymbols.Checked = true;
            this.cbSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSymbols.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSymbols.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSymbols.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSymbols.Location = new System.Drawing.Point(12, 33);
            this.cbSymbols.Name = "cbSymbols";
            this.cbSymbols.Size = new System.Drawing.Size(124, 20);
            this.cbSymbols.TabIndex = 0;
            this.cbSymbols.Text = "Incluir símbolos";
            this.cbSymbols.UseVisualStyleBackColor = true;
            // 
            // cbUpper
            // 
            this.cbUpper.AutoSize = true;
            this.cbUpper.Checked = true;
            this.cbUpper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbUpper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUpper.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpper.Location = new System.Drawing.Point(12, 111);
            this.cbUpper.Name = "cbUpper";
            this.cbUpper.Size = new System.Drawing.Size(209, 20);
            this.cbUpper.TabIndex = 1;
            this.cbUpper.Text = "Incluir caracteres maiúsculos";
            this.cbUpper.UseVisualStyleBackColor = true;
            // 
            // cbLower
            // 
            this.cbLower.AutoSize = true;
            this.cbLower.Checked = true;
            this.cbLower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLower.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLower.Location = new System.Drawing.Point(12, 85);
            this.cbLower.Name = "cbLower";
            this.cbLower.Size = new System.Drawing.Size(209, 20);
            this.cbLower.TabIndex = 2;
            this.cbLower.Text = "Incluir caracteres minúsculos";
            this.cbLower.UseVisualStyleBackColor = true;
            // 
            // cbSimilar
            // 
            this.cbSimilar.AutoSize = true;
            this.cbSimilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSimilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSimilar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSimilar.Location = new System.Drawing.Point(12, 137);
            this.cbSimilar.Name = "cbSimilar";
            this.cbSimilar.Size = new System.Drawing.Size(307, 20);
            this.cbSimilar.TabIndex = 3;
            this.cbSimilar.Text = "Excluir caracteres similares (i, l, 1, L, o, 0, O)";
            this.cbSimilar.UseVisualStyleBackColor = true;
            // 
            // cbAmbiguous
            // 
            this.cbAmbiguous.AutoSize = true;
            this.cbAmbiguous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAmbiguous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAmbiguous.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAmbiguous.Location = new System.Drawing.Point(12, 163);
            this.cbAmbiguous.Name = "cbAmbiguous";
            this.cbAmbiguous.Size = new System.Drawing.Size(348, 20);
            this.cbAmbiguous.TabIndex = 4;
            this.cbAmbiguous.Text = "Excluir caract. ambíguos ({ } [ ] ( ) / \\ \' \" ` ~ , ; : . < >)";
            this.cbAmbiguous.UseVisualStyleBackColor = true;
            // 
            // cbNumbers
            // 
            this.cbNumbers.AutoSize = true;
            this.cbNumbers.Checked = true;
            this.cbNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNumbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNumbers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumbers.Location = new System.Drawing.Point(12, 59);
            this.cbNumbers.Name = "cbNumbers";
            this.cbNumbers.Size = new System.Drawing.Size(123, 20);
            this.cbNumbers.TabIndex = 5;
            this.cbNumbers.Text = "Incluir números";
            this.cbNumbers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tamanho da senha:";
            this.label1.Click += new System.EventHandler(this.pGenerator_Click);
            // 
            // upAmountPass
            // 
            this.upAmountPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upAmountPass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upAmountPass.Location = new System.Drawing.Point(146, 7);
            this.upAmountPass.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.upAmountPass.Name = "upAmountPass";
            this.upAmountPass.Size = new System.Drawing.Size(49, 22);
            this.upAmountPass.TabIndex = 7;
            this.upAmountPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upAmountPass.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // btnNum
            // 
            this.btnNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNum.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum.Location = new System.Drawing.Point(34, 284);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(75, 26);
            this.btnNum.TabIndex = 8;
            this.btnNum.Text = "Número";
            this.tip.SetToolTip(this.btnNum, "Caractere inicial: Número");
            this.btnNum.UseVisualStyleBackColor = false;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnUpper
            // 
            this.btnUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpper.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpper.Location = new System.Drawing.Point(187, 284);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(79, 26);
            this.btnUpper.TabIndex = 9;
            this.btnUpper.Text = "Maiúsculo";
            this.tip.SetToolTip(this.btnUpper, "Caractere inicial: Maiúsculo");
            this.btnUpper.UseVisualStyleBackColor = false;
            this.btnUpper.Click += new System.EventHandler(this.btnUpper_Click);
            // 
            // btnLower
            // 
            this.btnLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLower.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLower.Location = new System.Drawing.Point(109, 284);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(78, 26);
            this.btnLower.TabIndex = 10;
            this.btnLower.Text = "Minúsculo";
            this.tip.SetToolTip(this.btnLower, "Caractere inicial: Minúsculo");
            this.btnLower.UseVisualStyleBackColor = false;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnSymbol
            // 
            this.btnSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSymbol.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSymbol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSymbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSymbol.Location = new System.Drawing.Point(266, 284);
            this.btnSymbol.Name = "btnSymbol";
            this.btnSymbol.Size = new System.Drawing.Size(75, 26);
            this.btnSymbol.TabIndex = 11;
            this.btnSymbol.Text = "Símbolo";
            this.tip.SetToolTip(this.btnSymbol, "Caractere inicial: Símbolo");
            this.btnSymbol.UseVisualStyleBackColor = false;
            this.btnSymbol.Click += new System.EventHandler(this.btnSymbol_Click);
            // 
            // cbMultPass
            // 
            this.cbMultPass.AutoSize = true;
            this.cbMultPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMultPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMultPass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMultPass.Location = new System.Drawing.Point(12, 215);
            this.cbMultPass.Name = "cbMultPass";
            this.cbMultPass.Size = new System.Drawing.Size(129, 20);
            this.cbMultPass.TabIndex = 12;
            this.cbMultPass.Text = "Múltiplas senhas";
            this.cbMultPass.UseVisualStyleBackColor = true;
            this.cbMultPass.CheckedChanged += new System.EventHandler(this.cbMultPass_CheckedChanged);
            // 
            // upMultPass
            // 
            this.upMultPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upMultPass.Enabled = false;
            this.upMultPass.Location = new System.Drawing.Point(144, 215);
            this.upMultPass.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.upMultPass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upMultPass.Name = "upMultPass";
            this.upMultPass.Size = new System.Drawing.Size(42, 20);
            this.upMultPass.TabIndex = 13;
            this.upMultPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upMultPass.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // pGenerator
            // 
            this.pGenerator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pGenerator.BackColor = System.Drawing.Color.PowderBlue;
            this.pGenerator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGenerator.Controls.Add(this.picInfo);
            this.pGenerator.Controls.Add(this.picGitHub);
            this.pGenerator.Controls.Add(this.btnCopy);
            this.pGenerator.Controls.Add(this.btnSave);
            this.pGenerator.Controls.Add(this.picLevelPass);
            this.pGenerator.Controls.Add(this.txtPassword);
            this.pGenerator.Controls.Add(this.btnGenerate);
            this.pGenerator.Location = new System.Drawing.Point(373, -1);
            this.pGenerator.Name = "pGenerator";
            this.pGenerator.Size = new System.Drawing.Size(409, 321);
            this.pGenerator.TabIndex = 14;
            this.pGenerator.Click += new System.EventHandler(this.pGenerator_Click);
            // 
            // picGitHub
            // 
            this.picGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGitHub.Image = ((System.Drawing.Image)(resources.GetObject("picGitHub.Image")));
            this.picGitHub.Location = new System.Drawing.Point(5, 282);
            this.picGitHub.Name = "picGitHub";
            this.picGitHub.Size = new System.Drawing.Size(31, 31);
            this.picGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGitHub.TabIndex = 14;
            this.picGitHub.TabStop = false;
            this.tip.SetToolTip(this.picGitHub, "GitHub");
            this.picGitHub.Click += new System.EventHandler(this.picGitHub_Click);
            this.picGitHub.MouseEnter += new System.EventHandler(this.picGitHub_MouseEnter);
            this.picGitHub.MouseLeave += new System.EventHandler(this.picGitHub_MouseLeave);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(297, 111);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(103, 26);
            this.btnCopy.TabIndex = 13;
            this.btnCopy.Text = "Copiar senha";
            this.tip.SetToolTip(this.btnCopy, "Copiar campo de senha");
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(297, 79);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 26);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Salvar senha";
            this.tip.SetToolTip(this.btnSave, "Salvar campo de senha");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picLevelPass
            // 
            this.picLevelPass.BackColor = System.Drawing.Color.Transparent;
            this.picLevelPass.Location = new System.Drawing.Point(275, 47);
            this.picLevelPass.Name = "picLevelPass";
            this.picLevelPass.Size = new System.Drawing.Size(25, 26);
            this.picLevelPass.TabIndex = 11;
            this.picLevelPass.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(7, 12);
            this.txtPassword.MaxLength = 3000;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(393, 29);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(306, 47);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(94, 26);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Gerar senha";
            this.tip.SetToolTip(this.btnGenerate, "Gerar senha(s) aleatória(s)");
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cbLevelPass
            // 
            this.cbLevelPass.AutoSize = true;
            this.cbLevelPass.Checked = true;
            this.cbLevelPass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLevelPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLevelPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLevelPass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLevelPass.Location = new System.Drawing.Point(12, 241);
            this.cbLevelPass.Name = "cbLevelPass";
            this.cbLevelPass.Size = new System.Drawing.Size(168, 20);
            this.cbLevelPass.TabIndex = 15;
            this.cbLevelPass.Text = "Mostrar nível de senha";
            this.cbLevelPass.UseVisualStyleBackColor = true;
            // 
            // cbEqualChar
            // 
            this.cbEqualChar.AutoSize = true;
            this.cbEqualChar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEqualChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEqualChar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEqualChar.Location = new System.Drawing.Point(12, 189);
            this.cbEqualChar.Name = "cbEqualChar";
            this.cbEqualChar.Size = new System.Drawing.Size(294, 20);
            this.cbEqualChar.TabIndex = 16;
            this.cbEqualChar.Text = "Excluir caracteres iguais (aa, ZZ, oo, PP, ii)";
            this.cbEqualChar.UseVisualStyleBackColor = true;
            // 
            // lblFirstChar
            // 
            this.lblFirstChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFirstChar.AutoSize = true;
            this.lblFirstChar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstChar.Location = new System.Drawing.Point(124, 265);
            this.lblFirstChar.Name = "lblFirstChar";
            this.lblFirstChar.Size = new System.Drawing.Size(127, 16);
            this.lblFirstChar.TabIndex = 17;
            this.lblFirstChar.Text = "Primeiro caractere";
            this.lblFirstChar.Click += new System.EventHandler(this.pGenerator_Click);
            // 
            // picInfo
            // 
            this.picInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picInfo.Image = ((System.Drawing.Image)(resources.GetObject("picInfo.Image")));
            this.picInfo.Location = new System.Drawing.Point(44, 282);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(31, 31);
            this.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInfo.TabIndex = 15;
            this.picInfo.TabStop = false;
            this.tip.SetToolTip(this.picInfo, "Créditos");
            this.picInfo.Click += new System.EventHandler(this.picInfo_Click);
            this.picInfo.MouseEnter += new System.EventHandler(this.picInfo_MouseEnter);
            this.picInfo.MouseLeave += new System.EventHandler(this.picInfo_MouseLeave);
            // 
            // frmPassGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 319);
            this.Controls.Add(this.lblFirstChar);
            this.Controls.Add(this.cbEqualChar);
            this.Controls.Add(this.cbLevelPass);
            this.Controls.Add(this.pGenerator);
            this.Controls.Add(this.upMultPass);
            this.Controls.Add(this.btnSymbol);
            this.Controls.Add(this.cbUpper);
            this.Controls.Add(this.cbMultPass);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.upAmountPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNumbers);
            this.Controls.Add(this.cbAmbiguous);
            this.Controls.Add(this.cbSimilar);
            this.Controls.Add(this.cbLower);
            this.Controls.Add(this.cbSymbols);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPassGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Senha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPassGen_FormClosing);
            this.Load += new System.EventHandler(this.frmPassGenerator_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmPassGen_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.upAmountPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upMultPass)).EndInit();
            this.pGenerator.ResumeLayout(false);
            this.pGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLevelPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSymbols;
        private System.Windows.Forms.CheckBox cbUpper;
        private System.Windows.Forms.CheckBox cbLower;
        private System.Windows.Forms.CheckBox cbSimilar;
        private System.Windows.Forms.CheckBox cbAmbiguous;
        private System.Windows.Forms.CheckBox cbNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown upAmountPass;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button btnUpper;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnSymbol;
        private System.Windows.Forms.CheckBox cbMultPass;
        private System.Windows.Forms.NumericUpDown upMultPass;
        private System.Windows.Forms.Panel pGenerator;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox cbLevelPass;
        private System.Windows.Forms.PictureBox picLevelPass;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.CheckBox cbEqualChar;
        private System.Windows.Forms.Label lblFirstChar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.PictureBox picGitHub;
        private System.Windows.Forms.PictureBox picInfo;
    }
}

