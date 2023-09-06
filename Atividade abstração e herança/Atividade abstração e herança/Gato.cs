using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_abstração_e_herança
{
    internal class Gato:Animal
    {
        private string CorPelo;

        public string corpelo
        {
            get
            {
                return this.CorPelo;
            }
            set
            {
                this.CorPelo = value;
            }
        }
    }
}
