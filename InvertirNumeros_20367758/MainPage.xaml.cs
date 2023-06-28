namespace InvertirNumeros_20367758;

///<Summary>
///<Createddate>27/06/2023</Createddate>
///<company>INDEL</company>
///<lastmodificationdate>27/06/2023</lastmodificationdate>
///<lastmodificationdescription>
///Se asigno un nombre a cada entry
///
///</lastmodificationdescription>
///<lastmodifierautor>Erika Chávez</lastmodifierautor>
///</Summary>

public partial class MainPage : ContentPage
{
	/// <summary>
	/// Constructor
	/// </summary>

	public MainPage()
	{
		InitializeComponent();
	}

	/// <summary>
	/// evento que se ejecuta al dar clic en el boton 
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>

    private void btnInvertit_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(datoA.Text) && !string.IsNullOrEmpty(datoB.Text) &&
			!string.IsNullOrEmpty(datoC.Text) && !string.IsNullOrEmpty(datoD.Text))
		{
			double Dato1, Dato2, Dato3, Dato4;
			Dato1 = Convert.ToDouble(datoA.Text);
			Dato2 = Convert.ToDouble(datoB.Text);
			Dato3 = Convert.ToDouble(datoC.Text);
			Dato4 = Convert.ToDouble(datoD.Text);

			datoA.Text = Convert.ToString(Dato4);
			datoB.Text = Convert.ToString(Dato3);
            datoC.Text = Convert.ToString(Dato2);
            datoD.Text = Convert.ToString(Dato1);
        }
		else
		{
			DisplayAlert("error", "Introduce todos los números", "por favor");
		}
    }
}

