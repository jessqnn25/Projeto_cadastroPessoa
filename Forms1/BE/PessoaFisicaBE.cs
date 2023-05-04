using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuPrimeiroApp.VO;
using MeuPrimeiroApp.DAO;
namespace MeuPrimeiroApp.BE {   
    public class PessoaFisicaBE
    {
        public Fisica pessoa { get; set; }
        private PessoaFisicaDAO dao { get; set; }
        public PessoaFisicaBE()
        {
            dao = new PessoaFisicaDAO();
        }

        public void create()
        {
            dao.pessoa = pessoa;
            dao.create();
        }
        public void update()
        {

        }
        public void delete()
        {

        }
        public List<Fisica> list()
        {
            return dao.list(); ;
        }

    }
}
