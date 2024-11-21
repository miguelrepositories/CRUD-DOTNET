using System;

namespace Modelos
{
    public class Doencas
    {
        private int id;
        private string cid;
        private string tipo;
        private string nome;
        private string sintomas;

        public Doencas() { }

        public Doencas(string cid, string tipo, string nome, string sintomas)
        {
            Cid = cid;
            Tipo = tipo;
            Nome = nome;
            Sintomas = sintomas;
        }

        public Doencas(int id, string cid, string tipo, string nome, string sintomas) : this(cid, tipo, nome, sintomas)
        {
            Id = id;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Cid
        {
            get
            {
                return cid;
            }
            set
            {
                cid = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Sintomas
        {
            get
            {
                return sintomas;
            }
            set
            {
                sintomas = value;
            }
        }
    }
}
