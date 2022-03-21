namespace Parcial1DanielSanchez
{
    public partial class Form1 : Form
    {
        List<Jugadores> jugadores = new List<Jugadores>();
        public Form1()
        {
            InitializeComponent();

            string nombreArchivo = "Jugadores.txt";

            FileStream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() != -1)
            {
                string texto = reader.ReadLine();
                comboBoxJugador.Items.Add(texto);
            }
            reader.Close();
        }

        private void GuardarRegistro()
        {
            FileStream stream = new FileStream("Goles.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var jugadores in jugadores)
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
            Jugadores jugador = new Jugadores();

            jugador.nojugador = comboBoxJugador.Text;
            jugador.fechaJuego = Convert.ToDateTime(dateTimePicker1.Text);
            jugador.equipo = textBoxEquipo.Text;
            jugador.goles = Convert.ToInt16(textBoxGoles.Text);

            jugadores.Add(jugador);
            GuardarRegistro();
           

        }
    }
}