using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Singleton.Instance.InscreaseScore(10);
        GameManager.instance.InscreaseScore(15);
        //Start 함수가 호출될떄 Instance에 접근해서 10점을 추가 한다.
    }

}
