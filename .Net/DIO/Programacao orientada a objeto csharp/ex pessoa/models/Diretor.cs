using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex_pessoa.models
{
    public class Diretor : Professor
    {
        //método selado não posso utilizar na classe filha
         public override void Apresentar()
        {
            Console.WriteLine("Diretor");
        }
    }
}