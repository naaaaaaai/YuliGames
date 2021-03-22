using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;

public class FaceKeep : MonoBehaviour
{
	private VRMBlendShapeProxy proxy;

	//3秒後に表情を戻す(別の表情にする)
	float TimeCount = 4;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{


		if (proxy == null)
		{
			proxy = GetComponent<VRMBlendShapeProxy>();
		}
		else
		{

			proxy.SetValue(BlendShapePreset.Joy, 1.0f);

			//表情処理終章後にカウント開始
			TimeCount -= Time.deltaTime;
            if(TimeCount <=2){

				proxy.SetValue(BlendShapePreset.Joy, 0f);
				//表情変化
				proxy.SetValue(BlendShapePreset.Fun, 1.0f);


            }
			//カウントが0になったら=この場合は3秒経ったら
			if (TimeCount <= 0)
			{

				proxy.SetValue(BlendShapePreset.Fun, 0f);
				//表情変化
				proxy.SetValue(BlendShapePreset.Sorrow, 1.0f);

			}



		}




	}
}