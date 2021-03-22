//VRMにて自作したキャラクターが設定した時間毎に表情を変化させるスクリプト
//(今回はキャラクターが寝るイメージのスクリプト）
//float TimeCountは任意で調整
//表情を追加したい場合は

//if(TimeCount <= x ){

//proxy.SetValue("A", 0f);
//proxy.SetValue("B", 1.0f);

//　x＝時間　A＝前回の表情　　B＝今回の表情をそれぞれ挿入すれば稼働出来ます。
//プリセットの表情を使用する際は「"A"」ではなく「BlendShapePreset.Fun」のように「.」の後に表情名をつけたら出来ました。
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;

public class Sleep : MonoBehaviour
{
	private VRMBlendShapeProxy proxy;

	//設定する時間（今回は8秒）
	float TimeCount = 8;

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

			proxy.SetValue(BlendShapePreset.Fun, 1.0f);

			//表情処理終章後にカウント開始
			TimeCount -= Time.deltaTime;

			//2秒経過した場合は変化（今回はJoy→Fun)
			if (TimeCount <= 6)
			{

				proxy.SetValue(BlendShapePreset.Fun, 0f);
				//表情変化
				proxy.SetValue("Sleepy", 1.0f);


			}

			if (TimeCount <= 4)
			{

				proxy.SetValue("Sleepy", 0f);
				//表情変化
				proxy.SetValue("SleepyMore", 1.0f);

			}
			if (TimeCount <= 3)
			{

				proxy.SetValue("SleepyMore", 0f);
				//表情変化
				proxy.SetValue("Sleep", 1.0f);

			}
			if (TimeCount <= 0)
			{

				proxy.SetValue("Sleep", 0f);
				//表情変化
				proxy.SetValue("SleepBaka", 1.0f);

			}


		}
        //今回は自作blendshapeを使用し4段階に分けて行動をしております。



	}
}

