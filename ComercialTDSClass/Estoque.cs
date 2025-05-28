using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ComercialTDSClass
{
    public class Estoque
    {
        public int id { get; set; }
        public string? CodBarras { get; set; }
        public string? Descricao { get; set; }
        public double ValorUnit { get; set; }
        public Categoria? Categoria { get; set;}
        public DateTime DataCard { get; set; }
        public byte[] imagem { get; set;}
        public string? Nome { get; set;}
        public Estoque() 
        {
            Categoria = new();
            public Estoque()
        {
            Categoria = new();
        }
        public Estoque(int id, string? codBarras, string? descricao, double valorUnit, string? unidadeVenda, Categoria? categoria, double estoqueMinimo, double classeDesconto, byte[] imagem, DateTime dataCad, bool descontinuado)
        {
            Id = id;
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
            Descontinuado = descontinuado;
        }
        // os métodos não estão especificados na construção dele
        //precisa retirar alguns contrutores que não estão bem especificados 