using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpriteAnemationConfig", menuName = "Config/SpriteAnemationConfig", order = 1)]

public class SpriteAnimationConfig : ScriptableObject
{
    [SerializeField] private List<SpriteSequence> _sequences;

    public List<SpriteSequence> Sequences => _sequences;
}
