using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumMaze : MonoBehaviour
{
    private bool[] walls = new bool[4];

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
                    case 18:
                        walls[0] = true;
                        walls[1] = true;
                        walls[2] = true;
                        walls[3] = false;
                        break;

                    case 8:
                    case 13:
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
                    case 14:
                    case 15:
                    case 16:
                        walls[1] = false;
                        walls[2] = true;
                        break;

                    case 3:
                    case 5:
                    case 6:
                    case 8:
                    case 9:
                    case 11:
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
                    case 13:
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
}