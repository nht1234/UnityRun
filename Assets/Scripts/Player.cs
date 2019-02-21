using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 5f;//캐릭터 이동속도

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Speed  * Time.deltaTime);//transform.Translate() 오브젝트를 이동시키는 함수
                                                           //인자: Vector3(x, y, z)
                                                           //Speed * Time.deltaTime 60프레임일때, 1프레임 이동거리
                                                           //= 초속 5m * (1/60)
        
    }
}
