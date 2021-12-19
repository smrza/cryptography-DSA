using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            panelIntro.Visible = false;
            panelFunctionality.Visible = true;
            this.KeyPress -= new KeyPressEventHandler(MainForm_KeyPress);
        }

        RSA rsa;
        int bitLength = 512; //default key value
        string pathToWorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); //default working directory
        string pathToPublicKeys = ""; //full path to public keys
        string pathToPrivateKeys = ""; //full path to private keys
        string pathToFile = ""; //full path original file
        string nameOfFileToSign = ""; //filename with extension
        string pathMsgFile = ""; //full path of .msg file (open message)
        string pathSignFile = ""; //full path of .sign file
        string pathZipFile = ""; //full path of working zip file
        string sha256OfFile = ""; //hash

        private void ButtonSignatureFunctionality_Click(object sender, EventArgs e)
        {
            panelFunctionality.Visible = false;
            panelKeysGeneration.Visible = true;
        }

        private void ButtonVerificationFunctionality_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please, select a .pub containing public keys.", "Select .pub", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPublicKeysFile();
                if (pathToPublicKeys != "")
                {
                    string[] publicKeysFile = File.ReadAllText(pathToPublicKeys).Split(' ');
                    try
                    {
                        rsa = new RSA(BigInteger.Parse(publicKeysFile[1]), BigInteger.Parse(publicKeysFile[0]));
                        MessageBox.Show("Please, select a .zip containing files for verification.", "Select .zip", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        VerifyMessage();
                        Reset();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Incorrect format for keys. Wrong file or empty?" + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    pathToPublicKeys = "";
                }
                else MessageBox.Show("You did not select any file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong, please try again!" + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonImportKeys_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please, load your .pub file containing public keys.", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPublicKeysFile();
                MessageBox.Show("Please, load your .pri file containing private keys.", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPrivateKeysFile();

                if(pathToPrivateKeys == "" || pathToPublicKeys == "")
                {
                    MessageBox.Show("No file chosen for either public/private keys. Please try again and make sure to select both files this time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] publicKeysFile = File.ReadAllText(pathToPublicKeys).Split(' ');
                    string[] privateKeysFile = File.ReadAllText(pathToPrivateKeys).Split(' ');

                    try
                    {
                        rsa = new RSA(BigInteger.Parse(privateKeysFile[0]), BigInteger.Parse(privateKeysFile[1]), BigInteger.Parse(publicKeysFile[1]));
                        panelKeysGeneration.Visible = false;
                        panelSign.Visible = true;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Incorrect format for keys. Wrong file or empty?" + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong, please try again!" + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAutoGenerateKeys_Click(object sender, EventArgs e)
        {
            panelKeysGeneration.Visible = false;
            panelKeysSize.Visible = true;
        }

        private void ButtonGenerateKeyContinue_Click(object sender, EventArgs e)
        {
            rsa = new RSA(bitLength);
            panelKeysSize.Visible = false;
            panelSign.Visible = true;
        }

        private void ButtonSignTXT_Click(object sender, EventArgs e)
        {
            try
            {
                LoadFileTXT();
                if (pathToFile == "")
                {
                    MessageBox.Show("Failed to load file. Please, try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sha256OfFile = GetSHA256OfFile(pathToFile);
                    WriteKeysToFiles();
                    WriteOpenMessageToFile();
                    WriteEncryptedMessageToFile();
                    CompressToZipTXT();
                    pathToFile = "";
                    labelFileExtension.Visible = true;
                    labelNameOfFile.Visible = true;
                    labelPathOfFile.Visible = true;
                    labelDateOfCreation.Visible = true;
                    label12.Visible = false;
                    MessageBox.Show("File signed.", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong. Please try again!" + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSign_Click(object sender, EventArgs e)
        {
            try
            {
                LoadFile();
                if(pathToFile == "")
                {
                    MessageBox.Show("Failed to load file. Please, try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sha256OfFile = GetSHA256OfFile(pathToFile);
                    WriteKeysToFiles();
                    WriteEncryptedMessageToFile();
                    CompressToZip();
                    pathToFile = "";
                    labelFileExtension.Visible = true;
                    labelNameOfFile.Visible = true;
                    labelPathOfFile.Visible = true;
                    labelDateOfCreation.Visible = true;
                    label12.Visible = false;
                    MessageBox.Show("File signed.", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong. Please try again!" + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void WriteKeysToFiles()
        {
            try
            {
                string pathPri = $"{pathToWorkingDirectory}\\private_keys_{DateTime.Now.ToString("MM/dd/yyyy/HH/mm/ss")}.pri";
                string pathPub = $"{pathToWorkingDirectory}\\public_keys_{DateTime.Now.ToString("MM/dd/yyyy/HH/mm/ss")}.pub";
                File.WriteAllText(pathPri, $"{rsa.n} {rsa.d}");
                File.WriteAllText(pathPub, $"{rsa.n} {rsa.e}");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong while writing your keys. Please try again!" + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetSHA256OfFile(string path)
        {
            try
            {
                FileStream fileStream = File.OpenRead(path);
                SHA256Managed sha256Managed = new SHA256Managed();
                byte[] byteArraySHA256 = sha256Managed.ComputeHash(fileStream);

                fileStream.Close();
                sha256Managed.Clear();

                return BitConverter.ToString(byteArraySHA256).Replace("-", String.Empty).ToLower();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong: " + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return "Something went wrong.";
        }

        public void CompressToZip()
        {
            string pathDirectory = $"{pathToWorkingDirectory}\\zipFile_{DateTime.Now.ToString("MM/dd/yyyy/HH/mm/ss")}";

            if (Directory.Exists(pathDirectory) == true)
            {
                Directory.Delete(pathDirectory, true);
                Directory.CreateDirectory(pathDirectory);
            }
            else Directory.CreateDirectory(pathDirectory);

            File.Copy(pathToFile, $"{pathDirectory}\\{nameOfFileToSign}");
            File.Move(pathToWorkingDirectory + pathSignFile, pathDirectory + pathSignFile);
            ZipFile.CreateFromDirectory(pathDirectory, $"{pathToWorkingDirectory}\\zipedFiles_{DateTime.Now.ToString("MM/dd/yyyy/HH/mm/ss")}.zip");

            Directory.Delete(pathDirectory, true);
        }

        public void CompressToZipTXT()
        {
            string pathDirectory = $"{pathToWorkingDirectory}\\zipFile_{DateTime.Now.ToString("MM/dd/yyyy/HH/mm/ss")}";

            if (Directory.Exists(pathDirectory) == true)
            {
                Directory.Delete(pathDirectory, true);
                Directory.CreateDirectory(pathDirectory);
            }
            else Directory.CreateDirectory(pathDirectory);

            File.Move(pathToWorkingDirectory + pathSignFile, pathDirectory + pathSignFile);
            File.Move(pathToWorkingDirectory + pathMsgFile, pathDirectory + pathMsgFile);
            ZipFile.CreateFromDirectory(pathDirectory, $"{pathToWorkingDirectory}\\zipedFiles_{DateTime.Now.ToString("MM/dd/yyyy/HH/mm/ss")}.zip");

            Directory.Delete(pathDirectory, true);
        }

        public void WriteOpenMessageToFile()
        {
            pathMsgFile = $"\\open_message_{DateTime.Now.ToString("MM/dd/yyyy/HH/mm/ss")}.msg";
            File.WriteAllText(pathToWorkingDirectory + pathMsgFile, File.ReadAllText(pathToFile));
        }

        public void WriteEncryptedMessageToFile()
        {
            pathSignFile = $"\\sign_message_{DateTime.Now.ToString("MM/dd/yyyy/HH/mm/ss")}.sign";
            File.WriteAllText(pathToWorkingDirectory + pathSignFile, rsa.Sign(sha256OfFile));
        }

        public void VerifyMessage()
        {
            LoadZipFile();
            string unzippedDirectory = $"{pathToWorkingDirectory}\\workingZip_{DateTime.Now.ToString("MM/dd/yyyy/HH/mm/ss")}";

            if(pathZipFile == "")
            {
                MessageBox.Show("No .zip chosen. Please, try again!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ZipFile.ExtractToDirectory(pathZipFile, unzippedDirectory);
                string[] file = Directory.GetFiles(unzippedDirectory);

                string pathSignedFile = "";
                string pathOriginalFile = "";

                try
                {
                    foreach (var item in file)
                    {
                        if (item.Length > 5)
                        {
                            if (item.Substring(item.Length - 5) == ".sign")
                            {
                                pathSignedFile = item;
                            }
                            else pathOriginalFile = item;
                        }
                    }

                    if (rsa.Verify(GetSHA256OfFile(pathOriginalFile), File.ReadAllText(pathSignedFile)) == true)
                    {
                        MessageBox.Show("Message transmitted correctly. WELL DONE!", "ALL GOOD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Error! Message has been modified! Be careful, the file has been compromised! You are in danger. Turn the computer off immediately!!! Don't ever use internety again!", "DANGER!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Something went wrong, most likely wrong .zip chosen." + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                pathZipFile = "";
                Directory.Delete(unzippedDirectory, true);
            }     
        }

        private void Reset()
        {
            rsa = new RSA(); //reset RSA
            bitLength = 512; //default key value
            pathToWorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); //default working directory
            pathToPublicKeys = ""; //full path to public keys
            pathToPrivateKeys = ""; //full path to private keys
            pathToFile = ""; //full path original file
            nameOfFileToSign = ""; //filename with extension
            pathMsgFile = ""; //full path of .msg file (open message)
            pathSignFile = ""; //full path of .sign file
            pathZipFile = ""; //full path of working zip file
            sha256OfFile = ""; //hash
        }

        private void LoadPublicKeysFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Public Keys(*.pub) | *.pub";
            openFile.Title = "Please select a file";
            openFile.FilterIndex = 1;
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            openFile.InitialDirectory = pathToWorkingDirectory;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pathToPublicKeys = openFile.FileName;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Something went wrong, please try again!" + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadPrivateKeysFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Private Keys(*.pri) | *.pri";
            openFile.Title = "Please select a file";
            openFile.FilterIndex = 1;
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            openFile.InitialDirectory = pathToWorkingDirectory;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pathToPrivateKeys = openFile.FileName;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Something went wrong, please try again!" + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadFileTXT()
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files(*.txt) | *.txt";
            openFile.Title = "Please select a file";
            openFile.FilterIndex = 1;
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            openFile.InitialDirectory = pathToWorkingDirectory;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    nameOfFileToSign = openFile.SafeFileName;
                    labelNameOfFile.Text = "Name of file: " + nameOfFileToSign;
                    labelPathOfFile.Text = "Path: " + openFile.FileName;
                    labelFileExtension.Text = "Extension: " + Path.GetExtension(openFile.FileName);
                    labelDateOfCreation.Text = "Date modified: " + Convert.ToString(File.GetCreationTime(openFile.FileName));
                    pathToFile = openFile.FileName;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Something went wrong, please try again!" + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadZipFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Zip(*.zip) | *.zip";
            openFile.Title = "Please select a file";
            openFile.FilterIndex = 1;
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            openFile.InitialDirectory = pathToWorkingDirectory;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pathZipFile = openFile.FileName;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Something went wrong, please try again!" + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "All files(*.*) | *.*";
            openFile.Title = "Please select a file";
            openFile.FilterIndex = 1;
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            openFile.InitialDirectory = pathToWorkingDirectory;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    nameOfFileToSign = openFile.SafeFileName;
                    labelNameOfFile.Text = "Name of file: " + nameOfFileToSign;
                    labelPathOfFile.Text = "Path: " + openFile.FileName;
                    labelFileExtension.Text = "Extension: " + Path.GetExtension(openFile.FileName);
                    labelDateOfCreation.Text = "Date modified: " + Convert.ToString(File.GetCreationTime(openFile.FileName));
                    pathToFile = openFile.FileName;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Something went wrong, please try again!" + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RadioButtonsCheckChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                bitLength = Convert.ToInt32(((RadioButton)sender).Text);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            panelSign.Visible = false;
            panelFunctionality.Visible = true;
            Reset();
        }
    }
}
