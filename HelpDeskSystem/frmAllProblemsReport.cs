using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.Office.Interop.Word;

namespace HelpDeskSystem
{
    public partial class frmAllProblemsReport : Form
    {
        EnterProblem problem = new EnterProblem();
        public frmAllProblemsReport()
        {
            InitializeComponent();
        }

        private void frmAllProblemsReport_Load(object sender, EventArgs e)
        {
            dgvAllProblems.DataSource = problem.GetAllProblems();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs  e)
        {
            Bitmap bm = new Bitmap(this.dgvAllProblems.Width, this.dgvAllProblems.Height);
            dgvAllProblems.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, this.dgvAllProblems.Width, this.dgvAllProblems.Height));
            e.Graphics.DrawImage(bm, 10, 10);
        }
        //FOR EXCEL
        private void copyAlltoClipboard()
        {
            dgvAllProblems.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvAllProblems.MultiSelect = true;
            dgvAllProblems.SelectAll();
            DataObject dataObj = dgvAllProblems.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void btnExcelWork_Click(object sender, EventArgs e)
        {
            
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        //FOR WORD

        private void btnWordDoc_Click(object sender, EventArgs e)
        {
            
        }
    }
}
