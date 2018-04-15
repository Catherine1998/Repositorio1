using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_de_promedio_de_ventas
{
    class Ventas
    {
        private int codigo;
        private string descripcion;
        private double precio;

        private double mes1;
        private double mes2;
        private double mes3;
        private double mes4;
        private double mes5;
        private double mes6;

        public Ventas(int codigo, string descripcion, double precio, double mes1, double mes2, double mes3, double mes4, double mes5, double mes6)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Mes1 = mes1;
            this.Mes2 = mes2;
            this.Mes3 = mes3;
            this.Mes4 = mes4;
            this.Mes5 = mes5;
            this.Mes6 = mes6;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Mes1 { get => mes1; set => mes1 = value; }
        public double Mes2 { get => mes2; set => mes2 = value; }
        public double Mes3 { get => mes3; set => mes3 = value; }
        public double Mes4 { get => mes4; set => mes4 = value; }
        public double Mes5 { get => mes5; set => mes5 = value; }
        public double Mes6 { get => mes6; set => mes6 = value; }

        public double Calcular()
        {
            double p = 0;
            p = (this.mes1 + this.mes2 + this.mes3 + this.mes4 + this.mes5 + this.mes6) / 6;
            return p;
        }

    } 

   
}
