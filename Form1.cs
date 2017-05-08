using ComicVineLibrary.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace ComicSerializer_Test
{
    public partial class Form1 : Form
    {
        ComicVineVolume volume = new ComicVineVolume();
        ComicVineIssue issue = new ComicVineIssue();
        FileInfo info = new FileInfo();

        string FilePath = "";
        string LibraryPath = "";

        apiTools api = new apiTools(Properties.Resources.apiKey);

        public Form1()
        {
            InitializeComponent();
        }

        //reset all fields
        public void clearForm()
        {
            //reset textboxes
            tbDownloadURL.Text = "";
            tbFilePath.Text = "";
            wbIssueDescription.DocumentText = "";
            tbIssueNumber.Text = "";
            tbIssueYear.Text = "";
            tbMD5Hash.Text = "";
            tbTranslator.Text = "";
            tbVlCountIssues.Text = "";
            tbVlName.Text = "";
            tbVlStartYear.Text = "";
            wbVolumeDesription.DocumentText = "";

            //reset comboboxes
            cbPublishers.SelectedItem = cbPublishers.Items[0];
            cbIssueLanguage.SelectedItem = cbIssueLanguage.Items[0];
            cbIssueMonth.SelectedItem = cbIssueMonth.Items[0];

            //rest link labels
            llbIssueCoverURL.Text = "URL";
            llbVlCoverURL.Text = "URL";

            pbCover.Image = Properties.Resources.defaultCover;
        }

        public void getComicsInfo()
        {
            string vol_name = DataManager.getVolumeNameFromFileName(FilePath);
            int issue_number = DataManager.getIssueNumberFromFileName(FilePath);

            //check if volume info file already exist
            string dir = DataManager.checkVolumeInfoFileExist(LibraryPath, vol_name);
            if (dir != null)
                volume = DataManager.getVolumeInfoFromFile(dir, vol_name);
            else
            {
                try
                {
                    volume = api.getVolumeByName(vol_name);
                }
                catch { }
            }
            //check if issue info file already exist
            dir = DataManager.checkIssueInfoFileExist(LibraryPath, vol_name, issue_number);
            if (dir != null)
                issue = DataManager.getIssueInfoFromFile(dir, vol_name, issue_number);
            else
            {
                try
                {
                    issue = api.getIssueByName(vol_name, issue_number);
                }
                catch { }
            }
            info.id = issue != null ? issue.id : 0;
            info.md5hash = DataManager.checkMD5(FilePath);
        }

        public void fillInfoInThread()
        {
            getComicsInfo();
            if (volume != null)
            {
                tbVlCountIssues.Invoke(new Action(() => tbVlCountIssues.Text = volume.count_of_issues.ToString()));
                wbIssueDescription.Invoke(new Action(() => wbVolumeDesription.DocumentText = volume.volume_description));
                tbVlName.Invoke(new Action(() => tbVlName.Text = volume.name));
                tbVlStartYear.Invoke(new Action(() => tbVlStartYear.Text = volume.start_year.ToString()));
                cbPublishers.Invoke(new Action(() => cbPublishers.Text = volume.publisher.publisher_name));
                llbVlCoverURL.Invoke(new Action(() => llbVlCoverURL.Text = volume.images.super_url));

                wbVolumeDesription.Invoke(new Action(() => wbVolumeDesription.DocumentText = volume.volume_description));
            }
            if (issue != null)
            {
                wbIssueDescription.Invoke(new Action(() => wbIssueDescription.DocumentText = issue.issue_description));
                tbIssueNumber.Invoke(new Action(() => tbIssueNumber.Text = issue.issue_number));
                tbIssueYear.Invoke(new Action(() => tbIssueYear.Text = issue.issue_year.ToString()));
                cbIssueMonth.Invoke(new Action(() => cbIssueMonth.SelectedItem = cbIssueMonth.Items[issue.issue_month - 1]));
                llbIssueCoverURL.Invoke(new Action(() => llbIssueCoverURL.Text = issue.images.super_url));

                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.Headers.Set(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.99 Safari/537.36");
                        client.DownloadFile(new Uri(issue.images.thumb_url), "thumb.jpeg");
                        pbCover.Invoke(new Action(() => pbCover.Image = Image.FromFile("thumb.jpeg")));
                    }
                }
                catch { }
            }
            tbMD5Hash.Invoke(new Action(() => tbMD5Hash.Text = info.md5hash));
        }

        public void fillFields()
        {
            if (volume != null)
            {
                tbVlCountIssues.Text = volume.count_of_issues.ToString();
                wbVolumeDesription.DocumentText = volume.volume_description;
                tbVlName.Text = volume.name;
                tbVlStartYear.Text = volume.start_year.ToString();
                cbPublishers.Text = volume.publisher.publisher_name;
                llbVlCoverURL.Text = volume.images.super_url;

                wbVolumeDesription.DocumentText = volume.volume_description;
            }
            if (issue != null)
            {
                wbIssueDescription.DocumentText = issue.issue_description;
                tbIssueNumber.Text = issue.issue_number;
                tbIssueYear.Text = issue.issue_year.ToString();
                cbIssueMonth.SelectedItem = cbIssueMonth.Items[issue.issue_month - 1];
                llbIssueCoverURL.Text = issue.images.super_url;

                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.Headers.Set(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.99 Safari/537.36");
                        client.DownloadFile(new Uri(issue.images.thumb_url), "thumb.jpeg");
                        pbCover.Image = Image.FromFile("thumb.jpeg");
                    }
                }
                catch { }
            }
            tbMD5Hash.Text = info.md5hash;
        }

        public void getInfoToFields()
        {
            getComicsInfo();
            fillFields();
        }

        //read all fields
        public void readFields()
        {
            //fill volume
            volume.name = tbVlName.Text;
            volume.publisher.publisher_name = cbPublishers.Text;
            volume.volume_description = wbVolumeDesription.DocumentText;
            volume.start_year = Convert.ToInt32(tbVlStartYear.Text);
            volume.count_of_issues = Convert.ToInt32(tbVlCountIssues.Text);

            //fill issue
            issue.issue_number = tbIssueNumber.Text;
            issue.issue_year = Convert.ToInt32(tbIssueYear.Text);
            issue.issue_month = cbIssueMonth.SelectedIndex + 1;
            issue.issue_description = wbIssueDescription.DocumentText;

            //fill FileInfo
            info.language = cbIssueLanguage.Text;
            info.translator = info.language == "eng" ? "" : tbTranslator.Text;
            info.url_download = tbDownloadURL.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //files filter
            fdChooseFile.Filter = "Comics Files|*.cbr;*.cbz|All Files|*.*";

            //fill publishers comboBox
            foreach (var publ in Enum.GetValues(typeof(Publishers)))
                cbPublishers.Items.Add(publ.ToString());


            //fill languages comboBox
            foreach (var lang in Enum.GetValues(typeof(Languages)))
                cbIssueLanguage.Items.Add(lang.ToString());

            //get library path from settings
            LibraryPath = Properties.Settings.Default.libPath;
            tbLibPath.Text = LibraryPath;

            clearForm();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        //choose File Path
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (LibraryPath == "")
                MessageBox.Show("Insert Library Path first!");
            else
            {
                var openResult = fdChooseFile.ShowDialog();

                if (openResult == DialogResult.OK)
                {
                    clearForm();
                    FilePath = fdChooseFile.FileName;
                    tbFilePath.Text = FilePath;

                    //getInfoToFields();

                    ThreadStart thr = new ThreadStart(fillInfoInThread);
                    Thread thr1 = new Thread(thr);
                    thr1.Start();
                    //fillFields();
                }
            }
        }

        //choose Library Path
        private void btnBrowseLibrary_Click(object sender, EventArgs e)
        {
            var openResult = fbLibPath.ShowDialog();

            if (openResult == DialogResult.OK)
            {
                LibraryPath = fbLibPath.SelectedPath;
                tbLibPath.Text = LibraryPath;
            }
        }

        private void cbIssueLanguage_TextChanged(object sender, EventArgs e)
        {
            if (cbIssueLanguage.Text == "en")
                tbTranslator.Enabled = false;
            else
                tbTranslator.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            try
            {
                readFields();
                try
                {
                    if (DataManager.checkVolumeInfoFileExist(LibraryPath, volume.name) == null)
                        DataManager.createVolumeInfoFile(LibraryPath, volume);

                    if (DataManager.checkIssueInfoFileExist(LibraryPath, volume.name, int.Parse(issue.issue_number)) == null)
                        DataManager.createIssueInfoFile(LibraryPath, volume, issue);

                    DataManager.createFileInfoFile(LibraryPath, volume, issue, info);
                }
                catch
                {
                    MessageBox.Show("I can`t save file.");
                }
                MessageBox.Show("Done.");
            }
            catch
            {
                MessageBox.Show("Fill all fields.");
            }
        }

        private void tbLibPath_TextChanged(object sender, EventArgs e)
        {
            if (tbLibPath.Text != "")
            {
                Properties.Settings.Default.libPath = LibraryPath;
                Properties.Settings.Default.Save();
            }
        }

        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(((LinkLabel)sender).Text);
        }

        private void btnSearchByNameAndNumber_Click(object sender, EventArgs e)
        {
            ThreadStart thr = new ThreadStart(fillInfoInThread);
            Thread thr1 = new Thread(thr);
            thr1.Start();

            //getInfoToFields();
        }
    }
}
