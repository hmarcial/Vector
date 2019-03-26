using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class miVector
    {
        private int [] vec;
        public miVector(int tam)
        {
            vec = new int[tam];
        }
        public void llena(int inicio)
        {
            for(int i =0;i< vec.Length; i++)
            {
                vec[i] = inicio;
                inicio++;
            }
        }
        /// <summary>
        /// Funcion que mustre el vector
        /// </summary>
        /// <returns>Regresa posiciones del vector con Datos</returns>
        public string mostrar()
        {
            string dale = "";
            for(int i = 0; i < vec.Length; i++)
            {
                 dale+= "[ " + i + " ]= " + vec[i] +  Environment.NewLine;
            }
            return dale;
        }
        public void girarrriva()
        {
            int temporal = vec[vec.Length-1];
            for(int i = vec.Length-1; i >=1; i--)
            {        
                vec[i] = vec[i-1];
            }
            vec[0] = temporal;
        }
        public void giraabajo()
        {
            int temporal = 0;
            for(int i =0; i < vec.Length - 1; i++)
            {
                vec[i] = vec[i + 1];
            }
            vec[vec.Length - 1] = temporal;
        }
        public void invertir()
        {
            int temporal = 0;
            for(int i = 0; i> vec.Length - 1; i++)
            {
                for (int j = vec.Length - 1; j < 0; j--)
                {
                    temporal = vec[i];
                    vec[i] = vec[j];
                    vec[j] = temporal;
                }

            }
        }
    }
}