using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 1.0f;


    void Update()
    {
        #region Input.GetKeyDown
        // if (Input.GetKeyDown(KeyCode.W))
        // {    
        //     transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
        //     // == transform.position += new Vector3(0, 0, 1);
        // }
        // 
        // if(Input.GetKeyDown(KeyCode.A))
        // {
        //     transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
        //     // == transform.position += new Vector3(-1, 0, 0);
        // }
        // 
        // if (Input.GetKeyDown(KeyCode.D))
        // {
        //     transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        //     // == transform.position += new Vector3(1, 0, 0);
        // }
        // 
        // if (Input.GetKeyDown(KeyCode.S))
        // {
        //     transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
        //     // == transform.position += new Vector3(0, 0, -1);
        // }
        #endregion

        // Input.GetAxis : 1 ~ -1 ������ ���� ��ȯ�ϴ� �Լ��Դϴ�.
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        // v = v0 + vt
        // Time.deltaTime : �� �������� �Ϸ�Ǳ���� �ɸ� �ð�

        direction.Normalize();

        transform.Translate(direction * speed * Time.deltaTime);
    }
}
