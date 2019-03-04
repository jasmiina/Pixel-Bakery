using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using System.Text;
using UnityEngine.SceneManagement;

public class ChangeSpeech : MonoBehaviour {

    public Text customerspeech;
    public Text playerspeech;
    public Image customerSprite;
    public Sprite famousGuySprite;
    public Sprite poorBoySprite;
    public Sprite regWomanSprite;
    //public Sprite regManSprite;
    public Image customerBubble;
    public Image playerBubble;
    public Text moneyAmount;

    private static int convoNumber;
    private static bool firstTime;
    private static int lineNumber;
    private bool dialogueEnd;

    private System.Random rnd = new System.Random();

    void Start()
    {
        if (Stats.orderScene) { 
            Stats.customer = Stats.getCustomer();
        }
        else
        {
            //show moneystat
        }
        moneyAmount.text = Stats.money.ToString();
        customerBubble.enabled = false;
        playerBubble.enabled = false;

        //Resets the scene-dependent static variables
        convoNumber = generateConvoNumber();
        firstTime = true;
        lineNumber = 0;
        dialogueEnd = false;

        OnClick();
    }

    public void OnClick()
    {
        if (Stats.orderScene)
        {
            switch (Stats.customer)
            {
                case "famousGuy":
                    customerSprite.sprite = famousGuySprite;
                    showDialogue(Stats.famousGuyLinesOrder);
                    break;

                case "poorBoy":
                    customerSprite.sprite = poorBoySprite;
                    showDialogue(Stats.poorBoyLinesOrder);
                    break;

                case "regWoman":
                    customerSprite.sprite = regWomanSprite;
                    showDialogue(Stats.regWomanLinesOrder);
                    break;

                    /*case "regMan":
                        customerSprite.sprite = regManSprite;
                        showDialogue(Stats.regManLinesOrder);
                        break;*/
            }
        }
        else
        {
            if (Stats.correctOrder)
            {
                switch (Stats.customer)
                {
                    case "famousGuy":
                        customerSprite.sprite = famousGuySprite;
                        showDialogue(Stats.famousGuyLinesRight);
                        if (dialogueEnd)
                        {
                            Stats.money += 30;
                        }
                        break;

                    case "poorBoy":
                        customerSprite.sprite = poorBoySprite;
                        showDialogue(Stats.poorBoyLinesRight);
                        if (dialogueEnd)
                        {
                            Stats.money += 10;
                        }
                        break;

                    case "regWoman":
                        customerSprite.sprite = regWomanSprite;
                        showDialogue(Stats.regWomanLinesRight);
                        if (dialogueEnd)
                        {
                            Stats.money += 20;
                        }
                        break;
                }
            }
            else
            {
                switch (Stats.customer)
                {
                    case "famousGuy":
                        customerSprite.sprite = famousGuySprite;
                        showDialogue(Stats.famousGuyLinesWrong);
                        break;

                    case "poorBoy":
                        customerSprite.sprite = poorBoySprite;
                        showDialogue(Stats.poorBoyLinesWrong);
                        break;

                    case "regWoman":
                        customerSprite.sprite = regWomanSprite;
                        showDialogue(Stats.regWomanLinesWrong);
                        break;
                }
            }
        }
    }

    /**
     * Shows dialogue on screen and moves to next scene
     */
    private void showDialogue(String[] lines)
    {
        customerspeech.text = "";
        playerspeech.text = "";
        bool doesLineExist = false; //to loop past empty/number-only lines

        while (doesLineExist == false)
        {
            if (firstTime == true)
            {
                foreach (string s in lines)
                {
                    if (s == convoNumber.ToString())
                    {
                        customerspeech.text = lines[System.Array.IndexOf(lines, s)];
                        lineNumber += System.Array.IndexOf(lines, s) + 1;
                    }
                }
                firstTime = false;
            }
            else if (lines[lineNumber].StartsWith("c")) //Jos customer puhuu
            {
                playerBubble.enabled = false;
                customerBubble.enabled = true;
                string order = "";
                string line = lines[lineNumber].Substring(2);
                if (line.Contains("*pastryType*"))
                {
                    OrderChoices oc = new OrderChoices();
                    order = oc.getPastryType();
                    line = line.Replace("*pastryType*", order);
                    Stats.setCustomerOrder(order, "pastryType");
                }
                else if (line.Contains("*ingredient*"))
                {
                    OrderChoices oc = new OrderChoices();
                    order = oc.getIngredient();
                    line = line.Replace("*ingredient*", order);
                    Stats.setCustomerOrder(order, "ingredient");
                }
                else if (line.Contains("*adjective*"))
                {
                    OrderChoices oc = new OrderChoices();
                    order = oc.getAdjective();
                    line = line.Replace("*adjective*", order);
                    Stats.setCustomerOrder(order, "adjective");
                }
                Debug.Log(Stats.customerOrder);
                customerspeech.text = line;
                lineNumber++;
                doesLineExist = true;
            }
            else if (lines[lineNumber].StartsWith("p")) //Jos pelaaja puhuu
            {
                playerBubble.enabled = true;
                customerBubble.enabled = false;
                playerspeech.text = lines[lineNumber].Substring(2);
                lineNumber++;
                doesLineExist = true;
            }
            else if (lines[lineNumber] == "End")
            {
                doesLineExist = true;
                if (Stats.orderScene)
                {
                    Stats.setScene("BakingView");
                }
                else
                {
                    if (Stats.correctOrder)
                    {
                        dialogueEnd = true;
                    }
                        Stats.orderScene = true;
                    Stats.correctOrder = false;
                    Stats.setScene("CustomerView");
                }
            }
            else
            {
                doesLineExist = false;
            }
        }
    }

    /**
     * Generates a random number based on the amount of customer's dialogue
     */
    private int generateConvoNumber()
    {
        int conversationNumber = 0;
        switch (Stats.customer)
        {
            case "regWoman":
                conversationNumber = rnd.Next(1, 4);
                break;
            /*case "regMan":
                conversationNumber = rnd.Next(1, 4);
                break;*/
            case "famousGuy":
                conversationNumber = rnd.Next(1, 4);
                break;
            case "poorBoy":
                conversationNumber = rnd.Next(1, 4);
                break;
        }
        return conversationNumber;
    }

    /* OSANA ONCLICK()-METODIA, JOS HALUAA KESKUSTELUN JATKUVAN KRONOLOGISESTI EIKÄ RANDOMISTI
     * case "famousguy":
                customerSprite.sprite = famousguySprite;
                while (doesLineExist == false)
                {
                    Stats.famBoyDialog++;
                    string[] famBoyLines = linesToArray("Assets/Dialogue/famBoyDialog.txt"); //SIIRRÄ MUUALLE
                    if (famBoyLines.Length > Stats.famBoyDialog && famBoyLines[Stats.famBoyDialog].StartsWith("f"))
                    {
                        customerspeech.text = famBoyLines[Stats.famBoyDialog].Substring(2);
                        doesLineExist = true;
                    }
                    else if (famBoyLines.Length > Stats.famBoyDialog && famBoyLines[Stats.famBoyDialog].StartsWith("p"))
                    {
                        playerspeech.text = famBoyLines[Stats.famBoyDialog].Substring(2);
                        doesLineExist = true;
                    }
                    else if (famBoyLines[Stats.famBoyDialog] == "End")
                    {
                        doesLineExist = true;
                        //gotonextscene
                    }
                    else
                    {
                        doesLineExist = false;
                    }
                }
                break;

            case "poorboy":
                customerSprite.sprite = poorboySprite;
                while (doesLineExist == false)
                {
                    Stats.poorBoyDialog++;
                    string[] poorBoyLines = linesToArray("Assets/Dialogue/poorBoyDialog.txt"); //SIIRRÄ MUUALLE
                    if (poorBoyLines.Length > Stats.poorBoyDialog && poorBoyLines[Stats.poorBoyDialog].StartsWith("b"))
                    {
                        customerspeech.text = poorBoyLines[Stats.poorBoyDialog].Substring(2);
                        doesLineExist = true;
                    }
                    else if (poorBoyLines.Length > Stats.poorBoyDialog && poorBoyLines[Stats.poorBoyDialog].StartsWith("p"))
                    {
                        playerspeech.text = poorBoyLines[Stats.poorBoyDialog].Substring(2);
                        doesLineExist = true;
                    }
                    else if (poorBoyLines[Stats.poorBoyDialog] == "End")
                    {
                        doesLineExist = true;
                        //gotonextscene
                    }
                    else
                    {
                        doesLineExist = false;
                    }
                }
                break;
*/
}
