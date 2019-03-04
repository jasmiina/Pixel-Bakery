using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

/**
 * Starts a new game and initializes some global variables
 */
public class StartNewGame : MonoBehaviour {

    private void Start()
    {
        Stats.money = 0;

        Stats.famousGuyLinesOrder = linesToArray("Assets/Dialogue/famBoyDialog.txt");
        Stats.famousGuyLinesRight = linesToArray("Assets/Dialogue/famBoyDialogRight.txt");
        Stats.famousGuyLinesWrong = linesToArray("Assets/Dialogue/famBoyDialogWrong.txt");

        Stats.poorBoyLinesOrder = linesToArray("Assets/Dialogue/poorBoyDialog.txt");
        Stats.poorBoyLinesRight = linesToArray("Assets/Dialogue/poorBoyDialogRight.txt");
        Stats.poorBoyLinesWrong = linesToArray("Assets/Dialogue/poorBoyDialogWrong.txt");

        Stats.regWomanLinesOrder = linesToArray("Assets/Dialogue/regWomanDialog.txt");
        Stats.regWomanLinesRight = linesToArray("Assets/Dialogue/regWomanDialogRight.txt");
        Stats.regWomanLinesWrong = linesToArray("Assets/Dialogue/regWomanDialogWrong.txt");

        //CHARACTER NOT IN USE
        /*Stats.regManLinesOrder = linesToArray("Assets/Dialogue/regManDialog.txt");
        Stats.regManLinesRight = linesToArray("Assets/Dialogue/regManDialogRight.txt");
        Stats.regManLinesWrong = linesToArray("Assets/Dialogue/regManDialogWrong.txt");*/
    }

    public void onClick()
    {
        Stats.orderScene = true;
        Stats.setScene("CustomerView");
    }

    /**
     * Reads filePath's lines to array.
     */
    private string[] linesToArray(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        return lines;
    }
}
