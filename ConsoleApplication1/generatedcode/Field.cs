﻿using ConsoleApplication1.generatedcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Field : Item
{
    public Item hasObject {get;set;}
    private string originalName{get;set;}
    public int xPos { get; set; }
    public int yPos { get; set; }
    public Field(String _name, Item objects)
    {
        hasObject = objects;
        name = _name;
        originalName = _name;
      
       
    }

    public void addObject(Item _object)
    {
        if (hasObject == null)
        {
            hasObject = _object;
            

        }
    }
        public void RemoveObject()
        {
            hasObject = null;
        }

    public void DeterminName()
    {
        
        if (hasObject == null)
        {
            name = originalName;
        }
        else
        {
            name = hasObject.name;
        }
        if (hasObject != null)
        {
            if (hasObject.name.Equals("O") && this.originalName.Equals("x"))
            {
                name = "0";

            }
        }
    }
    
}

