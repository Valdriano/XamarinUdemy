using Projeto03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.ViewModels
{
    public class PessoaDetailViewModel
    {
        public Pessoa Pessoa { get; set; }

        public PessoaDetailViewModel( Pessoa Pessoa )
        {
            this.Pessoa = Pessoa;
        }
    }
}
