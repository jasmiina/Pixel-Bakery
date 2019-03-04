using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseIngredient : MonoBehaviour {

    public Image image;
    private Text chosenIngredients;

    private bool onOrNot;


    private void Start()
    {
        chosenIngredients = GameObject.Find("ingredients").GetComponent<Text>();
    }

    public void OnClick () {

        string chosenIngredientName = "";
        if (image.sprite != null)
        {
            chosenIngredientName = image.sprite.name;
        }
        

        ToggleButton();
        string chosenIngredientsString = "";
        char c;
        if (onOrNot)
        {
            GetComponent<Image>().color = Color.gray;

            Stats.currentChosenIngredients.Add(chosenIngredientName);
            foreach (string s in Stats.currentChosenIngredients)
            {
                c = s[0];
                c = char.ToUpper(c);
                chosenIngredientsString += c + s.Substring(1) + "\n";
            }
            chosenIngredients.text = chosenIngredientsString;
        }
        else
        {
            GetComponent<Image>().color = Color.white;

            Stats.currentChosenIngredients.Remove(chosenIngredientName);
            foreach (string s in Stats.currentChosenIngredients)
            {
                c = s[0];
                c = char.ToUpper(c);
                chosenIngredientsString += c + s.Substring(1) + "\n";
            }
            chosenIngredients.text = chosenIngredientsString;
        }
    }

    public void ToggleButton()
    {
        onOrNot = !onOrNot;

    }
}

