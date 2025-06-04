using UnityEngine;

public class PickUpTNT : MonoBehaviour
{
    [SerializeField] private GameObject _tnt;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Interact"))
        {
            if (collision.tag == "Player")
            {
                Moving moving = collision.gameObject.GetComponent<Moving>();
                if (moving._isHandFree == true)
                {
                    moving._isHandFree = false;
                    Destroy(gameObject);
                    _tnt.SetActive(true);
                }
            }
        }
    }
}
