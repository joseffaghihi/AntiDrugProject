using UnityEngine;
using System.Collections;

namespace ADAM2
{
    public class TextBox : MonoBehaviour
    {
        void onCollisionEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                GUI.Label(new Rect(10, 10, 50, 50), "DRUGSSSS!");
                Debug.Log("Touching ME");
            }

        }
    }
}//end of namespace