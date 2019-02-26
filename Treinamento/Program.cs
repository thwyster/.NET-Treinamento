using System;

namespace Treinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Classe2
    {
        int variavel1;
        int variavel2;
        int variavel3;

        public int propiedade1 { get; set; }
        public int propiedade2 { get; set; }
        public int propiedade3 { get; set; }

        public void MetodoPublico() { }
        private void MetodoPrivado() { }
        protected void MetodoProtegido() { }
    }

    class Classe3
    {
        public int propiedade4 { get; set; }
        public int propiedade5 { get; set; }
        public int propiedade6 { get; set; }

        public void Metodo1()
        {
            propiedade4 = 1;
        }
    }

    struct Struct1
    {
        static int var1 = 1;
        const int var2 = 1;
        
        public void Metodo1()
        {

        }
    }
}
