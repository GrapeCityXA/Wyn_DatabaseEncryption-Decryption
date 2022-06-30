using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBStringDecrypter_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("DragEnter!");
            e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void txtEodsFile_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data is string[])
            {
                var path = (data as string[])[0];
                FileInfo f = new FileInfo(path);
                txtEodsFile.Text = f.FullName;
            }
            else
            {
                MessageBox.Show($"Please drag the “eods.dll”{Environment.NewLine}Default location: C:\\Wyn Enterprise\\Tools\\EncryptOrDecryptString\\eods.dll");
            }
        }

        private void txtEodsFile_TextChanged(object sender, EventArgs e)
        {
            // 验证文件是否正确
            var isValidDll = ValidateFile();
            SetValidStyle(isValidDll);
        }

        private void SetValidStyle(bool styleType)
        {
            txtEodsFile.BackColor = styleType ? Color.LightGreen : Color.Yellow;
            txtDecrypted.Enabled = styleType;
            txtEncrypted.Enabled = styleType;
            btnDecrypt.Enabled = styleType;
            btnEncrypt.Enabled = styleType;
        }

        private bool ValidateFile()
        {
            var result = runCommand(1, "174fg4gU0sy6hjahY8AgG3P7lmTNoCea/PkeTkZtLotNO4=");
            return result.Trim().Equals("Decrypted String: testString");
        }
        string runCommand(int operationType, string code)
        {
            //* Create your Process
            Process process = new Process();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "dotnet";
            process.StartInfo.Arguments = $"\"{txtEodsFile.Text}\" {operationType} {code}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            //* Start process
            process.Start();
            //* Read one element asynchronously
            process.BeginErrorReadLine();
            //* Read the other one synchronously
            string output = process.StandardOutput.ReadToEnd();
            Debug.WriteLine(output);
            process.WaitForExit();
            return output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetValidStyle(false);
            Translate();
            TryGetDefaultPath();
        }

        private void TryGetDefaultPath()
        {
            if (File.Exists("C:\\Program Files\\Wyn Enterprise\\Tools\\EncryptOrDecryptString\\eods.dll"))
            {
                txtEodsFile.Text = "C:\\Program Files\\Wyn Enterprise\\Tools\\EncryptOrDecryptString\\eods.dll";
            }
        }

        private void Translate()
        {
            foreach (Control i in this.Controls)
            {
                if (!string.IsNullOrWhiteSpace(l18n_CN.ResourceManager.GetString(i.Name)))
                {
                    i.Text = l18n_CN.ResourceManager.GetString(i.Name);
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            var decruptResult = runCommand(1, txtEncrypted.Text);
            if (decruptResult.StartsWith("Decrypted String: "))
            {
                txtDecrypted.Text = decruptResult.Substring("Decrypted String: ".Length).Trim();
            }
            else
            {
                txtDecrypted.Text = decruptResult;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            var encryptResult = runCommand(0, txtDecrypted.Text);
            if (encryptResult.StartsWith("Encrypted String: "))
            {
                txtEncrypted.Text = encryptResult.Substring("Encrypted String: ".Length).Trim();
            }
            else
            {
                txtDecrypted.Text = encryptResult; 
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "eods.dll|eods.dll";
            var result = fd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEodsFile.Text = fd.FileName;
            }
        }
    }
}
