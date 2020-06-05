using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transitions : MonoBehaviour
{
	public float transitionTime = 2f;

	public Animator anim;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			StartCoroutine(loadNextLevel());
		}
		else if (Input.GetKeyDown(KeyCode.LeftAlt))
		{
			StartCoroutine(loadPreviousLevel());
		}
	}

	private IEnumerator loadNextLevel()
	{
		anim.SetTrigger("end");

		yield return new WaitForSeconds(transitionTime);

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	private IEnumerator loadPreviousLevel()
	{
		anim.SetTrigger("end");

		yield return new WaitForSeconds(transitionTime);

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}
}
