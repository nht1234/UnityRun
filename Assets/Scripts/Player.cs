using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float Speed = 5f;//캐릭터 이동속도
    public float JumpPower = 100;
    bool isJump = false;

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
        if (transform.position.y < 0.001f)
        {
            isJump = false;

            GetComponent<Animator>().SetBool("Jump", false);
        }
        if (Input.GetMouseButtonDown(0) && !isJump)
        {
            GetComponent<Rigidbody>().AddForce(0, JumpPower, 0);
            isJump = true;

            GetComponent<Animator>().SetBool("Jump", true);
        }

    }

    // 오브젝트가 충돌하면, 유니티에서 자동으로 호출되는 함수
    private void OnCollisionEnter(Collision collision)
    {
        //만약, 충돌한 오브젝트의 태그가 Block 이면
        if (collision.transform.tag == "Block")
        {
            // 게임 오버를 처리한다.
            SceneManager.LoadScene(0);
        }
    }
}
