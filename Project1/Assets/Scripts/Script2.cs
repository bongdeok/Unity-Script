using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script2 : MonoBehaviour
{
    public Text Player_ID;
    public Text Player_Level;
    public Text Player_Exp;

   [Range(1,99)] public int Level;
   [Range(0.0f,100.0f)] public float Exp;
    public string ID;
    //유니티 인스펙터에서 1~99 사이의 범위를 선택가능 -> 휠 바 이용
   
    // Start is called before the first frame update
    void Start()
    {
        Player_ID.text = ID;
        Player_Level.text = Level.ToString();
        Player_Exp.text = Exp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
