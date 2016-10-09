﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Game
{
    private bool gameIsWon = false;
    string levelID;
     Level level;
    InputView iv = new InputView();
    List<string> validKeys = new List<string> { "W", "A", "S", "D","R","Q"};
    List<string> validLevels = new List<string> { "1", "2", "3", "4" };

    levelmanager lm = new levelmanager();

	public virtual InputView InputView
	{
		get;
		set;
	}
    public Game()
    {
        gameIsWon = false;
    }

	public virtual void StartGame()
	{
        Console.Clear();
        Console.WriteLine("┌────────────────────────────────────────────────────┐");
        Console.WriteLine("| Welkom bij Sokoban                                 |");
        Console.WriteLine("|                                                    |");
        Console.WriteLine("| betekenis van de symbolen   |   doel van het spel  |");
        Console.WriteLine("|                             |                      |");
        Console.WriteLine("| spatie : outerspace         |   duw met de truck   |");
        Console.WriteLine("|      █ : muur               |   de krat(ten)       |");
        Console.WriteLine("|      · : vloer              |   naar de bestemming |");
        Console.WriteLine("|      O : krat               |                      |");
        Console.WriteLine("|      0 : krat op bestemming |                      |");
        Console.WriteLine("|      x : bestemming         |                      |");
        Console.WriteLine("|      @ : truck              |                      |");
        Console.WriteLine("|  WASD  : beweging           |                      |");
        Console.WriteLine("└────────────────────────────────────────────────────┘");
        Console.WriteLine("Press enter to continoue");
        PlayTheGame();
	}

	public Boolean CheckIfWon()
	{
        if (level.getboxesleft() == true)
        {
            return true;
            
        }
        return false;
	}

    public void PlayTheGame()
    {
         levelID = Console.ReadLine();
        if (!validLevels.Contains(levelID))
        {
            Console.WriteLine("please enter a number between 1 and 4");
            PlayTheGame();
        }

        level = new Level(lm.ReadFile(int.Parse(levelID)));
        level.UpdateField();
        while (!CheckIfWon())
        {
            // returns key that you press wihtout printingit on the console window
            ConsoleKeyInfo key = Console.ReadKey(true);
            //check to make sure only valid keys are pressed
            if (!validKeys.Contains(key.Key.ToString().ToUpper()))
            {
                Console.WriteLine("Please press only the valid keys: WASD");
                continue;
            }

            string a = key.Key.ToString().ToUpper();
            if(a.Equals("R"))
            {
                ResetLevel();
            }
            if (a.Equals("Q"))
            {
                ResetSokoban();
            }
            //Console.WriteLine(key.Key.ToString());
            level.MoveTruck(iv.Inputhandeler(key.Key.ToString()));

            // update the map so it shows the new value's 
            level.UpdateField();
        }
        Console.WriteLine("You won this level! Press enter to go back to the menu");
        Console.ReadLine();
        ResetSokoban();
    }

    public void ResetSokoban()
    {
        Console.Clear();
        StartGame();
        PlayTheGame();
        Console.ReadLine();
    }
    public void ResetLevel()
    {
        Console.Clear();
        level = new Level(lm.ReadFile(int.Parse(levelID)));
        level.UpdateField();
    }
    
}

