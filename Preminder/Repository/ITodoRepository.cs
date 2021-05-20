using Preminder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace Preminder.Repository
{
    public interface ITodoRepository
    {
        List<ToDoList> GetAllToDo();

        void Add(ToDoList toDoList);
        bool Remove(int no);
    }

    public class TodoRepository : ITodoRepository
    {
        static string pathDB = Path.GetFullPath(Environment.CurrentDirectory) + @"\Database\";
        static string DbName = "PreminderDataSet.mdf";
        string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + pathDB + DbName + ";Integrated Security=True";

        public void Add(ToDoList toDoList)
        {
            throw new NotImplementedException();
        }

        public List<ToDoList> GetAllToDo()
        {
            List<ToDoList> listToDo = new List<ToDoList>();

            SqlConnection con = new SqlConnection(connstring);
            string sql = "select * from TBTugas";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ToDoList newToDo = new ToDoList();

                newToDo.No = (int)dr["No"];
                newToDo.Tugas = dr["Tugas"].ToString();
                newToDo.Tenggat_Pengumpulan = dr["Tenggat_Pengumpulan"].ToString();
                newToDo.Keterangan = dr["Keterangan"].ToString();

                listToDo.Add(newToDo);
            }

            return listToDo;
        }

        public bool Remove(int no)
        {
            throw new NotImplementedException();
        }

    }
}
