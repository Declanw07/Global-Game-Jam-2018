//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;
//
//public class Cabin : MonoBehaviour {
//
//	int days = 0;
//	bool finished = false;
//	public AudioClip myaudio1;
//	public AudioClip myaudio2;
//	public AudioClip myaudio3;
//	public GameObject record;
//	public GameObject mic;
//	public GameObject bed;
//	bool dayEnd = false;
//	int heat = 50;
//	int influence;
//	int favour;
//	int dayTurn = 0;
//	public GameObject[] shipSprite;
//	Ray ray;
//	RaycastHit2D hit;
//	public int musicArraySize;
//	public int propagandaArraySize;
//	public AudioClip[] song;
//	public AudioClip[] propaganda;
//
//	// Use this for initialization
//	void Start () 
//	{
//		DayCycle ();
//	}
//	
//	// Update is called once per frame
//	void Update () 
//	{
//		if (days > 30)
//			finished = true;
//		if (finished == true)
//		{
//			//load end scene
//			SceneManager.LoadScene(null);
//			//save score data to file
//		}
//
//		if (heat <= 50)
//		{
//			shipSprite[null].gameObject.SetActive(false);
//		}
//		if (heat >50 && heat <=75)
//		{
//			shipSprite[0].gameObject.SetActive(true);
//		}
//		if (heat >75 && heat <=90)
//		{
//			shipSprite[1].gameObject.SetActive(true);
//		}
//		if (heat >90 && heat <=100)
//		{
//			shipSprite[2].gameObject.SetActive(true);
//		}
//
//		if (dayEnd == true)
//		{
//			dayEnd = false;
//			days++;
//			DayCycle ();
//		}
//	}
//
//	public void DayCycle ()
//	{
//		AudioSource audio = GetComponent<AudioSource> ();
//
//		if (dayTurn < 3)
//			dayTurn++;
//		if (dayTurn >= 3)
//		{
//			dayTurn = 0;
//			dayEnd = true;
//		}
//
//		GameObject x = GameObject.FindGameObjectWithTag ("CityInFocus");
//		//influence = x.GetComponent<scriptname> (influence);
//		//favour = x.GetComponent<scriptname> (favour);
//		// alternativley can write/read these values from a file once the map script is done
//
//		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
//		bool redundant1 = false;
//		bool redundant2 = false;
//		bool redundant3 = false;
//
//		if (Physics2D.Raycast (ray, out hit) == record && redundant1 == false)
//		{
//			audio.Play (myaudio1);
//			redundant1 = true;
//		}
//		if (Physics2D.Raycast (ray, out hit) == mic && redundant2 == false)
//		{
//			audio.Play (myaudio2);
//			redundant2 = true;
//		}
//		if (Physics2D.Raycast (ray, out hit) == bed && redundant3 == false)
//		{
//			audio.Play (myaudio3);
//			redundant3 = true;
//		}
//
//		if (Input.GetMouseButtonDown (0))
//		{
//			if (Physics2D.Raycast (ray, out hit) == record)
//			{
//				//int i = Random.Range(0,
//			}
//		}
//	}
//
//
//}
