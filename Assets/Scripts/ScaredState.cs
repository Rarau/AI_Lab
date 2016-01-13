using UnityEngine;

public class ScaredState : State<GhostAI> {
	public void execute(GhostAI ai, StateMachine<GhostAI> fsm) {
		Debug.Log ("Executing Scared State");
		if (ai.Eaten ()) {
			ai.fsm.setState(new GoHomeState());
		}
		else if (!ai.Powered ()) {
			ai.fsm.setState(new ScatterState());
		}
	}
	public void enter (GhostAI ai) {
		Debug.Log ("Entered Scared State");
	}
	public void exit (GhostAI ai) {
		Debug.Log ("Left Scared State");
	}
}