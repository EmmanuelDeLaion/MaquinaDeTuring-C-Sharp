using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaDeTuring
{
    public partial class Form1 : Form
    {
        String cadena, cadenaAuxiliar, aux;
        int estado = 0;
        int longitud;
        String[] arreglo;
        int apuntador = 1;

        public Form1()
        {
            InitializeComponent();
        }


        private void txtcadena_OnValueChanged(object sender, EventArgs e)
        {
            cadena = txtcadena.Text;
            cadenaAuxiliar = "#" + cadena + "#";
            longitud = cadenaAuxiliar.Length;
            arreglo = new String[longitud];
            for (int i = 0; i < longitud; i++)
            {
                arreglo[i] = "" + cadenaAuxiliar[i];
            }

            iniciarMarcadores();
        }


        private void btnPasos_Click(object sender, EventArgs e)
        {
            borrarMarcador();
            switch (estado)
            {
                case 0:
                    {
                        e0();
                        break;
                    }
                case 1:
                    {
                        e1();
                        break;
                    }
                case 2:
                    {
                        e2();
                        break;
                    }
                case 3:
                    {
                        e3();
                        break;
                    }
                case 4:
                    {
                        e4();
                        break;
                    }
            }
        }


        void actualizarcadena(String dato)
        {
            switch (apuntador)
            {
                case 1:
                    {
                        textBox2.Text = dato;
                        break;
                    }
                case 2:
                    {
                        textBox3.Text = dato;
                        break;
                    }
                case 3:
                    {
                        textBox4.Text = dato;
                        break;
                    }
                case 4:
                    {
                        textBox5.Text = dato;
                        break;
                    }
                case 5:
                    {
                        textBox6.Text = dato;
                        break;
                    }
                case 6:
                    {
                        textBox7.Text = dato;
                        break;
                    }
                case 7:
                    {
                        textBox8.Text = dato;
                        break;
                    }
                case 8:
                    {
                        textBox9.Text = dato;
                        break;
                    }
                case 9:
                    {
                        textBox10.Text = dato;
                        break;
                    }
                case 10:
                    {
                        textBox11.Text = dato;
                        break;
                    }
            }
        }

        void cabezal()
        {
            switch (apuntador)
            {
                case 0:
                    {
                        textBox12.Text = "^";
                        break;
                    }
                case 1:
                    {
                        textBox13.Text = "^";
                        break;
                    }
                case 2:
                    {
                        textBox14.Text = "^";
                        break;
                    }
                case 3:
                    {
                        textBox15.Text = "^";
                        break;
                    }
                case 4:
                    {
                        textBox16.Text = "^";
                        break;
                    }
                case 5:
                    {
                        textBox17.Text = "^";
                        break;
                    }
                case 6:
                    {
                        textBox18.Text = "^";
                        break;
                    }
                case 7:
                    {
                        textBox19.Text = "^";
                        break;
                    }
                case 8:
                    {
                        textBox20.Text = "^";
                        break;
                    }
                case 9:
                    {
                        textBox21.Text = "^";
                        break;
                    }
                case 10:
                    {
                        textBox23.Text = "^";
                        break;
                    }
            }
        }


        void moverderecha()
        {
            apuntador++;
        }


        void moverizquierda()
        {
            apuntador--;
        }


        void e0()
        {
            cabezal();
            aux = arreglo[apuntador];
            if (aux == "1")
            {
                arreglo[apuntador] = "x";
                actualizarcadena("x");
                moverderecha();
                estado = 1;
            }
            else if (aux == "B")
            {
                arreglo[apuntador] = "B";
                actualizarcadena("B");
                moverderecha();
                estado = 3;
            }
            else
            {

                MessageBox.Show("Cadena rechazada");
            }
            lbEstado.Text = "q" + estado;
        }



        void e1()
        {
            cabezal();
            aux = arreglo[apuntador];
            if (aux == "1")
            {
                arreglo[apuntador] = "1";
                actualizarcadena("1");
                moverderecha();
                estado = 1;
            }
            else if (aux == "B")
            {
                arreglo[apuntador] = "B";
                actualizarcadena("B");
                moverderecha();
                estado = 1;
            }
            else if (aux == "A")
            {
                arreglo[apuntador] = "B";
                actualizarcadena("B");
                moverizquierda();
                estado = 2;
            }
            else
            {
                MessageBox.Show("Cadena rechazada");
            }
            lbEstado.Text = "q" + estado;
        }

        void e2()
        {
            cabezal();
            aux = arreglo[apuntador];
            if (aux == "1")
            {
                arreglo[apuntador] = "1";
                actualizarcadena("1");
                moverizquierda();
                estado = 2;
            }
            else if (aux == "B")
            {
                arreglo[apuntador] = "B";
                actualizarcadena("B");
                moverizquierda();
                estado = 2;
            }
            else if (aux == "x")
            {
                arreglo[apuntador] = "1";
                actualizarcadena("1");
                moverderecha();
                estado = 0;
            }
            else
            {
                MessageBox.Show("Cadena rechazada");
            }
            lbEstado.Text = "q" + estado;
        }




        void e3()
        {
            cabezal();
            aux = arreglo[apuntador];
            if (aux == "A")
            {
                arreglo[apuntador] = "A";
                actualizarcadena("A");
                moverderecha();
                estado = 3;
            }
            else if (aux == "B")
            {
                arreglo[apuntador] = "B";
                actualizarcadena("B");
                moverderecha();
                estado = 3;
            }
            else if (aux == "#")
            {
                arreglo[apuntador] = "#";
                actualizarcadena("#");
                moverderecha();
                estado = 4;
            }
            else
            {
                MessageBox.Show("Cadena rechazada");
            }
            lbEstado.Text = "q" + estado;
        }



        void e4()
        {
            cabezal();
            MessageBox.Show("Cadena aceptada");
            lbEstado.Text =  "q" + estado;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuElipse1_TargetControlResized(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            lbEstado.Text = "";
            txtcadena.Text = "";
            textBox1.Text = "#";
            textBox2.Text = "#";
            textBox3.Text = "#";
            textBox4.Text = "#";
            textBox5.Text = "#";
            textBox6.Text = "#";
            textBox7.Text = "#";
            textBox8.Text = "#";
            textBox9.Text = "#";
            textBox10.Text = "#";
            textBox11.Text = "#";
            textBox12.Text = "";
             textBox13.Text = "";
             textBox14.Text = "";
             textBox15.Text = "";
             textBox16.Text = "";
             textBox17.Text = "";
             textBox18.Text = "";
             textBox19.Text = "";     
             textBox20.Text = "";    
             textBox21.Text = "";   
             textBox23.Text = "";

        }

        

        void iniciarMarcadores()
        {
            int posicion = 0;
            while (posicion < longitud)
            {
                switch (posicion)
                {
                    case 0:
                        {
                            textBox1.Text = (arreglo[0]);
                            break;
                        }
                    case 1:
                        {
                            textBox2.Text = (arreglo[1]);
                            break;
                        }
                    case 2:
                        {
                            textBox3.Text = (arreglo[2]);
                            break;
                        }
                    case 3:
                        {
                            textBox4.Text = (arreglo[3]);
                            break;
                        }
                    case 4:
                        {
                            textBox5.Text = (arreglo[4]);
                            break;
                        }
                    case 5:
                        {
                            textBox6.Text = (arreglo[5]);
                            break;
                        }
                    case 6:
                        {
                            textBox7.Text = (arreglo[6]);
                            break;
                        }
                    case 7:
                        {
                            textBox8.Text = (arreglo[7]);
                            break;
                        }
                    case 8:
                        {
                            textBox9.Text = (arreglo[8]);
                            break;
                        }
                    case 9:
                        {
                            textBox10.Text = (arreglo[9]);
                            break;
                        }
                    case 10:
                        {
                            textBox11.Text = (arreglo[10]);
                            break;
                        }
                }
                posicion++;
            }
            textBox12.Text = "^";
        }



        void borrarMarcador()
        {
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox23.Text = "";      
        }



    }
}
