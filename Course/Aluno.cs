using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Aluno
    {
        public string AlunoNovo;
        public double Nota;

       public void NotaDoAluno()
        {
            for (int i = 0; i < 2; i++)
            {
                double n1 = Nota + Nota;
            }
        }
        public double MediaFinal(double nota)
        {
            string mensagem = "";
            double Media = nota / 3;
            if (Media > 60.0)
            {
                mensagem = "Aprovado = Média Final :" + Media;
            }else
                mensagem = "Reprovado = Média Final :" + Media;

            return Media;
        }
    }
}
