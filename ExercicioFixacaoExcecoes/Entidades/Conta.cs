using ExercicioFixacaoExcecoes.Entidades.ErrosPersonalizados;
using System.Globalization;

namespace ExercicioFixacaoExcecoes.Entidades  {
    class Conta {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double SaqueLimite { get; set; }

        public Conta() { }

        public Conta(int numero, string nome, double saldo, double saqueLimite) {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
            SaqueLimite = saqueLimite;
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            if (quantia > SaqueLimite) {
                throw new ErrosDeDominio("Não Pode fazer um saque maior que seu limite:");
            }
            if (quantia > Saldo) {
                throw new ErrosDeDominio("Você não tem saldo disponivel para o Saque:");
            }
            Saldo = Saldo - quantia;
        }

        public override string ToString() {
            return "Número: " + Numero.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + "Nome: " + Nome + ", "
                + "Saldo Atualizado: " + Saldo.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + "Saque Limite: " + SaqueLimite.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
