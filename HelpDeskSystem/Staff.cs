using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HelpDeskSystem
{
    class Staff
    {
        DataAccessLayer dl = new DataAccessLayer();
        public string StaffID { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string StaffRole { get; set; }
        public string StaffUsername { get; set; }
        public Staff()
        {

        }
        public DataTable GetStaff()
        {
            return dl.getStaff();
        }
        public DataTable GetStaffToTransfer()
        {
            return dl.getStaffToTransfer();
        }
        public DataTable GetStaffLogin(string staffID, string staffUsername)
        {
            return dl.getStaffLogin(staffID, staffUsername);
        }
        public void InsertStaff(string staffID,string surname,string fName,string role,string username)
        {
            dl.insertStaff(staffID,surname ,fName,role,username);
        }
        public void DeleteStaff(string staffID)
        {
            dl.deleteStaff(staffID);
        }
    }
}
