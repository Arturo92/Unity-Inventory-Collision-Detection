using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryClick : MonoBehaviour
{
	
	public Text Text1;
	public Text Text2;
	public Text Text3;
	
	public void removeItem(){
		StartCoroutine(RemoveItem());
	}
	
	public void removeItem2(){
		StartCoroutine(RemoveItem2());
	}
	
	public void removeItem3(){
		StartCoroutine(RemoveItem3());
	}
	IEnumerator RemoveItem(){
		if(Text1.GetComponent<Text>().text == "Apple"){
			Text1.GetComponent<Text>().text = "";
		}
		
		yield return 0;
	}
	
	IEnumerator RemoveItem2(){
		if(Text2.GetComponent<Text>().text == "Sword"){
			Text2.GetComponent<Text>().text = "";
		}
		
		yield return 0;
	}
	
	IEnumerator RemoveItem3(){
		if(Text3.GetComponent<Text>().text == "Potion"){
			Text3.GetComponent<Text>().text = "";
		}
		
		yield return 0;
	}
    void Start()
    {
		
    }

    void Update()
    {
    
    }
}
