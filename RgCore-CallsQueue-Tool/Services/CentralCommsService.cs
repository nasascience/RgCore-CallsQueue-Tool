using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RgCore_CallsQueue_Tool.Models.Central;
using RgCore_CallsQueue_Tool.Services.Contexts;

namespace RgCore_CallsQueue_Tool.Services
{
    public class CentralCommsService
    {
        private CentralCommsContext rgCommContext = new CentralCommsContext();

        public async Task<List<Messages>> GetCallQueues()
        {
            var d = DateTime.UtcNow.Date;
            var formattedDate = d.Year + "-" + d.Month + "-" + d.Day; //'2020-07-06'

            var result = new List<Messages>();
            string CriteriaQuery = @"
                SELECT * FROM [dbo].[Messages]
  where messagestatus=23 and utctime > '"+formattedDate+"'";
            result = rgCommContext.Messages.SqlQuery(CriteriaQuery).ToList();
            return result;
        }





    }
}
