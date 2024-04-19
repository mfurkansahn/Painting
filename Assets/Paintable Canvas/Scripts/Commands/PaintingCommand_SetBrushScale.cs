using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingCommand_SetBrushScale : BasePaintingCommand
{
    float ScaleToSet;

    public PaintingCommand_SetBrushScale(float InScaleToSet, bool InIsUndoable = true) :
        base(InIsUndoable)
    {
        ScaleToSet = InScaleToSet;
    }

    public void Execute(ref float? OutScale)
    {
        OutScale = ScaleToSet;
    }
}
