using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUrbanPark.Model
{
    public class Vaga
    {
        private int id;
        private int numero_vaga;
        private TipoVaga tipoVaga;
        private TipoStatus status;

        public Vaga(int numero_vaga, TipoVaga tipoVaga, TipoStatus status)
        {
           
            this.numero_vaga = numero_vaga;
            this.tipoVaga = tipoVaga;
            this.status = status;
        }

        public Vaga(int id, int numero_vaga, TipoVaga tipoVaga, TipoStatus status)
        {
            this.id = id;
            this.numero_vaga = numero_vaga;
            this.tipoVaga = tipoVaga;
            this.status = status;
        }

        public int Id { get => id; set => id = value; }
        public int Numero_vaga { get => numero_vaga; set => numero_vaga = value; }
        public TipoVaga TipoVaga { get => tipoVaga; set => tipoVaga = value; }
        public TipoStatus Status { get => status; set => status = value; }
    }
}
