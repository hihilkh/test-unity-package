using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test.MyPackage
{
    public class Test : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Print()
        {
            Debug.LogError("I am Testing.");
        }

        internal void Print2()
        {
            Debug.LogError("I am Testing 2.");
        }
    }
}