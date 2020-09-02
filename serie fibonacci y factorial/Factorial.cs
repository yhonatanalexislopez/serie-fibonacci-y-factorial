using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serie_fibonacci_y_factorial
{
    public class Factorial:valor
    {
        public int calcularFactorial() 
        { 
         int factorial,numero;

            factorial = 1;
            numero = this.getNumero();
            for (int i = 1; i <= numero; i++) 
            {
                factorial = factorial * i;
            
            }
            return factorial;
        
        
        
        
        }
        
         
          
                
        
        }
    }

