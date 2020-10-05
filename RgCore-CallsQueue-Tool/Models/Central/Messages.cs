using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RgCore_CallsQueue_Tool.Models.Central
{
    public class Messages
    {
        [Key]
        public int MessageId { get; set; } //(int, not null)
        public int Description { get; set; } //(int, not null)
        public string InternalAddress { get; set; } //(nvarchar(max), null)
        public string ExternalAddress { get; set; } //(nvarchar(max), null)
        public string ARef { get; set; } //(char(22), null)
        public int? GtRef { get; set; } //(int, null)
        public string LoanBookId { get; set; } //(nvarchar(max), null)
        //public string LenderEndpoint { get; set; } //(nvarchar(max), null)
        public string ClientType { get; set; } //(nvarchar(max), null)
        public string ClientUserName { get; set; } //(nvarchar(max), null)
        public int MessageStatus { get; set; } //(int, not null)
        public TimeSpan StatusTime { get; set; } //(time(7), not null)
        public DateTime UtcTime { get; set; } //(datetime2(7), not null)
        public DateTime LocalDateTime { get; set; } //(datetime2(7), not null)
        public string MessageTitle { get; set; } //(nvarchar(max), null)
        public string MessageBody { get; set; } //(nvarchar(max), null)
        public string ExternalId { get; set; } //(nvarchar(max), null)
        public string CommId { get; set; } //(nvarchar(max), null)
        public int? LenderId { get; set; } //(int, null)
    }

}
