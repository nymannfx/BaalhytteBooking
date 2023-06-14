using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BaalhytteBooking
{
    public class Reservation
    {
        private int _id;
        private DateTime _tidspunkt;
        private BoerneGruppe _boernegruppe;

        public Reservation(int _id, DateTime _tidspunkt, BoerneGruppe _boernegruppe) {
            ID = _id;
            Tidspunkt = _tidspunkt;
            Boernegruppe = _boernegruppe;
        }


        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public DateTime Tidspunkt
        {
            get { return _tidspunkt; }
            set { _tidspunkt = value; }
        }

        public BoerneGruppe Boernegruppe
        {
            get { return _boernegruppe; }
            set { _boernegruppe = value; }
        }

        public override string ToString()
        {
            return $"ID: {ID}, Tidspunkt: {Tidspunkt}, Børnegruppe: {Boernegruppe}";
        }

    }
}
