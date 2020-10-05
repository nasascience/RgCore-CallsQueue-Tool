using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RgCore_CallsQueue_Tool.Models.Central
{
    public class Attachments
    {
        [Key]
        public int AttachmentId { get; set; } //(int, not null)
        public int MessageId { get; set; } //(int, not null)
        public string AttachmentType { get; set; } //(nvarchar(max), null)
        public string Title { get; set; } //(nvarchar(max), null)
        public string Location { get; set; } //(nvarchar(max), null)
        public virtual Messages Message { get; set; }
    }

}
