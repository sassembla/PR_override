using UnityEngine;
using System.Collections;

public class EntryPoint_Scroll : MonoBehaviour {

	/**
		ステージ進行、入力に対するゲーム側の挙動を行う。

		イェーガーのなかの人からのシグナルを受けて、イェーガーの操作、KJの操作、判定を行う。
		・基礎的な進行をAppControllerが制御(stateを持つ)
		・ゲーム進行はこのScrollが持つ
		という原則で動かす。
	*/

	public GameObject scroll;

	void Awake () {
		// scroll = GameObject.
	}
}
