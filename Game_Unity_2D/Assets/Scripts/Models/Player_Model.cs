using UnityEngine;

public class Player_Model : MonoBehaviour
{
    private static Player_Model _instance;

    public float Speed { get; set; }
    public int JumpImpuls { get; set; }
    public int Heals { get; set; }

    private Player_Model()
    {
        Speed = 30f;
        JumpImpuls = 14000;
        Heals = 100;
    }

    public static Player_Model GetInstance()
    {
        if(_instance == null)
        {
            _instance = new Player_Model();
        }
        return _instance;
    }
}
