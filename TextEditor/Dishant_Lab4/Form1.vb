Imports System.IO
Public Class frmTextEditor
    ' frmTextEditor is a form that allows users to easily open, save, or print text files. 
    ' The form has a menu strip with the following tabs: File, Edit, and Help. Each tab has its own options.
    ' The Open option under File tab allows user to select a file to open.
    ' The Save option under File tab saves the file with the same name.
    ' The Save as option under File tab opens the file dialog and allows user to enter a name and file type.
    ' The Print option under File tab allows user to print the file.
    ' The Close option under File tab closes the opened file.
    ' The Exit option under File tab ends the program and closes the form.
    ' The Copy option under Edit tab copies the selected text to the clipboard.
    ' The Cut options under Edit tab cuts the selected text and copies it to the clipboard.
    ' The Paste option under Edit tab pastes the text from clipboard to the textbox.
    ' The About option under the Help tab opens frmAbout form with information.
    ' The Index option under the Help tab opens frmIndex form with information.

    ' Program created on: 2016-03-23
    ' Program created by: Dishant Patel (100472875), Scott Huxter (100580938).

    'currentFile variable stores the file name which is used during save process.
    Dim currentFile As String
    'changeMade is a boolean variable which checks if any changes were made.
    Dim changeMade As Boolean = False

    Private Sub defaultSettings()
        'Disables the save, save as, print, and close option when no file is open.
        SaveToolStripMenuItem.Enabled = False
        SaveAsToolStripMenuItem.Enabled = False
        PrintToolStripMenuItem.Enabled = False
        CloseToolStripMenuItem.Enabled = False
        'Checks to see if there is any text to paste, if not then the paste option will be disabled.
        If Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) = True Then
            PasteToolStripMenuItem.Enabled = True
        Else
            PasteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub saveFile()
        'Saves the changes made in the same file (Save).
        Dim FileWriter As StreamWriter = New StreamWriter(currentFile)
        FileWriter.Write(txtBoxContent.Text)
        FileWriter.Close()
    End Sub

    Private Sub frmTextEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call the defaultSettings sub routine.
        defaultSettings()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        'Open the file using the file reader.
        Dim FileReader As StreamReader
        Dim openResults As DialogResult
        openResults = opnFileDialog.ShowDialog()
        If openResults = DialogResult.OK Then
            FileReader = New StreamReader(opnFileDialog.FileName)
            txtBoxContent.Text = FileReader.ReadToEnd()
            FileReader.Close()
        End If
        'Once a file is opened, enable the save, save as, print, and close options in the menu strip.
        SaveToolStripMenuItem.Enabled = True
        SaveAsToolStripMenuItem.Enabled = True
        PrintToolStripMenuItem.Enabled = True
        CloseToolStripMenuItem.Enabled = True
        'Change the current file to the file that was opened.
        currentFile = opnFileDialog.FileName
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'Call the saveFile sub routine.
        saveFile()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        'Prompts the user to choose  a name and file type (Save As).
        Dim FileWriter As StreamWriter
        Dim saveAsResults As DialogResult
        'Sets the default file name as Document 1.
        svasFileDialog.FileName = "Document 1"
        svasFileDialog.Filter = "(*.txt) |*.txt|(*.*) |*.*"
        saveAsResults = svasFileDialog.ShowDialog()
        If saveAsResults = DialogResult.OK Then
            FileWriter = New StreamWriter(svasFileDialog.FileName, False)
            FileWriter.Write(txtBoxContent.Text)
            FileWriter.Close()
        End If
        'Changes the current file to the file name that was used during the save as process.
        currentFile = svasFileDialog.FileName
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'Initialize variables that will be used to the display title and message in the message box.
        Dim msgBoxPrompt = "Would you like to save the file?"
        Dim msgBoxTitle = "Custom Text Editor"
        'Message box has 3 options, yes, no, and cancel. Cancel is the default option.
        Dim msgBoxOption = MsgBoxStyle.YesNoCancel Or MsgBoxStyle.DefaultButton3
        Dim userResponse = MsgBox(msgBoxPrompt, msgBoxOption, msgBoxTitle)
        'If changeMade is true (if text was changed) then open the message box.
        If changeMade = True Then
            'If user clicks Yes then call the function saveFile() and clear the text box and set to default settings.
            If userResponse = MsgBoxResult.Yes Then
                saveFile()
                txtBoxContent.Clear()
                defaultSettings()
                'If user clicks No then just clear the textbox and set to default settings.
            ElseIf userResponse = MsgBoxResult.No
                txtBoxContent.Clear()
                defaultSettings()
            End If
            'If no changes have been made to the text, then exit without the opening the message box.
        Else
            txtBoxContent.Clear()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Close the form.
        Close()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        'If any text is selected, copy the selected text.
        If txtBoxContent.SelectionLength > 0 Then
            txtBoxContent.Copy()
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        'If any text is selected, cut the selected text.
        If txtBoxContent.SelectedText <> "" Then
            txtBoxContent.Cut()
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Paste the copied text from the clipboard.
        txtBoxContent.Paste()
    End Sub

    Private Sub IndexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndexToolStripMenuItem.Click
        'Open the frmIndex form.
        Dim indForm As frmIndex
        indForm = New frmIndex()
        indForm.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Open the frmAbout form.
        Dim abtForm As frmAbout
        abtForm = New frmAbout()
        abtForm.Show()
    End Sub

    Private Sub txtBoxContent_TextChanged(sender As Object, e As EventArgs) Handles txtBoxContent.TextChanged
        'set the changeMade variable to true if any text has been changed.
        changeMade = True
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        'Open the print dialog.
        prntDialog.ShowDialog()
    End Sub

End Class