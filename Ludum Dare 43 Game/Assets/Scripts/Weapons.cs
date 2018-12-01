using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon")]
public class Guns : ScriptableObject {

	public bool isUnlocked;
	public new string name;
	public GameObject bulletPrefab;
	public int rageCost;
	public int amountOfAmmo;
	public int ammoInMag;
	public int dmg;
	public float fireRate;
}
