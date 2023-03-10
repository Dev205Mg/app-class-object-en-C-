using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_class_object
{
    class Etudiant
    {
        public string nom, mention;
        public float note1, note2, moyenne;

        public Etudiant()
        {
        }

        public void setNote()
        {
            Console.Write("Nom = ");
            nom = Console.ReadLine();
            Console.Write("Note 1 = ");
            note1 = float.Parse(Console.ReadLine());
            Console.Write("Note 2 = ");
            note2 = float.Parse(Console.ReadLine());
        }
        public void calcMoyenGe()
        {
            moyenne = (this.note1 + this.note2) / 2;
        }
        public void attribMention()
        {
            if(moyenne <= 10)
            {
                mention = " Miezaha fa tsy ampy !!";
            } else if (moyenne <= 15)
            {
                mention = " Tsara fa tohizo ";
            }
            else
            {
                mention = " Tena tsara ";
            }
            
        }
        public void imprimBulletin()
        {
            Console.WriteLine(" Nom = " + nom);
            Console.WriteLine($" Moyenne = {moyenne} \n Mention = {mention}");// afaka atao otranio koa le izy
            Console.ReadKey();
        }
    }
}
