using ScheduleModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PairRepository
    {
        public void CreateNewPair(Pair pair)
        {
            int scheduleId = InsertSchedule(pair.Day, 
                                            pair.Type, 
                                            pair.NumberOfPair,
                                            pair.Subject);

            pair.Tutors.
                ToList().
                ForEach(x => InsertScheduleTutor(scheduleId, x));

            pair.Auditoriums.
                ToList().
                ForEach(x => InsertScheduleAuditorium(scheduleId, x));

            pair.Groups.
                ToList().
                ForEach(x => InsertScheduleGroup(scheduleId, x));
        }

        private int InsertSchedule(string day, 
                                   string type, 
                                   int number, 
                                   string subject)
        {
            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager
                .ConnectionStrings["ScheduleDBConnectionString"].ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("CreatePair", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("day_name", day);
                command.Parameters.AddWithValue("name_couple_type", type);
                command.Parameters.AddWithValue("subject", subject);
                command.Parameters.AddWithValue("couple_number", number);

                var result = command.ExecuteScalar();
                return (int)result;
            }
        }

        private void InsertScheduleTutor(int scheduleId, string tutorName)
        {
            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager
                .ConnectionStrings["ScheduleDBConnectionString"].ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("AddTutorForPair", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("scheduleId", scheduleId);
                command.Parameters.AddWithValue("tutorName", tutorName);

                command.ExecuteNonQuery();
            }
        }

        private void InsertScheduleAuditorium(int scheduleId, int auditorium)
        {
            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager
                .ConnectionStrings["ScheduleDBConnectionString"].ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("AddAuditoriumForPair", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("scheduleId", scheduleId);
                command.Parameters.AddWithValue("auditorium", auditorium);

                command.ExecuteNonQuery();
            }
        }

        private void InsertScheduleGroup(int scheduleId, string groupName)
        {
            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager
                .ConnectionStrings["ScheduleDBConnectionString"].ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("AddGroupsForPair", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("scheduleId", scheduleId);
                command.Parameters.AddWithValue("groupName", groupName);

                command.ExecuteNonQuery();
            }
        }
    }
}
