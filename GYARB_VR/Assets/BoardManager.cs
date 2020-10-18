using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    private const float tileSize = 1.0f;
    private const float tileOffset = 0.5f;

    private int selectionX = -1;
    private int selectionY = -1;

    private void Update()
    {
         UpdateSelection();
        DrawChessBoard();
       
    }

    private void UpdateSelection()
    {
        if (!Camera.main)
        return;

        
    }

    private void DrawChessBoard()
    {
        Vector3 widthLine = Vector3.right * 7;
        Vector3 heightLine = Vector3.forward * 8;

        for (int i = 0; i <= 8; i++)
        {
            Vector3 start = Vector3.forward * i;
            Debug.DrawLine (start, start + widthLine);
            for (int j = 0; j <= 8; j++)
            {
             start = Vector3.right * j;
            Debug.DrawLine (start, start + heightLine);
            }
        }
    }
}
