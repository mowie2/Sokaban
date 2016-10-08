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
    Level level = new Level(5);
    InputView iv = new InputView();
    List<string> validKeys = new List<string> { "W", "A", "S", "D" };

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

	public virtual void CheckIfWon()
	{
		
	}

    public void PlayTheGame()
    {
        while (!gameIsWon)
        {
            // returns key that you press wihtout printingit on the console window
            ConsoleKeyInfo key = Console.ReadKey(true);
            //check to make sure only valid keys are pressed
            if (!validKeys.Contains(key.Key.ToString().ToUpper()))
            {
                Console.WriteLine("Please press only the valid keys: WASD");
                PlayTheGame();
            }
            //Console.WriteLine(key.Key.ToString());
            level.MoveTruck(iv.Inputhandeler(key.Key.ToString()));
        }
    }

}

