using System;
namespace ExercicioFixacaoExcecoes.Entidades.ErrosPersonalizados {
    class ErrosDeDominio : ApplicationException {

        public ErrosDeDominio (string message) : base(message) { }
    }
}
