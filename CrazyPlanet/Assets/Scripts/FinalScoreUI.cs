using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Text))]
public class FinalScoreUI : MonoBehaviour {

	void Start ()
	{
		GetComponent<Text>().text = "distance = <i><b>" + Planet.Score.ToString("0.#") + "</b>m</i>";
	}

}
