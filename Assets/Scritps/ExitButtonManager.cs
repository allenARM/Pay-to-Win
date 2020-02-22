using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButtonManager : MonoBehaviour
{
	public GameObject exitButton;
	public GameObject adbutton;
	public GameObject popoutUI;
	float waitTime = 5;	
    // Start is called before the first frame update
    void Start()
    {
		// gamemanager
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void ButtonRun()
	{
		popoutUI.GetComponent<Animator>().SetTrigger("Exit");
		StartCoroutine(delay());
	}

	IEnumerator delay()
	{
		yield return new WaitForSeconds(1f);
		popoutUI.SetActive(false);
		// if (gamepurchased dont show ad)
			yield return new WaitForSeconds(waitTime);
			adbutton.GetComponent<RewardedAdsButton>().ShowRewardedVideo();
	}
}
