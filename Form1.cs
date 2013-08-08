
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainToolBox;
namespace ProfileCopy
{
    public partial class Form1 : Form
    {
        private DomainTools adminTask;

        public Form1()
        {
            adminTask = new DomainTools();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void separatorLine_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void outlook_checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void oldComputer_txt_clicked(object sender, System.EventArgs e)
        {
            resetOldComputerFields();
        }
        private void newComputer_txt_clicked(object sender, System.EventArgs e)
        {
            resetNewComputerFields();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       
        private void testOldComputerConnection_Click(object sender, EventArgs e)
        {
            List<string> users = new List<string>();
            string oldComputer = oldComputer_txt.Text;
            string oldComputerVer;
            try
            {
                if (!oldComputer_txt.Text.Equals(""))
                {
                    if (adminTask.canConnect(oldComputer))
                    {
                        oldComputer_txt.BackColor = Color.LightGreen;
                        output_txt.AppendText("Connected to the old computer.\n");
                        oldComputerVer = adminTask.windowsVersion(oldComputer).ToString();
                        oldWindowsVer_txt.Text = oldComputerVer;
                        if (oldComputerVer.Contains("Microsoft Windows XP"))
                            users = Workstation.listUsersWindowsXp(oldComputer);
                        else
                            users = Workstation.listUsersWindows7(oldComputer);
                        foreach (string user in users)
                            oldUsersAccount_combo.Items.Add(user);
                    }
                    else
                    {
                        oldComputer_txt.BackColor = Color.Red;
                        output_txt.AppendText("Could not connect to the old computer.\n");
                    }
                }
                else
                    oldComputer_txt.BackColor = Color.Red;
            }
            catch (NullReferenceException f)
            {
                output_txt.AppendText(f.ToString());
            }
        }

        private void testNewComputerConnection_Click(object sender, EventArgs e)
        {
            string newComputer = newComputer_txt.Text;
            try
            {
                if (!newComputer_txt.Text.Equals(""))
                {
                    if (adminTask.canConnect(newComputer))
                    {
                        newComputer_txt.BackColor = Color.LightGreen;
                        output_txt.AppendText("Connected to the old computer.\n");
                        newWindowsVer_txt.Text = adminTask.windowsVersion(newComputer).ToString();
                        List<string> users = Workstation.listUsersWindows7(newComputer);
                        foreach (string user in users)
                            newUserAccount_combo.Items.Add(user);
                    }
                    else
                    {
                        newComputer_txt.BackColor = Color.Red;
                        output_txt.AppendText("Could not connect to the old computer.\n");
                    }
                }
                else
                    newComputer_txt.BackColor = Color.Red;
            }
            catch (NullReferenceException f)
            {
                output_txt.AppendText(f.ToString());
                
            }
        }

        private void resetOldComputerFields()
        {
            oldComputer_txt.BackColor = Color.White;
            oldComputer_txt.Text = "";
            oldUsersAccount_combo.Items.Clear();
            oldWindowsVer_txt.Text = "";
            oldUsersAccount_combo.Items.Clear();
            oldUsersAccount_combo.Text = "";
           
        }

        private void resetNewComputerFields()
        {
            newComputer_txt.BackColor = Color.White;
            newComputer_txt.Text = "";
            newUserAccount_combo.Items.Clear();
            newWindowsVer_txt.Text = "";
            newUserAccount_combo.Items.Clear();
            newUserAccount_combo.Text = "";
        }


        private void doCopy()
        {
            if(desktopIsChecked())
                copyDesktop();
            if (outlookIsChecked())
                copyOutlook();
            if (favoritesIsChecked())
                copyFavorites();
            if (signaturesIsChecked())
                copySignatures();
        }

        private void copy_btn_Click(object sender, EventArgs e)
        {
            doCopy();
            output_txt.AppendText(desktopIsChecked().ToString());
        }

        private bool desktopIsChecked()
        {
            if (desktop_checkBox.Checked)
                return true;
            else
                return false;
        }
        private bool outlookIsChecked()
        {
            if (outlook_checkBox.Checked)
                return true;
            else
                return false;
        }
        private bool signaturesIsChecked()
        {
            if (signatures_checkBox.Checked)
                return true;
            else
                return false;
        }
        private bool favoritesIsChecked()
        {
            if (favorites_checkBox.Checked)
                return true;
            else
                return false;
        }
        private bool forceOverwriteIsChecked()
        {
            if (forceOverwrite_checkBox.Checked)
                return true;
            else
                return false;
        }

        private bool copyDesktop()
        {
            Copy(oldUsersAccount_combo.SelectedItem.ToString() + @"\Desktop", newUserAccount_combo.SelectedItem.ToString() + @"\Desktop", forceOverwriteIsChecked());
            return true;
        }

        private bool copyFavorites()
        {
            Copy(oldUsersAccount_combo.SelectedItem.ToString() + @"\Favorites", newUserAccount_combo.SelectedItem.ToString() + @"\Favorites", forceOverwriteIsChecked());
            return true;
        }
        private bool copySignatures()
        {
            string oldComputerVer = oldWindowsVer_txt.Text;
            string newComputerVer = newWindowsVer_txt.Text;
            if (oldComputerVer.Contains("Microsoft Windows XP") && newComputerVer.Contains("Microsoft Windows XP"))
                Copy(oldUsersAccount_combo.SelectedItem.ToString() + @"\\Application Data\Microsoft\Signatures", newUserAccount_combo.SelectedItem.ToString() + @"\\Application Data\Microsoft\Signatures", forceOverwriteIsChecked());
            else if (oldComputerVer.Contains("Microsoft Windows XP"))
                Copy(oldUsersAccount_combo.SelectedItem.ToString() + @"\\Application Data\Microsoft\Signatures", newUserAccount_combo.SelectedItem.ToString() + @"\\AppData\Roaming\Microsoft\Signatures", forceOverwriteIsChecked());
            else
                Copy(oldUsersAccount_combo.SelectedItem.ToString() + @"\\AppData\Roaming\Microsoft\Signatures", newUserAccount_combo.SelectedItem.ToString() + @"\\AppData\Roaming\Microsoft\Signatures", forceOverwriteIsChecked());

            return true;
        }

        private bool copyOutlook()
        {
            string oldComputerVer = oldWindowsVer_txt.Text;
            string newComputerVer = newWindowsVer_txt.Text;
            if (oldComputerVer.Contains("Microsoft Windows XP") && newComputerVer.Contains("Microsoft Windows XP"))
                Copy(oldUsersAccount_combo.SelectedItem.ToString() + @"\\Application Data\Microsoft\Outlook", newUserAccount_combo.SelectedItem.ToString() + @"\\Application Data\Microsoft\Outlook", forceOverwriteIsChecked());
            else if (oldComputerVer.Contains("Microsoft Windows XP"))
                Copy(oldUsersAccount_combo.SelectedItem.ToString() + @"\\Application Data\Microsoft\Outlook", newUserAccount_combo.SelectedItem.ToString() + @"\\AppData\Roaming\Microsoft\Outlook", forceOverwriteIsChecked());
            else
                Copy(oldUsersAccount_combo.SelectedItem.ToString() + @"\\AppData\Roaming\Microsoft\Outlook", newUserAccount_combo.SelectedItem.ToString() + @"\\AppData\Roaming\Microsoft\Outlook", forceOverwriteIsChecked());

            return true;
        }

        public void Copy(string from, string to, bool overwrite)
        {
            /*
             *  Verify from and to exists
             */
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(from);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + from);
            }

            // If the destination directory doesn't exist, create it. 
            if (!Directory.Exists(to))
            {
                Directory.CreateDirectory(to);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(to, file.Name);
                try
                {
                    file.CopyTo(temppath, overwrite);
                    output_txt.AppendText(file.Name + "\n");
                }
                catch (System.IO.IOException e)
                {
                    continue;
                }
            }


            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(to, subdir.Name);
                Copy(subdir.FullName, temppath, overwrite);
            }


        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            resetNewComputerFields();
            resetOldComputerFields();
            output_txt.Clear();
            desktop_checkBox.CheckState = CheckState.Unchecked;
            favorites_checkBox.CheckState = CheckState.Unchecked;
            outlook_checkBox.CheckState = CheckState.Unchecked;
            signatures_checkBox.CheckState = CheckState.Unchecked;
            forceOverwrite_checkBox.CheckState = CheckState.Unchecked;
            forceOverwrite_checkBox.CheckState = CheckState.Unchecked;

        }

    }
}

