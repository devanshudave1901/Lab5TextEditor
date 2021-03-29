//Author - Devanshu Dave
// Date - 26-03-2021
//Description - This application which will Normally give the user a text editor where user can Save,Copy,paste etc the text or open the file. This application is written on c#.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5TextEditor
{
    public partial class formTextEditor : Form
    {
        // declaring the filepath with the string and keeping that string as empty.
        string filePath = String.Empty;
        // Declared the isChanged variable with bool variable and set that to false.
        bool isUnchanged = false;
        public formTextEditor()
        {
            InitializeComponent();            
        }
        #region "Event Handlers"
        /// <summary>
        /// This opens the new file for the user when user press the new option or CTRL+N. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFile(object sender, EventArgs e)
        {
            //ConfirmClose function called which will pop up and asked the user to save the file or not.
            ConfirmClose();
            // if statement used to (is not unchanged then do this...)
            if (!isUnchanged)
            {

               // this message.show will show the message to ask to procced and will clear the current file. and if user enters yes then the computer will enter the 
               // if statement
                if (MessageBox.Show("This will clear the current file. Would You like to proceed?", "Confirm New FIle", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    // Clearing the editor
                    textBoxEditor.Clear();
                    // setting filepath to empty
                    filePath = String.Empty;
                    // making isUnchanged to true.
                    isUnchanged = true;
                    // calling Update Title function
                    UpdateTitle();
                }
            }

        }
        /// <summary>
        /// This will open the file for the user. When the user selects the option open or ctrl+O the this will open fileDialog box to open the file from.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFile(object sender, EventArgs e)
        {
            //ConfirmClose function called which will pop up and asked the user to save the file or not.
            ConfirmClose();
            // creating and configuring a open dialog
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";
            // Displaying the open dialog to the user 
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                // if user says or press ok then to initialize StreamReader object
                FileStream myFile = new FileStream(openDialog.FileName, FileMode.Open, FileAccess.Read);
                StreamReader read = new StreamReader(myFile);
                
                // ReadToEnd() to lead the data and display in the text Box Editor
                textBoxEditor.Text = read.ReadToEnd();
                // Stream Reader be closed.
                read.Close();
         
            }
        }
        /// <summary>
        /// This option when selected saves the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickSave(object sender, EventArgs e)
        {
            // If filePath is empty then will call the ClickSaveAs function.
            if (filePath == String.Empty)
            {
                // Function been called.
                ClickSaveAs(sender, e);
            }
            else
            {
                // SaveTextFile Function been called.
                SaveTextFile(filePath);
            }
        }
        /// <summary>
        /// This is the when the user selects the save as option to save the file locally.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ClickSaveAs(object sender, EventArgs e)
        {
            // creating and configuring a save dialog
            FileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text files (*.txt) | *.txt|All files (*.*)|*.*";
            // Displaying the open dialog to the user 
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // SaveTextFile Function been called.
                SaveTextFile(filePath);
                // UpdateTitle function been called.
                UpdateTitle();

            }
        }
        /// <summary>
        /// This Closes the file when option is selected 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseFile(object sender, EventArgs e)
        {
            //ConfirmClose function been called
            ConfirmClose();
            // Closes the file
            Close();


        }
        /// <summary>
        /// This is the option which closes the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitFile(object sender, EventArgs e)
        {

            // Close file function has been called to close the file.
            CloseFile(sender,e);

        }
        /// <summary>
        /// This is the function to copy the text from the editor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CopyText(object sender, EventArgs e)
        {

            // SetText used which also selects the text info.
            // clipboard.SetText method used to copy the selected text.
            if(textBoxEditor.SelectedText != "")
            {
                Clipboard.SetText(textBoxEditor.SelectedText);
            }
            

        }
        /// <summary>
        /// This is when user selects cut option to cut the selected text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CutText(object sender, EventArgs e)
        {
            // // SetText used which also selects the text info and then makes that empty(i.e. cut).
            if (textBoxEditor.SelectedText != "")
            {
                Clipboard.SetText(textBoxEditor.SelectedText);
                // empty that selected text (i.e. cut)
                textBoxEditor.SelectedText = "";
            }
        }
        /// <summary>
        /// This paste the text when the paste option is selected .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void PasteText(object sender, EventArgs e)
        {
            // if the clipboard contains text enter the if block.
            if (Clipboard.ContainsText())
            {
                // this is used to paste the things
                // this pastes in the textbox editor and inserts the text from the text got from the GetText function and paste that into the selected part means last
                // where the cursor is ther(with the help of selection start).
                textBoxEditor.Text = textBoxEditor.Text.Insert(textBoxEditor.SelectionStart, Clipboard.GetText());               
            }         
        }
        /// <summary>
        /// This is when about option selected which displays authors name and course info.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickAbout(object sender, EventArgs e)
        {
            // displays the informaton
            MessageBox.Show("NETD 2202" + "\n\n" + "Lab #5" + "\n\n\n" + " By Devanshu Dave");
        }
        #endregion
        #region "Funtions"
        /// <summary>
        /// update title funtion is called in various places. This Updates the title
        /// </summary>
        public void UpdateTitle()
        {
            // this refers to this form where text is set to Devanshu's Text Editor
            this.Text = "Devanshu's Text Editor";
            // when the filepath is not empty then it wil enter this.
            if (filePath != String.Empty)
            {
                // sets - + filepath
               // basically to update the title.
                this.Text += "-" + filePath;
            }
        }
        /// <summary>
        /// This is used to create and configute save dialog and the functionality of save is written here which has been called in above save as and save event handler.
        /// </summary>
        /// <param name="path"></param>
        public void SaveTextFile(string path)
        {
            // creating and configuring a save dialog
            FileStream myFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(myFile);
            // This is to add text to texteditor with the help of .text
            writer.Write(textBoxEditor.Text);
            // writer.close() to close the file
            writer.Close();
        }
        /// <summary>
        /// This is the function which pops up and ask to save or not.
        /// </summary>

        private void ConfirmClose()
        {
            // Displays the save (yes or no) box with the info.
           MessageBox.Show("Do You Want to Save This File?", "Confirm", MessageBoxButtons.YesNo);

           // This is the firs bonus marks question.I did half second bonus question but was not able to
           // make that work as intended due to time left less. That's why decided to remove the second bonus marks code.


        }
        #endregion
    }
}
