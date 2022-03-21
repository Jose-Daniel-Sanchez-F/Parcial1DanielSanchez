using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1DanielSanchez
{
    public partial class Form2 : Form
    {
        List<Mostrar> mostrarGo = new List<Mostrar>();
        List<Goles> gol = new List<Goles>();
        List<Jugadores> juga = new List<Jugadores>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("Goles.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() != -1)
            {
                Goles gole = new Goles();
                gole.nojugador = reader.ReadLine();
                gole.fechaJuego = Convert.ToDateTime(reader.ReadLine());
                gole.equipo= reader.ReadLine();

                gole.goles=Convert.ToInt16(reader.ReadLine());

                gol.Add(gole);
            }
            reader.Close();
            FileStream stream1 = new FileStream("Jugadores.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);

            while (reader1.Peek() != -1)
            {
                Jugadores gole = new Jugadores();
                gole.nojugador = reader1.ReadLine();
                gole.nombre = reader1.ReadLine();   
                gole.equipo = reader1.ReadLine();

                juga.Add(gole);
            }
            reader1.Close();

            foreach(var a in juga)
            {
                foreach (var b in gol)
                {
                    if (a.nojugador==b.nojugador)
                    {
                        Mostrar mostrar = new Mostrar(); 
                        mostrar.nombre=a.nombre;
                        mostrar.goles = b.goles;
                        mostrarGo.Add(mostrar);

                    }

                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = mostrarGo;
            dataGridView1.Refresh();


        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {

        }
    }
}
