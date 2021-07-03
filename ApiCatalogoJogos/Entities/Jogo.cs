using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Entities
{
    public class Jogo
    {
        public Jogo(Guid guid, string v1, string v2, double v3)
        {
            Guid = guid;
            V1 = v1;
            V2 = v2;
            V3 = v3;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }
        public double Preco { get; set; }
        public Guid Guid { get; }
        public string V1 { get; }
        public string V2 { get; }
        public double V3 { get; }
    }
}
