using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UnderstandCShap.configuration;
using UnderstandCShap.entities;

namespace UnderstandCShap.services
{
    internal class GadgetService
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader dataReader;
        private ConnectMySQL connectMySQL;
        private readonly string[] SQL_COMMAND =
        {
            "select * from gadget",
            "select * from gadget where gid = @gid", // @i will pass it later
            "insert into gadget values (@gid,@model,@brand,@price,@amount)",
            "update gadget set model = @model , brand = @brand , price = @price, amount = @amount where gid = @gid",
            "delete from gadget where gid = @gid",
        };
        public GadgetService()
        {
            connectMySQL = new ConnectMySQL();
            connection = connectMySQL.MySqlConnection;
            command = new MySqlCommand();
        }

        public List<Gadget> getAllGadgets()
        {
            List<Gadget> gadgets = new List<Gadget>();
            // connect mysql
            connection.Open();
            // set up command for query
            command.Connection = connection;
            command.CommandText = SQL_COMMAND[0];
            // ExecuteReader() Used to execute a command that will return 0 or more 
            dataReader = command.ExecuteReader();
            // Read the data and store them in the list
            while (dataReader.Read())
            {
                Gadget gadget = new Gadget(
                    (string) dataReader["gid"],
                    (string) dataReader["model"],
                    (string) dataReader["brand"],
                    (float) Convert.ToDouble(dataReader["price"]),
                   (int) Convert.ToInt64(dataReader["amount"])
                );
                gadgets.Add(gadget);
            }
            // always close
            dataReader.Close();
            connection.Close();
            return gadgets;
        }

        public Gadget getGadgetById(string gid)
        {
            Gadget? gadget = null;
            // connect mysql
            connection.Open();
            // set up command for query
            command.Connection = connection;
            command.CommandText = SQL_COMMAND[1];
            // way to pass value as params
            command.Parameters.AddWithValue("@gid", gid);
            // ExecuteReader() Used to execute a command that will return 0 or more 
            dataReader = command.ExecuteReader();
            // Read the data and store them in the list
            while (dataReader.Read())
            {
                gadget = new Gadget(
                    (string)dataReader["gid"],
                    (string)dataReader["model"],
                    (string)dataReader["brand"],
                    (float)Convert.ToDouble(dataReader["price"]),
                    (int)Convert.ToInt64(dataReader["amount"])
                );
            }
            // always close
            dataReader.Close();
            connection.Close();
            return gadget;
        }

        public Boolean saveGadget(Gadget gadget)
        {
            // connect mysql
            connection.Open();
            // set up command for query
            command.Connection = connection;
            command.CommandText = SQL_COMMAND[2];
            command.Parameters.AddWithValue("@gid", gadget.Gid);
            command.Parameters.AddWithValue("@model", gadget.Model);
            command.Parameters.AddWithValue("@brand", gadget.Brand);
            command.Parameters.AddWithValue("@price", gadget.Price);
            command.Parameters.AddWithValue("@amount", gadget.Amount);
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result == 0)
            {
                return false;
            }
            return true;
        }

        public Boolean editGadget(Gadget gadget,string gid)
        {
            // connect mysql
            connection.Open();
            // set up command for query
            command.Connection = connection;
            command.CommandText = SQL_COMMAND[3];
            command.Parameters.AddWithValue("@model", gadget.Model);
            command.Parameters.AddWithValue("@brand", gadget.Brand);
            command.Parameters.AddWithValue("@price", gadget.Price);
            command.Parameters.AddWithValue("@amount", gadget.Amount);
            command.Parameters.AddWithValue("@gid", gid);
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result == 0)
            {
                return false;
            }
            return true;
        }

        public Boolean removeGadgetById(string gid)
        {
            // connect mysql
            connection.Open();
            // set up command for query
            command.Connection = connection;
            command.CommandText = SQL_COMMAND[4];
            command.Parameters.AddWithValue("@gid", gid);
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result == 0)
            {
                return false;
            }
            return true;
        }
    }
}
