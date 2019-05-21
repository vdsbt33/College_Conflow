using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conflow.Models.Proprietario
{
    public class Proprietario
    {
        public Int32 COD_PROPRIETARIO
        {
            get;
            set;
        }

        public String NOME_PROPRIETARIO
        {
            get;
            set;
        }

        public String RG_PROPRIETARIO
        {
            get;
            set;
        }

        public String CPFCNPJ_PROPRIETARIO
        {
            get;
            set;
        }

        public String SEXO_PROPRIETARIO
        {
            get;
            set;
        }

        public String DAT_NASCIMENTO_PROPRIETARIO
        {
            get;
            set;
        }

        public String END_UF_PROPRIETARIO
        {
            get;
            set;
        }

        public String END_CIDADE_PROPRIETARIO
        {
            get;
            set;
        }

        public String END_BAIRRO_PROPRIETARIO
        {
            get;
            set;
        }

        public String END_RUA_PROPRIETARIO
        {
            get;
            set;
        }

        public String END_NUM_PROPRIETARIO
        {
            get;
            set;
        }

        public String ID_CONDOMINIO
        {
            get;
            set;
        }

        public String ID_BLOCO
        {
            get;
            set;
        }

        public String ID_PREDIO
        {
            get;
            set;
        }

        public Int32 NUM_APARTAMENTO_PROPRIETARIO
        {
            get;
            set;
        }

        public Proprietario()
        {

        }

        public Proprietario(Int32 COD_PROPRIETARIO, String NOME_PROPRIETARIO, String RG_PROPRIETARIO, String CPFCNPJ_PROPRIETARIO, String SEXO_PROPRIETARIO, String DAT_NASCIMENTO_PROPRIETARIO, String END_UF_PROPRIETARIO, String END_CIDADE_PROPRIETARIO, String END_BAIRRO_PROPRIETARIO, String END_RUA_PROPRIETARIO, String END_NUM_PROPRIETARIO, String ID_CONDOMINIO, String ID_BLOCO, String ID_PREDIO, Int32 NUM_APARTAMENTO_PROPRIETARIO)
        {
            this.COD_PROPRIETARIO = COD_PROPRIETARIO;
            this.NOME_PROPRIETARIO = NOME_PROPRIETARIO;
            this.RG_PROPRIETARIO = RG_PROPRIETARIO;
            this.CPFCNPJ_PROPRIETARIO = CPFCNPJ_PROPRIETARIO;
            this.SEXO_PROPRIETARIO = SEXO_PROPRIETARIO;
            this.DAT_NASCIMENTO_PROPRIETARIO = DAT_NASCIMENTO_PROPRIETARIO;
            this.END_UF_PROPRIETARIO = END_UF_PROPRIETARIO;
            this.END_CIDADE_PROPRIETARIO = END_CIDADE_PROPRIETARIO;
            this.END_BAIRRO_PROPRIETARIO = END_BAIRRO_PROPRIETARIO;
            this.END_RUA_PROPRIETARIO = END_RUA_PROPRIETARIO;
            this.END_NUM_PROPRIETARIO = END_NUM_PROPRIETARIO;
            this.ID_CONDOMINIO = ID_CONDOMINIO;
            this.ID_BLOCO = ID_BLOCO;
            this.ID_PREDIO = ID_PREDIO;
            this.NUM_APARTAMENTO_PROPRIETARIO = NUM_APARTAMENTO_PROPRIETARIO;

        }
        
    }
}
