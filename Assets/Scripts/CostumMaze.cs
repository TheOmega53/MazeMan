using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumMaze : MonoBehaviour
{
    private bool[] walls = new bool[4];
    //private int[] doorAttr = new int[3]; 
    private List<IntVector2> EnemyCoordinates = new List<IntVector2>();
    private List<IntVector2> KeyCoordinates = new List<IntVector2>();
    private List<int[]> DoorCoordinates = new List<int[]>();

    public bool[] getCell(IntVector2 coordinates)
    {

        switch (coordinates.z)
        {
            case 29 :
                switch (coordinates.x) {
                    case 0:
                        walls[0] = true;
                        walls[1] = false;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 1:
                    case 2:
                    case 6:
                    case 7:
                    case 9:
                    case 11:
                    case 14:
                    case 15:
                    case 17:
                        walls[0] = true;
                        walls[1] = false;
                        walls[2] = true;
                        walls[3] = false;
                        break;

                    case 3:
                    case 5:
                    case 10:
                    case 16:
                        walls[0] = true;
                        walls[1] = false;
                        walls[2] = false;
                        walls[3] = false;
                        break;

                    case 4:
                    case 12:
                        walls[0] = true;
                        walls[1] = true;
                        walls[2] = true;
                        walls[3] = false;
                        break;

                    case 8:
                    case 13:
                    case 18:
                        walls[0] = true;
                        walls[1] = true;
                        walls[2] = false;
                        walls[3] = false;
                        break;
                }
                break;

            case 28:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                    {
                    case 0:                        
                        walls[1] = true;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 1:
                    case 4:
                    case 5:
                    case 6:
                    case 8:
                    case 12:
                    case 13:
                    case 14:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 2:
                    case 3:
                    case 7:
                    case 9:
                    case 10:
                    case 15:
                    case 16:
                    case 17:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 11:
                        walls[1] = false;
                        walls[2] = false;
                        break;


                }
                break;

            case 27:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = false;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 1:
                    case 6:
                    case 8:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 2:
                    case 4:
                    case 10:
                    case 11:
                    case 14:
                    case 17:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 3:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 5:
                    case 7:
                    case 9:
                    case 12:
                    case 13:
                    case 15:
                    case 16:
                        walls[1] = false;
                        walls[2] = false;
                        break;

                }
                break;

            case 26:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = true;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 1:
                    case 2:
                    case 4:
                    case 7:
                    case 10:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 3:
                    case 5:
                    case 6:
                    case 8:
                    case 9:
                    case 11:
                    case 14:
                    case 15:
                    case 16:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 12:
                    case 13:
                        walls[1] = false;
                        walls[2] = false;
                        break;

                    case 17:
                        walls[1] = true;
                        walls[2] = true;
                        break;
                }
                break;

            case 25:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = false;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 1:
                    case 6:
                    case 9:
                    case 12:
                    case 13:
                    case 14:
                    case 16:
                    case 17:
                    
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 2:
                    case 4:
                    case 15:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 3:
                        walls[1] = false;
                        walls[2] = false;
                        break;

                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 11:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;
                }
                break;

            case 24:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = true;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 1:
                    case 2:
                    case 5:
                    case 7:
                    case 12:
                    case 14:
                    case 16:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 3:
                    case 6:
                    case 10:
                    case 17:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 4:
                    case 8:
                    case 11:
                    case 13:
                    case 15:
                        walls[1] = false;
                        walls[2] = false;
                        break;

                    case 9:
                        walls[1] = true;
                        walls[2] = true;
                        break;
                }
                break;

            case 23:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = false;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 1:
                    case 6:
                    case 9:
                    case 12:
                    case 14:
                        walls[1] = false;
                        walls[2] = false;
                        break;

                    case 2:
                    case 3:
                    case 5:
                    case 8:
                    case 16:
                    case 17:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 4:
                        walls[1] = false;
                        walls[2] = true;
                        break;
                    
                    case 7:
                    case 10:
                    case 11:
                    case 13:
                    case 15:
                        walls[1] = true;
                        walls[2] = true;
                        break;
                }
                break;

            case 22:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = false;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 1:
                    case 3:
                    case 7:
                    case 8:
                        walls[1] = false;
                        walls[2] = false;
                        break;

                    case 2:
                    case 5:
                    case 12:
                    case 14:
                    case 16:
                    case 17:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 6:
                    case 10:
                    case 11:
                    case 13:
                    case 15:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 4:
                    case 9:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                }
                break;

            case 21:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = false;
                        walls[2] = true;
                        walls[3] = true;
                        break;

                    case 1:
                    case 4:
                    case 5:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 2:
                    case 8:
                    case 13:
                    case 15:
                    case 18:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 3:
                    case 6:
                    case 7:
                    case 16:
                    case 17:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 9:
                    case 10:
                    case 11:
                    case 12:
                    case 14:
                        walls[1] = false;
                        walls[2] = false;
                        break;



                }
                break;

            case 20:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = false;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 13:
                    case 16:
                    case 17:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 5:
                    case 11:
                    case 12:
                    case 14:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 6:
                    case 8:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 7:
                    case 9:
                    case 10:
                    case 15:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 19:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = false;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 1:
                    case 2:
                    case 3:
                    case 5:
                    case 6:
                    case 9:
                    case 10:
                    case 12:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 4:
                    case 7:
                    case 8:
                    case 15:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 11:
                    case 14:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 13:
                    case 16:
                    case 17:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 18:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = true;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 5:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 3:
                    case 7:
                    case 15:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 6:
                    case 13:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 1:
                    case 2:
                    case 4:
                    case 12:
                    case 14:
                    case 16:
                    case 17:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 17:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = true;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 13:
                    case 16:
                    case 17:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 4:
                    case 9:
                    case 12:
                    case 14:
                    case 15:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 18:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 1:
                    case 2:
                    case 3:
                    case 10:
                    case 11:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 16:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = true;
                        walls[2] = true;
                        walls[3] = true;
                        break;

                    case 1:
                    case 2:
                    case 4:
                    case 6:
                    case 7:
                    case 12:
                    case 17:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 8:
                    case 11:
                    case 13:
                    case 15:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 3:
                    case 5:
                    case 10:
                    case 14:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 9:
                    case 16:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 15:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = false;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 3:
                    case 6:
                    case 11:
                    case 13:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 4:
                    case 7:
                    case 8:
                    case 12:
                    case 14:
                    case 16:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 1:
                    case 9:
                    case 15:
                    case 18:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 2:
                    case 5:
                    case 10:
                    case 17:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 14:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = true;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 1:
                    case 9:
                    case 12:
                    case 14:
                    case 15:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 4:
                    case 5:
                    case 6:
                    case 11:
                    case 13:
                    case 17:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 3:
                    case 7:
                    case 10:
                    case 16:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 2:
                    case 8:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 13:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = false;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 3:
                    case 10:
                    case 11:
                    case 13:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 2:
                    case 4:
                    case 5:
                    case 12:
                    case 14:
                    case 15:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 1:
                    case 8:
                    case 17:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 6:
                    case 7:
                    case 9:
                    case 16:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 12:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = true;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 2:
                    case 8:
                    case 17:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 3:
                    case 4:
                    case 5:
                    case 7:
                    case 9:
                    case 10:
                    case 13:
                    case 14:
                    case 15:
                    case 16:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 6:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 1:
                    case 11:
                    case 12:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 11:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = true;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 6:
                    case 7:
                    case 16:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 2:
                    case 4:
                    case 8:
                    case 9:
                    case 10:
                    case 13:
                    case 14:
                    case 15:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 1:
                    case 3:
                    case 17:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 5:
                    case 11:
                    case 12:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 10:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = false;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 1:
                    case 3:
                    case 11:
                    case 12:
                    case 15:
                    case 17:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 4:
                    case 8:
                    case 9:
                    case 10:
                    case 14:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 5:
                    case 7:
                    case 13:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 2:
                    case 6:
                    case 16:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 9:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = false;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 3:
                    case 4:
                    case 5:
                    case 8:
                    case 9:
                    case 10:
                    case 12:
                    case 14:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 2:
                    case 6:
                    case 15:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 1:
                    case 17:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 7:
                    case 11:
                    case 13:
                    case 16:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 8:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = true;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 2:
                    case 3:
                    case 4:
                    case 8:
                    case 17:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 5:
                    case 6:
                    case 7:
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 16:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 10:
                    case 15:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 1:
                    case 9:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 7:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = true;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 7:
                    case 15:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 4:
                    case 5:
                    case 6:
                    case 8:
                    case 9:
                    case 11:
                    case 12:
                    case 17:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 1:
                    case 13:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 2:
                    case 3:
                    case 10:
                    case 14:
                    case 16:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 6:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = false;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 1:
                    case 13:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 4:
                    case 5:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                    case 15:
                    case 17:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 7:
                    case 14:
                    case 16:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 2:
                    case 3:
                    case 6:
                    case 12:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 5:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = true;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 2:
                    case 3:
                    case 14:
                    case 15:
                    case 16:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 1:
                    case 5:
                    case 6:
                    case 9:
                    case 10:
                    case 12:
                    case 17:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 4:
                    case 8:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 7:
                    case 11:
                    case 13:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 4:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = true;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 2:
                    case 4:
                    case 8:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 6:
                    case 7:
                    case 9:
                    case 11:
                    case 12:
                    case 13:
                    case 16:
                    case 17:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 5:
                    case 10:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 1:
                    case 3:
                    case 14:
                    case 15:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 3:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = true;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 5:
                    case 8:
                    case 10:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 1:
                    case 2:
                    case 3:
                    case 11:
                    case 12:
                    case 13:
                    case 16:
                    case 17:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 6:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 4:
                    case 7:
                    case 9:
                    case 14:
                    case 15:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 2:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = true;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 6:
                    case 8:
                    case 15:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 1:
                    case 2:
                    case 3:
                    case 7:
                    case 9:
                    case 10:
                    case 12:
                    case 13:
                    case 17:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 4:
                    case 11:
                    case 16:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                    case 5:
                    case 14:
                        walls[1] = false;
                        walls[2] = false;
                        break;
                }
                break;

            case 1:
                walls[0] = false;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[1] = true;
                        walls[2] = false;
                        walls[3] = true;
                        break;

                    case 3:
                    case 4:
                    case 7:
                    case 10:
                    case 11:
                    case 14:
                    case 15:
                    case 16:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 2:
                    case 6:
                    case 9:
                    case 13:
                    case 18:
                        walls[1] = true;
                        walls[2] = false;
                        break;

                    case 1:
                    case 5:
                    case 8:
                    case 12:
                    case 17:
                        walls[1] = true;
                        walls[2] = true;
                        break;

                }
                break;

            case 0:
                walls[0] = false;
                walls[1] = false;
                walls[2] = true;
                walls[3] = false;
                switch (coordinates.x)
                {
                    case 0:
                        walls[3] = true;
                        break;

                    case 18:
                        walls[1] = true;
                        break;
                }
                break;

        }
        return walls;
    }

    public List<IntVector2> getEnemyCoordinates()
    {
        EnemyCoordinates.Clear();
        EnemyCoordinates.Add(new IntVector2(1, 1));
        EnemyCoordinates.Add(new IntVector2(2, 3));
        EnemyCoordinates.Add(new IntVector2(10, 2));
        EnemyCoordinates.Add(new IntVector2(10, 4));
        EnemyCoordinates.Add(new IntVector2(1, 7));
        EnemyCoordinates.Add(new IntVector2(7, 10));
        EnemyCoordinates.Add(new IntVector2(10, 12));
        EnemyCoordinates.Add(new IntVector2(17, 12));
        EnemyCoordinates.Add(new IntVector2(15, 13));
        EnemyCoordinates.Add(new IntVector2(3, 14));
        EnemyCoordinates.Add(new IntVector2(7, 14));
        EnemyCoordinates.Add(new IntVector2(15, 15));
        EnemyCoordinates.Add(new IntVector2(0, 16));
        EnemyCoordinates.Add(new IntVector2(8, 19));
        EnemyCoordinates.Add(new IntVector2(4, 21));
        EnemyCoordinates.Add(new IntVector2(18, 21));
        EnemyCoordinates.Add(new IntVector2(2, 25));
        EnemyCoordinates.Add(new IntVector2(1, 26));
        EnemyCoordinates.Add(new IntVector2(12, 29));
        return EnemyCoordinates;
    }

    public List<IntVector2> getKeyCoordinates()
    {
        KeyCoordinates.Clear();
        KeyCoordinates.Add(new IntVector2(3, 0));
        KeyCoordinates.Add(new IntVector2(3, 6));
        KeyCoordinates.Add(new IntVector2(15, 3));
        KeyCoordinates.Add(new IntVector2(12, 11));
        KeyCoordinates.Add(new IntVector2(2, 17));
        KeyCoordinates.Add(new IntVector2(17, 18));
        KeyCoordinates.Add(new IntVector2(10, 20));
        KeyCoordinates.Add(new IntVector2(1, 22));
        KeyCoordinates.Add(new IntVector2(13, 26));
        return KeyCoordinates;
    }

    public List<int[]> getDoorCoordinates()
    {
        DoorCoordinates.Clear();
        DoorCoordinates.Add(new int[] { 2, 6, 3 });
        DoorCoordinates.Add(new int[] { 14, 2, 2 });
        DoorCoordinates.Add(new int[] { 11, 8, 2 });
        DoorCoordinates.Add(new int[] { 12, 12, 0 });
        DoorCoordinates.Add(new int[] { 11, 16, 0 });
        DoorCoordinates.Add(new int[] { 3, 17, 1 });
        DoorCoordinates.Add(new int[] { 18, 19, 0 });
        DoorCoordinates.Add(new int[] { 11, 21, 1 });
        DoorCoordinates.Add(new int[] { 0, 23, 0 });
        DoorCoordinates.Add(new int[] { 14, 25, 1 });
        return DoorCoordinates;


    }
}