using UnityEngine;

public class PutTnT : MonoBehaviour
{
    [SerializeField] private GameObject _tnt;
    public bool _isReady = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Interact"))
        {
            if (collision.tag == "Player")
            {
                Moving moving = collision.gameObject.GetComponent<Moving>();
                if (moving._isHandFree == false)
                {
                    moving._isHandFree = true;
                    gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f, 255);
                    _tnt.SetActive(false);
                    _isReady = true;
                }
            }
        }
    }
}
