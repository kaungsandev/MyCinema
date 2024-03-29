﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCinema
{
    class Movie
    {
        readonly MySqlConnection connection;

        public Movie()
        {
            string entry = "Data Source=127.0.0.1;" + "Initial Catalog=cinema_ticket_system;" + "User id=root;" + "Password='';";
            connection = new MySqlConnection(entry);
        }
        public void Insert(string name, string category, string theater, string start, string end)
        {
            try
            {

                string insert = "INSERT INTO movie(movie_name,movie_genre,theater_name,startdate,enddate) VALUES('" + name + "','" + category + "','" + theater + "','"+start+"','"+end+"')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insert, connection);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);  
            }
        }
        public string[] Show()
        {
            string[] name = new string[3];
            int i = 0;
            try
            {

                string query = "SELECT movie_name FROM movie ORDER BY movie_id DESC LIMIT 3";
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    name[i] = reader["movie_name"].ToString();
                    i++;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return name;
        }

    }
}
