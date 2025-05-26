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