using System;
using UnityEngine;
using System.Collections.Generic;
using Random = UnityEngine.Random;

namespace ClassLibrary1
{
    
    public class GenerateWold : MonoBehaviour
    {
        public GameObject[] platforms;

        private void Start()
        {
            Vector3 pos = new Vector3(0,0,0);
            for (int i = 0;i < 20;i++)
            {
                int platformNumber = Random.Range(0, platforms.Length);
                Instantiate(platforms[platformNumber], pos, Quaternion.identity);
                pos.z += 10; //interval z position
            }
        }

        
    }
}