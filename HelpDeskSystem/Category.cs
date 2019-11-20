using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HelpDeskSystem
{
    class Category
    {
        DataAccessLayer dl = new DataAccessLayer();
        public string CategoryID { get; set; }
        public string CategoryDescription { get; set; }

        public DataTable GetCategory()
        {
            return dl.getCategory();
        }
        public void InsertCategory(string categoryID, string categoryDescr)
        {
            dl.insertCategory(categoryID,categoryDescr);
        }
        public void DeleteCategory(string catID,string catDescr)
        {
            dl.deleteCategory(catID, catDescr);
        }
    }
}
