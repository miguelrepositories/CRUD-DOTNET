using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;
using Npgsql;
using System;
using System.Collections.Generic;

namespace testeCliente
{
    [TestClass]
    public class UnitTest1
    {
        public void InserirDoencas()
        {
            IRepositorio rep = new RepositorioNpgsql();
            try
            {
                rep.Inserir(doenca: new Doencas(cid: "J00J99",tipo: "Doen�as do aparelho respirat�rio", nome: "Asma", sintomas: "falta de ar ou dificuldade para respirar;respira��o r�pida e curta;sensa��o de aperto no peito;chiado ou assobio agudo no peito ao respirar e tosse."));
            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(rep.Consultar(nome: "Asma"));
        }

        [TestMethod]
        public void DeletarDoencas()
        {
            RepositorioNpgsql rep = new RepositorioNpgsql();
            try
            {
                rep.Deletar(nome: "Asma");
            }
            catch (Exception ex)
            {
                
            }
            Assert.IsNull(rep.Consultar(nome: "Asma"));
        }

        public void AtualizarDoencas()
        {
            IRepositorio rep = new RepositorioNpgsql();
            try
            {
                rep.Atualizar(doenca: new Doencas(cid: "J00J99", tipo: "Doen�as do aparelho respirat�rio", nome: "Asma", sintomas: "falta de ar ou dificuldade para respirar"));
            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(rep.Consultar(cid: "J00J99"));
        }

        [TestMethod]
        public void ConsultarDoencas()
        {
            InserirDoencas();
            Doencas doenca = null;
            RepositorioNpgsql rep = new RepositorioNpgsql();
            try
            {
                doenca = rep.Consultar(nome: "Asma");
            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(doenca);
        }

        [TestMethod]

        public void ListarClientes()
        {
            List<Doencas> doenca = null;
            IRepositorio rep = new RepositorioNpgsql();
            try
            {
                doenca = rep.Listar();
            }
            catch (Exception ex)
            {
                
            }
            Assert.IsNotNull(doenca);
        }
    }
}
