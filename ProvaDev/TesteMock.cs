using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaDev
{
    public interface VerificaBhaskara
    {

        string VerificaBhaskara(Teste t);

    }
       public class Teste: VerificaBhaskara
    {
        public double a { get; set; }
        public double b { get; set; }
        public double delta { get; set; }
        public double x1 { get; set; }
        public double x2 { get; set; }
    }
   
    public string VerificaBhaskara(Teste d);
    
            if (d.delta > 0)
               return "Retorna maior valor das raízes."
            else if (delta == 0)
            return
            "Raizes iguais, retorne o valor zero." 
            else if  (delta < 0)  
             return               
            "Retorna menor que zero!"
            

            }
}


