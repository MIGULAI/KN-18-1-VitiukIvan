using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_level_1 : MonoBehaviour
{
    private static float Min_x = -1.2f;
    private static float Max_x = 2.9f;

    public float CamPosis;
    private Camera cam;
    public GameObject player;
    void Update()
    {
        if (player.transform.position.x <= Min_x)
        {
            CamPosis = Min_x;
        }
        else if (player.transform.position.x >= Max_x)
        {
            CamPosis = Max_x;
        }
        else
        {
            CamPosis = player.transform.position.x;
        }
        transform.position = new Vector3(CamPosis, 9.25f, -10f);

    }
}
