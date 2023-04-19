using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtuluGenerators : MonoBehaviour {
	public GameObject[] virtuluSagataves;
	public float laikaIntervals = 1.0f;
	float minPoz, maxPoz;
	Transform krasnsTransform;

	void Start ()
	{
		krasnsTransform = GetComponent<Transform>();

	}

	public void sagatavotVirtulus(bool stavoklis)
	{
		if (stavoklis)
			StartCoroutine(Generet());
		else
			StopAllCoroutines();
	}
	IEnumerator Generet()
	{
		while (true)
		{
			minPoz=krasnsTransform.position.x-20;
            maxPoz = krasnsTransform.position.x + 20;
			var cip=Random.Range(minPoz, maxPoz);
			var pozicija = new Vector3(cip, transform.position.y);
			GameObject virtulis = Instantiate(virtuluSagataves[Random.Range(0,virtuluSagataves.Length)], pozicija, Quaternion.identity, krasnsTransform);
            yield return new WaitForSeconds(laikaIntervals);
		}
	}
}
