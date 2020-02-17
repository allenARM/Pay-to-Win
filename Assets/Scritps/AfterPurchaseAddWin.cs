using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AfterPurchaseAddWin : MonoBehaviour
{
	TextMeshProUGUI text;
	int temp; 
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

	public void PurchaseMade()
	{
		temp = int.Parse(text.text);
		temp++;
		text.text = temp.ToString();
	}
}
