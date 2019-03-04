using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Shows customer order on UI
 */
public class ShowOrderText : MonoBehaviour {

    public Text orderText;

    void Start () {
        orderText.text = Stats.customerOrder;
    }
}
