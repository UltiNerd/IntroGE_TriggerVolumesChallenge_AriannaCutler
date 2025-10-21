using UnityEngine;

public class TriggerSetActive2 : MonoBehaviour
{
    public GameObject Trigger2;

    void OnTriggerEnter(Collider other)
    {
        Trigger2.SetActive(true);

    }

    void OnTriggerExit(Collider other)
    {
       Trigger2.SetActive(false);
    }
}
