using UnityEngine;

public class HealtPoints : MonoBehaviour
{
    [Tooltip("The amount of health points this object has")]
    [SerializeField] private int Max_healthPoints = 3;
    private int healthPoints;

    private void Start()
    {
        healthPoints = Max_healthPoints;
    }

    public int HealthPoints
    {
        get => healthPoints;
        set => healthPoints = value;
    }

    public void TakeDamage(int damage)
    {
        healthPoints -= damage;
        Debug.Log($"{gameObject.name} took {damage} damage. Remaining health: {healthPoints}");
        if (healthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Heal(int heal)
    {
        if (healthPoints < Max_healthPoints)
        {
            healthPoints += heal;
            Debug.Log($"{gameObject.name} healed {heal} points. Remaining health: {healthPoints}");
        }
    }
}
