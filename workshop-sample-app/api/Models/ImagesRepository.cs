using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace api.Models
{
    public class ImagesRepository {
      private string connectionString;

      public ImagesRepository(){
        //var secretPath = @"c:\ProgramData\Docker\secrets\sa_password";
        //var pwd = File.ReadAllText(secretPath);
        var pwd = Environment.GetEnvironmentVariable("SA_PASSWORD");
        Console.WriteLine("The sa password is: {0}", pwd);
        connectionString = string.Format("Server=db;Database=ddev;User Id=sa;Password={0};", pwd);
      }

      public IDbConnection Connection
      {
          get  {
              return new SqlConnection(connectionString);
          }
      }

      public int Count{
        get{
          using(var dbConnection = Connection)
          {
            return dbConnection.ExecuteScalar<int>("SELECT COUNT(*) FROM Images");
          }
        }
      }

      public IEnumerable<Image> List(){
        using (IDbConnection dbConnection = Connection)
        {
            dbConnection.Open();
            return dbConnection.Query<Image>("SELECT * FROM Images");
        }
      }

      public Image GetById(int id){
        using (IDbConnection dbConnection = Connection)
        {
            string sQuery = "SELECT * FROM Images WHERE Id = @Id";
            dbConnection.Open();
            return dbConnection.Query<Image>(sQuery, new { Id = id }).FirstOrDefault();
        }
      }
    }
}
