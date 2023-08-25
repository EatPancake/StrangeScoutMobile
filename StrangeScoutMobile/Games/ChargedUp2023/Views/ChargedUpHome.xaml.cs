namespace StrangeScoutMobile.Games.ChargedUp2023.Views;

public partial class ChargedUpHome : ContentPage
{
	 static ChargedUp CU = new ChargedUp();

	public ChargedUpHome()
	{
		InitializeComponent();
		configGame();
	}

	public void configGame()
	{
		CU.MakeGame();
	}

	public ChargedUp getGame()
	{
		return CU;
	}
}