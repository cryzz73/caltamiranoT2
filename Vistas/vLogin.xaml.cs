namespace caltamiranoT2.Vistas;

public partial class vLogin : ContentPage
{
    String Usuario1;
    string Contrasena1;
	public vLogin(string Usuario,string contrasena)
	{
		InitializeComponent();
        Usuario1 = Usuario;
        Contrasena1 = contrasena;
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
      /*string Usuario = "uisrael";
        string contrasena = "12345";*/
        if (Usuario1 == txtUsuario.Text && Contrasena1 == txtContrasena.Text)
        {
            Navigation.PushAsync(new vPrincipal(Usuario1));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/ Contraseña incorrectos", "Cerrar");
            txtUsuario.Text = "";
            txtContrasena.Text = "";

        }
    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());

    }
}