using System.Collections;
using UnityEngine;

public class GuiController_gun : MonoBehaviour {

	public GameObject[] GUIMenus;
	public string[] names;
	private int GUISize;

	bool unactive_all(){
		GUISize = GUIMenus.Length;
		for (int x = 0; x <= GUISize - 1; x++) {
			GUIMenus [x].SetActive (false);
		}
		return true;
	}

	public void Switch_GUI(string name){
		if (unactive_all ()) {
			for (int x = 0; x <= GUISize - 1; x++) {
				if (names [x] == name) {
					GUIMenus[x].SetActive (true);
					break;
				}
			}
		}
	}
}