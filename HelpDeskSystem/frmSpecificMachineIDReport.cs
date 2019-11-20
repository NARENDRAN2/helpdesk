using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDeskSystem
{
    public partial class frmSpecificMachineIDReport : Form
    {
        EnterProblem prob = new EnterProblem();
        public frmSpecificMachineIDReport()
        {
            InitializeComponent();
        }

        private void frmSpecificMachineIDReport_Load(object sender, EventArgs e)
        {
            txtMachineID.Focus();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dgvSpecificMachine.DataSource = prob.GetProblemForSpecificMachineID(txtMachineID.Text);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvSpecificMachine.Width, this.dgvSpecificMachine.Height);
            dgvSpecificMachine.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvSpecificMachine.Width, this.dgvSpecificMachine.Height));
            e.Graphics.DrawImage(bm, 10, 10);
        }
        private void copyAlltoClipboard()
        {
            dgvSpecificMachine.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvSpecificMachine.MultiSelect = true;
            dgvSpecificMachine.SelectAll();
            DataObject dataObj = dgvSpecificMachine.GetClipboardContent();
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
    }
}
