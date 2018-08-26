using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class post_connection : MonoBehaviour {


	// 아래 함수는 코루틴이라는 방식으로 사용됩니다.
	IEnumerator PostNetworkingWithWWW()
	{
		WWWForm form = new WWWForm();
		// form.AddField("필드 이름", "필드 내용");

		// 아래 코드의 쌍따옴표 안에 URL 주소를 넣으시면 됩니다.
		WWW www = new WWW("18.221.175.171", form);
		yield return www;
		// 아래 result 변수에 URL에서 반환해주는 값이 들어가게 됩니다.
		string result = www.text;

		// Debug.Log 함수는 유니티의 콘솔 창에서 무슨 값이 들어있는지 볼 수 있게 해줍니다.
		Debug.Log(result);
	}

	// Use this for initialization
	void Start () {
		// 저는 지금 Store 씬의 background에 코드를 넣어놨습니다.
		// 그렇기 때문에 스토어 씬이 시작할 때 위 함수를 한 번 실행할 수 있게 Start 함수에 넣어 놨습니다.

		// 만약 QR 씬이나 Store_Search 씬에서 통신을 하실려면 각 씬에 이 스크립트를 적용 후,
		// 특정 행동 (QR 인식 시, 상점 선택 시) 후에 아래 함수를 실행하고 씬 이동을 하시면 됩니다.

		StartCoroutine("PostNetworkingWithWWW");

		// JSON 파싱을 통해 원하는 정보를 프리팹을 이용하여 저장하는 코드도 적어 놓겠습니다.

		// '키 값' 이라는 이름의 프리팹을 '밸류 값'이라는 값으로 저장합니다. (씬을 이동해도 적용됨) (같은 키 값으로 사용할 시 overwrite) 
		// PlayerPrefs.SetString("키 값", "밸류 값");

		// '키 값' 이라는 이름의 프리팹을 찾아 그에 해당하는 값을 반환합니다. '밸류 값'이 되겠죠?
		// PlayerPrefs.GetString("키 값");
	}
	
	// Update is called once per frame
	void Update () {
	}
}
