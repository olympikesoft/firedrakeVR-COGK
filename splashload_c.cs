using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class splashload_c : MonoBehaviour {

	// Use this for initialization
	void Start () 

	{
		StartCoroutine ("Countdown");

	}
	
	private IEnumerator Countdown ()
	{
		yield return new WaitForSeconds (5);
//		SceneManager.LoadScene ("1");

	}
}
