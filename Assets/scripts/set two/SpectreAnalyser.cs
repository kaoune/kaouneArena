using UnityEngine;
using System.Collections;

public class SpectreAnalyser : MonoBehaviour 
{
	public AudioSource audioSource;
	
	public int numSamples;

	public LineRenderer spectrumLine, rawLine;
	
	void Start () 
	{
		spectrumLine.SetVertexCount(numSamples);
		rawLine.SetVertexCount(numSamples);
	}
	
	void Update () 
	{
		float[] spectre = audioSource.GetSpectrumData(numSamples, 0, FFTWindow.BlackmanHarris);
		float[] raw = audioSource.GetOutputData(numSamples, 0);
		for (int i = 0; i < numSamples; i ++)
		{
			spectrumLine.SetPosition(i, new Vector3(i* 0.1f, (spectre[i] * 100f) + 2.0f, 0));
			rawLine.SetPosition(i, new Vector3(i * 0.1f, (raw[i] * 5f) - 2.0f, 0));
		}
	}
}
