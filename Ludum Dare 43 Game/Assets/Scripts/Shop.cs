using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour {

	public Text Item1;
	public Text Item2;
	public Text Item8;
	[SerializeField]private Guns ItemR1;
	[SerializeField]private Guns ItemR2;
	[SerializeField]private Guns ItemR8;
	[SerializeField]private GameObject gm;
	private Rage rageCS;

	// Use this for initialization
	void Start () {
		if (ItemR1 != null){Item1.text = ItemR1.name + " - " + ItemR1.rageCost;}
		if (ItemR2 != null){Item2.text = ItemR2.name + " - " + ItemR2.rageCost;}
		if (ItemR8 != null){Item8.text = ItemR8.name + " - " + ItemR8.rageCost;}
		
		rageCS = gm.GetComponent<Rage>();
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void OnItem1Press()
	{
		Debug.Log("PRESS!");
		if (rageCS.realRage >= ItemR1.rageCost)
		{
			Debug.Log("IF!");
			rageCS.realRage = rageCS.realRage - ItemR1.rageCost;
			ItemR1.isUnlocked = true;
			Destroy(Item1.transform.parent.transform.parent);
		}
	}
	public void OnItem2Press()
	{
		if (rageCS.realRage >= ItemR2.rageCost)
		{
			rageCS.realRage = rageCS.realRage - ItemR2.rageCost;
			ItemR2.isUnlocked = true;
			Destroy(Item2.transform.parent.transform.parent);
		}
	}
	public void OnItem8Press()
	{
		if (rageCS.realRage >= ItemR8.rageCost)
		{
			rageCS.realRage = rageCS.realRage - ItemR8.rageCost;
			ItemR8.isUnlocked = true;
			Destroy(Item8.transform.parent.transform.parent);
		}
	}
	
}
