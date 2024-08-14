using System.Collections;
using System.Collections.Generic;
using UnityEngine; // 유니티 엔진에 있는 기능을 사용합니다.

public class Script1 : MonoBehaviour // MonoBehaviour가 연결되어있다.
                                     // MonoBehaviour는 유니티에서 사용하는 기능들을 모아놓은 클래스
{
    public GameObject Cube;
    public int Count = 0;        // public : 유니티 엔진에서 수정이 가능하고 보인다
    private float value = 2.0f; // private : 유니티 엔진에서 보이지 않는다.
    // 일반 C#은 Main 함수를 통해 실행
    // 유니티 스크립트는 라이프 사이클에 의해 정해진 위치에 코드를 설계 및 엔진 실행

    // Start is called before the first frame update
    // 프레임 시작 시 호출되는 함수
    void Start()
    {
        Debug.Log("첫 프레임에 Start를 시작하겠습니다.");
    }

    // Update is called once per frame
    // 실질적인 동작 등을 구현해야하는 위치 계속 반복
    void Update()
    {
        Debug.Log(Count++);
    }
}
