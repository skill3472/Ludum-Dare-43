using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapons")]
public class Weapons : MonoBehaviour {

	public new string name;

	public int rageCost;
	public int amountOfAmmo;
	public int ammoInMag;
	public int dmg;
}
