using System;
using System.Collections.Generic;
using System.Text;

namespace LIBRERIACLASES
{
    public class Pack
    {
        public CAT10 traficoMLAT;
        public CAT10 traficoSMR;

        public Pack(CAT10 traficoMLAT, CAT10 traficoSMR)
        {
            this.traficoMLAT = traficoMLAT;
            this.traficoSMR = traficoSMR;
        }

    }
}
