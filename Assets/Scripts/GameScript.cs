using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    // Set the location of each cell to -1 to mean unplayed/empty
    int spriteIndex = -1;
    int[] locations = { -1, -1, -1, -1, -1, -1, -1, -1, -1};


    public int PlayerTurn()
    {
        spriteIndex++;
        return spriteIndex % 2;
    }

    public void UpdateBoard(int index, int player)
    {
        // Set the cell in the location array to the player number which is X or O (0 or 1)
        locations[index - 1] = player;
        Debug.Log("Hello");
        Debug.Log(index);
        Debug.Log(locations[index - 1]);
    }

    public int CheckWinner(int player)
    {
        if (locations[0] == player && locations[1] == player && locations[2] == player) {
            return 1;
        } else if (locations[3] == player && locations[4] == player && locations[5] == player) {
            return 1;
        } else if (locations[6] == player && locations[7] == player && locations[8] == player) {
            return 1;
        }

        if (locations[0] == player && locations[3] == player && locations[6] == player) {
            return 1;
        } else if (locations[1] == player && locations[4] == player && locations[7] == player) {
            return 1;
        } else if (locations[2] == player && locations[5] == player && locations[8] == player) {
            return 1;
        }

        if (locations[0] == player && locations[4] == player && locations[8] == player) {
            return 1;
        } else if (locations[2] == player && locations[4] == player && locations[6] == player) {
            return 1;
        }
        
        return 0;
    }
}
