using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoClickerV1
{
    public partial class AutoClicker : Form
    {
        // Importar user32.dll para emular interacciones del usuario
        [DllImport("user32.dll")]

        // Variables y constantes para emular presionar boton de mouse
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint cButtons, uint dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        // Otras variables
        private Boolean iniciado = false;
        private Timer timer;
        private const int CONVERSION_MS_MIN = 60000;
        private const int INTERVALO_CENTRAR_CURSOR = 10;
        private const int DISTANCIA_MOV_CURSOR = 30;
        private int clics = 0;

        public AutoClicker()
        {
            InitializeComponent();
        }

        private void Btn_Principal_Evento(object sender, EventArgs e)
        {
            if (!iniciado)
            {
                iniciado = true;
                btn_Principal.Text = "Detener";

                if (chk_MinimizarVentana.Checked) 
                    MinimizarVentana();
                if (chk_CentrarCursor.Checked) 
                    CentrarCursor();

                Iniciartemporizador();
            }
            else
            {
                DetenerTemporizador();
                iniciado = false;
                btn_Principal.Text = "Iniciar";
            }
        }

        private void MinimizarVentana()
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Iniciartemporizador()
        {
            int retraso = (int)num_Retraso.Value;

            // SOLO PARA PRUEBAS, APLICAR CHECK EN OPCIONES ADICIONALES "TEST CADA 5 SEGS"
            if (retraso < 1)
                timer = new Timer() { Interval = 5000 };
            else
                timer = new Timer() { Interval = (int)num_Retraso.Value * CONVERSION_MS_MIN };

            timer.Tick += EmularActividad;
            timer.Start();
        }

        private void EmularActividad(object sender, EventArgs e)
        {
            // Incrementar contador de clics
            clics += 1;

            // Verificar si se debe centrar el cursor
            if(clics >= INTERVALO_CENTRAR_CURSOR && chk_CentrarCursor.Checked)
            {
                CentrarCursor();
                clics = 0;
            }

            // Obtener la posición actual del cursor
            int posX = Cursor.Position.X;
            int posY = Cursor.Position.Y;

            if (chk_MoverCursor.Checked)
            {
                Random random = new Random();
                int deltaX = random.Next(-DISTANCIA_MOV_CURSOR, DISTANCIA_MOV_CURSOR);
                int deltaY = random.Next(-DISTANCIA_MOV_CURSOR, DISTANCIA_MOV_CURSOR);

                posX = posX + deltaX;
                posY = posY + deltaY;

                Cursor.Position = new System.Drawing.Point(posX, posY);
            }
                
            // Emular un doble clic en la posición actual del cursor
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
        }

        private void CentrarCursor()
        {
            int centerScreenWidth = Screen.PrimaryScreen.Bounds.Width / 2;
            int centerScreenHeight = Screen.PrimaryScreen.Bounds.Height / 2;

            // Ubicar el cursor en el centro de la pantalla
            Cursor.Position = new System.Drawing.Point(centerScreenWidth, centerScreenHeight);
        }

        private void DetenerTemporizador()
        {
            timer.Stop();
        }
    }
}
