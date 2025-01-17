using System;
using Godot;
using GodotCustomResource;

[RegisteredType(nameof(BetaResource), "res://Testing/icon.png")]
public class BetaResource : Resource
{
    public BetaResource() { }

    public BetaResource(float[] floatArrayField, float floatField, string textField, string textField2)
    {
        FloatArrayField = floatArrayField;
        FloatField = floatField;
        TextField = textField;
        TextField2 = textField2;
    }

    [Export]
    public float[] FloatArrayField { get; set; } = Array.Empty<float>();
    [Export]
    public float FloatField { get; set; } = 0;
    [Export]
    public string TextField { get; set; } = "";
    [Export]
    public string TextField2 { get; set; } = "";

    public override string ToString()
    {
        return $"Beta: [ {string.Join(", ", FloatArrayField)} | {FloatField} | {TextField} | {TextField2} ]";
    }
}
