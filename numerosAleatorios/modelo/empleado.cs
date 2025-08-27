using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerosAleatorios.modelo
{
    public class empleado
    {
        private int numero;
        private string nombre;
        private DateTime fechaN;
        private bool sexo;
        private char grupo;
        private double salario;
        private bool seguro;

        public empleado()
        {
        }

        public empleado(int numero, string nombre, DateTime fechaN, bool sexo, char grupo, double salario, bool seguro)
        {
            this.Numero = numero;
            this.Nombre = nombre;
            this.FechaN = fechaN;
            this.Sexo = sexo;
            this.Grupo = grupo;
            this.Salario = salario;
            this.Seguro = seguro;
        }

        public int Numero { get => numero; set => numero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaN { get => fechaN; set => fechaN = value; }
        public bool Sexo { get => sexo; set => sexo = value; }
        public char Grupo { get => grupo; set => grupo = value; }
        public double Salario { get => salario; set => salario = value; }
        public bool Seguro { get => seguro; set => seguro = value; }
    }
}
