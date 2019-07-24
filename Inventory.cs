using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Inventory : MonoBehaviour 
{
	//public GameObject inventoryPanel;
	public Text Text1;
	public Text Text2;
	public Text Text3;
	
	
	void OnCollisionExit(Collision collision){
		 if(collision.gameObject.tag == "Apple")
		 {
		 	Text1.GetComponent<Text>().text = "Apple";
		 }
		 else if(collision.gameObject.tag == "Sword")
		 {
		 	Text2.GetComponent<Text>().text = "Sword";
		 }  
		 else if(collision.gameObject.tag == "Potion")
		 {
		 	Text3.GetComponent<Text>().text = "Potion";
		 }
	}
}

