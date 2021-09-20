using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class Function
    {

        public static SqlConnection Connection { get; } = new SqlConnection("Data Source=BUE205D16;Initial Catalog=BDTurmaManha;Persist Security Info=True;User ID=guest01;Password=@Senac2021");

        public static void Executa(string comm) // ele vai receber diretamente o "comando" como select, inset entre outros
        {
            SqlCommand comando = new SqlCommand(comm, Connection);
            Connection.Open();
            comando.ExecuteNonQuery();
            Connection.Close();

        }
        public static List<string> GenericUnitSelect(string element, string table)
        {

            List<string> returnElements = new List<string>();

            string select = $"SELECT {element} from dbo.{table}";
            SqlCommand comand = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = comand.ExecuteReader();
            while (dr.Read())
            {
                returnElements.Add((string)dr[0].ToString());
            }
            dr.Close();
            Function.Connection.Close();

            return returnElements;


        }

        public static List<string> GenericUnitSelect(string element, string table, string where)
        {

            List<string> returnElements = new List<string>();

            string select = $"SELECT {element} from dbo.{table} WHERE {where}";
            SqlCommand comand = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = comand.ExecuteReader();
            while (dr.Read())
            {
                returnElements.Add((string)dr[0].ToString());
            }
            dr.Close();
            Function.Connection.Close();

            return returnElements;

           
        }


        public static void GenericExecute(string command)
        {
            SqlCommand com = new SqlCommand(command, Connection);
            Connection.Open();
            com.ExecuteNonQuery();
            Connection.Close();

        }

    }
}
