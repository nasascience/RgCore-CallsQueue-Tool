using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using RgCore_CallsQueue_Tool.Models.Central;
using System.Linq.Expressions;
namespace RgCore_CallsQueue_Tool.Services.Contexts
{
    public class CentralCommsContext: DbContext
    {
        public CentralCommsContext() : base("name=Central_Comms") { }
        public DbSet<Attachments> Attachments { get; set; }
        public DbSet<Messages> Messages { get; set; }

       //public static List<Messages> GetAll()
       //{
       //    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Central_Comms"].ConnectionString))
       //    {
       //         //context.Set<Messages>().
       //    }
       //}
    }
}
