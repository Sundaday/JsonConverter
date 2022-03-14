using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonSerializable
{
    class Personne
    {
        public int Id;
        public string Name;

        public Personne(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public void Afficher()
        {
            Console.WriteLine("Id : " + Id + " Name : " + Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var Personne = new Personne(2,"titi");
            //Personne.Id = 435245;
            //Personne.Name = "toto";
            //Personne.Afficher();

            ////Serialiser un objet en Json
            //string json = JsonConvert.SerializeObject(Personne);
            //Console.WriteLine(json);

            ////Déserialiser un Json en objet
            //string jsonTata = "{\"Id\":69,\"Name\":\"tata\"}";
            //Personne tata = JsonConvert.DeserializeObject<Personne>(jsonTata);
            //tata.Afficher();

            //var personnes = new List<Personne>() 
            //{
            //    new Personne (5,"Jean"),
            //    new Personne (6,"Claire"),
            //    new Personne (8,"Marc"),
            //    new Personne (51,"Paul"),
            //    new Personne (65,"Kevin"),
            //};

            //foreach (Personne person in personnes)
            //{
            //    //Console.WriteLine(person.Name);
            //}

            //string listJson = JsonConvert.SerializeObject(personnes);
            ////Console.WriteLine(listJson);
            //string path = "ListPersonne.txt";

            //try
            //{
            //    File.WriteAllText(path, listJson);
            //}catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

            string json = File.ReadAllText("listPersonne.txt");
            var listPersonne = JsonConvert.DeserializeObject<List<Personne>>(json);
            foreach (var personne in listPersonne) 
            {
                personne.Afficher();
            }
        }
    }
}
