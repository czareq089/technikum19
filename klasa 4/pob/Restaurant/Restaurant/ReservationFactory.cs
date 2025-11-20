using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public static class ReservationFactory
    {
        public static Reservation Create(int type)
        {
            Logger logger = Logger.GetInstance();
            switch (type) {
                case 1:
                    logger.Log("Dodano nową rezerwację stolika.");
                    return new TableReservation();              
                case 2:
                    logger.Log("Dodano nową rezerwację sali.");
                    return new WholeReservation();
                default:
                    throw new ArgumentException("Nieznany typ rezerwacji.");
                }
        }       
    }
}
