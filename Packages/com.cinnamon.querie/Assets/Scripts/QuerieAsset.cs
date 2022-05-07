using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Querie
{
   
    [CreateAssetMenu(fileName = "NewQuerieAsset", menuName = "Querie/QuerieAsset")]
    public class QuerieAsset : ScriptableObject
    {
        public QuerieGeneratorBase Generator {get; protected set;}
    }
}