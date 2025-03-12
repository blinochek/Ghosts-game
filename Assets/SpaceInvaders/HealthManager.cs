using UnityEngine;
using TMPro; // Обязательно добавьте это, чтобы использовать TextMeshPro

public class HealthDisplay : MonoBehaviour
{
    public Player player; // Ссылка на объект игрока с переменной health
    public TextMeshProUGUI healthText; // Ссылка на объект TextMeshPro Text

    void Update()
    {
        // Проверяем, что ссылки назначены
        if (player != null && healthText != null)
        {

        }
        else
        {
            Debug.LogError("Не назначены ссылки на Player или TextMeshPro Text!");
        }
    }
}
