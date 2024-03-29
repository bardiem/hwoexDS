﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Net;
using System.IO;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Data;
using hwoexClient.Service;


namespace hwoexClient
{
    public class UseDB
    {

        private Service1Client service;

        public UseDB()
        {
            service = new Service1Client();
        }

        public string FromDate(string date)
        {
            string temp = "";
            try
            {
                char[] tempCh = new char[10];

                tempCh = date.ToCharArray();
                for (int i = 0; i < 10; i++)
                {
                    temp += tempCh[i];
                }
            }
            catch (Exception)
            {
                return date;
            }

            return temp;
            }

        public string GetPassword()
        {
            string password;
            password = service.GetData();
            return password;
        }

        public DataTable FillWorkers(Worker[] workers)
        {
            DataTable table = new DataTable();
            int cols = 13;
            for (int i = 0; i < cols; i++)
            {
                table.Columns.Add();
            }
            table.Columns[0].ColumnName = "ID";
            table.Columns[1].ColumnName = "Прізвище";
            table.Columns[2].ColumnName = "Ім'я";
            table.Columns[3].ColumnName = "Побатькові";
            table.Columns[4].ColumnName = "Місто";
            table.Columns[5].ColumnName = "Адреса";
            table.Columns[6].ColumnName = "Стать";
            table.Columns[7].ColumnName = "Сімейний стан";
            table.Columns[8].ColumnName = "Дата народження";
            table.Columns[9].ColumnName = "Бажана зарплата";
            table.Columns[10].ColumnName = "Бажана посада";
            table.Columns[11].ColumnName = "Номер картки";
            table.Columns[12].ColumnName = "Кількість дітей";

            foreach (Worker key in workers)
            {
                int i = 0;
                string[] str = new string[cols];
                str[i++] = key.Id;
                str[i++] = key.Surname;
                str[i++] = key.Name;
                str[i++] = key.SecondName;
                str[i++] = key.City;
                str[i++] = key.Address;
                str[i++] = key.Sex;
                str[i++] = key.MaritalStatus;
                str[i++] = FromDate(key.BirthDate);
                str[i++] = key.WantedSalary;
                str[i++] = key.WantedPosition;
                str[i++] = key.CardNumber;
                str[i++] = key.ChildrenCount;
                table.Rows.Add(str);

            }
            return table;
        }




        public DataTable FillEducation(Education[] educations)
        {
            DataTable table = new DataTable();
            int cols = 10;
            for (int i = 0; i < cols; i++)
            {
                table.Columns.Add();
            }

            table.Columns[0].ColumnName = "ID";
            table.Columns[1].ColumnName = "Назва";
            table.Columns[2].ColumnName = "Номер працівника";
            table.Columns[3].ColumnName = "Дата вступу";
            table.Columns[4].ColumnName = "Дата закінчення";
            table.Columns[5].ColumnName = "Чи закінчений";
            table.Columns[6].ColumnName = "Факультет";
            table.Columns[7].ColumnName = "Тип";
            table.Columns[8].ColumnName = "Акридетація";
            table.Columns[9].ColumnName = "Розташування";


            foreach (Education key in educations)
            {
                int i = 0;
                string[] str = new string[cols];
                str[i++] = key.Id;
                str[i++] = key.Name;
                str[i++] = key.WorkerId;
                str[i++] = FromDate(key.StartDate.ToString());
                str[i++] = FromDate(key.FinishDate.ToString());
                str[i++] = key.IsFinished;
                str[i++] = key.Faculty;
                str[i++] = key.Owner;
                str[i++] = key.Type;
                str[i++] = key.Location;
                table.Rows.Add(str);

            }
            return table;

        }




        public DataTable FillExperiance(Experiance[] experiances)
        {
            DataTable table = new DataTable();
            int cols = 10;
            for (int i = 0; i < cols; i++)
            {
                table.Columns.Add();
            }

            table.Columns[0].ColumnName = "ID";
            table.Columns[1].ColumnName = "Назва";
            table.Columns[2].ColumnName = "Кількість працівників";
            table.Columns[3].ColumnName = "Гендиректор";
            table.Columns[4].ColumnName = "Тип";
            table.Columns[5].ColumnName = "Номер працівника";
            table.Columns[6].ColumnName = "Посада";
            table.Columns[7].ColumnName = "Зарплата";
            table.Columns[8].ColumnName = "Дата вступу на посаду";
            table.Columns[9].ColumnName = "Дата звільнення";


            foreach (Experiance key in experiances)
            {
                string[] str = new string[cols];
                str[0] = key.Id;
                str[5] = key.Name;
                str[6] = key.Size;
                str[7] = key.Ceo;
                str[8] = key.Type;
                str[9] = key.WorkerId;
                str[1] = key.Position;
                str[2] = key.Salary;
                str[3] = FromDate(key.StartDate);
                str[4] = FromDate(key.FinishDate);
                table.Rows.Add(str);
            }
            return table;
        }








    }



}


