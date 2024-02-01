using DeberSemana7.Modelos;

namespace DeberSemana7.Vistas;

public partial class ActualizarEliminar : ContentPage
{
	public ActualizarEliminar(Estudiante datos)
	{
		InitializeComponent();
        txtCodigo.Text = datos.codigo.ToString();
        txtNombre.Text = datos.nombre.ToString();
        txtApellido.Text = datos.apellido.ToString();
        txtEdad.Text = datos.edad.ToString();
    }

    private void btnEliminar_Clicked(object sender, EventArgs e)
    {
	 string id=txtCodigo.Text.ToString();
 	string url = $"http://172.24.13.67/semana6/post.php?codigo={id}";
 	var content = await cliente.DeleteAsync(url);
	 await Navigation.PushAsync(new Inicio());
    }

    private void btnActualizar_Clicked(object sender, EventArgs e)
    {
	 string id = txtCodigo.Text.ToString();
 	string edad=txtNombre.Text.ToString();
 	string url = $"http://172.24.13.67/semana6/post.php";
	var content = await cliente.PutAsync(url);
        await Navigation.PushAsync(new Inicio());
    }
}
