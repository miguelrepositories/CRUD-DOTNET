using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepositorio
    {
        void Inserir(Doencas doenca);
        void Deletar(string cid);
        void Atualizar(Doencas doenca);

        Doencas Consultar(string cid);
        public List<Doencas> Listar();
    }
}
