using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Server
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData();

        [OperationContract]
        int GetTableCount(string tableName);

        [OperationContract]
        List<Worker> GetWorkers();

        [OperationContract]
        List<Education> GetEducations();

        [OperationContract]
        List<Experiance> GetExperiances();

        [OperationContract]
        void InsertWorker(string surname, string name, string secondName, string city, string address, string sex, string maritalStatus,
            string birthDate, string wantedSalary, string wantedPosition, string cardNumber, string childrenCount);

        [OperationContract]
        void InsertEducation(string name, string startDate, string finishDate, string faculty, string isFinished,
        string type, string owner, string location);

        [OperationContract]
        void InsertExperience(string name, string size, string ceo, string type, string position,
            string salary, string startDate, string finishDate);

        [OperationContract]
        void DeleteTable(string tableName, int id);

        [OperationContract]
        List<Worker> GetWorker(int id);

        [OperationContract]
        List<Education> GetEducation(int id);

        [OperationContract]
        List<Experiance> GetExperiance(int id);

        [OperationContract]
        void UpdateWorker(string id, string surname, string name, string secondName, string city, string address, string sex, string maritalStatus,
            string birthDate, string wantedSalary, string wantedPosition, string cardNumber, string childrenCount);

        [OperationContract]
        void UpdateEducation(string id, string name, string type, string owner, string location, string startDate, string finishDate,
            string faculty, string isFinished);

        [OperationContract]
        void UpdateExperiance(int id, string name, int size, string ceo, string type, string position, int salary, string startDate, string finishDate);


        [OperationContract]
        List<Worker> SelectFromWorkers();

        [OperationContract]
        List<Education> SelectFromEducation();

        [OperationContract]
        List<Experiance> SelectFromExperiance();


    }


    [DataContract]
    public class Worker
    {

        string id;
        string surname;
        string name;
        string secondName;
        string city;
        string address;
        string sex;
        string maritalStatus;
        string birthDate;
        string wantedSalary;
        string wantedPosition;
        string cardNumber;
        string childrenCount;


        [DataMember]
        public string Id { get => id; set => id = value; }
        [DataMember]
        public string Surname { get => surname; set => surname = value; }
        [DataMember]
        public string Name { get => name; set => name = value; }
        [DataMember]
        public string SecondName { get => secondName; set => secondName = value; }
        [DataMember]
        public string City { get => city; set => city = value; }
        [DataMember]
        public string Address { get => address; set => address = value; }
        [DataMember]
        public string Sex { get => sex; set => sex = value; }
        [DataMember]
        public string MaritalStatus { get => maritalStatus; set => maritalStatus = value; }
        [DataMember]
        public string BirthDate { get => birthDate; set => birthDate = value; }
        [DataMember]
        public string WantedSalary { get => wantedSalary; set => wantedSalary = value; }
        [DataMember]
        public string WantedPosition { get => wantedPosition; set => wantedPosition = value; }
        [DataMember]
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        [DataMember]
        public string ChildrenCount { get => childrenCount; set => childrenCount = value; }

    }


    [DataContract]
    public class Education
    {
        string id;
        string name;
        string workerId;
        string startDate;
        string finishDate;
        string faculty;
        string isFinished;
        string type;
        string owner;
        string location;


        [DataMember]
        public string Id { get => id; set => id = value; }
        [DataMember]
        public string Name { get => name; set => name = value; }
        [DataMember]
        public string WorkerId { get => workerId; set => workerId = value; }
        [DataMember]
        public string StartDate { get => startDate; set => startDate = value; }
        [DataMember]
        public string FinishDate { get => finishDate; set => finishDate = value; }
        [DataMember]
        public string Faculty { get => faculty; set => faculty = value; }
        [DataMember]
        public string IsFinished { get => isFinished; set => isFinished = value; }
        [DataMember]
        public string Type { get => type; set => type = value; }
        [DataMember]
        public string Owner { get => owner; set => owner = value; }
        [DataMember]
        public string Location { get => location; set => location = value; }
    }

    [DataContract]
    public class Experiance
    {

        string id;
        string name;
        string size;
        string ceo;
        string type;
        string workerId;
        string position;
        string salary;
        string startDate;
        string finishDate;

        [DataMember]
        public string Id { get => id; set => id = value; }
        [DataMember]
        public string Name { get => name; set => name = value; }
        [DataMember]
        public string Size { get => size; set => size = value; }
        [DataMember]
        public string Ceo { get => ceo; set => ceo = value; }
        [DataMember]
        public string Type { get => type; set => type = value; }
        [DataMember]
        public string WorkerId { get => workerId; set => workerId = value; }
        [DataMember]
        public string Position { get => position; set => position = value; }
        [DataMember]
        public string Salary { get => salary; set => salary = value; }
        [DataMember]
        public string StartDate { get => startDate; set => startDate = value; }
        [DataMember]
        public string FinishDate { get => finishDate; set => finishDate = value; }

    }

}
