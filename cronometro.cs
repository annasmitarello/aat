using System;

namespace CronometroApp
{
    class Cronometro
    {
        private int segundos;
        public Cronometro()
        {
            minutos = 0;
            segundos = 0;
        }
        public void Reiniciar()
        {
            minutos = 0;
            segundos = 0;
        }
        public void IncrementarTiempo()
        {
            segundos++;

            if (segundos >= 60)
            {
                minutos++;
                segundos = 0;
            }
        }

        public string MostrarTiempo()
        {
            return minutos + " minutos, " + segundos + " segundos";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cronometro cronometro = new Cronometro();

            for (int i = 0; i < 5000; i++)
            {
                cronometro.IncrementarTiempo();
            }

            Console.WriteLine(cronometro.MostrarTiempo());
        }
    }
}
