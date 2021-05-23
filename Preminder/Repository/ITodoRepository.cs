using Preminder.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SqlClient;

namespace Preminder.Repository
{
    // Interface
    public interface ITodoRepository
    {
        List<ToDoList> GetAllToDo();

        void Add(ToDoList toDoList);
        bool Remove(int no);
    }


    // Class
    public class TodoRepository : ITodoRepository
    {
        // Variables
        readonly private static string connstring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Preminder\Preminder\Database\PreminderDataSet.mdf;Integrated Security = True";


        // Methods

        /// <summary>
        /// Method untuk mendapatkan data dari tabel Tugas pada database
        /// </summary>
        /// <returns></returns>
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

        public void Add(ToDoList toDoList)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int no)
        {
            throw new NotImplementedException();
        }
    }
}
