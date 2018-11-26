using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMonsterClasses
{
    public class SeaMonster
    {
        #region FIELDS

        private string _name;
        private double _weight;
        private bool _canUseFreshwater;

        #endregion

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public bool CanUseFreshwater
        {
            get { return _canUseFreshwater; }
            set { _canUseFreshwater = value; }
        }

        public SeaMonster()
        {

        }

        public SeaMonster(string name)
        {
            _name = name;
        }
    }
}
