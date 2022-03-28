using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicializacionDeUnCarrito.clases
{
   
        internal class Carro
        {
            public string Marca { get; }
            public int Modelo { get; }
            public String Color { get; set; }
            public int VMaxima { get; }

        private int Encendido = 0;
            private int velocidad_actual = 0;
            private const int MAXVELOCIDAD = 150;


        public Carro(string _marca, int _modelo, string _color, int _vmaxima)
        {
            Marca = _marca;
            Modelo = _modelo;
            Color = _color;
            VMaxima= _vmaxima; 
            Encendido = 0;
            this.velocidad_actual = 0;
        }

        public Carro(string v1, int v2, string v3)
        {
        }

        public string GetVelocidadActual()
        {
            return $"vamos a {velocidad_actual} KM/H";
        }

        public void EncendidoMotor()
        {
            if (Encendido == 0)
            {
                Console.WriteLine("Tu carro esta listo para correr");
                Encendido = 1;
                this.velocidad_actual = 0;
            }
            else
            {
                Console.WriteLine("Ya esta encendido tu carro!!!");
            }
        }

        public string acelerar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"no puedo acelerar con el carro apagado";
                return mensaje;
            }

            velocidad_actual += 20;
            if (velocidad_actual <= VMaxima)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = VMaxima;
                mensaje = $"{velocidad_actual}KPH Aguas rapido y furioso, vas muy rapido y ya llegaste al tope";
            }

          
            Console.WriteLine(mensaje);
            return mensaje;
        }

        public string desacelerar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"No puedes desacelerar si el carro esta apagado!!";
                return mensaje;
            }
            else
            {
                velocidad_actual -= 5;
                mensaje = $"Vas desacelerando, tu velocidad actual es {velocidad_actual}";

            }
            Console.WriteLine(mensaje);
            return mensaje; 
            
        }

        public string frenar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = "El carro esta apagado, no podemos frenar";
            }
            else
            {
                velocidad_actual -= 10;
                if (velocidad_actual >= 0)
                {
                    mensaje = $" vamos frenando, tu velocidad es {velocidad_actual}KM/H";

                }
                else
                {
                    mensaje = $"Ya no puedes frenar, vamos a 0KM/H";
                }
            }
            
            
            Console.WriteLine(mensaje);
            return mensaje; 
        }

        public void apagarmotor()
        {
            if (Encendido== 1)
            {
                Console.WriteLine("El Carro esta siendo apagado");
                Console.WriteLine("El carro ya está apagado");
                Encendido = 0;
            }
            else
            {
                Console.WriteLine("Lo siento! tu carro ya estaba apagado");
            }
        }

        public string Bocinar()
        {
            string mensaje = "wiii wiii wiiiiii!!! tu carro esta bocinando!";
            Console.WriteLine(mensaje); 
            return mensaje;
        }
    }
}
       
