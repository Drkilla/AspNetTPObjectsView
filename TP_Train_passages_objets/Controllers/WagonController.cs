using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP_Train_passages_objets.Controllers
{
    public class Passagers
    {
        public string nom;

        public Passagers(string pNom)
        {
            nom = pNom;
        }
        public Passagers()
        {

        }
    }

    public class Wagon
    {
        public int nombre;
        public int numero;
        public int nombrePassagers;
        public List<Passagers> listPassagers = new List<Passagers>();

        public Wagon(int pNombre,int pNumero,List<Passagers>LstPassagers)
        {
            nombre = pNombre;
            numero = pNumero;
            
            this.listPassagers = LstPassagers;
            

        }
        public Wagon()
        {

        }

    }

    public class Train 
    {
        
        public List<Wagon> lstWagons = new List<Wagon>();
        public Train(List<Wagon>lstWagon)
        {
            lstWagons = lstWagon;


        }
        public Train()
        {

        }
    }
    

    public class WagonController : Controller
    {
        

        
        
        // GET: Wagon
        public ActionResult Index()
        {
            Passagers mesPassagers = new Passagers();

            Wagon wagon1 = new Wagon();

            Train monTrain = new Train();

            wagon1.listPassagers.Add(new Passagers("Alice"));
            wagon1.listPassagers.Add(new Passagers("Bob"));
            wagon1.listPassagers.Add(new Passagers("Soshana"));
            wagon1.listPassagers.Add(new Passagers("Jeremie"));
            wagon1.numero = 1;

            Wagon wagon2 = new Wagon();
            wagon2.listPassagers.Add(new Passagers("Kevin"));
            wagon2.listPassagers.Add(new Passagers("Jean"));
            wagon2.listPassagers.Add(new Passagers("Donald"));
            wagon2.numero = 2;
            monTrain.lstWagons.Add(wagon1);
            monTrain.lstWagons.Add(wagon2);


            

            return View(monTrain);

        }
    }
}