﻿using System;
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
            int max = 1;
            switch (tableName)
            {
                case "Worker":
                    List<Worker> w = GetWorkers();
                    foreach (Worker key in w)
                    {
                        if (max < int.Parse(key.Id))
                        {
                            max = int.Parse(key.Id);
                        }
                    }
                    break;
                case "Education":
                    List<Education> e = GetEducations();
                    foreach (Education key in e)
                    {
                        if (max < int.Parse(key.Id))
                        {
                            max = int.Parse(key.Id); ;
                        }
                    }
                    break;
                case "Experiance":
                    List<Experiance> c = GetExperiances();
                    foreach (Experiance key in c)
                    {
                        if (max < int.Parse(key.Id))
                        {
                            max = int.Parse(key.Id); ;
                        }
                    }
                    break;
            }
            return max;

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


            if (wantedSalary == "(Необов'язково)" || wantedSalary == "")
                wantedSalary = "0";
            if(wantedPosition == "(Необов'язково)")
                wantedPosition = "";
            if (cardNumber == "(Необов'язково)")
                cardNumber = "";
            try
            {
                com.Parameters.AddWithValue("param1", surname);
                com.Parameters.AddWithValue("param2", name);
                com.Parameters.AddWithValue("param3", secondName);
                com.Parameters.AddWithValue("param4", city);
                com.Parameters.AddWithValue("param5", address);
                com.Parameters.AddWithValue("param6", sex);
                com.Parameters.AddWithValue("param7", maritalStatus);
                com.Parameters.AddWithValue("param8", birthDate);
                com.Parameters.AddWithValue("param9", int.Parse(wantedSalary));
                com.Parameters.AddWithValue("param10", wantedPosition);
                com.Parameters.AddWithValue("param11", cardNumber);
                com.Parameters.AddWithValue("param12", int.Parse(childrenCount));
            }
            catch (Exception)
            {

            }



            con.Open();
            try
            {
                int rows = com.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }

            con.Close();

        }



        public void InsertEducation(string name, string type, string owner, string location,
            string startDate, string finishDate, string faculty, string isFinished)
        {
            SqlConnection con = new SqlConnection(conString);
            int workerId = GetLastId("Worker");
            bool f = false;

            string queryText = "INSERT INTO Education (name, type, owner, location, workerId, startDate, finishDate, faculty, isFinished) VALUES " +
                "(@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9);";
            SqlCommand com = new SqlCommand(queryText, con);
            if(isFinished == "Так")
            {
                f = true;
            }
            try { 
            com.Parameters.AddWithValue("param1", name);
            com.Parameters.AddWithValue("param2", type);
            com.Parameters.AddWithValue("param3", owner);
            com.Parameters.AddWithValue("param4", location);
            com.Parameters.AddWithValue("param5", workerId);
            com.Parameters.AddWithValue("param6", startDate);
            com.Parameters.AddWithValue("param7", finishDate);
            com.Parameters.AddWithValue("param8", faculty);
            com.Parameters.AddWithValue("param9", f);
            }
            catch (Exception)
            {

            }
            con.Open();
            try
            {
                int rows = com.ExecuteNonQuery();
            }
            catch(Exception)
            {

            }

            con.Close();
        }


        public void InsertExperience(string name, string size, string ceo, string type, string position,
            string salary, string startDate, string finishDate)
        {
            try { 
                SqlConnection con = new SqlConnection(conString);
                int workerId = GetLastId("Worker");

                string queryText = "INSERT INTO Experiance (name, size, CEO, type, workerId, position, salary, startDate, finishDate) VALUES " +
                    "(@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9);";

                SqlCommand com = new SqlCommand(queryText, con);
              
                com.Parameters.AddWithValue("param1", name);
                com.Parameters.AddWithValue("param2", size);
                com.Parameters.AddWithValue("param3", ceo);
                com.Parameters.AddWithValue("param4", type);
                com.Parameters.AddWithValue("param5", workerId);
                com.Parameters.AddWithValue("param6", position);
                com.Parameters.AddWithValue("param7", int.Parse(salary));
                com.Parameters.AddWithValue("param8", startDate);
                com.Parameters.AddWithValue("param9", finishDate);
                con.Open();
                int rows = com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

            }
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
            List<Worker> l = new List<Worker>();
            Worker w = new Worker();
            try
            {
                SqlConnection con = new SqlConnection(conString);
                SqlCommand com = new SqlCommand("SELECT * FROM Worker WHERE id=@id", con);
                com.Parameters.AddWithValue("id", id);
                con.Open();

                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
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
                }
                dr.Close();
                con.Close();
            }
            catch (Exception) { }

            l.Add(w);
            return l;
        }

        public List<Education> GetEducation(int id)
        {
            List<Education> l = new List<Education>();
            Education e = new Education();
            try
            {
                SqlConnection con = new SqlConnection(conString);
                SqlCommand com = new SqlCommand("SELECT * FROM Education WHERE id = @id", con);
                com.Parameters.AddWithValue("id", id);
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
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
                }
                dr.Close();
                con.Close();
            }
            catch (Exception)
            {

            }
            l.Add(e);
            return l;
        }

        public List<Experiance> GetExperiance(int id)
        {
            List<Experiance> l = new List<Experiance>();
            Experiance e = new Experiance();

            try
            {
                SqlConnection con = new SqlConnection(conString);
                SqlCommand com = new SqlCommand("SELECT * FROM Experiance WHERE id = @id", con);
                com.Parameters.AddWithValue("id", id);
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
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
                }
                dr.Close();
                con.Close();
            } catch(Exception)
            {
            }

            l.Add(e);
            return l;
        }


        public void UpdateWorker(string id, string surname, string name, string secondName, string city, string address, string sex, string maritalStatus,
            string birthDate, string wantedSalary, string wantedPosition, string cardNumber, string childrenCount)
        {
            SqlConnection con = new SqlConnection(conString);

            string queryText = "UPDATE Worker SET surname = @surname, name = @name, secondName = @secondName, city = @city, address = @address," +
                " sex = @sex, maritalStatus = @maritalStatus, birthDate = @birthDate, wantedSalary = @wantedSalary," +
             "wantedPosition = @wantedPosition, cardNumber = @cardNumber, childrenCount = @childrenCount WHERE id = @id";

            SqlCommand com = new SqlCommand(queryText, con);

            com.Parameters.AddWithValue("id", int.Parse(id));
            com.Parameters.AddWithValue("surname", surname);
            com.Parameters.AddWithValue("name", name);
            com.Parameters.AddWithValue("secondName", secondName);
            com.Parameters.AddWithValue("city", city);
            com.Parameters.AddWithValue("address", address);
            com.Parameters.AddWithValue("sex", sex);
            com.Parameters.AddWithValue("maritalStatus", maritalStatus);
            com.Parameters.AddWithValue("birthDate", birthDate);
            com.Parameters.AddWithValue("wantedSalary", int.Parse(wantedSalary));
            com.Parameters.AddWithValue("wantedPosition", wantedPosition);
            com.Parameters.AddWithValue("cardNumber", cardNumber);
            com.Parameters.AddWithValue("childrenCount", int.Parse(childrenCount));

            con.Open();
            int rows = com.ExecuteNonQuery();
            con.Close();

            
        }

        public void UpdateEducation(string id, string name, string type, string owner, string location, string startDate, string finishDate, 
            string faculty,string isFinished)
        {
            SqlConnection con = new SqlConnection(conString);

            string queryText = "Update Education SET name = @param1, type = @param2, owner = @param3, location = @param4, startDate = @param5," +
                " finishDate = @param6, faculty = @param7, isFinished = @param8 WHERE id = @id";
            SqlCommand com = new SqlCommand(queryText, con);

            if (isFinished == "Так")
            {
                isFinished = "1";
            }
            else if (isFinished  == "Ні")
            {
                isFinished = "0";
            }

            com.Parameters.AddWithValue("id", int.Parse(id));
            com.Parameters.AddWithValue("param1", name);
            com.Parameters.AddWithValue("param2", type);
            com.Parameters.AddWithValue("param3", owner);
            com.Parameters.AddWithValue("param4", location);
            com.Parameters.AddWithValue("param5", startDate);
            com.Parameters.AddWithValue("param6", finishDate);
            com.Parameters.AddWithValue("param7", faculty);
            com.Parameters.AddWithValue("param8", isFinished);
            

            con.Open();
            int rows = com.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateExperiance(int id, string name, int size, string ceo, string type, string position, int salary, string startDate, string finishDate)
        {
            SqlConnection con = new SqlConnection(conString);

            string queryText = "UPDATE Experiance SET name = @name, size = @size, CEO = @ceo, type = @type, position = @position," +
                " salary = @salary, startDate = @startDate, finishDate = @finishDate WHERE id = @id ";
            SqlCommand com = new SqlCommand(queryText, con);
            com.Parameters.AddWithValue("id", id);
            com.Parameters.AddWithValue("name", name);
            com.Parameters.AddWithValue("size", size);
            com.Parameters.AddWithValue("ceo", ceo);
            com.Parameters.AddWithValue("type", type);
            com.Parameters.AddWithValue("position", position);
            com.Parameters.AddWithValue("salary", salary);
            com.Parameters.AddWithValue("startDate", startDate);
            com.Parameters.AddWithValue("finishDate", finishDate);
            con.Open();
            int rows = com.ExecuteNonQuery();
            con.Close();
        }

        public List<Worker> SelectFromWorkers(string surname, string name, string city, string address, string maritalStatus,
            string wantedSalary, string wantedPosition, string childrenCount)
        {
            List<Worker> l = new List<Worker>();
            
            try
            {
                SqlConnection con = new SqlConnection(conString);
                SqlCommand com = new SqlCommand("SELECT * FROM Worker", con);
                if (city != "" && maritalStatus != "")
                {
                    com = new SqlCommand("SELECT * FROM Worker WHERE city = @city AND maritalStatus = @maritalStatus", con);
                    com.Parameters.AddWithValue("city", city);
                    com.Parameters.AddWithValue("maritalStatus", maritalStatus);
                }else if (wantedSalary != "" && wantedPosition != "")
                {
                    com = new SqlCommand("SELECT * FROM Worker WHERE wantedSalary < @wantedSalary AND wantedPosition = @wantedPosition", con);
                    com.Parameters.AddWithValue("wantedSalary", int.Parse(wantedSalary));
                    com.Parameters.AddWithValue("wantedPosition", wantedPosition);
                } else if (surname != "" && name != "")
                {
                    com = new SqlCommand("SELECT * FROM Worker WHERE surname = @surname AND name = @name", con);
                    com.Parameters.AddWithValue("surname", surname);
                    com.Parameters.AddWithValue("name", name);
                }
                else if (surname != "")
                {
                    com = new SqlCommand("SELECT * FROM Worker WHERE surname = @surname", con);
                    com.Parameters.AddWithValue("surname", surname);
                }
                else if (city != "")
                {
                    com = new SqlCommand("SELECT * FROM Worker WHERE city = @city", con);
                    com.Parameters.AddWithValue("city", city);
                } else if (address != "")
                {
                    com = new SqlCommand("SELECT * FROM Worker WHERE address = @address", con);
                    com.Parameters.AddWithValue("address", address);
                } else if(maritalStatus != "")
                {
                    com = new SqlCommand("SELECT * FROM Worker WHERE maritalStatus = @maritalStatus", con);
                    com.Parameters.AddWithValue("maritalStatus", maritalStatus);
                } else if(wantedSalary != "")
                {
                    com = new SqlCommand("SELECT * FROM Worker WHERE wantedSalary < @wantedSalary", con);
                    com.Parameters.AddWithValue("wantedSalary", int.Parse(wantedSalary));
                } else if(wantedPosition != "")
                {
                    com = new SqlCommand("SELECT * FROM Worker WHERE wantedPosition =  @wantedPosition", con);
                    com.Parameters.AddWithValue("wantedPosition", wantedPosition);
                } else if(childrenCount != "")
                {
                    com = new SqlCommand("SELECT * FROM Worker WHERE childrenCount <  @childrenCount", con);
                    com.Parameters.AddWithValue("childrenCount", int.Parse(childrenCount));
                }


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
                    l.Add(w);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception) { }
            return l;
        }


        public List<Education> SelectFromEducation(string name, string type, string owner, string faculty)
        {
            List<Education> l = new List<Education>();

            try
            {
                SqlConnection con = new SqlConnection(conString);
                SqlCommand com = new SqlCommand("SELECT * FROM Education", con);
                if (type != "" && faculty != "")
                {
                    com = new SqlCommand("SELECT * FROM Education WHERE type = @type AND faculty = @faculty", con);
                    com.Parameters.AddWithValue("type", type);
                    com.Parameters.AddWithValue("faculty", faculty);
                } else
                if (type != "" && owner != "")
                {
                    com = new SqlCommand("SELECT * FROM Education WHERE type = @type AND owner = @owner", con);
                    com.Parameters.AddWithValue("type", type);
                    com.Parameters.AddWithValue("owner", owner);
                }
                else if (faculty != "")
                {
                    com = new SqlCommand("SELECT * FROM Education WHERE faculty = @faculty", con);
                    com.Parameters.AddWithValue("faculty", faculty);
                } else
                if (type != "")
                {
                    com = new SqlCommand("SELECT * FROM Education WHERE type = @type", con);
                    com.Parameters.AddWithValue("type", type);
                }
                else if (owner != "")
                {
                    com = new SqlCommand("SELECT * FROM Education WHERE owner = @owner", con);
                    com.Parameters.AddWithValue("owner", owner);
                }
                else
                if (name != "")
                {
                    com = new SqlCommand("SELECT * FROM Education WHERE name = @name", con);
                    com.Parameters.AddWithValue("name", name);
                }
                
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
                    l.Add(e);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception) { }
            return l;
        }

        public List<Experiance> SelectFromExperiance(string name, string size, string ceo, string type)
        {
            List<Experiance> l = new List<Experiance>();

            try
            {
                SqlConnection con = new SqlConnection(conString);
                SqlCommand com = new SqlCommand("SELECT * FROM Experiance", con);
                if (type != "")
                {
                    com = new SqlCommand("SELECT * FROM Experiance WHERE type = @type", con);
                    com.Parameters.AddWithValue("type", type);
                }
                else
                if (ceo != "")
                {
                    com = new SqlCommand("SELECT * FROM Experiance WHERE ceo = @ceo", con);
                    com.Parameters.AddWithValue("ceo", ceo);
                }
                else
                if (size != "")
                {
                    com = new SqlCommand("SELECT * FROM Experiance WHERE size > @size", con);
                    com.Parameters.AddWithValue("size", size);
                }
                else
                if (name != "")
                {
                    com = new SqlCommand("SELECT * FROM Experiance WHERE name = @name", con);
                    com.Parameters.AddWithValue("name", name);
                }

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
                    l.Add(e);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception) { }
            return l;
        }
    }
}
