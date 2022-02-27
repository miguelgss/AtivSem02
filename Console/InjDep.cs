using System;

namespace Console
{
    public interface IBancos
    {
        void DepositarDinheiro(double qtd);
        double VerificarConta();
    }

    public class Banco1 : IBancos
    {
        public void DepositarDinheiro(double qtd)
        {
            throw new NotImplementedException();
        }

        public double VerificarConta()
        {
            throw new NotImplementedException();
        }
    }
    public class Banco2 : IBancos
    {
        public void DepositarDinheiro(double qtd)
        {
            throw new NotImplementedException();
        }

        public double VerificarConta()
        {
            throw new NotImplementedException();
        }
    }

    public class Banco3 : IBancos
    {
        public long Dinheiro { get; private set; }
        public void DepositarDinheiro(double qtd)
        {
            throw new NotImplementedException();
        }

        public double VerificarConta()
        {
            throw new NotImplementedException();
        }
    }

    public class TransferenciasBancarias
    {
        private IBancos Banco1, Banco2;

        public TransferenciasBancarias(IBancos banco1, IBancos banco2)
        {
            Banco1 = banco1;
            Banco2 = banco2;
        }

        public void Transferir(IBancos banco1, IBancos banco2)
        {
            // TODO: Banco 01 entrega o valor e Banco 02 recebe o valor.
            System.Console.WriteLine("TransferenciasBancarias.Transferir Executado.");
        }
    }
}
