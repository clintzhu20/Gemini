using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{
    public GameObject Column_prefabs;
    public float time_between_column = 2.0f;

    public float column_spawn_position_left = -4.0f;
    public float column_spawn_position_right = 4.0f;

    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        timer = time_between_column;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0.0f)
        {
            Instantiate(Column_prefabs,new Vector3(Random.Range(column_spawn_position_left, column_spawn_position_right),-20,0), Quaternion.identity);
            timer = time_between_column;

        }
    }
}
