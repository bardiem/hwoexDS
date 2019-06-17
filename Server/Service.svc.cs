using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Server
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {

        private string conString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog = hwoex; Integrated Security = True";


        private int GetLastId(string tableName)
        {

            SqlConnection con = new SqlConnection(conString);
            SqlCommand com = new SqlCommand("Select TOP 1 id from @table order by id desc;", con);
            con.Open();
            com.Parameters.AddWithValue("table", tableName);
            SqlDataReader dr = com.ExecuteReader();
            int count = int.Parse(dr.Read().ToString());
            dr.Close();
            con.Close();
            return count;

        }


        public string GetData()
        {
            return "12345";
        }



        public int GetTableCount(string tableName)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand com = new SqlCommand("SELECT count(*) FROM " + tableName, con);
            con.Open();

            SqlDataReader dr = com.ExecuteReader();
            int count = int.Parse(dr.Read().ToString());
            dr.Close();
            con.Close();
            return count;

        }




        public List<Education> GetEducations()
        {
            List<Education> list = new List<Education>();

            SqlConnection con = new SqlConnection(conString);
            SqlCommand com = new SqlCommand("SELECT * FROM Education", con);

            con.Open();

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                Education e = new Education();
                e.Id = dr[0].ToString();
                e.Name = dr[1].ToString();
                e.WorkerId = dr[2].ToString();
                e.StartDate = dr[3].ToString();
                e.FinishDate = dr[4].ToString();
                e.Faculty = dr[5].ToString();
                e.IsFinished = dr[6].ToString();
                e.Type = dr[7].ToString();
                e.Owner = dr[8].ToString();
                e.Location = dr[9].ToString();
                list.Add(e);
            }

            dr.Close();
            con.Close();
            return list;
        }



        public List<Experiance> GetExperiances()
        {
            List<Experiance> list = new List<Experiance>();

            SqlConnection con = new SqlConnection(conString);
            SqlCommand com = new SqlCommand("SELECT * FROM Experiance", con);

            con.Open();

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                Experiance e = new Experiance();
                e.Id = dr[0].ToString();
                e.Name = dr[1].ToString();
                e.Size = dr[2].ToString();
                e.Ceo = dr[3].ToString();
                e.Type = dr[4].ToString();
                e.WorkerId = dr[5].ToString();
                e.Position = dr[6].ToString();
                e.Salary = dr[7].ToString();
                e.StartDate = dr[8].ToString();
                e.FinishDate = dr[9].ToString();
                list.Add(e);
            }

            dr.Close();
            con.Close();
            return list;
        }



        public List<Worker> GetWorkers()
        {
            List<Worker> list = new List<Worker>();

            SqlConnection con = new SqlConnection(conString);
            SqlCommand com = new SqlCommand("SELECT * FROM Worker", con);

            con.Open();

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                Worker w = new Worker();
                w.Id = dr[0].ToString();
                w.Surname = dr[1].ToString();
                w.Name = dr[2].ToString();
                w.SecondName = dr[3].ToString();
                w.City = dr[4].ToString();
                w.Address = dr[5].ToString();
                w.Sex = dr[6].ToString();
                w.MaritalStatus = dr[7].ToString();
                w.BirthDate = dr[8].ToString();
                w.WantedSalary = dr[9].ToString();
                w.WantedPosition = dr[10].ToString();
                w.CardNumber = dr[11].ToString();
                w.ChildrenCount = dr[12].ToString();
                list.Add(w);
            }

            dr.Close();
            con.Close();
            return list;
        }




        public void InsertWorker(string surname, string name, string secondName, string city, string address, string sex, string maritalStatus,
            string birthDate, string wantedSalary, string wantedPosition, string cardNumber, string childrenCount)
        {
            SqlConnection con = new SqlConnection(conString);

            string queryText = "INSERT INTO Worker (surname, name, secondName, city, address, sex, maritalStatus, birthDate, wantedSalary," +
             "wantedPosition, cardNumber, childrenCount) VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, " +
             "@param9, @param10, @param11, @param12);";
            
            
            SqlCommand com = new SqlCommand(queryText, con);

            /*char[] cBDate = birthDate.ToCharArray();
            string[] bDate = new string[2];
            for (int i = 0; i < 3; i++)
            {
                bDate[0] += cBDate[i];
            }

            for (int i = 4; i < 6; i++)
            {
                bDate[1] += cBDate[i];
            }

            for (int i = 7; i < 9; i++)
            {
                bDate[1] += cBDate[i];
            }*/

            com.Parameters.AddWithValue("param1", surname);
            com.Parameters.AddWithValue("param2", name);
            com.Parameters.AddWithValue("param3", secondName);
            com.Parameters.AddWithValue("param4", city);
            com.Parameters.AddWithValue("param5", address);
            com.Parameters.AddWithValue("param6", sex);
            com.Parameters.AddWithValue("param7", maritalStatus);
            //com.Parameters.AddWithValue("param8", new DateTime(int.Parse(bDate[0]), int.Parse(bDate[1]), int.Parse(bDate[2])));
            com.Parameters.AddWithValue("param8", birthDate);
            com.Parameters.AddWithValue("param9", int.Parse(wantedSalary));
            com.Parameters.AddWithValue("param10", wantedPosition);
            com.Parameters.AddWithValue("param11", cardNumber);
            com.Parameters.AddWithValue("param12", int.Parse(childrenCount));



            con.Open();

            int rows = com.ExecuteNonQuery();

            con.Close();

        }



        public void InsertEducation(string name, string type, string owner, string location,
            string startDate, string finishDate, string faculty, string isFinished)
        {
            SqlConnection con = new SqlConnection(conString);
            int workerId = GetLastId("Worker");

            string queryText = "INSERT INTO Education (name, type, owner, location, workerId, startDate, finishDate, faculty, isFinished) VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, " +
             "@param9, @param10, @param11, @param12);";

            SqlCommand com = new SqlCommand(queryText, con);
            con.Open();
            int rows = com.ExecuteNonQuery();
            con.Close();
        }


        public void InsertExperience(string name, string size, string ceo, string type, string position,
            string salary, string startDate, string finishDate)
        {
            SqlConnection con = new SqlConnection(conString);
            int workerId = GetLastId("Worker");

            string queryText = "INSERT INTO School (name, size, CEO, type, workerId, position, salary, startDate, finishDate) VALUES ('" +
                name + "','" + size + "','" + ceo + "','" + type + "','" + workerId + "','" + position + "','" + salary + "','" +
                "','" + startDate + "','" + finishDate + "');";

            SqlCommand com = new SqlCommand(queryText, con);
            con.Open();
            int rows = com.ExecuteNonQuery();
            con.Close();
        }



        public void DeleteTable(string tableName, int id)
        {
            SqlConnection con = new SqlConnection(conString);

            string queryText = "DELETE FROM " + tableName + " WHERE id = " + id;

            SqlCommand com = new SqlCommand(queryText, con);
            con.Open();
            int rows = com.ExecuteNonQuery();
            con.Close();
        }

        public List<Worker> GetWorker(int id)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand com = new SqlCommand("SELECT * FROM Worker WHERE id = " + id, con);

            con.Open();

            SqlDataReader dr = com.ExecuteReader();

            Worker w = new Worker();
            w.Id = dr[0].ToString();
            w.Surname = dr[1].ToString();
            w.Name = dr[2].ToString();
            w.SecondName = dr[3].ToString();
            w.City = dr[4].ToString();
            w.Address = dr[5].ToString();
            w.Sex = dr[6].ToString();
            w.MaritalStatus = dr[7].ToString();
            w.BirthDate = dr[8].ToString();
            w.WantedSalary = dr[9].ToString();
            w.WantedPosition = dr[10].ToString();
            w.CardNumber = dr[11].ToString();
            w.ChildrenCount = dr[12].ToString();

            dr.Close();
            con.Close();
            List<Worker> l = new List<Worker>();
            l.Add(w);
            return l;
        }

        public List<Education> GetEducation(int id)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand com = new SqlCommand("SELECT * FROM Education WHERE id =" + id, con);

            con.Open();

            SqlDataReader dr = com.ExecuteReader();

            Education e = new Education();
            e.Id = dr[0].ToString();
            e.Name = dr[1].ToString();
            e.WorkerId = dr[2].ToString();
            e.StartDate = dr[3].ToString();
            e.FinishDate = dr[4].ToString();
            e.Faculty = dr[5].ToString();
            e.IsFinished = dr[6].ToString();
            e.Type = dr[7].ToString();
            e.Owner = dr[8].ToString();
            e.Location = dr[9].ToString();

            dr.Close();
            con.Close();
            List<Education> l = new List<Education>();
            l.Add(e);
            return l;
        }

        public List<Experiance> GetExperiance(int id)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand com = new SqlCommand("SELECT * FROM Experiance WHERE id = " + id, con);

            con.Open();

            SqlDataReader dr = com.ExecuteReader();

            Experiance e = new Experiance();
            e.Id = dr[0].ToString();
            e.Name = dr[1].ToString();
            e.Size = dr[2].ToString();
            e.Ceo = dr[3].ToString();
            e.Type = dr[4].ToString();
            e.WorkerId = dr[5].ToString();
            e.Position = dr[6].ToString();
            e.Salary = dr[7].ToString();
            e.StartDate = dr[8].ToString();
            e.FinishDate = dr[9].ToString();

            dr.Close();
            con.Close();
            List<Experiance> l = new List<Experiance>();
            l.Add(e);
            return l;
        }
    }
}
