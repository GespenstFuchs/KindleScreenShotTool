namespace KindleScreenShotTool
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainTabControl = new TabControl();
            ScreenShotTabPage = new TabPage();
            label12 = new Label();
            CaptureCountNumericUpDown = new NumericUpDown();
            CaptureCountRadioButton = new RadioButton();
            label26 = new Label();
            DuplicateCountNumericUpDown = new NumericUpDown();
            DuplicateCountRadioButton = new RadioButton();
            label22 = new Label();
            label21 = new Label();
            PressKeyComboBox = new ComboBox();
            label20 = new Label();
            label18 = new Label();
            label9 = new Label();
            WaitingTimeNumericUpDown = new NumericUpDown();
            label6 = new Label();
            FileNameSampleLabel = new Label();
            ScreenShotExeButton = new Button();
            TestScreenShotButton = new Button();
            FileNameSerialNumberNumericUpDown = new NumericUpDown();
            label7 = new Label();
            CaptureHeightNumericUpDown = new NumericUpDown();
            label5 = new Label();
            CaptureStartYNumericUpDown = new NumericUpDown();
            label4 = new Label();
            CaptureWidthNumericUpDown = new NumericUpDown();
            label3 = new Label();
            CaptureStartXNumericUpDown = new NumericUpDown();
            label2 = new Label();
            GetTitleButton = new Button();
            KindleTitleTextBox = new TextBox();
            label1 = new Label();
            OCRTabPage = new TabPage();
            LangComboBox = new ComboBox();
            label17 = new Label();
            LangFileFolderPathSelectButton = new Button();
            LangFileFolderPathTextBox = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            OCRExeButton = new Button();
            MergeRadioButton = new RadioButton();
            SingleRadioButton = new RadioButton();
            label11 = new Label();
            label10 = new Label();
            OCRImageFolderPathSelectButton = new Button();
            OCRImageFolderPathTextBox = new TextBox();
            label8 = new Label();
            PDFTabPage = new TabPage();
            PDFImageFolderPathSelectButton = new Button();
            PDFImageFolderPathTextBox = new TextBox();
            label19 = new Label();
            PDFExeButton = new Button();
            ImageConcatenationTabPage = new TabPage();
            ImageConcatenationFileNameSampleLabel = new Label();
            ImageConcatenationFileNameSerialNumberNumericUpDown = new NumericUpDown();
            label13 = new Label();
            ConnectionCountNumericUpDown = new NumericUpDown();
            label25 = new Label();
            ConnectionDirectionComboBox = new ComboBox();
            label24 = new Label();
            ImageConcatenationImageFolderPathSelectButton = new Button();
            ImageConcatenationImageFolderPathTextBox = new TextBox();
            label23 = new Label();
            ImageConcatenationExeButton = new Button();
            ScreenShotSaveFolderBrowserDialog = new FolderBrowserDialog();
            LangFileFolderPathToolTip = new ToolTip(components);
            OCRImageFolderPathFolderBrowserDialog = new FolderBrowserDialog();
            OCROutputFolderPathFolderBrowserDialog = new FolderBrowserDialog();
            LangFileFolderPathFolderBrowserDialog = new FolderBrowserDialog();
            OCRTextSaveFileDialog = new SaveFileDialog();
            TestScreenShotSaveFileDialog = new SaveFileDialog();
            PDFSaveFileDialog = new SaveFileDialog();
            PDFImageFolderPathFolderBrowserDialog = new FolderBrowserDialog();
            ConnectionImageSaveFolderBrowserDialog = new FolderBrowserDialog();
            MainTabControl.SuspendLayout();
            ScreenShotTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CaptureCountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DuplicateCountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WaitingTimeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FileNameSerialNumberNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CaptureHeightNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CaptureStartYNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CaptureWidthNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CaptureStartXNumericUpDown).BeginInit();
            OCRTabPage.SuspendLayout();
            PDFTabPage.SuspendLayout();
            ImageConcatenationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageConcatenationFileNameSerialNumberNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ConnectionCountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(ScreenShotTabPage);
            MainTabControl.Controls.Add(OCRTabPage);
            MainTabControl.Controls.Add(PDFTabPage);
            MainTabControl.Controls.Add(ImageConcatenationTabPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(800, 517);
            MainTabControl.TabIndex = 0;
            // 
            // ScreenShotTabPage
            // 
            ScreenShotTabPage.BackColor = SystemColors.Control;
            ScreenShotTabPage.BorderStyle = BorderStyle.FixedSingle;
            ScreenShotTabPage.Controls.Add(label12);
            ScreenShotTabPage.Controls.Add(CaptureCountNumericUpDown);
            ScreenShotTabPage.Controls.Add(CaptureCountRadioButton);
            ScreenShotTabPage.Controls.Add(label26);
            ScreenShotTabPage.Controls.Add(DuplicateCountNumericUpDown);
            ScreenShotTabPage.Controls.Add(DuplicateCountRadioButton);
            ScreenShotTabPage.Controls.Add(label22);
            ScreenShotTabPage.Controls.Add(label21);
            ScreenShotTabPage.Controls.Add(PressKeyComboBox);
            ScreenShotTabPage.Controls.Add(label20);
            ScreenShotTabPage.Controls.Add(label18);
            ScreenShotTabPage.Controls.Add(label9);
            ScreenShotTabPage.Controls.Add(WaitingTimeNumericUpDown);
            ScreenShotTabPage.Controls.Add(label6);
            ScreenShotTabPage.Controls.Add(FileNameSampleLabel);
            ScreenShotTabPage.Controls.Add(ScreenShotExeButton);
            ScreenShotTabPage.Controls.Add(TestScreenShotButton);
            ScreenShotTabPage.Controls.Add(FileNameSerialNumberNumericUpDown);
            ScreenShotTabPage.Controls.Add(label7);
            ScreenShotTabPage.Controls.Add(CaptureHeightNumericUpDown);
            ScreenShotTabPage.Controls.Add(label5);
            ScreenShotTabPage.Controls.Add(CaptureStartYNumericUpDown);
            ScreenShotTabPage.Controls.Add(label4);
            ScreenShotTabPage.Controls.Add(CaptureWidthNumericUpDown);
            ScreenShotTabPage.Controls.Add(label3);
            ScreenShotTabPage.Controls.Add(CaptureStartXNumericUpDown);
            ScreenShotTabPage.Controls.Add(label2);
            ScreenShotTabPage.Controls.Add(GetTitleButton);
            ScreenShotTabPage.Controls.Add(KindleTitleTextBox);
            ScreenShotTabPage.Controls.Add(label1);
            ScreenShotTabPage.Location = new Point(4, 30);
            ScreenShotTabPage.Name = "ScreenShotTabPage";
            ScreenShotTabPage.Padding = new Padding(3);
            ScreenShotTabPage.Size = new Size(792, 483);
            ScreenShotTabPage.TabIndex = 0;
            ScreenShotTabPage.Text = "スクリーンショット";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(113, 356);
            label12.Name = "label12";
            label12.Size = new Size(183, 21);
            label12.TabIndex = 28;
            label12.Text = "枚撮影したら、終了します。";
            // 
            // CaptureCountNumericUpDown
            // 
            CaptureCountNumericUpDown.Enabled = false;
            CaptureCountNumericUpDown.Location = new Point(37, 354);
            CaptureCountNumericUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            CaptureCountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CaptureCountNumericUpDown.Name = "CaptureCountNumericUpDown";
            CaptureCountNumericUpDown.Size = new Size(72, 29);
            CaptureCountNumericUpDown.TabIndex = 27;
            CaptureCountNumericUpDown.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // CaptureCountRadioButton
            // 
            CaptureCountRadioButton.AutoSize = true;
            CaptureCountRadioButton.Location = new Point(17, 360);
            CaptureCountRadioButton.Name = "CaptureCountRadioButton";
            CaptureCountRadioButton.Size = new Size(14, 13);
            CaptureCountRadioButton.TabIndex = 26;
            CaptureCountRadioButton.UseVisualStyleBackColor = true;
            CaptureCountRadioButton.CheckedChanged += CaptureCountRadioButton_CheckedChanged;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(113, 321);
            label26.Name = "label26";
            label26.Size = new Size(391, 21);
            label26.TabIndex = 25;
            label26.Text = "枚続けて、同じスクリーンショットが撮影されたら、終了します。";
            // 
            // DuplicateCountNumericUpDown
            // 
            DuplicateCountNumericUpDown.Location = new Point(37, 319);
            DuplicateCountNumericUpDown.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            DuplicateCountNumericUpDown.Name = "DuplicateCountNumericUpDown";
            DuplicateCountNumericUpDown.Size = new Size(72, 29);
            DuplicateCountNumericUpDown.TabIndex = 24;
            DuplicateCountNumericUpDown.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // DuplicateCountRadioButton
            // 
            DuplicateCountRadioButton.AutoSize = true;
            DuplicateCountRadioButton.Checked = true;
            DuplicateCountRadioButton.Location = new Point(17, 325);
            DuplicateCountRadioButton.Name = "DuplicateCountRadioButton";
            DuplicateCountRadioButton.Size = new Size(14, 13);
            DuplicateCountRadioButton.TabIndex = 23;
            DuplicateCountRadioButton.TabStop = true;
            DuplicateCountRadioButton.UseVisualStyleBackColor = true;
            DuplicateCountRadioButton.CheckedChanged += DuplicateCountRadioButton_CheckedChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(7, 292);
            label22.Name = "label22";
            label22.Size = new Size(106, 21);
            label22.TabIndex = 21;
            label22.Text = "撮影終了条件";
            // 
            // label21
            // 
            label21.BorderStyle = BorderStyle.FixedSingle;
            label21.Location = new Point(7, 306);
            label21.Name = "label21";
            label21.Size = new Size(507, 91);
            label21.TabIndex = 22;
            // 
            // PressKeyComboBox
            // 
            PressKeyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PressKeyComboBox.FormattingEnabled = true;
            PressKeyComboBox.Items.AddRange(new object[] { "左（←）", "右（→）" });
            PressKeyComboBox.Location = new Point(151, 255);
            PressKeyComboBox.Name = "PressKeyComboBox";
            PressKeyComboBox.Size = new Size(100, 29);
            PressKeyComboBox.TabIndex = 20;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(7, 258);
            label20.Name = "label20";
            label20.Size = new Size(64, 21);
            label20.TabIndex = 19;
            label20.Text = "押下キー";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(229, 222);
            label18.Name = "label18";
            label18.Size = new Size(47, 21);
            label18.TabIndex = 18;
            label18.Text = "ミリ秒";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 222);
            label9.Name = "label9";
            label9.Size = new Size(106, 21);
            label9.TabIndex = 16;
            label9.Text = "撮影待機時間";
            // 
            // WaitingTimeNumericUpDown
            // 
            WaitingTimeNumericUpDown.Location = new Point(151, 220);
            WaitingTimeNumericUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            WaitingTimeNumericUpDown.Name = "WaitingTimeNumericUpDown";
            WaitingTimeNumericUpDown.Size = new Size(72, 29);
            WaitingTimeNumericUpDown.TabIndex = 17;
            WaitingTimeNumericUpDown.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(7, 417);
            label6.Name = "label6";
            label6.Size = new Size(422, 42);
            label6.TabIndex = 29;
            label6.Text = "※Kindleを自動で前面表示にし、スクリーンショットを撮影します。\r\n　Kindleを最小化せずに、実行ボタンを押下して下さい。";
            // 
            // FileNameSampleLabel
            // 
            FileNameSampleLabel.AutoSize = true;
            FileNameSampleLabel.Location = new Point(229, 187);
            FileNameSampleLabel.Name = "FileNameSampleLabel";
            FileNameSampleLabel.Size = new Size(192, 21);
            FileNameSampleLabel.TabIndex = 15;
            FileNameSampleLabel.Text = "サンプルファイル名：000.png";
            // 
            // ScreenShotExeButton
            // 
            ScreenShotExeButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            ScreenShotExeButton.Location = new Point(7, 20);
            ScreenShotExeButton.Name = "ScreenShotExeButton";
            ScreenShotExeButton.Size = new Size(100, 40);
            ScreenShotExeButton.TabIndex = 0;
            ScreenShotExeButton.Text = "実行";
            ScreenShotExeButton.UseVisualStyleBackColor = true;
            ScreenShotExeButton.Click += ScreenShotExeButton_Click;
            // 
            // TestScreenShotButton
            // 
            TestScreenShotButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            TestScreenShotButton.Location = new Point(113, 20);
            TestScreenShotButton.Name = "TestScreenShotButton";
            TestScreenShotButton.Size = new Size(100, 40);
            TestScreenShotButton.TabIndex = 1;
            TestScreenShotButton.Text = "テスト撮影";
            TestScreenShotButton.UseVisualStyleBackColor = true;
            TestScreenShotButton.Click += TestScreenShotButton_Click;
            // 
            // FileNameSerialNumberNumericUpDown
            // 
            FileNameSerialNumberNumericUpDown.Location = new Point(151, 185);
            FileNameSerialNumberNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            FileNameSerialNumberNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            FileNameSerialNumberNumericUpDown.Name = "FileNameSerialNumberNumericUpDown";
            FileNameSerialNumberNumericUpDown.Size = new Size(72, 29);
            FileNameSerialNumberNumericUpDown.TabIndex = 14;
            FileNameSerialNumberNumericUpDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
            FileNameSerialNumberNumericUpDown.ValueChanged += FileNameSerialNumberNumericUpDown_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 187);
            label7.Name = "label7";
            label7.Size = new Size(135, 21);
            label7.TabIndex = 13;
            label7.Text = "ファイル名連番桁数";
            // 
            // CaptureHeightNumericUpDown
            // 
            CaptureHeightNumericUpDown.Location = new Point(325, 150);
            CaptureHeightNumericUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            CaptureHeightNumericUpDown.Name = "CaptureHeightNumericUpDown";
            CaptureHeightNumericUpDown.Size = new Size(72, 29);
            CaptureHeightNumericUpDown.TabIndex = 12;
            CaptureHeightNumericUpDown.Value = new decimal(new int[] { 888, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 152);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 11;
            label5.Text = "撮影高さ";
            // 
            // CaptureStartYNumericUpDown
            // 
            CaptureStartYNumericUpDown.Location = new Point(151, 150);
            CaptureStartYNumericUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            CaptureStartYNumericUpDown.Name = "CaptureStartYNumericUpDown";
            CaptureStartYNumericUpDown.Size = new Size(72, 29);
            CaptureStartYNumericUpDown.TabIndex = 10;
            CaptureStartYNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 152);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 9;
            label4.Text = "撮影開始位置：Ｙ";
            // 
            // CaptureWidthNumericUpDown
            // 
            CaptureWidthNumericUpDown.Location = new Point(325, 115);
            CaptureWidthNumericUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            CaptureWidthNumericUpDown.Name = "CaptureWidthNumericUpDown";
            CaptureWidthNumericUpDown.Size = new Size(72, 29);
            CaptureWidthNumericUpDown.TabIndex = 8;
            CaptureWidthNumericUpDown.Value = new decimal(new int[] { 1870, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 117);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 7;
            label3.Text = "撮影幅";
            // 
            // CaptureStartXNumericUpDown
            // 
            CaptureStartXNumericUpDown.Location = new Point(151, 115);
            CaptureStartXNumericUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            CaptureStartXNumericUpDown.Name = "CaptureStartXNumericUpDown";
            CaptureStartXNumericUpDown.Size = new Size(72, 29);
            CaptureStartXNumericUpDown.TabIndex = 6;
            CaptureStartXNumericUpDown.Value = new decimal(new int[] { 48, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 117);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 5;
            label2.Text = "撮影開始位置：Ｘ";
            // 
            // GetTitleButton
            // 
            GetTitleButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GetTitleButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            GetTitleButton.Location = new Point(673, 73);
            GetTitleButton.Name = "GetTitleButton";
            GetTitleButton.Size = new Size(110, 40);
            GetTitleButton.TabIndex = 4;
            GetTitleButton.Text = "タイトル取得";
            GetTitleButton.UseVisualStyleBackColor = true;
            GetTitleButton.Click += GetTitleButton_Click;
            // 
            // KindleTitleTextBox
            // 
            KindleTitleTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            KindleTitleTextBox.Location = new Point(126, 80);
            KindleTitleTextBox.MaxLength = 0;
            KindleTitleTextBox.Name = "KindleTitleTextBox";
            KindleTitleTextBox.Size = new Size(541, 29);
            KindleTitleTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 83);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 2;
            label1.Text = "Kindleのタイトル";
            // 
            // OCRTabPage
            // 
            OCRTabPage.BackColor = SystemColors.Control;
            OCRTabPage.BorderStyle = BorderStyle.FixedSingle;
            OCRTabPage.Controls.Add(LangComboBox);
            OCRTabPage.Controls.Add(label17);
            OCRTabPage.Controls.Add(LangFileFolderPathSelectButton);
            OCRTabPage.Controls.Add(LangFileFolderPathTextBox);
            OCRTabPage.Controls.Add(label16);
            OCRTabPage.Controls.Add(label15);
            OCRTabPage.Controls.Add(label14);
            OCRTabPage.Controls.Add(OCRExeButton);
            OCRTabPage.Controls.Add(MergeRadioButton);
            OCRTabPage.Controls.Add(SingleRadioButton);
            OCRTabPage.Controls.Add(label11);
            OCRTabPage.Controls.Add(label10);
            OCRTabPage.Controls.Add(OCRImageFolderPathSelectButton);
            OCRTabPage.Controls.Add(OCRImageFolderPathTextBox);
            OCRTabPage.Controls.Add(label8);
            OCRTabPage.Location = new Point(4, 24);
            OCRTabPage.Name = "OCRTabPage";
            OCRTabPage.Padding = new Padding(3);
            OCRTabPage.Size = new Size(792, 489);
            OCRTabPage.TabIndex = 1;
            OCRTabPage.Text = "OCR";
            // 
            // LangComboBox
            // 
            LangComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LangComboBox.FormattingEnabled = true;
            LangComboBox.Items.AddRange(new object[] { "日本語", "日本語（縦書き）", "英語", "日本語＋英語", "日本語（縦書き）＋英語" });
            LangComboBox.Location = new Point(221, 295);
            LangComboBox.Name = "LangComboBox";
            LangComboBox.Size = new Size(220, 29);
            LangComboBox.TabIndex = 14;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(25, 298);
            label17.Name = "label17";
            label17.Size = new Size(42, 21);
            label17.TabIndex = 13;
            label17.Text = "言語";
            // 
            // LangFileFolderPathSelectButton
            // 
            LangFileFolderPathSelectButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LangFileFolderPathSelectButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            LangFileFolderPathSelectButton.Location = new Point(663, 253);
            LangFileFolderPathSelectButton.Name = "LangFileFolderPathSelectButton";
            LangFileFolderPathSelectButton.Size = new Size(110, 40);
            LangFileFolderPathSelectButton.TabIndex = 12;
            LangFileFolderPathSelectButton.Text = "フォルダ選択";
            LangFileFolderPathSelectButton.UseVisualStyleBackColor = true;
            LangFileFolderPathSelectButton.Click += LangFileFolderPathSelectButton_Click;
            // 
            // LangFileFolderPathTextBox
            // 
            LangFileFolderPathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LangFileFolderPathTextBox.Location = new Point(221, 260);
            LangFileFolderPathTextBox.MaxLength = 0;
            LangFileFolderPathTextBox.Name = "LangFileFolderPathTextBox";
            LangFileFolderPathTextBox.Size = new Size(436, 29);
            LangFileFolderPathTextBox.TabIndex = 11;
            LangFileFolderPathTextBox.Text = "C:\\Users\\fugyu\\Documents\\traineddata";
            LangFileFolderPathToolTip.SetToolTip(LangFileFolderPathTextBox, "tessdataファイルが配置されているフォルダパスを入力して下さい。");
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(25, 263);
            label16.Name = "label16";
            label16.Size = new Size(191, 21);
            label16.TabIndex = 10;
            label16.Text = "言語ファイル格納フォルダパス";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(25, 232);
            label15.Name = "label15";
            label15.Size = new Size(74, 21);
            label15.TabIndex = 8;
            label15.Text = "OCR設定";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Location = new Point(12, 243);
            label14.Name = "label14";
            label14.Size = new Size(771, 101);
            label14.TabIndex = 9;
            // 
            // OCRExeButton
            // 
            OCRExeButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            OCRExeButton.Location = new Point(7, 20);
            OCRExeButton.Name = "OCRExeButton";
            OCRExeButton.Size = new Size(100, 40);
            OCRExeButton.TabIndex = 0;
            OCRExeButton.Text = "実行";
            OCRExeButton.UseVisualStyleBackColor = true;
            OCRExeButton.Click += OCRExeButton_Click;
            // 
            // MergeRadioButton
            // 
            MergeRadioButton.AutoSize = true;
            MergeRadioButton.Location = new Point(23, 173);
            MergeRadioButton.Name = "MergeRadioButton";
            MergeRadioButton.Size = new Size(212, 25);
            MergeRadioButton.TabIndex = 7;
            MergeRadioButton.Text = "まとめてテキストファイルを出力";
            MergeRadioButton.UseVisualStyleBackColor = true;
            // 
            // SingleRadioButton
            // 
            SingleRadioButton.AutoSize = true;
            SingleRadioButton.Checked = true;
            SingleRadioButton.Location = new Point(23, 142);
            SingleRadioButton.Name = "SingleRadioButton";
            SingleRadioButton.Size = new Size(254, 25);
            SingleRadioButton.TabIndex = 6;
            SingleRadioButton.TabStop = true;
            SingleRadioButton.Text = "ファイル単位でテキストファイルを出力";
            SingleRadioButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 118);
            label11.Name = "label11";
            label11.Size = new Size(74, 21);
            label11.TabIndex = 4;
            label11.Text = "出力形式";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.BackColor = Color.Transparent;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Location = new Point(12, 129);
            label10.Name = "label10";
            label10.Size = new Size(771, 82);
            label10.TabIndex = 5;
            // 
            // OCRImageFolderPathSelectButton
            // 
            OCRImageFolderPathSelectButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OCRImageFolderPathSelectButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            OCRImageFolderPathSelectButton.Location = new Point(673, 73);
            OCRImageFolderPathSelectButton.Name = "OCRImageFolderPathSelectButton";
            OCRImageFolderPathSelectButton.Size = new Size(110, 40);
            OCRImageFolderPathSelectButton.TabIndex = 3;
            OCRImageFolderPathSelectButton.Text = "フォルダ選択";
            OCRImageFolderPathSelectButton.UseVisualStyleBackColor = true;
            OCRImageFolderPathSelectButton.Click += OCRImageFolderPathSelectButton_Click;
            // 
            // OCRImageFolderPathTextBox
            // 
            OCRImageFolderPathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OCRImageFolderPathTextBox.Location = new Point(126, 80);
            OCRImageFolderPathTextBox.MaxLength = 0;
            OCRImageFolderPathTextBox.Name = "OCRImageFolderPathTextBox";
            OCRImageFolderPathTextBox.Size = new Size(541, 29);
            OCRImageFolderPathTextBox.TabIndex = 2;
            OCRImageFolderPathTextBox.Text = "C:\\Users\\fugyu\\OneDrive\\画像\\Screenshots";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 83);
            label8.Name = "label8";
            label8.Size = new Size(114, 21);
            label8.TabIndex = 1;
            label8.Text = "画像フォルダパス";
            // 
            // PDFTabPage
            // 
            PDFTabPage.BackColor = SystemColors.Control;
            PDFTabPage.BorderStyle = BorderStyle.FixedSingle;
            PDFTabPage.Controls.Add(PDFImageFolderPathSelectButton);
            PDFTabPage.Controls.Add(PDFImageFolderPathTextBox);
            PDFTabPage.Controls.Add(label19);
            PDFTabPage.Controls.Add(PDFExeButton);
            PDFTabPage.Location = new Point(4, 24);
            PDFTabPage.Name = "PDFTabPage";
            PDFTabPage.Size = new Size(792, 489);
            PDFTabPage.TabIndex = 2;
            PDFTabPage.Text = "PDF";
            // 
            // PDFImageFolderPathSelectButton
            // 
            PDFImageFolderPathSelectButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PDFImageFolderPathSelectButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            PDFImageFolderPathSelectButton.Location = new Point(673, 73);
            PDFImageFolderPathSelectButton.Name = "PDFImageFolderPathSelectButton";
            PDFImageFolderPathSelectButton.Size = new Size(110, 40);
            PDFImageFolderPathSelectButton.TabIndex = 3;
            PDFImageFolderPathSelectButton.Text = "フォルダ選択";
            PDFImageFolderPathSelectButton.UseVisualStyleBackColor = true;
            PDFImageFolderPathSelectButton.Click += PDFImageFolderPathSelectButton_Click;
            // 
            // PDFImageFolderPathTextBox
            // 
            PDFImageFolderPathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PDFImageFolderPathTextBox.Location = new Point(126, 80);
            PDFImageFolderPathTextBox.MaxLength = 0;
            PDFImageFolderPathTextBox.Name = "PDFImageFolderPathTextBox";
            PDFImageFolderPathTextBox.Size = new Size(541, 29);
            PDFImageFolderPathTextBox.TabIndex = 2;
            PDFImageFolderPathTextBox.Text = "C:\\Users\\fugyu\\OneDrive\\画像\\Screenshots";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(7, 83);
            label19.Name = "label19";
            label19.Size = new Size(114, 21);
            label19.TabIndex = 1;
            label19.Text = "画像フォルダパス";
            // 
            // PDFExeButton
            // 
            PDFExeButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            PDFExeButton.Location = new Point(7, 20);
            PDFExeButton.Name = "PDFExeButton";
            PDFExeButton.Size = new Size(100, 40);
            PDFExeButton.TabIndex = 0;
            PDFExeButton.Text = "実行";
            PDFExeButton.UseVisualStyleBackColor = true;
            PDFExeButton.Click += PDFExeButton_Click;
            // 
            // ImageConcatenationTabPage
            // 
            ImageConcatenationTabPage.BackColor = SystemColors.Control;
            ImageConcatenationTabPage.BorderStyle = BorderStyle.FixedSingle;
            ImageConcatenationTabPage.Controls.Add(ImageConcatenationFileNameSampleLabel);
            ImageConcatenationTabPage.Controls.Add(ImageConcatenationFileNameSerialNumberNumericUpDown);
            ImageConcatenationTabPage.Controls.Add(label13);
            ImageConcatenationTabPage.Controls.Add(ConnectionCountNumericUpDown);
            ImageConcatenationTabPage.Controls.Add(label25);
            ImageConcatenationTabPage.Controls.Add(ConnectionDirectionComboBox);
            ImageConcatenationTabPage.Controls.Add(label24);
            ImageConcatenationTabPage.Controls.Add(ImageConcatenationImageFolderPathSelectButton);
            ImageConcatenationTabPage.Controls.Add(ImageConcatenationImageFolderPathTextBox);
            ImageConcatenationTabPage.Controls.Add(label23);
            ImageConcatenationTabPage.Controls.Add(ImageConcatenationExeButton);
            ImageConcatenationTabPage.Location = new Point(4, 24);
            ImageConcatenationTabPage.Name = "ImageConcatenationTabPage";
            ImageConcatenationTabPage.Size = new Size(792, 489);
            ImageConcatenationTabPage.TabIndex = 3;
            ImageConcatenationTabPage.Text = "画像連結";
            // 
            // ImageConcatenationFileNameSampleLabel
            // 
            ImageConcatenationFileNameSampleLabel.AutoSize = true;
            ImageConcatenationFileNameSampleLabel.Location = new Point(226, 187);
            ImageConcatenationFileNameSampleLabel.Name = "ImageConcatenationFileNameSampleLabel";
            ImageConcatenationFileNameSampleLabel.Size = new Size(192, 21);
            ImageConcatenationFileNameSampleLabel.TabIndex = 10;
            ImageConcatenationFileNameSampleLabel.Text = "サンプルファイル名：000.png";
            // 
            // ImageConcatenationFileNameSerialNumberNumericUpDown
            // 
            ImageConcatenationFileNameSerialNumberNumericUpDown.Location = new Point(148, 185);
            ImageConcatenationFileNameSerialNumberNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            ImageConcatenationFileNameSerialNumberNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ImageConcatenationFileNameSerialNumberNumericUpDown.Name = "ImageConcatenationFileNameSerialNumberNumericUpDown";
            ImageConcatenationFileNameSerialNumberNumericUpDown.Size = new Size(72, 29);
            ImageConcatenationFileNameSerialNumberNumericUpDown.TabIndex = 9;
            ImageConcatenationFileNameSerialNumberNumericUpDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
            ImageConcatenationFileNameSerialNumberNumericUpDown.ValueChanged += ImageConcatenationFileNameSerialNumberNumericUpDown_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 187);
            label13.Name = "label13";
            label13.Size = new Size(135, 21);
            label13.TabIndex = 8;
            label13.Text = "ファイル名連番桁数";
            // 
            // ConnectionCountNumericUpDown
            // 
            ConnectionCountNumericUpDown.Location = new Point(148, 150);
            ConnectionCountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ConnectionCountNumericUpDown.Name = "ConnectionCountNumericUpDown";
            ConnectionCountNumericUpDown.Size = new Size(72, 29);
            ConnectionCountNumericUpDown.TabIndex = 7;
            ConnectionCountNumericUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(7, 152);
            label25.Name = "label25";
            label25.Size = new Size(58, 21);
            label25.TabIndex = 6;
            label25.Text = "連結数";
            // 
            // ConnectionDirectionComboBox
            // 
            ConnectionDirectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ConnectionDirectionComboBox.FormattingEnabled = true;
            ConnectionDirectionComboBox.Items.AddRange(new object[] { "上から下（↓）", "下から上（↑）", "左から右（→）", "右から左（←）" });
            ConnectionDirectionComboBox.Location = new Point(148, 115);
            ConnectionDirectionComboBox.Name = "ConnectionDirectionComboBox";
            ConnectionDirectionComboBox.Size = new Size(140, 29);
            ConnectionDirectionComboBox.TabIndex = 5;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(7, 118);
            label24.Name = "label24";
            label24.Size = new Size(74, 21);
            label24.TabIndex = 4;
            label24.Text = "連結方向";
            // 
            // ImageConcatenationImageFolderPathSelectButton
            // 
            ImageConcatenationImageFolderPathSelectButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ImageConcatenationImageFolderPathSelectButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            ImageConcatenationImageFolderPathSelectButton.Location = new Point(673, 73);
            ImageConcatenationImageFolderPathSelectButton.Name = "ImageConcatenationImageFolderPathSelectButton";
            ImageConcatenationImageFolderPathSelectButton.Size = new Size(110, 40);
            ImageConcatenationImageFolderPathSelectButton.TabIndex = 3;
            ImageConcatenationImageFolderPathSelectButton.Text = "フォルダ選択";
            ImageConcatenationImageFolderPathSelectButton.UseVisualStyleBackColor = true;
            ImageConcatenationImageFolderPathSelectButton.Click += ImageConcatenationImageFolderPathSelectButton_Click;
            // 
            // ImageConcatenationImageFolderPathTextBox
            // 
            ImageConcatenationImageFolderPathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ImageConcatenationImageFolderPathTextBox.Location = new Point(148, 80);
            ImageConcatenationImageFolderPathTextBox.MaxLength = 0;
            ImageConcatenationImageFolderPathTextBox.Name = "ImageConcatenationImageFolderPathTextBox";
            ImageConcatenationImageFolderPathTextBox.Size = new Size(519, 29);
            ImageConcatenationImageFolderPathTextBox.TabIndex = 2;
            ImageConcatenationImageFolderPathTextBox.Text = "C:\\Users\\fugyu\\OneDrive\\画像\\Screenshots";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(7, 83);
            label23.Name = "label23";
            label23.Size = new Size(114, 21);
            label23.TabIndex = 1;
            label23.Text = "画像フォルダパス";
            // 
            // ImageConcatenationExeButton
            // 
            ImageConcatenationExeButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            ImageConcatenationExeButton.Location = new Point(7, 20);
            ImageConcatenationExeButton.Name = "ImageConcatenationExeButton";
            ImageConcatenationExeButton.Size = new Size(100, 40);
            ImageConcatenationExeButton.TabIndex = 0;
            ImageConcatenationExeButton.Text = "実行";
            ImageConcatenationExeButton.UseVisualStyleBackColor = true;
            ImageConcatenationExeButton.Click += ImageConcatenationExeButton_Click;
            // 
            // ScreenShotSaveFolderBrowserDialog
            // 
            ScreenShotSaveFolderBrowserDialog.Description = "保存するフォルダを選択";
            ScreenShotSaveFolderBrowserDialog.InitialDirectory = "Environment.SpecialFolder.MyDocuments";
            // 
            // OCRImageFolderPathFolderBrowserDialog
            // 
            OCRImageFolderPathFolderBrowserDialog.InitialDirectory = "Environment.SpecialFolder.MyDocuments";
            // 
            // OCROutputFolderPathFolderBrowserDialog
            // 
            OCROutputFolderPathFolderBrowserDialog.Description = "保存するフォルダを選択";
            OCROutputFolderPathFolderBrowserDialog.InitialDirectory = "Environment.SpecialFolder.MyDocuments";
            // 
            // LangFileFolderPathFolderBrowserDialog
            // 
            LangFileFolderPathFolderBrowserDialog.InitialDirectory = "Environment.SpecialFolder.MyDocuments";
            // 
            // OCRTextSaveFileDialog
            // 
            OCRTextSaveFileDialog.DefaultExt = "txt";
            OCRTextSaveFileDialog.FileName = "一括出力";
            OCRTextSaveFileDialog.Filter = "テキストファイル (*.txt)|*.txt";
            OCRTextSaveFileDialog.InitialDirectory = "Environment.SpecialFolder.MyDocuments";
            OCRTextSaveFileDialog.RestoreDirectory = true;
            OCRTextSaveFileDialog.Title = "読み取ったテキストを保存";
            // 
            // TestScreenShotSaveFileDialog
            // 
            TestScreenShotSaveFileDialog.DefaultExt = "png";
            TestScreenShotSaveFileDialog.FileName = "テストスクリーンショット";
            TestScreenShotSaveFileDialog.Filter = "PNGファイル (*.png)|*.png";
            TestScreenShotSaveFileDialog.InitialDirectory = "Environment.SpecialFolder.MyDocuments";
            TestScreenShotSaveFileDialog.RestoreDirectory = true;
            TestScreenShotSaveFileDialog.Title = "テストスクリーンショットを保存";
            // 
            // PDFSaveFileDialog
            // 
            PDFSaveFileDialog.DefaultExt = "pdf";
            PDFSaveFileDialog.FileName = "作成PDF";
            PDFSaveFileDialog.Filter = "pdfファイル (*.pdf)|*.pdf";
            PDFSaveFileDialog.InitialDirectory = "Environment.SpecialFolder.MyDocuments";
            PDFSaveFileDialog.RestoreDirectory = true;
            PDFSaveFileDialog.Title = "PDFを保存";
            // 
            // PDFImageFolderPathFolderBrowserDialog
            // 
            PDFImageFolderPathFolderBrowserDialog.InitialDirectory = "Environment.SpecialFolder.MyDocuments";
            // 
            // ConnectionImageSaveFolderBrowserDialog
            // 
            ConnectionImageSaveFolderBrowserDialog.Description = "保存するフォルダを選択";
            ConnectionImageSaveFolderBrowserDialog.InitialDirectory = "Environment.SpecialFolder.MyDocuments";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 517);
            Controls.Add(MainTabControl);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kindleスクリーンショットツール";
            MainTabControl.ResumeLayout(false);
            ScreenShotTabPage.ResumeLayout(false);
            ScreenShotTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CaptureCountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)DuplicateCountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)WaitingTimeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)FileNameSerialNumberNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)CaptureHeightNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)CaptureStartYNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)CaptureWidthNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)CaptureStartXNumericUpDown).EndInit();
            OCRTabPage.ResumeLayout(false);
            OCRTabPage.PerformLayout();
            PDFTabPage.ResumeLayout(false);
            PDFTabPage.PerformLayout();
            ImageConcatenationTabPage.ResumeLayout(false);
            ImageConcatenationTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImageConcatenationFileNameSerialNumberNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ConnectionCountNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage ScreenShotTabPage;
        private TabPage OCRTabPage;
        private Label label1;
        private TextBox KindleTitleTextBox;
        private Button GetTitleButton;
        private NumericUpDown CaptureStartXNumericUpDown;
        private Label label2;
        private Label label3;
        private NumericUpDown CaptureWidthNumericUpDown;
        private Label label4;
        private NumericUpDown CaptureStartYNumericUpDown;
        private Label label5;
        private NumericUpDown CaptureHeightNumericUpDown;
        private Label label7;
        private NumericUpDown FileNameSerialNumberNumericUpDown;
        private Label FileNameSampleLabel;
        private TabPage PDFTabPage;
        private TabPage ImageConcatenationTabPage;
        private Button ScreenShotExeButton;
        private Button TestScreenShotButton;
        private Label label8;
        private TextBox OCRImageFolderPathTextBox;
        private Button OCRImageFolderPathSelectButton;
        private Label label10;
        private Label label11;
        private RadioButton MergeRadioButton;
        private RadioButton SingleRadioButton;
        private Button OCRExeButton;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox LangFileFolderPathTextBox;
        private Button LangFileFolderPathSelectButton;
        private Label label17;
        private ComboBox LangComboBox;
        private Button PDFExeButton;
        private Button PDFImageFolderPathSelectButton;
        private TextBox PDFImageFolderPathTextBox;
        private Label label19;
        private Button ImageConcatenationExeButton;
        private Button ImageConcatenationImageFolderPathSelectButton;
        private TextBox ImageConcatenationImageFolderPathTextBox;
        private Label label23;
        private Label label24;
        private ComboBox ConnectionDirectionComboBox;
        private Label label25;
        private NumericUpDown ConnectionCountNumericUpDown;
        private FolderBrowserDialog ScreenShotSaveFolderBrowserDialog;
        private NumericUpDown CaptureCountNumericUpDown;
        private Label label12;
        private ToolTip LangFileFolderPathToolTip;
        private FolderBrowserDialog OCRImageFolderPathFolderBrowserDialog;
        private FolderBrowserDialog OCROutputFolderPathFolderBrowserDialog;
        private FolderBrowserDialog LangFileFolderPathFolderBrowserDialog;
        private SaveFileDialog OCRTextSaveFileDialog;
        private SaveFileDialog TestScreenShotSaveFileDialog;
        private SaveFileDialog PDFSaveFileDialog;
        private FolderBrowserDialog PDFImageFolderPathFolderBrowserDialog;
        private FolderBrowserDialog ConnectionImageSaveFolderBrowserDialog;
        private Label label6;
        private Label ImageConcatenationFileNameSampleLabel;
        private NumericUpDown ImageConcatenationFileNameSerialNumberNumericUpDown;
        private Label label13;
        private Label label9;
        private NumericUpDown WaitingTimeNumericUpDown;
        private Label label18;
        private ComboBox PressKeyComboBox;
        private Label label20;
        private Label label22;
        private Label label21;
        private RadioButton DuplicateCountRadioButton;
        private NumericUpDown DuplicateCountNumericUpDown;
        private Label label26;
        private RadioButton CaptureCountRadioButton;
    }
}
