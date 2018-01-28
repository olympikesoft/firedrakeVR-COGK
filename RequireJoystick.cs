using UnityEngine;
using UnityEngine.SceneManagement;

public class RequireJoystick : MonoBehaviour
{

	public string gameScene;
	public string noJoystickScene;

	private void Start()
	{
		// Does the list of joysticks have anything in it?
		bool isJoystickPresent = (Input.GetJoystickNames().Length > 0);

		if (isJoystickPresent)
		{
			// If we have a joystick, load the game scene:
			SceneManager.LoadScene(gameScene);
		}
		else
		{
			// If we do NOT have a joystick, load the "no joystick" scene:
			SceneManager.LoadScene(noJoystickScene);
		}
	}
}
