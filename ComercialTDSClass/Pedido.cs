using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class Pedido
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime? Data { get; set; }
        public string? Status { get; set; }
        public double Desconto { get; set; }
        public List<ItemPedido> Items { get; set; }

        public Pedido() { }

        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }
        public Pedido(Usuario usuario, Cliente cliente)
        {
            Usuario = usuario;
            Cliente = cliente;
        }
        public Pedido(int id, string status, double desconto)
        {
            Id = id;
            Status = status;
            Desconto = desconto;
        }

        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime? data, string? status, double desconto, List<ItemPedido> items)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
            Items = items;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = "sp_pedido_insert";
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return true;
        }
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = "sp_pedido_update";
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            cmd.Parameters.AddWithValue("pscliente_id", Cliente.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            bool atualizado = cmd.ExecuteNonQuery() > 0 ? true : false;
            cmd.Connection.Close();
            return atualizado;
        }

        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select *from pedido where id= {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Pedido pedido = new();
                var cmd = Banco.Abrir();
                cmd.CommandText = $"select * from pedido where id = {id}";
                while (dr.Read())
                {
                    pedido = new(new()
                    {
                        dr.GetInt32(0),
                        Usuario.ObterPorIdPorId(dr.GetInt32(1)),
                        Cliente.ObterPorId(dr.GetInt32(2)),
                        dr.GetDateTime(3),
                        dr.GetString(4),
                        dr.GetDouble(5),
                        ItemPedido.ObterListaPorPedidoId(dr.GetInt32(0))
                    );
                }
            }
            dr.Close();
            cmd.Connection.Close();
            return pedido;

        }

        public static List<Pedido> ObterLista()
        {
            List<Pedido> pedidos = new();
            return pedidos;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select *from pedido where id= {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Pedido pedido = new();
                var cmd = Banco.Abrir();
                cmd.CommandText = $"select * from pedido where id = {id}";
                while (dr.Read())
                {
                    pedido = new(new()
                    {
                        dr.GetInt32(0),
                        Usuario.ObterPorIdPorId(dr.GetInt32(1)),
                        Cliente.ObterPorId(dr.GetInt32(2)),
                        dr.GetDateTime(3),
                        dr.GetString(4),
                        dr.GetDouble(5),
                        ItemPedido.ObterListaPorPedidoId(dr.GetInt32(0))
                    );
                }
            }
            dr.Close();
            cmd.Connection.Close();
            return pedido;
           
                    );
        }
            }

    }
//precisa corrigir o de pedido também pois esta com muitos erros nesse 