using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour {

	public Text Item1;
	public Text Item2;
	public Text Item3;
	public Text Item4;
	public Text Item5;
	public Text Item6;
	public Text Item7;
	public Text Item8;
	[SerializeField]private Guns ItemR1;
	[SerializeField]private Guns ItemR2;
	[SerializeField]private Guns ItemR3;
	[SerializeField]private Guns ItemR4;
	[SerializeField]private Guns ItemR5;
	[SerializeField]private Guns ItemR6;
	[SerializeField]private Guns ItemR7;
	[SerializeField]private Guns ItemR8;
	[SerializeField]private GameObject gm;
	private Rage rageCS;

	// Use this for initialization
	void Start () {
		if (ItemR1 != null){Item1.text = ItemR1.name + " - " + ItemR1.rageCost;}
		if (ItemR2 != null){Item2.text = ItemR2.name + " - " + ItemR2.rageCost;}
		if (ItemR3 != null){Item3.text = ItemR3.name + " - " + ItemR3.rageCost;}
		if (ItemR4 != null){Item4.text = ItemR4.name + " - " + ItemR4.rageCost;}
		if (ItemR5 != null){Item5.text = ItemR5.name + " - " + ItemR5.rageCost;}
		if (ItemR6 != null){Item6.text = ItemR6.name + " - " + ItemR6.rageCost;}
		if (ItemR7 != null){Item7.text = ItemR7.name + " - " + ItemR7.rageCost;}
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
	public void OnItem3Press()
	{
		if (rageCS.realRage >= ItemR3.rageCost)
		{
			rageCS.realRage = rageCS.realRage - ItemR3.rageCost;
			ItemR3.isUnlocked = true;
			Destroy(Item3.transform.parent.transform.parent);
		}
	}
	public void OnItem4Press()
	{
		if (rageCS.realRage >= ItemR4.rageCost)
		{
			rageCS.realRage = rageCS.realRage - ItemR4.rageCost;
			ItemR4.isUnlocked = true;
			Destroy(Item4.transform.parent.transform.parent);
		}
	}
	public void OnItem5Press()
	{
		if (rageCS.realRage >= ItemR5.rageCost)
		{
			rageCS.realRage = rageCS.realRage - ItemR5.rageCost;
			ItemR5.isUnlocked = true;
			Destroy(Item5.transform.parent.transform.parent);
		}
	}
	public void OnItem6Press()
	{
		if (rageCS.realRage >= ItemR6.rageCost)
		{
			rageCS.realRage = rageCS.realRage - ItemR6.rageCost;
			ItemR6.isUnlocked = true;
			Destroy(Item6.transform.parent.transform.parent);
		}
	}
	public void OnItem7Press()
	{
		if (rageCS.realRage >= ItemR7.rageCost)
		{
			rageCS.realRage = rageCS.realRage - ItemR7.rageCost;
			ItemR7.isUnlocked = true;
			Destroy(Item7.transform.parent.transform.parent);
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
