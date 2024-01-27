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

    }

    private void btnActualizar_Clicked(object sender, EventArgs e)
    {

    }
}