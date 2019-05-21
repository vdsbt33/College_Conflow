using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conflow.Models.Morador
{
    public class Morador
    {
        public Int32 COD_MORADOR
        {
            get;
            set;
        }

        public String NOME_MORADOR
        {
            get;
            set;
        }

        public String DAT_NASCIMENTO_MORADOR
        {
            get;
            set;
        }

        public String SEXO_MORADOR
        {
            get;
            set;
        }

        public Int32 COD_APARTAMENTO_MORADOR
        {
            get;
            set;
        }

        public Int32 NUM_APARTAMENTO_MORADOR
        {
            get;
            set;
        }

        public Int32 COD_PREDIO_MORADOR
        {
            get;
            set;
        }

        public String ID_PREDIO_MORADOR
        {
            get;
            set;
        }

        public String ID_BLOCO_MORADOR
        {
            get;
            set;
        }

        public String ID_CONDOMINIO_MORADOR
        {
            get;
            set;
        }

        public Morador()
        {

        }

        public Morador(Int32 COD_MORADOR, String NOME_MORADOR, String DAT_NASCIMENTO_MORADOR, String SEXO_MORADOR, Int32 COD_APARTAMENTO_MORADOR, Int32 NUM_APARTAMENTO_MORADOR, Int32 COD_PREDIO_MORADOR, String ID_PREDIO_MORADOR, String ID_BLOCO_MORADOR, String ID_CONDOMINIO_MORADOR)
        {
            this.COD_MORADOR = COD_MORADOR;
            this.NOME_MORADOR = NOME_MORADOR;
            this.DAT_NASCIMENTO_MORADOR = DAT_NASCIMENTO_MORADOR;
            this.SEXO_MORADOR = SEXO_MORADOR;
            this.COD_APARTAMENTO_MORADOR = COD_APARTAMENTO_MORADOR;
            this.NUM_APARTAMENTO_MORADOR = NUM_APARTAMENTO_MORADOR;
            this.COD_PREDIO_MORADOR = COD_PREDIO_MORADOR;
            this.ID_PREDIO_MORADOR = ID_PREDIO_MORADOR;
            this.ID_BLOCO_MORADOR = ID_BLOCO_MORADOR;
            this.ID_CONDOMINIO_MORADOR = ID_CONDOMINIO_MORADOR;
        }
    }
}
