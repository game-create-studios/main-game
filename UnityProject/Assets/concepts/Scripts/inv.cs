using UnityEngine;
using System.Collections;

public class inv : MonoBehaviour {
	//How much owned
	public int morphine = 0; 
	public int medkits = 0;
	public int adren = 0;
	public int bandages = 0;
	//Most can be carried
	public int maxBandages = 3;
	public int maxMedkits = 3;
	public int maxAdren = 3;
	public int maxMorphine = 3;
	//How many of all items can be carried
	public int maxInv = 6;

	public bool isFull()
	{
		if (morphine + medkits + adren + bandages == maxInv)
		{
			return true;
		}
		return false;
	}

}
