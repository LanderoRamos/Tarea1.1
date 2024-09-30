namespace Tarea1._1.Views;

public partial class Calculadora : ContentPage
{
    string intput1, intput2;

    public Calculadora()
	{
		InitializeComponent();

    }

    

    private void OnButton1Clicked(object sender, EventArgs e)
    {
        intput1 = MyEntry_1.Text;
        intput2 = MyEntry_2.Text;

        double result = double.Parse(intput1) + double.Parse(intput2);

        DisplayAlert("El resultado es:", ""+result, "OK");
    }

    private void OnButton2Clicked(object sender, EventArgs e)
    {
        intput1 = MyEntry_1.Text;
        intput2 = MyEntry_2.Text;

        double result = double.Parse(intput1) - double.Parse(intput2);

        DisplayAlert("El resultado es:", "" + result, "OK");
    }

    private void OnButton3Clicked(object sender, EventArgs e)
    {
        intput1 = MyEntry_1.Text;
        intput2 = MyEntry_2.Text;

        double result = double.Parse(intput1) * double.Parse(intput2);

        DisplayAlert("El resultado es:", "" + result, "OK");
    }

    private void OnButton4Clicked(object sender, EventArgs e)
    {
        intput1 = MyEntry_1.Text;
        intput2 = MyEntry_2.Text;

        double result = double.Parse(intput1) / double.Parse(intput2);

        DisplayAlert("El resultado es:", "" + result, "OK");
    }

    private void OnTextChanged(object sender, TextChangedEventArgs e)
    {
        // Puedes manejar el cambio de texto aquí si lo necesitas
        // Por ejemplo, validar el texto ingresado
    }
}