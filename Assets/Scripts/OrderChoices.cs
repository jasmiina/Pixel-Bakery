using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/**
 * To create different ways customers can express what they want
 */
public class OrderChoices {

    // PastryType strings
    private const String pastryTypePastry = "some pastry";
    private const String pastryTypeCake = "some cake";
    private const String pastryTypeIceCream = "some ice cream";
    private const String pastryTypeDoughnut = "a doughnut";
    private const String pastryTypeBun = "a baked roll";
    // Ingredient strings
    private const String ingredientChoco = "chocolate";
    private const String ingredientBerries = "berries";
    private const String ingredientFruit = "fruit";
    private const String ingredientVanilla = "vanilla";
    private const String ingredientMilk = "milk";
    // Adjective strings
    private const String adjCreamy = "creamy";
    private const String adjFruity = "fruity";
    private const String adjCold = "cold";

    /**
     * Pastry categories
     */
    private string[] pastryTypes = { pastryTypePastry, pastryTypeCake, pastryTypeDoughnut, pastryTypeIceCream, pastryTypeBun };
    public string[] getPastryTypeList()
    {
        return pastryTypes;
    }
    public string getPastryType()
    {

        System.Random rnd = new System.Random();
        return pastryTypes[rnd.Next(0, pastryTypes.Length)];
    }
    // Methods return a string[] of recipe names that match the category
    public string[] typePastries()
    {
        string[] correctRecipes = new string[] {"Sweet bun", "Cherry bun", "Chocolate bun", "Angel cake", "Mudcake", "Berry cake",
        "Doughnut", "Chocolate doughnut", "Pink doughnut"};
        return correctRecipes;
    }
    public string[] typeCakes()
    {
        string[] correctRecipes = new string[] {"Angel cake", "Mudcake", "Berry cake"};
        return correctRecipes;
    }
    public string[] typeDoughnuts()
    {
        string[] correctRecipes = new string[] { "Doughnut", "Chocolate doughnut", "Pink doughnut" };
        return correctRecipes;
    }
    public string[] typeBuns()
    {
        string[] correctRecipes = new string[] {"Sweet bun", "Cherry bun", "Chocolate bun"};
        return correctRecipes;
    }
    public string[] typeIceCream()
    {
        string[] correctRecipes = new string[] { "Trio sundae", "Love sundae", "Rainbow sundae", "Dark dreams sundae",
            "Chocolate sundae", "Vanilla ice cream" };
        return correctRecipes;
    }

    /**
     * Spesific ingredients the customer wants, but it's better to be broad,
     * so the player doesn't have to choose from just one ingredient
     * (eg. chocolate -> milk chocolate, white chocolate or dark chocolate).
     */
    private string[] ingredients = { ingredientBerries, ingredientChoco, ingredientFruit, ingredientVanilla, ingredientMilk };
    public string[] getIngredientList()
    {
        return ingredients;
    }
    public string getIngredient()
    {
        System.Random rnd = new System.Random();
        return ingredients[rnd.Next(0, ingredients.Length)];
    }
    // Methods return a string[] of recipe names that have the ingredient
    public string[] ingBerries()
    {
        string[] correctRecipes = new string[] {"Cherry bun", "Angel cake", "Berry cake","Pink doughnut", "Trio sundae",
            "Love sundae", "Rainbow sundae", "Dark dreams sundae","Berry bowl"};
        return correctRecipes;
    }
    public string[] ingChocos()
    {
        string[] correctRecipes = new string[] {"Chocolate bun", "Mudcake", "Chocolate doughnut", "Trio sundae", "Love sundae",
            "Dark dreams sundae", "Chocolate sundae"};
        return correctRecipes;
    }
    public string[] ingFruits()
    {
        string[] correctRecipes = new string[] {"Rainbow sundae", "Dark dreams sundae", "Chocolate sundae", "Fruit bowl"};
        return correctRecipes;
    }
    public string[] ingVanillas()
    {
        string[] correctRecipes = new string[] {"Trio sundae","Vanilla ice cream"};
        return correctRecipes;
    }
    public string[] ingMilks()
    {
        string[] correctRecipes = new string[] {"Chocolate bun","Mudcake","Doughnut", "Chocolate doughnut", "Pink doughnut",
            "Trio sundae", "Love sundae", "Rainbow sundae", "Dark dreams sundae","Chocolate sundae", "Vanilla ice cream"};
        return correctRecipes;
    }


    /**
     * Descriptive words of what the customer wants.
     */
    private string[] adjectives = { adjCreamy, adjFruity, adjCold };
    public string[] getAdjectiveList()
    {
        return adjectives;
    }
    public string getAdjective()
    {
        System.Random rnd = new System.Random();
        return adjectives[rnd.Next(0, adjectives.Length)];
    }
    // Methods return a string[] of recipe names that match the adjective
    public string[] adjCreamys()
    {
        string[] correctRecipes = new string[] {"Trio sundae", "Love sundae", "Rainbow sundae", "Dark dreams sundae",
            "Chocolate sundae", "Vanilla ice cream", "Angel cake", "Berry cake"};
        return correctRecipes;
    }
    public string[] adjFruitys()
    {
        string[] correctRecipes = new string[] {"Fruit bowl", "Rainbow sundae", "Berry bowl", "Berry cake"};
        return correctRecipes;
    }
    public string[] adjColds()
    {
        string[] correctRecipes = new string[] { "Trio sundae", "Love sundae", "Rainbow sundae", "Dark dreams sundae",
            "Chocolate sundae", "Vanilla ice cream" };
        return correctRecipes;
    }


    //NOT USED IN CURRENT VERSION
    /**
     * Whole sentences that will imply what the customer wants.
     * Written in a general style, so the speaking style fits multiple customers.
     * Only used during spesific fitting events/seasons.
     */
    private string[] sentence = { "Do you have anything that will warm me up? I'm freezing!",
        "It's so cold out today, I need to something to make me warmer.",
        "It's so warm in here, do you have anything cold?" };
    
}
