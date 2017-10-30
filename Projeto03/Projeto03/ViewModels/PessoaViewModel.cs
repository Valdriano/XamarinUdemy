using Projeto03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.ViewModels
{
    public class PessoaViewModel
    {
        public List<Pessoa> listPessoas { get; set; }
        public PessoaViewModel()
        {
            listPessoas = new List<Pessoa>();

            listPessoas.AddRange(
                new Pessoa[]
                {
                    new Pessoa{Nome = "Valdriano", Email="valdriano.oliveira@gmail.com", Cargo = "Desenvolvedor"},
                    new Pessoa{Nome = "Iracema", Email="iracema.soares@gmail.com", Cargo = "Pedagoga"},
                    new Pessoa{Nome = "Samuel", Email="samuel.oliveira@gmail.com", Cargo = "Estudante"},
                    new Pessoa{Nome = "Jessica", Email="jessica.silva@gmail.com", Cargo = "Aux. Administrativa"},
                    new Pessoa{Nome = "Lucas", Email="lucas.carvalho@gmail.com", Cargo = "Estagiario"},
                    new Pessoa{Nome = "Rita", Email="rita.costa@gmail.com", Cargo = "Estudante"}
                }
                );
        }
    }
}
