using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
using System;

/**
 * Bakes something based on what ingredients player has chosen
 */
public class Bake : MonoBehaviour {

    private Texture recipeImage;

    public Texture fruitbowl;
    public Texture sweetbun;
    public Texture chocolatebun;
    public Texture cherrybun;
    public Texture angelcake;
    public Texture berrybowl;
    public Texture berrycake;
    public Texture doughnut;
    public Texture chocodoughnut;
    public Texture pinkdoughnut;
    public Texture mudcake;
    public Texture vanillaicecream;
    public Texture triosundae;
    public Texture chocosundae;
    public Texture lovesundae;
    public Texture rainbowsundae;
    public Texture darksundae;

    public GUIStyle popUpBox;
    public GUIStyle popUpText;
    public GUIStyle popUpButton;

    private Recipes gt = new Recipes();
    bool showBakeResultWindow;
    bool recipeExists;
    string matchedRecipe;

    /**
     * For pop-up window creation
     */
    public Rect windowRect = new Rect(0, 0, 0, 0);

    void Start()
    {
        int windowWidth = 100;
        int windowHeight = 90;
        int x = (Screen.width - windowWidth) / 2;
        int y = (Screen.height - windowWidth) / 2;
        windowRect.Set(x, y, windowWidth, windowHeight);

        recipeImage = sweetbun;
    }

    /**
     * Checks if what player has made matches a recipe
     */
    public void OnClick () {

        gt.Start();
        Stats.currentChosenIngredients.Sort();
        string[] currentChosenIngredients = Stats.currentChosenIngredients.ToArray();

        foreach (string[] recipe in gt.getRecipes())
        {
            string[] recipeIngredients = SubArray(recipe, 1, recipe.Length);
            Array.Sort(recipeIngredients);
            if (recipeIngredients.SequenceEqual(currentChosenIngredients))
            {
                matchedRecipe = recipe[0];
                recipeExists = true;

                switch (matchedRecipe)
                {
                    case "Fruit bowl":
                        recipeImage = fruitbowl;
                        break;
                    case "Sweet bun":
                        recipeImage = sweetbun;
                        break;
                    case "Chocolate bun":
                        recipeImage = chocolatebun;
                        break;
                    case "Cherry bun":
                        recipeImage = cherrybun;
                        break;
                    case "Angel cake":
                        recipeImage = angelcake;
                        break;
                    case "Berry bowl":
                        recipeImage = berrybowl;
                        break;
                    case "Berry cake":
                        recipeImage = berrycake;
                        break;
                    case "Doughnut":
                        recipeImage = doughnut;
                        break;
                    case "Chocolate doughnut":
                        recipeImage = chocodoughnut;
                        break;
                    case "Pink doughnut":
                        recipeImage = pinkdoughnut;
                        break;
                    case "Mudcake":
                        recipeImage = mudcake;
                        break;
                    case "Vanilla ice cream":
                        recipeImage = vanillaicecream;
                        break;
                    case "Trio sundae":
                        recipeImage = triosundae;
                        break;
                    case "Chocolate sundae":
                        recipeImage = chocosundae;
                        break;
                    case "Love sundae":
                        recipeImage = lovesundae;
                        break;
                    case "Rainbow sundae":
                        recipeImage = rainbowsundae;
                        break;
                    case "Dark dreams sundae":
                        recipeImage = darksundae;
                        break;
                }
                break;
            }
        }
        showBakeResultWindow = true;
        checkOrder();
    }


    void OnGUI()
    {
        if (showBakeResultWindow)
        {
            if (recipeExists)
            {
                windowRect = GUI.Window(0, windowRect, recipeWindow, "", popUpBox);
            }
            else
            {
                windowRect = GUI.Window(0, windowRect, notFoundWindow, "", popUpBox);
            }
        }
    }

    // When recipe is found
    void recipeWindow(int windowID)
    {
        GUI.Label(new Rect(10, 5, 80, 5), "You've made:", popUpText);
        GUI.Label(new Rect(10, 10, 80, 10), matchedRecipe, popUpText);
        GUI.DrawTexture(new Rect(25, 20, 48, 48), recipeImage);
        if (GUI.Button(new Rect(25, 65, 50, 20), "Serve!", popUpButton ))
        {
            Stats.currentChosenIngredients.Clear();
            showBakeResultWindow = false;
            Stats.orderScene = false;
            Stats.setScene("CustomerView");
        }
    }

    // When recipe is not found
    void notFoundWindow(int windowID)
    {
        GUI.Label(new Rect(10, 10, 80, 40), "That doesn't seem to work...", popUpText );
        if (GUI.Button(new Rect(25, 45, 50, 20), "Try again", popUpButton))
        {
            showBakeResultWindow = false;
        }
    }

    /**
     * Checks if what player has baked matches the Stats.customerOrder
     */
    public void checkOrder()
    {
        try
        {
            OrderChoices oc = new OrderChoices();
            if (Stats.customerOrderType.Equals("pastryType"))
            {
                if (Stats.customerOrder.Equals("some pastry"))
                {
                    foreach (string pastry in oc.typePastries())
                    {
                        if (matchedRecipe.Equals(pastry))
                        {
                            Stats.correctOrder = true;
                        }
                    }
                }
                if (Stats.customerOrder.Equals("a cake"))
                {
                    foreach (string pastry in oc.typeCakes())
                    {
                        if (matchedRecipe.Equals(pastry))
                        {
                            Stats.correctOrder = true;
                        }
                    }
                }
                if (Stats.customerOrder.Equals("some ice cream"))
                {
                    foreach (string pastry in oc.typeIceCream())
                    {
                        if (matchedRecipe.Equals(pastry))
                        {
                            Stats.correctOrder = true;
                        }
                    }
                }
                if (Stats.customerOrder.Equals("a doughnut"))
                {
                    foreach (string pastry in oc.typeDoughnuts())
                    {
                        if (matchedRecipe.Equals(pastry))
                        {
                            Stats.correctOrder = true;
                        }
                    }
                }
                if (Stats.customerOrder.Equals("a baked roll"))
                {
                    foreach (string pastry in oc.typeBuns())
                    {
                        if (matchedRecipe.Equals(pastry))
                        {
                            Stats.correctOrder = true;
                        }
                    }
                }
            }
            if (Stats.customerOrderType.Equals("ingredient"))
            {
                if (Stats.customerOrder.Equals("chocolate"))
                {
                    foreach (string pastry in oc.ingChocos())
                    {
                        if (matchedRecipe.Equals(pastry))
                        {
                            Stats.correctOrder = true;
                        }
                    }
                }
                if (Stats.customerOrder.Equals("berries"))
                {
                    foreach (string pastry in oc.ingBerries())
                    {
                        if (matchedRecipe.Equals(pastry))
                        {
                            Stats.correctOrder = true;
                        }
                    }
                }
                if (Stats.customerOrder.Equals("vanilla"))
                {
                    foreach (string pastry in oc.ingVanillas())
                    {
                        if (matchedRecipe.Equals(pastry))
                        {
                            Stats.correctOrder = true;
                        }
                    }
                }
                if (Stats.customerOrder.Equals("milk"))
                {
                    foreach (string pastry in oc.ingMilks())
                    {
                        if (matchedRecipe.Equals(pastry))
                        {
                            Stats.correctOrder = true;
                        }
                    }
                }
                if (Stats.customerOrder.Equals("fruit"))
                {
                    foreach (string pastry in oc.ingFruits())
                    {
                        if (matchedRecipe.Equals(pastry))
                        {
                            Stats.correctOrder = true;
                        }
                    }
                }
            }
            if (Stats.customerOrderType.Equals("adjective"))
            {
                if (Stats.customerOrder.Equals("creamy"))
                {
                    foreach (string pastry in oc.adjCreamys())
                    {
                        if (matchedRecipe.Equals(pastry))
                        {
                            Stats.correctOrder = true;
                        }
                    }
                }
                if (Stats.customerOrder.Equals("fruity"))
                {
                    foreach (string pastry in oc.adjFruitys())
                    {
                        if (matchedRecipe.Equals(pastry))
                        {
                            Stats.correctOrder = true;
                        }
                    }
                }
                if (Stats.customerOrder.Equals("cold"))
                {
                    foreach (string pastry in oc.adjColds())
                    {
                        if (matchedRecipe.Equals(pastry))
                        {
                            Stats.correctOrder = true;
                        }
                    }
                }
            }
        }
        catch (NullReferenceException e)
        {
            Debug.Log(e.ToString());
        }
    }

    public string[] SubArray(string[] array, int start, int end)
    {
        int len = end - start;
        string[] result = new string[len];
        for(int i = 0; i<len; i++)
        {
            result[i] = array[i + start];
        }
        return result;
    }
}
