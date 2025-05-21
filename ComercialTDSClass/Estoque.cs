using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class Estoque
    {
        public int id { get; set; }
        public string? CodBarras { get; set; }
        public string? Descricao { get; set; }
        public double ValorUnit { get; set; }
        public Categoria? Categoria { get; set; }
        public DateTime DataCard { get; set; }
        public byte[] imagem { get; set; }
        public string? Nome { get; set; }
        public Estoque()
        {
            Categoria = new();
        }

    }
}
/*quando for inserir uma imagem no C#
o símbolo "[]" não quer dizer que contém uma imagem ali, 
mas que esta sendo convertido em bytes uma 
matriz de bytes que indica que pode ser inserido imagem 
para o c# consiga interpretar/rodar aquele dado*/
 public Estoque(int id, string? codBarras, string? descricao, double valorunit, Categoria? categoria, DateTime datacard, byte[] imagem, string nome)
{

}
