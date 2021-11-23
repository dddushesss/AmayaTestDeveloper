using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "LevelsData", menuName = "Custom/LevelsData", order = 1)]
    public class LevelsData : ScriptableObject
    {
        [Serializable]
        public struct Difficult
        {
            [SerializeField] private int _row;
            [SerializeField] private int _colum;

            public Difficult(int row, int colum)
            {
                _row = row;
                _colum = colum;
            }

            public int Row => _row;
            public int Colum => _colum;
        }

        [Serializable]
        public struct LevelSet
        {
            [SerializeField] private string desctiption;
            [SerializeField] private StringSpriteDictionary views;

            public LevelSet(string desctiption, StringSpriteDictionary views)
            {
                this.desctiption = desctiption;
                this.views = views;
            }
        }

        [SerializeField] private List<Difficult> _difficult;
        [SerializeField] private List<LevelSet> _levelSets;
        
        
        public List<Difficult> Difficulty => _difficult;
        public List<LevelSet> LevelSets => _levelSets;
    }
}