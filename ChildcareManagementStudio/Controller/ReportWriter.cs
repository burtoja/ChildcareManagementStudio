using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.Properties;
using Microsoft.Office.Interop.Word;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Class that can be used to write attendance and sign-in sheets.
    /// </summary>
    public class ReportWriter
    {
        private List<StudentClassroomAssignment> studentClassroomAssignments;

        /// <summary>
        /// Constructor for the ReportWriter class.
        /// </summary>
        /// <param name="studentClassroomAssignments">The list of student/classroom assignments.</param>
        public ReportWriter(List<StudentClassroomAssignment> studentClassroomAssignments)
        {
            if (studentClassroomAssignments == null)
            {
                throw new ArgumentNullException("The list of student/classroom assignments cannot be null.");
            }

            if (studentClassroomAssignments.Count == 0)
            {
                throw new ArgumentException("There must be at least one assignment in the list.");
            }

            this.studentClassroomAssignments = studentClassroomAssignments;
        }

        /// <summary>
        /// Method that writes a PDF file for an attendance sheet.
        /// </summary>
        /// <param name="filePath">The path where the file will be saved.</param>
        public void WriteAttendanceSheet(object filePath)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException("filePath", "The file path cannot be null.");
            }

            if (!GetFileExtension(filePath).Equals("pdf", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("The file must have a PDF extension.", "filePath");
            }

            object missing = System.Reflection.Missing.Value;
            object readOnly = false;
            object isVisible = false;
            object fileName = @"C:\Test\AttendanceSheet.dotx";
            object fileFormat = WdSaveFormat.wdFormatPDF;
            object saveChanges = WdSaveOptions.wdDoNotSaveChanges;

            Microsoft.Office.Interop.Word.Application oWord = new Microsoft.Office.Interop.Word.Application();

            Documents oDocTmp = oWord.Documents;
            oWord.Visible = false;

            string temporaryFilePath = Path.GetTempFileName();
            File.WriteAllBytes(temporaryFilePath, Resources.AttendanceSheet);
            object templatePath = temporaryFilePath;

            Documents documentTemplate = oWord.Documents;
            oWord.Visible = false;
            Document oDoc = documentTemplate.Open(ref templatePath, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible, ref missing, ref missing, ref missing, ref missing);

            oDoc.Bookmarks["startOfTable"].Select();
            oWord.Selection.TypeText(this.studentClassroomAssignments[0].Student.FullName);
            oDoc.Tables[2].Rows.Last.Cells[2].Select();
            oWord.Selection.TypeText(this.studentClassroomAssignments[0].Student.DateOfBirth.ToShortDateString());

            if (this.studentClassroomAssignments.Count > 1)
            {
                for (int assignmentNumber = 1; assignmentNumber < this.studentClassroomAssignments.Count; assignmentNumber++)
                {
                    oDoc.Tables[2].Rows.Add();
                    oDoc.Tables[2].Rows.Last.Cells[1].Select();
                    oWord.Selection.TypeText(this.studentClassroomAssignments[assignmentNumber].Student.FullName);
                    oDoc.Tables[2].Rows.Last.Cells[2].Select();
                    oWord.Selection.TypeText(this.studentClassroomAssignments[assignmentNumber].Student.DateOfBirth.ToShortDateString());
                }
            }

            oDoc.SaveAs(ref filePath, ref fileFormat, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            oDoc.Close(ref saveChanges, ref missing, ref missing);
            oWord.Quit(ref saveChanges, ref missing, ref missing);

            MessageBox.Show("Here");
        }

        private string GetFileExtension(object filePath)
        {
            string filePathString = (string)filePath;
            string[] filePathParts = filePathString.Split('.');
            string fileExtension = filePathParts[filePathParts.Length - 1];
            return fileExtension;
        }
    }
}