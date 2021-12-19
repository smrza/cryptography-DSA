namespace DSA
{
    partial class MainForm
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
            this.labelPathOfFile = new System.Windows.Forms.Label();
            this.labelFileExtension = new System.Windows.Forms.Label();
            this.labelDateOfCreation = new System.Windows.Forms.Label();
            this.labelNameOfFile = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonEcnrypt = new System.Windows.Forms.Button();
            this.panelSign = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelFunctionality = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonVerificationFunctionality = new System.Windows.Forms.Button();
            this.buttonSignatureFunctionality = new System.Windows.Forms.Button();
            this.panelKeysGeneration = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAutoGenerateKeys = new System.Windows.Forms.Button();
            this.buttonImportKeys = new System.Windows.Forms.Button();
            this.panelKeysSize = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonGenerateKeyContinue = new System.Windows.Forms.Button();
            this.panelIntro = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelSign.SuspendLayout();
            this.panelFunctionality.SuspendLayout();
            this.panelKeysGeneration.SuspendLayout();
            this.panelKeysSize.SuspendLayout();
            this.panelIntro.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPathOfFile
            // 
            this.labelPathOfFile.AutoSize = true;
            this.labelPathOfFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPathOfFile.Location = new System.Drawing.Point(56, 125);
            this.labelPathOfFile.Name = "labelPathOfFile";
            this.labelPathOfFile.Size = new System.Drawing.Size(46, 17);
            this.labelPathOfFile.TabIndex = 0;
            this.labelPathOfFile.Text = "label1";
            this.labelPathOfFile.Visible = false;
            // 
            // labelFileExtension
            // 
            this.labelFileExtension.AutoSize = true;
            this.labelFileExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileExtension.Location = new System.Drawing.Point(56, 268);
            this.labelFileExtension.Name = "labelFileExtension";
            this.labelFileExtension.Size = new System.Drawing.Size(46, 17);
            this.labelFileExtension.TabIndex = 1;
            this.labelFileExtension.Text = "label2";
            this.labelFileExtension.Visible = false;
            // 
            // labelDateOfCreation
            // 
            this.labelDateOfCreation.AutoSize = true;
            this.labelDateOfCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfCreation.Location = new System.Drawing.Point(56, 168);
            this.labelDateOfCreation.Name = "labelDateOfCreation";
            this.labelDateOfCreation.Size = new System.Drawing.Size(46, 17);
            this.labelDateOfCreation.TabIndex = 2;
            this.labelDateOfCreation.Text = "label3";
            this.labelDateOfCreation.Visible = false;
            // 
            // labelNameOfFile
            // 
            this.labelNameOfFile.AutoSize = true;
            this.labelNameOfFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameOfFile.Location = new System.Drawing.Point(56, 217);
            this.labelNameOfFile.Name = "labelNameOfFile";
            this.labelNameOfFile.Size = new System.Drawing.Size(46, 17);
            this.labelNameOfFile.TabIndex = 3;
            this.labelNameOfFile.Text = "label4";
            this.labelNameOfFile.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(296, 171);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "512";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButtonsCheckChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(296, 212);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(63, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "1024";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButtonsCheckChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(296, 252);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(63, 24);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "2048";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.RadioButtonsCheckChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "bits";
            // 
            // buttonEcnrypt
            // 
            this.buttonEcnrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEcnrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEcnrypt.Location = new System.Drawing.Point(146, 366);
            this.buttonEcnrypt.Name = "buttonEcnrypt";
            this.buttonEcnrypt.Size = new System.Drawing.Size(270, 77);
            this.buttonEcnrypt.TabIndex = 23;
            this.buttonEcnrypt.Text = "SIGN ANY FILE";
            this.buttonEcnrypt.UseVisualStyleBackColor = true;
            this.buttonEcnrypt.Click += new System.EventHandler(this.ButtonSign_Click);
            // 
            // panelSign
            // 
            this.panelSign.Controls.Add(this.label12);
            this.panelSign.Controls.Add(this.label11);
            this.panelSign.Controls.Add(this.button1);
            this.panelSign.Controls.Add(this.buttonBack);
            this.panelSign.Controls.Add(this.buttonEcnrypt);
            this.panelSign.Controls.Add(this.labelNameOfFile);
            this.panelSign.Controls.Add(this.labelDateOfCreation);
            this.panelSign.Controls.Add(this.labelFileExtension);
            this.panelSign.Controls.Add(this.labelPathOfFile);
            this.panelSign.Location = new System.Drawing.Point(21, 17);
            this.panelSign.Name = "panelSign";
            this.panelSign.Size = new System.Drawing.Size(897, 622);
            this.panelSign.TabIndex = 25;
            this.panelSign.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(230, 203);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(255, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Properties will show after you sign a file";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(298, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "FILE PROPERTIES";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(513, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 77);
            this.button1.TabIndex = 24;
            this.button1.Text = "SIGN TEXT FILE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonSignTXT_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(358, 546);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(166, 55);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "CANCEL";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // panelFunctionality
            // 
            this.panelFunctionality.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFunctionality.Controls.Add(this.label7);
            this.panelFunctionality.Controls.Add(this.buttonVerificationFunctionality);
            this.panelFunctionality.Controls.Add(this.buttonSignatureFunctionality);
            this.panelFunctionality.Location = new System.Drawing.Point(96, 172);
            this.panelFunctionality.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFunctionality.Name = "panelFunctionality";
            this.panelFunctionality.Size = new System.Drawing.Size(750, 308);
            this.panelFunctionality.TabIndex = 27;
            this.panelFunctionality.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(400, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Please, select your desired functionality:";
            // 
            // buttonVerificationFunctionality
            // 
            this.buttonVerificationFunctionality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerificationFunctionality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerificationFunctionality.Location = new System.Drawing.Point(417, 168);
            this.buttonVerificationFunctionality.Name = "buttonVerificationFunctionality";
            this.buttonVerificationFunctionality.Size = new System.Drawing.Size(270, 77);
            this.buttonVerificationFunctionality.TabIndex = 26;
            this.buttonVerificationFunctionality.Text = "VERIFICATION";
            this.buttonVerificationFunctionality.UseVisualStyleBackColor = true;
            this.buttonVerificationFunctionality.Click += new System.EventHandler(this.ButtonVerificationFunctionality_Click);
            // 
            // buttonSignatureFunctionality
            // 
            this.buttonSignatureFunctionality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignatureFunctionality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignatureFunctionality.Location = new System.Drawing.Point(51, 168);
            this.buttonSignatureFunctionality.Name = "buttonSignatureFunctionality";
            this.buttonSignatureFunctionality.Size = new System.Drawing.Size(270, 77);
            this.buttonSignatureFunctionality.TabIndex = 26;
            this.buttonSignatureFunctionality.Text = "SIGNATURE";
            this.buttonSignatureFunctionality.UseVisualStyleBackColor = true;
            this.buttonSignatureFunctionality.Click += new System.EventHandler(this.ButtonSignatureFunctionality_Click);
            // 
            // panelKeysGeneration
            // 
            this.panelKeysGeneration.Controls.Add(this.label8);
            this.panelKeysGeneration.Controls.Add(this.buttonAutoGenerateKeys);
            this.panelKeysGeneration.Controls.Add(this.buttonImportKeys);
            this.panelKeysGeneration.Location = new System.Drawing.Point(96, 172);
            this.panelKeysGeneration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelKeysGeneration.Name = "panelKeysGeneration";
            this.panelKeysGeneration.Size = new System.Drawing.Size(750, 308);
            this.panelKeysGeneration.TabIndex = 27;
            this.panelKeysGeneration.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(336, 50);
            this.label8.TabIndex = 0;
            this.label8.Text = "Would you like to import \r\nyour keys or auto-generate them?";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAutoGenerateKeys
            // 
            this.buttonAutoGenerateKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutoGenerateKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAutoGenerateKeys.Location = new System.Drawing.Point(426, 180);
            this.buttonAutoGenerateKeys.Name = "buttonAutoGenerateKeys";
            this.buttonAutoGenerateKeys.Size = new System.Drawing.Size(270, 77);
            this.buttonAutoGenerateKeys.TabIndex = 26;
            this.buttonAutoGenerateKeys.Text = "AUTO-GENERATE";
            this.buttonAutoGenerateKeys.UseVisualStyleBackColor = true;
            this.buttonAutoGenerateKeys.Click += new System.EventHandler(this.ButtonAutoGenerateKeys_Click);
            // 
            // buttonImportKeys
            // 
            this.buttonImportKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImportKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportKeys.Location = new System.Drawing.Point(58, 180);
            this.buttonImportKeys.Name = "buttonImportKeys";
            this.buttonImportKeys.Size = new System.Drawing.Size(270, 77);
            this.buttonImportKeys.TabIndex = 26;
            this.buttonImportKeys.Text = "IMPORT";
            this.buttonImportKeys.UseVisualStyleBackColor = true;
            this.buttonImportKeys.Click += new System.EventHandler(this.ButtonImportKeys_Click);
            // 
            // panelKeysSize
            // 
            this.panelKeysSize.Controls.Add(this.label5);
            this.panelKeysSize.Controls.Add(this.label9);
            this.panelKeysSize.Controls.Add(this.label4);
            this.panelKeysSize.Controls.Add(this.buttonGenerateKeyContinue);
            this.panelKeysSize.Controls.Add(this.label3);
            this.panelKeysSize.Controls.Add(this.radioButton5);
            this.panelKeysSize.Controls.Add(this.radioButton3);
            this.panelKeysSize.Controls.Add(this.radioButton4);
            this.panelKeysSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelKeysSize.Location = new System.Drawing.Point(96, 103);
            this.panelKeysSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelKeysSize.Name = "panelKeysSize";
            this.panelKeysSize.Size = new System.Drawing.Size(750, 452);
            this.panelKeysSize.TabIndex = 27;
            this.panelKeysSize.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(92, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(348, 50);
            this.label9.TabIndex = 0;
            this.label9.Text = "Please, select key size \r\n(higher value means more secure):";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGenerateKeyContinue
            // 
            this.buttonGenerateKeyContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateKeyContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateKeyContinue.Location = new System.Drawing.Point(230, 346);
            this.buttonGenerateKeyContinue.Name = "buttonGenerateKeyContinue";
            this.buttonGenerateKeyContinue.Size = new System.Drawing.Size(270, 77);
            this.buttonGenerateKeyContinue.TabIndex = 26;
            this.buttonGenerateKeyContinue.Text = "CONTINUE";
            this.buttonGenerateKeyContinue.UseVisualStyleBackColor = true;
            this.buttonGenerateKeyContinue.Click += new System.EventHandler(this.ButtonGenerateKeyContinue_Click);
            // 
            // panelIntro
            // 
            this.panelIntro.Controls.Add(this.label6);
            this.panelIntro.Controls.Add(this.label2);
            this.panelIntro.Controls.Add(this.label1);
            this.panelIntro.Controls.Add(this.label10);
            this.panelIntro.Location = new System.Drawing.Point(18, 18);
            this.panelIntro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelIntro.Name = "panelIntro";
            this.panelIntro.Size = new System.Drawing.Size(900, 615);
            this.panelIntro.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(460, 72);
            this.label6.TabIndex = 3;
            this.label6.Text = "Application\r\n-> signs a file.\r\n-> verifies if the file is an original or has been" +
    " modified.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(537, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digital Signature Algorithm implemented with RSA and SHA256\r\nby Jan Smrža and Dom" +
    "inik Závada\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Semestral project";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(280, 492);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "(press any key to continue)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 655);
            this.Controls.Add(this.panelFunctionality);
            this.Controls.Add(this.panelKeysSize);
            this.Controls.Add(this.panelSign);
            this.Controls.Add(this.panelIntro);
            this.Controls.Add(this.panelKeysGeneration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.panelSign.ResumeLayout(false);
            this.panelSign.PerformLayout();
            this.panelFunctionality.ResumeLayout(false);
            this.panelFunctionality.PerformLayout();
            this.panelKeysGeneration.ResumeLayout(false);
            this.panelKeysGeneration.PerformLayout();
            this.panelKeysSize.ResumeLayout(false);
            this.panelKeysSize.PerformLayout();
            this.panelIntro.ResumeLayout(false);
            this.panelIntro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPathOfFile;
        private System.Windows.Forms.Label labelFileExtension;
        private System.Windows.Forms.Label labelDateOfCreation;
        private System.Windows.Forms.Label labelNameOfFile;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonEcnrypt;
        private System.Windows.Forms.Panel panelSign;
        private System.Windows.Forms.Panel panelFunctionality;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonVerificationFunctionality;
        private System.Windows.Forms.Button buttonSignatureFunctionality;
        private System.Windows.Forms.Panel panelKeysGeneration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAutoGenerateKeys;
        private System.Windows.Forms.Button buttonImportKeys;
        private System.Windows.Forms.Panel panelKeysSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonGenerateKeyContinue;
        private System.Windows.Forms.Panel panelIntro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonBack;
    }
}

