using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TurnScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer; // Sprite renderer class
    GameObject gameBoard;          // GameObject class

    GameObject canvas;             // GameObject class for canvas
    public Sprite[] images;        // Array of images available in sprite
    bool unplayed = true;          // Bool to determine if the cell has been played already or not


    private void Start()
    {
        spriteRenderer.sprite = null; // Set the sprite shown to be nothing when starting the game
    }

    private void OnMouseDown()
    {
        if (unplayed)
        {
            // Determines if the player is X or O
            int winner = gameBoard.GetComponent<GameScript>().CheckWinner(0);

            if (winner == 0) {
                winner = gameBoard.GetComponent<GameScript>().CheckWinner(1);
            }

            if (winner == 0) {
                int index = gameBoard.GetComponent<GameScript>().PlayerTurn();

                // Renders the X or O sprite depending on index
                spriteRenderer.sprite = images[index];

                // Set the sprite as played so same space can't be chosen again
                unplayed = false;

                // Get the name string and parse to find location of the sprite on the board
                Debug.Log(name);
                string [] subStrings = name.Split('n');
                Debug.Log(subStrings[1]);

                // Convert the string number into an int number
                int number;
                Int32.TryParse(subStrings[1], out number);

                // Call the UpdateBoard function to update the 1-D array
                gameBoard.GetComponent<GameScript>().UpdateBoard(number, index);

                // Call the CheckWinner function to see if the current player won
                winner = gameBoard.GetComponent<GameScript>().CheckWinner(index);

                if (winner == 1) {
                    canvas.GetComponent<TextScript>().DisplayWinner(index);
                }
            }
            
        }
        
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Grab the SpriteRenderer Component of the token attached to this script
        gameBoard = GameObject.Find("GameBoard");        // Grab the game object called GameBoard and all its functions associated with the script attached to it
        canvas = GameObject.Find("Canvas");
    }

    
}
