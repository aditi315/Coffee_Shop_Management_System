using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace COFFEE_SHOP_MANAGEMENT_SYSTEM.Models
{
    public class Users
    {
        SqlConnection conn;
        public Users()
        {
            conn = new SqlConnection("Server=desktop-du2rp3h\\sqlexpress;Database=Coffee;Integrated Security=True");

        }
        public void AddUser(User user)
        {
           
            conn.Open();
            string query = "INSERT INTO Users (Id,Name,Username,Password,UserType) VALUES('" + user.Id + "','" + user.Name + "','" + user.Username + "','" + user.Password + "','" + user.UserType + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();


        }
        
        public User AuthenticateUser(string username, string password)
        {
              conn.Open();
              User u = null;
              string query = "SELECT * FROM Users WHERE Username='" + username + "' and Password='" + password +"'";
              SqlCommand cmd = new SqlCommand(query, conn);
              SqlDataReader reader = cmd.ExecuteReader();
              while (reader.Read())
              {
                  u = new User();
                  u.Name = reader.GetString(reader.GetOrdinal("Name"));
                  u.Username = reader.GetString(reader.GetOrdinal("Username"));
                  u.Password = reader.GetString(reader.GetOrdinal("Password"));
                  u.Id = reader.GetString(reader.GetOrdinal("Id"));
                  u.UserType = reader.GetString(reader.GetOrdinal("UserType"));
              }
              conn.Close(); 
              return u;

        }
        public void DeleteUser(User u)
        {
            //delete user from database

        }
        public void UpdateUser(User u)
        {
            conn.Open();
            string query = "UPDATE Users SET Username='" + u.Username + "', Password='" + u.Password + "' WHERE Id='" + u.Id + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int rslt = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public User GetUser(string username)
        {
            User user = null;
            conn.Open();
            string query = "SELECT * FROM Users WHERE Username='" + username + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user = new User();
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Id = reader.GetString(reader.GetOrdinal("Id"));
            }
            conn.Close();
            return user;
        }
        public ArrayList GetAllUsers()
        {
            ArrayList users = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Users";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User temp = new User();
                temp.Name = reader.GetString(reader.GetOrdinal("Name"));
                temp.Username = reader.GetString(reader.GetOrdinal("Username"));
                temp.Id = reader.GetString(reader.GetOrdinal("Id"));
                users.Add(temp);
            }
            conn.Close();
            return users;
        }

        public ArrayList GetAllCustomer()
        {
            ArrayList users = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Users where usertype=2;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User temp = new User();
                temp.Name = reader.GetString(reader.GetOrdinal("Name"));
                temp.Username = reader.GetString(reader.GetOrdinal("Username"));
                temp.Id = reader.GetString(reader.GetOrdinal("Id"));
                users.Add(temp);
            }
            conn.Close();
            return users;
        }
        public ArrayList GetAllEmployee()
        {
            ArrayList users = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Users where usertype=3;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User temp = new User();
                temp.Name = reader.GetString(reader.GetOrdinal("Name"));
                //temp.Username = reader.GetString(reader.GetOrdinal("Username"));
                temp.Id = reader.GetString(reader.GetOrdinal("Id"));
                users.Add(temp);
            }
            conn.Close();
            return users;
        }



    }
}

