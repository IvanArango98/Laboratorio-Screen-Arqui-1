using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arqui
{
    public partial class Form1 : Form
    {
        public List<string> Lista = new List<string>();


        public Form1()
        {
            InitializeComponent();

            if (!Directory.Exists("C:\\LabArqui"))
                Directory.CreateDirectory("C:\\LabArqui");
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                Diccionario a = new Diccionario();
                string letra = Texto.Text.ToString();

                for (int i = 0; i < letra.Length; i++)
                {
                    char b = letra[i];
                    string nueva = (b + "").ToUpper();
                    a.Caracter(nueva, 1, 1);
                }
                Texto.Clear();
                Filas.Clear();
                Columnas.Clear();
                MessageBox.Show("Archivo creado exitosamentes");
          
            }

        private void CrearArchivoSalida()
        {
            if(Columnas.Text.ToString().Length >0 && Filas.Text.ToString().Length >0)
                {
                StringBuilder Archivo = new StringBuilder();
                int fila = int.Parse(Filas.Text.ToString());
                int columna = int.Parse(Columnas.Text.ToString());

                Archivo.Append("load Screen.hdl,");
                Archivo.Append(System.Environment.NewLine);
                Archivo.Append("output-file Screen.out,");
                Archivo.Append(System.Environment.NewLine);
                Archivo.Append("output-list in out;");
                Archivo.Append(System.Environment.NewLine);
                Archivo.Append("\n\r");

                for (int i = 0; i < Lista.Count; i++)
                {
                    if (Lista.ElementAt(i) != null)
                    {
                        int Decimal = 32 * fila + columna;
                        fila++;
                        string bin = Bus(Convert.ToString(Decimal, 2));
                        string nueva = new string(Lista.ElementAt(i).Reverse().ToArray());
                        Archivo.Append("set in %B" + nueva + ", set load 1 , set address %B" + bin + ", tick, tock, output;");
                        Archivo.Append(System.Environment.NewLine);
                    }
                    else if (Lista.ElementAt(i) == null)
                    {
                        columna++;
                        fila = Convert.ToInt32(Filas.Text);
                    }
                }

                StreamWriter writer = new StreamWriter(@"C:\\LabArqui\ArchivoSalida.tst");
                writer.Write(Archivo.ToString());
                writer.Close();
            }
            else{
                MessageBox.Show("Debe de ingresar fila y columna");
            }
        }

        private string Bus(string numero)
        {
            int difference = 13 - numero.Length;
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < difference; i++)
            {
                resultado.Append("0");
            }
            resultado.Append(numero);
            return resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string line = "";
          
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader letterFile = new System.IO.StreamReader(openFileDialog1.FileName);
                while ((line = letterFile.ReadLine()) != null)
                {
                    Lista.Add(line);
                }
                
                Lista.Add("0000000000000000");
                Lista.Add(null);
                letterFile.Close();
            }
            CrearArchivoSalida();
        }
    }
}
