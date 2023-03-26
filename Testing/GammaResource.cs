using System;
using Godot;

public class GammaResource : Resource
{
    public GammaResource() { }

    public GammaResource(BetaResource[] betaArray, string textField)
    {
        BetaArray = betaArray;
        TextField = textField;
    }

    [Export]
    public BetaResource[] BetaArray { get; set; } = Array.Empty<BetaResource>();
    [Export]
    public string TextField { get; set; } = "";

    public override string ToString()
    {
        return $"Gamma: [ {string.Join<BetaResource>(", ", BetaArray)} | {TextField} ]";
    }
}
