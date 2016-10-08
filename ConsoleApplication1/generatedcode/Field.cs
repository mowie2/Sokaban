using ConsoleApplication1.generatedcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Field : Item
{
    Item hasObject;
    private string originalName{get;set;}
    public Field(String _name)
    {
        name = _name;
        originalName = _name;
      
        if (_name.Equals("█"))
        {
            hasObject = new Item();
        }
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
    }
    
}

