using UnityEngine;
using System.Collections;

/**
	シーンのコントロールを行う、アプリケーションのエントリーポイント。
	各シーンごとの単独起動も可能にしておくとデバッグがラク。
*/
public class AppController : MonoBehaviour {
	
	void Awake () {
		DontDestroyOnLoad (transform.gameObject);

		// load initial game scene-pair.
		{
			// Manipulate
			Application.LoadLevelAdditiveAsync("Manipulate");

			// Scroll
			Application.LoadLevelAdditiveAsync("Scroll");
		}
	}
}
