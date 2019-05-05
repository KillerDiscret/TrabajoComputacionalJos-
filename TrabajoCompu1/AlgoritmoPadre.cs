using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoCompu
{
    class AlgoritmoPadre
    {
        public static List<Deudor> Deudores { get; set; }

        
        public AlgoritmoPadre()
        {
            if(Deudores==null)
            {
                Deudores = new List<Deudor>();
            }
        }
        public void AgregarDatosManualmente(Deudor aux)
        {
            if (ExisteDNI(aux.DNI) == false )
            {
                Deudores.Add(aux);
            }
        }
        public void GenerarDatos()
        {
            //si volvemos a inicializar a los deudores lo que se almacena primero como manual
            //se perdera luego que pongamos agregar aleatoriamente
            //inicializarlo solo serviria cuando queremos generar otra lista aleatoria
            //para eliminar los anteriores y crear otros nuevos elementos
            //Deudores = new List<Deudor>();
            for (int i = 0; i < 1000; i++)
            {
                loop:
                Random r1 = new Random();
                Random r2 = new Random();
                Deudor aux = new Deudor();
                aux.DEUDA = r1.Next(1000, 50001);
                aux.DNI = r2.Next(70000000, 80000001);
                if (ExisteDNI(aux.DNI) == false && ExisteDeuda(aux.DEUDA) == false)
                {
                    Deudores.Add(aux);
                }
                else
                {
                    goto loop;
                }

            }
        }
        public bool ExisteDeuda(int DEUDA)
        {
            return Deudores.Exists(delegate (Deudor aux) { return aux.DEUDA == DEUDA; });
        }
        public bool ExisteDNI(int DNI)
        {
            return Deudores.Exists(delegate (Deudor aux) { return aux.DNI == DNI; });
        }

        public int[] OrdenarPorInsercion()
        {
            List<int> listaDeudas = new List<int>();
            foreach(Deudor x in Deudores)
            {
                listaDeudas.Add(x.DEUDA);
            }
            int[] arrDeudas = new int[Deudores.Count];
            for (int i = 0; i < Deudores.Count; i++)
            {
                arrDeudas[i] = listaDeudas[i];
            }
            int k, aux;
            for (int i = 0; i < Deudores.Count; i++)
            {
                k = i - 1;
                aux = arrDeudas[i];
                while ((k >= 0) && (aux < arrDeudas[k]))
                {
                    arrDeudas[k + 1] = arrDeudas[k];
                    k--;
                }
                arrDeudas[k + 1] = aux;
            }
            return arrDeudas;
        }
        public int[] OrdenarPorShell()
        {
            List<int> listaDeudas = new List<int>();
            foreach (Deudor x in Deudores)
            {
                listaDeudas.Add(x.DEUDA);
            }
            int[] arrDeudas = new int[Deudores.Count];
            for (int j = 0; j < Deudores.Count; j++)
            {
                arrDeudas[j] = listaDeudas[j];
            }
            int medio = Deudores.Count, i, aux;
            bool band;
            while (medio > 1)
            {
                medio = medio / 2;
                band = true;
                while (band == true)
                {
                    band = false;
                    i = 0;
                    while ((i + medio) < Deudores.Count)
                    {
                        if (arrDeudas[i] > arrDeudas[i + medio])
                        {
                            aux = arrDeudas[i];
                            arrDeudas[i] = arrDeudas[i + medio];
                            arrDeudas[i + medio] = aux;
                            band = true;
                        }
                        i++;
                    }
                }
            }

            return arrDeudas;
        }






    }
}
