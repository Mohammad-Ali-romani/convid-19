using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class DBHnadler
    {
        employee emp;
        public DBHnadler()
        {
        }
        public DBHnadler(employee emp)
        {
            this.emp = emp;
        }
        public DataSet GetAllItems()
        {
            string sql = "select * from tblStudents";
            return ProjectDB.ExcuteDataSet(sql);
        }
        public employee GetItemsByID()
        {
            string sql = "select * from tblStudents where ID=" + emp.empId;
            DataTable tb = ProjectDB.ExcuteDataTable(sql);
            emp.Name = tb.Rows[0][1].ToString();
            emp.Gender = tb.Rows[0][2].ToString();
            emp.Marks = (int)tb.Rows[0][3];
            return emp;
        }
        public int UpdateItemByID(int id)
        {
            string sql = string.Format("update tblStudents set Name='{0}', Gender='{1}', TotalMarks={2} where ID={3}",
                emp.Name,
                emp.Gender,
                emp.Marks,
                id);
            return ProjectDB.ExcuteNonQuery(sql);
        }
        public int DelelteItemByID()
        {
            string sql = string.Format("delete from tblStudents where ID={0}",
                emp.empId);
            return ProjectDB.ExcuteNonQuery(sql);
        }
        public int AddNewItem()
        {
            string sql = string.Format("insert into tblStudents (Name,Gender,TotalMarks) values ('{0}',{1},{2})",
                emp.Name,
                emp.Gender,
                emp.Marks);
            return ProjectDB.ExcuteNonQuery(sql);
        }
        public object CountItems()
        {
            string sql = string.Format("select count(*) from tblStudents");
            return ProjectDB.ExcuteScalar(sql);
        }
    }
}