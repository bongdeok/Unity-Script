using System.Collections;
using System.Collections.Generic;
using UnityEngine; // ����Ƽ ������ �ִ� ����� ����մϴ�.

public class Script1 : MonoBehaviour // MonoBehaviour�� ����Ǿ��ִ�.
                                     // MonoBehaviour�� ����Ƽ���� ����ϴ� ��ɵ��� ��Ƴ��� Ŭ����
{
    public GameObject Cube;
    public int Count = 0;        // public : ����Ƽ �������� ������ �����ϰ� ���δ�
    private float value = 2.0f; // private : ����Ƽ �������� ������ �ʴ´�.
    // �Ϲ� C#�� Main �Լ��� ���� ����
    // ����Ƽ ��ũ��Ʈ�� ������ ����Ŭ�� ���� ������ ��ġ�� �ڵ带 ���� �� ���� ����

    // Start is called before the first frame update
    // ������ ���� �� ȣ��Ǵ� �Լ�
    void Start()
    {
        Debug.Log("ù �����ӿ� Start�� �����ϰڽ��ϴ�.");
    }

    // Update is called once per frame
    // �������� ���� ���� �����ؾ��ϴ� ��ġ ��� �ݺ�
    void Update()
    {
        Debug.Log(Count++);
    }
}
