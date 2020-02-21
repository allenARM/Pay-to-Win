using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Data;

public class TimerManager : MonoBehaviour
{
	public GameObject obj;
	public int WaitMinutes;
	System.DateTime currentTime;
	System.DateTime RemaningTime;
	System.TimeSpan tmpSpan;
	TextMeshProUGUI text;

	// Need to add time savings
    // Start is called before the first frame update

	void Awake()
	{
		//RemaningTime load saved time
	}
    void Start()
    {
		obj.active = false;
		text = obj.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
		//gets current time and compare with remaning time
		//count down time if there is time left.
		currentTime = System.DateTime.Now;
		if (RemaningTime.CompareTo(currentTime) == -1)
		{
			gameObject.GetComponent<Button>().interactable = true;
			obj.active = false;
		}
		else
		{
			tmpSpan = RemaningTime - currentTime;
			text.text = "Time Remaning: " + tmpSpan.Minutes.ToString() + ":" + tmpSpan.Seconds.ToString();
		}
		//add RemaningTime saving to the file.
    }

	public void TimerRunner()
	{
		//disables main button and runs timer
		gameObject.GetComponent<Button>().interactable = false;
		obj.active = true;
		RemaningTime = currentTime;
		RemaningTime = RemaningTime.AddMinutes(WaitMinutes);
	}
}
