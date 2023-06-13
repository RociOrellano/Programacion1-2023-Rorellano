using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasessApp
{
    public class MarcaCelular
    {
        public static List<MarcaCelular> dameMarca()
        {
            //esta es la lista que voy a devolver
            List<MarcaCelular>  listita = new List<MarcaCelular>();

            MarcaCelular marca1 = new MarcaCelular();
            marca1.idMarca = 1;
            marca1.nameMarca = "Samsung";

            listita.Add(marca1);

            MarcaCelular  marca2 = new MarcaCelular();
            marca2.idMarca = 2;
            marca2.nameMarca = "Apple";

            listita.Add(marca2);

            MarcaCelular marca3 = new MarcaCelular();
            marca3.idMarca = 3;
            marca3.nameMarca = "HUAWEI";

            listita.Add(marca3);

            return listita;

        }
        public int idMarca { get; set; }
        public string nameMarca { get; set; }
        public string paisOrigen { get; set; }
    }
}
