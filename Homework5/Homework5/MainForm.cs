using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Homework5
{
    public partial class MainForm : Form
    {
        private FileData data;
        private String oldText;

        
        public MainForm()
        {
            InitializeComponent();
            // Create FileData object using the default user settings
            data = new FileData(Properties.Settings.Default.ColorSetting, Properties.Settings.Default.FontSetting);

            // Set the file textbox settings
            updateFileTextBoxSettings();
            updateFontStatus();
        }

        //Updates the fontInfoStatus status bar
        private void updateFontStatus()
        {
            fontInfoStatus.Text = "Font: " + FileTextBox.Font.Name + ", Style: " + FileTextBox.Font.Style 
                + ", Size: " + FileTextBox.Font.Size;
        }

        //Updates the values of the Text box retriving the information from the data object
        private void updateFileTextBoxSettings()
        {
            this.FileTextBox.Text = this.data.FileText;
            this.FileTextBox.Font = this.data.TextFont;
            this.FileTextBox.ForeColor = this.data.TextColor;
            if (this.FileTextBox.Text.Length > 0)
            {
                this.data.TextModified = true;
            }

        }

        // Clear the data object
        private void clearDataSettings()
        {
            this.data.FileText = "";
            this.data.TextFont = Properties.Settings.Default.FontSetting;
            this.data.TextColor = Properties.Settings.Default.ColorSetting;
            this.data.TextModified = false;
            this.data.IsSaved = false;
            this.data.FileText = "";
        }

        // Update registered changes to data object and wordCountStatus
        private void FileTextBox_TextChanged(object sender, EventArgs e)
        {
            oldText = data.FileText;
            data.FileText = this.FileTextBox.Text;
            data.TextModified = true;

            //updates the wordCountStatus status bar
            if(FileTextBox.Text == String.Empty)
            {
                wordCountStatus.Text = "0 Words";
            } else if (FileTextBox.Text.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Count() == 1)
            {
                wordCountStatus.Text = "1 Word";
            } else if (FileTextBox.Text.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Count() > 1)
            {
                wordCountStatus.Text = String.Format("{0} Words", 
                    FileTextBox.Text.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Count());
            }
        }

        // Open the preferences dialog modelessly
        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences pdlg = new Preferences();
            pdlg.Owner = this;
            // Intialize dialog
            pdlg.color = this.data.TextColor;
            pdlg.font = this.data.TextFont;
            pdlg.Apply += PreferencesDialog_Apply;

            pdlg.Show();
        }

        // Function to handle the apply button of the preference dialog
        private void PreferencesDialog_Apply(object sender, EventArgs e)
        {
            var dlg = sender as Preferences;
            if (dlg != null)
            {
                this.data.TextColor = dlg.color;
                this.data.TextFont = dlg.font;
                // Update the file textbox
                updateFileTextBoxSettings();
                updateFontStatus();
            }
        }

        // Open the oath dialog modally
        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OathDialog oathDlg = new OathDialog();
            oathDlg.Owner = this;
            oathDlg.StartPosition = FormStartPosition.Manual;
            oathDlg.Location = new Point(this.Location.X + this.Width - 15, this.Location.Y);
            oathDlg.ShowDialog();
        }

        // Open the about dialog modelessly
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog abtthDlg = new AboutDialog();
            abtthDlg.Owner = this;
            abtthDlg.StartPosition = FormStartPosition.Manual;
            abtthDlg.Location = new Point(this.Location.X, this.Location.Y + this.Height - 8);
            abtthDlg.Show();
        }

        // Save the file using Binary Format Serialization. Use previous location if the fali was already saved
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.data.IsSaved)  //If the data was alredy saved use the same location
            {
                using (Stream stream = new FileStream(this.data.SavedName, FileMode.Create, FileAccess.Write))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this.data);
                    this.data.IsSaved = true;
                    this.data.TextModified = false;
                }
            }
            else  // If not display a dialog to use a new location
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            
        }

        // Save as the file using Binary Format Serialization 
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;
                using (Stream stream = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this.data);
                    this.data.SavedName = dlg.FileName;
                    this.data.IsSaved = true;
                    this.data.TextModified = false;
                }
            }
        }

        // Open a saved file using Binary Format Serialization 
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.data.TextModified)
            {
                DialogResult d = MessageBox.Show("Do you want to save the file?", "Unsaved Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    this.saveToolStripMenuItem_Click(sender, e);
                }
            }

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;
                using (Stream stream = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                {
                    IFormatter formatter = new BinaryFormatter();
                    this.data = (FileData)formatter.Deserialize(stream);
                    //Update the Text Box
                    updateFileTextBoxSettings();

                    //Avoid asking to save if we just open the file
                    this.data.TextModified = false;
                    this.data.SavedName = dlg.FileName;
                    this.data.IsSaved = true;
                }
            }
        }

        //Verifies if there are unsaved changes, save it and then clear teh textbox 
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.data.TextModified)
            {
                DialogResult d = MessageBox.Show("Do you want to save the file?","Unsaved Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(d == DialogResult.Yes)
                {
                    this.saveToolStripMenuItem_Click(sender, e);
                }                
            }

            clearDataSettings();
            updateFileTextBoxSettings();
            this.data.TextModified = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.data.TextModified)
            {
                DialogResult d = MessageBox.Show("Do you want to save the file?", "Unsaved Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    this.saveToolStripMenuItem_Click(sender, e);
                }
                if (d == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //If anything is selected in the textbox, it will delete it and save the selected text in the Clipboard
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileTextBox.SelectedText != String.Empty)
            {
                String selectedText = FileTextBox.SelectedText;
                Clipboard.SetText(selectedText);
                int pointerPos = FileTextBox.SelectionStart;    //saves the pointer's position
                FileTextBox.SelectedText = FileTextBox.SelectedText.Replace(selectedText, "");
                FileTextBox.SelectionStart = pointerPos;        //places the pointer back to its original position
            }

        }

        //Saves whatever text is selected from the textbox into the Clipboard
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileTextBox.SelectedText != string.Empty)
            {
                String selectedText = FileTextBox.SelectedText;
                Clipboard.SetText(selectedText);
            }
        }

        //Gets the text that is saved in the Clipboard, and pastes it wherever the pointer is, or replaces any selected text if it exists
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String copiedText = Clipboard.GetText();
            int pointerPos = FileTextBox.SelectionStart;    //saves the pointer's position

            //replaces the textbox's selected text if there is any
            if (FileTextBox.SelectedText != String.Empty)
            {
                FileTextBox.SelectedText = 
                    FileTextBox.SelectedText.Replace(FileTextBox.SelectedText, copiedText);
            } else
            {
                FileTextBox.Text = FileTextBox.Text.Insert(FileTextBox.SelectionStart, copiedText);
                FileTextBox.SelectionStart = pointerPos + copiedText.Length;    //places the pointer at the end of the pasted text
            }
          
        }

        //Goes one state back to the state in which the textbox was last modified
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oldText != null)
            {
                int pointerPos = FileTextBox.SelectionStart;
                FileTextBox.Text = oldText;
                FileTextBox.SelectionStart = pointerPos;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oldText == null || oldText == string.Empty)
            {
                undoToolStripMenuItem.Enabled = false;
            }
            else
            {
                undoToolStripMenuItem.Enabled = true;
            }

            if(FileTextBox.SelectedText == string.Empty)
            {
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
            }
            else
            {
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;

            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileTextBox.SelectAll();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.MyAppIcon;
         
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
