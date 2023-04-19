using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KursorsUzAttela : MonoBehaviour {
	public AudioSource kurAtskanot;
	public AudioClip koAtskanot;

	public void uzAttela(){
		kurAtskanot.PlayOneShot (koAtskanot);
	}

	public void noAttela(){
		kurAtskanot.Stop ();
	}
}
