using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo03_heranca
{

    //simbolo de herança : que sao dois pontos
    class pessoa_fisica : pessoa
    {
        private string rg;
        public void setRg(string rg)
        {
            this.rg = rg;
        }

        public string getRg()
        {
            return this.rg;
        }
    }
}
