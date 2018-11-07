using Restaurante.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioBase<TEntity>
        where TEntity : EntidadeBase
    {
        int Incluir(TEntity entidade);
        void Excluir(int id);
        void Excluir(TEntity entidade);
        void Alterar(TEntity entidade);
        TEntity SelecionarPorId(int id);
        IEnumerable<TEntity> SelecionarTodos();
    }
}
