using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuPrimeiroApp.VO;
using MySql.Data.MySqlClient;
namespace MeuPrimeiroApp.DAO
{
    public class PessoaFisicaDAO: baseDAO
    {
        public static List<Fisica> listaPessoaFisica;
        public Fisica pessoa { get; set; }
        public PessoaFisicaDAO()
        {
            if (listaPessoaFisica == null)
            {
                listaPessoaFisica = new List<Fisica>();
            }
        }
        public void create()
        {
            this.sql = "insert into cadastro(cod,nome,endereco,cpf) values (@cod,@nome,@endereco,@cpf)";
            cmd.CommandText = this.sql;
            this.parametros.Add(new MySqlParameter("@cod", pessoa.codigo));
            this.parametros.Add(new MySqlParameter("@nome", pessoa.nome));
            this.parametros.Add(new MySqlParameter("@endereco", pessoa.endereco));
            this.parametros.Add(new MySqlParameter("@cpf", pessoa.cpf));
            execute();
        }
        public void update()
        {

        }
        public void delete()
        {

        }
        public List<Fisica> list()
        {
            return listaPessoaFisica;
        }
    }
}
