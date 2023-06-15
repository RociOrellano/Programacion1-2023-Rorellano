using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasessApp
{
  
    public class MarcaCelular
    {
        public static List<MarcaCelular> BaseDeDatosLasMarcas;
        public static List<MarcaCelular> dameMarca()
        {
            //esta es la lista que voy a devolver
            //List<MarcaCelular>  listita = new List<MarcaCelular>();
            if (BaseDeDatosLasMarcas == null)
            {
                BaseDeDatosLasMarcas = new List<MarcaCelular>();


                MarcaCelular marca1 = new MarcaCelular();
                marca1.idMarca = 1;
                marca1.nameMarca = "Samsung";

                BaseDeDatosLasMarcas.Add(marca1);

                MarcaCelular marca2 = new MarcaCelular();
                marca2.idMarca = 2;
                marca2.nameMarca = "Apple";

                BaseDeDatosLasMarcas.Add(marca2);

                MarcaCelular marca3 = new MarcaCelular();
                marca3.idMarca = 3;
                marca3.nameMarca = "HUAWEI";

                BaseDeDatosLasMarcas.Add(marca3);
            }
            return BaseDeDatosLasMarcas;

        }
        public int idMarca { get; set; }
        public string nameMarca { get; set; }
        public string paisOrigen { get; set; }
        public string modelo { get; set; }  
    }
}
