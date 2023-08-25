
using StrangeScoutMobile.Games.ChargedUp2023;
using StrangeScoutMobile.Games.ChargedUp2023.Views;

namespace StrangeScoutMobile.Games.ChargedUp2023.Views;

public partial class Input : ContentPage
{
	private ChargedUpHome CUH = new ChargedUpHome();
	private ChargedUp CU;
	private Game game;

    private ChargedUpLocalDataBase CDB;


	private List<ObjectLocations> objectLocations;
	private List<ScoringPositions> scoringPositions;
	private List<ScoringPositions> history;


	public Input()
	{
		InitializeComponent();
        CU = CUH.getGame();
		game = CU.getGameObj();
		setUp();
    }

    //set config for charged up
	public void setUp()
	{
		objectLocations = game.GetLocations();
		scoringPositions = game.GetScoringPositions();
        game.round.setScoringPositions(scoringPositions);
        game.round.setObjectLocations(objectLocations);
		history = game.round.GetHistory();
        update();
        CDB.setup();
        //CDB.testAdd();
	}
    //search scoring pos by name
	public int ScorebyName(string name)
	{
		int index = 0;
		for(int i = 0; scoringPositions.Count > i; i++)
		{
			if (scoringPositions[i].getName() == name)
			{
				index = i; break;
			}
		}
		return index;
	}
    // search location by name
    public int LocationbyName(string name)
    {
        int index = 0;
        for (int i = 0; objectLocations.Count > i; i++)
        {
            if (scoringPositions[i].getName() == name)
            {
                index = i; break;
            }
        }
        return index;
    }


    //TODO one function pass in arg
    //Auto
    public void Mobility(object sender, EventArgs args)
	{
		game.round.Scored(scoringPositions[ScorebyName("Mobility")]);
	}
    public void Top_Node_Auto()
    {
        game.round.Scored(scoringPositions[ScorebyName("Top_Node_Auto")]);
    }
    public void Mid_Node_Auto()
    {
        game.round.Scored(scoringPositions[ScorebyName("Mid_Node_Auto")]);
    }
    public void Bot_Node_Auto()
    {
        game.round.Scored(scoringPositions[ScorebyName("Mobility")]);
    }
    public void CSDocked_Auto()
    {
        game.round.Scored(scoringPositions[ScorebyName("ChargeStation_Docked_Auto")]);
    }
    public void CSEngaged_Auto()
    {
        game.round.Scored(scoringPositions[ScorebyName("ChargeStation_Engaged_Auto")]);
    }

    //Tele scoring
    public void Top_Node_Tele()
    {
        game.round.Scored(scoringPositions[ScorebyName("Top_Node_Tele")]);
    }
    public void Mid_Node_Tele()
    {
        game.round.Scored(scoringPositions[ScorebyName("Mid_Node_Tele")]);
    }
    public void Bot_Node_Tele()
    {
        game.round.Scored(scoringPositions[ScorebyName("Bot_Node_Tele")]);
    }

    //Endround scoring
    public void Top_Node_EndGame()
    {
        game.round.Scored(scoringPositions[ScorebyName("Top_Node_Endgame")]);
    }
    public void Mid_Node_EndGame()
    {
       game. round.Scored(scoringPositions[ScorebyName("Mid_Node_EndGame")]);
    }
    public void Bot_Node_EndGame()
    {
       game.round.Scored(scoringPositions[ScorebyName("Bot_Node_EndGame")]);
    }
    public void Parked_EndGame()
    {
        game.round.Scored(scoringPositions[ScorebyName("Parked_EndGame")]);
    }
    public void CSDocked_EndGame()
    {
        game.round.Scored(scoringPositions[ScorebyName("ChargeStation_Docked_EndGame")]);
    }
    public void CSEngaged_EndGame()
    {
        game.round.Scored(scoringPositions[ScorebyName("ChargeStation_Engaged_EndGame")]);
    }

    //show and hide grid
    public void lockGrid()
    {
        GridInput.IsVisible = false;
    }
    public void UnlockGrid()
    {
        GridInput.IsVisible = true;
    }

    //undo last input
    public void Undo(object sender, EventArgs args)
	{
		game.round.Undo();
        update();
	}
	public void getScore(object sender, EventArgs args)
	{
		lable.Text = game.round.getPoints().ToString();
	}
	public void cyclestop(object sender, EventArgs args)
	{
        game.round.startCycle();
	}

 

    private void Top_Changed(object sender, CheckedChangedEventArgs e)
    {
        lockGrid();
        Stations.IsVisible = true;

        string state = game.round.getState();

        if(state == "auto")
        {
            Top_Node_Auto();
        }
        else if(state == "tele")
        {
            Top_Node_Tele();
            game.round.stopCycle().ToString();
            game.round.startCycle();
        }
        else if(state == "end")
        {
            Top_Node_EndGame();
            game.round.stopCycle().ToString();
            game.round.startCycle();
        }
        update();
    }
    private void Mid_Changed(object sender, CheckedChangedEventArgs e)
    {
        lockGrid();
        Stations.IsVisible = true;

        string state = game.round.getState();

        if (state == "auto")
        {
            Mid_Node_Auto();
        }
        else if (state == "tele")
        {
            Mid_Node_Tele();
            game.round.stopCycle();
            game.round.startCycle();
        }
        else if(state == "end")
        {
            Mid_Node_EndGame();
            game.round.stopCycle();
            game.round.startCycle();
        }
        update();
    }
    private void Bot_Changed(object sender, CheckedChangedEventArgs e)
    {
        lockGrid();
        Stations.IsVisible = true;

        string state = game.round.getState();

        if (state == "auto")
        {
            Bot_Node_Auto();
        }
        else if (state == "tele")
        {
            Bot_Node_Tele();
            game.round.stopCycle();
            game.round.startCycle();
        }
        else if (state == "end")
        {
            Bot_Node_EndGame();
            game.round.stopCycle();
            game.round.startCycle(); 
        }
        update();
    }

    private void Singles(object sender, EventArgs e)
    {
        game.round.SetLocationHistory(objectLocations[LocationbyName("SingleSubStation")]);
        UnlockGrid();
        Stations.IsVisible = false;
    }
    private void Doubles(object sender, EventArgs e)
    {
        game.round.SetLocationHistory(objectLocations[LocationbyName("DoubleSubStation")]);
        UnlockGrid();
        Stations.IsVisible = false;
    }
    private void Centers(object sender, EventArgs e)
    {
        game.round.SetLocationHistory(objectLocations[LocationbyName("Center_Field")]);
        UnlockGrid();
        Stations.IsVisible = false;
    }

    private void NScored(object sender, EventArgs e)
    {
        game.round.SetLocationHistory(objectLocations[LocationbyName("SingleSubStation")]);
        lockGrid();
        Stations.IsVisible = true;
    }

    public void updatePoints()
    {
        Points.Text = game.round.getPoints().ToString();
    }

    public void updateCycles()
    {
        Cycles.Text = game.round.avgCycle().ToString();
    }

    public void update()
    {
        updatePoints();
        updateCycles();
    }

 
}