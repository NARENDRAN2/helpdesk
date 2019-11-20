using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HelpDeskSystem
{
    class DataAccessLayer
    {
        private string connectionString;
        SqlConnection dbConn;
        SqlCommand dbCmd;
        SqlDataAdapter dbAdapt;
        public DataAccessLayer()
        {
            connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"H:\\MODULES\\ONT2000\\Help Desk Project\\HelpDeskSystem\\HelpDeskSystem\\Info@ITDB.mdf\"; Integrated Security = True";
            dbConn = new SqlConnection(connectionString);
        }
        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        //GETTING DATATABLES FROM DATABASE
        public DataTable getAdminLogin(string user,string pass)
        {
            DataTable dtAdminLogin = new DataTable();
            dbCmd = new SqlCommand("sp_GetAdminLogin'" + user + "','" + pass + "'", dbConn);
            dbAdapt = new SqlDataAdapter(dbCmd);
            dbAdapt.Fill(dtAdminLogin);
            return dtAdminLogin;
        }
        public DataTable getStaffLogin(string stID, string stUser)
        {
            DataTable dtStaffLogin = new DataTable();
            dbCmd = new SqlCommand("sp_GetStaffLogin'" + stID + "','" + stUser + "'", dbConn);
            dbAdapt = new SqlDataAdapter(dbCmd);
            dbAdapt.Fill(dtStaffLogin);
            return dtStaffLogin;
        }
        public DataTable getStaff()
        {
            DataTable dtStaff = new DataTable();
            dbCmd = new SqlCommand("sp_GetStaff", dbConn);
            dbAdapt = new SqlDataAdapter(dbCmd);
            dbAdapt.Fill(dtStaff);
            return dtStaff;
        }
        public DataTable getStaffToTransfer()
        {
            DataTable dtStaffTransfer = new DataTable();
            dbCmd = new SqlCommand("sp_GetStaffToTransfer", dbConn);
            dbAdapt = new SqlDataAdapter(dbCmd);
            dbAdapt.Fill(dtStaffTransfer);
            return dtStaffTransfer;
        }
        public DataTable getCategory()
        {
            DataTable dtCategory = new DataTable();
            dbCmd = new SqlCommand("sp_GetCategory", dbConn);
            dbAdapt = new SqlDataAdapter(dbCmd);
            dbAdapt.Fill(dtCategory);
            return dtCategory;
        }
        public DataTable getAllProblems()
        {
            DataTable dtAllProblems = new DataTable();
            dbCmd = new SqlCommand("sp_GetAllProblems", dbConn);
            dbAdapt = new SqlDataAdapter(dbCmd);
            dbAdapt.Fill(dtAllProblems);
            return dtAllProblems;
        }
        public DataTable getOpenProblems()
        {
            DataTable dtOpenProblems = new DataTable();
            dbCmd = new SqlCommand("sp_GetOpenProblems", dbConn);
            dbAdapt = new SqlDataAdapter(dbCmd);
            dbAdapt.Fill(dtOpenProblems);
            return dtOpenProblems;
        }
        public DataTable getWaitingProblems()
        {
            DataTable dtWaitingProblems = new DataTable();
            dbCmd = new SqlCommand("sp_GetWaitingProblems", dbConn);
            dbAdapt = new SqlDataAdapter(dbCmd);
            dbAdapt.Fill(dtWaitingProblems);
            return dtWaitingProblems;
        }
        public DataTable getSolvedProblems()
        {
            DataTable dtSolvedProblems = new DataTable();
            dbCmd = new SqlCommand("sp_GetSolvedProblems", dbConn);
            dbAdapt = new SqlDataAdapter(dbCmd);
            dbAdapt.Fill(dtSolvedProblems);
            return dtSolvedProblems;
        }
        public DataTable getHighPriorityProblems()
        {
            DataTable dtHighPriorityProblems = new DataTable();
            dbCmd = new SqlCommand("sp_GetHighPriorityProblems", dbConn);
            dbAdapt = new SqlDataAdapter(dbCmd);
            dbAdapt.Fill(dtHighPriorityProblems);
            return dtHighPriorityProblems;
        }
        public DataTable getClosedProblems()
        {
            DataTable dtClosedProblems = new DataTable();
            dbCmd = new SqlCommand("sp_GetClosedProblems", dbConn);
            dbAdapt = new SqlDataAdapter(dbCmd);
            dbAdapt.Fill(dtClosedProblems);
            return dtClosedProblems;
        }
        public DataTable getProblemsForTransfer()
        {
            DataTable dtProblems = new DataTable();
            dbCmd = new SqlCommand("sp_GetProblemsForTransfer", dbConn);
            dbAdapt = new SqlDataAdapter(dbCmd);
            dbAdapt.Fill(dtProblems);
            return dtProblems;
        }
        public DataTable getLoggedProblems(int probID)
        {
            DataTable dtLoggedProblems = new DataTable();
            dbCmd = new SqlCommand("sp_GetLoggedProblems'" + probID + "'", dbConn);
            dbAdapt = new SqlDataAdapter(dbCmd);
            dbAdapt.Fill(dtLoggedProblems);
            return dtLoggedProblems;
        }
        public DataTable getDateRangeProblems(DateTime start,DateTime end)
        {
            DataTable dtRange = new DataTable();
            dbCmd = new SqlCommand("sp_GetDateRange'" + start + "','" + end + "'", dbConn);
            dbAdapt = new SqlDataAdapter(dbCmd);
            dbAdapt.Fill(dtRange);
            return dtRange;
        }
        public DataTable getProblemsForSpecificStaff(string staffID)
        {
            DataTable dtStaffMember = new DataTable();
            dbCmd = new SqlCommand("sp_GetSpecificStaff '" + staffID + "'",dbConn);
            dbAdapt = new SqlDataAdapter(dbCmd);
            dbAdapt.Fill(dtStaffMember);
            return dtStaffMember;
        }
        public DataTable getProblemsForSpecificCategory(string catID)
        {
            DataTable dtCategory = new DataTable();
            dbCmd = new SqlCommand("sp_GetSpecificCategory '" + catID + "'",dbConn);
            dbAdapt = new SqlDataAdapter(dbCmd);
            dbAdapt.Fill(dtCategory);
            return dtCategory;
        }
        public DataTable getProblemsForSpecificMachineID(string machineID)
        {
            DataTable dtMachine = new DataTable();
            dbCmd = new SqlCommand("sp_GetSpecificMachineID '" + machineID + "'",dbConn);
            dbAdapt = new SqlDataAdapter(dbCmd);
            dbAdapt.Fill(dtMachine);
            return dtMachine;
        }
        //INSERTING TO DATABASE
        public void insertProblem(int priority, string problem,DateTime date ,string category,string logicDrive)
        {
            string reportUser = Environment.UserName;
            string staffID = "Not allocated yet";
            string machineID = Environment.MachineName;
            string currentDir = Environment.CurrentDirectory;
            string status = "Open";

            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            string sqlInsert = "sp_InsertProblem '" + date + "','" + priority + "','" + reportUser + "','" + staffID + "','"+ machineID + "','" + currentDir + "','" + problem + "','" + category + "','" +logicDrive + "','"+ status + "'";
            dbCmd = new SqlCommand(sqlInsert, dbConn);

            int x = dbCmd.ExecuteNonQuery();
        }

        public void insertProblemLog(DateTime logDate, string staffID,string comment)// <admin> 1.1 prac 3
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();
            string sqlInsert = "sp_InsertProblemLog'" + logDate + "','" + staffID + "','" + comment + "'";
            dbCmd = new SqlCommand(sqlInsert, dbConn);

            int x = dbCmd.ExecuteNonQuery();
        }
        public void insertCategory(string catID,string catDescr)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            string sqlInsert = "sp_InsertCategory '" + catID + "','" + catDescr + "'";
            dbCmd = new SqlCommand(sqlInsert, dbConn);

            int x = dbCmd.ExecuteNonQuery();
        }
        public void insertStaff(string staffID,string surname,string fname,string role,string uName)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            string sqlInsert = "sp_InsertStaff '" + staffID + "','" + surname + "','" + fname + "','" +role + "','" + uName + "'";
            dbCmd = new SqlCommand(sqlInsert, dbConn);

            int x = dbCmd.ExecuteNonQuery();
        }
        //UPDATING DATABASE
        public void updateProblem(int problemID,string staffID,string status) // <admin>status is updated to "waiting" when allocate 1.1 prac 3
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            string sqlUpdate = "sp_UpdateProblem'" + problemID + "','" + staffID + "','" + status + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);

            int x = dbCmd.ExecuteNonQuery();
        }
        public void updateProblemLog(int proID, DateTime date,string staffID,string comment) //<staff> updates this 1.2 prac 3
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            string sqlUpdate = "sp_UpdateProblemLog '" + proID + "','" + date + "','" + staffID + "','" + comment + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);

            int x = dbCmd.ExecuteNonQuery();
        }
        public void updateProblemsForCloseAllProblems(DateTime date)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            string sqlUpdate = "sp_UpdateProblemsForCloseAllProblems '" + date + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);

            int x = dbCmd.ExecuteNonQuery();
        }
        public void updateProblemForCloseSelectedProblem(int probID, DateTime date)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            string sqlUpdate = "sp_UpdateProblemForCloseSelectedProblem '" + probID + "','" + date + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);

            int x = dbCmd.ExecuteNonQuery();
        }
        public void updateLoggedProblemsForCloseAllProblems(string date)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            string sqlUpdate = "sp_UpdateLoggedProblemsForCloseAllProblems'" + date + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);

            int x = dbCmd.ExecuteNonQuery();
        }
        public void updateLoggedProblemForSelectedProblems(int probID, string date)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            string sqlUpdate = "sp_UpdateLoggedProblemForSelectedProblem'" + probID + "','" + date + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);

            int x = dbCmd.ExecuteNonQuery();
        }
        public void updateTransferedStaff(int probID, string staffID)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            string sqlUpdate = "sp_UpdateTransferedStaff'" + probID + "','" + staffID + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);

            int x = dbCmd.ExecuteNonQuery();
        }
        public void updateEscalatedProblem(int probID, string priority)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            string sqlUpdate = "sp_UpdateEscalatedProblem'" + probID + "','" + priority + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);

            int x = dbCmd.ExecuteNonQuery();
        }
        //DELETE FROM DATABASE
        public void deleteCategory(string catId,string catDesc)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();
            string sqlDelete = "sp_DeleteCategory'" + catId + "','" + catDesc + "'";
            dbCmd = new SqlCommand(sqlDelete, dbConn);

            int x = dbCmd.ExecuteNonQuery();
        }
        public void deleteStaff(string staffID)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            string sqlDelete = "sp_DeleteStaff'" + staffID + "'";
            dbCmd = new SqlCommand(sqlDelete, dbConn);

            int x = dbCmd.ExecuteNonQuery();
        }

    }


}
