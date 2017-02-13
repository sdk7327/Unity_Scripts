using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public SpriteRenderer[] buttons;

	private int buttonSelect;

	public float stayLit;
	private float stayLitCounter;

	// Use this for initialization
	public void Start () {
	
		buttonSelect = Random.Range(0, buttons.Length);

		buttons[buttonSelect].color = new Color(buttons[buttonSelect].color.r, buttons[buttonSelect].color.g, buttons[buttonSelect].color.b, 1f);

		stayLitCounter = stayLit;
	}
	
	// Update is called once per frame
	void Update () {
		if (stayLitCounter > 0) {
			stayLitCounter -= Time.deltaTime;

		} else {
			buttons [buttonSelect].color = new Color (buttons [buttonSelect].color.r, buttons [buttonSelect].color.g, buttons [buttonSelect].color.b, 0.5f);
		}
	}
}
