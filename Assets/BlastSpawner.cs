using UnityEngine;

public class BlastSpawner : MonoBehaviour
{
    [SerializeField] private GameObject blastPrefab;

    // Spawn a blast object when called
    public void SpawnBlast(GameObject obj)
    {
        Instantiate(blastPrefab, obj.transform.position, Quaternion.identity);
    }
}
