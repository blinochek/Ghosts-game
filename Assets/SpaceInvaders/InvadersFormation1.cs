using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersFormation1 : MonoBehaviour
{
    [SerializeField] private Shield shieldPrefab; // ссылка на префаб
    [SerializeField] private int col = 8;
    [SerializeField] private int row = 5;
    [SerializeField] private float gap = 1.5f;
  

    [SerializeField] private List<Shield> invaders = new List<Shield>();


    [SerializeField] private float heightOffset = 2f;
    [SerializeField] private float downStep = 10f;



    private bool _formationHasReachBorder;
    private float _startAmount;
    
 
    
    private void Start()
    {

        Vector3 invaderScale = shieldPrefab.transform.localScale; 
        float xOffset = invaderScale.x * (col-1) * gap / 2;
        float yOffset = invaderScale.y * (row-1) * gap / 2 - heightOffset;

        for(int y = row; y > 0; y--)
        {
            for(int x = 0; x < col; x++)
            {
                Vector3 spawnPosition = new Vector3(x * gap - xOffset, y * gap - yOffset, 0) + new Vector3(0, -5, 0);
                Shield shield = Instantiate(shieldPrefab, spawnPosition, Quaternion.identity);
                invaders.Add(shield); // добавляем в лист
            }
        
    
    
}

}

}