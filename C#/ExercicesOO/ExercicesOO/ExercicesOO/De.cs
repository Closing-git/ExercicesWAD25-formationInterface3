using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    public static class De
    {
        private static uint _valeurMin = 1;
        private static uint _valeurMax = 6;
        private static Random rng = new Random();

        public static uint ValeurMin
        {
            get { return _valeurMin; }
            set
            {
                if (_valeurMin > 0)
                {
                    _valeurMin = value;

                    if (_valeurMin >= _valeurMax)
                    {
                        _valeurMax = (_valeurMin + 1);
                    }

                }
            }
        }

        public static uint ValeurMax
        {
            get { return _valeurMax; }
            set
            {
                if (_valeurMax > 1)
                {
                    _valeurMax = value;

                    if (_valeurMax <= _valeurMin)
                    {
                        _valeurMin = (_valeurMax - 1);
                    }
                }
            }
        }




        public static uint[] Lancer(uint nbDes)
        {
            uint[] result = new uint[nbDes];

            for (int i = 0; i < nbDes; i++)
            {
                result[i] = (uint)rng.Next((int)ValeurMin, (int)ValeurMax + 1);

            }

            return result;
        }

    }
}
