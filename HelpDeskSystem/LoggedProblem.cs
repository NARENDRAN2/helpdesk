using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HelpDeskSystem
{
    class LoggedProblem
    {
        DataAccessLayer dl = new DataAccessLayer();
        public int ProblemID { get; set; }
        public string Date = DateTime.Now.ToLongDateString();
        public string StaffID { get; set; }
        public string Comment { get; set; }

        public LoggedProblem()
        {

        }
        public void InsertProblemLog(DateTime logDate, string staffID, string comment)
        {
            dl.insertProblemLog(logDate,staffID,comment);
        }
        public void UpdateProblemLog(int probID, DateTime logDate, string staffID, string comment)
        {
            dl.updateProblemLog(probID, logDate,staffID,comment);
        }
        public void UpdateLoggedProblemsForCloseAllProblems(DateTime date)
        {
            dl.updateProblemsForCloseAllProblems(date);
        }
        public void UpdateLoggedProblemForCloseSelectedProblem(int probID, DateTime date)
        {
            dl.updateProblemForCloseSelectedProblem(probID, date);
        }
        public DataTable GetLoggedProblems(int problemID)
        {
            return dl.getLoggedProblems(problemID);
        }
       
    }
}
