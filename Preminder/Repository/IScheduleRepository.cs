using Preminder.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SqlClient;

namespace Preminder.Repository
{
    // Interface
    public interface IScheduleRepository
    {
        List<Schedule> GetAll();
        void Add(string coursee, string day, string hour);
        void Update(int id, string course, string day, string hour);
        void Delete(int id);
    }


    // Class
    public class ScheduleRepository : IScheduleRepository
    {
        // Variables
        readonly string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\PreminderDataSet.mdf;Integrated Security=True";


        // Methods

        /// <summary>
        /// Method untuk mendapatkan data dari tabel CourseSchedule pada database, serta nengurutkan berdasarkan Hari dan Jam
        /// </summary>
        /// <returns></returns>
        public List<Schedule> GetAll()
        {
            List<Schedule> listSchedule = new List<Schedule>();
            
            SqlConnection con = new SqlConnection(connstring);
            string sql = "SELECT * FROM TblCourseSchedule ORDER BY case when Day = 'Senin' then 1 when Day = 'Selasa' then 2 when Day = 'Rabu' then 3 when Day = 'Kamis' then 4 when Day = 'Jumat' then 5 when Day = 'Sabtu' then 6 when Day = 'Minggu' then 7 else NULL end, Hour" ;

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

        /// <summary>
        /// Method untuk menambahkan data ke dalam tabel CourseSchedule pada database
        /// </summary>
        /// <param name="course"></param>
        /// <param name="day"></param>
        /// <param name="hour"></param>
        public void Add(string course, string day, string hour)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "insert into TblCourseSchedule(Course, Day, Hour) values('" + course + "','" + day + "','" + hour + "')";
            
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Method untuk menghapus data di tabel CourseSchedule pada database
        /// </summary>
        /// <param name="id"></param>
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

        /// <summary>
        /// Method untuk mengupdate data di tabel CourseSchedule pada database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="course"></param>
        /// <param name="day"></param>
        /// <param name="hour"></param>
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
