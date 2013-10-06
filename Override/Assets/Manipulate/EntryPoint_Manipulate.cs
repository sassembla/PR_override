using UnityEngine;
using System.Collections;

public class EntryPoint_Manipulate : MonoBehaviour {

	/**
		このシーン(Manipulate)の中で、パイロット側が体験する「イェーガーの中」の動作を行う。
		外部へと操作シグナルを出して、外部からのエフェクトを受ける。
		Kinectでの操作と、Oculus用GUIの表示、+外部へのシグナル送付、外部からのシグナル受信とグラフィック化、が責務になる。

		このシーンでコントロールする大まかなシークエンス
		・AppControllerからのloadを起点にする。
		・ゲームが起動して、まっさきに横の人と動きの同調。これがブレインハンドシェイクだ！
		・外部からのシーケンスを受け取り、ポーズをとり、イェーガーを動かす
		・外部との通信を受け/外部へと通信を行い、KJと戦斗する
	*/
	void Awake () {
		
	}
}
