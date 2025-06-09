using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Media;
using System.IO;
using WMPLib;  // Agrega la referencia a Windows Media Player
namespace AhorcadoBetaC01
{
    public partial class Form1 : Form
    {
        
        int tiempoRestante = 60;
        string NameTabla;
        int ganadas = 0;
        int perdidas = 0;
        int errores = 0;
        string respuesta = "";
        bool modoAmigo = false;
        bool modoSolo = false;
        bool pausar = false;
        int indicePregunta = 0;
       

        int turnoActual = 1;
        int puntaje1 = 0;
        int puntaje2 = 0;
        bool modoDosJugadores = false;

        private void EvaluarResultado(bool acerto)
        {
            if (acerto)
            {
                if (turnoActual == 1)
                {
                    puntaje1++;
                    TxtPuntaje1.Text = puntaje1.ToString();
                }
                else
                {
                    puntaje2++;
                    TxtPuntaje2.Text = puntaje2.ToString();
                }

                MessageBox.Show("¡Bien hecho Jugador " + turnoActual.ToString() + "! Ahora le toca al Jugador: " + (turnoActual == 1 ? "2" : "1") + ".");
            }
            else
            {
                MessageBox.Show("Turno perdido. Ahora le toca al Jugador: " + (turnoActual == 1 ? "2" : "1") + ".");
            }

            // Cambiar el turno
            if (turnoActual == 1)
            {
                turnoActual = 2;
            }
            else
            {
                turnoActual = 1;
            }

            lblTurno.Text = "Turno del Jugador:  " + turnoActual.ToString();

            // Cargar siguiente pregunta
           // CargarSiguientePregunta();
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
            
        {
            NameTabla ="Niños";
            BtnNiños.Checked = true;
                        
            CmdJugar.Enabled = false;
            TxtNombre.Focus();
            ReproducirSonidoDesdeRecurso(Properties.Resources.entrada, "entrada.mp3");
        }

        private void ReproducirSonidoDesdeRecurso(byte[] sonidoRecurso, string nombreArchivoTemporal)
        {
            // Crear ruta temporal
            string rutaTemp = Path.Combine(Path.GetTempPath(), nombreArchivoTemporal);

            // Escribir el archivo en la ruta temporal
            File.WriteAllBytes(rutaTemp, sonidoRecurso);

            // Reproducir con Windows Media Player
            
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.URL = rutaTemp;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void CmdAdd_Click(object sender, EventArgs e)

        {
           
            string letraIngresada = TxtNombre.Text;
            if (string.IsNullOrWhiteSpace(letraIngresada) || letraIngresada.Length <1)
                {
                   MessageBox.Show("Ingresa un Nombre.");
                   TxtNombre.Focus();
                  return;
                }



            if (!modoSolo)
            {
                MessageBox.Show("¡Nombre ingresado! Juego listo para un jugador.");
                lblteam1.ForeColor = Color.LawnGreen;
                lblteam1.Text = TxtNombre.Text;
                lblteam2.ForeColor = Color.Red;
                lblteam2.Text = "PERDIDAS";
                TxtNombre.Text = "";
                TxtNombre.Focus();
                TxtNombre.Enabled = false;
                CmdAdd.Enabled = false;
                CmdJugar.Enabled = true;
                   
           }

            else
            {
                if (!modoAmigo)
                {
                    lblteam1.ForeColor = Color.LawnGreen;
                    lblteam1.Text = TxtNombre.Text;
                    MessageBox.Show("Primer jugador ingresado. Ahora escribe el nombre del segundo jugador.");
                    TxtNombre.Focus();
                    modoAmigo = true;
                    TxtNombre.Text = "";
                    TxtNombre.Focus();
                }
                else
                {
                    lblteam2.ForeColor = Color.LawnGreen;
                    lblteam2.Text = TxtNombre.Text;
                    modoAmigo = false;
                    MessageBox.Show("¡Jugadores listos! Empieza el juego.");
                    TxtNombre.Text = "";
                    TxtNombre.Focus();
                    TxtNombre.Enabled = false;
                    CmdAdd.Enabled = false;
                    CmdJugar.Enabled = true;
                }
            }
               
                                  
                                      

                       
        }
        private void TiempoContador()
        {
           
            TimerContador.Start();
        }
        private void CargarPreguntaDesdeCategoria(string categoria)
        {
            using (var conexion = new SQLiteConnection("Data Source=AhorcadoBeta.db3;Version=3;"))
            {

             conexion.Open();
             string sql = "SELECT pregunta, respuesta FROM " + categoria  + " LIMIT 1 OFFSET " + indicePregunta;
          
                
               using (var comando = new SQLiteCommand(sql, conexion))

            {
                using (SQLiteDataReader lector=comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        TxtPregunta.Text =lector["pregunta"].ToString ();
                        respuesta=lector["respuesta"].ToString ();
                    }
                    else
                    {
                        // Si ya no hay más preguntas, vuelve al inicio
                        indicePregunta = 0;
                        CargarPreguntaDesdeCategoria(NameTabla); // Llama de nuevo a la función para cargar la primera pregunta
                    }

                }
            }
               conexion.Close();
        }

}

        private void TimerContador_Tick(object sender, EventArgs e)
        {

            tiempoRestante--;
            TxtContador.Text = tiempoRestante.ToString();
            if (tiempoRestante <=0 )
            {
                ReproducirSonidoDesdeRecurso(Properties.Resources.perdisteh, "perdisteh.mp3");
                TimerContador.Stop();
                MessageBox.Show("¡ Tiempo Terminado!, Perdiste el Juego");
                if (modoDosJugadores)
                {
                    EvaluarResultado(false);
                    CmdJugar.Enabled = true;
                    txtLetraEntrada.Text = "";
                    txtLetraEntrada.Enabled = false;
                    tiempoRestante = 60;
                    ReproducirSonidoDesdeRecurso(Properties.Resources.entrada, "entrada.mp3");
                    return;
                }
                panelLetras.Controls.Clear();
                perdidas = perdidas + 1;
                TxtPuntaje2.Text = perdidas.ToString();
                MuestraImagenes();
                TxtPregunta.Text = "";

                tiempoRestante = 60;
                CmdJugar.Enabled = true;
                ReproducirSonidoDesdeRecurso(Properties.Resources.entrada, "entrada.mp3");
            }
            

         }

        private void MostrarCajasDeLetras(string palabra)
        {
            panelLetras.Controls.Clear(); // Limpia los anteriores

            int espacio = 5;
            int ancho = 30;
            int alto = 30;

            // Elegimos qué letras mostrar al azar
            Random rnd = new Random();
            List<int> indicesRevelados = new List<int>();

            int cantidadAMostrar = Math.Max(1, palabra.Length / 3); // Revelar aprox. 1/3 de las letras

            while (indicesRevelados.Count < cantidadAMostrar)
            {
                int index = rnd.Next(0, palabra.Length);
                if (!indicesRevelados.Contains(index))
                    indicesRevelados.Add(index);
            }

            for (int i = 0; i < palabra.Length; i++)
            {
                TextBox letraBox = new TextBox();
                letraBox.Name = "txtLetra" + i;
                letraBox.Width = ancho;
                letraBox.Height = alto;
                letraBox.MaxLength = 1;
                letraBox.Font = new Font("Arial", 14, FontStyle.Bold);
                letraBox.TextAlign = HorizontalAlignment.Center;
                letraBox.Location = new Point((ancho + espacio) * i, 10);

                if (indicesRevelados.Contains(i))
                {
                    letraBox.Text = palabra[i].ToString(); // Revela esta letra
                    letraBox.ReadOnly = true;
                    letraBox.BackColor = Color.LightGray;
                }
                else
                {
                    letraBox.Text = ""; // Vacía para que el jugador la complete
                    letraBox.ReadOnly = false;
                }

                panelLetras.Controls.Add(letraBox);
               
            }
        }
        private void CmdJugar_Click(object sender, EventArgs e)

            
        {
           
            indicePregunta++;
            CargarPreguntaDesdeCategoria(NameTabla);
            MostrarCajasDeLetras(respuesta);
            groupBox2.Enabled = false;
            CmdJugar.Enabled = false;
            txtLetraEntrada.Enabled = true;
            txtLetraEntrada.Focus();
            errores = 0;
            TiempoContador();
            
            for (int i = 1; i <= 6; i++)
            {
                PictureBox pic = this.Controls.Find("picAhorcado" + i, true).FirstOrDefault() as PictureBox;
                if (pic != null)
                    pic.Visible = true;
            }
            ReproducirSonidoDesdeRecurso(Properties.Resources.juegoPlay, "juegoPlay.mp3");
        }

        private void MuestraImagenes()
         {
             // bucle para colocar la propiedad visible=false a todos los picrures.
             for (int i = 1; i <= 6; i++)
             {
                 PictureBox pic = this.Controls.Find("picAhorcado" + i, true).FirstOrDefault() as PictureBox;
                 if (pic != null)
                     pic.Visible = false;
             }
        }

        private void CmdSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir del juego?",
                                              "Salir del juego",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); // Cierra toda la aplicación
            }
           
        }

        private void BtnNiños_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnNiños.Checked)
                NameTabla="Niños";
        }

        private void BtnSecundaria_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnSecundaria.Checked)
                NameTabla = "Secundaria";
        }

        private void BtnUniversidad_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnUniversidad.Checked)
                NameTabla = "Universidad";
        }

        private void BtnMaster_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnMaster.Checked)
                NameTabla = "Master";
        }

        

 private void BuscaGanador()
        {
            string RespuestaJugador="";
            string limpiaJugador;
            string limpiaBD;
     //bucle que obtiene respuesta del jugador mientras teclea
            for (int i = 0; i < respuesta.Length; i++)
            {
                    TextBox letraBox = this.Controls
                    .Find("txtLetra" + i, searchAllChildren: true)
                    .FirstOrDefault() as TextBox;
               
                if(letraBox != null)
                {
                 RespuestaJugador += letraBox.Text;
                                                  
                }
            
            }
            limpiaJugador = RespuestaJugador.Replace(" ", "").ToUpper();
            limpiaBD = respuesta.Replace(" ", "").ToUpper();
           
            if (limpiaJugador == limpiaBD)
            {
                TimerContador.Stop();
                ReproducirSonidoDesdeRecurso(Properties.Resources.ganador, "ganador.mp3");
                MessageBox.Show("¡Felicidades! Ganaste","Ganador");
                if (modoDosJugadores)
                {
                    EvaluarResultado(true);
                    CmdJugar.Enabled = true;
                    txtLetraEntrada.Text = "";
                    txtLetraEntrada.Enabled = false;
                    TxtContador.Text = "0";
                    tiempoRestante = 60;
                    groupBox2.Enabled = true;
                    ReproducirSonidoDesdeRecurso(Properties.Resources.entrada, "entrada.mp3");
                    return;
                }
            

                ganadas = ganadas + 1;
                TxtPuntaje1.Text = ganadas.ToString() ;
                txtLetraEntrada.Enabled = false;
                CmdJugar.Enabled = true;
                TxtContador.Text = "0";
                tiempoRestante = 60;
                errores = 0;
                ReproducirSonidoDesdeRecurso(Properties.Resources.entrada, "entrada.mp3");
            }
        }

private void ValidarLetra()
{
 string letraIngresada = txtLetraEntrada.Text.ToLower();
    bool acierto = false;


    // Recorro toda la longitud de la respuesta
    for (int i = 0; i < respuesta.Length; i++)
    {
        if (respuesta[i].ToString().ToLower() == letraIngresada)
        {
            // Busco la TextBox correspondiente por su nombre
            TextBox letraBox = this.Controls
                .Find("txtLetra" + i, searchAllChildren: true)
                .FirstOrDefault() as TextBox;

            if (letraBox != null && letraBox.Text == "")
            {
                letraBox.Text = letraIngresada;
                acierto = true;
            }
        }
    }

    if (!acierto)
    {
        errores++;
        // Muestra la imagen de ahorcado correspondiente (picAhorcado1..,picAhorcado6...)
        if (errores <= 6)
        {
            
            var pic = this.Controls
                .Find("picAhorcado" + errores, searchAllChildren: true)
                .FirstOrDefault() as PictureBox;
            if (pic != null) pic.Visible = false;
           
        }

        if (errores >= 6)
        {
            TimerContador.Stop();
            ReproducirSonidoDesdeRecurso(Properties.Resources.perdisteh, "perdisteh.mp3");
            MessageBox.Show("¡Perdiste! La palabra era:  " + respuesta  );

            if(modoDosJugadores)
            {
                EvaluarResultado(false);
                CmdJugar.Enabled = true;
                groupBox2.Enabled = true;
                TxtContador.Text = "0";
                tiempoRestante = 60;
                txtLetraEntrada.Text = "";
                txtLetraEntrada.Enabled = false;
                ReproducirSonidoDesdeRecurso(Properties.Resources.entrada, "entrada.mp3");
                return;
            }
            

            txtLetraEntrada.Enabled = false;
            CmdJugar.Enabled = true;
            perdidas = perdidas + 1;
            TxtPuntaje2.Text = perdidas.ToString();
            TxtContador.Text = "0";
            groupBox2.Enabled = true;
            tiempoRestante = 60;
            ReproducirSonidoDesdeRecurso(Properties.Resources.entrada, "entrada.mp3");
        }
    }
    else
    {
        // Verificar si ganó (todas las cajas ya tienen texto)
        bool gano = true;
        for (int i = 0; i < respuesta.Length; i++)
        {
            TextBox letraBox = this.Controls
                .Find("txtLetra" + i, searchAllChildren: true)
                .FirstOrDefault() as TextBox;
            if (letraBox != null && letraBox.Text == "")
            {
                gano = false;
                BuscaGanador();
                
                break;
            }
        }
        if (gano)
        {
            TimerContador.Stop();
            ReproducirSonidoDesdeRecurso(Properties.Resources.ganador, "ganador.mp3");
            MessageBox.Show("Felicidades ¡Ganaste!","Ganador");

            if (modoDosJugadores)
            {
                EvaluarResultado(true);
                CmdJugar.Enabled = true;
                txtLetraEntrada.Text = "";
                txtLetraEntrada.Enabled = false;
                TxtContador.Text = "0";
                tiempoRestante = 60;
                groupBox2.Enabled = true;
                ReproducirSonidoDesdeRecurso(Properties.Resources.entrada, "entrada.mp3");
                return;
            }
            txtLetraEntrada.Enabled = false;
            CmdJugar.Enabled = true;
            TxtContador.Text = "0";
            ganadas = ganadas + 1;
            TxtPuntaje1.Text = ganadas.ToString() ;
            tiempoRestante = 60;
            groupBox2.Enabled = true;
            ReproducirSonidoDesdeRecurso(Properties.Resources.entrada, "entrada.mp3");
        }
    }

    txtLetraEntrada.Clear();
    txtLetraEntrada.Focus();
}

private void txtLetraEntrada_KeyPress(object sender, KeyPressEventArgs e)
{
    
    // Convertir la tecla presionada en letra mayúscula
    char letraIngresada = char.ToUpper(e.KeyChar);
       

    // Convertimos también la palabra a mayúscula para comparar
    if (respuesta.ToUpper().Contains(letraIngresada))
    {
        txtLetraEntrada.Text = letraIngresada.ToString();
        MessageBox.Show("✅ ¡Acertaste! La letra es correcta.");
        
        ValidarLetra();

        e.Handled = true; // Evita que aparezca en el TextBox
        txtLetraEntrada.Focus();
    }
    else
    {
        MessageBox.Show("❌ Esta letra es incorrecta.");
         ValidarLetra();
         e.Handled = true; // Evita que aparezca en el TextBox
         txtLetraEntrada.Focus();
    }
    
}

private void txtLetraEntrada_TextChanged(object sender, EventArgs e)
{

}

private void BtnJugarS_CheckedChanged(object sender, EventArgs e)
{
    

}

private void BtnJugarA_CheckedChanged(object sender, EventArgs e)
{
   
}

private void CmdNuevo_Click(object sender, EventArgs e)
{
    CmdAdd.Enabled = true;
    TxtNombre.Enabled = true;
    CmdJugar.Enabled = false;
    lblteam1.ForeColor = Color.White;
    lblteam2.ForeColor = Color.White;
    lblteam1.Text = "TEAM - 1.....";
    lblteam2.Text = "PERDIDAS";

    puntaje1 = 0;
    puntaje2 = 0;
    modoDosJugadores = false;

    TxtPuntaje1.Visible = true;
    TxtPuntaje2.Visible = true;
    ganadas = 0;
    perdidas = 0;
    TxtPuntaje2.Text = "0";
    TxtPuntaje1.Text = "0";
    BtnJugarS.Checked = true;
    TimerContador.Stop();
    TxtContador.Text = "0";
    TxtPregunta.Text = "";
    txtLetraEntrada.Enabled = false;
    panelLetras.Controls.Clear();
    tiempoRestante = 60;
    TimerContador.Stop();
    
}

private void btnInstrucciones_Click(object sender, EventArgs e)
{
    
}



private void CmdPausar_Click(object sender, EventArgs e)
    
{
   int c = int.Parse(TxtContador.Text);
    
  if(c > 0)
    {

    
        if (!pausar)
        {
            TimerContador.Stop();
            CmdPausar.Text = "SEGUIR";
            btnInstrucciones.Enabled = false;
            txtLetraEntrada.Enabled = false;
            lbljuegoP.Visible = true;
            pausar = true;
        }
        else
        {
            TimerContador.Start();
            CmdPausar.Text = "PAUSAR";
            btnInstrucciones.Enabled = true;
            txtLetraEntrada.Enabled = true;
            lbljuegoP.Visible = false;
            pausar = false;
        }
    }   

}

private void CmdCancela_Click(object sender, EventArgs e)
{
    BtnJugarS.Checked = true;
    lblteam1.Text = "TEAM - 1.....";
    lblteam2.Text = "PERDIDAS";
}

private void BtnJugarS_CheckedChanged_1(object sender, EventArgs e)
{
    if (BtnJugarS.Checked)
    {

        modoDosJugadores = false;
        
        lblTurno.Text = "";

        modoSolo = false;
        modoAmigo = false;
        MessageBox.Show("Modo un jugador. Ingresa tu nombre.");
        TxtPuntaje1.Visible = true;
        ganadas = 0;
        perdidas = 0;
        

        TxtPuntaje1.Text = "0";
        TxtPuntaje2.Text = "0";
        lblteam1.Visible = true;
        CmdAdd.Enabled = true;
        CmdJugar.Enabled = false;
        TxtNombre.Enabled = true;
        lblteam1.Text = "TEAM - 1.....";
        lblteam2.Text = "PERDIDAS";
        TxtNombre.Focus();
    }
}

private void BtnJugarA_CheckedChanged_1(object sender, EventArgs e)
{
    if (BtnJugarA.Checked)
    {
        modoDosJugadores = true;
        turnoActual = 1;
        lblTurno.Text = "Turno del Jugador 1";

        modoSolo = true;
        modoAmigo = false;
        MessageBox.Show("Modo dos jugadores. Ingresa el nombre del primer jugador.");

        TxtPuntaje2.Visible = true;
        lblteam2.Visible = true;
        CmdAdd.Enabled = true;
        CmdJugar.Enabled = false;
        TxtNombre.Enabled = true;
        TxtNombre.Focus();
        ganadas = 0;
        perdidas = 0;
        TxtPuntaje1.Text = "0";
        TxtPuntaje2.Text = "0";
        lblteam1.Text = "TEAM - 1.....";
        lblteam2.Text = "TEAM - 2.....";
    }
}

private void btnInstrucciones_Click_1(object sender, EventArgs e)
{
    string instrucciones = "🎮 ¡Bienvenido al Juego del Ahorcado! 🕹️\n\n" +
            "🧠 Objetivo del juego:\n" +
            "Adivina la respuesta correcta antes de que se acabe el tiempo o se complete el dibujo del ahorcado.\n\n" +
            "⏱️ Tiempo límite:\n" +
            "Tienes 60 segundos para resolver cada palabra.\n\n" +
            "❌ Errores permitidos:\n" +
            "Solo puedes fallar 6 veces. ¡Cada error dibuja una parte del ahorcado!\n\n" +
            "👤 Modo de un jugador:\n" +
            "1. Ingresa tu nombre.\n" +
            "2. Elige una categoría: Niños, Secundaria, Universidad o Máster.\n\n" +
            "👥 Modo dos jugadores:\n" +
            "1. Selecciona 'Jugar con amigo'.\n" +
            "2. Ingresa los nombres de ambos jugadores.\n\n" +
            "📊 Estadísticas:\n" +
            "Lleva la cuenta de tus partidas ganadas y perdidas.\n\n" +
            "💡 Consejo:\n" +
            "Aprovecha las letras visibles para completar la palabra.\n\n" +
            "💡 Visual Studio 13:\n" +
            "Este Proyecto esta en C# y Compilado en Inno Setup 6.4.\n\n" +
            "🎉 ¡Buena suerte y diviértete! 🏆";

    MessageBox.Show(instrucciones, "Instrucciones del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
}

private void TxtNombre_TextChanged(object sender, EventArgs e)
{

}

private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
{
    if (BtnJugarS.Checked == false && BtnJugarA.Checked == false)
    {
        MessageBox.Show("Selecione una Opcion,Solo o con Amigo");
        TxtNombre.Clear();
        return;
    }
}

         



    }
} 

