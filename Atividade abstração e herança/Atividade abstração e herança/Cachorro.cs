using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_abstração_e_herança
{
    internal class Cachorro : Animal
    {
           
        private string raca;

        public string Raca
        {
            get
            {
                return this.raca;
            }
            set
            {
                this.raca = value;
            }
        }

    }
}

