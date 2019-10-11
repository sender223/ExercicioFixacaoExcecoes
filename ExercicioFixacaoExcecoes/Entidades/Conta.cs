using ExercicioFixacaoExcecoes.Entidades.ErrosPersonalizados;
using System.Globalization;

namespace ExercicioFixacaoExcecoes.Entidades  {
    class Conta {
        //declarando propriedade autoimplementada. 
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double SaqueLimite { get; set; }
        //construtor padrao
        public Conta() { }
        //construtor padrao com as propriedades
        public Conta(int numero, string nome, double saldo, double saqueLimite) {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
            SaqueLimite = saqueLimite;
        }
        //declarando metodo Deposito. 
        public void Deposito(double quantia) {
            Saldo += quantia;
        }
        //declarando metodo Saque com algumas condições if
        public void Saque(double quantia) {
            //se a quantia for maior que o limite do saque exibe o erro
            if (quantia > SaqueLimite) {
                throw new ErrosDeDominio("Não Pode fazer um saque maior que seu limite:");
            }//se a quantia for maior que o saldo da conta exibe o erro abaixo
            if (quantia > Saldo) {
                throw new ErrosDeDominio("Você não tem saldo disponivel para o Saque:");
            }
            //caso não ocorra nenhum erro ele faz a subtração
            Saldo = Saldo - quantia;
        }
        //aqui declaramos a variavel override string para exibir as informações 
        public override string ToString() {
            return "Número: " + Numero.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + "Nome: " + Nome + ", "
                + "Saldo Atualizado: " + Saldo.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + "Saque Limite: " + SaqueLimite.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
