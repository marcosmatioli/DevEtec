using Sistema_Login_desk.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Login_desk.Model
{
     // primeiro deixar a classe publica
     public class controle
    {
        public bool T; // atributo booleano para retornar 
        public String mensagem = ""; // utiliza string para trazer uma mensagem
        public bool acessar(String login, String senha)
        {
            LoginComandos loginComand = new LoginComandos(); // classe 
           T= loginComand.verificarLogin(login, senha); // metodo

            if(!loginComand.mensagem.Equals(""))
            {
                this.mensagem = loginComand.mensagem;
            }

            return T;
        }
       
    }
}
