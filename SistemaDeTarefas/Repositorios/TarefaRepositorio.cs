using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios.Interfaces;

namespace SistemaDeTarefas.Repositorios
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        public Task<TarefaModel> Adicionar(TarefaModel tarefa)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TarefaModel> Atualizar(TarefaModel tarefaModel, int id)
        {
            throw new NotImplementedException();
        }

        public Task<TarefaModel> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TarefaModel>> BuscarTodasTarefas()
        {
            throw new NotImplementedException();
        }
    }
}
