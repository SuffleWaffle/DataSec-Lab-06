namespace DataSec_Lab_06_PRJ
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.keyFilePage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openKeyBtn = new System.Windows.Forms.Button();
            this.openKPathBox = new System.Windows.Forms.TextBox();
            this.keyHEXPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editHEXCheckBox = new System.Windows.Forms.CheckBox();
            this.keyHEXTextBox = new System.Windows.Forms.TextBox();
            this.passPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.viewPassCheckBox = new System.Windows.Forms.CheckBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.keyXORPage = new System.Windows.Forms.TabPage();
            this.saveFileStLabel = new System.Windows.Forms.Label();
            this.encodingStLabel = new System.Windows.Forms.Label();
            this.openFileStLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.xorImageList = new System.Windows.Forms.ImageList(this.components);
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.GenKeyButton = new System.Windows.Forms.Button();
            this.keyGenImageList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.totTimeLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.KeyExtRadioButton = new System.Windows.Forms.RadioButton();
            this.KeyRNGRadioButton = new System.Windows.Forms.RadioButton();
            this.keyLengthComboBox = new System.Windows.Forms.ComboBox();
            this.keyLengthLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.authorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.keyFilePage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.keyHEXPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.passPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.keyXORPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.keyFilePage);
            this.tabControl1.Controls.Add(this.keyHEXPage);
            this.tabControl1.Controls.Add(this.passPage);
            this.tabControl1.Controls.Add(this.keyXORPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(485, 113);
            this.tabControl1.TabIndex = 0;
            // 
            // keyFilePage
            // 
            this.keyFilePage.BackColor = System.Drawing.SystemColors.Control;
            this.keyFilePage.Controls.Add(this.groupBox1);
            this.keyFilePage.Location = new System.Drawing.Point(4, 22);
            this.keyFilePage.Name = "keyFilePage";
            this.keyFilePage.Padding = new System.Windows.Forms.Padding(3);
            this.keyFilePage.Size = new System.Drawing.Size(477, 87);
            this.keyFilePage.TabIndex = 0;
            this.keyFilePage.Text = "Key File";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openKeyBtn);
            this.groupBox1.Controls.Add(this.openKPathBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File path";
            // 
            // openKeyBtn
            // 
            this.openKeyBtn.Location = new System.Drawing.Point(404, 29);
            this.openKeyBtn.Name = "openKeyBtn";
            this.openKeyBtn.Size = new System.Drawing.Size(44, 23);
            this.openKeyBtn.TabIndex = 1;
            this.openKeyBtn.Text = "...";
            this.openKeyBtn.UseVisualStyleBackColor = true;
            this.openKeyBtn.Click += new System.EventHandler(this.openKeyBtn_Click);
            // 
            // openKPathBox
            // 
            this.openKPathBox.Location = new System.Drawing.Point(6, 31);
            this.openKPathBox.Name = "openKPathBox";
            this.openKPathBox.Size = new System.Drawing.Size(392, 20);
            this.openKPathBox.TabIndex = 0;
            // 
            // keyHEXPage
            // 
            this.keyHEXPage.BackColor = System.Drawing.SystemColors.Control;
            this.keyHEXPage.Controls.Add(this.groupBox3);
            this.keyHEXPage.Location = new System.Drawing.Point(4, 22);
            this.keyHEXPage.Name = "keyHEXPage";
            this.keyHEXPage.Padding = new System.Windows.Forms.Padding(3);
            this.keyHEXPage.Size = new System.Drawing.Size(477, 87);
            this.keyHEXPage.TabIndex = 1;
            this.keyHEXPage.Text = "Key HEX";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.editHEXCheckBox);
            this.groupBox3.Controls.Add(this.keyHEXTextBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 72);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Key (HEX format)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DataSec_Lab_06_PRJ.Properties.Resources.raise_hand;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::DataSec_Lab_06_PRJ.Properties.Resources.raise_hand;
            this.pictureBox1.InitialImage = global::DataSec_Lab_06_PRJ.Properties.Resources.raise_hand;
            this.pictureBox1.Location = new System.Drawing.Point(401, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 47);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // editHEXCheckBox
            // 
            this.editHEXCheckBox.AutoSize = true;
            this.editHEXCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editHEXCheckBox.Location = new System.Drawing.Point(380, 34);
            this.editHEXCheckBox.Name = "editHEXCheckBox";
            this.editHEXCheckBox.Size = new System.Drawing.Size(15, 14);
            this.editHEXCheckBox.TabIndex = 2;
            this.editHEXCheckBox.UseVisualStyleBackColor = true;
            this.editHEXCheckBox.CheckedChanged += new System.EventHandler(this.editHEXCheckBox_CheckedChanged);
            // 
            // keyHEXTextBox
            // 
            this.keyHEXTextBox.Location = new System.Drawing.Point(6, 31);
            this.keyHEXTextBox.Name = "keyHEXTextBox";
            this.keyHEXTextBox.ReadOnly = true;
            this.keyHEXTextBox.Size = new System.Drawing.Size(368, 20);
            this.keyHEXTextBox.TabIndex = 0;
            this.keyHEXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyHEXTextBox_KeyPress);
            // 
            // passPage
            // 
            this.passPage.BackColor = System.Drawing.SystemColors.Control;
            this.passPage.Controls.Add(this.label2);
            this.passPage.Controls.Add(this.viewPassCheckBox);
            this.passPage.Controls.Add(this.passTextBox);
            this.passPage.Controls.Add(this.pictureBox2);
            this.passPage.Location = new System.Drawing.Point(4, 22);
            this.passPage.Name = "passPage";
            this.passPage.Size = new System.Drawing.Size(477, 87);
            this.passPage.TabIndex = 2;
            this.passPage.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password sample:";
            // 
            // viewPassCheckBox
            // 
            this.viewPassCheckBox.AutoSize = true;
            this.viewPassCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewPassCheckBox.Location = new System.Drawing.Point(386, 35);
            this.viewPassCheckBox.Name = "viewPassCheckBox";
            this.viewPassCheckBox.Size = new System.Drawing.Size(15, 14);
            this.viewPassCheckBox.TabIndex = 4;
            this.viewPassCheckBox.UseVisualStyleBackColor = true;
            this.viewPassCheckBox.CheckedChanged += new System.EventHandler(this.viewPassCheckBox_CheckedChanged);
            // 
            // passTextBox
            // 
            this.passTextBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.passTextBox.Location = new System.Drawing.Point(106, 32);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(274, 20);
            this.passTextBox.TabIndex = 1;
            this.passTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DataSec_Lab_06_PRJ.Properties.Resources.eye_scanner;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(406, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 47);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // keyXORPage
            // 
            this.keyXORPage.BackColor = System.Drawing.SystemColors.Control;
            this.keyXORPage.Controls.Add(this.saveFileStLabel);
            this.keyXORPage.Controls.Add(this.encodingStLabel);
            this.keyXORPage.Controls.Add(this.openFileStLabel);
            this.keyXORPage.Controls.Add(this.label11);
            this.keyXORPage.Controls.Add(this.label10);
            this.keyXORPage.Controls.Add(this.label9);
            this.keyXORPage.Controls.Add(this.label8);
            this.keyXORPage.Controls.Add(this.label7);
            this.keyXORPage.Controls.Add(this.label6);
            this.keyXORPage.Controls.Add(this.OpenFileButton);
            this.keyXORPage.Controls.Add(this.EncodeButton);
            this.keyXORPage.Controls.Add(this.SaveFileButton);
            this.keyXORPage.Location = new System.Drawing.Point(4, 22);
            this.keyXORPage.Name = "keyXORPage";
            this.keyXORPage.Size = new System.Drawing.Size(477, 87);
            this.keyXORPage.TabIndex = 3;
            this.keyXORPage.Text = "Key XOR File";
            // 
            // saveFileStLabel
            // 
            this.saveFileStLabel.AutoSize = true;
            this.saveFileStLabel.ForeColor = System.Drawing.Color.Red;
            this.saveFileStLabel.Location = new System.Drawing.Point(334, 53);
            this.saveFileStLabel.Name = "saveFileStLabel";
            this.saveFileStLabel.Size = new System.Drawing.Size(37, 13);
            this.saveFileStLabel.TabIndex = 15;
            this.saveFileStLabel.Text = "(none)";
            // 
            // encodingStLabel
            // 
            this.encodingStLabel.AutoSize = true;
            this.encodingStLabel.ForeColor = System.Drawing.Color.Red;
            this.encodingStLabel.Location = new System.Drawing.Point(147, 53);
            this.encodingStLabel.Name = "encodingStLabel";
            this.encodingStLabel.Size = new System.Drawing.Size(37, 13);
            this.encodingStLabel.TabIndex = 14;
            this.encodingStLabel.Text = "(none)";
            // 
            // openFileStLabel
            // 
            this.openFileStLabel.AutoSize = true;
            this.openFileStLabel.ForeColor = System.Drawing.Color.Red;
            this.openFileStLabel.Location = new System.Drawing.Point(17, 53);
            this.openFileStLabel.Name = "openFileStLabel";
            this.openFileStLabel.Size = new System.Drawing.Size(37, 13);
            this.openFileStLabel.TabIndex = 13;
            this.openFileStLabel.Text = "(none)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Save file:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Encryption:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Open file:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(329, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "3.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(141, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "2.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "1.";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackgroundImage = global::DataSec_Lab_06_PRJ.Properties.Resources.open_folder;
            this.OpenFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenFileButton.Location = new System.Drawing.Point(69, 21);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(52, 45);
            this.OpenFileButton.TabIndex = 6;
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // EncodeButton
            // 
            this.EncodeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EncodeButton.ImageIndex = 0;
            this.EncodeButton.ImageList = this.xorImageList;
            this.EncodeButton.Location = new System.Drawing.Point(202, 21);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(121, 45);
            this.EncodeButton.TabIndex = 5;
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.encodeBtn_Click);
            // 
            // xorImageList
            // 
            this.xorImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("xorImageList.ImageStream")));
            this.xorImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.xorImageList.Images.SetKeyName(0, "encryption_false.png");
            this.xorImageList.Images.SetKeyName(1, "encryption_true.png");
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.BackgroundImage = global::DataSec_Lab_06_PRJ.Properties.Resources.diskette;
            this.SaveFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveFileButton.Location = new System.Drawing.Point(386, 21);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(52, 45);
            this.SaveFileButton.TabIndex = 4;
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // GenKeyButton
            // 
            this.GenKeyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GenKeyButton.ImageIndex = 0;
            this.GenKeyButton.ImageList = this.keyGenImageList;
            this.GenKeyButton.Location = new System.Drawing.Point(21, 238);
            this.GenKeyButton.Name = "GenKeyButton";
            this.GenKeyButton.Size = new System.Drawing.Size(143, 23);
            this.GenKeyButton.TabIndex = 1;
            this.GenKeyButton.Text = "Generate Key";
            this.GenKeyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.GenKeyButton.UseVisualStyleBackColor = true;
            this.GenKeyButton.Click += new System.EventHandler(this.genKeyBtn_Click);
            // 
            // keyGenImageList
            // 
            this.keyGenImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("keyGenImageList.ImageStream")));
            this.keyGenImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.keyGenImageList.Images.SetKeyName(0, "key21.png");
            this.keyGenImageList.Images.SetKeyName(1, "key (1).png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total time (m : s):";
            // 
            // totTimeLabel
            // 
            this.totTimeLabel.AutoSize = true;
            this.totTimeLabel.Location = new System.Drawing.Point(402, 243);
            this.totTimeLabel.Name = "totTimeLabel";
            this.totTimeLabel.Size = new System.Drawing.Size(49, 13);
            this.totTimeLabel.TabIndex = 3;
            this.totTimeLabel.Text = "00:00.00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.KeyExtRadioButton);
            this.groupBox2.Controls.Add(this.KeyRNGRadioButton);
            this.groupBox2.Controls.Add(this.keyLengthComboBox);
            this.groupBox2.Controls.Add(this.keyLengthLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 103);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key";
            // 
            // KeyExtRadioButton
            // 
            this.KeyExtRadioButton.AutoSize = true;
            this.KeyExtRadioButton.Location = new System.Drawing.Point(209, 62);
            this.KeyExtRadioButton.Name = "KeyExtRadioButton";
            this.KeyExtRadioButton.Size = new System.Drawing.Size(202, 17);
            this.KeyExtRadioButton.TabIndex = 8;
            this.KeyExtRadioButton.TabStop = true;
            this.KeyExtRadioButton.Text = "Key Generation (Password Extension)";
            this.KeyExtRadioButton.UseVisualStyleBackColor = true;
            this.KeyExtRadioButton.CheckedChanged += new System.EventHandler(this.keyExtRadioBtn_CheckedChanged);
            // 
            // KeyRNGRadioButton
            // 
            this.KeyRNGRadioButton.AutoSize = true;
            this.KeyRNGRadioButton.Location = new System.Drawing.Point(209, 28);
            this.KeyRNGRadioButton.Name = "KeyRNGRadioButton";
            this.KeyRNGRadioButton.Size = new System.Drawing.Size(203, 17);
            this.KeyRNGRadioButton.TabIndex = 7;
            this.KeyRNGRadioButton.TabStop = true;
            this.KeyRNGRadioButton.Text = "Key Generation (Pseudo-RNG Crypto)";
            this.KeyRNGRadioButton.UseVisualStyleBackColor = true;
            this.KeyRNGRadioButton.CheckedChanged += new System.EventHandler(this.keyRNGRadioBtn_CheckedChanged);
            // 
            // keyLengthComboBox
            // 
            this.keyLengthComboBox.AutoCompleteCustomSource.AddRange(new string[] { "8", "16", "24", "32", "12500000" });
            this.keyLengthComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.keyLengthComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.keyLengthComboBox.FormattingEnabled = true;
            this.keyLengthComboBox.Items.AddRange(new object[] { "8", "16", "24", "32", "12500000" });
            this.keyLengthComboBox.Location = new System.Drawing.Point(100, 27);
            this.keyLengthComboBox.Name = "keyLengthComboBox";
            this.keyLengthComboBox.Size = new System.Drawing.Size(65, 21);
            this.keyLengthComboBox.TabIndex = 6;
            this.keyLengthComboBox.TextChanged += new System.EventHandler(this.keyLengthComboBox_TextChanged);
            this.keyLengthComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyLengthComboBox_KeyPress);
            // 
            // keyLengthLabel
            // 
            this.keyLengthLabel.AutoSize = true;
            this.keyLengthLabel.Location = new System.Drawing.Point(97, 64);
            this.keyLengthLabel.Name = "keyLengthLabel";
            this.keyLengthLabel.Size = new System.Drawing.Size(13, 13);
            this.keyLengthLabel.TabIndex = 5;
            this.keyLengthLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Key length (bits):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Key length (bytes):";
            // 
            // authorLinkLabel
            // 
            this.authorLinkLabel.AutoSize = true;
            this.authorLinkLabel.Location = new System.Drawing.Point(419, 9);
            this.authorLinkLabel.Name = "authorLinkLabel";
            this.authorLinkLabel.Size = new System.Drawing.Size(59, 13);
            this.authorLinkLabel.TabIndex = 5;
            this.authorLinkLabel.TabStop = true;
            this.authorLinkLabel.Text = "Author Info";
            this.authorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.authorLinkLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 278);
            this.Controls.Add(this.authorLinkLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.totTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenKeyButton);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lab06 - File Encryption";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.keyFilePage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.keyHEXPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.passPage.ResumeLayout(false);
            this.passPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.keyXORPage.ResumeLayout(false);
            this.keyXORPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage keyFilePage;
        private System.Windows.Forms.TabPage keyHEXPage;
        private System.Windows.Forms.TabPage passPage;
        private System.Windows.Forms.TabPage keyXORPage;
        private System.Windows.Forms.Button GenKeyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totTimeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button openKeyBtn;
        private System.Windows.Forms.TextBox openKPathBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton KeyExtRadioButton;
        private System.Windows.Forms.RadioButton KeyRNGRadioButton;
        private System.Windows.Forms.ComboBox keyLengthComboBox;
        private System.Windows.Forms.Label keyLengthLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox editHEXCheckBox;
        private System.Windows.Forms.TextBox keyHEXTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox viewPassCheckBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.LinkLabel authorLinkLabel;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.ImageList keyGenImageList;
        private System.Windows.Forms.ImageList xorImageList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label saveFileStLabel;
        private System.Windows.Forms.Label encodingStLabel;
        private System.Windows.Forms.Label openFileStLabel;
    }
}

