using CommentPage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;


namespace CommentPage.Models

{
    public class minitwitterDataModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Command { get; set; }



        public DateTime Time = DateTime.Now;
        //public DateTime Time { get; set; }


    }
}
