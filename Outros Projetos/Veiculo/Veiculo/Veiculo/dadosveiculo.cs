using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    class dadosveiculo
    {   //esse aqui é um negocio que precisa fazer para identificar quem é quem,
        //para trabalhar melhor com os dados depois
        private string modelo;
        private string fabricante;
        private int ano;
        private string estado;
        private string cidade;
        private string placa;
        private string foto;
        //
        public string Modelo
        {
            get{
                return modelo;
            }
            set{
                modelo=value;
            }
        }
        public string Fabricante
        {
            get
            {
                return fabricante;
            }
            set
            {
                fabricante = value;
            }
        }
        public int Ano
        {
            get
            {
                return ano;
            }
            set
            {
                ano = value;
            }
        }
        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }
        public string Cidade
        {
            get
            {
                return cidade;
            }
            set
            {
                cidade = value;
            }
        }
            public string Placa
        {
            get
            {
                return placa;
            }
            set
            {
                placa = value;
            }
        }
            public string Foto
        {
            get
            {
                return foto;
            }
            set
            {
                foto = value;
            }
        }
    }
    }

