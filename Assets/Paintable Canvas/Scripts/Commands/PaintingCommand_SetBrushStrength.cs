using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingCommand_SetBrushStrength : BasePaintingCommand
{
    float StrengthToSet;

    public PaintingCommand_SetBrushStrength(float InStrengthToSet, bool InIsUndoable = true) :
        base(InIsUndoable)
    {
        StrengthToSet = InStrengthToSet;
    }

    public void Execute(ref float? OutStrength)
    {
        OutStrength = StrengthToSet;
    }
}
