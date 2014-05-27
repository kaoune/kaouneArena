using UnityEngine;
using System.Collections;

public class animation_time : MonoBehaviour {

	public float hSliderValue = 1.0F;
	public float hSliderValueBis = 1.0F;
	public float hSliderValueTers = 1.0F;
	
	public GameObject trans;
	public GameObject rota;
	public ParticleSystem kaoune;
	
    void OnGUI() {
	
        hSliderValue = GUI.HorizontalSlider(new Rect(0, 0, 100, 30), hSliderValue, 0.0F, 1.0F);
		
		hSliderValueBis = GUI.HorizontalSlider(new Rect(0, 30, 100, 30), hSliderValueBis, 0.0F, 1.0F);
		
		hSliderValueTers = GUI.HorizontalSlider(new Rect(0, 60, 100, 30), hSliderValueTers, 0.0f, 1.0f);
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

				trans.animation["translations"].speed = hSliderValueBis;
				rota.animation["rotations"].speed = hSliderValue;
				Time.timeScale = hSliderValueTers;
	}
}
