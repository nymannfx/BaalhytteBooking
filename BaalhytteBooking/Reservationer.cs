using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaalhytteBooking
{
    public class Reservationer
    {
        public Dictionary<int, Reservation> reservation;

        #region Instance Fields
        private int _id;
        #endregion

        #region Constructor
        public Reservationer()
        {
            reservation = new Dictionary<int, Reservation>();
        }
        #endregion

        #region Properties
        public Dictionary<int, Reservation> Reservations
        {
            get { return reservation; }
        }
        public int Id { get { return _id; } set { _id = value; } }
        #endregion

        #region Methods

        public void RegistrerReservation(Reservation reservation)
        {
            Reservations.Add(reservation.ID, reservation);
        }

        public void FjernReservation(Reservation reservation)
        {
            Reservations.Remove(reservation.ID);
        }

        public void PrintReservationer()
        {
            foreach(var r in Reservations)
                Console.WriteLine(r);
        }

        #endregion
    }
}

