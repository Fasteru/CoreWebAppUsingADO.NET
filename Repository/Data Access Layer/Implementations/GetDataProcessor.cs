using Models;
using Repository.ConnectionFactory;
using Repository.Data_Access_Layer.Contracts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data_Access_Layer.Implementations
{
    public class GetDataProcessor : IGetData
    {
        private readonly IDbConnectionFactory _connectionFactory;

        public GetDataProcessor(IDbConnectionFactory dbConnectionFactory)
        {
            _connectionFactory = dbConnectionFactory;
        }
        public List<StudentsModel> GetStudentsData()
        {
            List<StudentsModel>? studentsList = new List<StudentsModel>();
            string queryString = "Select * from Student_table";
            var connection = _connectionFactory.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(queryString, connection);
            connection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                StudentsModel student = new StudentsModel()
                {

                    Student_Id = reader.GetInt32(0),
                    Student_Name = reader.GetString(1),
                    Class = reader.GetInt32(2),
                    Section = reader.GetString(3),
                    Gender = reader.GetString(4),
                    DateOfBirth = reader.GetDateTime(5)

                };
                studentsList.Add(student);
            }
            connection.Close();
            return studentsList;
        }
    }
}
