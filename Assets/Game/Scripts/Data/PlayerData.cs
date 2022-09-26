using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Scripts.Data
{
    public static class PlayerData
    {

        public static int CurrentLevelID
        {
            get => PlayerPrefs.GetInt("CurrentLevelID", 0);

            set 
            {
                PlayerPrefs.SetInt("CurrentLevelID", value);
            }
        }

    }
}
