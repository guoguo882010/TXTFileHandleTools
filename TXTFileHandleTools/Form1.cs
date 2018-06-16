using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace TXTFileHandleTools
{
    public partial class Form1 : Form
    {
        private string[] mergeFileNames = { };
        private string mergeTargetFile = "";
        private string dupSourceFile = "";
        private string dupTargetFile = "";
        private string domainSourceFile = "";
        private string domainTargetFile = "";


        public Form1()
        {
            InitializeComponent();
        }


        private void SelectMergeSourceFilesButton_Click(object sender, EventArgs e)
        {
         
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "Text files (*.txt)|*.txt";
            ofd.RestoreDirectory = true;
            ofd.FilterIndex = 1;
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                mergeFileNames = ofd.FileNames;
                MergeLabel.Text = mergeFileNames.Length.ToString() + " 个文件被选择";
            }

        }

        private void SelectMergeTargetFileButton_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Text files (*.txt)|*.txt";
            sfd.RestoreDirectory = true;
            sfd.FilterIndex = 1;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MergeTargetFileTextBox.Text = mergeTargetFile = sfd.FileName;
            }
        }

        private void MergeFileButton_Click(object sender, EventArgs e)
        {

            if (mergeTargetFile==""  || mergeFileNames.Length==0)
            {
                MessageBox.Show("目标文件，合并的文件必须选择");
            }
            else
            {

                MergeTargetFileTextBox.Enabled = false;
                SelectMergeTargetFileButton.Enabled = false;
                SelectMergeSourceFilesButton.Enabled = false;
                MergeFileButton.Enabled = false;

                Task.Factory.StartNew(() => {
                    List<string> all = new List<string>();
                    foreach (var item in mergeFileNames)
                    {
                        string[] readText = File.ReadAllLines(item, Encoding.UTF8);
                        all.AddRange(readText.ToList<string>());
                    }
                    //Distinct会删除重复项
                    //all = all.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
                    all = all.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

                    File.WriteAllLines(mergeTargetFile, all, Encoding.UTF8);
                    all.Clear();
                }).ContinueWith(t => {

                    this.Invoke((MethodInvoker)delegate {
                        MergeTargetFileTextBox.Enabled = true;
                        SelectMergeTargetFileButton.Enabled = true;
                        SelectMergeSourceFilesButton.Enabled = true;
                        MergeFileButton.Enabled = true;
                    });

                });

            }

        }

        private void MergeTargetFileTextBox_TextChanged(object sender, EventArgs e)
        {
            mergeTargetFile = MergeTargetFileTextBox.Text.Trim();
        }

        private void DupButton_Click(object sender, EventArgs e)
        {
            if (dupTargetFile == "" || dupSourceFile =="")
            {
                MessageBox.Show("源文件，目标文件必须选择");
            }
            else
            {
                DupSourceFileButton.Enabled = false;
                DupTargetFileButton.Enabled = false;
                DupSourceFileTextBox.Enabled = false;
                DupTargetFileTextBox.Enabled = false;
                DupButton.Enabled = false;

                Task.Factory.StartNew(() => {

                    string[] all = File.ReadAllLines(dupSourceFile, Encoding.UTF8);

                    //移除空字符
                    all = all.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

                    // 移除重复
                    HashSet<string> hs = new HashSet<string>(all.ToList<string>());

                    File.WriteAllLines(dupTargetFile, hs, Encoding.UTF8);

                    Array.Clear(all, 0, all.Length);
                    hs.Clear();
                    

                }).ContinueWith(t => {

                    this.Invoke((MethodInvoker)delegate {
                        DupSourceFileButton.Enabled = true;
                        DupTargetFileButton.Enabled = true;
                        DupSourceFileTextBox.Enabled = true;
                        DupTargetFileTextBox.Enabled = true;
                        DupButton.Enabled = true;
                    });

                });
            }
            

        }

        private void DupSourceFileTextBox_TextChanged(object sender, EventArgs e)
        {
            dupSourceFile = DupSourceFileTextBox.Text.Trim();
        }

        private void DupTargetFileTextBox_TextChanged(object sender, EventArgs e)
        {
            dupTargetFile = DupTargetFileTextBox.Text.Trim();
        }

        private void DupSourceFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "Text files (*.txt)|*.txt";
            ofd.RestoreDirectory = true;
            ofd.FilterIndex = 1;
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DupSourceFileTextBox.Text = dupSourceFile = ofd.FileName;
            }
        }

        private void DupTargetFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Text files (*.txt)|*.txt";
            sfd.RestoreDirectory = true;
            sfd.FilterIndex = 1;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DupTargetFileTextBox.Text = dupTargetFile = sfd.FileName;
            }
        }


        private void DomainSourceButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "Text files (*.txt)|*.txt";
            ofd.RestoreDirectory = true;
            ofd.FilterIndex = 1;
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DomainSourceTextBox.Text = domainSourceFile = ofd.FileName;
            }
        }

        private void DomainTargetButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Text files (*.txt)|*.txt";
            sfd.RestoreDirectory = true;
            sfd.FilterIndex = 1;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DomainTargetTextBox.Text = domainTargetFile = sfd.FileName;
            }
        }

        private void DomainSourceTextBox_TextChanged(object sender, EventArgs e)
        {
            domainSourceFile = DomainSourceTextBox.Text.Trim();
        }

        private void DomainTargetTextBox_TextChanged(object sender, EventArgs e)
        {
            domainTargetFile = DomainTargetTextBox.Text.Trim();
        }

        private void DomainButton_Click(object sender, EventArgs e)
        {

            if (domainTargetFile == "" || domainSourceFile == "")
            {
                MessageBox.Show("源文件，目标文件必须选择");
            }
            else
            {

                DomainSourceButton.Enabled = false;
                DomainTargetButton.Enabled = false;
                DomainSourceTextBox.Enabled = false;
                DomainTargetTextBox.Enabled = false;
                DomainButton.Enabled = false;

                Task.Factory.StartNew(() =>
                {

                    string[] all = File.ReadAllLines(domainSourceFile, Encoding.UTF8);

                    all = all.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

                    Parallel.For(0, all.Length, (i) =>
                    {

                        all[i] = ExtractDomainFromURL(all[i]);

                    });

                    all = all.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToArray();
                    File.WriteAllLines(domainTargetFile, all, Encoding.UTF8);
                    Array.Clear(all, 0, all.Length);

                }).ContinueWith(t =>
                {

                    this.Invoke((MethodInvoker)delegate
                    {
                        DomainSourceButton.Enabled = true;
                        DomainTargetButton.Enabled = true;
                        DomainSourceTextBox.Enabled = true;
                        DomainTargetTextBox.Enabled = true;
                        DomainButton.Enabled = true;
                    });

                });
            }
        }

        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }


        public static string ExtractDomainFromURL(string Url)
        {

            if (!Url.Contains("http://") && !Url.Contains("https://"))
                return "";

            try
            {
                Uri url = new Uri(Url);

                return url.Scheme + "://" + url.Host;
            }
            catch (Exception)
            {
                return "";
            }
           
        }

    }
}
