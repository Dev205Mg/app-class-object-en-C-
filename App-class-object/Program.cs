using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_class_object
{
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant rakoto = new Etudiant();
            rakoto.setNote();
            rakoto.calcMoyenGe();
            rakoto.attribMention();
            rakoto.imprimBulletin();
        }
    }
}
