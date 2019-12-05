using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WoodenElevatorProject
{
    class DatabaseConnection
    {

        String con;
        public DataSet ds;
        public OleDbCommand cmd;
        public OleDbConnection oldb;
        public OleDbDataAdapter da;
        public OleDbCommandBuilder cb;
        public DatabaseConnection()
        {
            try
            {

                con = @"Provider = Microsoft.ACE.OLEDB.12.0; data source =./Elevator.accdb";
                oldb = new OleDbConnection(con);
                cmd = new OleDbCommand();
                cmd.Connection = oldb;
                cmd.CommandText = "Select * from ElevatorRecord";
                da = new OleDbDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                cb = new OleDbCommandBuilder(da);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public DataSet DisplayQuery()
        {
            return ds;
        }
        public void InsertQuery(String logaction)
        {
            DataRow dr = ds.Tables[0].NewRow();
            dr[1] = DateTime.Now.ToShortDateString();
            dr[2] = DateTime.Now.ToShortTimeString();
            dr[3] = logaction;
            ds.Tables[0].Rows.Add(dr);
            
        }
        public void Save()
        {
            DataSet anotherds = ds.GetChanges();
            da.Update(anotherds);
            ds.Tables[0].AcceptChanges();
        }
    }
}