using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arqui
{

    class Diccionario
    {

        private void A()
        {
            int row, column;
            string[,] letra = new string[16, 16];
            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (((column == 1 || column == 5) && row != 0) ||
                         ((row == 0 || row == 3) && (column > 1 && column < 5)))
                    {
                        letra[row, column] = ("1");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }
                      else
                    {
                        letra[row, column] = ("0");
                    }
                }
            }
            EscribirArchivo(letra, "Letra A");
            
        }

        private void B()
        {
            int row, column;

            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (column == 1 || ((row == 0 || row == 3 || row == 6) && (column < 5 && column > 1)) || (column == 5 && (row != 0 && row != 3 && row != 6)))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }

                }
               
            }
            EscribirArchivo(letra, "Letra B");

        }

        private void C()
        {
            int row, column;

            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if ((column == 1 && (row != 0 && row != 6)) || ((row == 0 || row == 6) && (column > 1 && column < 5)) || (column == 5 && (row == 1 || row == 5)))
                        {
                            letra[row, column] = ("1");
                        }
                        else
                        {
                            letra[row, column] = ("0");
                        }
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }
            }

            EscribirArchivo(letra, "Letra C");
        }

        private void D()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row <16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (column == 1 || ((row == 0 || row == 6) && (column > 1 && column < 5)) || (column == 5 && row != 0 && row != 6))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }
                
            }

            EscribirArchivo(letra, "Letra D");

        }

        private void E()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (column == 1 || ((row == 0 || row == 6) && (column > 1 && column < 6)) || (row == 3 && column > 1 && column < 5))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra E");

        }

        private  void F()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (column == 1 || (row == 0 && column > 1 && column < 6) || (row == 3 && column > 1 && column < 5))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra F");

        }

        private void G()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if ((column == 1 && row != 0 && row != 6) || ((row == 0 || row == 6) && column > 1 && column < 5) || (row == 3 && column > 2 && column < 6) || (column == 5 && row != 0 && row != 2 && row != 6))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra G");

        }

        private void H()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if ((column == 1 || column == 5) || (row == 3 && column > 1 && column < 6))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra H");

        }

        private void I()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (column == 3 || (row == 0 && column > 0 && column < 6) || (row == 6 && column > 0 && column < 6))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra I");

        }

        private void J()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if ((column == 4 && row != 6) || (row == 0 && column > 2 && column < 6) || (row == 6 && column == 3) || (row == 5 && column == 2))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra J");

        }

        private void K()
        {
            int row, column, j = 5, i = 0;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (column == 1 || ((row == column + 1) && column != 0))
                            letra[row, column] = ("1");
                        else if (row == i && column == j)
                        {
                            letra[row, column] = ("1");
                            i = i + 1;
                            j = j - 1;
                        }
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra K");

        }

        private void L()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (column == 1 || (row == 6 && column != 0 && column < 6))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra L");

        }

        private void M()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (column == 1 || column == 5 || (row == 2 && (column == 2 || column == 4)) || (row == 3 && column == 3))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra M");

        }

        private void N()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (column == 1 || column == 5 || (row == column && column != 0 && column != 6))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra N");

        }

        private void O()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (((column == 1 || column == 5) && row != 0 && row != 6) || ((row == 0 || row == 6) && column > 1 && column < 5))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra O");

        }

        private void P()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (column == 1 || ((row == 0 || row == 3) && column > 0 && column < 5) || ((column == 5 || column == 1) && (row == 1 || row == 2)))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra P");

        }

        private void Q()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if ((column == 1 && row != 0 && row != 6) || (row == 0 && column > 1 && column < 5) || (column == 5 && row != 0 && row != 5) || (row == 6 && column > 1 && column < 4) || (column == row - 1 && row > 3))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra Q");

        }

        private void R()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (column == 1 || ((row == 0 || row == 3) && column > 1 && column < 5) || (column == 5 && row != 0 && row < 3) || (column == row - 1 && row > 2))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra R");

        }

        private void S()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (((row == 0 || row == 3 || row == 6) && column > 1 && column < 5) || (column == 1 && (row == 1 || row == 2 || row == 6)) || (column == 5 && (row == 0 || row == 4 || row == 5)))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra S");

        }

        private void T()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (column == 3 || (row == 0 && column > 0 && column < 6))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra T");

        }

        private void U()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (((column == 1 || column == 5) && row != 6) || (row == 6 && column > 1 && column < 5))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra U");

        }

        private void V()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (((column == 1 || column == 5) && row < 5) || (row == 6 && column == 3) || (row == 5 && (column == 2 || column == 4)))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra V");

        }

        private void W()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (((column == 1 || column == 5) && row < 6) || ((row == 5 || row == 4) && column == 3) || (row == 6 && (column == 2 || column == 4)))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra W");

        }

        private void X()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (((column == 1 || column == 5) && (row > 4 || row < 2)) || row == column && column > 0 && column < 6 || (column == 2 && row == 4) || (column == 4 && row == 2))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra X");

        }

        private void Y()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (((column == 1 || column == 5) && row < 2) || row == column && column > 0 && column < 4 || (column == 4 && row == 2) || ((column == 3) && row > 3))
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra Y");

        }

        private void Z()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                    if (row < 7 && column < 7)
                    {
                        if (((row == 0 || row == 6) && column >= 0 && column <= 6) || row + column == 6)
                            letra[row, column] = ("1");
                        else
                            letra[row, column] = ("0");
                    }
                    else
                    {
                        letra[row, column] = ("0");
                    }
                }

            }

            EscribirArchivo(letra, "Letra Z");

        }

        private void Espacio()
        {
            int row, column;
            string[,] letra = new string[16, 16];

            for (row = 0; row < 16; row++)
            {
                for (column = 0; column < 16; column++)
                {
                   
                    letra[row, column] = ("0");
                }

            }

            EscribirArchivo(letra, "Espacio");

        }

        public void Caracter(string letra,int Fila,int columna)
        {
            
            List<String> Imprimir = new List<string>();
            

            switch (letra)
            {
                case "A":
                    A();
                 
                  
                    break;
                case "B":
                    B();
                
                    break;
                case "C":
                    C();
                  
                    break;
                case "D":
                    D();
                
                    break;
                case "E":
                    E();
           
                    break;
                case "F":
                    F();
             
                    break;
                case "G":
                    G();
            
                    break;
                case "H":
                    H();
               
                    break;
                case "I":
                    I();
                  
                    break;
                case "J":
                    J();
                 
                    break;
                case "K":
                    K();
       
                    break;
                case "L":
                    L();
                
                    break;
                case "M":
                    M();
                  
                    break;
                case "N":
                    N();
               
                    break;
                case "O":
                    O();
          
                    break;
                case "P":
                    P();
                 
                    break;
                case "Q":
                    Q();
            
                    break;
                case "R":
                    R();
                 
                    break;
                case "S":
                    S();

                    break;
                case "T":
                    T();
                 
                    break;
                case "U":
                    U();
                
                    break;
                case "V":
                    V();
               
                    break;
                case "W":
                    W();
                  
                    break;
                case "X":
                    X();
                  
                    break;
                case "Y":
                    Y();
                  
                    break;
                case "Z":
                    Z();
                 
                    break;
                case " ":
                    Espacio();
               
                    break;
                default:
                    MessageBox.Show("Caracter "+ letra + " no reconocido");
                    break;
            }
        }

        private void EscribirArchivo(string[,] letra, string nombre)
        {
            List<String> Imprimir = new List<string>();
            StringBuilder concatenar = new StringBuilder();
            
   

            for (int i = 0; i < 16; i++)
            {
                string tempo = "";
                for (int j = 0; j < 16; j++)
                {
                    tempo += letra[i, j];
                }
                Imprimir.Add(tempo);
            }

            StreamWriter writer = new StreamWriter(@"C:\\LabArqui\" + nombre + ".txt");
            foreach (var item in Imprimir)
            {
                writer.WriteLine(item);
            }

            

            writer.Close();
        }

        private List<string> LeerArchivo(string ruta)
        {
            List<string> list = new List<string>();
            using (StreamReader reader = new StreamReader(ruta))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line); 
                   
                }
            }
            return list;
        }

    }

    }

