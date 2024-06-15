using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate
    {
        protected string? caracteres; 
        List<string>? ListCaracteres;
        
        public Calculate(string? _caracteres)
        {
            caracteres = _caracteres;
        }

        public void readCaracteres()
        {
            char[] separators = new char[] {'+', '-', '/', 'x'};
            string[] numbers = caracteres.Split(separators);            
        }
    }
}
