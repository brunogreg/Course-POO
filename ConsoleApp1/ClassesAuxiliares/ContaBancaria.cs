using System.Globalization;

namespace Course.ClassesAuxiliares {
    internal class ContaBancaria {
        public double NumeroConta;
        public string TitularDaConta;
        private double Saldo; // armazena o valor real da conta
        
        public ContaBancaria(double numeroConta, string titular, double depositoInicial = 0) { // Construtor opcional com depósito inicial
            NumeroConta = numeroConta;
            TitularDaConta = titular;
            Saldo = depositoInicial;
        }
        
        public void Depositar(double valor) {  // Método para depósito
            Saldo += valor;
        }
                
        public void Sacar(double valor) { // Método para saque (desconta taxa fixa)
            Saldo -= valor;            
            Saldo -= 5.0;  //  taxa de saque de 5 reais
        }

        public double GetSaldo() {
            return Saldo;
        }

        public override string ToString() {
            return "Conta: "
                + NumeroConta
                + ", Titular: "
                + TitularDaConta
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
