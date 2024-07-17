using UnityEngine;

public class ShipManager : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject,2f); // It references to the object on which the script is attached
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        GamePlayManager.instance.IncrementScore();
    }
}
