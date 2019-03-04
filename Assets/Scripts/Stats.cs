using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.SceneManagement;

/**
 * Used to manage universal stats and methods that all classes need access for
 */
public static class Stats {

    /**
     * All the dialogue that is gotten from text files in StartNewGame-method
     */
    public static string[] famousGuyLinesOrder;
    public static string[] famousGuyLinesRight;
    public static string[] famousGuyLinesWrong;
    public static string[] poorBoyLinesOrder;
    public static string[] poorBoyLinesRight;
    public static string[] poorBoyLinesWrong;
    public static string[] regWomanLinesOrder;
    public static string[] regWomanLinesRight;
    public static string[] regWomanLinesWrong;
    /*public static string[] regManLinesOrder;
    public static string[] regManLinesRight;    //CHARACTER NOT IN USE
    public static string[] regManLinesWrong;*/

    /**
     * The currency player gets when what they have baked matches a customer's order
     */
    public static int money;

    /**
     * If true, shows the customer ordering. If false, shows the customer paying instead.
     */
    public static bool orderScene;

    /**
     * Tells what customer to show in the current scene.
     */
    public static string customer;

    /**
     * Tells what the customer wants to order
     */
    public static string customerOrder;

    /**
     * Tells what type customer's order is (eg. adjective)
     */
    public static string customerOrderType;

    public static void setCustomerOrder(string order, string orderType)
    {
        customerOrder = order;
        customerOrderType = orderType;
    }

    /**
     * Tells if what player baked matched customerorder or not
     */
    public static bool correctOrder;

    /**
     * Lists what ingredients player has chosen for the current baking scene
     */
     public static List<string> currentChosenIngredients = new List<string>();

    public static void setScene(string scene)
    {
        try
        {
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }
        catch (System.Exception e)
        {
            Debug.Log("Given scene parameter doesn't exist.");
        }
    }

    /**
     * Returns a customer randomly
     */
    public static string getCustomer()
    {
        System.Random rnd = new System.Random();
        int customerN = rnd.Next(1, 4);
        string customer = "";
        switch (customerN)
        {
            case 1:
                customer = "regWoman";
                break;
            case 2:
                customer = "poorBoy";
                break;
            case 3:
                customer = "famousGuy";
                break;
                /*case 4:
                    customer = "regMan";
                    break;*/
        }
        return customer;
    }
}

//NOT USED IN CURRENT VERSION
/**
     * Tells what part of famousguy's dialog to show.
     */
//public static int famBoyDialog;
/**
 * Tells what part of poorboy's dialog to show.
 */
//public static int poorBoyDialog;
/**
     * Tells what day it is.
     */
//public static int dayNumber;