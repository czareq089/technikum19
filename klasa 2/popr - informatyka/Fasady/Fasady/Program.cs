/*namespace Fasada-pralka
{

    
    class WashingMachine
    {
         Washing w;
         Rinsing r; 
         Spinning s;
         
         public void startWashing() {}
         
         public void WeztoWypierz()
         {
             w = new Washing();
             r = new Rinsing();
             s = new Spinning();
         }
    }
    
    class Washing{
        public void wash() {}
    }
    
    class Rinsing{
        public void rinse() {}
    }
    
    class Spinning{
        public void spin() {}
    }
    
    class Client
    {
        WashingMachine wm;

        public void Pierz(WashingMachine wm)
        {
            this.wm = wm;
        }
    } 
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}*/
/*using System;
namespace FasadaAuto
{
    class Program
    {
        interface Car
        {
            void build();
        }
        
        class Chevrolet : Car
        {
            public void build()
            {
                Console.WriteLine("Chevrolet");
            }
        }

        class Renault : Car
        {
            public void build()
            {
                Console.WriteLine("Renault");
            }
        }

        class BMW : Car
        {
            public void build()
            {
                Console.WriteLine("BMW");
            }
        }

        class FacadeForCar
        {
            Car chevrolet;
            Car renault;
            Car bmw;
            
            public FacadeForCar()
            {
                chevrolet = new Chevrolet();
                renault = new Renault();
                bmw = new BMW();
            }
            
            public void buildChevrolet()
            {
                chevrolet.build();
            }
            
            public void buildRenault()
            {
                renault.build();
            }
            
            public void buildBMW()
            {
                bmw.build();
            }
            
            
            
            
        }
        
        public static void Main(string args[])
        {
            
        }
    }
}*/

/*namespace FasadaHomeTheater
{
    class HomeTheater
    {
        public void watchMovie() {}
        public void endMovie() {}
    }
    
    class Projector
    {
        public void on() {}
        public void off() {}
    }
    
    class SoundSystem
    {
        public void on() {}
        public void off() {}
    }

    class SetMediaPlayer
    {
        public void play() {}
        public void stop() {}
    }
}*/

/*namespace FasadaComposite
{
    class Program
    {
        interface Component
        {
            void operation();
        }
        
        public class Leaf : Component
        {
            public new void operation() {}
        }
        
        class Composite : Component
        {
            
            List<Composite> composites = new List<Composite>();
            
            public void operation() {}

            public void add(Composite com)
            {
                composites.Add(com);
            }
            
            public void remove() {}
            
            public void get() {}
        }
    }
}*/

namespace FasadaGraphic
{
    class Graphic {}
    
    class Picture : Graphic
    {
        public void draw() {}
        public void add() {}
        
    }
}