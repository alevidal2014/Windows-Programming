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
using Microsoft.VisualBasic.Devices;

namespace Homework6
{
    public partial class TopForm : Form
    {           

        private FileData data;
        private String oldText;
        private Keyboard keyboard;
        String FileName { get; set; }
        String ExtName { get; set; }

        // Keeps track of number of top forms open
        static int formCount = 0;

        public TopForm()
        {
            InitializeComponent();
            this.ExtName = ".g1";
            // Create FileData object using the default user settings
            data = new FileData(Properties.Settings.Default.ColorSetting, Properties.Settings.Default.FontSetting);

            // Set the file textbox settings
            updateFileTextBoxSettings();
            updateFontStatus();

            formCount++;
            // Add form number to title, and register the form and its windows menu item to the application
            this.Text = String.Format("{0}:{1}", this.Text, formCount);
            MultiSDIApp.Application.AddTopLevelForm(this);
            MultiSDIApp.Application.AddWindowMenu(windowToolStripMenuItem);
            keyboard = new Keyboard();
            toolStripNewFileButton.Click += newToolStripMenuItem_Click;
            toolStripOpenFileButton.Click += openToolStripMenuItem_Click;
            toolStripSaveFileButton.Click += saveToolStripMenuItem_Click;
            toolStripSaveFileAsButton.Click += saveAsToolStripMenuItem_Click;
            toolStripCutButton.Click += cutToolStripMenuItem_Click;
            toolStripCopyButton.Click += copyToolStripMenuItem_Click;
            toolStripPasteButton.Click += pasteToolStripMenuItem_Click;
            Application.Idle += Application_Idle;
            toolStripCutButton.Enabled = false;
            toolStripCopyButton.Enabled = false;


        }

        private void Application_Idle(object sender, EventArgs e)
        {
            if(FileTextBox.SelectedText != string.Empty)
            {
                toolStripCutButton.Enabled = true;
                toolStripCopyButton.Enabled = true;
            }
            else
            {
                toolStripCutButton.Enabled = false;
                toolStripCopyButton.Enabled = false;
            }
        }



        // Creates a new Top Form modelessly, opening a file if passed one
        public static TopForm CreateTopLevelWindow(String fileName)
        {
            if (!String.IsNullOrEmpty(fileName))
            {
                foreach (TopForm form in Application.OpenForms)
                {
                    if (String.Compare(form.FileName, fileName, true) == 0)
                    {
                        form.Activate();
                        return form;
                    }
                }
            }

            TopForm newForm = new TopForm();
            newForm.OpenFile(fileName);
            newForm.Show();
            newForm.Activate();
            return newForm;
        }

        // Opens file (if it exists), reads its contents and place then into the file text box
        private void OpenFile(String fileName)
        {
            this.FileName = fileName;
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    FileTextBox.Text = reader.ReadToEnd();
                }
            }
            else // Could not find file, open form as Untitled
            {
                this.FileName = String.Format("Untitled {0}", formCount);
            }
            this.Text = String.Format("{0} ({1})", this.Text, this.FileName);
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

        // Save the file using Binary Format Serialization. Use previous location if the file was already saved
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
                //Setting the default extension for the file 
                dlg.AddExtension = true;
                dlg.DefaultExt = this.ExtName;
                dlg.Filter = "G1 files (*.g1)|*"+ this.ExtName +"|All files (*.*)|*.*";

                if (dlg.ShowDialog() != DialogResult.OK) return;
                using (Stream stream = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this.data);
                    this.data.SavedName = dlg.FileName;
                    this.data.IsSaved = true;
                    this.data.TextModified = false;
                    //Update the Form Title 
                    this.FileName = this.data.SavedName;
                    this.Text = String.Format("{0} ({1})", this.Text.Substring(0,13), this.FileName.Substring(this.FileName.LastIndexOf('\\') + 1));
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
                //Setting the default extension for the file 
                dlg.AddExtension = true;
                dlg.DefaultExt = this.ExtName;
                dlg.Filter = "G1 files (*.g1)|*" + this.ExtName + "|All files (*.*)|*.*";

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

                    //Update the Form Title 
                    this.FileName = this.data.SavedName;
                    this.Text = String.Format("{0} ({1})", this.Text.Substring(0, 13), this.FileName.Substring(this.FileName.LastIndexOf('\\') + 1));
                }
            }
        }

        /* Old Version -
        //Verifies if there are unsaved changes, save it and then clear the textbox 
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
        */

        // New version - Creates a new Top Form when new option is selected
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopForm.CreateTopLevelWindow(null);
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
            SetCapLockStatus();
            toolStripNewFileButton.Image = Properties.Resources.Danrabbit_Elementary_Document_new.ToBitmap();
            toolStripOpenFileButton.Image = Properties.Resources.Custom_Icon_Design_Flatastic_10_Open_file.ToBitmap();
            toolStripSaveFileButton.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_save.ToBitmap();
            toolStripSaveFileAsButton.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_save_as.ToBitmap();
            toolStripExitFileButton.Image = Properties.Resources.Icons8_Windows_8_Users_Exit.ToBitmap();
            toolStripCopyButton.Image = Properties.Resources.Custom_Icon_Design_Mono_General_2_Copy.ToBitmap();
            toolStripCutButton.Image = Properties.Resources.Custom_Icon_Design_Mono_General_2_Cut.ToBitmap();
            toolStripPasteButton.Image = Properties.Resources.Custom_Icon_Design_Mono_General_2_Paste.ToBitmap();
        }


        private void FileTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            capLockStatusLabel.Text = "CapLock : ";

            SetCapLockStatus();
        }

        private void SetCapLockStatus()
        {
            if (this.keyboard.CapsLock)
            {
                capLockStatusLabel.Text = capLockStatusLabel.Text + "ON";
            }
            else
            {
                capLockStatusLabel.Text = capLockStatusLabel.Text + "OFF";
            }
        }

        //Indicates that what is being dragged into the text box is dropable.
        private void FileTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && 
                (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                e.Effect = DragDropEffects.Copy;
            } else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        //Takes the dragged data and drops it into the text box
        private void FileTextBox_DragDrop(object sender, DragEventArgs e)
        { 
            int pointerPos = FileTextBox.SelectionStart;    //saves the pointer's position
            FileTextBox.Text = FileTextBox.Text.Insert(FileTextBox.SelectionStart, (String)e.Data.GetData(DataFormats.Text));
            FileTextBox.SelectionStart = pointerPos;
        
        }

        //Allows for text to be dragged from the text box using by holding the right click button.
        private void FileTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (FileTextBox.SelectedText != String.Empty)
            {
                if (e.Button == MouseButtons.Right)
                {
                    FileTextBox.DoDragDrop(FileTextBox.SelectedText, DragDropEffects.Copy);
                }
            }
        }

        //checks if the CTRL + an arrow key are pressed to move the window according to the arrow key
        private void FileTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (keyboard.CtrlKeyDown)
                    {
                        this.Location = new Point(this.Location.X - 1, this.Location.Y);
                    }
                    break;
                case Keys.Right:
                    if (keyboard.CtrlKeyDown)
                    {
                        this.Location = new Point(this.Location.X + 1, this.Location.Y);
                    }
                    break;
                case Keys.Down:
                    if (keyboard.CtrlKeyDown)
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + 1);
                    }
                    break;
                case Keys.Up:
                    if (keyboard.CtrlKeyDown)
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y - 1);
                    }
                    break;
            }
        }

        private void toolStripExitFileButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
