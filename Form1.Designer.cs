namespace ComicSerializer_Test
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbVlName = new System.Windows.Forms.TextBox();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.lbVlName = new System.Windows.Forms.Label();
            this.lbVlStartYear = new System.Windows.Forms.Label();
            this.tbVlStartYear = new System.Windows.Forms.TextBox();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.cbPublishers = new System.Windows.Forms.ComboBox();
            this.lbFilePath = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.fdChooseFile = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lbVlDesription = new System.Windows.Forms.Label();
            this.lbVlCountIssues = new System.Windows.Forms.Label();
            this.tbVlCountIssues = new System.Windows.Forms.TextBox();
            this.lbVlCoverURL = new System.Windows.Forms.Label();
            this.llbVlCoverURL = new System.Windows.Forms.LinkLabel();
            this.lbHR1 = new System.Windows.Forms.Label();
            this.lbIssueNumber = new System.Windows.Forms.Label();
            this.tbIssueNumber = new System.Windows.Forms.TextBox();
            this.lbIssueYear = new System.Windows.Forms.Label();
            this.tbIssueYear = new System.Windows.Forms.TextBox();
            this.cbIssueMonth = new System.Windows.Forms.ComboBox();
            this.lbIssueMonth = new System.Windows.Forms.Label();
            this.lbIssueDescription = new System.Windows.Forms.Label();
            this.llbIssueCoverURL = new System.Windows.Forms.LinkLabel();
            this.lbIssueCoverURL = new System.Windows.Forms.Label();
            this.lbHR2 = new System.Windows.Forms.Label();
            this.cbIssueLanguage = new System.Windows.Forms.ComboBox();
            this.lbIssueLanguage = new System.Windows.Forms.Label();
            this.lbTranslator = new System.Windows.Forms.Label();
            this.tbTranslator = new System.Windows.Forms.TextBox();
            this.lbMD5 = new System.Windows.Forms.Label();
            this.tbMD5Hash = new System.Windows.Forms.TextBox();
            this.lbHR3 = new System.Windows.Forms.Label();
            this.lbDownloadURL = new System.Windows.Forms.Label();
            this.tbDownloadURL = new System.Windows.Forms.TextBox();
            this.lbHR4 = new System.Windows.Forms.Label();
            this.lbLibPath = new System.Windows.Forms.Label();
            this.tbLibPath = new System.Windows.Forms.TextBox();
            this.btnBrowseLibrary = new System.Windows.Forms.Button();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.fbLibPath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.wbVolumeDesription = new System.Windows.Forms.WebBrowser();
            this.wbIssueDescription = new System.Windows.Forms.WebBrowser();
            this.btnSearchByNameAndNumber = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVlName
            // 
            this.tbVlName.Location = new System.Drawing.Point(165, 117);
            this.tbVlName.Name = "tbVlName";
            this.tbVlName.Size = new System.Drawing.Size(198, 20);
            this.tbVlName.TabIndex = 0;
            // 
            // pbCover
            // 
            this.pbCover.Image = global::ComicSerializer_Test.Properties.Resources.defaultCover;
            this.pbCover.Location = new System.Drawing.Point(8, 242);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(133, 164);
            this.pbCover.TabIndex = 1;
            this.pbCover.TabStop = false;
            // 
            // lbVlName
            // 
            this.lbVlName.AutoSize = true;
            this.lbVlName.Location = new System.Drawing.Point(166, 101);
            this.lbVlName.Name = "lbVlName";
            this.lbVlName.Size = new System.Drawing.Size(73, 13);
            this.lbVlName.TabIndex = 2;
            this.lbVlName.Text = "Volume Name";
            // 
            // lbVlStartYear
            // 
            this.lbVlStartYear.AutoSize = true;
            this.lbVlStartYear.Location = new System.Drawing.Point(9, 147);
            this.lbVlStartYear.Name = "lbVlStartYear";
            this.lbVlStartYear.Size = new System.Drawing.Size(88, 13);
            this.lbVlStartYear.TabIndex = 4;
            this.lbVlStartYear.Text = "Volume start year";
            // 
            // tbVlStartYear
            // 
            this.tbVlStartYear.Location = new System.Drawing.Point(8, 163);
            this.tbVlStartYear.Name = "tbVlStartYear";
            this.tbVlStartYear.Size = new System.Drawing.Size(129, 20);
            this.tbVlStartYear.TabIndex = 3;
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Location = new System.Drawing.Point(9, 100);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(50, 13);
            this.lbPublisher.TabIndex = 6;
            this.lbPublisher.Text = "Publisher";
            // 
            // cbPublishers
            // 
            this.cbPublishers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPublishers.FormattingEnabled = true;
            this.cbPublishers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbPublishers.Location = new System.Drawing.Point(8, 116);
            this.cbPublishers.Name = "cbPublishers";
            this.cbPublishers.Size = new System.Drawing.Size(129, 21);
            this.cbPublishers.TabIndex = 7;
            // 
            // lbFilePath
            // 
            this.lbFilePath.AutoSize = true;
            this.lbFilePath.Location = new System.Drawing.Point(13, 10);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(48, 13);
            this.lbFilePath.TabIndex = 9;
            this.lbFilePath.Text = "File Path";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(12, 26);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(635, 20);
            this.tbFilePath.TabIndex = 8;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(657, 23);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lbVlDesription
            // 
            this.lbVlDesription.AutoSize = true;
            this.lbVlDesription.Location = new System.Drawing.Point(398, 100);
            this.lbVlDesription.Name = "lbVlDesription";
            this.lbVlDesription.Size = new System.Drawing.Size(98, 13);
            this.lbVlDesription.TabIndex = 12;
            this.lbVlDesription.Text = "Volume Description";
            // 
            // lbVlCountIssues
            // 
            this.lbVlCountIssues.AutoSize = true;
            this.lbVlCountIssues.Location = new System.Drawing.Point(166, 147);
            this.lbVlCountIssues.Name = "lbVlCountIssues";
            this.lbVlCountIssues.Size = new System.Drawing.Size(122, 13);
            this.lbVlCountIssues.TabIndex = 14;
            this.lbVlCountIssues.Text = "Volume - count of issues";
            // 
            // tbVlCountIssues
            // 
            this.tbVlCountIssues.Location = new System.Drawing.Point(165, 163);
            this.tbVlCountIssues.Name = "tbVlCountIssues";
            this.tbVlCountIssues.Size = new System.Drawing.Size(198, 20);
            this.tbVlCountIssues.TabIndex = 13;
            // 
            // lbVlCoverURL
            // 
            this.lbVlCoverURL.AutoSize = true;
            this.lbVlCoverURL.Location = new System.Drawing.Point(9, 197);
            this.lbVlCoverURL.Name = "lbVlCoverURL";
            this.lbVlCoverURL.Size = new System.Drawing.Size(98, 13);
            this.lbVlCoverURL.TabIndex = 15;
            this.lbVlCoverURL.Text = "Volume Cover URL";
            // 
            // llbVlCoverURL
            // 
            this.llbVlCoverURL.AutoSize = true;
            this.llbVlCoverURL.Location = new System.Drawing.Point(9, 210);
            this.llbVlCoverURL.Name = "llbVlCoverURL";
            this.llbVlCoverURL.Size = new System.Drawing.Size(29, 13);
            this.llbVlCoverURL.TabIndex = 16;
            this.llbVlCoverURL.TabStop = true;
            this.llbVlCoverURL.Text = "URL";
            this.llbVlCoverURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lbHR1
            // 
            this.lbHR1.AutoSize = true;
            this.lbHR1.Location = new System.Drawing.Point(5, 226);
            this.lbHR1.Name = "lbHR1";
            this.lbHR1.Size = new System.Drawing.Size(730, 13);
            this.lbHR1.TabIndex = 17;
            this.lbHR1.Text = resources.GetString("lbHR1.Text");
            // 
            // lbIssueNumber
            // 
            this.lbIssueNumber.AutoSize = true;
            this.lbIssueNumber.Location = new System.Drawing.Point(148, 243);
            this.lbIssueNumber.Name = "lbIssueNumber";
            this.lbIssueNumber.Size = new System.Drawing.Size(72, 13);
            this.lbIssueNumber.TabIndex = 19;
            this.lbIssueNumber.Text = "Issue Number";
            // 
            // tbIssueNumber
            // 
            this.tbIssueNumber.Location = new System.Drawing.Point(147, 259);
            this.tbIssueNumber.Name = "tbIssueNumber";
            this.tbIssueNumber.Size = new System.Drawing.Size(198, 20);
            this.tbIssueNumber.TabIndex = 18;
            // 
            // lbIssueYear
            // 
            this.lbIssueYear.AutoSize = true;
            this.lbIssueYear.Location = new System.Drawing.Point(148, 287);
            this.lbIssueYear.Name = "lbIssueYear";
            this.lbIssueYear.Size = new System.Drawing.Size(57, 13);
            this.lbIssueYear.TabIndex = 21;
            this.lbIssueYear.Text = "Issue Year";
            // 
            // tbIssueYear
            // 
            this.tbIssueYear.Location = new System.Drawing.Point(147, 303);
            this.tbIssueYear.Name = "tbIssueYear";
            this.tbIssueYear.Size = new System.Drawing.Size(198, 20);
            this.tbIssueYear.TabIndex = 20;
            // 
            // cbIssueMonth
            // 
            this.cbIssueMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIssueMonth.FormattingEnabled = true;
            this.cbIssueMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbIssueMonth.Location = new System.Drawing.Point(147, 345);
            this.cbIssueMonth.Name = "cbIssueMonth";
            this.cbIssueMonth.Size = new System.Drawing.Size(129, 21);
            this.cbIssueMonth.TabIndex = 23;
            // 
            // lbIssueMonth
            // 
            this.lbIssueMonth.AutoSize = true;
            this.lbIssueMonth.Location = new System.Drawing.Point(148, 329);
            this.lbIssueMonth.Name = "lbIssueMonth";
            this.lbIssueMonth.Size = new System.Drawing.Size(65, 13);
            this.lbIssueMonth.TabIndex = 22;
            this.lbIssueMonth.Text = "Issue Month";
            // 
            // lbIssueDescription
            // 
            this.lbIssueDescription.AutoSize = true;
            this.lbIssueDescription.Location = new System.Drawing.Point(398, 243);
            this.lbIssueDescription.Name = "lbIssueDescription";
            this.lbIssueDescription.Size = new System.Drawing.Size(88, 13);
            this.lbIssueDescription.TabIndex = 25;
            this.lbIssueDescription.Text = "Issue Description";
            // 
            // llbIssueCoverURL
            // 
            this.llbIssueCoverURL.AutoSize = true;
            this.llbIssueCoverURL.Location = new System.Drawing.Point(259, 384);
            this.llbIssueCoverURL.Name = "llbIssueCoverURL";
            this.llbIssueCoverURL.Size = new System.Drawing.Size(29, 13);
            this.llbIssueCoverURL.TabIndex = 27;
            this.llbIssueCoverURL.TabStop = true;
            this.llbIssueCoverURL.Text = "URL";
            this.llbIssueCoverURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lbIssueCoverURL
            // 
            this.lbIssueCoverURL.AutoSize = true;
            this.lbIssueCoverURL.Location = new System.Drawing.Point(148, 384);
            this.lbIssueCoverURL.Name = "lbIssueCoverURL";
            this.lbIssueCoverURL.Size = new System.Drawing.Size(88, 13);
            this.lbIssueCoverURL.TabIndex = 26;
            this.lbIssueCoverURL.Text = "Issue Cover URL";
            // 
            // lbHR2
            // 
            this.lbHR2.AutoSize = true;
            this.lbHR2.Location = new System.Drawing.Point(5, 409);
            this.lbHR2.Name = "lbHR2";
            this.lbHR2.Size = new System.Drawing.Size(730, 13);
            this.lbHR2.TabIndex = 28;
            this.lbHR2.Text = resources.GetString("lbHR2.Text");
            // 
            // cbIssueLanguage
            // 
            this.cbIssueLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIssueLanguage.FormattingEnabled = true;
            this.cbIssueLanguage.Location = new System.Drawing.Point(8, 443);
            this.cbIssueLanguage.Name = "cbIssueLanguage";
            this.cbIssueLanguage.Size = new System.Drawing.Size(129, 21);
            this.cbIssueLanguage.TabIndex = 30;
            this.cbIssueLanguage.TextChanged += new System.EventHandler(this.cbIssueLanguage_TextChanged);
            // 
            // lbIssueLanguage
            // 
            this.lbIssueLanguage.AutoSize = true;
            this.lbIssueLanguage.Location = new System.Drawing.Point(9, 427);
            this.lbIssueLanguage.Name = "lbIssueLanguage";
            this.lbIssueLanguage.Size = new System.Drawing.Size(88, 13);
            this.lbIssueLanguage.TabIndex = 29;
            this.lbIssueLanguage.Text = "Isssue Language";
            // 
            // lbTranslator
            // 
            this.lbTranslator.AutoSize = true;
            this.lbTranslator.Location = new System.Drawing.Point(170, 428);
            this.lbTranslator.Name = "lbTranslator";
            this.lbTranslator.Size = new System.Drawing.Size(54, 13);
            this.lbTranslator.TabIndex = 32;
            this.lbTranslator.Text = "Translator";
            // 
            // tbTranslator
            // 
            this.tbTranslator.Location = new System.Drawing.Point(169, 444);
            this.tbTranslator.Name = "tbTranslator";
            this.tbTranslator.Size = new System.Drawing.Size(198, 20);
            this.tbTranslator.TabIndex = 31;
            // 
            // lbMD5
            // 
            this.lbMD5.AutoSize = true;
            this.lbMD5.Location = new System.Drawing.Point(9, 48);
            this.lbMD5.Name = "lbMD5";
            this.lbMD5.Size = new System.Drawing.Size(58, 13);
            this.lbMD5.TabIndex = 34;
            this.lbMD5.Text = "MD5 Hash";
            // 
            // tbMD5Hash
            // 
            this.tbMD5Hash.Location = new System.Drawing.Point(12, 64);
            this.tbMD5Hash.Name = "tbMD5Hash";
            this.tbMD5Hash.Size = new System.Drawing.Size(588, 20);
            this.tbMD5Hash.TabIndex = 33;
            // 
            // lbHR3
            // 
            this.lbHR3.AutoSize = true;
            this.lbHR3.Location = new System.Drawing.Point(9, 87);
            this.lbHR3.Name = "lbHR3";
            this.lbHR3.Size = new System.Drawing.Size(730, 13);
            this.lbHR3.TabIndex = 35;
            this.lbHR3.Text = resources.GetString("lbHR3.Text");
            // 
            // lbDownloadURL
            // 
            this.lbDownloadURL.AutoSize = true;
            this.lbDownloadURL.Location = new System.Drawing.Point(398, 428);
            this.lbDownloadURL.Name = "lbDownloadURL";
            this.lbDownloadURL.Size = new System.Drawing.Size(108, 13);
            this.lbDownloadURL.TabIndex = 37;
            this.lbDownloadURL.Text = "Issue Download URL";
            // 
            // tbDownloadURL
            // 
            this.tbDownloadURL.Location = new System.Drawing.Point(397, 444);
            this.tbDownloadURL.Name = "tbDownloadURL";
            this.tbDownloadURL.Size = new System.Drawing.Size(338, 20);
            this.tbDownloadURL.TabIndex = 36;
            // 
            // lbHR4
            // 
            this.lbHR4.AutoSize = true;
            this.lbHR4.Location = new System.Drawing.Point(5, 467);
            this.lbHR4.Name = "lbHR4";
            this.lbHR4.Size = new System.Drawing.Size(730, 13);
            this.lbHR4.TabIndex = 38;
            this.lbHR4.Text = resources.GetString("lbHR4.Text");
            // 
            // lbLibPath
            // 
            this.lbLibPath.AutoSize = true;
            this.lbLibPath.Location = new System.Drawing.Point(12, 498);
            this.lbLibPath.Name = "lbLibPath";
            this.lbLibPath.Size = new System.Drawing.Size(63, 13);
            this.lbLibPath.TabIndex = 40;
            this.lbLibPath.Text = "Library Path";
            // 
            // tbLibPath
            // 
            this.tbLibPath.Location = new System.Drawing.Point(11, 514);
            this.tbLibPath.Name = "tbLibPath";
            this.tbLibPath.Size = new System.Drawing.Size(444, 20);
            this.tbLibPath.TabIndex = 39;
            this.tbLibPath.TextChanged += new System.EventHandler(this.tbLibPath_TextChanged);
            // 
            // btnBrowseLibrary
            // 
            this.btnBrowseLibrary.Location = new System.Drawing.Point(461, 514);
            this.btnBrowseLibrary.Name = "btnBrowseLibrary";
            this.btnBrowseLibrary.Size = new System.Drawing.Size(75, 20);
            this.btnBrowseLibrary.TabIndex = 41;
            this.btnBrowseLibrary.Text = "Browse";
            this.btnBrowseLibrary.UseVisualStyleBackColor = true;
            this.btnBrowseLibrary.Click += new System.EventHandler(this.btnBrowseLibrary_Click);
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(649, 506);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(86, 36);
            this.btnSerialize.TabIndex = 42;
            this.btnSerialize.Text = "Save Info";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(540, 505);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 36);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // wbVolumeDesription
            // 
            this.wbVolumeDesription.Location = new System.Drawing.Point(397, 117);
            this.wbVolumeDesription.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbVolumeDesription.Name = "wbVolumeDesription";
            this.wbVolumeDesription.Size = new System.Drawing.Size(331, 107);
            this.wbVolumeDesription.TabIndex = 44;
            // 
            // wbIssueDescription
            // 
            this.wbIssueDescription.Location = new System.Drawing.Point(397, 259);
            this.wbIssueDescription.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbIssueDescription.Name = "wbIssueDescription";
            this.wbIssueDescription.Size = new System.Drawing.Size(331, 107);
            this.wbIssueDescription.TabIndex = 45;
            // 
            // btnSearchByNameAndNumber
            // 
            this.btnSearchByNameAndNumber.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearchByNameAndNumber.Location = new System.Drawing.Point(606, 52);
            this.btnSearchByNameAndNumber.Name = "btnSearchByNameAndNumber";
            this.btnSearchByNameAndNumber.Size = new System.Drawing.Size(126, 32);
            this.btnSearchByNameAndNumber.TabIndex = 46;
            this.btnSearchByNameAndNumber.Text = "Search info by\r\nName and Number";
            this.btnSearchByNameAndNumber.UseVisualStyleBackColor = true;
            this.btnSearchByNameAndNumber.Click += new System.EventHandler(this.btnSearchByNameAndNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 564);
            this.Controls.Add(this.btnSearchByNameAndNumber);
            this.Controls.Add(this.wbIssueDescription);
            this.Controls.Add(this.wbVolumeDesription);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.btnBrowseLibrary);
            this.Controls.Add(this.lbLibPath);
            this.Controls.Add(this.tbLibPath);
            this.Controls.Add(this.lbHR4);
            this.Controls.Add(this.lbDownloadURL);
            this.Controls.Add(this.tbDownloadURL);
            this.Controls.Add(this.lbHR3);
            this.Controls.Add(this.lbMD5);
            this.Controls.Add(this.tbMD5Hash);
            this.Controls.Add(this.lbTranslator);
            this.Controls.Add(this.tbTranslator);
            this.Controls.Add(this.cbIssueLanguage);
            this.Controls.Add(this.lbIssueLanguage);
            this.Controls.Add(this.lbHR2);
            this.Controls.Add(this.llbIssueCoverURL);
            this.Controls.Add(this.lbIssueCoverURL);
            this.Controls.Add(this.lbIssueDescription);
            this.Controls.Add(this.cbIssueMonth);
            this.Controls.Add(this.lbIssueMonth);
            this.Controls.Add(this.lbIssueYear);
            this.Controls.Add(this.tbIssueYear);
            this.Controls.Add(this.lbIssueNumber);
            this.Controls.Add(this.tbIssueNumber);
            this.Controls.Add(this.lbHR1);
            this.Controls.Add(this.llbVlCoverURL);
            this.Controls.Add(this.lbVlCoverURL);
            this.Controls.Add(this.lbVlCountIssues);
            this.Controls.Add(this.tbVlCountIssues);
            this.Controls.Add(this.lbVlDesription);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lbFilePath);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.cbPublishers);
            this.Controls.Add(this.lbPublisher);
            this.Controls.Add(this.lbVlStartYear);
            this.Controls.Add(this.tbVlStartYear);
            this.Controls.Add(this.lbVlName);
            this.Controls.Add(this.pbCover);
            this.Controls.Add(this.tbVlName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComicSerializer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVlName;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Label lbVlName;
        private System.Windows.Forms.Label lbVlStartYear;
        private System.Windows.Forms.TextBox tbVlStartYear;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.ComboBox cbPublishers;
        private System.Windows.Forms.Label lbFilePath;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.OpenFileDialog fdChooseFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lbVlDesription;
        private System.Windows.Forms.Label lbVlCountIssues;
        private System.Windows.Forms.TextBox tbVlCountIssues;
        private System.Windows.Forms.Label lbVlCoverURL;
        private System.Windows.Forms.LinkLabel llbVlCoverURL;
        private System.Windows.Forms.Label lbHR1;
        private System.Windows.Forms.Label lbIssueNumber;
        private System.Windows.Forms.TextBox tbIssueNumber;
        private System.Windows.Forms.Label lbIssueYear;
        private System.Windows.Forms.TextBox tbIssueYear;
        private System.Windows.Forms.ComboBox cbIssueMonth;
        private System.Windows.Forms.Label lbIssueMonth;
        private System.Windows.Forms.Label lbIssueDescription;
        private System.Windows.Forms.LinkLabel llbIssueCoverURL;
        private System.Windows.Forms.Label lbIssueCoverURL;
        private System.Windows.Forms.Label lbHR2;
        private System.Windows.Forms.ComboBox cbIssueLanguage;
        private System.Windows.Forms.Label lbIssueLanguage;
        private System.Windows.Forms.Label lbTranslator;
        private System.Windows.Forms.TextBox tbTranslator;
        private System.Windows.Forms.Label lbMD5;
        private System.Windows.Forms.TextBox tbMD5Hash;
        private System.Windows.Forms.Label lbHR3;
        private System.Windows.Forms.Label lbDownloadURL;
        private System.Windows.Forms.TextBox tbDownloadURL;
        private System.Windows.Forms.Label lbHR4;
        private System.Windows.Forms.Label lbLibPath;
        private System.Windows.Forms.TextBox tbLibPath;
        private System.Windows.Forms.Button btnBrowseLibrary;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.FolderBrowserDialog fbLibPath;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.WebBrowser wbVolumeDesription;
        private System.Windows.Forms.WebBrowser wbIssueDescription;
        private System.Windows.Forms.Button btnSearchByNameAndNumber;
    }
}

