using numerosAleatorios.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerosAleatorios.dato
{
    internal class admnEmple
    {
     List<empleado> listaEmpleados = new List<empleado>();
        public void addEmpleado(empleado e)
        {
            listaEmpleados.Add(e);
        }
        Random r = new Random();
        String[] nom = { "Ana", "Luis", "Carlos", "Maria", "Jose", "Lucia", "Pedro", "Sofia", "Jorge", "Elena" };
        public void addEmpleado()
        {

            listaEmpleados.Clear();
            int num= r.Next(1, 80); 
            String nombre = nom[r.Next(nom.Length)];
            bool sexo = r.Next(2) == 0; ;
            DateTime fechaN = new DateTime(r.Next(1950, 2005), r.Next(1, 13), r.Next(1, 29));
            char grupo = (char)r.Next('A', 'D');
            double salario = r.Next(30000, 100000);
            bool seguro = r.Next(2) == 0;
            empleado e = new empleado(num, nombre, fechaN, sexo, grupo, salario, seguro);
            listaEmpleados.Add(e);

        }
        public List<empleado> showEmpleado()
        {
            return listaEmpleados;  
        }

    }
}
