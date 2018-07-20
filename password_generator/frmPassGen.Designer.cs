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
            this.cbSimilar = new System.Windows.Forms.CheckBox();
            this.cbAmbiguous = new System.Windows.Forms.CheckBox();
            this.lblAmountPass = new System.Windows.Forms.Label();
            this.upAmountPass = new System.Windows.Forms.NumericUpDown();
            this.btnNum = new System.Windows.Forms.Button();
            this.btnUpper = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnSymbol = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.picLevelPass = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbLevelPass = new System.Windows.Forms.CheckBox();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.btnSymbols = new System.Windows.Forms.Button();
            this.btnLowers = new System.Windows.Forms.Button();
            this.btnUppers = new System.Windows.Forms.Button();
            this.btnNumbers = new System.Windows.Forms.Button();
            this.cbEqualChar = new System.Windows.Forms.CheckBox();
            this.lblFirstChar = new System.Windows.Forms.Label();
            this.lblOthers = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblOpenSource = new System.Windows.Forms.Label();
            this.lblFree = new System.Windows.Forms.Label();
            this.lblAprimored = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upAmountPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLevelPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSimilar
            // 
            this.cbSimilar.AutoSize = true;
            this.cbSimilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSimilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSimilar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSimilar.Location = new System.Drawing.Point(9, 144);
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
            this.cbAmbiguous.Location = new System.Drawing.Point(9, 170);
            this.cbAmbiguous.Name = "cbAmbiguous";
            this.cbAmbiguous.Size = new System.Drawing.Size(348, 20);
            this.cbAmbiguous.TabIndex = 4;
            this.cbAmbiguous.Text = "Excluir caract. ambíguos ({ } [ ] ( ) / \\ \' \" ` ~ , ; : . < >)";
            this.cbAmbiguous.UseVisualStyleBackColor = true;
            // 
            // lblAmountPass
            // 
            this.lblAmountPass.AutoSize = true;
            this.lblAmountPass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPass.Location = new System.Drawing.Point(250, 316);
            this.lblAmountPass.Name = "lblAmountPass";
            this.lblAmountPass.Size = new System.Drawing.Size(133, 16);
            this.lblAmountPass.TabIndex = 6;
            this.lblAmountPass.Text = "Tamanho da senha:";
            this.lblAmountPass.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // upAmountPass
            // 
            this.upAmountPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upAmountPass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upAmountPass.Location = new System.Drawing.Point(388, 314);
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
            this.btnNum.BackColor = System.Drawing.Color.Teal;
            this.btnNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum.Location = new System.Drawing.Point(14, 238);
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
            this.btnUpper.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpper.Location = new System.Drawing.Point(165, 238);
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
            this.btnLower.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLower.Location = new System.Drawing.Point(88, 238);
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
            this.btnSymbol.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSymbol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSymbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSymbol.Location = new System.Drawing.Point(243, 238);
            this.btnSymbol.Name = "btnSymbol";
            this.btnSymbol.Size = new System.Drawing.Size(75, 26);
            this.btnSymbol.TabIndex = 11;
            this.btnSymbol.Text = "Símbolo";
            this.tip.SetToolTip(this.btnSymbol, "Caractere inicial: Símbolo");
            this.btnSymbol.UseVisualStyleBackColor = false;
            this.btnSymbol.Click += new System.EventHandler(this.btnSymbol_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(552, 311);
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
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(443, 311);
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
            this.picLevelPass.BackColor = System.Drawing.SystemColors.Control;
            this.picLevelPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLevelPass.Location = new System.Drawing.Point(183, 312);
            this.picLevelPass.Name = "picLevelPass";
            this.picLevelPass.Size = new System.Drawing.Size(24, 24);
            this.picLevelPass.TabIndex = 11;
            this.picLevelPass.TabStop = false;
            this.picLevelPass.Click += new System.EventHandler(this.picLevelPass_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(14, 273);
            this.txtPassword.MaxLength = 3000;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(750, 29);
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
            this.btnGenerate.Location = new System.Drawing.Point(661, 311);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(103, 26);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Gerar senha";
            this.tip.SetToolTip(this.btnGenerate, "Gerar senha aleatória");
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
            this.cbLevelPass.Location = new System.Drawing.Point(14, 314);
            this.cbLevelPass.Name = "cbLevelPass";
            this.cbLevelPass.Size = new System.Drawing.Size(168, 20);
            this.cbLevelPass.TabIndex = 15;
            this.cbLevelPass.Text = "Mostrar nível de senha";
            this.cbLevelPass.UseVisualStyleBackColor = true;
            this.cbLevelPass.CheckedChanged += new System.EventHandler(this.cbLevelPass_CheckedChanged);
            // 
            // btnSymbols
            // 
            this.btnSymbols.BackColor = System.Drawing.Color.Teal;
            this.btnSymbols.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSymbols.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSymbols.Location = new System.Drawing.Point(689, 238);
            this.btnSymbols.Name = "btnSymbols";
            this.btnSymbols.Size = new System.Drawing.Size(75, 26);
            this.btnSymbols.TabIndex = 21;
            this.btnSymbols.Text = "Símbolos";
            this.tip.SetToolTip(this.btnSymbols, "Outros caracteres: Símbolos");
            this.btnSymbols.UseVisualStyleBackColor = false;
            this.btnSymbols.Click += new System.EventHandler(this.btnSymbols_Click);
            // 
            // btnLowers
            // 
            this.btnLowers.BackColor = System.Drawing.Color.Teal;
            this.btnLowers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowers.Location = new System.Drawing.Point(532, 238);
            this.btnLowers.Name = "btnLowers";
            this.btnLowers.Size = new System.Drawing.Size(80, 26);
            this.btnLowers.TabIndex = 20;
            this.btnLowers.Text = "Minúsculos";
            this.tip.SetToolTip(this.btnLowers, "Outros caracteres: Minúsculos");
            this.btnLowers.UseVisualStyleBackColor = false;
            this.btnLowers.Click += new System.EventHandler(this.btnLowers_Click);
            // 
            // btnUppers
            // 
            this.btnUppers.BackColor = System.Drawing.Color.Teal;
            this.btnUppers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUppers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUppers.Location = new System.Drawing.Point(610, 238);
            this.btnUppers.Name = "btnUppers";
            this.btnUppers.Size = new System.Drawing.Size(80, 26);
            this.btnUppers.TabIndex = 19;
            this.btnUppers.Text = "Maiúsculos";
            this.tip.SetToolTip(this.btnUppers, "Outros caracteres: Maiúsculos");
            this.btnUppers.UseVisualStyleBackColor = false;
            this.btnUppers.Click += new System.EventHandler(this.btnUppers_Click);
            // 
            // btnNumbers
            // 
            this.btnNumbers.BackColor = System.Drawing.Color.Teal;
            this.btnNumbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumbers.Location = new System.Drawing.Point(458, 238);
            this.btnNumbers.Name = "btnNumbers";
            this.btnNumbers.Size = new System.Drawing.Size(75, 26);
            this.btnNumbers.TabIndex = 18;
            this.btnNumbers.Text = "Números";
            this.tip.SetToolTip(this.btnNumbers, "Outros caracteres: Números");
            this.btnNumbers.UseVisualStyleBackColor = false;
            this.btnNumbers.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // cbEqualChar
            // 
            this.cbEqualChar.AutoSize = true;
            this.cbEqualChar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEqualChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEqualChar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEqualChar.Location = new System.Drawing.Point(9, 196);
            this.cbEqualChar.Name = "cbEqualChar";
            this.cbEqualChar.Size = new System.Drawing.Size(294, 20);
            this.cbEqualChar.TabIndex = 16;
            this.cbEqualChar.Text = "Excluir caracteres iguais (aa, ZZ, oo, PP, ii)";
            this.cbEqualChar.UseVisualStyleBackColor = true;
            // 
            // lblFirstChar
            // 
            this.lblFirstChar.AutoSize = true;
            this.lblFirstChar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstChar.Location = new System.Drawing.Point(104, 219);
            this.lblFirstChar.Name = "lblFirstChar";
            this.lblFirstChar.Size = new System.Drawing.Size(127, 16);
            this.lblFirstChar.TabIndex = 17;
            this.lblFirstChar.Text = "Primeiro caractere";
            // 
            // lblOthers
            // 
            this.lblOthers.AutoSize = true;
            this.lblOthers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOthers.Location = new System.Drawing.Point(552, 219);
            this.lblOthers.Name = "lblOthers";
            this.lblOthers.Size = new System.Drawing.Size(119, 16);
            this.lblOthers.TabIndex = 22;
            this.lblOthers.Text = "Outros caracteres";
            this.lblOthers.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(225, -4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(338, 126);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 23;
            this.picLogo.TabStop = false;
            this.tip.SetToolTip(this.picLogo, "Gerador de Senhas");
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(67, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsOptions
            // 
            this.tsOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInfo,
            this.tsmiGitHub});
            this.tsOptions.Name = "tsOptions";
            this.tsOptions.Size = new System.Drawing.Size(59, 20);
            this.tsOptions.Text = "Opções";
            // 
            // tsmiInfo
            // 
            this.tsmiInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsmiInfo.Image")));
            this.tsmiInfo.Name = "tsmiInfo";
            this.tsmiInfo.Size = new System.Drawing.Size(180, 22);
            this.tsmiInfo.Text = "Créditos";
            this.tsmiInfo.Click += new System.EventHandler(this.tsmiInfo_Click);
            // 
            // tsmiGitHub
            // 
            this.tsmiGitHub.Image = ((System.Drawing.Image)(resources.GetObject("tsmiGitHub.Image")));
            this.tsmiGitHub.Name = "tsmiGitHub";
            this.tsmiGitHub.Size = new System.Drawing.Size(180, 22);
            this.tsmiGitHub.Text = "GitHub";
            this.tsmiGitHub.Click += new System.EventHandler(this.tsmiGitHub_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(271, 121);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(251, 16);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.Text = "Gerador de Senhas aleatórias gratuito";
            this.lblDescription.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // lblOpenSource
            // 
            this.lblOpenSource.AutoSize = true;
            this.lblOpenSource.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenSource.Location = new System.Drawing.Point(11, 33);
            this.lblOpenSource.Name = "lblOpenSource";
            this.lblOpenSource.Size = new System.Drawing.Size(107, 16);
            this.lblOpenSource.TabIndex = 26;
            this.lblOpenSource.Text = "• Código aberto";
            this.lblOpenSource.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // lblFree
            // 
            this.lblFree.AutoSize = true;
            this.lblFree.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFree.Location = new System.Drawing.Point(11, 49);
            this.lblFree.Name = "lblFree";
            this.lblFree.Size = new System.Drawing.Size(68, 16);
            this.lblFree.TabIndex = 27;
            this.lblFree.Text = "• Gratuito";
            this.lblFree.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // lblAprimored
            // 
            this.lblAprimored.AutoSize = true;
            this.lblAprimored.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAprimored.Location = new System.Drawing.Point(11, 65);
            this.lblAprimored.Name = "lblAprimored";
            this.lblAprimored.Size = new System.Drawing.Size(140, 16);
            this.lblAprimored.TabIndex = 28;
            this.lblAprimored.Text = "• Código aprimorado";
            this.lblAprimored.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // frmPassGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 347);
            this.Controls.Add(this.lblAprimored);
            this.Controls.Add(this.lblFree);
            this.Controls.Add(this.lblOpenSource);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnSymbols);
            this.Controls.Add(this.btnUppers);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnLowers);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblOthers);
            this.Controls.Add(this.picLevelPass);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblFirstChar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbEqualChar);
            this.Controls.Add(this.cbLevelPass);
            this.Controls.Add(this.btnSymbol);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.upAmountPass);
            this.Controls.Add(this.lblAmountPass);
            this.Controls.Add(this.cbAmbiguous);
            this.Controls.Add(this.cbSimilar);
            this.Controls.Add(this.btnNumbers);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPassGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Senhas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPassGen_FormClosing);
            this.Load += new System.EventHandler(this.frmPassGenerator_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmPassGen_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.upAmountPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLevelPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbSimilar;
        private System.Windows.Forms.CheckBox cbAmbiguous;
        private System.Windows.Forms.Label lblAmountPass;
        private System.Windows.Forms.NumericUpDown upAmountPass;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button btnUpper;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnSymbol;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox cbLevelPass;
        private System.Windows.Forms.PictureBox picLevelPass;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.CheckBox cbEqualChar;
        private System.Windows.Forms.Label lblFirstChar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblOthers;
        private System.Windows.Forms.Button btnSymbols;
        private System.Windows.Forms.Button btnLowers;
        private System.Windows.Forms.Button btnUppers;
        private System.Windows.Forms.Button btnNumbers;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiGitHub;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblOpenSource;
        private System.Windows.Forms.Label lblFree;
        private System.Windows.Forms.Label lblAprimored;
    }
}

