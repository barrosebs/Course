using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;



        public double SalarioLiquido()
        {
           return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return
                "Funcionário: "
                + Nome
                + ", R$ "
                + ", \n Salario Líquido "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
