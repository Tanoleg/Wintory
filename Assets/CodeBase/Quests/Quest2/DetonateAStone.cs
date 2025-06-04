using Unity.VisualScripting;
using UnityEngine;

public class DetonateAStone : MonoBehaviour
{
    [SerializeField] private GameObject _tnt1;
    [SerializeField] private GameObject _tnt2;
    [SerializeField] private GameObject _Stone;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Interact"))
        {
            if (collision.tag == "Player")
            {
                if (_tnt1.GetComponent<PutTnT>()._isReady == true || _tnt1.GetComponent<PutTnT>()._isReady == true)
                {
                    Destroy(_Stone);
                }
            }
        }
    }
}
