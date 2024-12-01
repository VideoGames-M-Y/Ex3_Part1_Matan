using UnityEngine;

public class CollideTeleport : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the teleportation of this object to the other side of the screen")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            if (transform.position.x > 0) {
                other.transform.position = new Vector3(-transform.position.x + other.GetComponent<SpriteRenderer>().bounds.size.x/2, other.transform.position.y, other.transform.position.z);
            } else {
                other.transform.position = new Vector3(-transform.position.x - other.GetComponent<SpriteRenderer>().bounds.size.x/2, other.transform.position.y, other.transform.position.z);
            }
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}
