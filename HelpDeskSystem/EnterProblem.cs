using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HelpDeskSystem
{
    class EnterProblem
    {
        DataAccessLayer dl = new DataAccessLayer();
        public int ProblemID { get; set; }
        public int Priority { get; set; }
        public string ProblemComment { get; set; }
        public string Date { get; set; }
        public string Category { get; set; }
        public string LogicalDrive { get; set; }

        public EnterProblem()
        {

        }
        public void InsertProblem(int priority, string problem, DateTime date,string category, string logicDrive)
        {
            dl.insertProblem(priority,problem,date,category,logicDrive);
        }
        public void UpdateProblem(int problemID, string staffID,string status) //used by admin
        {
            dl.updateProblem(problemID,staffID,status);
        }
        public void UpdateProblemsForCloseAllProblems(DateTime date)
        {
            dl.updateProblemsForCloseAllProblems(date);
        }
        public void UpdateProblemForCloseSelectedProblem(int probID,DateTime date)
        {
            dl.updateProblemForCloseSelectedProblem(probID, date);
        }
        public void UpdateTransferedStaff(int probID,string staffID)
        {
            dl.updateTransferedStaff(probID, staffID);
        }
        public void UpdateEscalatedProblem(int probID, string priority)
        {
            dl.updateEscalatedProblem(probID, priority);
        }
        public DataTable GetAllProblems()
        {
            return dl.getAllProblems();
        }
        public DataTable GetOpenProblems()
        {
            return dl.getOpenProblems();
        }
        public DataTable GetWaitingProblems()
        {
            return dl.getWaitingProblems();
        }
        public DataTable GetSolvedProblems()
        {
            return dl.getSolvedProblems();
        }
        public DataTable GetHighPriorityProblems()
        {
            return dl.getHighPriorityProblems();
        }
        public DataTable GetClosedProblems()
        {
            return dl.getClosedProblems();
        }
        public DataTable GetProblemsForTransfer()
        {
            return dl.getProblemsForTransfer();
        }
        public DataTable GetDateRangeProblems(DateTime start, DateTime end)
        {
            return dl.getDateRangeProblems(start,end);
        }
        public DataTable GetProblemForSpecificStaffMember(string staffID)
        {
            return dl.getProblemsForSpecificStaff(staffID);
        }
        public DataTable GetProblemForSpecificCategory(string categoryID)
        {
            return dl.getProblemsForSpecificCategory(categoryID);
        }
        public DataTable GetProblemForSpecificMachineID(string machineID)
        {
            return dl.getProblemsForSpecificMachineID(machineID);
        }
    }
}
