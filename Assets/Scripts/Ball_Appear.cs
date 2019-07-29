using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Appear : MonoBehaviour
{
    public GameObject player, killer;
    Vector2 dis;
    bool flag = true;
    float NowT, LstT;
    Vector2 expect = new Vector2(10.0f, 0.0f);
    public int forward = 1;
    public float time = 1.0f;
    public float speed = 50.0f;
    void Update()
    {
        //print(forward);
        //print(flag);
        if (flag)
        {
            GameObject tmp = Instantiate(killer, new Vector3(Random.Range(-10.5f, 10.5f), 5.0f, 0), Quaternion.identity);
            Rigidbody2D rb = tmp.GetComponent<Rigidbody2D>();
            rb.gravityScale = 0;
            dis = player.transform.position - tmp.transform.position;
            float div = expect.magnitude / dis.magnitude;
            dis *= div;
            dis += new Vector2(0.0f, Random.Range(-1.0f, 1.0f));
            rb.AddForce(dis*speed);
            flag = false;
            NowT = LstT = Time.fixedTime;
        }
        if (!flag)
        {
            NowT = Time.fixedTime;
            if (NowT - LstT >= time)
                flag = true;
        }
    }
}
