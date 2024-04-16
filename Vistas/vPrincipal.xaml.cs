namespace caltamiranoT2.Vistas;

public partial class vPrincipal : ContentPage
{
	public vPrincipal(string Usuario)
	{
        
		InitializeComponent();
        DisplayAlert("Bienvenido", Usuario, "Cerrar");
        lblUsuario.Text = "Usuario conectado " + Usuario;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (pkAlumno.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "Seleccione un alumno", "Cerrar");
        }
        else
        {

            string dato = pkAlumno.Items[pkAlumno.SelectedIndex].ToString();
            lblAlumnopk.Text = "El dato seleccionado es: " + dato;
        }
    }
    private void btnCalificacion1_Clicked(object sender, EventArgs e)
    {
        Double nota1 = Convert.ToInt32(txtSeguimiento1.Text);
        Double examen1 = Convert.ToInt32(txtExamen1.Text);
        double calificacion1 = (nota1 * 0.3) + (examen1 * 0.2);
        lblSeguimiento1pk.Text = "Calificacion seguimiento 1 es : " + calificacion1;
    }
    private void btnCalificacion2_Clicked(object sender, EventArgs e)
    {
        Double nota2 = Convert.ToInt32(txtSeguimiento2.Text);
        Double examen2 = Convert.ToInt32(txtExamen2.Text);
        double calificacion2 = (nota2 * 0.3) + (examen2 * 0.2);
        lblSeguimiento2pk.Text = "Calificacion seguimiento 1 es : " + calificacion2;
    }
    private void btnCalificacionFinal_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtSeguimiento1.Text) || string.IsNullOrEmpty(txtSeguimiento2.Text) ||
          string.IsNullOrEmpty(txtExamen1.Text) || string.IsNullOrEmpty(txtExamen2.Text))
        {
            DisplayAlert("Alerta", "Ingrese todas las calificaciones", "Cerrar");
        }
        else
        {
            double notaSeguimiento1, notaSeguimiento2, notaExamen1, notaExamen2;

            if (!double.TryParse(txtSeguimiento1.Text, out notaSeguimiento1) ||
                !double.TryParse(txtSeguimiento2.Text, out notaSeguimiento2) ||
                !double.TryParse(txtExamen1.Text, out notaExamen1) ||
                !double.TryParse(txtExamen2.Text, out notaExamen2))
            {
                DisplayAlert("Alerta", "Ingrese notas válidas", "Cerrar");
                return;
            }

            if (notaSeguimiento1 < 0 || notaSeguimiento1 > 10 ||
                notaSeguimiento2 < 0 || notaSeguimiento2 > 10 ||
                notaExamen1 < 0 || notaExamen1 > 10 ||
                notaExamen2 < 0 || notaExamen2 > 10)
            {
                DisplayAlert("Alerta", "Ingrese notas dentro del rango válido (0 a 10)", "Cerrar");
                return;
            }
            double calificacionSeguimiento1 = (notaSeguimiento1 * 0.3)+(notaExamen1 * 0.2);
            double calificacionSeguimiento2 = (notaSeguimiento2 * 0.3)+(notaExamen2 * 0.2);
            double calificacionFinal = calificacionSeguimiento1 + calificacionSeguimiento2;
            string estado;
            if (calificacionFinal >= 7)
            {
                estado = "Aprobado";
            }
            else if (calificacionFinal >= 5 && calificacionFinal <= 6.9)
            {
                estado = "Complementario";
            }
            else
            {
                estado = "Reprobado";
            }
            string dato = pkAlumno.Items[pkAlumno.SelectedIndex].ToString();
            lblAlumnopk.Text = "El dato seleccionado es: " + dato;

            string fecha = dpFecha.Date.ToString();
            lblDatopk.Text = "El dato seleccionado es: " + fecha;
            
            lblFinalpk.Text = "Calificación final: " + calificacionFinal.ToString() + ", Estado: " + estado;
            
            DisplayAlert("Alerta", "Estudiante \n" + dato + "\n Fecha: \n" + fecha + "\n Nota parcial 1:  \n " + calificacionSeguimiento1+
           "\n Nota parcial 2: \n" + calificacionSeguimiento2 + "\n Nota final: \n" + calificacionFinal+ "\n Estado: \n" + estado, "Cerrar");
        }
    }
}