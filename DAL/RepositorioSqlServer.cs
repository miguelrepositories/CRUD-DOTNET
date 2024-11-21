using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class RepositorioSqlServer : IRepositorio
    {
        public List<Doencas> Listar()
        {
            throw new NotImplementedException();
        }

        Doencas IRepositorio.Consultar(string cid)
        {
            throw new NotImplementedException();
        }

        void IRepositorio.Deletar(string cid)
        {
            throw new NotImplementedException();
        }

        void IRepositorio.Inserir(Doencas doenca)
        {
            throw new NotImplementedException();
        }

        void IRepositorio.Atualizar(Doencas doenca)
        {
            throw new NotImplementedException();
        }
    }
}
