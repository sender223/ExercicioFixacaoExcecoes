using System;
namespace ExercicioFixacaoExcecoes.Entidades.ErrosPersonalizados {
    //instanciamos a superclasse ApplicationException. 
    class ErrosDeDominio : ApplicationException {
        
        public ErrosDeDominio (string message) : base(message) { }
    }
}
