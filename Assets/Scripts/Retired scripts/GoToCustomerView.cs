using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToCustomerView : MonoBehaviour {

    // Loads the customer scene
    public void OnClick()
    {
        SceneManager.LoadScene("CustomerView", LoadSceneMode.Single);
    }
}
