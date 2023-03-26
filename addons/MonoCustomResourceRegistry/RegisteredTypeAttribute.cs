using System;

namespace MonoCustomResourceRegistry;

[AttributeUsage(AttributeTargets.Class)]
public class RegisteredTypeAttribute : Attribute
{
	public string name;
	public string iconPath;
	public string baseType;

	public RegisteredTypeAttribute(string name, string iconPath = "", string baseType = "")
	{
		this.name = name;
		this.iconPath = iconPath;
		this.baseType = baseType;
	}
}
