
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class OutputView
{
	public virtual Level Level
	{
		get;
		set;
	}

	public virtual void PrintField()
	{
        Level.UpdateField();
	}

}

