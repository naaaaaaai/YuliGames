using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;

public class FaceChange : MonoBehaviour
{

	private VRMBlendShapeProxy proxy;

    
    

	// Use this for initialization
	void Start()
	{
        proxy = this.GetComponent<VRMBlendShapeProxy>();
	}

	// Update is called once per frame
	void Update()
	{


		if (proxy == null)
		{
            Debug.Log("null");
			proxy = GetComponent<VRMBlendShapeProxy>();
		}
		else
		{

			//キーボード入力
			if (Input.GetKey(KeyCode.D))
			{
                Debug.Log("yuri");
				//表情呼び出し
				proxy.SetValue(BlendShapePreset.Joy, 1.0f);
				//proxy.SetValue(BlendShapePreset.Extra, 1.0f);

			}
			else
			{

				proxy.SetValue("Neutral", 0f);
			}

			if (Input.GetKey(KeyCode.DownArrow))
			{
				proxy.SetValue("Fun", 1.0f);

			}
			else
			{
				proxy.SetValue("Fun", 0f);
			}

			if (Input.GetKey(KeyCode.RightArrow))
			{
				proxy.SetValue("Joy", 1.0f);
			}
			else
			{
				proxy.SetValue("Joy", 0f);
			}

			if (Input.GetKey(KeyCode.LeftArrow))
			{
				proxy.SetValue("Sorrow", 1.0f);
			}
			else
			{
				proxy.SetValue("Sorrow", 0f);
			}

		}



	}
}