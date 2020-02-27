using UnityEngine;

public class Player_Model : MonoBehaviour
{
    public class Model
    {
        public static string Name { get; set; }
        public static float Spead { get; set; }
        public static int Damage { get; set; }

        public Model()
        {
            Name = "player";
            Spead = 20f;
            Damage = 0;
        }
    }
}
