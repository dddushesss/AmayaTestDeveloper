using UnityEditor;

namespace DefaultNamespace.Editor
{
    [CustomPropertyDrawer(typeof(StringSpriteDictionary))]
    public class AnySerializableDictionaryPropertyDrawer : SerializableDictionaryPropertyDrawer { }
}