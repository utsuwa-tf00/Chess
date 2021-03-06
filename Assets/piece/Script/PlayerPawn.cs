using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPawn : Piece
{
    public override int[,] CanMove(int[,] FloorPieceData)
    {
        var data = new int[8,8];
        int Check = CheckPos(FloorPos[0], FloorPos[1] + 1, FloorPieceData);
        if(Check >= 0)data[FloorPos[0], FloorPos[1] + 1] = 1;
        return data;
    }
    
    public override int[,] PlayerPawnCanMove(int[,] FloorPieceData)
    {
        var data = new int[8,8];
        int Center =PlayerCheckPos(FloorPos[0], FloorPos[1], FloorPieceData);
        int Front = PlayerCheckPos(FloorPos[0], FloorPos[1] + 1, FloorPieceData);
        int Back = PlayerCheckPos(FloorPos[0], FloorPos[1] - 1, FloorPieceData);
        int Right = PlayerCheckPos(FloorPos[0] + 1, FloorPos[1], FloorPieceData);
        int Left = PlayerCheckPos(FloorPos[0] - 1, FloorPos[1], FloorPieceData);
        if(Center >= 0)data[FloorPos[0], FloorPos[1]] = 1;
        if(Front >= 0)data[FloorPos[0], FloorPos[1] + 1] = 1;
        if(Back >= 0)data[FloorPos[0], FloorPos[1] - 1] = 1;
        if(Right >= 0)data[FloorPos[0] + 1, FloorPos[1]] = 1;
        if(Left >= 0)data[FloorPos[0] - 1, FloorPos[1]] = 1;
        return data;
    }
}
