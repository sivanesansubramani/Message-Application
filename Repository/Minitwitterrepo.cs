using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using CommentPage.Models;

namespace CommentPage.Repository
{
    public class minitwitterRepository
    {
        public readonly string connectionString;


        public minitwitterRepository()
        {

            connectionString = @"Data Source = DESKTOP-Q3JLMJE\SQLEXPRESS; Initial Catalog = MiniTwitter; Integrated Security = True";
        }

        public void Insertcommand(minitwitterDataModel data)
        {
            try
            {

                SqlConnection connectionObject = new SqlConnection(connectionString);

                connectionObject.Open();
                connectionObject.Execute($"exec Insertminitwitter '{data.Name}', '{data.Command}','{data.Time.ToString("MM-dd-yyyy HH:mm:ss")}' ");


                connectionObject.Close();

            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<minitwitterDataModel> Selectcommand()

        {
            try
            {
                List<minitwitterDataModel> Listofcommands = new List<minitwitterDataModel>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                Listofcommands = connection.Query<minitwitterDataModel>("exec Selectcommand", connectionString).ToList();
                connection.Close();

                

                return Listofcommands;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }

}

