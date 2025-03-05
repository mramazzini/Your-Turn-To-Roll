namespace YourTurnToRoll.Core.Attributes;

[AttributeUsage(AttributeTargets.Interface)]
public class EnumTypeAttribute : Attribute
{
    public EnumTypeAttribute(Type enumType)
    {
        if (!enumType.IsEnum)
            throw new ArgumentException($"{enumType.Name} must be an enum type.");

        EnumType = enumType;
    }

    public Type EnumType { get; }
}