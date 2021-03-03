using System;

namespace PR1_Load_planner
{
    class Objetos
    {
        public string nombre;
        public string abreviacion;
        public double pesoDelObjeto;
        // Peso está en kilogramos(kg)
        public int UnidadesQueOcupa;
        
        public Objetos(string nombre, string abreviacion, double pesoDelObjeto, int UnidadesQueOcupa)
        {
            this.nombre = nombre;
            this.abreviacion = abreviacion;
            this.pesoDelObjeto = pesoDelObjeto;
            this.UnidadesQueOcupa = UnidadesQueOcupa;
        }
    }
}