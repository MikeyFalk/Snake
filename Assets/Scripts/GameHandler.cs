﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private Snake snake;
    
    private LevelGrid levelGrid;
    
    private void Start()
    {
        Debug.Log("GameHandler.Start");

        levelGrid = new LevelGrid(20, 20);

        snake.Setup(levelGrid);
        levelGrid.Setup(snake);


        GameObject snakeHeadGameObject = new GameObject();
        SpriteRenderer snakeSpriteRenderer = snakeHeadGameObject.AddComponent<SpriteRenderer>();
        snakeSpriteRenderer.sprite = GameAssets.i.snakeHeadSprite;

       /* int number = 0;
        FunctionPeriodic.Create(() =>
        {          
            CMDebug.TextPopupMouse("Ding " + number);
            number ++;
        }, 
        .3f);
       */
    }

}
