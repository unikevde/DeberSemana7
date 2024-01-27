using System.Net;

namespace DeberSemana7.Vistas;

public partial class Agregar : ContentPage
{
	public Agregar()
	{
		InitializeComponent();
	}

    private void btnAgregar_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Hola","Prueba", "Cerrar");
        try
        {
           WebClient cliente = new WebClient();
           // WebClient cliente = new();
            var parametros = new System.Collections.Specialized.NameValueCollection();
            parametros.Add("codigo", txtCodigo.Text);
            parametros.Add("nombre", txtNombre.Text);
            parametros.Add("apellido", txtApellido.Text);
            parametros.Add("edad", txtEdad.Text);
            cliente.UploadValues("http://192.168.17.59:8080/MOVILES/post.php", "POST", parametros);
            DisplayAlert("Hola", "AGREGADO", "Cerrar");
            Navigation.PushAsync(new Inicio());
        }
        catch (Exception ex)
        {

            DisplayAlert("Alerta", ex.Message, "Cerrar");
        }

    }
}