using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conflow
{
    class ComandosSQL
    {


        // Retorna a data e hora atual no formato do SQL
        public String current_timestamp
        {
            get
            {
                return String.Format("{0}-{1}-{2} {3}:{4}:{5}", DateTime.Now.Year.ToString(), ConverterDataHora(DateTime.Now.Month.ToString()), ConverterDataHora(DateTime.Now.Day.ToString()), ConverterDataHora(DateTime.Now.Hour.ToString()), ConverterDataHora(DateTime.Now.Minute.ToString()), ConverterDataHora(DateTime.Now.Second.ToString()));
            }
        }

        // Faz com que valores menores que 10 retornem com um zero antes. Ex: 07, 08, 09, 10.
        // Como em datas (03/05/2000)
        private String ConverterDataHora(String valor)
        {
            if (Convert.ToInt32(valor) < 10)
            {
                return "0" + valor;
            }
            return valor;
        }
    }
}
