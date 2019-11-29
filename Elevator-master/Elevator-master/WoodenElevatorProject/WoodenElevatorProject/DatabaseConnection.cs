using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WoodenElevatorProject
{
    class DatabaseConnection
    {
        public static OleDbConnection cn;
        public static void DbConnection()
        {
            try
            {
                cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source=./AppData/ElevatorDatabase.accdb");
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
