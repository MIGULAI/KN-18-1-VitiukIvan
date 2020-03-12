using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary
{
    class PlayerModel
    {
        private static PlayerModel _instance;

        public float Speed { get; set; }
        public int JumpImpuls { get; set; }
        public int Heals { get; set; }

        private PlayerModel()
        {
            Speed = 30f;
            JumpImpuls = 10000;
            Heals = 100;
        }

        public static PlayerModel GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PlayerModel();
            }
            return _instance;
        }
    }
}
