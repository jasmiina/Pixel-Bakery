using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToBakingView : MonoBehaviour {

	// Loads the baking scene
	public void OnClick () {
        SceneManager.LoadScene("BakingView", LoadSceneMode.Single);
    }

}
