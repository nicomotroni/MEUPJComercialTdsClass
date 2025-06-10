using Org.BouncyCastle.Crypto.Digests;
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
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public string? CodBarras { get; set; }
        public int Quantidade { get; set; }
        public string? Descricao { get; set; }
        public double ValorUnit { get; set; }
        public Categoria? Categoria { get; set; }
        public DateTime  DataEntrada { get; set; }
        public byte[] imagem { get; set; }
        public string Localizacao { get; set; }

        public Estoque()
        {

        }
        public Estoque(int id, string nomeProduto, string codigoProduto,int quantidade)

        {

        }







        // os métodos não estão especificados na construção dele
        //precisa retirar alguns contrutores que não estão bem especificados 
        //atualizar aqui 10/06 inserir o estoque