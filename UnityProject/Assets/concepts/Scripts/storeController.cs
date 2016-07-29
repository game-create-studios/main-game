using UnityEngine;
using System.Collections;

public class storeController : MonoBehaviour {

	public GameObject Player;

	public GameObject[] Weapons;
	public string[] weaponNames;
	public string[] weaponCat;
	private int weaponCount;

	public GameObject[] Meds;
	public string[] medNames;
	private int medCount;

	void giveItem_Med(string MedsName)
	{
		if (Player.GetComponent<inv> ().isFull () == false) {
			if (MedsName == "morphine") {
				Player.GetComponent<inv> ().morphine += 1;
			}
			else if (MedsName == "medkit") {
				Player.GetComponent<inv> ().medkits += 1;
			}
			else if (MedsName == "adren") {
				Player.GetComponent<inv> ().adren += 1;
			}
			else if (MedsName == "bandages") {
				Player.GetComponent<inv> ().bandages += 1;
			}
		}
	}

	public void buyWeapon(string weaponName)
	{
		for (int x = 0; x <= weaponCount - 1; x++) {
			if (weaponNames[x] == weaponName) {
				Debug.Log ("Giving: " + weaponName);
			}
		}
	}
	public void buyMeds(string medName)
	{
		for (int x = 0; x <= medCount - 1; x++) {
			if (medNames[x] == medName) {
				Debug.Log ("Giving: " + medName);
				giveItem_Med (medName);
			}
		}
	}
	void Start(){
		weaponCount = Weapons.Length;
		medCount = Meds.Length;
	}
}
