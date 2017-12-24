namespace MakeRandomString
{
    partial class TestApp
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestApp));
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnMakeLowerCaseLetters = new System.Windows.Forms.Button();
            this.btnMakeUpperCaseLetters = new System.Windows.Forms.Button();
            this.btnMakeLowerCaseAndSymbols = new System.Windows.Forms.Button();
            this.btnMakeLowerAndUpper = new System.Windows.Forms.Button();
            this.btnMakeLowerCaseLettersAndNumbers = new System.Windows.Forms.Button();
            this.btnMakeNumbers = new System.Windows.Forms.Button();
            this.btnMakeUpperCaseLettersAndNumber = new System.Windows.Forms.Button();
            this.btnMakeSymbols = new System.Windows.Forms.Button();
            this.btnMakeUpperCaseAndSymbols = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMixAll = new System.Windows.Forms.Button();
            this.btnMakeMixLCUCAndSymbols = new System.Windows.Forms.Button();
            this.btnMakeNumbersAndSymbols = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMakeByPattern = new System.Windows.Forms.Button();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.ttPatternInstruction = new System.Windows.Forms.ToolTip(this.components);
            this.bntAbout = new System.Windows.Forms.Button();
            this.btnMakeMixLCUCNumbers = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(135, 13);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(312, 20);
            this.txtResult.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "String Length:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(91, 13);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(38, 20);
            this.txtLength.TabIndex = 2;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(453, 12);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(75, 23);
            this.btnCopyToClipboard.TabIndex = 3;
            this.btnCopyToClipboard.Text = "Copy";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnMakeLowerCaseLetters
            // 
            this.btnMakeLowerCaseLetters.Location = new System.Drawing.Point(6, 19);
            this.btnMakeLowerCaseLetters.Name = "btnMakeLowerCaseLetters";
            this.btnMakeLowerCaseLetters.Size = new System.Drawing.Size(114, 23);
            this.btnMakeLowerCaseLetters.TabIndex = 4;
            this.btnMakeLowerCaseLetters.Text = "Lower Case Letters";
            this.btnMakeLowerCaseLetters.UseVisualStyleBackColor = true;
            this.btnMakeLowerCaseLetters.Click += new System.EventHandler(this.btnMakeLowerCaseLetters_Click);
            // 
            // btnMakeUpperCaseLetters
            // 
            this.btnMakeUpperCaseLetters.Location = new System.Drawing.Point(6, 48);
            this.btnMakeUpperCaseLetters.Name = "btnMakeUpperCaseLetters";
            this.btnMakeUpperCaseLetters.Size = new System.Drawing.Size(114, 23);
            this.btnMakeUpperCaseLetters.TabIndex = 5;
            this.btnMakeUpperCaseLetters.Text = "Upper Case Letters";
            this.btnMakeUpperCaseLetters.UseVisualStyleBackColor = true;
            this.btnMakeUpperCaseLetters.Click += new System.EventHandler(this.btnMakeUpperCaseLetters_Click);
            // 
            // btnMakeLowerCaseAndSymbols
            // 
            this.btnMakeLowerCaseAndSymbols.Location = new System.Drawing.Point(6, 48);
            this.btnMakeLowerCaseAndSymbols.Name = "btnMakeLowerCaseAndSymbols";
            this.btnMakeLowerCaseAndSymbols.Size = new System.Drawing.Size(135, 23);
            this.btnMakeLowerCaseAndSymbols.TabIndex = 6;
            this.btnMakeLowerCaseAndSymbols.Text = "LC Letters and Symbols";
            this.btnMakeLowerCaseAndSymbols.UseVisualStyleBackColor = true;
            this.btnMakeLowerCaseAndSymbols.Click += new System.EventHandler(this.btnMakeLowerCaseAndSymbols_Click);
            // 
            // btnMakeLowerAndUpper
            // 
            this.btnMakeLowerAndUpper.Location = new System.Drawing.Point(6, 19);
            this.btnMakeLowerAndUpper.Name = "btnMakeLowerAndUpper";
            this.btnMakeLowerAndUpper.Size = new System.Drawing.Size(135, 23);
            this.btnMakeLowerAndUpper.TabIndex = 7;
            this.btnMakeLowerAndUpper.Text = "Lower and Upper Case Letters";
            this.btnMakeLowerAndUpper.UseVisualStyleBackColor = true;
            this.btnMakeLowerAndUpper.Click += new System.EventHandler(this.btnMakeLowerAndUpper_Click);
            // 
            // btnMakeLowerCaseLettersAndNumbers
            // 
            this.btnMakeLowerCaseLettersAndNumbers.Location = new System.Drawing.Point(147, 48);
            this.btnMakeLowerCaseLettersAndNumbers.Name = "btnMakeLowerCaseLettersAndNumbers";
            this.btnMakeLowerCaseLettersAndNumbers.Size = new System.Drawing.Size(135, 23);
            this.btnMakeLowerCaseLettersAndNumbers.TabIndex = 8;
            this.btnMakeLowerCaseLettersAndNumbers.Text = "LC Letters and Numbers";
            this.btnMakeLowerCaseLettersAndNumbers.UseVisualStyleBackColor = true;
            this.btnMakeLowerCaseLettersAndNumbers.Click += new System.EventHandler(this.btnMakeLowerCaseLettersAndNumbers_Click);
            // 
            // btnMakeNumbers
            // 
            this.btnMakeNumbers.Location = new System.Drawing.Point(126, 48);
            this.btnMakeNumbers.Name = "btnMakeNumbers";
            this.btnMakeNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnMakeNumbers.TabIndex = 9;
            this.btnMakeNumbers.Text = "Numbers";
            this.btnMakeNumbers.UseVisualStyleBackColor = true;
            this.btnMakeNumbers.Click += new System.EventHandler(this.btnMakeNumbers_Click);
            // 
            // btnMakeUpperCaseLettersAndNumber
            // 
            this.btnMakeUpperCaseLettersAndNumber.Location = new System.Drawing.Point(147, 77);
            this.btnMakeUpperCaseLettersAndNumber.Name = "btnMakeUpperCaseLettersAndNumber";
            this.btnMakeUpperCaseLettersAndNumber.Size = new System.Drawing.Size(135, 23);
            this.btnMakeUpperCaseLettersAndNumber.TabIndex = 10;
            this.btnMakeUpperCaseLettersAndNumber.Text = "UC Letters and Numbers";
            this.btnMakeUpperCaseLettersAndNumber.UseVisualStyleBackColor = true;
            this.btnMakeUpperCaseLettersAndNumber.Click += new System.EventHandler(this.btnMakeUpperCaseLettersAndNumber_Click);
            // 
            // btnMakeSymbols
            // 
            this.btnMakeSymbols.Location = new System.Drawing.Point(126, 19);
            this.btnMakeSymbols.Name = "btnMakeSymbols";
            this.btnMakeSymbols.Size = new System.Drawing.Size(75, 23);
            this.btnMakeSymbols.TabIndex = 11;
            this.btnMakeSymbols.Text = "Symbols";
            this.btnMakeSymbols.UseVisualStyleBackColor = true;
            this.btnMakeSymbols.Click += new System.EventHandler(this.btnMakeSymbols_Click);
            // 
            // btnMakeUpperCaseAndSymbols
            // 
            this.btnMakeUpperCaseAndSymbols.Location = new System.Drawing.Point(6, 77);
            this.btnMakeUpperCaseAndSymbols.Name = "btnMakeUpperCaseAndSymbols";
            this.btnMakeUpperCaseAndSymbols.Size = new System.Drawing.Size(135, 23);
            this.btnMakeUpperCaseAndSymbols.TabIndex = 12;
            this.btnMakeUpperCaseAndSymbols.Text = "UC Letters and Symbols";
            this.btnMakeUpperCaseAndSymbols.UseVisualStyleBackColor = true;
            this.btnMakeUpperCaseAndSymbols.Click += new System.EventHandler(this.btnMakeUpperCaseAndSymbols_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMakeSymbols);
            this.groupBox1.Controls.Add(this.btnMakeUpperCaseLetters);
            this.groupBox1.Controls.Add(this.btnMakeLowerCaseLetters);
            this.groupBox1.Controls.Add(this.btnMakeNumbers);
            this.groupBox1.Location = new System.Drawing.Point(15, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 80);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make solo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMakeMixLCUCNumbers);
            this.groupBox2.Controls.Add(this.btnMixAll);
            this.groupBox2.Controls.Add(this.btnMakeMixLCUCAndSymbols);
            this.groupBox2.Controls.Add(this.btnMakeNumbersAndSymbols);
            this.groupBox2.Controls.Add(this.btnMakeLowerAndUpper);
            this.groupBox2.Controls.Add(this.btnMakeLowerCaseAndSymbols);
            this.groupBox2.Controls.Add(this.btnMakeUpperCaseLettersAndNumber);
            this.groupBox2.Controls.Add(this.btnMakeUpperCaseAndSymbols);
            this.groupBox2.Controls.Add(this.btnMakeLowerCaseLettersAndNumbers);
            this.groupBox2.Location = new System.Drawing.Point(231, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 172);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Make mixed:";
            // 
            // btnMixAll
            // 
            this.btnMixAll.Location = new System.Drawing.Point(6, 135);
            this.btnMixAll.Name = "btnMixAll";
            this.btnMixAll.Size = new System.Drawing.Size(276, 23);
            this.btnMixAll.TabIndex = 15;
            this.btnMixAll.Text = "All";
            this.btnMixAll.UseVisualStyleBackColor = true;
            this.btnMixAll.Click += new System.EventHandler(this.btnMixAll_Click);
            // 
            // btnMakeMixLCUCAndSymbols
            // 
            this.btnMakeMixLCUCAndSymbols.Location = new System.Drawing.Point(6, 106);
            this.btnMakeMixLCUCAndSymbols.Name = "btnMakeMixLCUCAndSymbols";
            this.btnMakeMixLCUCAndSymbols.Size = new System.Drawing.Size(135, 23);
            this.btnMakeMixLCUCAndSymbols.TabIndex = 14;
            this.btnMakeMixLCUCAndSymbols.Text = "LC, UC Lett.and Symbols";
            this.btnMakeMixLCUCAndSymbols.UseVisualStyleBackColor = true;
            this.btnMakeMixLCUCAndSymbols.Click += new System.EventHandler(this.btnMakeMixLCUCAndSymbols_Click);
            // 
            // btnMakeNumbersAndSymbols
            // 
            this.btnMakeNumbersAndSymbols.Location = new System.Drawing.Point(147, 19);
            this.btnMakeNumbersAndSymbols.Name = "btnMakeNumbersAndSymbols";
            this.btnMakeNumbersAndSymbols.Size = new System.Drawing.Size(135, 23);
            this.btnMakeNumbersAndSymbols.TabIndex = 13;
            this.btnMakeNumbersAndSymbols.Text = "Numbers and Symbols";
            this.btnMakeNumbersAndSymbols.UseVisualStyleBackColor = true;
            this.btnMakeNumbersAndSymbols.Click += new System.EventHandler(this.btnMakeNumbersAndSymbols_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Method: ";
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(68, 229);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.ReadOnly = true;
            this.txtMethod.Size = new System.Drawing.Size(399, 20);
            this.txtMethod.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMakeByPattern);
            this.groupBox3.Controls.Add(this.txtPattern);
            this.groupBox3.Location = new System.Drawing.Point(15, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 52);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Make by a pattern:";
            // 
            // btnMakeByPattern
            // 
            this.btnMakeByPattern.Location = new System.Drawing.Point(166, 20);
            this.btnMakeByPattern.Name = "btnMakeByPattern";
            this.btnMakeByPattern.Size = new System.Drawing.Size(35, 23);
            this.btnMakeByPattern.TabIndex = 20;
            this.btnMakeByPattern.Text = "Go";
            this.btnMakeByPattern.UseVisualStyleBackColor = true;
            this.btnMakeByPattern.Click += new System.EventHandler(this.btnMakeByPattern_Click);
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(6, 22);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(154, 20);
            this.txtPattern.TabIndex = 19;
            this.txtPattern.MouseHover += new System.EventHandler(this.txtPattern_MouseHover);
            // 
            // bntAbout
            // 
            this.bntAbout.Location = new System.Drawing.Point(473, 227);
            this.bntAbout.Name = "bntAbout";
            this.bntAbout.Size = new System.Drawing.Size(56, 23);
            this.bntAbout.TabIndex = 19;
            this.bntAbout.Text = "About";
            this.bntAbout.UseVisualStyleBackColor = true;
            this.bntAbout.Click += new System.EventHandler(this.bntAbout_Click);
            // 
            // btnMakeMixLCUCNumbers
            // 
            this.btnMakeMixLCUCNumbers.Location = new System.Drawing.Point(147, 106);
            this.btnMakeMixLCUCNumbers.Name = "btnMakeMixLCUCNumbers";
            this.btnMakeMixLCUCNumbers.Size = new System.Drawing.Size(135, 23);
            this.btnMakeMixLCUCNumbers.TabIndex = 16;
            this.btnMakeMixLCUCNumbers.Text = "LC, UP Lett. and Nums";
            this.btnMakeMixLCUCNumbers.UseVisualStyleBackColor = true;
            this.btnMakeMixLCUCNumbers.Click += new System.EventHandler(this.btnMakeMixLCUCNumbers_Click);
            // 
            // TestApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 261);
            this.Controls.Add(this.bntAbout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make ASCII Random String Test App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnMakeLowerCaseLetters;
        private System.Windows.Forms.Button btnMakeUpperCaseLetters;
        private System.Windows.Forms.Button btnMakeLowerCaseAndSymbols;
        private System.Windows.Forms.Button btnMakeLowerAndUpper;
        private System.Windows.Forms.Button btnMakeLowerCaseLettersAndNumbers;
        private System.Windows.Forms.Button btnMakeNumbers;
        private System.Windows.Forms.Button btnMakeUpperCaseLettersAndNumber;
        private System.Windows.Forms.Button btnMakeSymbols;
        private System.Windows.Forms.Button btnMakeUpperCaseAndSymbols;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMixAll;
        private System.Windows.Forms.Button btnMakeMixLCUCAndSymbols;
        private System.Windows.Forms.Button btnMakeNumbersAndSymbols;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMakeByPattern;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.ToolTip ttPatternInstruction;
        private System.Windows.Forms.Button bntAbout;
        private System.Windows.Forms.Button btnMakeMixLCUCNumbers;
    }
}

