using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaalhytteBooking
{
    public class BoerneGruppe
    {
        private int _id;
        private string _name;
        private string _aldersgruppe;
        private int _antalAfGrupper;

        #region Constructor

        public BoerneGruppe(int _id, string _name, string _aldersgruppe, int _antalAfGrupper) {
            ID = _id;
            Name = _name;
            Aldersgruppe = _aldersgruppe;
            AntalAfGrupper = _antalAfGrupper;
        }
        #endregion

        #region Properties
        public int ID { 
            get { return _id; } 
            set { _id = value; }
        }
        public string Name { 
            get { return _name;} 
            set { _name = value; }
        }
        public string Aldersgruppe { 
            get { return _aldersgruppe;}
            set { _aldersgruppe = value;}
        }
        public int AntalAfGrupper { 
            get { return _antalAfGrupper; }
            set
            {
                _antalAfGrupper = value;
            }
        }
        #endregion

        public override string ToString()
        {
            return $"ID:{ID}, Navn:{Name}, Aldersgruppe:{Aldersgruppe}, Deltagere:{AntalAfGrupper}";
        }
    }
}
