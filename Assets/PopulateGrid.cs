using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateGrid : MonoBehaviour
{
    public GameObject prefab;

    public Sprite apple;
    public Sprite banana;
    public Sprite blueberry;
    public Sprite sugar;
    public Sprite flour;
    public Sprite cream;
    public Sprite nuts;
    public Sprite strawberry;
    public Sprite pear;
    public Sprite cacaopowder;
    public Sprite yeast;
    public Sprite cherry;
    public Sprite milkchocolatebar;
    public Sprite egg;
    public Sprite milk;
    public Sprite lingonberry;
    public Sprite vanilla;
    public Sprite butter;
    public Sprite honey;
    /*public Sprite darkchocolatebar;
    public Sprite whitechocolatebar;*/


    void Start()
    {
        Populate();
    }

    void Populate()
    {
        GameObject newObj;
        int numberToCreate = 19; // number of ingredients

        for (int i = 0; i < numberToCreate; i++)
        {
            Sprite ingSprite = null;
            switch (i) //makes ingredient buttons display all ingredients one by one
            {
                case 0:
                    ingSprite = apple;
                    break;
                case 1:
                    ingSprite = banana;
                    break;
                case 2:
                    ingSprite = blueberry;
                    break;
                case 3:
                    ingSprite = flour;
                    break;
                case 4:
                    ingSprite = yeast;
                    break;
                case 5:
                    ingSprite = cherry;
                    break;
                case 6:
                    ingSprite = cacaopowder;
                    break;
                case 7:
                    ingSprite = cream;
                    break;
                case 8:
                    ingSprite = egg;
                    break;
                case 9:
                    ingSprite = lingonberry;
                    break;
                case 10:
                    ingSprite = milk;
                    break;
                case 11:
                    ingSprite = nuts;
                    break;
                case 12:
                    ingSprite = milkchocolatebar;
                    break;
                case 13:
                    ingSprite = strawberry;
                    break;
                case 14:
                    ingSprite = sugar;
                    break;
                case 15:
                    ingSprite = vanilla;
                    break;
                case 16:
                    ingSprite = honey;
                    break;
                case 17:
                    ingSprite = pear;
                    break;
                case 18:
                    ingSprite = butter;
                    break;
            }
            prefab.GetComponent<Image>().sprite = ingSprite;
            newObj = (GameObject)Instantiate(prefab, transform);

            
        }

    }
}