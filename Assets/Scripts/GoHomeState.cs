using UnityEngine;

public class GoHomeState : State<GhostAI> {
	public void execute(GhostAI ai, StateMachine<GhostAI> fsm) {
		Debug.Log ("Executing GoHome State");
		if (ai.GetHome ()) {
			ai.fsm.setState (new ScatterState ());
		}
	}
	public void enter (GhostAI ai) {
		Debug.Log ("Entered GoHome State");
		ai.goHome ();
	}
	public void exit (GhostAI ai) {
		Debug.Log ("Left GoHome State");
		ai.getHome = false;
	}
}