namespace caltamiranoT2.Vistas;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		string Usuario = txtUsuario.Text;
		string contrasena = txtContrasena.Text;
		Navigation.PushAsync(new vLogin(Usuario, contrasena));
    }
}