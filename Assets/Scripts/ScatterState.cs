using UnityEngine;

public class ScatterState : State<GhostAI> {
	public void execute(GhostAI ai, StateMachine<GhostAI> fsm) {
		Debug.Log ("Executing Scatter State");
		if (ai.AttackWave ()) {
			ai.fsm.setState(new AttackState());
		}
		else if (ai.Powered ()) {
			ai.fsm.setState(new ScaredState());
		}
	}
	public void enter (GhostAI ai) {
		Debug.Log ("Entered Scatter State");
	}
	public void exit (GhostAI ai) {
		Debug.Log ("Left Scatter State");
	}
}