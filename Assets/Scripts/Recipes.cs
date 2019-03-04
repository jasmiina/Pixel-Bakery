using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Holds information of recipes
 */
public class Recipes{
    
    string[] sweetbun;
    string[] cherrybun;
    string[] chocolatebun;
    string[] fruitbowl;
    string[] angelcake;
    string[] angelcake2;
    string[] berrybowl;
    string[] berrycake;
    string[] berrycake2;
    string[] berrycake3;
    string[] doughnut;
    string[] chocodoughnut;
    string[] chocodoughnut2;
    string[] pinkdoughnut;
    string[] pinkdoughnut2;
    string[] pinkdoughnut3;
    string[] mudcake;
    string[] vanillaicecream;
    string[] triosundae;
    string[] triosundae2;
    string[] chocosundae;
    string[] chocosundae2;
    string[] lovesundae;
    string[] rainbowsundae;
    string[] darksundae;

    public void Start() {
        //string[0] is the pastry name, rest are needed ingredients
        sweetbun = new string[] { "Sweet bun", "butter", "egg", "flour", "sugar", "yeast" };
        cherrybun = new string[] { "Cherry bun", "butter", "cherry" , "egg", "flour", "sugar", "yeast"};
        chocolatebun = new string[] { "Chocolate bun", "butter" ,"egg", "flour", "milk chocolate", "sugar", "yeast"};
        fruitbowl = new string[] { "Fruit bowl", "apple", "pear", "banana" };
        angelcake = new string[] { "Angel cake", "egg", "flour","sugar" };
        angelcake2 = new string[] { "Angel cake", "egg", "flour", "strawberry", "sugar" };
        berrybowl = new string[] { "Berry bowl", "blueberry", "cherry", "lingonberry", "strawberry" };
        berrycake = new string[] { "Berry cake", "cream", "butter", "egg", "flour", "strawberry", "sugar" };
        berrycake2 = new string[] { "Berry cake", "butter", "cream", "egg", "flour", "cherry", "sugar" };
        berrycake3 = new string[] { "Berry cake", "blueberry", "cream", "butter", "egg", "flour", "sugar" };
        doughnut = new string[] { "Doughnut", "butter", "flour", "milk", "sugar", "yeast" };
        chocodoughnut = new string[] { "Chocolate doughnut", "butter", "flour", "milk", "milk chocolate", "sugar", "yeast" };
        chocodoughnut2 = new string[] { "Chocolate doughnut", "butter", "cacao-powder", "flour", "milk", "sugar", "yeast" };
        pinkdoughnut = new string[] { "Pink doughnut", "butter", "flour", "milk", "strawberry", "sugar", "yeast" };
        pinkdoughnut2 = new string[] { "Pink doughnut", "butter", "cherry", "flour", "milk", "sugar", "yeast" };
        pinkdoughnut3 = new string[] { "Pink doughnut", "butter", "flour", "milk", "lingonberry", "sugar", "yeast" };
        mudcake = new string[] { "Mudcake", "butter", "egg", "flour", "milk chocolate", "sugar" };
        vanillaicecream = new string[] {"Vanilla ice cream", "cream","milk","sugar", "vanilla" };
        triosundae = new string[] { "Trio sundae", "cacao-powder", "cream", "milk", "strawberry", "sugar", "vanilla" };
        triosundae2 = new string[] { "Trio sundae", "cream", "milk", "milk chocolate", "strawberry", "sugar", "vanilla" };
        chocosundae = new string[] { "Chocolate sundae", "banana","cream", "milk", "milk chocolate", "sugar" };
        chocosundae2 = new string[] { "Chocolate sundae", "banana", "cacao-powder", "cream", "milk", "sugar" };
        lovesundae = new string[] { "Love sundae", "cream", "milk", "milk chocolate", "strawberry","sugar" };
        rainbowsundae = new string[] { "Rainbow sundae", "banana", "cream", "milk", "pear", "strawberry", "sugar" };
        darksundae = new string[] { "Dark dreams sundae", "blueberry", "cream", "milk", "milk chocolate", "sugar" };


        /* Pastry p1 = new Pastry("Sweet bun", sweetbun);
         Pastry p2 = new Pastry("Cherry bun", cherrybun);
         Pastry p3 = new Pastry("Chocolate bun", chocolatebun);*/
    }

    public string[][] getRecipes() {
        string[][] recipes = new string[25][] { sweetbun, cherrybun, chocolatebun, fruitbowl, angelcake, angelcake2, berrybowl, berrycake,
        berrycake2, berrycake3, doughnut, pinkdoughnut, chocodoughnut, chocodoughnut2, pinkdoughnut2, pinkdoughnut3, mudcake, vanillaicecream,
        triosundae, triosundae2, chocosundae, chocosundae2, lovesundae, rainbowsundae, darksundae};
        return recipes;
    }

}
