using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {

        //Além do crud básico fazer uma pesquisa especial
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
