using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public AudioClip crack;
	public Sprite[] hitSprites;
	public static int breakcableCount=0;

	private int timesHit;
	private LevelManager levelManager;
	private bool isBreakable;
	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		//Keep track of breakable bricks
		if (isBreakable) {
			breakcableCount++;	
			print (breakcableCount);
		}
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col) {
		//AudioSource.PlayClipAtPoint (crack, transform.position);
		bool isBreakable = (this.tag == "Breakable");
		if (isBreakable) {
			HandleHits ();	
		}
	}

	void HandleHits(){
		timesHit++ ;
		int maxHits = hitSprites.Length + 1;
		if (timesHit >= maxHits) {
			breakcableCount--;
			print (breakcableCount);
			levelManager.BrickDestroyed();
			Destroy (gameObject);
		} else {
			LoadSprites();
		}
	}

	void LoadSprites() {
		int spriteIndex = timesHit - 1;
		if (hitSprites [spriteIndex]) {
			this.GetComponent<SpriteRenderer> ().sprite = hitSprites [spriteIndex];
		}
	}

	//TODO Remove this method once we can actually win!
	void SimulateWin() {
		levelManager.LoadNextLevel ();
	}
}
