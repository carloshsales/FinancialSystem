using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Base : Notification
    {
        [Display( Name = "ID" )]
        public int ID { get; set; }
        [Display( Name = "Name" )]
        public string Name { get; set; }
    }
}
