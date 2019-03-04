using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pastry {

    private string Name;
    string[] Ingredients;

	public Pastry(string name, string[] ingredients)
    {
        Name = name;
        Ingredients = ingredients;
    }

    public string giveName()
    {
        return Name;
    }
    public string[] giveIngredients()
    {
        return Ingredients;
    }
}
