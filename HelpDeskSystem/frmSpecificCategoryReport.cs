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
    public partial class frmSpecificCategoryReport : Form
    {
        EnterProblem prob = new EnterProblem();
        Category cat = new Category();
        public frmSpecificCategoryReport()
        {
            InitializeComponent();
        }

        private void frmSpecificCategoryReport_Load(object sender, EventArgs e)
        {            
            cmbCategory.DataSource = cat.GetCategory();
            cmbCategory.DisplayMember = "CategoryDescription";
            cmbCategory.ValueMember = "CategoryID";
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSpecificCategory.DataSource = prob.GetProblemForSpecificCategory(cmbCategory.SelectedValue.ToString());
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
            Bitmap bm = new Bitmap(this.dgvSpecificCategory.Width, this.dgvSpecificCategory.Height);
            dgvSpecificCategory.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvSpecificCategory.Width, this.dgvSpecificCategory.Height));
            e.Graphics.DrawImage(bm, 10, 10);
        }
        private void copyAlltoClipboard()
        {
            dgvSpecificCategory.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvSpecificCategory.MultiSelect = true;
            dgvSpecificCategory.SelectAll();
            DataObject dataObj = dgvSpecificCategory.GetClipboardContent();
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

        private void btnWordDoc_Click(object sender, EventArgs e)
        {

        }
    }
}
