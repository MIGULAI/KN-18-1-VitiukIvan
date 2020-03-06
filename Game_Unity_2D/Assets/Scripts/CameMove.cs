using UnityEngine;

public class CameMove : MonoBehaviour
{
    private static float min_x = -1.2f;
    private static float max_x = 2.9f;

    public float CamPosis;
    private Camera cam;
    public GameObject player;

    void Update()
    {
        if(player.transform.position.x <= min_x)
        {
            CamPosis = min_x;
        } else if(player.transform.position.x >= max_x)
        {
            CamPosis = max_x;
        }
        else
        {
            CamPosis = player.transform.position.x;
        }
        transform.position = new Vector3(CamPosis, 9.25f, -10f);

    }
}
