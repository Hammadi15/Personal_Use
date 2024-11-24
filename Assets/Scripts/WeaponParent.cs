using UnityEngine;

public class WeaponParent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is create
    public Vector2 PointerPosition { get; set; }

    private void Update()
    {
        transform.right= (PointerPosition - (Vector2) transform.position).normalized ;
    }
}
