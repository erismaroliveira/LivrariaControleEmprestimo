using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace LivrariaControleEmprestimo.WEB.Models
{
    public class EmprestimoViewModel
    {
        public Livro oLivro { get; set; }
        public Cliente oCliente { get; set; }
        public int idCliente { get; set; }
        public int idLivro { get; set; }
        [DisplayName("Data do Empréstimo")]
        public DateTime dataEmprestimo { get; set; }
        [DisplayName("Data da Entrega")]
        public DateTime dataEntrega { get; set; }
        public List<Cliente> oListCliente { get; set; }
        public List<Livro> oListLivro { get; set; }
    }
}
