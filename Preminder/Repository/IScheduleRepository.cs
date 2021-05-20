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
    public interface IScheduleRepository
    {
        List<Schedule> GetAll();
        void Add(string coursee, string day, string hour);
        void Update(int id, string course, string day, string hour);
        void Delete(int id);
    }

    public class ScheduleRepository : IScheduleRepository
    {
        static string pathDB = Path.GetFullPath(Environment.CurrentDirectory) + @"\Database\";
        static string DbName = "PreminderDataSet.mdf";
        string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + pathDB + DbName + ";Integrated Security=True";

        public List<Schedule> GetAll()
        {
            List<Schedule> listSchedule = new List<Schedule>();
            
            SqlConnection con = new SqlConnection(connstring);
            string sql = "select * from TblCourseSchedule";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Schedule newSchedule = new Schedule();

                newSchedule.Id = (int)dr["Id"];
                newSchedule.Course = dr["Course"].ToString();
                newSchedule.Day = dr["Day"].ToString();
                newSchedule.Hour = dr["Hour"].ToString();

                listSchedule.Add(newSchedule);
            }

            return listSchedule;
        }

        public void Add(string course, string day, string hour)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "insert into TblCourseSchedule(Course, Day, Hour) values('" + course + "','" + day + "','" + hour + "')";
            
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(int id)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "delete from TblCourseSchedule where Id = @Id";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Update(int id, string course, string day, string hour)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "update TblCourseSchedule set Course = @course, Day = @day, Hour = @hour where Id = @id";
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@course", course);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@day", day);
            cmd.Parameters.AddWithValue("@hour", hour);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
