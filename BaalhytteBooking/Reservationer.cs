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
        public Dictionary<int, Reservation> reservation { get; set; }

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
        public int Id { get { return _id; } set { _id = value; } }
        #endregion

        #region Methods

        public void RegistrerReservation(Reservation reservation)
        {
        }

        public void FjernReservation(Reservation reservation)
        {

        }

        public void PrintReservationer()
        {
            Console.WriteLine();
        }

        #endregion
    }
}

