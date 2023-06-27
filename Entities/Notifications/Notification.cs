using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notifications
{
    public class Notification
    {
        public Notification ()
        {
            Notifications = new List<Notification>();
        }

        [NotMapped]
        public string PropertieName { get; set; }

        [NotMapped]
        public string Message { get; set; }

        [NotMapped]
        public List<Notification> Notifications;


        public bool ValidateStringProperty ( string value, string propertyName )
        {
            if (string.IsNullOrWhiteSpace( value ) || string.IsNullOrWhiteSpace( propertyName ))
            {
                Notifications.Add( new Notification
                {
                    Message = "Campo Obrigatório",
                    PropertieName = propertyName
                } );
                return false;
            }
            return true;
        }

        public bool ValidateIntegerProperty ( int value, string propertyName )
        {
            if (value < 1 || string.IsNullOrWhiteSpace( propertyName ))
            {

                Notifications.Add( new Notification
                {
                    Message = "Campo Obrigatório",
                    PropertieName = propertyName
                } );

                return false;
            }
            return true;
        }
    }
}
