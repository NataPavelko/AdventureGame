using System;
using MySqlConnector;

namespace AdventureMan.HelpingTools
{
    public class DB_Angriff
    {
        public static string connectionString = "Server=127.0.0.1; Database = game; User = root; password=;";
        
        public static MySqlConnection connection;
        
        
        public static void Connect()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Connection success");
            }
            catch (Exception e)
            {
                Console.WriteLine("No!");
            }
        }


        public static void ReadHero(Konstraktor hero)
        {
            string query = "SELECT * FROM spieler WHERE id=" + hero + "; ";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["name"].ToString();
                string level = reader["level"].ToString();
                string health = reader["health"].ToString();
                string strength = reader["strength"].ToString();
                string attack = reader["attack"].ToString();
                
                
                command.Parameters.AddWithValue("@name", hero.Name );
                command.Parameters.AddWithValue("@level", hero.Level);
                command.Parameters.AddWithValue("@health", hero.Health);
                command.Parameters.AddWithValue("@strength", hero.Strength);
                command.Parameters.AddWithValue("@attack", hero.Attack);
                
                
                
                Console.WriteLine(($"Name: {name} "+$"Start Level: {level} " +$"Health: {health} " + $"Strength: {strength}"));
            }
            
        }
        
        public static Konstraktor HeroByID(int id)
        {
            Konstraktor hero = null;
            string query = "SELECT * FROM spieler WHERE id=" + id + "; ";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id2 = reader.GetInt32("id");
                string name = reader["name"].ToString();
                int level = reader.GetInt32("level");
                int health = reader.GetInt32("health");
                int strength = reader.GetInt32("strength");
                int attack = reader.GetInt32("attack");
                
                
                // Console.WriteLine(($"Name: {name} "+$"Start Level: {level} " +$"Health: {health} " + $"Strength: {strength}"));
                hero = new Konstraktor(id2, name, level, health, strength, attack);
            }
            
            return hero;
        }

        public static void HeroInfo(Konstraktor hero)
        {
            string query = $"";

        }

    }
}