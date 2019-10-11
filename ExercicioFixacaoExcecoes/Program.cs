using System;
using System.Globalization;
using ExercicioFixacaoExcecoes.Entidades;
using ExercicioFixacaoExcecoes.Entidades.ErrosPersonalizados;

namespace ExercicioFixacaoExcecoes {
    class Program {
        static void Main(string[] args) {
            //colocamos o bloco de codigo dentro do try, ele ira tentar
            //caso falhe entra no bloco do catch e exibe o erro ocorrido. 
            try {
                Console.WriteLine("Entre com os Dados da Conta: ");
                Console.Write("Numero: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Deposito Inicial: ");
                double saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Limite de Saque: ");
                double limiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //instanciando a Classe Conta e atribuindo os valores. 
                Conta acc = new Conta(numero, nome, saldoInicial, limiteSaque);
                
                Console.WriteLine();
                Console.WriteLine("Entre com o valor para Saque: ");
                double qntSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //chamando a variavel e o metodo para colocar a quantidade que foi digitada para o saque
                acc.Saque(qntSaque);
                Console.WriteLine(acc);

            }catch (ErrosDeDominio e){
                Console.WriteLine("Erro de Saque: " + e.Message);                
            }
            catch (Exception e) {
                Console.WriteLine("Erro de Formatação: " + e.Message);
            }
        }
    }
}
