using UnityEngine;

public class CameMove : MonoBehaviour
{
    public float max_x, max_Y;
    private Camera cam;
    public GameObject player;
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10f);

    }
}
