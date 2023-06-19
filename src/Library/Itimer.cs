using System;
using System.Threading;


namespace Full_GRASP_And_SOLID;

public class Itimer:TimerClient
{

    private Recipe recipe;

    public Itimer(Recipe recipe)
    {
        this.recipe = recipe;
    }
    
    public void TimeOut()
    {
        recipe.SetCooked();
    }

   
}