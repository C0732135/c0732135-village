using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0732135_village
{
    class Program
    {
        static void Main(string[]args)
        {
            (new learningExperiment()).run();

        }
    }
   
        }
    class learningExperiment
    {
        private Village c;

        public void run()
        {
            Village toronto;
            toronto = new Village();
            Village a, b;
            toronto.villageName = "verion A";
            a = toronto;
            Console.WriteLine(a.villageName);
            toronto = new Village();
            toronto.villageName = "version B";
            b = toronto;
            Console.WriteLine(b.villageName);
            toronto = new Village();
            toronto.villageName = "version c";
            c = toronto;
            Console.WriteLine(c.villageName);
       ajax.nextVillage = null;
        }
    }
    class Village
    {
       public bool isAstrelide;
      public  Village nextVillage;
        public Village preVillage;
        public string villageName;
    }
    class Countryside
    {
        Village toronto, maple, ajax;
        public void run() {
            maple = new Village();
                toronto = new Village();
                ajax = new Village();
            maple.villageName = "toronto";
            maple.nextVillage = toronto;
        }
    public void travel()
    {
        Village currentVillage = maple;
        while (currentVillage.isAstrelide!=null) { 
        
            Console.WriteLine("I am in" + currentVillage);
            if (currentVillage.isAstrelide)
                Console.WriteLine("You found Astrilde in" + currentVillage);


            else
                currentVillage = currentVillage.nextVillage;
    }
}
    

