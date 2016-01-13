using UnityEngine;

public class AttackState : State<GhostAI> {
	public void execute(GhostAI ai, StateMachine<GhostAI> fsm) {
		Debug.Log ("Executing Attack State");
		if (ai.Powered ()) {
			ai.fsm.setState(new ScaredState());
		}
		else if (!ai.AttackWave ()) {
			ai.fsm.setState(new ScatterState());
		}
	}
	public void enter (GhostAI ai) {
		Debug.Log ("Entered Attack State");
	}
	public void exit (GhostAI ai) {
		Debug.Log ("Left Attack State");
	}
}