using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public class InjDep
    {

    }
}
