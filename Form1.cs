namespace Parcial1DanielSanchez
{
    public partial class Form1 : Form
    {
        List<Jugadores> jugadores = new List<Jugadores>();
        List<Goles> gol = new List<Goles>();
        public Form1()
        {
            InitializeComponent();

            FileStream stream1 = new FileStream("Jugadores.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);

            while (reader1.Peek() != -1)
            {
                Jugadores gole = new Jugadores();
                gole.nojugador = reader1.ReadLine();
                gole.nombre = reader1.ReadLine();
                gole.equipo = reader1.ReadLine();

                jugadores.Add(gole);
            }
            reader1.Close();
            foreach(var a in jugadores)
            {
                comboBoxJugador.Items.Add(a.nombre);
               
            }
        }

        private void GuardarRegistro()
        {
            FileStream stream = new FileStream("Goles.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var jugadores in gol)
            {
                writer.WriteLine(jugadores.nojugador);
                writer.WriteLine(jugadores.fechaJuego);
                writer.WriteLine(jugadores.equipo);
                writer.WriteLine(jugadores.goles);

            }
            writer.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            foreach (var a in jugadores)
            {
               if (a.nombre == comboBoxJugador.Text)
                {

                    Goles goles = new Goles();

                    goles.nojugador = a.nojugador; 

                    goles.fechaJuego = Convert.ToDateTime(dateTimePicker1.Text);
                    goles.equipo = textBoxEquipo.Text;
                    goles.goles = Convert.ToInt16(textBoxGoles.Text);

                    gol.Add(goles);
                    GuardarRegistro();
                }

            }

           

        }

        private void buttonRegistros_Click(object sender, EventArgs e)
        {
            Form2 formregistro = new Form2();
            formregistro.Show();
        }
    }
}