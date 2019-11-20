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

namespace HelpDeskSystem
{
    public partial class frmOpenProblemsReport : Form
    {
        EnterProblem prob = new EnterProblem();
        public frmOpenProblemsReport()
        {
            InitializeComponent();
        }

        private void dgvAllProblems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAllOpenProblemsReport_Load(object sender, EventArgs e)
        {
            dgvAllOpenProblems.DataSource = prob.GetOpenProblems();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvAllOpenProblems.Width, this.dgvAllOpenProblems.Height);
            dgvAllOpenProblems.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvAllOpenProblems.Width, this.dgvAllOpenProblems.Height));
            e.Graphics.DrawImage(bm, 10, 10);
        }
        private void copyAlltoClipboard()
        {
            dgvAllOpenProblems.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvAllOpenProblems.MultiSelect = true;
            dgvAllOpenProblems.SelectAll();
            DataObject dataObj = dgvAllOpenProblems.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void btnExcelWork_Click_1(object sender, EventArgs e)
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
    }
}
