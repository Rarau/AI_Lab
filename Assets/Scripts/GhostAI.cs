using UnityEngine;
using System.Collections;

public class GhostAI : MonoBehaviour {
	public StateMachine<GhostAI> fsm;

	public GameObject home;

	NavMeshAgent navAgent;

	// Use this for initialization
	void Start () {
		navAgent = GetComponent<NavMeshAgent> ();
		home = GameObject.Find ("Home");

		fsm = new StateMachine<GhostAI> (this);
		fsm.setState (new ScatterState ());
	}
	
	// Update is called once per frame
	void Update () {
		fsm.update ();

		if (Input.GetKeyDown (KeyCode.Space)) {
			StartCoroutine(PowerUpCR());
		}
		if (Input.GetKeyDown (KeyCode.E) && powered) {
			eaten = true;
		}
	}

	IEnumerator PowerUpCR()
	{
		powered = true;
		yield return new WaitForSeconds (2.0f);
		powered = false;
	}

	void reverseDirection()
	{
	}

	public void goHome()
	{
		//StartCoroutine (GoHomeCR ());
		navAgent.SetDestination (home.transform.position);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.name == "Home") {
			getHome = true;
		}
	}

	IEnumerator GoHomeCR()
	{
		yield return new WaitForSeconds (Random.Range (1.0f, 3.0f));
		getHome = true;
	}

	bool attackWave = false;
	public bool AttackWave(){
		return attackWave;
	}

	bool powered = false;
	public bool Powered(){
		return powered;
	}

	
	bool eaten = false;
	public bool Eaten(){
		return eaten;
	}

	public bool getHome = false;
	public bool GetHome() {
		return getHome;
	}
}