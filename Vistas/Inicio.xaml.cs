using DeberSemana7.Modelos;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace DeberSemana7.Vistas;

public partial class Inicio : ContentPage
{
    private const string Url = "http://192.168.17.59:8080/MOVILES/post.php";
    private readonly HttpClient cliente = new HttpClient();
    private ObservableCollection<Estudiante> estud;

    public Inicio()
    {
        InitializeComponent();
        Obtener();
    }


    public async void Obtener()
    {
        var content = await cliente.GetStringAsync(Url);
        List<Estudiante> mostrarEstudiante = JsonConvert.DeserializeObject<List<Estudiante>>(content);
        estud = new ObservableCollection<Estudiante>(mostrarEstudiante);
        listaEstudiante.ItemsSource = estud;


    }

    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Agregar());

    }

    private void listaEstudiante_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var objetoestudiante = (Estudiante)e.SelectedItem;
        Navigation.PushAsync(new ActualizarEliminar(objetoestudiante));
    }

}
