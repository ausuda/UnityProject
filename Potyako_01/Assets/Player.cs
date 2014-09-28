using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	SpriteRenderer MainSpriteRenderer;
	// publicで宣言し、inspectorで設定可能にする
	public Sprite StandbySprite;
	public Sprite HoldSprite;
	//public Sprite SlashSprite;

	private int count=0;
	
	void Start ()
	{
		// このobjectのSpriteRendererを取得
		MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// 何かしらのタイミングで呼ばれる
	void Update()
	{

		count++;

		//if (count==10)
		// SpriteRenderのspriteを設定済みの他のspriteに変更
		// 例) HoldSpriteに変更
		MainSpriteRenderer.sprite = HoldSprite;
	}
}