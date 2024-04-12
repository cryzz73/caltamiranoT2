namespace caltamiranoT2.Vistas;

public partial class vPrincipal : ContentPage
{
	public vPrincipal()
	{
		InitializeComponent();
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
        try
        {
            if (int.TryParse(lblSeguimiento1pk.Text, out int seguimiento1))
            {
                if (int.TryParse(lblSeguimiento2pk.Text, out int seguimiento2))
                {
                    double final = seguimiento1 + seguimiento2;
                    lblFinalpk.Text = "La calificación final es: " + final.ToString();
                }
                else
                {
                    lblFinalpk.Text = "Error: El segundo seguimiento no es un número válido.";
                }
            }
            else
            {
                lblFinalpk.Text = "Error: El primer seguimiento no es un número válido.";
            }
        }
        catch (Exception ex)
        {
            lblFinalpk.Text = "Error: Ocurrió un problema al calcular la calificación final.";
            Console.WriteLine("Error: " + ex.Message);
        }


    }
}