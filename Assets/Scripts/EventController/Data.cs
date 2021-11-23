using System.IO;
using DefaultNamespace;
using UnityEngine;
using static DefaultNamespace.LevelsData;
using Object = UnityEngine.Object;

namespace EventController
{
    [CreateAssetMenu(fileName = "Data", menuName = "Custom/Data", order = 0)]
    public class Data : ScriptableObject
    {
       
        [SerializeField] private string _levelsDataPath;
        private LevelsData _levelsData;

        public LevelsData LevelsData
        {
            get
            {
                if (_levelsData == null)
                {
                    _levelsData = Load<LevelsData>("Data/" + _levelsDataPath);
                }

                return _levelsData;
            }
        }
        
        private T Load<T>(string resourcesPath) where T : Object =>
            Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));
    }
}